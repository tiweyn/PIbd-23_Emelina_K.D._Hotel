using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Справочник: дополнительная платная усуга
/// </summary>
public class ExtraService
{
    public int ServiceId { get; private set; }
    public string ServiceName { get; private set; } = string.Empty;
    public decimal Price { get; private set; }

    public static ExtraService CreateEntity(int serviceId, string serviceName, decimal price)
    {
        return new ExtraService
        {
            ServiceId = serviceId,
            ServiceName = serviceName ?? string.Empty,
            Price = price
        };
    }
}
