using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormExtraService : Form
{
    private readonly IExtraServiceRepository _repository;
    private int? _serviceId;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var service = _repository.ReadById(value);
                if (service == null) throw new InvalidDataException(nameof(service));
                textBoxName.Text = service.ServiceName;
                numericUpDownPrice.Value = service.Price;
                _serviceId = value;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    public FormExtraService(IExtraServiceRepository repository)
    {
        InitializeComponent();
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var entity = ExtraService.CreateEntity(_serviceId ?? 0, textBoxName.Text, numericUpDownPrice.Value);
            if (_serviceId.HasValue) _repository.Update(entity);
            else _repository.Create(entity);

            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}