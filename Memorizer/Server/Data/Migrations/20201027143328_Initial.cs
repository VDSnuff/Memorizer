using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Memorizer.Server.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "StudyingProcesInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepetitionCount = table.Column<int>(nullable: false),
                    LearningStatus = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastRepetition = table.Column<DateTime>(nullable: true),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topic = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    LanguageCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Texts_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(nullable: true),
                    Synonyms = table.Column<string>(nullable: true),
                    Translation = table.Column<string>(nullable: true),
                    Definition = table.Column<string>(nullable: true),
                    AssociatedImage = table.Column<string>(nullable: true),
                    LanguageCode = table.Column<string>(nullable: true),
                    TranslationLanguageCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_Languages_LanguageCode",
                        column: x => x.LanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Words_Languages_TranslationLanguageCode",
                        column: x => x.TranslationLanguageCode,
                        principalTable: "Languages",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyingEntityTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyingDataType = table.Column<string>(nullable: false),
                    StudyingProcesInfoId = table.Column<int>(nullable: true),
                    UserNote = table.Column<string>(nullable: true),
                    TextId = table.Column<int>(nullable: true),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyingDataType = table.Column<string>(nullable: false),
                    StudyingProcesInfoId = table.Column<int>(nullable: true),
                    UserNote = table.Column<string>(nullable: true),
                    WordId = table.Column<int>(nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    StudyingEntityTextId = table.Column<int>(nullable: true),
                    StudyingEntityWordId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Tags_StudyingEntityTexts_StudyingEntityTextId",
                        column: x => x.StudyingEntityTextId,
                        principalTable: "StudyingEntityTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tags_StudyingEntityWords_StudyingEntityWordId",
                        column: x => x.StudyingEntityWordId,
                        principalTable: "StudyingEntityWords",
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

            migrationBuilder.CreateIndex(
                name: "IX_Tags_StudyingEntityTextId",
                table: "Tags",
                column: "StudyingEntityTextId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_StudyingEntityWordId",
                table: "Tags",
                column: "StudyingEntityWordId");

            migrationBuilder.CreateIndex(
                name: "IX_Texts_LanguageCode",
                table: "Texts",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Words_LanguageCode",
                table: "Words",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Words_TranslationLanguageCode",
                table: "Words",
                column: "TranslationLanguageCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Tags");

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

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
