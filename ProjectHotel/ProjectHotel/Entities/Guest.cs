using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHotel.Entities;
/// <summary>
/// Справочник: гость гостиницы
/// </summary>
public class Guest
{
    public int GuestId { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;
    public string PassportNumber { get; private set; } = string.Empty;

    public static Guest CreateEntity(int guestId, string fullName, string phone, string passportNumber)
    {
        return new Guest
        {
            GuestId = guestId,
            FullName = fullName ?? string.Empty,
            Phone = phone ?? string.Empty,
            PassportNumber = passportNumber ?? string.Empty
        };
    }
}
