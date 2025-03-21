using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class Speranza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("01234567-89ab-cdef-0123-456789abcdef"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("12345678-9abc-def0-1234-56789abcdef0"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("1e2d3c4b-5a67-8f90-bcdf-3456e7f8912a"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("23456789-abcd-ef01-2345-6789abcdef01"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("3456789a-bcde-f012-3456-789abcdef012"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("456789ab-cdef-0123-4567-89abcdef0123"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("9a8b7c6d-5e4f-3a2b-1c0d-6789fabcde12"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("f9e8d7c6-b5a4-3d2c-1e0f-6789abcfde12"));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"),
                columns: new[] { "Cognome", "Email", "Nome" },
                values: new object[] { "Rossi", "mario.rossi@email.com", "Mario" });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 24, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3263), new DateTime(2025, 3, 21, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 2, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3274), new DateTime(2025, 3, 31, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 8, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3276), new DateTime(2025, 4, 5, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 28, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3271), new DateTime(2025, 3, 26, 11, 0, 25, 842, DateTimeKind.Utc).AddTicks(3270) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Camere",
                columns: new[] { "CameraId", "NumeroCamera", "PrezzoPerNotte", "Tipo" },
                values: new object[,]
                {
                    { new Guid("01234567-89ab-cdef-0123-456789abcdef"), 115, 120m, "Familiare" },
                    { new Guid("12345678-9abc-def0-1234-56789abcdef0"), 116, 50m, "Singola" },
                    { new Guid("1e2d3c4b-5a67-8f90-bcdf-3456e7f8912a"), 112, 120m, "Familiare" },
                    { new Guid("23456789-abcd-ef01-2345-6789abcdef01"), 117, 80m, "Doppia" },
                    { new Guid("3456789a-bcde-f012-3456-789abcdef012"), 118, 120m, "Familiare" },
                    { new Guid("456789ab-cdef-0123-4567-89abcdef0123"), 119, 50m, "Singola" },
                    { new Guid("9a8b7c6d-5e4f-3a2b-1c0d-6789fabcde12"), 113, 50m, "Singola" },
                    { new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"), 114, 80m, "Doppia" },
                    { new Guid("f9e8d7c6-b5a4-3d2c-1e0f-6789abcfde12"), 111, 80m, "Doppia" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"),
                columns: new[] { "Cognome", "Email", "Nome" },
                values: new object[] { "Barberis", "rachele.barberis@email.com", "Rachele" });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 24, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1358), new DateTime(2025, 3, 21, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 2, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1373), new DateTime(2025, 3, 31, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 4, 8, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1376), new DateTime(2025, 4, 5, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"),
                columns: new[] { "DataFine", "DataInizio" },
                values: new object[] { new DateTime(2025, 3, 28, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1368), new DateTime(2025, 3, 26, 10, 53, 2, 832, DateTimeKind.Utc).AddTicks(1368) });
        }
    }
}
