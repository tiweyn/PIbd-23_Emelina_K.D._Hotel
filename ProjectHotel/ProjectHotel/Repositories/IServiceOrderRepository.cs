using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IServiceOrderRepository
{
    IEnumerable<ServiceOrder> ReadAll(DateTime? fromDate = null, DateTime? toDate = null, int? bookingId = null);
    void Create(ServiceOrder order);
    void Delete(int id);
}
