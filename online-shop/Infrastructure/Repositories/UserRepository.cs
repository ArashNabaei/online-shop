using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBContext dbContext) : base(dbContext)
        {
        }

        // Add the additional logics to the code here
        //public async Task<User> GetUserByEmailAsync(string email)
        //{
        //    return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        //}
    }
}
