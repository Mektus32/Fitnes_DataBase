using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Authors {
    public interface IAuthorManager {
        public Task<IReadOnlyCollection<Author>> GetAll();
        public Task<Author> GetAuthorById(int id);
        public Task AddAuthor(CreateOrUpdateAuthorRequest request);
        public Task UpdateAuthor(int id, CreateOrUpdateAuthorRequest request);
    }
}
