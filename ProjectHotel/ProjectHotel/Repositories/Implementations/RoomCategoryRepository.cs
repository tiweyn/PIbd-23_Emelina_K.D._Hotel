using ProjectHotel.Entities;
using ProjectHotel.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations;

public class RoomCategoryRepository : IRoomCategoryRepository
{
    public void Create(RoomCategory category) => ArgumentNullException.ThrowIfNull(category);

    public void Update(RoomCategory category) => ArgumentNullException.ThrowIfNull(category);

    public void Delete(int id) { if (id <= 0) throw new ArgumentException("Некорректный ID", nameof(id)); }

    public RoomCategory ReadById(int id) => RoomCategory.CreateEntity(0, string.Empty, 1, 0, RoomAmenities.None);

    public IEnumerable<RoomCategory> ReadAll() => [];
}
