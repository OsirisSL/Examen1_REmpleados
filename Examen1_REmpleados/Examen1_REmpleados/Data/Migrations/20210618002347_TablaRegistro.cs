using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen1_REmpleados.Data.Migrations
{
    public partial class TablaRegistro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    RegistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistApodo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistDireccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistCPostal = table.Column<int>(type: "int", nullable: false),
                    RegistTelefono = table.Column<int>(type: "int", nullable: false),
                    RegistCelular = table.Column<int>(type: "int", nullable: false),
                    RegistFax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistObsrvaciones = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.RegistId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}
