using Dapper;
using Ecommerce_server.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace DBAccess.Services
{
    public interface IProductService
    {
        Task<Product?> GetProduct(string productId);
        //Task<IServiceResult> AddProduct(Product product);
    }

    public class ProductService : IProductService
    {
        private static string connectionStr;
        private static string tableName = "products";

        public ProductService(ISettingsService settings)
        {
            connectionStr = settings.DBConnectionString;
        }

        public async Task<Product?> GetProduct(string productId)
        {
            using (IDbConnection dbc = new MySqlConnection(connectionStr))
            {
                string command = $"SELECT * FROM {tableName} WHERE productId=4;";
                try
                {
                    // use enum in products table for category
                    var result = await dbc.QueryAsync<Product>(command);   // Using Dapper Lib
                    var modelList = result.ToList();

                    Console.WriteLine($"Product returned: {modelList[0].Name}");
                    return modelList[0];
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
