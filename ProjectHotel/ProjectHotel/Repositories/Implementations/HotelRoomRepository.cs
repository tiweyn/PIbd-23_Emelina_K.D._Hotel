using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations;

public class HotelRoomRepository : IHotelRoomRepository
{
    public void Create(HotelRoom room) => ArgumentNullException.ThrowIfNull(room);

    public void Update(HotelRoom room) => ArgumentNullException.ThrowIfNull(room);

    public void Delete(int id) { if (id <= 0) throw new ArgumentException("Некорректный ID", nameof(id)); }

    public HotelRoom ReadById(int id) => HotelRoom.CreateEntity(0, 0, string.Empty, 1);

    public IEnumerable<HotelRoom> ReadAll() => [];
}
