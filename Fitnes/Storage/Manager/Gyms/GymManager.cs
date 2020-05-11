using Fitnes.Storage;
using Fitnes.Storage.Manager.Gyms;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Gyms {
    public class GymManager : IGymManager {
        private readonly FitnesDbContext context;
        public GymManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }
        public async void AddGym(CreateOrUpdateGymRequest request) {
            var gym = new Gym {
                GymId = context.Gyms.LastOrDefault().GymId++,
                Name = request.Name
            };
            foreach (var elem in request.MachinesName) {
                var GymMachine = new GymTrainingMachine {
                    GymId = gym.GymId,
                    TrainingMachineId = context.TrainingMachines.Where(c => c.Name == elem).FirstOrDefault().TrainingMachineId
                };
                await context.GymTrainingMachines.AddAsync(GymMachine);
            }
            await context.Gyms.AddAsync(gym);
            await context.SaveChangesAsync();
        }
        public async Task<List<KeyValuePair<bool, string>>> CreateListWithTrainingMachines(int? id=null) {
            var list = new List<KeyValuePair<bool, string>>();
            if (id != null) {
                var tmp = await context.GymTrainingMachines.Where(c => c.GymId == id).ToListAsync();
                var Names = new List<string>();
                tmp.ForEach(elem => Names.Add(context.TrainingMachines.Find(elem.TrainingMachineId).Name));
                foreach (var elem in context.TrainingMachines) {
                    list.Add(new KeyValuePair<bool, string>(Names.Contains(elem.Name), elem.Name));
                }
            } else {
                foreach (var elem in context.TrainingMachines) {
                    list.Add(new KeyValuePair<bool, string>(false, elem.Name));
                }
            }
            return list;
        }

        public void DeleteGym(int id) {
            var GymMachines = context.GymTrainingMachines.Where(c => c.GymId == id).ToList();
            foreach (var elem in GymMachines) {
                context.GymTrainingMachines.Remove(elem);
            }
            var emp = context.Employees.Where(c => c.GymId == id).ToList();
            foreach (var elem in emp) {
                elem.GymId = null;
            }
            context.Gyms.Remove(context.Gyms.Find(id));
            context.SaveChanges();
        }
        public async Task<IReadOnlyCollection<GymWithTrainingMachines>> GetAll() {
            var tmp = await context.Gyms.Include(c => c).ToListAsync();
            List<GymWithTrainingMachines> listWithNames = new List<GymWithTrainingMachines>();
            foreach (var elem in tmp) {
                List<string> MachineNames = new List<string>();
                await context.GymTrainingMachines.Where(c => c.GymId == elem.GymId).
                    ForEachAsync(elem => MachineNames.Add(context.TrainingMachines.Find(elem.TrainingMachineId).Name));
                listWithNames.Add(new GymWithTrainingMachines() {
                    Id = elem.GymId,
                    Name = elem.Name,
                    Address = elem.Address,
                    MachineNames = MachineNames
                });
            }
            return listWithNames;
        }
        public async Task<Gym> GetGymById(int id) {
            var entity = await context.Gyms.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async void UpdateGym(int id, CreateOrUpdateGymRequest request) {
            var gym = await context.Gyms.FindAsync(id);
            gym.Name = request.Name;
            gym.Address = request.Address;
            this.DeleteGym(id);
            foreach (var elem in request.MachinesName) {
                var GymMachine = new GymTrainingMachine {
                    GymId = gym.GymId,
                    TrainingMachineId = context.TrainingMachines.Where(c => c.Name == elem).FirstOrDefault().TrainingMachineId
                };
                await context.GymTrainingMachines.AddAsync(GymMachine);
            }
            await context.Gyms.AddAsync(gym);
            await context.SaveChangesAsync();
        }
    }
}
