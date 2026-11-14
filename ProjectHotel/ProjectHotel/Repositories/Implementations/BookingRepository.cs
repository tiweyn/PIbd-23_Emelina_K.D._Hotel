using ProjectHotel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Repositories.Implementations;

public class BookingRepository : IBookingRepository
{
    public void Create(Booking booking) => ArgumentNullException.ThrowIfNull(booking);
    public IEnumerable<Booking> ReadAll(DateTime? fromDate = null, DateTime? toDate = null, int? guestId = null, int? roomId = null) => [];
}
