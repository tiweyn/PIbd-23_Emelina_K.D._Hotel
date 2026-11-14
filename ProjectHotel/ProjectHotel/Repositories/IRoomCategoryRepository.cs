using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IRoomCategoryRepository
{
    IEnumerable<RoomCategory> ReadAll();
    RoomCategory ReadById(int id);
    void Create(RoomCategory category);
    void Update(RoomCategory category);
    void Delete(int id);
}
