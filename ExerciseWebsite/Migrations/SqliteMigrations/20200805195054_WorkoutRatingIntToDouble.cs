using Microsoft.EntityFrameworkCore.Migrations;

namespace ExerciseWebsite.Migrations
{
    public partial class WorkoutRatingIntToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Workouts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Workouts",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
