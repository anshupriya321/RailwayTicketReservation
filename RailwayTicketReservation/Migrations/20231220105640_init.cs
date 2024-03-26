using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RailwayTicketReservation.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(name: "Passenger_Id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PassengerName = table.Column<string>(name: "Passenger_Name", type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    SeatNo = table.Column<int>(name: "Seat_No", type: "integer", nullable: false),
                    Bookingstatus = table.Column<string>(name: "Booking_status", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "ReserveTickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(name: "Ticket_Id", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FromStation = table.Column<string>(name: "From_Station", type: "text", nullable: false),
                    ToStation = table.Column<string>(name: "To_Station", type: "text", nullable: false),
                    DepartureTime = table.Column<DateOnly>(name: "Departure_Time", type: "date", nullable: false),
                    Return = table.Column<DateOnly>(type: "date", nullable: false),
                    AgeGroup = table.Column<string>(name: "Age_Group", type: "text", nullable: false),
                    SeatAvailability = table.Column<int>(name: "Seat_Availability", type: "integer", nullable: false),
                    SeatNo = table.Column<int>(name: "Seat_No", type: "integer", nullable: false),
                    Payment = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveTickets", x => x.TicketId);
                });

            migrationBuilder.CreateTable(
                name: "SignIn",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignIn", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "trains",
                columns: table => new
                {
                    TrainNo = table.Column<int>(name: "Train_No", type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TrainName = table.Column<string>(name: "Train_Name", type: "text", nullable: false),
                    Time = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trains", x => x.TrainNo);
                });

            migrationBuilder.CreateTable(
                name: "UserRegistration",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(name: "First_Name", type: "text", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "text", nullable: false),
                    MobileNo = table.Column<int>(type: "integer", nullable: false),
                    EmailId = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRegistration", x => x.UserName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropTable(
                name: "ReserveTickets");

            migrationBuilder.DropTable(
                name: "SignIn");

            migrationBuilder.DropTable(
                name: "trains");

            migrationBuilder.DropTable(
                name: "UserRegistration");
        }
    }
}
