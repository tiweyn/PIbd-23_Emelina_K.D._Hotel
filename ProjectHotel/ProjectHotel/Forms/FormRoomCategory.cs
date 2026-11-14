using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Entities.Enums;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormRoomCategory : Form
{
    private readonly IRoomCategoryRepository _repository;
    private int? _categoryId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var category = _repository.ReadById(value);
                if (category == null) throw new InvalidDataException(nameof(category));

                textBoxName.Text = category.CategoryName;
                numericUpDownCapacity.Value = category.Capacity;
                numericUpDownPrice.Value = category.PricePerNight;

                for (int i = 0; i < checkedListBoxAmenities.Items.Count; i++)
                {
                    var item = (RoomAmenities)checkedListBoxAmenities.Items[i];
                    checkedListBoxAmenities.SetItemChecked(i, (category.Amenities & item) != 0);
                }
                _categoryId = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    public FormRoomCategory(IRoomCategoryRepository repository)
    {
        InitializeComponent();
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        foreach (var elem in Enum.GetValues<RoomAmenities>())
        {
            if (elem != RoomAmenities.None)
            {
                checkedListBoxAmenities.Items.Add(elem);
            }
        }
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || checkedListBoxAmenities.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            RoomAmenities amenities = RoomAmenities.None;
            foreach (var item in checkedListBoxAmenities.CheckedItems)
            {
                amenities |= (RoomAmenities)item;
            }

            var entity = RoomCategory.CreateEntity(_categoryId ?? 0, textBoxName.Text, (int)numericUpDownCapacity.Value, numericUpDownPrice.Value, amenities);
            if (_categoryId.HasValue) _repository.Update(entity);
            else _repository.Create(entity);

            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}