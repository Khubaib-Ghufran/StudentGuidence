﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentGuidence.DataAccess.Migrations
{
    public partial class ChangedStduentDateTimeToDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UniversityStartDate",
                table: "Students",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UniversityStartDate",
                table: "Students",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }
    }
}
