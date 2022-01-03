using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        bool beginTransaction();

        bool rollBackTransaction();

        int saveChanges();
    }
}
