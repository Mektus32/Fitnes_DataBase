using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage {
    public class FitnesDbContext : DbContext {
        public FitnesDbContext(DbContextOptions<FitnesDbContext> options) : base(options) {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gym> Gyms { get; set; }
        public DbSet<GymTrainingMachine> GymTrainingMachines { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<ProgramWorkout> ProgramWorkouts { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainingMachine> TrainingMachines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<GymTrainingMachine>()
                .HasKey(t => new { t.GymId, t.TrainingMachineId });

            modelBuilder.Entity<GymTrainingMachine>()
                .HasOne(pt => pt.Gym)
                .WithMany(p => p.GymTrainingMachines)
                .HasForeignKey(pt => pt.GymId);

            modelBuilder.Entity<GymTrainingMachine>()
                .HasOne(pt => pt.TrainingMachine)
                .WithMany(t => t.GymTrainingMachines)
                .HasForeignKey(pt => pt.TrainingMachineId);
            modelBuilder.Entity<Client>().HasData(
                new Client[] {
                    new Client { ClientId = Guid.NewGuid(), Name = "Mike", LastName = "Tarasyan", TrainerId = null, SubscriptionId = null }
                });
        }
    }
}
