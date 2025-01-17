﻿using Fitnes.Storage;
using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage.Manager.Trainers;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Employers {
    public class EmployeeManager : IEmployeeManager {
        private readonly FitnesDbContext context;
        public EmployeeManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }

        public async Task AddEmployee(CreateOrUpdateEmployeeRequest request) {
            if (request.Experience < 0 || request.Salary <= 0) {
                throw new ArgumentException();
            }
            var emp = new Employee {
                Name = request.Name,
                PositionId = request.PositionId,
                Experience = request.Experience,
                Salary = request.Salary,
                GymId = request.GymId
            };
            await context.Employees.AddAsync(emp);
            await context.SaveChangesAsync();
        }
        public async Task DeleteEmployee(int id) {
            var tr = await context.Trainers.Where(c => c.EmployeeId == id).ToListAsync();
            var man = new TrainerManager(context);
            if (tr.Count != 0)
                await man.DeleteTrainer(tr[0].TrainerId);
            context.Employees.Remove(context.Employees.Find(id));
            await context.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<EmployeeWithPositionAndGymName>> GetAll() {
            var tmp = await context.Employees.Include(c => c).ToListAsync();
            List<EmployeeWithPositionAndGymName> listWithNames = new List<EmployeeWithPositionAndGymName>();
            foreach (var elem in tmp) {
                listWithNames.Add(new EmployeeWithPositionAndGymName() {
                    Id = elem.EmployeeId,
                    Name = elem.Name,
                    PositionName = context.Positions.Find(elem.PositionId).Name,
                    Experience = elem.Experience,
                    Salary = elem.Salary,
                    GymName = elem.GymId != null ? context.Gyms.Find(elem.GymId).Name : null
                });
            }
            return listWithNames;
        }
        public async Task<Employee> GetEmployeeById(int id) {
            var entity = await context.Employees.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdateEmployee(int id, CreateOrUpdateEmployeeRequest request) {
            if (request.Experience < 0 || request.Salary <= 0) {
                throw new ArgumentException();
            }
            if (request.PositionId != 2) {
                var tr = await context.Trainers.Where(c => c.EmployeeId == id).ToListAsync();
                if (tr.Count != 0) {
                    var man = new TrainerManager(context);
                    await man.DeleteTrainer(tr[0].TrainerId);
                }
            }
            var emp = await context.Employees.FindAsync(id);
            emp.Name = request.Name;
            emp.PositionId = request.PositionId;
            emp.Experience = request.Experience;
            emp.Salary = request.Salary;
            emp.GymId = request.GymId;
            await context.SaveChangesAsync();
        }
        public async Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateEmployee() {
            List<KeyValuePair<int, string>> listPositions = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> listGyms = new List<KeyValuePair<int, string>>();
            await context.Positions.ForEachAsync(elem => listPositions.Add(new KeyValuePair<int, string>(elem.PositionId, elem.Name)));
            await context.Gyms.ForEachAsync(elem => listGyms.Add(new KeyValuePair<int, string>(elem.GymId, elem.Name)));
            return (listPositions, listGyms);
        }
        public List<EmployeeWithPositionAndGymName> SearchEmployee(string text, int term) {
            var list = new List<EmployeeWithPositionAndGymName>();
            foreach (var elem in context.Employees) {
                list.Add(new EmployeeWithPositionAndGymName() {
                    Id = elem.EmployeeId,
                    Name = elem.Name,
                    PositionName = context.Positions.Find(elem.PositionId).Name,
                    Experience = elem.Experience,
                    Salary = elem.Salary,
                    GymName = elem.GymId != null ? context.Gyms.Find(elem.GymId).Name : null
                });
            }
            switch (term) {
                case 1: return list.Where(c => c.PositionName.IndexOf(text) >= 0).ToList();
                case 2: return list.Where(c => c.Name.IndexOf(text) >= 0).ToList();
                case 3: return list.Where(c => c.Experience == Convert.ToInt32(text)).ToList();
                case 4: return list.Where(c => c.Salary == Convert.ToInt32(text)).ToList();
                case 5: return list.Where(c => c.GymName.IndexOf(text) >= 0).ToList();
                default: throw new ArgumentNullException();
            }
        }
    }
}
