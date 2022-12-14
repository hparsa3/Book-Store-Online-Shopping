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
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private BoobaadyDbContext _db;

        public CoverTypeRepository(BoobaadyDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);
        }
    }
}
