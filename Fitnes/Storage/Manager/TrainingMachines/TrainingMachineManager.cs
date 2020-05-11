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
        public async void AddTrainingMachine(CreateOrUpdateTrainingMachineRequest request) {
            var gym = new TrainingMachine {
                TrainingMachineId = context.TrainingMachines.LastOrDefault().TrainingMachineId++,
                Name = request.Name,
                IsForHand = request.IsForHand,
                IsForLeg = request.IsForLeg,
                IsForBack = request.IsForBack
            };
            foreach (var elem in request.GymsName) {
                var GymMachine = new GymTrainingMachine {
                    TrainingMachineId = gym.TrainingMachineId,
                    GymId = context.Gyms.Where(c => c.Name == elem).FirstOrDefault().GymId
                };
                await context.GymTrainingMachines.AddAsync(GymMachine);
            }
            await context.TrainingMachines.AddAsync(gym);
            await context.SaveChangesAsync();
        }
        public async Task<List<KeyValuePair<bool, string>>> CreateListWithGym(int? id = null) {
            var list = new List<KeyValuePair<bool, string>>();
            if (id != null) {
                var tmp = await context.GymTrainingMachines.Where(c => c.TrainingMachineId == id).ToListAsync();
                var Names = new List<string>();
                tmp.ForEach(elem => Names.Add(context.Gyms.Find(elem.GymId).Name));
                foreach (var elem in context.Gyms) {
                    list.Add(new KeyValuePair<bool, string>(Names.Contains(elem.Name), elem.Name));
                }
            }
            else {
                foreach (var elem in context.Gyms) {
                    list.Add(new KeyValuePair<bool, string>(false, elem.Name));
                }
            }
            return list;
        }

        public async void DeleteTrainingMachine(int id) {
            var GymMachines = await context.GymTrainingMachines.Where(c => c.TrainingMachineId == id).ToListAsync();
            foreach (var elem in GymMachines) {
                context.GymTrainingMachines.Remove(elem);
            }
            context.SaveChanges();
        }
        public async Task<IReadOnlyCollection<TrainingMachineWithGym>> GetAll() {
            var tmp = await context.TrainingMachines.Include(c => c).ToListAsync();
            List<TrainingMachineWithGym> listWithNames = new List<TrainingMachineWithGym>();
            foreach (var elem in tmp) {
                List<string> GymNames = new List<string>();
                await context.GymTrainingMachines.Where(c => c.TrainingMachineId == elem.TrainingMachineId).
                    ForEachAsync(elem => GymNames.Add(context.Gyms.Find(elem.GymId).Name));
                listWithNames.Add(new TrainingMachineWithGym() {
                    Id = elem.TrainingMachineId,
                    Name = elem.Name,
                    IsForHand = elem.IsForHand,
                    IsForLeg = elem.IsForLeg,
                    IsForBack = elem.IsForBack,
                    GymNames = GymNames
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
        public async void UpdateTrainingMachine(int id, CreateOrUpdateTrainingMachineRequest request) {
            var gym = await context.TrainingMachines.FindAsync(id);
            gym.Name = request.Name;
            gym.IsForHand = request.IsForHand;
            gym.IsForLeg = request.IsForLeg;
            gym.IsForBack = request.IsForBack;
            this.DeleteTrainingMachine(id);
            foreach (var elem in request.GymsName) {
                var GymMachine = new GymTrainingMachine {
                    TrainingMachineId = gym.TrainingMachineId,
                    GymId = context.Gyms.Where(c => c.Name == elem).FirstOrDefault().GymId
                };
                await context.GymTrainingMachines.AddAsync(GymMachine);
            }
            await context.TrainingMachines.AddAsync(gym);
            await context.SaveChangesAsync();
        }
    }
}
