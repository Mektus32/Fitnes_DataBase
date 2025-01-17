﻿using Fitnes.Storage.Manager.Authors;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Positions {
    public class PositionManager : IPositionManager {
        private readonly FitnesDbContext context;
        public PositionManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }
        public async Task AddPosition(CreateOrUpdatePositionRequest request) {
            var pos = new Position {
                Name = request.Name
            };
            await context.Positions.AddAsync(pos);
            await context.SaveChangesAsync();
        }
        public async Task<IReadOnlyCollection<Position>> GetAll() {
            return await context.Positions.Include(c => c).ToListAsync();
        }
        public async Task<Position> GetPositionById(int id) {
            var entity = await context.Positions.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdatePosition(int id, CreateOrUpdatePositionRequest request) {
            var pos = await context.Positions.FindAsync(id);//TODO check exception
            pos.Name = request.Name;
            await context.SaveChangesAsync();
        }
    }
}
