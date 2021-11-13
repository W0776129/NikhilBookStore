using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NikhilBookStore.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);  //retrive category by id
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            String includeProperties = null  //usefull for foreign key refrences
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            String includeProperties = null
            );


    }
}
