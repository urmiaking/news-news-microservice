﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsManagementMicroService.Data;

namespace NewsManagementMicroService.Migrations
{
    [DbContext(typeof(NewsManagementMicroServiceContext))]
    [Migration("20200712001201_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsManagementMicroService.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("NewsId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "چه خفن",
                            DateTime = new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(1882),
                            IsConfirmed = true,
                            NewsId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "ای بابا عجب گیری کردیم",
                            DateTime = new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(4437),
                            IsConfirmed = true,
                            NewsId = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "بسته ها واقعا گرونن",
                            DateTime = new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(4479),
                            IsConfirmed = true,
                            NewsId = 3,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("NewsManagementMicroService.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(10000);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NewsGroupId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<bool>("ShowInSlider")
                        .HasColumnType("bit");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("VisitCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsGroupId");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2020, 7, 12, 0, 12, 1, 219, DateTimeKind.Utc).AddTicks(5568),
                            Description = "اسنپدراگون ۸۶۵ پلاس مانند نسخه غیر پلاس، از نمایشگرهای ۱۴۴ هرتز پشتیبانی می کند. با این وجود در بخش GPU شانس 10٪ بهتری برای پردازش فریم های بازی دارد تا بهترین استفاده را از این رفرش ریت داشته باشد زیرا Adreno 650 نیز یک افزایش کلاک داشته است.یکی دیگر از تغییرات سخت افزاری، انتقال سریع FastConnect 6900 است(از 6800).این امکان پشتیبانی از آخرین Wi - Fi 6E را فراهم می کند، که در باند 6 گیگاهرتزی کار می کند تا سرعت حداکثر 3.2 گیگابیت بر ثانیه و تأخیر در زیر 3 میلی ثانیه را ارائه دهد.همچنین، آن را قادر می سازد بلوتوث ۵.۲ با قابلیت X Adaptive و برای پشتیبانی از آنتن صوتی 96 کیلوهرتز و آنتن بلوتوث دوگانه را داشته باشد.",
                            ImageName = "snapdragon.jpg",
                            NewsGroupId = 3,
                            ShortDescription = "پس از مدت ها شایعه درباره ارایه شدن یا نشدن حالا و امشب تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد. این تراشه نسخه بهبودیافته اسنپدراگون ۸۶۵ است و با پشتیبانی از Wi-Fi 6E و GPU قوی تر عرضه شده است. خبر بد اینکه همچنان خبری از مودم یکپارچه 5G نیست! خب خبر خوب دیگر عبور از مرز فرکانس ۳ گیگاهرتز است.",
                            ShowInSlider = true,
                            Tags = "تکنولوژی,اسنپدراگون,تراشه",
                            Title = "تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد",
                            VisitCount = 10
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2020, 7, 12, 0, 12, 1, 219, DateTimeKind.Utc).AddTicks(9983),
                            Description = "در پی انتشار اخباری مبنی بر محدودیت واردات موبایل با ارزش بالای ۳۰۰ یورو که از سوی انجمن واردکنندگان موبایل، تبلت و لوازم جانبی اعلام شده بود  و مدیرکل دفتر مقررات صادرات و واردات وزارت صنعت، معدن و تجارت (صمت) نیز امروز اعلام کردند که منتظر اعلام نظر نهایی کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات هستند در نهایت بر اساس اطلاعات دریافتی ایسنا این محدویت اعمال نشده و قضیه ممنوعیت واردات این گوشی‌ها منتفی شد. همچنین پیش از این محمد جواد آذری جهرمی، وزیر ارتباطات، در توییترش گفته بود که این تصمیم ایرادات جدی دارد و از احتمال بازنگری در این تصمیم خبر داده بود. نظر شما چیست؟ فکر می کنید که منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو به بازگشت قیمت به قبل بیانجامد؟",
                            ImageName = "iPhone.jpg",
                            NewsGroupId = 3,
                            ShortDescription = "امروز در کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات موضوع اعمال ممنوعیت واردات گوشی‌های بالای ۳۰۰ یورو منتفی شد.",
                            ShowInSlider = true,
                            Tags = "گرانی,تکنولوژی,موبایل",
                            Title = "منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو",
                            VisitCount = 10
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2020, 7, 12, 0, 12, 1, 220, DateTimeKind.Utc).AddTicks(72),
                            Description = "به گزارش وزارت ارتباطات و فناوری اطلاعات، حسین فلاح جوشقانی معاون وزیر و رئیس سازمان تنظیم مقررات و ارتباطات رادیویی،با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود. اگر اپراتوری بیش از ۵۰ درصد سهم بازار را در اختیار داشته باشد اپراتور مسلط است که هر دو اپراتور اول و دوم اپراتور مسلط بازار هستند و حالا هر دو اپراتور به‌صورت هماهنگ بسته‌های پرمخاطب خود را از کانال‌هایی که خرید مردم بیشتر از آن‌ها انجام می‌شود مثل USSD خارج کرده‌اند و این یعنی بازار را به سمتی برده‌اند که مشترک مجبور شود تا نیازش را بر اساس بسته‌های موجود با قیمت خیلی بالاتر تأمین کند.",
                            ImageName = "internet.jpg",
                            NewsGroupId = 1,
                            ShortDescription = "رئیس سازمان تنظیم مقررات و ارتباطات رادیویی با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود.",
                            ShowInSlider = false,
                            Tags = "سیاسی,گرانی,اپراتور",
                            Title = "گرانی بسته ها موجب جریمه اپراتورها شد",
                            VisitCount = 10
                        });
                });

            modelBuilder.Entity("NewsManagementMicroService.Models.NewsGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("NewsGroups");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            GroupTitle = "تکنولوژی"
                        },
                        new
                        {
                            Id = 1,
                            GroupTitle = "سیاسی"
                        },
                        new
                        {
                            Id = 2,
                            GroupTitle = "اجتماعی"
                        });
                });

            modelBuilder.Entity("NewsManagementMicroService.Models.Comment", b =>
                {
                    b.HasOne("NewsManagementMicroService.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NewsManagementMicroService.Models.News", b =>
                {
                    b.HasOne("NewsManagementMicroService.Models.NewsGroup", "NewsGroup")
                        .WithMany("News")
                        .HasForeignKey("NewsGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
