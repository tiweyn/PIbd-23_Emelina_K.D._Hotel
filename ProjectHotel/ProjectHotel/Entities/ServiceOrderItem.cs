using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Класс-связка: одна позиция услуги внутри заказа
/// </summary>
public class ServiceOrderItem
{
    public int OrderId { get; private set; }
    public int ServiceId { get; private set; }
    public int Count { get; private set; }

    public static ServiceOrderItem CreateElement(int orderId,  int serviceId, int count)
    {
        return new ServiceOrderItem
        {
            OrderId = orderId,
            ServiceId = serviceId,
            Count = count
        };
    }
}
