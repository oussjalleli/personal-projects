using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    EntrepriseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresseEntreprise = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.EntrepriseId);
                });

            migrationBuilder.CreateTable(
                name: "participants",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailParticipant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_participants", x => x.ParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "Cagnottes",
                columns: table => new
                {
                    CagnotteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SommeDemandée = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    DateLimite = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntrepriseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cagnottes", x => x.CagnotteId);
                    table.ForeignKey(
                        name: "FK_Cagnottes_Entreprises_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprises",
                        principalColumn: "EntrepriseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participation",
                columns: table => new
                {
                    CagnottesCagnotteId = table.Column<int>(type: "int", nullable: false),
                    participantsParticipantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participation", x => new { x.CagnottesCagnotteId, x.participantsParticipantId });
                    table.ForeignKey(
                        name: "FK_Participation_Cagnottes_CagnottesCagnotteId",
                        column: x => x.CagnottesCagnotteId,
                        principalTable: "Cagnottes",
                        principalColumn: "CagnotteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participation_participants_participantsParticipantId",
                        column: x => x.participantsParticipantId,
                        principalTable: "participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participations",
                columns: table => new
                {
                    CagnotteFK = table.Column<int>(type: "int", nullable: false),
                    ParticipantFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participations", x => new { x.ParticipantFK, x.CagnotteFK });
                    table.ForeignKey(
                        name: "FK_Participations_Cagnottes_CagnotteFK",
                        column: x => x.CagnotteFK,
                        principalTable: "Cagnottes",
                        principalColumn: "CagnotteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participations_participants_ParticipantFK",
                        column: x => x.ParticipantFK,
                        principalTable: "participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cagnottes_EntrepriseId",
                table: "Cagnottes",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Participation_participantsParticipantId",
                table: "Participation",
                column: "participantsParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Participations_CagnotteFK",
                table: "Participations",
                column: "CagnotteFK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participation");

            migrationBuilder.DropTable(
                name: "Participations");

            migrationBuilder.DropTable(
                name: "Cagnottes");

            migrationBuilder.DropTable(
                name: "participants");

            migrationBuilder.DropTable(
                name: "Entreprises");
        }
    }
}
