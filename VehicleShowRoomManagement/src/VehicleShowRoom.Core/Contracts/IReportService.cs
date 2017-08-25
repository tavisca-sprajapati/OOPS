using System.Collections.Generic;

namespace VehicleShowRoom.Core.Contracts
{
    public interface IReportService<T>
    {
        List<T> GetAll();
    }
}
