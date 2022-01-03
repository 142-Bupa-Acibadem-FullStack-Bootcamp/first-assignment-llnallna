using NorthwindBupa.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        List<TDto> GetAll();
        List<TDto> GetAll(Expression<Func<T, bool>> expression);

        TDto Find(int id);

        IQueryable<T> GetIQeryable();

        TDto Add(TDto item);

        Task<TDto> AddAsync(TDto item);
        bool DeleteById(int id);
        Task<bool> DeleteByIdAsync(int id);
        bool Delete(TDto item);
    }
   
}
