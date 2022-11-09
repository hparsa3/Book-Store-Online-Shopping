using Boobaady.DataAccess.Repository.IRepository;
using Boobaady.Models;

namespace Boobaady.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private BoobaadyDbContext _db;

        public ShoppingCartRepository(BoobaadyDbContext db) : base(db)
        {
            _db = db;
        }

        public int DecrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count -= count;
            return shoppingCart.Count;
        }

        public int IncrementCount(ShoppingCart shoppingCart, int count)
        {
            shoppingCart.Count += count;
            return shoppingCart.Count;
        }

        public void Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}