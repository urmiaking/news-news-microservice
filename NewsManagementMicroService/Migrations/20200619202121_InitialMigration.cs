using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsManagementMicroService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupTitle = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 300, nullable: false),
                    Description = table.Column<string>(maxLength: 10000, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    ImageName = table.Column<string>(nullable: true),
                    VisitCount = table.Column<int>(nullable: false),
                    ShowInSlider = table.Column<bool>(nullable: false),
                    NewsGroupId = table.Column<int>(nullable: false),
                    Tags = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_NewsGroups_NewsGroupId",
                        column: x => x.NewsGroupId,
                        principalTable: "NewsGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    IsConfirmed = table.Column<bool>(nullable: false),
                    NewsId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NewsGroups",
                columns: new[] { "Id", "GroupTitle" },
                values: new object[] { 3, "اجتماعی" });

            migrationBuilder.InsertData(
                table: "NewsGroups",
                columns: new[] { "Id", "GroupTitle" },
                values: new object[] { 1, "سیاسی" });

            migrationBuilder.InsertData(
                table: "NewsGroups",
                columns: new[] { "Id", "GroupTitle" },
                values: new object[] { 2, "ورزشی" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 3, new DateTime(2020, 6, 19, 20, 21, 20, 883, DateTimeKind.Utc).AddTicks(2020), "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.", "thumb.png", 3, "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز", false, "تست۱,تست۲,تست۳", "عنوان خبر تست ۳", 10 });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 1, new DateTime(2020, 6, 19, 20, 21, 20, 882, DateTimeKind.Utc).AddTicks(7280), "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.", "thumb.png", 1, "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز", false, "تست۱,تست۲,تست۳", "عنوان خبر تست ۱", 10 });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 2, new DateTime(2020, 6, 19, 20, 21, 20, 883, DateTimeKind.Utc).AddTicks(1937), "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.", "thumb.png", 2, "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز", false, "تست۱,تست۲,تست۳", "عنوان خبر تست ۲", 10 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 3, "کامنت تست ۳", new DateTime(2020, 6, 19, 20, 21, 20, 883, DateTimeKind.Utc).AddTicks(6441), true, 3, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 1, "کامنت تست ۱", new DateTime(2020, 6, 19, 20, 21, 20, 883, DateTimeKind.Utc).AddTicks(4084), true, 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 2, "کامنت تست ۲", new DateTime(2020, 6, 19, 20, 21, 20, 883, DateTimeKind.Utc).AddTicks(6402), true, 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_NewsId",
                table: "Comments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_News_NewsGroupId",
                table: "News",
                column: "NewsGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "NewsGroups");
        }
    }
}
