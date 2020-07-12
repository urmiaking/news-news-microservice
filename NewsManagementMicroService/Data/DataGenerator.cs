using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsManagementMicroService.Models;

namespace NewsManagementMicroService.Data
{
    public static class DataGenerator
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var politicsGroup = new NewsGroup()
            {
                Id = 1,
                GroupTitle = "سیاسی"
            };

            var sportsGroup = new NewsGroup()
            {
                Id = 2,
                GroupTitle = "اجتماعی"
            };

            var socialGroup = new NewsGroup()
            {
                Id = 3,
                GroupTitle = "تکنولوژی"
            };

            var fakeNews1 = new News()
            {
                Id = 1,
                Description = "اسنپدراگون ۸۶۵ پلاس مانند نسخه غیر پلاس، از نمایشگرهای ۱۴۴ هرتز پشتیبانی می کند. با این وجود در بخش GPU شانس 10٪ بهتری برای پردازش فریم های بازی دارد تا بهترین استفاده را از این رفرش ریت داشته باشد زیرا Adreno 650 نیز یک افزایش کلاک داشته است.یکی دیگر از تغییرات سخت افزاری، انتقال سریع FastConnect 6900 است(از 6800).این امکان پشتیبانی از آخرین Wi - Fi 6E را فراهم می کند، که در باند 6 گیگاهرتزی کار می کند تا سرعت حداکثر 3.2 گیگابیت بر ثانیه و تأخیر در زیر 3 میلی ثانیه را ارائه دهد.همچنین، آن را قادر می سازد بلوتوث ۵.۲ با قابلیت X Adaptive و برای پشتیبانی از آنتن صوتی 96 کیلوهرتز و آنتن بلوتوث دوگانه را داشته باشد.",
                Title = "تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد",
                CreateDate = DateTime.UtcNow,
                ShortDescription = "پس از مدت ها شایعه درباره ارایه شدن یا نشدن حالا و امشب تراشه اسنپدراگون ۸۶۵ پلاس رسما معرفی شد. این تراشه نسخه بهبودیافته اسنپدراگون ۸۶۵ است و با پشتیبانی از Wi-Fi 6E و GPU قوی تر عرضه شده است. خبر بد اینکه همچنان خبری از مودم یکپارچه 5G نیست! خب خبر خوب دیگر عبور از مرز فرکانس ۳ گیگاهرتز است.",
                Tags = "تکنولوژی,اسنپدراگون,تراشه",
                VisitCount = 10,
                ImageName = "snapdragon.jpg",
                ShowInSlider = true,
                NewsGroupId = 3
            };

            var fakeNews2 = new News()
            {
                Id = 2,
                Description = "در پی انتشار اخباری مبنی بر محدودیت واردات موبایل با ارزش بالای ۳۰۰ یورو که از سوی انجمن واردکنندگان موبایل، تبلت و لوازم جانبی اعلام شده بود  و مدیرکل دفتر مقررات صادرات و واردات وزارت صنعت، معدن و تجارت (صمت) نیز امروز اعلام کردند که منتظر اعلام نظر نهایی کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات هستند در نهایت بر اساس اطلاعات دریافتی ایسنا این محدویت اعمال نشده و قضیه ممنوعیت واردات این گوشی‌ها منتفی شد. همچنین پیش از این محمد جواد آذری جهرمی، وزیر ارتباطات، در توییترش گفته بود که این تصمیم ایرادات جدی دارد و از احتمال بازنگری در این تصمیم خبر داده بود. نظر شما چیست؟ فکر می کنید که منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو به بازگشت قیمت به قبل بیانجامد؟", 
                Title = "منتفی شدن ممنوعیت واردات گوشی های بالای ۳۰۰ یورو",
                CreateDate = DateTime.UtcNow,
                ShortDescription = "امروز در کمیته مشترک میان بانک مرکزی و وزارتخانه‌های صمت و ارتباطات و فناوری اطلاعات موضوع اعمال ممنوعیت واردات گوشی‌های بالای ۳۰۰ یورو منتفی شد.",
                Tags = "گرانی,تکنولوژی,موبایل",
                VisitCount = 10,
                ImageName = "iPhone.jpg",
                ShowInSlider = true,
                NewsGroupId = 3
            };

            var fakeNews3 = new News()
            {
                Id = 3,
                Description = "به گزارش وزارت ارتباطات و فناوری اطلاعات، حسین فلاح جوشقانی معاون وزیر و رئیس سازمان تنظیم مقررات و ارتباطات رادیویی،با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود. اگر اپراتوری بیش از ۵۰ درصد سهم بازار را در اختیار داشته باشد اپراتور مسلط است که هر دو اپراتور اول و دوم اپراتور مسلط بازار هستند و حالا هر دو اپراتور به‌صورت هماهنگ بسته‌های پرمخاطب خود را از کانال‌هایی که خرید مردم بیشتر از آن‌ها انجام می‌شود مثل USSD خارج کرده‌اند و این یعنی بازار را به سمتی برده‌اند که مشترک مجبور شود تا نیازش را بر اساس بسته‌های موجود با قیمت خیلی بالاتر تأمین کند.",
                Title = "گرانی بسته ها موجب جریمه اپراتورها شد",
                CreateDate = DateTime.UtcNow,
                ShortDescription = "رئیس سازمان تنظیم مقررات و ارتباطات رادیویی با اشاره به افزایش قیمت بسته‌های اینترنت دو اپراتور عمده بازار گفت: اپراتورها برخلاف مصوبات رگولاتوری عمل کردند و باید قیمت را به شرایط قبل بازگردانند تا راه تعامل باز شود.",
                Tags = "سیاسی,گرانی,اپراتور",
                VisitCount = 10,
                ImageName = "internet.jpg",
                ShowInSlider = false,
                NewsGroupId = 1
            };

            var fakeComment1 = new Comment()
            {
                Id = 1,
                Content = "چه خفن",
                DateTime = DateTime.UtcNow,
                IsConfirmed = true,
                UserId = 1,
                NewsId = 1
            };

            var fakeComment2 = new Comment()
            {
                Id = 2,
                Content = "ای بابا عجب گیری کردیم",
                DateTime = DateTime.UtcNow,
                IsConfirmed = true,
                UserId = 1,
                NewsId = 2
            };

            var fakeComment3 = new Comment()
            {
                Id = 3,
                Content = "بسته ها واقعا گرونن",
                DateTime = DateTime.UtcNow,
                IsConfirmed = true,
                UserId = 1,
                NewsId = 3
            };

            modelBuilder.Entity<NewsGroup>()
                .HasData(socialGroup);

            modelBuilder.Entity<NewsGroup>()
                .HasData(politicsGroup);

            modelBuilder.Entity<NewsGroup>()
                .HasData(sportsGroup);

            modelBuilder.Entity<News>()
                .HasData(fakeNews1);

            modelBuilder.Entity<News>()
                .HasData(fakeNews2);

            modelBuilder.Entity<News>()
                .HasData(fakeNews3);

            modelBuilder.Entity<Comment>()
                .HasData(fakeComment1);

            modelBuilder.Entity<Comment>()
                .HasData(fakeComment2);

            modelBuilder.Entity<Comment>()
                .HasData(fakeComment3);
        }
    }
}
