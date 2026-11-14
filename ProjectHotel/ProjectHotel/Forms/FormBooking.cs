using System;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Entities.Enums;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormBooking : Form
{
    private readonly IBookingRepository _bookingRepository;

    public FormBooking(IBookingRepository bookingRepository, IGuestRepository guestRepository, IHotelRoomRepository roomRepository)
    {
        InitializeComponent();
        _bookingRepository = bookingRepository ?? throw new ArgumentNullException(nameof(bookingRepository));

        comboBoxGuest.DataSource = guestRepository.ReadAll();
        comboBoxGuest.DisplayMember = "FullName";
        comboBoxGuest.ValueMember = "GuestId";

        comboBoxRoom.DataSource = roomRepository.ReadAll();
        comboBoxRoom.DisplayMember = "RoomNumber";
        comboBoxRoom.ValueMember = "RoomId";

        comboBoxPaymentStatus.DataSource = Enum.GetValues(typeof(PaymentStatus));
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (comboBoxGuest.SelectedIndex < 0 || comboBoxRoom.SelectedIndex < 0 || comboBoxPaymentStatus.SelectedIndex < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (dateTimePickerCheckOut.Value <= dateTimePickerCheckIn.Value)
            {
                throw new Exception("Дата выезда должна быть позже даты заезда");
            }

            _bookingRepository.Create(Booking.CreateOperation(
                0,
                (int)comboBoxGuest.SelectedValue!,
                (int)comboBoxRoom.SelectedValue!,
                dateTimePickerCheckIn.Value,
                dateTimePickerCheckOut.Value,
                (PaymentStatus)comboBoxPaymentStatus.SelectedItem!,
                numericUpDownTotalCost.Value));

            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}