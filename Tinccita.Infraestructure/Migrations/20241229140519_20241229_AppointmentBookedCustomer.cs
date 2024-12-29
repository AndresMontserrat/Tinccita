using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tinccita.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class _20241229_AppointmentBookedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentBookedCustomer");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "AppointmentsBooked",
                newName: "Time_Start");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "AppointmentsAvailable",
                newName: "Time_Start");

            migrationBuilder.AddColumn<int>(
                name: "Minutes",
                table: "Services",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname1",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname2",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time_End",
                table: "AppointmentsBooked",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AddColumn<TimeOnly>(
                name: "Time_End",
                table: "AppointmentsAvailable",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.CreateTable(
                name: "AppointmentsBookedCustomers",
                columns: table => new
                {
                    AppointmentBookedId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomerGuid = table.Column<Guid>(type: "TEXT", nullable: false),
                    Details = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentsBookedCustomers", x => new { x.AppointmentBookedId, x.CustomerGuid });
                    table.ForeignKey(
                        name: "FK_AppointmentsBookedCustomers_AppointmentsBooked_AppointmentBookedId",
                        column: x => x.AppointmentBookedId,
                        principalTable: "AppointmentsBooked",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentsBookedCustomers_Customers_CustomerGuid",
                        column: x => x.CustomerGuid,
                        principalTable: "Customers",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentsBookedCustomers_CustomerGuid",
                table: "AppointmentsBookedCustomers",
                column: "CustomerGuid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentsBookedCustomers");

            migrationBuilder.DropColumn(
                name: "Minutes",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Surname1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Surname2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Time_End",
                table: "AppointmentsBooked");

            migrationBuilder.DropColumn(
                name: "Time_End",
                table: "AppointmentsAvailable");

            migrationBuilder.RenameColumn(
                name: "Time_Start",
                table: "AppointmentsBooked",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Time_Start",
                table: "AppointmentsAvailable",
                newName: "Time");

            migrationBuilder.CreateTable(
                name: "AppointmentBookedCustomer",
                columns: table => new
                {
                    AppointmentsBookedId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CustomersGuid = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentBookedCustomer", x => new { x.AppointmentsBookedId, x.CustomersGuid });
                    table.ForeignKey(
                        name: "FK_AppointmentBookedCustomer_AppointmentsBooked_AppointmentsBookedId",
                        column: x => x.AppointmentsBookedId,
                        principalTable: "AppointmentsBooked",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentBookedCustomer_Customers_CustomersGuid",
                        column: x => x.CustomersGuid,
                        principalTable: "Customers",
                        principalColumn: "Guid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentBookedCustomer_CustomersGuid",
                table: "AppointmentBookedCustomer",
                column: "CustomersGuid");
        }
    }
}
