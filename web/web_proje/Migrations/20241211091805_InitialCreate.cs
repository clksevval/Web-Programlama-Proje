using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web_proje.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acil_Durumlar",
                columns: table => new
                {
                    Acil_DurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acil_Durumlar", x => x.Acil_DurumId);
                });

            migrationBuilder.CreateTable(
                name: "Asistanlar",
                columns: table => new
                {
                    AsistanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsistanAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsistanSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AsistanYas = table.Column<int>(type: "int", nullable: false),
                    AsistanTel = table.Column<long>(type: "bigint", nullable: false),
                    AsistanMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nobet_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistanlar", x => x.AsistanId);
                });

            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    BolumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hasta_Sayisi = table.Column<int>(type: "int", nullable: false),
                    Bos_Yatak_Sayisi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.BolumId);
                });

            migrationBuilder.CreateTable(
                name: "Hocalar",
                columns: table => new
                {
                    HocaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocaSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HocaYas = table.Column<int>(type: "int", nullable: false),
                    HocaTel = table.Column<long>(type: "bigint", nullable: false),
                    HocaMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocalar", x => x.HocaId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciSifre = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Nobetler",
                columns: table => new
                {
                    NobetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsistanId = table.Column<int>(type: "int", nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: false),
                    Nobet_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nobetler", x => x.NobetId);
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    RandevuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HocaId = table.Column<int>(type: "int", nullable: false),
                    AsistanId = table.Column<int>(type: "int", nullable: false),
                    Randevu_Tarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.RandevuId);
                });

            migrationBuilder.CreateTable(
                name: "Roller",
                columns: table => new
                {
                    RolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RolAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roller", x => x.RolId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acil_Durumlar");

            migrationBuilder.DropTable(
                name: "Asistanlar");

            migrationBuilder.DropTable(
                name: "Bolumler");

            migrationBuilder.DropTable(
                name: "Hocalar");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Nobetler");

            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "Roller");
        }
    }
}
