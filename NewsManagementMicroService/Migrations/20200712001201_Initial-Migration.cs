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
                values: new object[] { 3, "تکنولوژی" });

            migrationBuilder.InsertData(
                table: "NewsGroups",
                columns: new[] { "Id", "GroupTitle" },
                values: new object[] { 1, "سیاسی" });

            migrationBuilder.InsertData(
                table: "NewsGroups",
                columns: new[] { "Id", "GroupTitle" },
                values: new object[] { 2, "اجتماعی" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 1, new DateTime(2020, 7, 12, 0, 12, 1, 219, DateTimeKind.Utc).AddTicks(5568), "اسنپدراگون ۸۶۵ پلاس مانند نسخه غیر پلاس، از نمایشگرهای ۱۴۴ هرتز پشتیبانی می کند. با این وجود در بخش GPU شانس 10٪ بهتری برای پردازش فریم های بازی دارد تا بهترین استفاده را از این رفرش ریت داشته باشد زیرا Adreno 650 نیز یک افزایش کلاک داشته است.یکی دیگر از تغییرات سخت افزاری، انتقال سریع FastConnect 6900 است(از 6800).این امکان پشتیبانی از آخرین Wi - Fi 6E را فراهم می کند، که در باند 6 گیگاهرتزی کار می کند تا سرعت حداکثر 3.2 گیگابیت بر ثانیه و تأخیر در زیر 3 میلی ثانیه را ارائه دهد.همچنین، آن را قادر می سازد بلوتوث ۵.۲ با قابلیت X Adaptive و برای پشتیبانی از آنتن صوتی 96 کیلوهرتز و آنتن بلوتوث دوگانه را داشته باشد.", "snapdragon.jpg", 3, "پس از مدت ها شایعه درباره ارایه شدن یا نشدن حالا و امشب تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد. این تراشه نسخه بهبودیافته اسنپدراگون ۸۶۵ است و با پشتیبانی از Wi-Fi 6E و GPU قوی تر عرضه شده است. خبر بد اینکه همچنان خبری از مودم یکپارچه 5G نیست! خب خبر خوب دیگر عبور از مرز فرکانس ۳ گیگاهرتز است.", true, "تکنولوژی,اسنپدراگون,تراشه", "تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد", 10 });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 2, new DateTime(2020, 7, 12, 0, 12, 1, 219, DateTimeKind.Utc).AddTicks(9983), "در پی انتشار اخباری مبنی بر محدودیت واردات موبایل با ارزش بالای ۳۰۰ یورو که از سوی انجمن واردکنندگان موبایل، تبلت و لوازم جانبی اعلام شده بود  و مدیرکل دفتر مقررات صادرات و واردات وزارت صنعت، معدن و تجارت (صمت) نیز امروز اعلام کردند که منتظر اعلام نظر نهایی کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات هستند در نهایت بر اساس اطلاعات دریافتی ایسنا این محدویت اعمال نشده و قضیه ممنوعیت واردات این گوشی‌ها منتفی شد. همچنین پیش از این محمد جواد آذری جهرمی، وزیر ارتباطات، در توییترش گفته بود که این تصمیم ایرادات جدی دارد و از احتمال بازنگری در این تصمیم خبر داده بود. نظر شما چیست؟ فکر می کنید که منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو به بازگشت قیمت به قبل بیانجامد؟", "iPhone.jpg", 3, "امروز در کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات موضوع اعمال ممنوعیت واردات گوشی‌های بالای ۳۰۰ یورو منتفی شد.", true, "گرانی,تکنولوژی,موبایل", "منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو", 10 });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "NewsGroupId", "ShortDescription", "ShowInSlider", "Tags", "Title", "VisitCount" },
                values: new object[] { 3, new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(72), "به گزارش وزارت ارتباطات و فناوری اطلاعات، حسین فلاح جوشقانی معاون وزیر و رئیس سازمان تنظیم مقررات و ارتباطات رادیویی،با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود. اگر اپراتوری بیش از ۵۰ درصد سهم بازار را در اختیار داشته باشد اپراتور مسلط است که هر دو اپراتور اول و دوم اپراتور مسلط بازار هستند و حالا هر دو اپراتور به‌صورت هماهنگ بسته‌های پرمخاطب خود را از کانال‌هایی که خرید مردم بیشتر از آن‌ها انجام می‌شود مثل USSD خارج کرده‌اند و این یعنی بازار را به سمتی برده‌اند که مشترک مجبور شود تا نیازش را بر اساس بسته‌های موجود با قیمت خیلی بالاتر تأمین کند.", "internet.jpg", 1, "رئیس سازمان تنظیم مقررات و ارتباطات رادیویی با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود.", false, "سیاسی,گرانی,اپراتور", "گرانی بسته ها موجب جریمه اپراتورها شد", 10 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 1, "چه خفن", new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(1882), true, 1, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 2, "ای بابا عجب گیری کردیم", new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(4437), true, 2, 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "DateTime", "IsConfirmed", "NewsId", "UserId" },
                values: new object[] { 3, "بسته ها واقعا گرونن", new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(4479), true, 3, 1 });

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
