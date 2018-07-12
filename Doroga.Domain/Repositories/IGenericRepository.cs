using System;
using System.Collections.Generic;
using System.Text;

namespace Doroga.Domain.Repositories
{
    public interface IGenericRepository<T> : IDisposable
    where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        void Save();
    }
}
