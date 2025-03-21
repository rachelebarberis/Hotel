using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class IniTabelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new DateTime(2025, 3, 24, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3495), new DateTime(2025, 3, 21, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("b8d5f8b3-908d-41c5-987d-3f869b6e9a48"), new DateTime(2025, 4, 2, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 3, 31, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("e1d2c3b4-a567-4f89-bcdf-9a6e8b3c2f91"), new DateTime(2025, 4, 8, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3511), new DateTime(2025, 4, 5, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"), new DateTime(2025, 3, 28, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3506), new DateTime(2025, 3, 26, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3505) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"), new DateTime(2025, 3, 24, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 3, 21, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"), new DateTime(2025, 4, 2, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3274), new DateTime(2025, 3, 31, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"), new DateTime(2025, 4, 8, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3276), new DateTime(2025, 4, 5, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "CameraId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new DateTime(2025, 3, 28, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 3, 26, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3270) });
        }
    }
}
