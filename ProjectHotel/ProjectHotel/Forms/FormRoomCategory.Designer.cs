namespace ProjectHotel.Forms;

partial class FormRoomCategory
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelName = null!;
    private TextBox textBoxName = null!;
    private Label labelCapacity = null!;
    private NumericUpDown numericUpDownCapacity = null!;
    private Label labelPrice = null!;
    private NumericUpDown numericUpDownPrice = null!;
    private Label labelAmenities = null!;
    private CheckedListBox checkedListBoxAmenities = null!;
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
        labelCapacity = new Label();
        numericUpDownCapacity = new NumericUpDown();
        labelPrice = new Label();
        numericUpDownPrice = new NumericUpDown();
        labelAmenities = new Label();
        checkedListBoxAmenities = new CheckedListBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
        SuspendLayout();

        labelName.Location = new Point(20, 25);
        labelName.Size = new Size(120, 23);
        labelName.Text = "Название:";

        textBoxName.Location = new Point(150, 22);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(210, 27);

        labelCapacity.Location = new Point(20, 65);
        labelCapacity.Size = new Size(120, 23);
        labelCapacity.Text = "Вместимость:";

        numericUpDownCapacity.Location = new Point(150, 63);
        numericUpDownCapacity.Minimum = 1;
        numericUpDownCapacity.Maximum = 10;
        numericUpDownCapacity.Name = "numericUpDownCapacity";
        numericUpDownCapacity.Size = new Size(120, 27);

        labelPrice.Location = new Point(20, 105);
        labelPrice.Size = new Size(120, 23);
        labelPrice.Text = "Цена за сутки:";

        numericUpDownPrice.DecimalPlaces = 2;
        numericUpDownPrice.Location = new Point(150, 103);
        numericUpDownPrice.Maximum = 1000000;
        numericUpDownPrice.Name = "numericUpDownPrice";
        numericUpDownPrice.Size = new Size(120, 27);

        labelAmenities.Location = new Point(20, 145);
        labelAmenities.Size = new Size(120, 23);
        labelAmenities.Text = "Удобства:";

        checkedListBoxAmenities.CheckOnClick = true;
        checkedListBoxAmenities.Location = new Point(150, 145);
        checkedListBoxAmenities.Name = "checkedListBoxAmenities";
        checkedListBoxAmenities.Size = new Size(210, 110);

        buttonSave.Location = new Point(70, 280);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.Text = "Сохранить";
        buttonSave.Click += ButtonSave_Click;

        buttonCancel.Location = new Point(210, 280);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.Text = "Отмена";
        buttonCancel.Click += ButtonCancel_Click;

        ClientSize = new Size(390, 340);
        Controls.AddRange([labelName, textBoxName, labelCapacity, numericUpDownCapacity, labelPrice, numericUpDownPrice, labelAmenities, checkedListBoxAmenities, buttonSave, buttonCancel]);
        Name = "FormRoomCategory";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Категория номера";
        ((System.ComponentModel.ISupportInitialize)numericUpDownCapacity).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}