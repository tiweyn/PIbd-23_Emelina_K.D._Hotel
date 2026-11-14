using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IHotelRoomRepository
{
    IEnumerable<HotelRoom> ReadAll();
    HotelRoom ReadById(int id);
    void Create(HotelRoom room);
    void Update(HotelRoom room);
    void Delete(int id);
}
