using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations;

public class ExtraServiceRepository : IExtraServiceRepository
{
    public void Create(ExtraService service) => ArgumentNullException.ThrowIfNull(service);

    public void Update(ExtraService service) => ArgumentNullException.ThrowIfNull(service);

    public void Delete(int id) { if (id <= 0) throw new ArgumentException("Некорректный ID", nameof(id)); }

    public ExtraService ReadById(int id) => ExtraService.CreateEntity(0, string.Empty, 0);

    public IEnumerable<ExtraService> ReadAll() => [];
}
