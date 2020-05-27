using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatingApp.API.Migrations
{
    public partial class RenameMessageColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("SenderDelete", "Messages", "SenderDeleted");
            migrationBuilder.RenameColumn("MessageSentDate", "Messages", "DateSent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("SenderDeleted", "Messages", "SenderDelete");
            migrationBuilder.RenameColumn("DateSent", "Messages", "MessageSentDate");
        }
    }
}
