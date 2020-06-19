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
                GroupTitle = "ورزشی"
            };

            var socialGroup = new NewsGroup()
            {
                Id = 3,
                GroupTitle = "اجتماعی"
            };

            var fakeNews1 = new News()
            {
                Id = 1,
                Description =
                    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.",
                Title = "عنوان خبر تست ۱",
                CreateDate = DateTime.UtcNow,
                ShortDescription =
                    "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز",
                Tags = "تست۱,تست۲,تست۳",
                VisitCount = 10,
                ImageName = "thumb.png",
                ShowInSlider = false,
                NewsGroupId = 1
            };

            var fakeNews2 = new News()
            {
                Id = 2,
                Description =
                    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.",
                Title = "عنوان خبر تست ۲",
                CreateDate = DateTime.UtcNow,
                ShortDescription =
                    "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز",
                Tags = "تست۱,تست۲,تست۳",
                VisitCount = 10,
                ImageName = "thumb.png",
                ShowInSlider = false,
                NewsGroupId = 2
            };

            var fakeNews3 = new News()
            {
                Id = 3,
                Description =
                    "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز، و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد، کتابهای زیادی در شصت و سه درصد گذشته حال و آینده، شناخت فراوان جامعه و متخصصان را می طلبد، تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی، و فرهنگ پیشرو در زبان فارسی ایجاد کرد، در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها، و شرایط سخت تایپ به پایان رسد و زمان مورد نیاز شامل حروفچینی دستاوردهای اصلی، و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.",
                Title = "عنوان خبر تست ۳",
                CreateDate = DateTime.UtcNow,
                ShortDescription =
                    "ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و برای شرایط فعلی تکنولوژی مورد نیاز",
                Tags = "تست۱,تست۲,تست۳",
                VisitCount = 10,
                ImageName = "thumb.png",
                ShowInSlider = false,
                NewsGroupId = 3
            };

            var fakeComment1 = new Comment()
            {
                Id = 1,
                Content = "کامنت تست ۱",
                DateTime = DateTime.UtcNow,
                IsConfirmed = true,
                UserId = 1,
                NewsId = 1
            };

            var fakeComment2 = new Comment()
            {
                Id = 2,
                Content = "کامنت تست ۲",
                DateTime = DateTime.UtcNow,
                IsConfirmed = true,
                UserId = 1,
                NewsId = 2
            };

            var fakeComment3 = new Comment()
            {
                Id = 3,
                Content = "کامنت تست ۳",
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
