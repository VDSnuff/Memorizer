using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Memorizer.Server.Data.Migrations
{
    public partial class StudyingEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudyingProcesInfos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RepetitionCount = table.Column<int>(nullable: false),
                    LearningStatus = table.Column<int>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastRepetition = table.Column<DateTime>(nullable: false),
                    NextRepetition = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingProcesInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Topic = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    Synonyms = table.Column<string>(nullable: true),
                    Translation = table.Column<string>(nullable: true),
                    Definition = table.Column<string>(nullable: true),
                    AssociatedImage = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    TranslationLanguage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyingEntityTexts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserNote = table.Column<string>(nullable: true),
                    StudyingDataType = table.Column<int>(nullable: false),
                    TextId = table.Column<string>(nullable: true),
                    StudyingProcesInfoId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingEntityTexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyingEntityTexts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyingEntityTexts_StudyingProcesInfos_StudyingProcesInfoId",
                        column: x => x.StudyingProcesInfoId,
                        principalTable: "StudyingProcesInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyingEntityTexts_Texts_TextId",
                        column: x => x.TextId,
                        principalTable: "Texts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyingEntityWords",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserNote = table.Column<string>(nullable: true),
                    WordId = table.Column<string>(nullable: true),
                    StudyingProcesInfoId = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingEntityWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyingEntityWords_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyingEntityWords_StudyingProcesInfos_StudyingProcesInfoId",
                        column: x => x.StudyingProcesInfoId,
                        principalTable: "StudyingProcesInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyingEntityWords_Words_WordId",
                        column: x => x.WordId,
                        principalTable: "Words",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTexts_ApplicationUserId",
                table: "StudyingEntityTexts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTexts_StudyingProcesInfoId",
                table: "StudyingEntityTexts",
                column: "StudyingProcesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTexts_TextId",
                table: "StudyingEntityTexts",
                column: "TextId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWords_ApplicationUserId",
                table: "StudyingEntityWords",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWords_StudyingProcesInfoId",
                table: "StudyingEntityWords",
                column: "StudyingProcesInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWords_WordId",
                table: "StudyingEntityWords",
                column: "WordId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudyingEntityTexts");

            migrationBuilder.DropTable(
                name: "StudyingEntityWords");

            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "StudyingProcesInfos");

            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
