using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        public CartRepository(DBContext dBContext) : base(dBContext) { }
    }
}
