using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class Modifica1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3464), new DateTime(2025, 3, 21, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 2, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 3, 31, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3477) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 8, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 4, 5, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 28, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 3, 26, 11, 24, 58, 96, DateTimeKind.Utc).AddTicks(3474) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3495), new DateTime(2025, 3, 21, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 2, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 3, 31, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 8, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3511), new DateTime(2025, 4, 5, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 28, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3506), new DateTime(2025, 3, 26, 11, 8, 32, 525, DateTimeKind.Utc).AddTicks(3505) });
        }
    }
}
