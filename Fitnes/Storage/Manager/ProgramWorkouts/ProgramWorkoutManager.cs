using Fitnes.Storage;
using Fitnes.Storage.Manager.ProgramWorkouts;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.ProgramWorkouts {
    public class ProgramWorkoutManager : IProgramWorkoutManager {
        private readonly FitnesDbContext context;
        public ProgramWorkoutManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }

        public async void AddProgramWorkout(CreateOrUpdateProgramWorkoutRequest request) {
            var pw = new ProgramWorkout {
                ProgramWorkoutId = context.ProgramWorkouts.LastOrDefault().ProgramWorkoutId++,
                Name = request.Name,
                AuthorId = request.AuthorId,
                Period = request.Period
            };
            await context.ProgramWorkouts.AddAsync(pw);
            await context.SaveChangesAsync();
        }

        public void DeleteProgramWorkout(int id) {
            context.ProgramWorkouts.Remove(context.ProgramWorkouts.Find(id));
            context.SaveChanges();
        }

        public async Task<IReadOnlyCollection<ProgramWorkoutWithAuthorName>> GetAll() {
            var tmp = await context.ProgramWorkouts.Include(c => c).ToListAsync();
            List<ProgramWorkoutWithAuthorName> listWithNames = new List<ProgramWorkoutWithAuthorName>();
            foreach (var elem in tmp) {
                listWithNames.Add(new ProgramWorkoutWithAuthorName() {
                    Id = elem.ProgramWorkoutId,
                    Name = elem.Name,
                    AuthorName = context.Authors.Find(elem.AuthorId).Name,
                    Period = elem.Period
                });
            }
            return listWithNames;
        }

        public async Task<ProgramWorkout> GetProgramWorkoutById(int id) {
            var entity = await context.ProgramWorkouts.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async void UpdateProgramWorkout(int id, CreateOrUpdateProgramWorkoutRequest request) {
            var pw = await context.ProgramWorkouts.FindAsync(id);
            pw.Name = request.Name;
            pw.AuthorId = request.AuthorId;
            pw.Period = request.Period;
            await context.SaveChangesAsync();
        }
        public async Task<List<KeyValuePair<int, string>>> CreateListForViewCreateProgramWorkout() {
            List<KeyValuePair<int, string>> listAuthors = new List<KeyValuePair<int, string>>();
            await context.Authors.ForEachAsync(elem => listAuthors.Add(new KeyValuePair<int, string>(elem.AuthorId, elem.Name)));
            return listAuthors;
        }
    }
}
