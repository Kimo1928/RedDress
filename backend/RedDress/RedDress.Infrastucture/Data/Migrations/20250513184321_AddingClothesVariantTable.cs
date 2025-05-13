using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RedDress.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class AddingClothesVariantTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClothesSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClothesVariants",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "NEWID()"),
                    ClothesId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClothesColorId = table.Column<int>(type: "int", nullable: false),
                    ClothesSizeId = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    PhotoId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerUnit = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothesVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClothesVariants_ClothesColors_ClothesColorId",
                        column: x => x.ClothesColorId,
                        principalTable: "ClothesColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothesVariants_ClothesSize_ClothesSizeId",
                        column: x => x.ClothesSizeId,
                        principalTable: "ClothesSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClothesVariants_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothesVariants_ClothesColorId",
                table: "ClothesVariants",
                column: "ClothesColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesVariants_ClothesSizeId",
                table: "ClothesVariants",
                column: "ClothesSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClothesVariants_PhotoId",
                table: "ClothesVariants",
                column: "PhotoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothesVariants");

            migrationBuilder.DropTable(
                name: "ClothesSize");
        }
    }
}
