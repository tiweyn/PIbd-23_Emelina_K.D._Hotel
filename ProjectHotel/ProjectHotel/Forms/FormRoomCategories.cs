using System;
using System.Windows.Forms;
using Unity;
using ProjectHotel.Repositories;

namespace ProjectHotel.Forms;

public partial class FormRoomCategories : Form
{
    private readonly IUnityContainer _container;
    private readonly IRoomCategoryRepository _repository;

    public FormRoomCategories(IUnityContainer container, IRoomCategoryRepository repository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void FormRoomCategories_Load(object? sender, EventArgs e) => LoadList();

    private void ButtonAdd_Click(object? sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormRoomCategory>().ShowDialog();
            LoadList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonUpd_Click(object? sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var id)) return;
        try
        {
            var form = _container.Resolve<FormRoomCategory>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    }

    private void ButtonDel_Click(object? sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var id)) return;
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
        try
        {
            _repository.Delete(id);
            LoadList();
        }
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
        id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["CategoryId"].Value);
        return true;
    }
}