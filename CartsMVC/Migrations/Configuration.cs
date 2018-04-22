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
                    Description = "�D�B�z���GIntel Core i5-7200U , 2.5GHz<br />�D�O����G8GB DDR4 2400<br />�D�w�СG512G SSD<br />�DLCD�ؤo�G13.3\" FHD �������t���e�ù� (LED)<br />�D���о��G�L<br />�D��L�GUSB3.1*1�BUSB 3.0*1<br />�D���q�G1.45 KG (with 3 cell battery)<br />�D�@�~�t�ΡGWindows 10 Pro 64 bit<br />�D�O�T�G3�~��ګO�T/LCD 1�Ӥ�L�G�I�O�T/�x�W�a�Ϩ쩲���e ",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 10
                },
                new Product()
                {
                    Price = 14900,
                    Name = "Apple iPad 32G LTE �� (MP1L2TA/A)",
                    DefaultImageURL = "https://a.ecimg.tw/items/DYAM9BA90084FIO/000001_1524103328.jpg",
                    Description = "�D9.7 �T Retina ��ܾ�<br />�D64 �줸�[�c�� A9 ����<br />�DM9 ��P�B�z<br />�D800 �U����������Y<br />�D���F10�p�ɹq���ϥήɶ� ",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 20
                },
                new Product()
                {
                    Price = 9999,
                    Name = "�p�� Note 2",
                    DefaultImageURL = "https://a.ecimg.tw/items/DYAN1BA9008TYUL/000001_1522766169.jpg",
                    Description = "�D5.7�T�X�ʦ����ù� <br />�DŻ�s821�ʯ઩���q�Xĥ�B�z�� <br />�D6GB�O���� + 128GB�x�s�Ŷ� <br />�D2256�U�����W�������۾� <br />�D4070mAh�j�q�q�W����� ",
                    PublishDate = DateTime.Now,
                    CategoryId = 0,
                    Quantity = 0
                });
        }
    }
}
