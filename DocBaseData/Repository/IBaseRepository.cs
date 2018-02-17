using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBaseData.Repository
{
    public interface IEntity
    {
        long Id { get; set; }
    }

    public interface IBaseRepository<T>
        where T : IEntity
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(string condition);

        T Find(long id);

        void Save(T item);

        void Delete(long id);
    }
}
