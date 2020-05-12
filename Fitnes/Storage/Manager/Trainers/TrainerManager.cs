using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Trainers {
    public class TrainerManager : ITrainerManager {
        private readonly FitnesDbContext context;
        public TrainerManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }
        public async Task AddTrainer(CreateOrUpdateTrainerRequest request) {
            var tr = new Trainer {
                ProgramWorkoutId = request.ProgramWorkoutId,
                EmployeeId = request.EmployeeId
            };
            await context.Trainers.AddAsync(tr);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTrainer(int id) {
            context.Clients.Where(c => c.TrainerId == id).ToList().ForEach(elem => elem.TrainerId = null);
            context.Trainers.Remove(context.Trainers.Find(id));
            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<TrainerWithPWAndEmployeeName>> GetAll() {
            var tmp = await context.Trainers.Include(c => c).ToListAsync();
            List<TrainerWithPWAndEmployeeName> listWithNames = new List<TrainerWithPWAndEmployeeName>();
            foreach (var elem in tmp) {
                listWithNames.Add(new TrainerWithPWAndEmployeeName() {
                    Id = elem.TrainerId,
                    Name = context.Employees.Find(context.Trainers.Find(elem.TrainerId).EmployeeId).Name,
                    ProgramWorkoutName = elem.ProgramWorkoutId != null ? context.ProgramWorkouts.Find(elem.ProgramWorkoutId).Name : null
                });
            }
            return listWithNames;
        }

        public async Task<Trainer> GetTrainerById(int id) {
            var entity = await context.Trainers.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdateTrainer(int id, CreateOrUpdateTrainerRequest request) {
            var emp = context.Employees.Find(request.EmployeeId).PositionId = 2;
            var pw = await context.Trainers.FindAsync(id);
            pw.EmployeeId = request.EmployeeId;
            pw.ProgramWorkoutId = request.ProgramWorkoutId != 0 ? request.ProgramWorkoutId : null;
            await context.SaveChangesAsync();
        }
        public async Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateTrainer() {
            List<KeyValuePair<int, string>> listProgramWorkouts = new List<KeyValuePair<int, string>>();
            await context.ProgramWorkouts.ForEachAsync(elem => listProgramWorkouts.Add(new KeyValuePair<int, string>(elem.ProgramWorkoutId, elem.Name)));
            List<KeyValuePair<int, string>> listEmployees = new List<KeyValuePair<int, string>>();
            foreach (var elem in context.Employees) {
                if (elem.PositionId == 2) {
                    listEmployees.Add(new KeyValuePair<int, string>(elem.EmployeeId, elem.Name));
                }
            }
            return (listProgramWorkouts, listEmployees);
        }
    }
}
