using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SellPoint.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    IdEntidad = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    TipoEntidad = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    TipoDocumento = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    NumeroDocumento = table.Column<long>(type: "bigint", maxLength: 15, nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    URLPaginaWeb = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    URLFacebook = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    URLInstagram = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    URLTwitter = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    URLTiktok = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: true),
                    CodigoPostal = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CoordenadasGps = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LimiteCredito = table.Column<int>(type: "int", maxLength: 15, nullable: false),
                    UserNameEntidad = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PassworEntidad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RolUserEntidad = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NoEliminable = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.IdEntidad);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entidades");
        }
    }
}
