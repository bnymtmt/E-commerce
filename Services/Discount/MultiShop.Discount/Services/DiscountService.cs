using Dapper;
using MultiShop.Discount.Context;
using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public class DiscountService : IDiscountService
    {
        private readonly DapperContext _context;

        public DiscountService(DapperContext context)
        {
            _context = context;
        }

        public async Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto)
        {
            string query = "INSERT INTO Coupons (Code, Rate, IsActive, ValidDate) VALUES (@code, @rate, @isActive, @validDate)";
            var parameters = new DynamicParameters();
            parameters.Add("@code", createCouponDto.Code);
            parameters.Add("@rate", createCouponDto.Rate);
            parameters.Add("@isActive", createCouponDto.IsActive);
            parameters.Add("@validDate", createCouponDto.ValidDate);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteDiscountCouponAsync(int id)
        {
            string query = "DELETE FROM Coupons WHERE CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponAsync()
        {
            string query = "SELECT * FROM Coupons";
            using (var connection = _context.CreateConnection())
            {
                var values = await  connection.QueryAsync<ResultDiscountCouponDto>(query);
                return (values.ToList());
            }
        }

        public async Task<GetByIdDiscountCouponDto> GetByIdDiscountCoupunAsync(int id)
        {
            string query = "SELECT * FROM Coupons WHERE CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@couponId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdDiscountCouponDto>(query, parameters);
                return values;
            }
        }

        public async Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto)
        {
            string query = "UPDATE Coupons SET Code = @code, Rate = @rate, IsActive = @isActive, ValidDate = @validDate WHERE CouponId = @couponId";
            var parameters = new DynamicParameters();
            parameters.Add("@code", updateCouponDto.Code);
            parameters.Add("@rate", updateCouponDto.Rate);
            parameters.Add("@isActive", updateCouponDto.IsActive);
            parameters.Add("@validDate", updateCouponDto.ValidDate);
            parameters.Add("@couponId", updateCouponDto.CouponId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
