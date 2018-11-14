using Microsoft.EntityFrameworkCore.Migrations;

namespace MarkOGDev.Microsoft_Samples.EfCoreSqlLite.ConsoleApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directories",
                columns: table => new
                {
                    DirectoryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directories", x => x.DirectoryId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DirectoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Directories_DirectoryId",
                        column: x => x.DirectoryId,
                        principalTable: "Directories",
                        principalColumn: "DirectoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "DirectoryId", "Description", "Name" },
                values: new object[] { 1, "Amazing Exotic Cars for sale", "Exotic Cars Online" });

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "DirectoryId", "Description", "Name" },
                values: new object[] { 2, "Swap Not Buy.", "Fashion Swap Shop UK" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 1, null, 1, null, "BMW I8" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 2, null, 1, null, "Porsche 911" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 3, null, 1, null, "Ferrari  Enzo" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 4, null, 2, null, "Classic Knee High Boots" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 5, null, 2, null, "Designer Handbag" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Description", "DirectoryId", "Image", "Title" },
                values: new object[] { 6, null, 2, null, "Groovy Summer Hat" });

            migrationBuilder.CreateIndex(
                name: "IX_Directories_Name",
                table: "Directories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_DirectoryId",
                table: "Items",
                column: "DirectoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Directories");
        }
    }
}
