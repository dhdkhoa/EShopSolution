using EShop.Data.Entities;
using EShop.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is Home Page of EShop" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword of EShop" },
                new AppConfig() { Key = "HomeDescription", Value = "This is Description of EShop" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language()
                {
                    Id = "vi-VN",
                    Name = "Tiếng Việt",
                    IsDefault = true
                },
                new Language()
                {
                    Id = "en-US",
                    Name = "English",
                    IsDefault = false
                });
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentID = null,
                    SortOrder = 2,
                    Status = Status.Active,
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Phần mềm",
                    LanguageId = "vi-VN",
                    SeoAlias = "phan-mem",
                    SeoDescription = "Các phần mềm quản lý kho, quản lý cửa hàng bán lẻ",
                    SeoTitle = "Các phần mềm quản lý kho, quản lý cửa hàng bán lẻ"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Software",
                    LanguageId = "en-US",
                    SeoAlias = "software",
                    SeoDescription = "Warehouse management software retail store management",
                    SeoTitle = "Warehouse management software retail store management"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Thiết kế website",
                    LanguageId = "vi-VN",
                    SeoAlias = "thiet-ke-website",
                    SeoDescription = "Thiết kế website cho cửa hàng, doanh nghiệp",
                    SeoTitle = "Thiết kế website cho cửa hàng, doanh nghiệp"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Design website",
                    LanguageId = "en-US",
                    SeoAlias = "design-website",
                    SeoDescription = "Website design for shops and businesses",
                    SeoTitle = "Website design for shops and businesses"
                });


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Phần mềm quản lý cửa hàng",
                    LanguageId = "vi-VN",
                    SeoAlias = "phan-mem-quan-ly-cua-hang",
                    SeoDescription = "Các phần mềm quản lý kho, quản lý cửa hàng bán lẻ",
                    SeoTitle = "Các phần mềm quản lý kho, quản lý cửa hàng bán lẻ",
                    Details = "Chi tiết sản phẩm",
                    Description = "Mô tả sản phẩm"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Software",
                    LanguageId = "en-US",
                    SeoAlias = "software-retail-store-management",
                    SeoDescription = "Warehouse management software retail store management",
                    SeoTitle = "Warehouse management software retail store management",
                    Details = "Details of product",
                    Description = "Description of product"
                });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId = 1,
                    CategoryId = 1,
                });

            var ADMIN_ID = new Guid("BA29E407-47A9-48C2-98AE-942C7FCEF6A1");
            var ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Adminsistrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "khoa.dinh@pap-tech.com",
                NormalizedEmail = "khoa.dinh@pap-tech.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Qpalzmz19"),
                SecurityStamp = string.Empty,
                FirstName = "Khoa",
                LastName="Dinh",
                Dob = new DateTime(2020,07,15),
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
