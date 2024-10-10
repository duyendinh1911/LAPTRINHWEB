using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaiId",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_TheLoaiId",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "TheLoaild",
                table: "SanPham",
                newName: "Sanpham");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_TheLoai_Sanpham",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_Sanpham",
                table: "SanPham");

            migrationBuilder.RenameColumn(
                name: "Sanpham",
                table: "SanPham",
                newName: "TheLoaild");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_TheLoaiId",
                table: "SanPham",
                column: "TheLoaiId");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_TheLoai_TheLoaiId",
                table: "SanPham",
                column: "TheLoaiId",
                principalTable: "TheLoai",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
