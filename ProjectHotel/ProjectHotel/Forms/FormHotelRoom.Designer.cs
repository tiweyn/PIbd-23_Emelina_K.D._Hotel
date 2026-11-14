namespace ProjectHotel.Forms;

partial class FormHotelRoom
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelNumber = null!;
    private TextBox textBoxNumber = null!;
    private Label labelFloor = null!;
    private NumericUpDown numericUpDownFloor = null!;
    private Label labelCategory = null!;
    private ComboBox comboBoxCategory = null!;
    private Button buttonSave = null!;
    private Button buttonCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelNumber = new Label();
        textBoxNumber = new TextBox();
        labelFloor = new Label();
        numericUpDownFloor = new NumericUpDown();
        labelCategory = new Label();
        comboBoxCategory = new ComboBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownFloor).BeginInit();
        SuspendLayout();

        labelNumber.Location = new Point(20, 25);
        labelNumber.Size = new Size(120, 23);
        labelNumber.Text = "Номер комнаты:";

        textBoxNumber.Location = new Point(150, 22);
        textBoxNumber.Name = "textBoxNumber";
        textBoxNumber.Size = new Size(200, 27);

        labelFloor.Location = new Point(20, 65);
        labelFloor.Size = new Size(120, 23);
        labelFloor.Text = "Этаж:";

        numericUpDownFloor.Location = new Point(150, 63);
        numericUpDownFloor.Minimum = 1;
        numericUpDownFloor.Maximum = 50;
        numericUpDownFloor.Name = "numericUpDownFloor";
        numericUpDownFloor.Size = new Size(120, 27);

        labelCategory.Location = new Point(20, 105);
        labelCategory.Size = new Size(120, 23);
        labelCategory.Text = "Категория:";

        comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxCategory.Location = new Point(150, 102);
        comboBoxCategory.Name = "comboBoxCategory";
        comboBoxCategory.Size = new Size(200, 28);

        buttonSave.Location = new Point(65, 160);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.Text = "Сохранить";
        buttonSave.Click += ButtonSave_Click;

        buttonCancel.Location = new Point(205, 160);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.Text = "Отмена";
        buttonCancel.Click += ButtonCancel_Click;

        ClientSize = new Size(380, 220);
        Controls.AddRange([labelNumber, textBoxNumber, labelFloor, numericUpDownFloor, labelCategory, comboBoxCategory, buttonSave, buttonCancel]);
        Name = "FormHotelRoom";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Номер гостиницы";
        ((System.ComponentModel.ISupportInitialize)numericUpDownFloor).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}