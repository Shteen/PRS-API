using PRS.Core.Entites;
using PRS.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS.DATA.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly OtherDbContext _context;

        public UserRepository(OtherDbContext context)
        {
            _context= context;
        }

		public Task<List<User>> GetAll()
		{
			return _context.User.OrderBy(p => p.UserName).ToListAsync();
		}
	}
}
