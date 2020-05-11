using Fitnes.Storage;
using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
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

        public async void AddEmployee(CreateOrUpdateEmployeeRequest request) {
            var emp = new Employee {
                EmployeeId = context.Employees.LastOrDefault().EmployeeId++,
                Name = request.Name,
                PositionId = request.PositionId,
                Experience = request.Experience,
                Salary = request.Salary,
                GymId = request.GymId
            };
            await context.Employees.AddAsync(emp);
            await context.SaveChangesAsync();
        }
        public void DeleteEmployee(int id) {
            context.Employees.Remove(context.Employees.Find(id));
            context.SaveChanges();
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
                    GymName = context.Employees.Find(elem.GymId).Name
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
        public async void UpdateEmployee(int id, CreateOrUpdateEmployeeRequest request) {
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
    }
}
