namespace ProjectHotel.Forms;

partial class FormServiceOrders
{
    private System.ComponentModel.IContainer components = null!;
    private DataGridView dataGridViewData = null!;
    private Panel panelButtons = null!;
    private Button buttonAdd = null!;
    private Button buttonDel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        dataGridViewData = new DataGridView();
        panelButtons = new Panel();
        buttonAdd = new Button();
        buttonDel = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
        panelButtons.SuspendLayout();
        SuspendLayout();

        dataGridViewData.AllowUserToAddRows = false;
        dataGridViewData.AllowUserToDeleteRows = false;
        dataGridViewData.AllowUserToResizeColumns = false;
        dataGridViewData.AllowUserToResizeRows = false;
        dataGridViewData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewData.Dock = DockStyle.Fill;
        dataGridViewData.MultiSelect = false;
        dataGridViewData.Name = "dataGridViewData";
        dataGridViewData.ReadOnly = true;
        dataGridViewData.RowHeadersVisible = false;
        dataGridViewData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewData.Size = new Size(660, 400);

        panelButtons.Controls.AddRange([buttonAdd, buttonDel]);
        panelButtons.Dock = DockStyle.Right;
        panelButtons.Size = new Size(140, 400);

        buttonAdd.Location = new Point(15, 20);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(110, 35);
        buttonAdd.Text = "Добавить";
        buttonAdd.Click += ButtonAdd_Click;

        buttonDel.Location = new Point(15, 70);
        buttonDel.Name = "buttonDel";
        buttonDel.Size = new Size(110, 35);
        buttonDel.Text = "Удалить";
        buttonDel.Click += ButtonDel_Click;

        ClientSize = new Size(800, 400);
        Controls.Add(dataGridViewData);
        Controls.Add(panelButtons);
        Name = "FormServiceOrders";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Заказы дополнительных услуг";
        Load += FormServiceOrders_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
        panelButtons.ResumeLayout(false);
        ResumeLayout(false);
    }
}