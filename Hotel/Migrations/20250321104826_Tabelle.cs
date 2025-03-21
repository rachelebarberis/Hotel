using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class Tabelle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("e8c4b5a3-7767-4b89-a983-65f1a342b234"), new DateTime(2025, 3, 24, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3368), new DateTime(2025, 3, 21, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("c6aaf1f8-2c1d-4b88-90eb-135f9a314f82"), new DateTime(2025, 4, 2, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 3, 31, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "CameraId", "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"), new Guid("d7e3a22f-2a1d-4bc0-9f7d-9ea1a8b2c893"), new DateTime(2025, 4, 8, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3386), new DateTime(2025, 4, 5, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("9f3b2d47-6c44-44f0-aad3-e9c276e54a62"), new DateTime(2025, 3, 28, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3380), new DateTime(2025, 3, 26, 10, 48, 25, 847, DateTimeKind.Utc).AddTicks(3379) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"), new DateTime(2025, 3, 24, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4253), new DateTime(2025, 3, 21, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"), new DateTime(2025, 4, 2, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4269), new DateTime(2025, 3, 31, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "CameraId", "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"), new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"), new DateTime(2025, 4, 8, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 4, 5, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "ClienteId", "DataFine", "DataInizio" },
                values: new object[] { new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"), new DateTime(2025, 3, 28, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4267), new DateTime(2025, 3, 26, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4266) });
        }
    }
}
