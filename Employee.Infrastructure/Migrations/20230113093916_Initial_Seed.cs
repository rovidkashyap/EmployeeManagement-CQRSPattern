using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee.Infrastructure.Migrations
{
    public partial class Initial_Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Department", "Email", "FirstName", "LastName", "Mobile" },
                values: new object[,]
                {
                    { 1, "HR", "rvd.kashyap@gmail.com", "Rovid", "Kashyap", "9760828296" },
                    { 2, "IT", "dhr.varun@gmail.com", "Dhirendra", "Varun", "8909371977" },
                    { 3, "Administration", "chetan.singh@gmail.com", "Shobit", "Goyal", "9045326030" },
                    { 4, "HR", "lalit.gautam@gmail.com", "Lalit", "Gautam", "9456201030" },
                    { 5, "Sales", "ruchi.cute@gmail.com", "Ruchi", "Khandelwal", "9965112200" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
