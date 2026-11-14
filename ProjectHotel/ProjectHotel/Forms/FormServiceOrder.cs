using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectHotel.Entities;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormServiceOrder : Form
{
    private readonly IServiceOrderRepository _orderRepository;

    public FormServiceOrder(IServiceOrderRepository orderRepository, IBookingRepository bookingRepository, IExtraServiceRepository serviceRepository)
    {
        InitializeComponent();
        _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));

        comboBoxBooking.DataSource = bookingRepository.ReadAll();
        comboBoxBooking.DisplayMember = "BookingId";
        comboBoxBooking.ValueMember = "BookingId";

        ColumnService.DataSource = serviceRepository.ReadAll();
        ColumnService.DisplayMember = "ServiceName";
        ColumnService.ValueMember = "ServiceId";
    }

    private void ButtonSave_Click(object? sender, EventArgs e)
    {
        try
        {
            if (comboBoxBooking.SelectedIndex < 0 || dataGridViewServices.RowCount < 1)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            var items = CreateListItemsFromDataGrid();
            if (items.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }

            _orderRepository.Create(ServiceOrder.CreateOperation(0, (int)comboBoxBooking.SelectedValue!, items));
            Close();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private List<ServiceOrderItem> CreateListItemsFromDataGrid()
    {
        var list = new List<ServiceOrderItem>();
        foreach (DataGridViewRow row in dataGridViewServices.Rows)
        {
            if (row.Cells["ColumnService"].Value == null || row.Cells["ColumnCount"].Value == null)
            {
                continue;
            }
            list.Add(ServiceOrderItem.CreateElement(0, Convert.ToInt32(row.Cells["ColumnService"].Value), Convert.ToInt32(row.Cells["ColumnCount"].Value)));
        }
        return list;
    }

    private void ButtonCancel_Click(object? sender, EventArgs e) => Close();
}