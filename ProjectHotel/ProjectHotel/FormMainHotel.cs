using System;
using System.Windows.Forms;
using Unity;
using ProjectHotel.Forms;

namespace ProjectHotel;

public partial class FormMainHotel : Form
{
    private readonly IUnityContainer _container;

    public FormMainHotel(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void CategoriesToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormRoomCategories>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void RoomsToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormHotelRooms>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void GuestsToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormGuests>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ExtraServicesToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormExtraServices>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void BookingsToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormBookings>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ServiceOrdersToolStripMenuItem_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormServiceOrders>().ShowDialog(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }
}