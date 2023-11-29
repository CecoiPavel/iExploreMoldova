using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iExploreMoldova.Migrations
{
    /// <inheritdoc />
    public partial class AddedReviewCommentCollumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReviewComment",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewComment",
                table: "Reviews");
        }
    }
}
