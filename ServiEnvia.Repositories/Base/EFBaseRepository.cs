using ServiEnvia.Data.EF.ConText;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ServiEnvia.Repositories.Base
{
    public abstract class EFBaseRepository : IEFBaseRepository
    {
        protected ServiEnviaDBEntities _context;

        public EFBaseRepository()
        {
        }

        public EFBaseRepository(ServiEnviaDBEntities dbContext)
        {
            _context = dbContext;
        }

        public void SaveChanges()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Add<T>(T item, bool saveChanges) where T : class
        {
            try
            {
                _context.Set(typeof(T)).Add(item);
                _context.Entry(item).State = EntityState.Added;
                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Edit<T>(T item, bool saveChanges) where T : class
        {
            try
            {
                if (!Exists(item)) _context.Set(typeof(T)).Attach(item);
                _context.Entry(item).State = EntityState.Modified;
                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete<T>(T item, bool saveChanges) where T : class
        {
            try
            {
                _context.Set(typeof(T)).Attach(item);
                _context.Entry(item).State = EntityState.Deleted;
                _context.Set(typeof(T)).Remove(item);

                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddList<T>(List<T> items, bool saveChanges) where T : class
        {
            try
            {
                foreach (T item in items)
                {
                    Add(item, false);
                }
                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void EditList<T>(List<T> items, bool saveChanges) where T : class
        {
            try
            {
                foreach (T item in items)
                {
                    Edit(item, false);
                }
                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteList<T>(List<T> items, bool saveChanges) where T : class
        {
            try
            {
                foreach (T item in items)
                {
                    Delete(item, false);
                }
                if (saveChanges) SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SetEntityState<T>(T Entity) where T : class
        {
            try
            {
                _context.Entry(Entity).State = EntityState.Unchanged;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Attach<T>(T Entity) where T : class
        {
            try
            {
                if (!Exists(Entity)) _context.Set(typeof(T)).Attach(Entity);
                _context.Entry(Entity).State = EntityState.Unchanged;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Detach<T>(T item) where T : class
        {
            try
            {
                _context.Entry(item).State = EntityState.Detached;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public bool Exists<T>(T entity) where T : class
        {
            try
            {
                return _context.Set<T>().Local.Any(e => e == entity);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Clear<T>() where T : class
        {
            _context.Set(typeof(T)).RemoveRange(_context.Set(typeof(T)));
            SaveChanges();
        }
    }
}
