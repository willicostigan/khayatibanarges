using System.Collections.Generic;

namespace _01_KhayatibanargesQuery.Contracts.Product
{
    public interface IProductQuery
    {
        List<ProductQueryModel> GetLatestArrivals();
    }
}
