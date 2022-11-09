using Boobaady.DataAccess;
using Boobaady.DataAccess.Repository;
using Boobaady.Models;
using Boobaady.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boobaady.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private BoobaadyDbContext _db;

        public OrderDetailRepository(BoobaadyDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderDetail obj)
        {
            _db.OrderDetail.Update(obj);
        }
    }
}
