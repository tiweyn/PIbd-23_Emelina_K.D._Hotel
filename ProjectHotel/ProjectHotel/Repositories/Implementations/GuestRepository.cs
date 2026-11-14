using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations;

public class GuestRepository : IGuestRepository
{
    public void Create(Guest guest) => ArgumentNullException.ThrowIfNull(guest);

    public void Update(Guest guest) => ArgumentNullException.ThrowIfNull(guest);

    public void Delete(int id) { if (id <= 0) throw new ArgumentException("Некорректный ID", nameof(id)); }

    public Guest ReadById(int id) => Guest.CreateEntity(0, string.Empty, string.Empty, string.Empty);

    public IEnumerable<Guest> ReadAll() => [];
}
