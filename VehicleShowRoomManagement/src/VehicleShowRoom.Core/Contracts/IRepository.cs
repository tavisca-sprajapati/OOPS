using System.Collections.Generic;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        List<T> GetAll();
        void Remove(int id);
        void Remove(T item);
    }
}
