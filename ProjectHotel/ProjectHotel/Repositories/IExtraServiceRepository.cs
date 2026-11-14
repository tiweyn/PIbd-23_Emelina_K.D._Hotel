using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IExtraServiceRepository
{
    IEnumerable<ExtraService> ReadAll();
    ExtraService ReadById(int id);
    void Create(ExtraService service);
    void Update(ExtraService service);
    void Delete(int id);
}
