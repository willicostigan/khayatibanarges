using System.Collections.Generic;
using _01_KhayatibanargesQuery.Contracts.ArticleCategory;
using _01_KhayatibanargesQuery.Contracts.ProductCategory;

namespace _01_KhayatibanargesQuery
{
    public class MenuModel
    {
        public List<ArticleCategoryQueryModel> ArticleCategories { get; set; }
        public List<ProductCategoryQueryModel> ProductCategories { get; set; }
    }
}
