using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMeetingManager.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hymns",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hymns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Salutation = table.Column<int>(type: "int", nullable: false),
                    isLeader = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Wards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FastAndTestimonyMeeting = table.Column<bool>(type: "bit", nullable: false),
                    Announcements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WardID = table.Column<int>(type: "int", nullable: true),
                    PresidingID = table.Column<int>(type: "int", nullable: true),
                    ConductingLeaderID = table.Column<int>(type: "int", nullable: true),
                    ChoristerID = table.Column<int>(type: "int", nullable: true),
                    OrganistID = table.Column<int>(type: "int", nullable: true),
                    OpeningHymnID = table.Column<int>(type: "int", nullable: true),
                    OpeningPrayerMemberID = table.Column<int>(type: "int", nullable: true),
                    SacramentHymnID = table.Column<int>(type: "int", nullable: true),
                    OptionalRestHymnTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OptionalRestHymnMemberID = table.Column<int>(type: "int", nullable: true),
                    ClosingHymnID = table.Column<int>(type: "int", nullable: true),
                    ClosingPrayerMemberID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meetings_Hymns_ClosingHymnID",
                        column: x => x.ClosingHymnID,
                        principalTable: "Hymns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Hymns_OpeningHymnID",
                        column: x => x.OpeningHymnID,
                        principalTable: "Hymns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Hymns_SacramentHymnID",
                        column: x => x.SacramentHymnID,
                        principalTable: "Hymns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_ChoristerID",
                        column: x => x.ChoristerID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_ClosingPrayerMemberID",
                        column: x => x.ClosingPrayerMemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_ConductingLeaderID",
                        column: x => x.ConductingLeaderID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_OpeningPrayerMemberID",
                        column: x => x.OpeningPrayerMemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_OptionalRestHymnMemberID",
                        column: x => x.OptionalRestHymnMemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_OrganistID",
                        column: x => x.OrganistID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Members_PresidingID",
                        column: x => x.PresidingID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Wards_WardID",
                        column: x => x.WardID,
                        principalTable: "Wards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(type: "int", nullable: true),
                    MeetingID = table.Column<int>(type: "int", nullable: true),
                    Topic = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Minutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Speakers_Meetings_MeetingID",
                        column: x => x.MeetingID,
                        principalTable: "Meetings",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Speakers_Members_MemberID",
                        column: x => x.MemberID,
                        principalTable: "Members",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ChoristerID",
                table: "Meetings",
                column: "ChoristerID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ClosingHymnID",
                table: "Meetings",
                column: "ClosingHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ClosingPrayerMemberID",
                table: "Meetings",
                column: "ClosingPrayerMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ConductingLeaderID",
                table: "Meetings",
                column: "ConductingLeaderID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OpeningHymnID",
                table: "Meetings",
                column: "OpeningHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OpeningPrayerMemberID",
                table: "Meetings",
                column: "OpeningPrayerMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OptionalRestHymnMemberID",
                table: "Meetings",
                column: "OptionalRestHymnMemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OrganistID",
                table: "Meetings",
                column: "OrganistID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_PresidingID",
                table: "Meetings",
                column: "PresidingID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_SacramentHymnID",
                table: "Meetings",
                column: "SacramentHymnID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_WardID",
                table: "Meetings",
                column: "WardID");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_MeetingID",
                table: "Speakers",
                column: "MeetingID");

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_MemberID",
                table: "Speakers",
                column: "MemberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Hymns");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Wards");
        }
    }
}
