using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cleanuparr.Persistence.Migrations.Data
{
    /// <inheritdoc />
    public partial class AddMaxInactiveDaysToSeedingRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "max_inactive_days",
                table: "u_torrent_seeding_rules",
                type: "REAL",
                nullable: false,
                defaultValue: -1.0);

            migrationBuilder.AddColumn<double>(
                name: "max_inactive_days",
                table: "transmission_seeding_rules",
                type: "REAL",
                nullable: false,
                defaultValue: -1.0);

            migrationBuilder.AddColumn<double>(
                name: "max_inactive_days",
                table: "r_torrent_seeding_rules",
                type: "REAL",
                nullable: false,
                defaultValue: -1.0);

            migrationBuilder.AddColumn<double>(
                name: "max_inactive_days",
                table: "q_bit_seeding_rules",
                type: "REAL",
                nullable: false,
                defaultValue: -1.0);

            migrationBuilder.AddColumn<double>(
                name: "max_inactive_days",
                table: "deluge_seeding_rules",
                type: "REAL",
                nullable: false,
                defaultValue: -1.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "max_inactive_days",
                table: "u_torrent_seeding_rules");

            migrationBuilder.DropColumn(
                name: "max_inactive_days",
                table: "transmission_seeding_rules");

            migrationBuilder.DropColumn(
                name: "max_inactive_days",
                table: "r_torrent_seeding_rules");

            migrationBuilder.DropColumn(
                name: "max_inactive_days",
                table: "q_bit_seeding_rules");

            migrationBuilder.DropColumn(
                name: "max_inactive_days",
                table: "deluge_seeding_rules");
        }
    }
}
