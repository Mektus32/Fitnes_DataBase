using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Authors {
    public class AuthorManager : IAuthorManager {
        private readonly FitnesDbContext context;
        public AuthorManager(FitnesDbContext fitnesDbContext) {
            this.context = fitnesDbContext;
        }

        public async void AddAuthor(CreateOrUpdateAuthorRequest request) {
            var auth = new Author {
                AuthorId = context.Authors.LastOrDefault().AuthorId++,
                Name = request.Name
            };
            await context.Authors.AddAsync(auth);
            await context.SaveChangesAsync();
        }

        public void DeleteAuthor(int id) {
            context.Authors.Remove(context.Authors.Find(id));//TODO check exception
            context.SaveChanges();
        }

        public async Task<IReadOnlyCollection<Author>> GetAll() {
            return await context.Authors.Include(c => c).ToListAsync();
        }

        public async Task<Author> GetAuthorById(int id) {
            var entity = await context.Authors.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }

        public async void UpdateAuthor(int id, CreateOrUpdateAuthorRequest request) {
            var auth = await context.Authors.FindAsync(id);//TODO check exception
            auth.Name = request.Name;
            await context.SaveChangesAsync();
        }
    }
}
