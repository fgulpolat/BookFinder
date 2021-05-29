using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPublisher_Book_BooksId",
                table: "BookPublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPublisher_Publisher_PublishersId",
                table: "BookPublisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPublisher",
                table: "BookPublisher");

            migrationBuilder.DropIndex(
                name: "IX_BookPublisher_PublishersId",
                table: "BookPublisher");

            migrationBuilder.DropColumn(
                name: "YearOfPrinting",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "PublishersId",
                table: "BookPublisher",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BooksId",
                table: "BookPublisher",
                newName: "BookId");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "BookPublisher",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BookPublisher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BookPublisher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "BookDetailId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPublisher",
                table: "BookPublisher",
                columns: new[] { "PublisherId", "BookId" });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NuberOfPages = table.Column<int>(type: "int", nullable: false),
                    YearOfPrinting = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookPublisher_BookId",
                table: "BookPublisher",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_BookDetailId",
                table: "Book",
                column: "BookDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_BookDetails_BookDetailId",
                table: "Book",
                column: "BookDetailId",
                principalTable: "BookDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublisher_Book_BookId",
                table: "BookPublisher",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublisher_Publisher_PublisherId",
                table: "BookPublisher",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_BookDetails_BookDetailId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPublisher_Book_BookId",
                table: "BookPublisher");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPublisher_Publisher_PublisherId",
                table: "BookPublisher");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookPublisher",
                table: "BookPublisher");

            migrationBuilder.DropIndex(
                name: "IX_BookPublisher_BookId",
                table: "BookPublisher");

            migrationBuilder.DropIndex(
                name: "IX_Book_BookDetailId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "BookPublisher");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BookPublisher");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BookPublisher");

            migrationBuilder.DropColumn(
                name: "BookDetailId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BookPublisher",
                newName: "PublishersId");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookPublisher",
                newName: "BooksId");

            migrationBuilder.AddColumn<DateTime>(
                name: "YearOfPrinting",
                table: "Book",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookPublisher",
                table: "BookPublisher",
                columns: new[] { "BooksId", "PublishersId" });

            migrationBuilder.CreateIndex(
                name: "IX_BookPublisher_PublishersId",
                table: "BookPublisher",
                column: "PublishersId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublisher_Book_BooksId",
                table: "BookPublisher",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPublisher_Publisher_PublishersId",
                table: "BookPublisher",
                column: "PublishersId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
