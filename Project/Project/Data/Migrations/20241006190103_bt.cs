using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class bt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_Sanpham",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_Sanpham",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "Sanpham",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TheLoaiId",
                table: "SanPham",
                newName: "TheLoaild");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_TheLoaild",
                table: "SanPham",
                column: "TheLoaild");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaild",
                table: "SanPham",
                column: "TheLoaild",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaild",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_TheLoaild",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TheLoaild",
                table: "SanPham",
                newName: "TheLoaiId");

            migrationBuilder.AddColumn<int>(
                name: "Sanpham",
                table: "SanPham",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_Sanpham",
                table: "SanPham",
                column: "Sanpham");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TheLoai_Sanpham",
                table: "SanPham",
                column: "Sanpham",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
