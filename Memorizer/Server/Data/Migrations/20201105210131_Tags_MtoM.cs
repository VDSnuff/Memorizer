using Microsoft.EntityFrameworkCore.Migrations;

namespace Memorizer.Server.Data.Migrations
{
    public partial class Tags_MtoM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_StudyingEntityTexts_StudyingEntityTextId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_StudyingEntityWords_StudyingEntityWordId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_StudyingEntityTextId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_StudyingEntityWordId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "StudyingEntityTextId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "StudyingEntityWordId",
                table: "Tags");

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "StudyingEntityWords",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TagName",
                table: "StudyingEntityTexts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudyingEntityTextTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyingEntityTextId = table.Column<int>(nullable: false),
                    TagId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingEntityTextTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyingEntityTextTags_StudyingEntityTexts_StudyingEntityTextId",
                        column: x => x.StudyingEntityTextId,
                        principalTable: "StudyingEntityTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyingEntityTextTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyingEntityWordTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudyingEntityWordId = table.Column<int>(nullable: false),
                    TagId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyingEntityWordTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyingEntityWordTags_StudyingEntityWords_StudyingEntityWordId",
                        column: x => x.StudyingEntityWordId,
                        principalTable: "StudyingEntityWords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyingEntityWordTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWords_TagName",
                table: "StudyingEntityWords",
                column: "TagName");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTexts_TagName",
                table: "StudyingEntityTexts",
                column: "TagName");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTextTags_StudyingEntityTextId",
                table: "StudyingEntityTextTags",
                column: "StudyingEntityTextId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityTextTags_TagId",
                table: "StudyingEntityTextTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWordTags_StudyingEntityWordId",
                table: "StudyingEntityWordTags",
                column: "StudyingEntityWordId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyingEntityWordTags_TagId",
                table: "StudyingEntityWordTags",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudyingEntityTexts_Tags_TagName",
                table: "StudyingEntityTexts",
                column: "TagName",
                principalTable: "Tags",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudyingEntityWords_Tags_TagName",
                table: "StudyingEntityWords",
                column: "TagName",
                principalTable: "Tags",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudyingEntityTexts_Tags_TagName",
                table: "StudyingEntityTexts");

            migrationBuilder.DropForeignKey(
                name: "FK_StudyingEntityWords_Tags_TagName",
                table: "StudyingEntityWords");

            migrationBuilder.DropTable(
                name: "StudyingEntityTextTags");

            migrationBuilder.DropTable(
                name: "StudyingEntityWordTags");

            migrationBuilder.DropIndex(
                name: "IX_StudyingEntityWords_TagName",
                table: "StudyingEntityWords");

            migrationBuilder.DropIndex(
                name: "IX_StudyingEntityTexts_TagName",
                table: "StudyingEntityTexts");

            migrationBuilder.DropColumn(
                name: "TagName",
                table: "StudyingEntityWords");

            migrationBuilder.DropColumn(
                name: "TagName",
                table: "StudyingEntityTexts");

            migrationBuilder.AddColumn<int>(
                name: "StudyingEntityTextId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudyingEntityWordId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tags_StudyingEntityTextId",
                table: "Tags",
                column: "StudyingEntityTextId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_StudyingEntityWordId",
                table: "Tags",
                column: "StudyingEntityWordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_StudyingEntityTexts_StudyingEntityTextId",
                table: "Tags",
                column: "StudyingEntityTextId",
                principalTable: "StudyingEntityTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_StudyingEntityWords_StudyingEntityWordId",
                table: "Tags",
                column: "StudyingEntityWordId",
                principalTable: "StudyingEntityWords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
