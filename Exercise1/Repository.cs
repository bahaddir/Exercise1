using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Repository<T> : IRepository<T> where T : class
    {
        List<T> data=new List<T>();
        public void Add(T entity)
        {
            data.Add(entity);
        }

        public void Delete(T entity)
        {
            data.Remove(entity);
        }

        public List<T> GetAll()
        {
            return data;
        }

        public void Update(T entity)
        {
        }
        public T GetById(int id)
        {
            var idProperty = typeof(T).GetProperty("Id");
            if (idProperty != null)
            {
                return data.FirstOrDefault(e => (int)idProperty.GetValue(e) == id);
            }
            return null;
        }
    }
}
