using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations
{
    public class ServiceOrderRepository : IServiceOrderRepository
    {
        public void Create(ServiceOrder order) => ArgumentNullException.ThrowIfNull(order);
        public void Delete(int id) { if (id <= 0) throw new ArgumentException("Некорректный ID", nameof(id)); }

        public IEnumerable<ServiceOrder> ReadAll(DateTime? fromDate = null, DateTime? toDate = null, int? bookingId = null) => [];
    }
}
