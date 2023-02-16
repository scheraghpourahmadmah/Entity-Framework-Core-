using Microsoft.EntityFrameworkCore.Migrations;

namespace WiziLib_DataAccess.Migrations
{
    public partial class AddOneToManyBookAndPublisherRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetail_CBookDetail_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CBookDetail_Id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "CBookDetail_Id",
                table: "Books",
                newName: "Publisher_Id");

            migrationBuilder.AddColumn<int>(
                name: "BookDetail_Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetail_Id",
                table: "Books",
                column: "BookDetail_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_Publisher_Id",
                table: "Books",
                column: "Publisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetail_BookDetail_Id",
                table: "Books",
                column: "BookDetail_Id",
                principalTable: "BookDetail",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_Publisher_Id",
                table: "Books",
                column: "Publisher_Id",
                principalTable: "Publishers",
                principalColumn: "Publisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetail_BookDetail_Id",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_Publisher_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetail_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_Publisher_Id",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookDetail_Id",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Publisher_Id",
                table: "Books",
                newName: "CBookDetail_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CBookDetail_Id",
                table: "Books",
                column: "CBookDetail_Id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetail_CBookDetail_Id",
                table: "Books",
                column: "CBookDetail_Id",
                principalTable: "BookDetail",
                principalColumn: "BookDetail_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
