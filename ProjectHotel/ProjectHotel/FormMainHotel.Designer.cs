namespace ProjectHotel
{
    partial class FormMainHotel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainHotel));
            menuStripMain = new MenuStrip();
            directoriesToolStripMenuItem = new ToolStripMenuItem();
            categoriesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            guestsToolStripMenuItem = new ToolStripMenuItem();
            extraServicesToolStripMenuItem = new ToolStripMenuItem();
            operationsToolStripMenuItem = new ToolStripMenuItem();
            bookingsToolStripMenuItem = new ToolStripMenuItem();
            serviceOrdersToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            menuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { directoriesToolStripMenuItem, operationsToolStripMenuItem, reportsToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(800, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStripMain";
            // 
            // directoriesToolStripMenuItem
            // 
            directoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoriesToolStripMenuItem, roomsToolStripMenuItem, guestsToolStripMenuItem, extraServicesToolStripMenuItem });
            directoriesToolStripMenuItem.Name = "directoriesToolStripMenuItem";
            directoriesToolStripMenuItem.Size = new Size(94, 20);
            directoriesToolStripMenuItem.Text = "Справочники";
            // 
            // categoriesToolStripMenuItem
            // 
            categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            categoriesToolStripMenuItem.Size = new Size(210, 22);
            categoriesToolStripMenuItem.Text = "Категории номеров";
            categoriesToolStripMenuItem.Click += CategoriesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new Size(210, 22);
            roomsToolStripMenuItem.Text = "Номера";
            roomsToolStripMenuItem.Click += RoomsToolStripMenuItem_Click;
            // 
            // guestsToolStripMenuItem
            // 
            guestsToolStripMenuItem.Name = "guestsToolStripMenuItem";
            guestsToolStripMenuItem.Size = new Size(210, 22);
            guestsToolStripMenuItem.Text = "Гости";
            guestsToolStripMenuItem.Click += GuestsToolStripMenuItem_Click;
            // 
            // extraServicesToolStripMenuItem
            // 
            extraServicesToolStripMenuItem.Name = "extraServicesToolStripMenuItem";
            extraServicesToolStripMenuItem.Size = new Size(210, 22);
            extraServicesToolStripMenuItem.Text = "Дополнительные услуги";
            extraServicesToolStripMenuItem.Click += ExtraServicesToolStripMenuItem_Click;
            // 
            // operationsToolStripMenuItem
            // 
            operationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookingsToolStripMenuItem, serviceOrdersToolStripMenuItem });
            operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            operationsToolStripMenuItem.Size = new Size(75, 20);
            operationsToolStripMenuItem.Text = "Операции";
            // 
            // bookingsToolStripMenuItem
            // 
            bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            bookingsToolStripMenuItem.Size = new Size(155, 22);
            bookingsToolStripMenuItem.Text = "Бронирования";
            bookingsToolStripMenuItem.Click += BookingsToolStripMenuItem_Click;
            // 
            // serviceOrdersToolStripMenuItem
            // 
            serviceOrdersToolStripMenuItem.Name = "serviceOrdersToolStripMenuItem";
            serviceOrdersToolStripMenuItem.Size = new Size(155, 22);
            serviceOrdersToolStripMenuItem.Text = "Заказы услуг";
            serviceOrdersToolStripMenuItem.Click += ServiceOrdersToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(60, 20);
            reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // FormMainHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStripMain);
            MainMenuStrip = menuStripMain;
            Name = "FormMainHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет в гостинице";
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private ToolStripMenuItem directoriesToolStripMenuItem;
        private ToolStripMenuItem categoriesToolStripMenuItem;
        private ToolStripMenuItem roomsToolStripMenuItem;
        private ToolStripMenuItem guestsToolStripMenuItem;
        private ToolStripMenuItem extraServicesToolStripMenuItem;
        private ToolStripMenuItem operationsToolStripMenuItem;
        private ToolStripMenuItem bookingsToolStripMenuItem;
        private ToolStripMenuItem serviceOrdersToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
    }
}