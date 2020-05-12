using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Employers {
    public interface IEmployeeManager {
        public Task<IReadOnlyCollection<EmployeeWithPositionAndGymName>> GetAll();
        public Task<Employee> GetEmployeeById(int id);
        public Task<(List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>)> CreateListForViewCreateEmployee();
        public Task AddEmployee(CreateOrUpdateEmployeeRequest request);
        public Task UpdateEmployee(int id, CreateOrUpdateEmployeeRequest request);
        public Task DeleteEmployee(int id);
    }
}
