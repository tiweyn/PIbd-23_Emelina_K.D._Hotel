using ProjectHotel.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Справочник: категория номера (эконом, стандарт, люкс)
/// </summary>
public class RoomCategory
{
    public int CategoryId { get; private set; }
    public string CategoryName { get; private set; } = string.Empty;
    public int Capacity { get; private set; }
    public decimal PricePerNight { get; private set; }
    public RoomAmenities Amenities { get; private set; }

    public static RoomCategory CreateEntity(int  categoryId, string categoryName, int capacity, decimal pricePerNight, RoomAmenities amenities)
    {
        return new RoomCategory
        {
            CategoryId = categoryId,
            CategoryName = categoryName ?? string.Empty,
            Capacity = capacity,
            PricePerNight = pricePerNight,
            Amenities = amenities

        };
    }

}
