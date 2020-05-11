using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Positions {
    public interface IPositionManager {
        public Task<IReadOnlyCollection<Position>> GetAll();
        public Task<Position> GetPositionById(int id);
        public void AddPosition(CreateOrUpdatePositionRequest request);
        public void UpdatePosition(int id, CreateOrUpdatePositionRequest request);
    }
}
