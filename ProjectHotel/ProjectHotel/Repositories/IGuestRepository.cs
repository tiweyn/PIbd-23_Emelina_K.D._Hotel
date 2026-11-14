using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IGuestRepository
{
    IEnumerable<Guest> ReadAll();
    Guest ReadById(int id);
    void Create(Guest guest);
    void Update(Guest guest);
    void Delete(int id);
}
