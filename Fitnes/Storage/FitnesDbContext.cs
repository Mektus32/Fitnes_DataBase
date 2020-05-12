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
            modelBuilder.Entity<Trainer>()
                .HasIndex(b => b.EmployeeId)
                .IsUnique();
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
                    new Client { ClientId = 1, Name = "Mike", LastName = "Tarasyan", TrainerId = 1, SubscriptionId = 1 },
                    new Client { ClientId = 2, Name = "Ayka", LastName = "Islanova", TrainerId = 2, SubscriptionId = 2 },
                    new Client { ClientId = 3, Name = "Mike", LastName = "Sharshan", TrainerId = null, SubscriptionId = 3 },
                    new Client { ClientId = 4, Name = "Dima", LastName = "Konopkin", TrainerId = 1, SubscriptionId = 1 }
                });
            modelBuilder.Entity<Gym>().HasData(
                new Gym[] {
                    new Gym { GymId = 1, Name = "Super 1", Address = "Stud" },
                    new Gym { GymId = 2, Name = "Best 1", Address = "BMar"}
                });
            modelBuilder.Entity<TrainingMachine>().HasData(
                new TrainingMachine[] {
                    new TrainingMachine {TrainingMachineId = 1, Name = "Super Hand", IsForHand = true, IsForLeg = false, IsForBack = false },
                    new TrainingMachine {TrainingMachineId = 2, Name = "Super Leg", IsForHand = false, IsForLeg = true, IsForBack = false },
                    new TrainingMachine {TrainingMachineId = 3, Name = "Super Back", IsForHand = false, IsForLeg = false, IsForBack = true }
                });
            modelBuilder.Entity<GymTrainingMachine>().HasData(
                new GymTrainingMachine[] {
                    new GymTrainingMachine { GymId = 1, TrainingMachineId = 1 },
                    new GymTrainingMachine { GymId = 1, TrainingMachineId = 2 },
                    new GymTrainingMachine { GymId = 1, TrainingMachineId = 3 },
                    new GymTrainingMachine { GymId = 2, TrainingMachineId = 1 },
                    new GymTrainingMachine { GymId = 2, TrainingMachineId = 2 },
                    new GymTrainingMachine { GymId = 2, TrainingMachineId = 3 }
                });
            modelBuilder.Entity<Employee>().HasData(
                new Employee[] {
                    new Employee { EmployeeId = 1, PositionId = 1, Name = "Ivan", Experience = 0, Salary = 20, GymId = 1 },
                    new Employee { EmployeeId = 2, PositionId = 2, Name = "Vadim", Experience = 2, Salary = 50, GymId = 1 },
                    new Employee { EmployeeId = 3, PositionId = 3, Name = "Anton", Experience = 0.5, Salary = 30, GymId = 1 },
                    new Employee { EmployeeId = 4, PositionId = 1, Name = "Kate", Experience = 0, Salary = 20, GymId = 2 },
                    new Employee { EmployeeId = 5, PositionId = 2, Name = "Liza", Experience = 2, Salary = 50, GymId = 2 },
                    new Employee { EmployeeId = 6, PositionId = 3, Name = "Dasha", Experience = 0.5, Salary = 30, GymId = 2 }
                });
            modelBuilder.Entity<Position>().HasData(
                new Position[] {
                    new Position { PositionId = 1, Name = "Cleaner" },
                    new Position { PositionId = 2, Name = "Trainer" },
                    new Position { PositionId = 3, Name = "Security" }
                });
            modelBuilder.Entity<Trainer>().HasData(
                new Trainer[] {
                    new Trainer { TrainerId = 1, ProgramWorkoutId = 1, EmployeeId = 2 },
                    new Trainer { TrainerId = 2, ProgramWorkoutId = 2, EmployeeId = 4 }
                });
            modelBuilder.Entity<ProgramWorkout>().HasData(
                new ProgramWorkout[] {
                    new ProgramWorkout { ProgramWorkoutId = 1, Name = "Super Program", AuthorId = 1, Period = 10 },
                    new ProgramWorkout { ProgramWorkoutId = 2, Name = "Exelent Program", AuthorId = 2, Period = 5 },
                    new ProgramWorkout { ProgramWorkoutId = 3, Name = "Best Program", AuthorId = 1, Period = 3 }
                });
            modelBuilder.Entity<Author>().HasData(
                new Author[] {
                    new Author { AuthorId = 1, Name = "Anton" },
                    new Author { AuthorId = 2, Name = "Ivan" }
                });
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription[] {
                    new Subscription { SubscriptionId = 1, Name = "Super Subscription", Price = 12, Time = 12 },
                    new Subscription { SubscriptionId = 2, Name = "Exelent Subscription", Price = 6, Time = 5 },
                    new Subscription { SubscriptionId = 3, Name = "Best Subscription", Price = 3, Time = 3 },
                });
        }
    }
}
