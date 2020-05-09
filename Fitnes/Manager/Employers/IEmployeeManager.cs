using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Employers {
    interface IEmployeeManager {
        Task<Employee> AddEmployee(CreateOrUpdateEmployeeRequest request);

        Task<IReadOnlyCollection<Employee>> GetAll();
        Task<Employee> UpdateEmployee(Guid id, CreateOrUpdateEmployeeRequest request);
        Task<Employee> GetById(Guid id);
    }
}
