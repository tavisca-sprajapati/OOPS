using System;
using System.Collections.Generic;
using VehicleShowRoom.Entities;
using VehicleShowRoom.Core.Contracts;

namespace VehicleShowRoom.Core.Implementations
{
    public class VehicleRepository : IVehicleRepository
    {
        private static List<Product> _vehicles;
        public VehicleRepository()
        {
            _vehicles = new List<Product>();
        }
        
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Product item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
