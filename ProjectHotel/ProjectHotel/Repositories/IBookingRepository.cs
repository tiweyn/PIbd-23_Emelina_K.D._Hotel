using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories;

public interface IBookingRepository
{
    IEnumerable<Booking> ReadAll(DateTime? fromDate = null, DateTime? toDate = null, int? guestId = null, int? roomId = null);
    void Create(Booking booking);
}
