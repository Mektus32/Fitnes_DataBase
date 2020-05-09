using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fitnes.Storage.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gym",
                columns: table => new
                {
                    GymId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym", x => x.GymId);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrainingMachine",
                columns: table => new
                {
                    TrainingMachineId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsForHand = table.Column<bool>(nullable: false),
                    IsForLeg = table.Column<bool>(nullable: false),
                    IsForBack = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingMachine", x => x.TrainingMachineId);
                });

            migrationBuilder.CreateTable(
                name: "ProgramWorkout",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    AuthorId = table.Column<Guid>(nullable: false),
                    Period = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramWorkout", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramWorkout_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PositionId = table.Column<Guid>(nullable: false),
                    Experience = table.Column<double>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    GymId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "GymId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GymTrainingMachine",
                columns: table => new
                {
                    GymId = table.Column<Guid>(nullable: false),
                    TrainingMachineId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GymTrainingMachine", x => new { x.GymId, x.TrainingMachineId });
                    table.ForeignKey(
                        name: "FK_GymTrainingMachine_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "GymId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GymTrainingMachine_TrainingMachine_TrainingMachineId",
                        column: x => x.TrainingMachineId,
                        principalTable: "TrainingMachine",
                        principalColumn: "TrainingMachineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    ProgramWorkoutId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscription_ProgramWorkout_ProgramWorkoutId",
                        column: x => x.ProgramWorkoutId,
                        principalTable: "ProgramWorkout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProgramWorkoutId = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainer_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainer_ProgramWorkout_ProgramWorkoutId",
                        column: x => x.ProgramWorkoutId,
                        principalTable: "ProgramWorkout",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    TrainerId = table.Column<Guid>(nullable: true),
                    Subsription = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Subscription_Subsription",
                        column: x => x.Subsription,
                        principalTable: "Subscription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Trainer_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Subsription",
                table: "Client",
                column: "Subsription");

            migrationBuilder.CreateIndex(
                name: "IX_Client_TrainerId",
                table: "Client",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_GymId",
                table: "Employee",
                column: "GymId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_GymTrainingMachine_TrainingMachineId",
                table: "GymTrainingMachine",
                column: "TrainingMachineId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramWorkout_AuthorId",
                table: "ProgramWorkout",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_ProgramWorkoutId",
                table: "Subscription",
                column: "ProgramWorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_EmployeeId",
                table: "Trainer",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_ProgramWorkoutId",
                table: "Trainer",
                column: "ProgramWorkoutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "GymTrainingMachine");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "TrainingMachine");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ProgramWorkout");

            migrationBuilder.DropTable(
                name: "Gym");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
