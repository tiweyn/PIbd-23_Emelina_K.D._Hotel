using System;
using System.IO;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormHotelRoom : Form
{
    private readonly IHotelRoomRepository _roomRepository;
    private int? _roomId;

    public int Id
    {
        set
        {
            try
            {
                var room = _roomRepository.ReadById(value);
                if (room == null) throw new InvalidDataException(nameof(room));
                textBoxNumber.Text = room.RoomNumber;
                numericUpDownFloor.Value = room.Floor;
                comboBoxCategory.SelectedValue = room.CategoryId;
                _roomId = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    public FormHotelRoom(IHotelRoomRepository roomRepository, IRoomCategoryRepository categoryRepository)
    {
        InitializeComponent();
        _roomRepository = roomRepository ?? throw new ArgumentNullException(nameof(roomRepository));
        comboBoxCategory.DataSource = categoryRepository.ReadAll();
        comboBoxCategory.DisplayMember = "CategoryName";
        comboBoxCategory.ValueMember = "CategoryId";
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxNumber.Text) || comboBoxCategory.SelectedIndex < 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var entity = HotelRoom.CreateEntity(_roomId ?? 0, (int)comboBoxCategory.SelectedValue!, textBoxNumber.Text, (int)numericUpDownFloor.Value);
            if (_roomId.HasValue) _roomRepository.Update(entity);
            else _roomRepository.Create(entity);

            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}