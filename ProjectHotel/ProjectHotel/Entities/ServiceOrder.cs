using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Операция: заказ доп услуг к проживанию
/// </summary>
public class ServiceOrder
{
    public int OrderId { get; private set; }
    public int BookingId { get; private set; }
    public DateTime OrderDate { get; private set; }
    public IEnumerable<ServiceOrderItem> Items { get; private set; } = [];

    public static ServiceOrder CreateOperation(int orderId,  int bookingId, IEnumerable<ServiceOrderItem> items)
    {
        return new ServiceOrder
        {
            OrderId = orderId,
            BookingId = bookingId,
            OrderDate = DateTime.Now,
            Items = items ?? []
        };
    }

}
