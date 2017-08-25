using System;
using System.Collections.Generic;
using VehicleShowRoom.Core.Contracts;
using VehicleShowRoom.Entities;

namespace VehicleShowRoom.Core.Implementations
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private static List<Invoice> _invoice;
        public InvoiceRepository()
        {
            _invoice = new List<Invoice>();
        }
        public void Add(Invoice item)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Invoice item)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
