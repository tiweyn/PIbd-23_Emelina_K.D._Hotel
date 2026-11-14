using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities.Enums;
/// <summary>
/// Статус оплаты бронирования
/// </summary>
public enum PaymentStatus
{
    None = 0,
    Pending = 1,
    Paid = 2,
    Rufunded = 3
}
