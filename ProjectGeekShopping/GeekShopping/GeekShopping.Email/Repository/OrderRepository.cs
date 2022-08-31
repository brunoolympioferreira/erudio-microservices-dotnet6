using GeekShopping.Email.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Email.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContextOptions<MySQLContext> _context;

        public OrderRepository(DbContextOptions<MySQLContext> context)
        {
            _context = context;
        }
        public async Task UpdateOrderPaymentStatus(long orderHeaderId, bool status)
        {
            //await using var _db = new MySQLContext(_context);
            //var header = await _db.Headers.FirstOrDefaultAsync(o => o.Id == orderHeaderId);

            //if (header != null)
            //{
            //    header.PaymentStatus = status;
            //    await _db.SaveChangesAsync();
            //}
        }
    }
}
