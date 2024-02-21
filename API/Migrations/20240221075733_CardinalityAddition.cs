using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class CardinalityAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_overtime_requests_account_id",
                table: "tbl_tr_overtime_requests",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_overtime_requests_overtime_id",
                table: "tbl_tr_overtime_requests",
                column: "overtime_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_account_roles_account_id",
                table: "tbl_tr_account_roles",
                column: "account_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_tr_account_roles_role_id",
                table: "tbl_tr_account_roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_employees_manager_id",
                table: "tbl_m_employees",
                column: "manager_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_accounts_tbl_m_employees_id",
                table: "tbl_m_accounts",
                column: "id",
                principalTable: "tbl_m_employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_m_employees_tbl_m_employees_manager_id",
                table: "tbl_m_employees",
                column: "manager_id",
                principalTable: "tbl_m_employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_tr_account_roles_tbl_m_accounts_account_id",
                table: "tbl_tr_account_roles",
                column: "account_id",
                principalTable: "tbl_m_accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_tr_account_roles_tbl_m_roles_role_id",
                table: "tbl_tr_account_roles",
                column: "role_id",
                principalTable: "tbl_m_roles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_tr_overtime_requests_tbl_m_accounts_account_id",
                table: "tbl_tr_overtime_requests",
                column: "account_id",
                principalTable: "tbl_m_accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_tr_overtime_requests_tbl_m_overtimes_overtime_id",
                table: "tbl_tr_overtime_requests",
                column: "overtime_id",
                principalTable: "tbl_m_overtimes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_accounts_tbl_m_employees_id",
                table: "tbl_m_accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_m_employees_tbl_m_employees_manager_id",
                table: "tbl_m_employees");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_tr_account_roles_tbl_m_accounts_account_id",
                table: "tbl_tr_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_tr_account_roles_tbl_m_roles_role_id",
                table: "tbl_tr_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_tr_overtime_requests_tbl_m_accounts_account_id",
                table: "tbl_tr_overtime_requests");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_tr_overtime_requests_tbl_m_overtimes_overtime_id",
                table: "tbl_tr_overtime_requests");

            migrationBuilder.DropIndex(
                name: "IX_tbl_tr_overtime_requests_account_id",
                table: "tbl_tr_overtime_requests");

            migrationBuilder.DropIndex(
                name: "IX_tbl_tr_overtime_requests_overtime_id",
                table: "tbl_tr_overtime_requests");

            migrationBuilder.DropIndex(
                name: "IX_tbl_tr_account_roles_account_id",
                table: "tbl_tr_account_roles");

            migrationBuilder.DropIndex(
                name: "IX_tbl_tr_account_roles_role_id",
                table: "tbl_tr_account_roles");

            migrationBuilder.DropIndex(
                name: "IX_tbl_m_employees_manager_id",
                table: "tbl_m_employees");
        }
    }
}
