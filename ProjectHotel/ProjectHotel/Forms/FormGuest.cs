using System;
using System.IO;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormGuest : Form
{
    private readonly IGuestRepository _repository;
    private int? _guestId;

    public int Id
    {
        set
        {
            try
            {
                var guest = _repository.ReadById(value);
                if (guest == null) throw new InvalidDataException(nameof(guest));
                textBoxFullName.Text = guest.FullName;
                textBoxPhone.Text = guest.Phone;
                textBoxPassport.Text = guest.PassportNumber;
                _guestId = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    public FormGuest(IGuestRepository repository)
    {
        InitializeComponent();
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhone.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassport.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var entity = Guest.CreateEntity(_guestId ?? 0, textBoxFullName.Text, textBoxPhone.Text, textBoxPassport.Text);
            if (_guestId.HasValue) _repository.Update(entity);
            else _repository.Create(entity);

            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}