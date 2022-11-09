using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boobaady.DataAccess.DbInitializer
{
    public interface IDbInitializer
    {
        void Initialize();
    }
}
