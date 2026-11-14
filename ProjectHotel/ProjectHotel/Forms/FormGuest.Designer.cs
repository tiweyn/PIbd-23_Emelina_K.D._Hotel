namespace ProjectHotel.Forms;

partial class FormGuest
{
    private System.ComponentModel.IContainer components = null!;
    private Label labelFullName = null!;
    private TextBox textBoxFullName = null!;
    private Label labelPhone = null!;
    private TextBox textBoxPhone = null!;
    private Label labelPassport = null!;
    private TextBox textBoxPassport = null!;
    private Button buttonSave = null!;
    private Button buttonCancel = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        labelFullName = new Label();
        textBoxFullName = new TextBox();
        labelPhone = new Label();
        textBoxPhone = new TextBox();
        labelPassport = new Label();
        textBoxPassport = new TextBox();
        buttonSave = new Button();
        buttonCancel = new Button();
        SuspendLayout();

        labelFullName.Location = new Point(20, 25);
        labelFullName.Size = new Size(100, 23);
        labelFullName.Text = "ФИО:";

        textBoxFullName.Location = new Point(130, 22);
        textBoxFullName.Name = "textBoxFullName";
        textBoxFullName.Size = new Size(220, 27);

        labelPhone.Location = new Point(20, 65);
        labelPhone.Size = new Size(100, 23);
        labelPhone.Text = "Телефон:";

        textBoxPhone.Location = new Point(130, 62);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(220, 27);

        labelPassport.Location = new Point(20, 105);
        labelPassport.Size = new Size(100, 23);
        labelPassport.Text = "Паспорт:";

        textBoxPassport.Location = new Point(130, 102);
        textBoxPassport.Name = "textBoxPassport";
        textBoxPassport.Size = new Size(220, 27);

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
        Controls.AddRange([labelFullName, textBoxFullName, labelPhone, textBoxPhone, labelPassport, textBoxPassport, buttonSave, buttonCancel]);
        Name = "FormGuest";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Гость";
        ResumeLayout(false);
        PerformLayout();
    }
}