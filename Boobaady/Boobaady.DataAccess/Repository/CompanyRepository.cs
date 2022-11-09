using Boobaady.DataAccess;
using Boobaady.DataAccess.Repository;
using Boobaady.Models;
using Boobaady.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boobaady.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private BoobaadyDbContext _db;

        public CompanyRepository(BoobaadyDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
