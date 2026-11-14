using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Справочник: конкретный номер в гостинице
/// </summary>
public class HotelRoom
{
    public int RoomId { get; private set; }
    public int CategoryId { get; private set; }
    public string RoomNumber { get; private set; } = string.Empty;
    public int Floor {  get; private set; }

    public static HotelRoom CreateEntity(int roomId, int categoryId, string roomNumber, int floor)
    {
        return new HotelRoom
        {
            RoomId = roomId,
            CategoryId = categoryId,
            RoomNumber = roomNumber ?? string.Empty,
            Floor = floor
        };
    }
}
