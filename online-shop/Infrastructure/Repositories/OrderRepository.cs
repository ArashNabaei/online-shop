using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DBContext dbContext) : base(dbContext) { }
    }
}
