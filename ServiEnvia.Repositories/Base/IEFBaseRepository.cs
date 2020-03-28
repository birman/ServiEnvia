using System.Collections.Generic;

namespace ServiEnvia.Repositories.Base
{
    public interface IEFBaseRepository
    {
        void SaveChanges();

        void Add<T>(T item, bool saveChanges) where T : class;

        void Edit<T>(T item, bool saveChanges) where T : class;

        void Delete<T>(T item, bool saveChanges) where T : class;

        void AddList<T>(List<T> items, bool saveChanges) where T : class;

        void EditList<T>(List<T> items, bool saveChanges) where T : class;

        void DeleteList<T>(List<T> item, bool saveChanges) where T : class;

        void SetEntityState<T>(T Entity) where T : class;

        void Attach<T>(T Entity) where T : class;

        void Detach<T>(T item) where T : class;

        bool Exists<T>(T entity) where T : class;

        void Clear<T>() where T : class;
    }
}
