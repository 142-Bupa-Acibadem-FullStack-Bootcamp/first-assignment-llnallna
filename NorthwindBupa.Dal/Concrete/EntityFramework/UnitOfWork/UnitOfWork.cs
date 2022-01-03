using NorthwindBupa.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Dal.Concreate.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public bool beginTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool rollBackTransaction()
        {
            throw new NotImplementedException();
        }

        public int saveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
