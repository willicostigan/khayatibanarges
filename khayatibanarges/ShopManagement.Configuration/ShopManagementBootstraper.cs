using _01_KhayatibanargesQuery.Contracts.Product;
using _01_KhayatibanargesQuery.Contracts.ProductCategory;
using _01_KhayatibanargesQuery.Contracts.Slide;
using _01_KhayatibanargesQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Product;
using ShopManagement.Application.Contracts.ProductCategory;
using ShopManagement.Application.Contracts.ProductPicture;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.ProductAgg;
using ShopManagement.Domain.ProductCategoryAgg;
using ShopManagement.Domain.ProductPictureAgg;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstraper
    {
        public static void Configure(IServiceCollection Services, string connectionString)
        {
            Services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            Services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            Services.AddTransient<IProductApplication, ProductApplication>();
            Services.AddTransient<IProductRepository, ProductRepository>();

            Services.AddTransient<IProductPictureApplication, ProductPictureApplication>();
            Services.AddTransient<IProductPictureRepository, ProductPictureRepository>();

            Services.AddTransient<ISlideApplication, SlideApplication>();
            Services.AddTransient<ISlideRepository, SlideRepository>();
            
            Services.AddTransient<ISlideQuery, SlideQuery>();
            Services.AddTransient<IProductCategoryQuery, ProductCategoryQuery>();
            Services.AddTransient<IProductQuery, ProductQuery>();

            Services.AddDbContext<ShopContext>(x => x.UseSqlServer(connectionString));
        }
    }
}