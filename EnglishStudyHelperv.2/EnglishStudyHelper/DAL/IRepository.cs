using System.Collections.Generic;

namespace EnglishStudyHelper.DAL
{
    interface IRepository<T>
        where T : class
    {
        IEnumerable<T> GetListAll();
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
       
    }
}
