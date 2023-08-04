using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll();//list yerine iquery çünkü bu sekilde direkt veritabanına gitme lolist/async gibi metodları ağırınca gider

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);                  //update-delete zaten track edildiği içiçn kısa sürüyo async kullanmıyorum
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);



    }
}





// The Func delegate points to a method that accepts parameters and returns a value;
//the Action delegate points to a method that accepts parameters but does not return a value (i.e., returns void).