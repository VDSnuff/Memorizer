using Microsoft.EntityFrameworkCore.Migrations;

namespace Memorizer.Server.Data.Migrations
{
    public partial class Languagesandcountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "TranslationLanguage",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Texts");

            migrationBuilder.AddColumn<string>(
                name: "LanguageCode",
                table: "Words",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationLanguageCode",
                table: "Words",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LanguageCode",
                table: "Texts",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Words_LanguageCode",
                table: "Words",
                column: "LanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Words_TranslationLanguageCode",
                table: "Words",
                column: "TranslationLanguageCode");

            migrationBuilder.CreateIndex(
                name: "IX_Texts_LanguageCode",
                table: "Texts",
                column: "LanguageCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_Languages_LanguageCode",
                table: "Texts",
                column: "LanguageCode",
                principalTable: "Languages",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Languages_LanguageCode",
                table: "Words",
                column: "LanguageCode",
                principalTable: "Languages",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Words_Languages_TranslationLanguageCode",
                table: "Words",
                column: "TranslationLanguageCode",
                principalTable: "Languages",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_Languages_LanguageCode",
                table: "Texts");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Languages_LanguageCode",
                table: "Words");

            migrationBuilder.DropForeignKey(
                name: "FK_Words_Languages_TranslationLanguageCode",
                table: "Words");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Words_LanguageCode",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Words_TranslationLanguageCode",
                table: "Words");

            migrationBuilder.DropIndex(
                name: "IX_Texts_LanguageCode",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "LanguageCode",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "TranslationLanguageCode",
                table: "Words");

            migrationBuilder.DropColumn(
                name: "LanguageCode",
                table: "Texts");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranslationLanguage",
                table: "Words",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Texts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
