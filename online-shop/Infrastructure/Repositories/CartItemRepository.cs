using Domain.Repositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CartItemRepository : Repository<CartItemRepository>, ICartItemRepository
    {
        public CartItemRepository(DBContext dbContext) : base(dbContext) { }
    }
}
