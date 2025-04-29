using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MultiShop.Discount.Context
{
    public class DapperContext:DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString= _configuration.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7PLSN8S; initial Catalog=MultiShopDiscountDb; integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<MultiShop.Discount.Entities.Coupon> Coupons { get; set; }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
