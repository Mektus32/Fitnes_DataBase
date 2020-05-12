using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.TrainingMachines {
    public class TrainingMachineManager : ITrainingMachineManager {
        private readonly FitnesDbContext context;
        public TrainingMachineManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }
        public async Task AddTrainingMachine(CreateOrUpdateTrainingMachineRequest request) {
            var gym = new TrainingMachine {
                Name = request.Name,
                IsForHand = request.IsForHand,
                IsForLeg = request.IsForLeg,
                IsForBack = request.IsForBack
            };
            await context.TrainingMachines.AddAsync(gym);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTrainingMachine(int id) {
            var GymMachines = await context.GymTrainingMachines.Where(c => c.TrainingMachineId == id).ToListAsync();
            foreach (var elem in GymMachines) {
                context.GymTrainingMachines.Remove(elem);
            }
            context.TrainingMachines.Remove(context.TrainingMachines.Find(id));
            context.SaveChanges();
        }
        public async Task<IReadOnlyCollection<TrainingMachine>> GetAll() {
            var tmp = await context.TrainingMachines.Include(c => c).ToListAsync();
            List<TrainingMachine> listWithNames = new List<TrainingMachine>();
            foreach (var elem in tmp) {
                List<string> GymNames = new List<string>();
                await context.GymTrainingMachines.Where(c => c.TrainingMachineId == elem.TrainingMachineId).
                    ForEachAsync(elem => GymNames.Add(context.Gyms.Find(elem.GymId).Name));
                listWithNames.Add(new TrainingMachine() {
                    TrainingMachineId = elem.TrainingMachineId,
                    Name = elem.Name,
                    IsForHand = elem.IsForHand,
                    IsForLeg = elem.IsForLeg,
                    IsForBack = elem.IsForBack
                });
            }
            return listWithNames;
        }
        public async Task<TrainingMachine> GetTrainingMachineById(int id) {
            var entity = await context.TrainingMachines.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdateTrainingMachine(int id, CreateOrUpdateTrainingMachineRequest request) {
            var gym = await context.TrainingMachines.FindAsync(id);
            gym.Name = request.Name;
            gym.IsForHand = request.IsForHand;
            gym.IsForLeg = request.IsForLeg;
            gym.IsForBack = request.IsForBack;
            var GymMachines = await context.GymTrainingMachines.Where(c => c.TrainingMachineId == id).ToListAsync();
            foreach (var elem in GymMachines) {
                context.GymTrainingMachines.Remove(elem);
            }
            await context.SaveChangesAsync();
        }
    }
}
