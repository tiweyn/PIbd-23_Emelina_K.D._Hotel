namespace ProjectHotel.Forms;

partial class FormExtraService
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelName = null!;
    private TextBox textBoxName = null!;
    private Label labelPrice = null!;
    private NumericUpDown numericUpDownPrice = null!;
    private Button buttonSave = null!;
    private Button buttonCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelName = new Label();
        textBoxName = new TextBox();
        labelPrice = new Label();
        numericUpDownPrice = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
        SuspendLayout();

        labelName.Location = new Point(20, 25);
        labelName.Size = new Size(100, 23);
        labelName.Text = "Название:";

        textBoxName.Location = new Point(130, 22);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(210, 27);

        labelPrice.Location = new Point(20, 65);
        labelPrice.Size = new Size(100, 23);
        labelPrice.Text = "Стоимость:";

        numericUpDownPrice.DecimalPlaces = 2;
        numericUpDownPrice.Location = new Point(130, 63);
        numericUpDownPrice.Maximum = 1000000;
        numericUpDownPrice.Name = "numericUpDownPrice";
        numericUpDownPrice.Size = new Size(120, 27);

        buttonSave.Location = new Point(60, 120);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.Text = "Сохранить";
        buttonSave.Click += ButtonSave_Click;

        buttonCancel.Location = new Point(200, 120);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.Text = "Отмена";
        buttonCancel.Click += ButtonCancel_Click;

        ClientSize = new Size(370, 180);
        Controls.AddRange(new Control[] { labelName, textBoxName, labelPrice, numericUpDownPrice, buttonSave, buttonCancel });
        Name = "FormExtraService";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Дополнительная услуга";
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}