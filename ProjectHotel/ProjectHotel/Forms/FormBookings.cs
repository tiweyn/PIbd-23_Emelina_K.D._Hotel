using System;
using System.Windows.Forms;
using Unity;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormBookings : Form
{
    private readonly IUnityContainer _container;
    private readonly IBookingRepository _repository;

    public FormBookings(IUnityContainer container, IBookingRepository repository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void FormBookings_Load(object? sender, EventArgs e) => LoadList();

    private void ButtonAdd_Click(object? sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormBooking>().ShowDialog();
            LoadList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void LoadList()
    {
        try { dataGridViewData.DataSource = _repository.ReadAll(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
}