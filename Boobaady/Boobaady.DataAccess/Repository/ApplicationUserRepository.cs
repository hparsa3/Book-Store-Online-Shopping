using Boobaady.DataAccess.Repository.IRepository;
using Boobaady.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boobaady.DataAccess.Repository
{
    public class ApplicationUserRepository :Repository<ApplicationUser>,IApplicationUserRepository
    {
        private BoobaadyDbContext _db;

        public ApplicationUserRepository(BoobaadyDbContext db) : base(db)
        {
            _db = db;
        }

    }

    internal interface IShoppingCartReposity
    {
    }
}
