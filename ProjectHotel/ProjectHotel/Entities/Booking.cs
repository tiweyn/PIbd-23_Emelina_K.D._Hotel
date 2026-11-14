using ProjectHotel.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Операция: бронирование и проживание гостя
/// </summary>
public class Booking
{
    public int BookingId { get; private set; }
    public int GuestId { get; private set; }
    public int RoomId {  get; private set; }
    public DateTime CheckInDate { get; private set; }
    public DateTime CheckOutDate { get; private set; }
    public PaymentStatus PaymentStatus { get; private set; }
    public decimal TotalCost { get; private set; }

    public static Booking CreateOperation(int bookingId, int guestId, int roomId, DateTime checkInDate, DateTime checkOutDate, PaymentStatus paymentStatus, decimal totalCost)
    {
        return new Booking
        {
            BookingId = bookingId,
            GuestId = guestId,
            RoomId = roomId,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate,
            PaymentStatus = paymentStatus,
            TotalCost = totalCost
        };
    }
}
