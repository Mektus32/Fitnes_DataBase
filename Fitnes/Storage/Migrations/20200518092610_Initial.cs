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
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Gym",
                columns: table => new
                {
                    GymId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gym", x => x.GymId);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Time = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.SubscriptionId);
                });

            migrationBuilder.CreateTable(
                name: "TrainingMachine",
                columns: table => new
                {
                    TrainingMachineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
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
                    ProgramWorkoutId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    Period = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramWorkout", x => x.ProgramWorkoutId);
                    table.ForeignKey(
                        name: "FK_ProgramWorkout_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    PositionId = table.Column<int>(nullable: true),
                    Experience = table.Column<int>(nullable: false),
                    Salary = table.Column<int>(nullable: false),
                    GymId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Gym_GymId",
                        column: x => x.GymId,
                        principalTable: "Gym",
                        principalColumn: "GymId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Position",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GymTrainingMachine",
                columns: table => new
                {
                    GymId = table.Column<int>(nullable: false),
                    TrainingMachineId = table.Column<int>(nullable: false)
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
                name: "Trainer",
                columns: table => new
                {
                    TrainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramWorkoutId = table.Column<int>(nullable: true),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.TrainerId);
                    table.ForeignKey(
                        name: "FK_Trainer_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainer_ProgramWorkout_ProgramWorkoutId",
                        column: x => x.ProgramWorkoutId,
                        principalTable: "ProgramWorkout",
                        principalColumn: "ProgramWorkoutId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    TrainerId = table.Column<int>(nullable: true),
                    SubscriptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "SubscriptionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Client_Trainer_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainer",
                        principalColumn: "TrainerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Name" },
                values: new object[,]
                {
                    { 1, "Anton" },
                    { 2, "Ivan" }
                });

            migrationBuilder.InsertData(
                table: "Gym",
                columns: new[] { "GymId", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Stud", "Super 1" },
                    { 2, "BMar", "Best 1" }
                });

            migrationBuilder.InsertData(
                table: "Position",
                columns: new[] { "PositionId", "Name" },
                values: new object[,]
                {
                    { 1, "Cleaner" },
                    { 2, "Trainer" },
                    { 3, "Security" }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "SubscriptionId", "Name", "Price", "Time" },
                values: new object[,]
                {
                    { 1, "Super Subscription", 12, 12.0 },
                    { 2, "Exelent Subscription", 6, 5.0 },
                    { 3, "Best Subscription", 3, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "TrainingMachine",
                columns: new[] { "TrainingMachineId", "IsForBack", "IsForHand", "IsForLeg", "Name" },
                values: new object[,]
                {
                    { 1, false, true, false, "Super Hand" },
                    { 2, false, false, true, "Super Leg" },
                    { 3, true, false, false, "Super Back" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "Experience", "GymId", "Name", "PositionId", "Salary" },
                values: new object[,]
                {
                    { 1, 0, 1, "Ivan", 1, 20 },
                    { 4, 0, 2, "Kate", 1, 20 },
                    { 2, 2, 1, "Vadim", 2, 50 },
                    { 5, 2, 2, "Liza", 2, 50 },
                    { 3, 5, 1, "Anton", 3, 30 },
                    { 6, 5, 2, "Dasha", 3, 30 }
                });

            migrationBuilder.InsertData(
                table: "GymTrainingMachine",
                columns: new[] { "GymId", "TrainingMachineId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ProgramWorkout",
                columns: new[] { "ProgramWorkoutId", "AuthorId", "Name", "Period" },
                values: new object[,]
                {
                    { 1, 1, "Super Program", 10.0 },
                    { 3, 1, "Best Program", 3.0 },
                    { 2, 2, "Exelent Program", 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "TrainerId", "EmployeeId", "ProgramWorkoutId" },
                values: new object[] { 2, 4, 2 });

            migrationBuilder.InsertData(
                table: "Trainer",
                columns: new[] { "TrainerId", "EmployeeId", "ProgramWorkoutId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "LastName", "Name", "SubscriptionId", "TrainerId" },
                values: new object[,]
                {
                    { 2, "Islanova", "Ayka", 2, 2 },
                    { 1, "Tarasyan", "Mike", 1, 1 },
                    { 3, "Sharshan", "Mike", 3, 1 },
                    { 4, "Konopkin", "Dima", 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_SubscriptionId",
                table: "Client",
                column: "SubscriptionId");

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
                name: "IX_Trainer_EmployeeId",
                table: "Trainer",
                column: "EmployeeId",
                unique: true);

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
