using CartsMVC.Models;

namespace CartsMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CartsMVC.Models.CartsDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CartsMVC.Models.CartsDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Users.AddOrUpdate(
                new User
                {
                    Id = "1",
                    Email = "Example@mail.com.tw",
                    UserName = "admim",
                    Password = "admin",
                    Roles = "API"
                });

            context.Products.AddOrUpdate(
                new Product()
                {
                    Price = 27900,
                    Name = "ASUS BX310UA-0611A7200U",
                    DefaultImageURL = "https://a.ecimg.tw/items/DHAFFQA9008K07F/000001_1522202553.jpg",
                    Description = "● 處理器：Intel Core i5-7200U , 2.5GHz <br />● 記憶體：8GB DDR4 2400<br />● 硬碟：512G SSD <br />● LCD尺寸：13.3\" FHD 霧面防眩光寬螢幕(LED) < br />● 光碟機：無<br />● 其他：USB3.1*1、USB 3.0*1 <br />● 重量：1.45 KG (with 3 cell battery) <br />● 作業系統：Windows 10 Pro 64 bit <br />● 保固：3年國際保固/LCD 1個月無亮點保固/台灣地區到府收送",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 10
                },
                new Product()
                {
                    Price = 14900,
                    Name = "Apple iPad 32G LTE 銀 (MP1L2TA/A)",
                    DefaultImageURL = "https://a.ecimg.tw/items/DYAM9BA90084FIO/000001_1524103328.jpg",
                    Description = "● 9.7 吋 Retina 顯示器 <br />● 64 位元架構的 A9 晶片 <br />● M9 協同處理<br />● 800 萬像素攝錄鏡頭 <br />● 長達10小時電池使用時間 ",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 20
                },
                new Product()
                {
                    Price = 9999,
                    Name = "小米 Note 2",
                    DefaultImageURL = "https://a.ecimg.tw/items/DYAN1BA9008TYUL/000001_1522766169.jpg",
                    Description = "● 5.7吋柔性曲面螢幕<br />● 驍龍821性能版高通旗艦處理器 <br />● 6GB記憶體 + 128GB儲存空間 <br />● 2256萬像素超高像素相機 <br />● 4070mAh大電量超長續航",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 0
                });
        }
    }
}
