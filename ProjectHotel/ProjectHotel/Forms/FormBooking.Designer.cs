namespace ProjectHotel.Forms;

partial class FormBooking
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelGuest = null!;
    private ComboBox comboBoxGuest = null!;
    private Label labelRoom = null!;
    private ComboBox comboBoxRoom = null!;
    private Label labelCheckIn = null!;
    private DateTimePicker dateTimePickerCheckIn = null!;
    private Label labelCheckOut = null!;
    private DateTimePicker dateTimePickerCheckOut = null!;
    private Label labelStatus = null!;
    private ComboBox comboBoxPaymentStatus = null!;
    private Label labelCost = null!;
    private NumericUpDown numericUpDownTotalCost = null!;
    private Button buttonSave = null!;
    private Button buttonCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelGuest = new Label();
        comboBoxGuest = new ComboBox();
        labelRoom = new Label();
        comboBoxRoom = new ComboBox();
        labelCheckIn = new Label();
        dateTimePickerCheckIn = new DateTimePicker();
        labelCheckOut = new Label();
        dateTimePickerCheckOut = new DateTimePicker();
        labelStatus = new Label();
        comboBoxPaymentStatus = new ComboBox();
        labelCost = new Label();
        numericUpDownTotalCost = new NumericUpDown();
        buttonSave = new Button();
        buttonCancel = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDownTotalCost).BeginInit();
        SuspendLayout();

        labelGuest.Location = new Point(20, 25);
        labelGuest.Size = new Size(130, 23);
        labelGuest.Text = "Гость:";

        comboBoxGuest.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxGuest.Location = new Point(160, 22);
        comboBoxGuest.Name = "comboBoxGuest";
        comboBoxGuest.Size = new Size(210, 28);

        labelRoom.Location = new Point(20, 65);
        labelRoom.Size = new Size(130, 23);
        labelRoom.Text = "Номер:";

        comboBoxRoom.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxRoom.Location = new Point(160, 62);
        comboBoxRoom.Name = "comboBoxRoom";
        comboBoxRoom.Size = new Size(210, 28);

        labelCheckIn.Location = new Point(20, 105);
        labelCheckIn.Size = new Size(130, 23);
        labelCheckIn.Text = "Дата заезда:";

        dateTimePickerCheckIn.Location = new Point(160, 102);
        dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
        dateTimePickerCheckIn.Size = new Size(210, 27);

        labelCheckOut.Location = new Point(20, 145);
        labelCheckOut.Size = new Size(130, 23);
        labelCheckOut.Text = "Дата выезда:";

        dateTimePickerCheckOut.Location = new Point(160, 142);
        dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
        dateTimePickerCheckOut.Size = new Size(210, 27);

        labelStatus.Location = new Point(20, 185);
        labelStatus.Size = new Size(130, 23);
        labelStatus.Text = "Статус оплаты:";

        comboBoxPaymentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxPaymentStatus.Location = new Point(160, 182);
        comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
        comboBoxPaymentStatus.Size = new Size(210, 28);

        labelCost.Location = new Point(20, 225);
        labelCost.Size = new Size(130, 23);
        labelCost.Text = "Стоимость:";

        numericUpDownTotalCost.DecimalPlaces = 2;
        numericUpDownTotalCost.Location = new Point(160, 222);
        numericUpDownTotalCost.Maximum = 1000000;
        numericUpDownTotalCost.Name = "numericUpDownTotalCost";
        numericUpDownTotalCost.Size = new Size(130, 27);

        buttonSave.Location = new Point(75, 275);
        buttonSave.Name = "buttonSave";
        buttonSave.Size = new Size(110, 35);
        buttonSave.Text = "Сохранить";
        buttonSave.Click += ButtonSave_Click;

        buttonCancel.Location = new Point(215, 275);
        buttonCancel.Name = "buttonCancel";
        buttonCancel.Size = new Size(110, 35);
        buttonCancel.Text = "Отмена";
        buttonCancel.Click += ButtonCancel_Click;

        ClientSize = new Size(400, 335);
        Controls.AddRange([labelGuest, comboBoxGuest, labelRoom, comboBoxRoom, labelCheckIn, dateTimePickerCheckIn, labelCheckOut, dateTimePickerCheckOut, labelStatus, comboBoxPaymentStatus, labelCost, numericUpDownTotalCost, buttonSave, buttonCancel]);
        Name = "FormBooking";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Бронирование";
        ((System.ComponentModel.ISupportInitialize)numericUpDownTotalCost).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}