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
        public async void AddTrainer(CreateOrUpdateTrainerRequest request) {
            var tr = new Trainer {
                TrainerId = context.Trainers.LastOrDefault().TrainerId++,
                ProgramWorkoutId = request.ProgramWorkoutId,
                EmployeeId = request.EmployeeId
            };
            await context.Trainers.AddAsync(tr);
            await context.SaveChangesAsync();
        }

        public void DeleteTrainer(int id) {
            context.Trainers.Remove(context.Trainers.Find(id));
            context.SaveChanges();
        }

        public async Task<IReadOnlyCollection<TrainerWithPWAndEmployeeName>> GetAll() {
            var tmp = await context.Trainers.Include(c => c).ToListAsync();
            List<TrainerWithPWAndEmployeeName> listWithNames = new List<TrainerWithPWAndEmployeeName>();
            foreach (var elem in tmp) {
                listWithNames.Add(new TrainerWithPWAndEmployeeName() {
                    Id = elem.TrainerId,
                    Name = context.Employees.Find(context.Trainers.Find(elem.TrainerId).EmployeeId).Name,
                    ProgramWorkoutName = context.ProgramWorkouts.Find(elem.ProgramWorkoutId).Name
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
        public async void UpdateTrainer(int id, CreateOrUpdateTrainerRequest request) {
            var pw = await context.Trainers.FindAsync(id);
            pw.EmployeeId = request.EmployeeId;
            pw.ProgramWorkoutId = request.ProgramWorkoutId;
            await context.SaveChangesAsync();
        }
        public async Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateTrainer() {
            List<KeyValuePair<int, string>> listProgramWorkouts = new List<KeyValuePair<int, string>>();
            await context.ProgramWorkouts.ForEachAsync(elem => listProgramWorkouts.Add(new KeyValuePair<int, string>(elem.ProgramWorkoutId, elem.Name)));
            List<KeyValuePair<int, string>> listEmployees = new List<KeyValuePair<int, string>>();
            await context.Employees.ForEachAsync(elem => listProgramWorkouts.Add(new KeyValuePair<int, string>(elem.EmployeeId, elem.Name)));
            return (listProgramWorkouts, listEmployees);
        }
    }
}
