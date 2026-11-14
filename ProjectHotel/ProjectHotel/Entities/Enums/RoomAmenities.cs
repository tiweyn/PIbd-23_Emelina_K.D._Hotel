using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities.Enums;
/// <summary>
/// Удобства в категории номера
/// </summary>
[Flags]
public enum RoomAmenities
{
    None = 0,
    WiFi = 1,
    Conditioner = 2,
    TV = 4,
    Safe = 8,
    Balcony = 16
}
