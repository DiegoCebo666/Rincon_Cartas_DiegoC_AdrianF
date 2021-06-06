using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RinconDL.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        int Login(string username, string password);
        IEnumerable<T> GetByFilter(Func<T, bool> predicate);
        IEnumerable<T> GetBySQL(string sql);
        void Insert(T entity);
        void Update(T entity);
        void Delete(object id);
        bool Exists(Func<T, bool> predicate);
        IEnumerable<T> GetBySql(String sql);
        T FindOne();
        void DeleteBySql(String sql);
    }
}
