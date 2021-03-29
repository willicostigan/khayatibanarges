using System.Collections.Generic;
using _0_Framework.Infrastructure;

namespace ShopManagement.Configuration.Permissions
{
    public class ShopPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDto>> Expose()
        {
            return new Dictionary<string, List<PermissionDto>>
            {
                {
                    "Product", new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ProductList, "ListProduct"),
                        new PermissionDto(ShopPermissions.ProductSearch, "SearchProduct"),
                        new PermissionDto(ShopPermissions.ProductCreate, "CreateProduct"),
                        new PermissionDto(ShopPermissions.ProductEdit, "EditProduct")
                    }
                },
                {
                    "ProductCategory" , new List<PermissionDto>
                    {
                        new PermissionDto(ShopPermissions.ProductCategoryList,"ListProductCategories"),
                        new PermissionDto(ShopPermissions.ProductCategorySearch,"SearchProductCategories"),
                        new PermissionDto(ShopPermissions.ProductCategoryCreate,"CreateProductCategory"),
                        new PermissionDto(ShopPermissions.ProductCategoryEdit,"EditProductCategory"),
                    }
                }
            };
        }
    }
}
