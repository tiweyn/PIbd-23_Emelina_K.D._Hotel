namespace ProjectHotel.Forms;

partial class FormServiceOrder
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelBooking = null!;
    private ComboBox comboBoxBooking = null!;
    private GroupBox groupBoxServices = null!;
    private DataGridView dataGridViewServices = null!;
    private DataGridViewComboBoxColumn ColumnService = null!;
    private DataGridViewTextBoxColumn ColumnCount = null!;
    private Button buttonSave = null!;
    private Button buttonCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelBooking = new Label();
        comboBoxBooking = new ComboBox();
        groupBoxServices = new GroupBox();
        dataGridViewServices = new DataGridView();
        ColumnService = new DataGridViewComboBoxColumn();
        ColumnCount = new DataGridViewTextBoxColumn();
        buttonSave = new Button();
        buttonCancel = new Button();
        groupBoxServices.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
        SuspendLayout();

        labelBooking.Location = new Point(20, 25);
        labelBooking.Size = new Size(120, 23);
        labelBooking.Text = "Бронирование:";

        comboBoxBooking.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxBooking.Location = new Point(150, 22);
        comboBoxBooking.Name = "comboBoxBooking";
        comboBoxBooking.Size = new Size(220, 28);

        groupBoxServices.Controls.Add(dataGridViewServices);
        groupBoxServices.Location = new Point(20, 65);
        groupBoxServices.Name = "groupBoxServices";
        groupBoxServices.Size = new Size(350, 210);
        groupBoxServices.Text = "Выбранные услуги";

        dataGridViewServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewServices.Columns.AddRange([ColumnService, ColumnCount]);
        dataGridViewServices.Dock = DockStyle.Fill;
        dataGridViewServices.Name = "dataGridViewServices";
        dataGridViewServices.RowHeadersVisible = false;

        ColumnService.HeaderText = "Услуга";
        ColumnService.Name = "ColumnService";

        ColumnCount.HeaderText = "Количество";
        ColumnCount.Name = "ColumnCount";

        buttonSave.Location = new Point(70, 295);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.Text = "Сохранить";
        buttonSave.Click += ButtonSave_Click;

        buttonCancel.Location = new Point(210, 295);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.Text = "Отмена";
        buttonCancel.Click += ButtonCancel_Click;

        ClientSize = new Size(390, 350);
        Controls.AddRange([labelBooking, comboBoxBooking, groupBoxServices, buttonSave, buttonCancel]);
        Name = "FormServiceOrder";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Заказ дополнительных услуг";
        groupBoxServices.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}