using Example2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Example2.Repositories
{
    //t hem class olmali hem de ientity kullanmali
    public class GenericRepository<T> : IRepository<T> where T : class,IEntity
    {
        List<T> data = new List<T>();

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

        public T GetById(Guid Guid)
        {
            /*
            var idProperty = typeof(T).GetProperty("Guid");
            if (idProperty != null)
            {
                return data.FirstOrDefault(e => (Guid)idProperty.GetValue(e) == Guid);
            }
            return null;
            */
            
            return data.FirstOrDefault(e => e.Guid == Guid);

            
        }

        public void Update(T entity)
        {
            /*
            // 1. Güncellenecek nesnenin listedeki indeksini (sırasını) bul.
            // T, IEntity arayüzünü uyguladığı için (where T : class, IEntity),
            // T'yi IEntity'e dönüştürerek Guid özelliğine güvenle erişebiliriz.

            // Güncellenen nesnenin Guid değerini al
            Guid entityGuid = ((IEntity)entity).Guid;

            // Listede, bu Guid değerine sahip nesnenin indeksini bul.
            int index = _data.FindIndex(e => ((IEntity)e).Guid == entityGuid);

            if (index != -1)
            {
                // 2. Eğer nesne listede bulunduysa (index -1 değilse),
                // o indeksteki eski nesneyi, parametre olarak gelen yeni nesne (entity) ile değiştir.
                _data[index] = entity;
            }
            else
            {
                // 3. (Opsiyonel) Nesne bulunamazsa bir hata fırlatılabilir.
                // Bu, kullanıcının olmayan bir şeyi güncellemeye çalıştığı anlamına gelir.
                throw new KeyNotFoundException($"Guid: {entityGuid} değerine sahip bir nesne bulunamadı.");
            }
            */

        }
    }
}
