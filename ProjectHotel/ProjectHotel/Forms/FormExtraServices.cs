using System;
using System.Windows.Forms;
using Unity;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormExtraServices : Form
{
    private readonly IUnityContainer _container;
    private readonly IExtraServiceRepository _repository;

    public FormExtraServices(IUnityContainer container, IExtraServiceRepository repository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void FormExtraServices_Load(object? sender, EventArgs e) => LoadList();

    private void ButtonAdd_Click(object? sender, EventArgs e)
    {
        try { _container.Resolve<FormExtraService>().ShowDialog(); LoadList(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonUpd_Click(object? sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var id)) return;
        try
        {
            var form = _container.Resolve<FormExtraService>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonDel_Click(object? sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var id)) return;
        if (MessageBox.Show("Удалить услугу?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        try { _repository.Delete(id); LoadList(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void LoadList()
    {
        try { dataGridViewData.DataSource = _repository.ReadAll(); }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewData.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["ServiceId"].Value);
        return true;
    }
}