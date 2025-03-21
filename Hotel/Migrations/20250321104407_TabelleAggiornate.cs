using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hotel.Migrations
{
    /// <inheritdoc />
    public partial class TabelleAggiornate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("34ac5b72-62cd-4b8d-b3c4-71d3132a7f79"), 106, 120m, "Familiare" },
                    { new Guid("456789ab-cdef-0123-4567-89abcdef0123"), 119, 50m, "Singola" },
                    { new Guid("9a8b7c6d-5e4f-3a2b-1c0d-6789fabcde12"), 113, 50m, "Singola" },
                    { new Guid("a75f1b56-3cbb-4e8a-a95d-6c3495d1c1b1"), 107, 50m, "Singola" },
                    { new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"), 102, 80m, "Doppia" },
                    { new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"), 114, 80m, "Doppia" },
                    { new Guid("b8d5f8b3-908d-41c5-987d-3f869b6e9a48"), 108, 80m, "Doppia" },
                    { new Guid("c4a5b6d7-e8f9-4012-abcd-567e8f91c2b3"), 110, 50m, "Singola" },
                    { new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"), 103, 120m, "Familiare" },
                    { new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"), 105, 80m, "Doppia" },
                    { new Guid("e1d2c3b4-a567-4f89-bcdf-9a6e8b3c2f91"), 109, 120m, "Familiare" },
                    { new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"), 104, 50m, "Singola" },
                    { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), 101, 50m, "Singola" },
                    { new Guid("f9e8d7c6-b5a4-3d2c-1e0f-6789abcfde12"), 111, 80m, "Doppia" }
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Cognome", "Email", "Nome", "Telefono" },
                values: new object[,]
                {
                    { new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"), "Verdi", "anna.verdi@email.com", "Anna", "1122334455" },
                    { new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"), "Barberis", "rachele.barberis@email.com", "Rachele", "1234567890" },
                    { new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"), "Bianchi", "luca.bianchi@email.com", "Luca", "0987654321" },
                    { new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"), "Neri", "giulia.neri@email.com", "Giulia", "5566778899" }
                });

            migrationBuilder.InsertData(
                table: "Prenotazioni",
                columns: new[] { "PrenotazioneId", "CameraId", "ClienteId", "DataFine", "DataInizio", "Stato" },
                values: new object[,]
                {
                    { new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"), new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"), new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"), new DateTime(2025, 4, 8, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4272), new DateTime(2025, 4, 5, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4271), "Annullata" },
                    { new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"), new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"), new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"), new DateTime(2025, 3, 24, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4253), new DateTime(2025, 3, 21, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4250), "Confermata" },
                    { new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"), new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"), new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"), new DateTime(2025, 4, 2, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4269), new DateTime(2025, 3, 31, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4269), "Confermata" },
                    { new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"), new DateTime(2025, 3, 28, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4267), new DateTime(2025, 3, 26, 10, 44, 7, 389, DateTimeKind.Utc).AddTicks(4266), "In Attesa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("34ac5b72-62cd-4b8d-b3c4-71d3132a7f79"));

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
                keyValue: new Guid("a75f1b56-3cbb-4e8a-a95d-6c3495d1c1b1"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("aab8a3c0-ded7-4d8f-a27d-e2a0d47f2b5b"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("b8d5f8b3-908d-41c5-987d-3f869b6e9a48"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("c4a5b6d7-e8f9-4012-abcd-567e8f91c2b3"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("d42c35f1-3e33-44c9-a62b-9bd8e07a5f84"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("e1d2c3b4-a567-4f89-bcdf-9a6e8b3c2f91"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("f9e8d7c6-b5a4-3d2c-1e0f-6789abcfde12"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("d3f2eeae-1b50-47eb-a2e1-5e713b6637a7"));

            migrationBuilder.DeleteData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("5e8d6a1b-3c2f-4b79-a012-9d8e7f6c5b4a"));

            migrationBuilder.DeleteData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("9c8d7e6f-5a4b-3c2d-1e0f-6789abcdef12"));

            migrationBuilder.DeleteData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("abcdef12-3456-7890-9a8b-7c6d5e4f3a2b"));

            migrationBuilder.DeleteData(
                table: "Prenotazioni",
                keyColumn: "PrenotazioneId",
                keyValue: new Guid("f1a2b3c4-d5e6-7f89-0123-456789abcdef"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("cc961b45-e0b1-4e49-a091-1d056c3d93e2"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("e7f3c58b-9f4c-44d3-b285-d61c2c4b3f42"));

            migrationBuilder.DeleteData(
                table: "Camere",
                keyColumn: "CameraId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("b7e90b60-bcc5-45b6-bbc6-e1d10fa1a2b6"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("bdde9f60-ef14-4a7d-a78a-d3a77e7b0a9c"));

            migrationBuilder.DeleteData(
                table: "Cliente",
                keyColumn: "ClienteId",
                keyValue: new Guid("c4dd7b3f-4fdc-493e-b59b-93df439e627d"));
        }
    }
}
