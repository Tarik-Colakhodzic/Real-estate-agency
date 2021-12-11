using Microsoft.EntityFrameworkCore.Migrations;

namespace RealEstateAgency.Migrations
{
    public partial class FKonbookofcomplaintsmodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookOfComplaints_Agents_AgentId",
                table: "BookOfComplaints");

            migrationBuilder.DropForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "BookOfComplaints",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AgentId",
                table: "BookOfComplaints",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BookOfComplaints_Agents_AgentId",
                table: "BookOfComplaints",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookOfComplaints_Agents_AgentId",
                table: "BookOfComplaints");

            migrationBuilder.DropForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyId",
                table: "BookOfComplaints",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgentId",
                table: "BookOfComplaints",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookOfComplaints_Agents_AgentId",
                table: "BookOfComplaints",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookOfComplaints_Properties_PropertyId",
                table: "BookOfComplaints",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}