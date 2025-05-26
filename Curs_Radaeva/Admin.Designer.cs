namespace Curs_Radaeva
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            bt_add = new Button();
            bt_edit = new Button();
            bt_delete = new Button();
            Transport = new Button();
            TimeTable = new Button();
            StatusDrivers = new Button();
            Routes = new Button();
            Role = new Button();
            Drivers = new Button();
            Client = new Button();
            Avtorizacia = new Button();
            Admin_BUT = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(bt_add);
            panel1.Controls.Add(bt_edit);
            panel1.Controls.Add(bt_delete);
            panel1.Controls.Add(Transport);
            panel1.Controls.Add(TimeTable);
            panel1.Controls.Add(StatusDrivers);
            panel1.Controls.Add(Routes);
            panel1.Controls.Add(Role);
            panel1.Controls.Add(Drivers);
            panel1.Controls.Add(Client);
            panel1.Controls.Add(Avtorizacia);
            panel1.Controls.Add(Admin_BUT);
            panel1.Location = new Point(657, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 447);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Location = new Point(0, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 36);
            panel2.TabIndex = 12;
            // 
            // bt_add
            // 
            bt_add.BackColor = SystemColors.AppWorkspace;
            bt_add.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            bt_add.ForeColor = SystemColors.ButtonHighlight;
            bt_add.Location = new Point(11, 413);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(128, 24);
            bt_add.TabIndex = 11;
            bt_add.Text = "ДОБАВИТЬ";
            bt_add.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = SystemColors.AppWorkspace;
            bt_edit.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            bt_edit.ForeColor = SystemColors.ButtonHighlight;
            bt_edit.Location = new Point(11, 381);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(128, 26);
            bt_edit.TabIndex = 10;
            bt_edit.Text = "ИЗМЕНИТЬ";
            bt_edit.UseVisualStyleBackColor = false;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = SystemColors.AppWorkspace;
            bt_delete.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            bt_delete.ForeColor = SystemColors.ButtonHighlight;
            bt_delete.Location = new Point(11, 349);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(128, 26);
            bt_delete.TabIndex = 9;
            bt_delete.Text = "УДАЛИТЬ";
            bt_delete.UseVisualStyleBackColor = false;
            // 
            // Transport
            // 
            Transport.BackColor = SystemColors.AppWorkspace;
            Transport.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Transport.ForeColor = SystemColors.ButtonHighlight;
            Transport.Location = new Point(11, 274);
            Transport.Name = "Transport";
            Transport.Size = new Size(128, 26);
            Transport.TabIndex = 8;
            Transport.Text = "Transport";
            Transport.UseVisualStyleBackColor = false;
            Transport.Click += Transport_Click;
            // 
            // TimeTable
            // 
            TimeTable.BackColor = SystemColors.AppWorkspace;
            TimeTable.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            TimeTable.ForeColor = SystemColors.ButtonHighlight;
            TimeTable.Location = new Point(11, 240);
            TimeTable.Name = "TimeTable";
            TimeTable.Size = new Size(128, 28);
            TimeTable.TabIndex = 7;
            TimeTable.Text = "TimeTable";
            TimeTable.UseVisualStyleBackColor = false;
            TimeTable.Click += TimeTable_Click;
            // 
            // StatusDrivers
            // 
            StatusDrivers.BackColor = SystemColors.AppWorkspace;
            StatusDrivers.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            StatusDrivers.ForeColor = SystemColors.ButtonHighlight;
            StatusDrivers.Location = new Point(11, 207);
            StatusDrivers.Name = "StatusDrivers";
            StatusDrivers.Size = new Size(128, 27);
            StatusDrivers.TabIndex = 6;
            StatusDrivers.Text = "StatusDrivers";
            StatusDrivers.UseVisualStyleBackColor = false;
            StatusDrivers.Click += StatusDrivers_Click;
            // 
            // Routes
            // 
            Routes.BackColor = SystemColors.AppWorkspace;
            Routes.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Routes.ForeColor = SystemColors.ButtonHighlight;
            Routes.Location = new Point(11, 171);
            Routes.Name = "Routes";
            Routes.Size = new Size(128, 30);
            Routes.TabIndex = 5;
            Routes.Text = "Routes";
            Routes.UseVisualStyleBackColor = false;
            Routes.Click += Routes_Click;
            // 
            // Role
            // 
            Role.BackColor = SystemColors.AppWorkspace;
            Role.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Role.ForeColor = SystemColors.ButtonHighlight;
            Role.Location = new Point(11, 139);
            Role.Name = "Role";
            Role.Size = new Size(128, 26);
            Role.TabIndex = 4;
            Role.Text = "Role";
            Role.UseVisualStyleBackColor = false;
            Role.Click += Role_Click;
            // 
            // Drivers
            // 
            Drivers.BackColor = SystemColors.AppWorkspace;
            Drivers.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Drivers.ForeColor = SystemColors.ButtonHighlight;
            Drivers.Location = new Point(11, 108);
            Drivers.Name = "Drivers";
            Drivers.Size = new Size(128, 25);
            Drivers.TabIndex = 3;
            Drivers.Text = "Drivers";
            Drivers.UseVisualStyleBackColor = false;
            Drivers.Click += Drivers_Click;
            // 
            // Client
            // 
            Client.BackColor = SystemColors.AppWorkspace;
            Client.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Client.ForeColor = SystemColors.ButtonHighlight;
            Client.Location = new Point(11, 76);
            Client.Name = "Client";
            Client.Size = new Size(128, 26);
            Client.TabIndex = 2;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = false;
            Client.Click += Client_Click;
            // 
            // Avtorizacia
            // 
            Avtorizacia.BackColor = SystemColors.AppWorkspace;
            Avtorizacia.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Avtorizacia.ForeColor = SystemColors.ButtonHighlight;
            Avtorizacia.Location = new Point(11, 42);
            Avtorizacia.Name = "Avtorizacia";
            Avtorizacia.Size = new Size(128, 28);
            Avtorizacia.TabIndex = 1;
            Avtorizacia.Text = "Avtorizacia";
            Avtorizacia.UseVisualStyleBackColor = false;
            Avtorizacia.Click += Avtorizacia_Click;
            // 
            // Admin_BUT
            // 
            Admin_BUT.BackColor = SystemColors.AppWorkspace;
            Admin_BUT.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            Admin_BUT.ForeColor = SystemColors.ButtonHighlight;
            Admin_BUT.Location = new Point(11, 11);
            Admin_BUT.Name = "Admin_BUT";
            Admin_BUT.Size = new Size(128, 25);
            Admin_BUT.TabIndex = 0;
            Admin_BUT.Text = "Admin";
            Admin_BUT.UseVisualStyleBackColor = false;
            Admin_BUT.Click += Admin_BUT_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 393);
            dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(662, 48);
            panel3.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(90, 8);
            button3.Name = "button3";
            button3.Size = new Size(33, 28);
            button3.TabIndex = 2;
            button3.Text = "--";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(51, 8);
            button2.Name = "button2";
            button2.Size = new Size(33, 28);
            button2.TabIndex = 1;
            button2.Text = "[]";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 8);
            button1.Name = "button1";
            button1.Size = new Size(33, 28);
            button1.TabIndex = 0;
            button1.Text = "Х";
            button1.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button Transport;
        private Button TimeTable;
        private Button StatusDrivers;
        private Button Routes;
        private Button Role;
        private Button Drivers;
        private Button Client;
        private Button Avtorizacia;
        private Button Admin_BUT;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_delete;
        private Panel panel2;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}