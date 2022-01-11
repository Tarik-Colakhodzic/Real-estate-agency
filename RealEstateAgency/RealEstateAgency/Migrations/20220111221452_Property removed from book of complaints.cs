using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgency.Migrations
{
    public partial class Propertyremovedfrombookofcomplaints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints");

            migrationBuilder.DropIndex(
                name: "IX_BookOfComplaints_PropertyId",
                table: "BookOfComplaints");

            migrationBuilder.DropColumn(
                name: "PropertyId",
                table: "BookOfComplaints");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PropertyId",
                table: "BookOfComplaints",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookOfComplaints_PropertyId",
                table: "BookOfComplaints",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
