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
            btAdmin = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
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
            panel1.Controls.Add(btAdmin);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(658, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 415);
            panel1.TabIndex = 0;
            // 
            // bt_add
            // 
            bt_add.BackColor = SystemColors.ControlDarkDark;
            bt_add.FlatAppearance.BorderSize = 0;
            bt_add.FlatStyle = FlatStyle.Flat;
            bt_add.Font = new Font("Microsoft Sans Serif", 12F);
            bt_add.ForeColor = Color.White;
            bt_add.Location = new Point(0, 323);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(140, 30);
            bt_add.TabIndex = 11;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = false;
            bt_add.Click += bt_add_Click;
            // 
            // bt_edit
            // 
            bt_edit.BackColor = SystemColors.ControlDarkDark;
            bt_edit.FlatAppearance.BorderSize = 0;
            bt_edit.FlatStyle = FlatStyle.Flat;
            bt_edit.Font = new Font("Microsoft Sans Serif", 12F);
            bt_edit.ForeColor = Color.White;
            bt_edit.Location = new Point(0, 353);
            bt_edit.Name = "bt_edit";
            bt_edit.Size = new Size(140, 30);
            bt_edit.TabIndex = 10;
            bt_edit.Text = "Edit";
            bt_edit.UseVisualStyleBackColor = false;
            bt_edit.Click += bt_edit_Click;
            // 
            // bt_delete
            // 
            bt_delete.BackColor = SystemColors.ControlDarkDark;
            bt_delete.FlatAppearance.BorderSize = 0;
            bt_delete.FlatStyle = FlatStyle.Flat;
            bt_delete.Font = new Font("Microsoft Sans Serif", 12F);
            bt_delete.ForeColor = Color.White;
            bt_delete.Location = new Point(-1, 383);
            bt_delete.Name = "bt_delete";
            bt_delete.Size = new Size(140, 30);
            bt_delete.TabIndex = 9;
            bt_delete.Text = "Delete";
            bt_delete.UseVisualStyleBackColor = false;
            bt_delete.Click += bt_delete_Click;
            // 
            // Transport
            // 
            Transport.BackColor = SystemColors.ControlDarkDark;
            Transport.FlatAppearance.BorderSize = 0;
            Transport.FlatStyle = FlatStyle.Flat;
            Transport.Font = new Font("Microsoft Sans Serif", 12F);
            Transport.ForeColor = Color.White;
            Transport.Location = new Point(0, 240);
            Transport.Name = "Transport";
            Transport.Size = new Size(140, 30);
            Transport.TabIndex = 8;
            Transport.Text = "Transport";
            Transport.UseVisualStyleBackColor = false;
            Transport.Click += Transport_Click;
            // 
            // TimeTable
            // 
            TimeTable.BackColor = SystemColors.ControlDarkDark;
            TimeTable.FlatAppearance.BorderSize = 0;
            TimeTable.FlatStyle = FlatStyle.Flat;
            TimeTable.Font = new Font("Microsoft Sans Serif", 12F);
            TimeTable.ForeColor = Color.White;
            TimeTable.Location = new Point(0, 210);
            TimeTable.Name = "TimeTable";
            TimeTable.Size = new Size(140, 30);
            TimeTable.TabIndex = 7;
            TimeTable.Text = "TimeTable";
            TimeTable.UseVisualStyleBackColor = false;
            TimeTable.Click += TimeTable_Click;
            // 
            // StatusDrivers
            // 
            StatusDrivers.BackColor = SystemColors.ControlDarkDark;
            StatusDrivers.FlatAppearance.BorderSize = 0;
            StatusDrivers.FlatStyle = FlatStyle.Flat;
            StatusDrivers.Font = new Font("Microsoft Sans Serif", 12F);
            StatusDrivers.ForeColor = Color.White;
            StatusDrivers.Location = new Point(0, 180);
            StatusDrivers.Name = "StatusDrivers";
            StatusDrivers.Size = new Size(140, 30);
            StatusDrivers.TabIndex = 6;
            StatusDrivers.Text = "StatusDrivers";
            StatusDrivers.UseVisualStyleBackColor = false;
            StatusDrivers.Click += StatusDrivers_Click;
            // 
            // Routes
            // 
            Routes.BackColor = SystemColors.ControlDarkDark;
            Routes.FlatAppearance.BorderSize = 0;
            Routes.FlatStyle = FlatStyle.Flat;
            Routes.Font = new Font("Microsoft Sans Serif", 12F);
            Routes.ForeColor = Color.White;
            Routes.Location = new Point(0, 150);
            Routes.Name = "Routes";
            Routes.Size = new Size(140, 30);
            Routes.TabIndex = 5;
            Routes.Text = "Routes";
            Routes.UseVisualStyleBackColor = false;
            Routes.Click += Routes_Click;
            // 
            // Role
            // 
            Role.BackColor = SystemColors.ControlDarkDark;
            Role.FlatAppearance.BorderSize = 0;
            Role.FlatStyle = FlatStyle.Flat;
            Role.Font = new Font("Microsoft Sans Serif", 12F);
            Role.ForeColor = Color.White;
            Role.Location = new Point(0, 120);
            Role.Name = "Role";
            Role.Size = new Size(140, 30);
            Role.TabIndex = 4;
            Role.Text = "Role";
            Role.UseVisualStyleBackColor = false;
            Role.Click += Role_Click;
            // 
            // Drivers
            // 
            Drivers.BackColor = SystemColors.ControlDarkDark;
            Drivers.FlatAppearance.BorderSize = 0;
            Drivers.FlatStyle = FlatStyle.Flat;
            Drivers.Font = new Font("Microsoft Sans Serif", 12F);
            Drivers.ForeColor = Color.White;
            Drivers.Location = new Point(0, 90);
            Drivers.Name = "Drivers";
            Drivers.Size = new Size(140, 30);
            Drivers.TabIndex = 3;
            Drivers.Text = "Drivers";
            Drivers.UseVisualStyleBackColor = false;
            Drivers.Click += Drivers_Click;
            // 
            // Client
            // 
            Client.BackColor = SystemColors.ControlDarkDark;
            Client.FlatAppearance.BorderSize = 0;
            Client.FlatStyle = FlatStyle.Flat;
            Client.Font = new Font("Microsoft Sans Serif", 12F);
            Client.ForeColor = Color.White;
            Client.Location = new Point(0, 60);
            Client.Name = "Client";
            Client.Size = new Size(140, 30);
            Client.TabIndex = 2;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = false;
            Client.Click += Client_Click;
            // 
            // Avtorizacia
            // 
            Avtorizacia.BackColor = SystemColors.ControlDarkDark;
            Avtorizacia.FlatAppearance.BorderSize = 0;
            Avtorizacia.FlatStyle = FlatStyle.Flat;
            Avtorizacia.Font = new Font("Microsoft Sans Serif", 12F);
            Avtorizacia.ForeColor = Color.White;
            Avtorizacia.Location = new Point(0, 30);
            Avtorizacia.Name = "Avtorizacia";
            Avtorizacia.Size = new Size(140, 30);
            Avtorizacia.TabIndex = 1;
            Avtorizacia.Text = "Avtorizacia";
            Avtorizacia.UseVisualStyleBackColor = false;
            Avtorizacia.Click += Avtorizacia_Click;
            // 
            // btAdmin
            // 
            btAdmin.BackColor = SystemColors.ControlDarkDark;
            btAdmin.FlatAppearance.BorderSize = 0;
            btAdmin.FlatStyle = FlatStyle.Flat;
            btAdmin.Font = new Font("Microsoft Sans Serif", 12F);
            btAdmin.ForeColor = Color.White;
            btAdmin.Location = new Point(0, 0);
            btAdmin.Name = "btAdmin";
            btAdmin.Size = new Size(140, 30);
            btAdmin.TabIndex = 0;
            btAdmin.Text = "Admin";
            btAdmin.UseVisualStyleBackColor = false;
            btAdmin.Click += btAdmin_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(658, 415);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(bt_min);
            panel2.Controls.Add(bt_max);
            panel2.Controls.Add(bt_exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 35);
            panel2.TabIndex = 2;
            panel2.MouseDown += panelTop_MouseDown;
            // 
            // bt_min
            // 
            bt_min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_min.BackColor = Color.Transparent;
            bt_min.BackgroundImage = Properties.Resources.MinB;
            bt_min.BackgroundImageLayout = ImageLayout.Zoom;
            bt_min.FlatAppearance.BorderSize = 0;
            bt_min.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            bt_min.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            bt_min.FlatStyle = FlatStyle.Flat;
            bt_min.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_min.Location = new Point(693, 0);
            bt_min.Margin = new Padding(4, 3, 4, 3);
            bt_min.Name = "bt_min";
            bt_min.Size = new Size(35, 35);
            bt_min.TabIndex = 11;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_Min_Click;
            // 
            // bt_max
            // 
            bt_max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_max.BackColor = Color.Transparent;
            bt_max.BackgroundImage = Properties.Resources.MaxB;
            bt_max.BackgroundImageLayout = ImageLayout.Zoom;
            bt_max.FlatAppearance.BorderSize = 0;
            bt_max.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            bt_max.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            bt_max.FlatStyle = FlatStyle.Flat;
            bt_max.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_max.Location = new Point(730, 0);
            bt_max.Margin = new Padding(4, 3, 4, 3);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(35, 35);
            bt_max.TabIndex = 10;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bt_exit.BackColor = Color.Transparent;
            bt_exit.BackgroundImage = Properties.Resources.ExitB;
            bt_exit.BackgroundImageLayout = ImageLayout.Zoom;
            bt_exit.FlatAppearance.BorderSize = 0;
            bt_exit.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            bt_exit.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            bt_exit.FlatStyle = FlatStyle.Flat;
            bt_exit.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_exit.ForeColor = SystemColors.ControlText;
            bt_exit.Location = new Point(765, 0);
            bt_exit.Margin = new Padding(4, 3, 4, 3);
            bt_exit.Name = "bt_exit";
            bt_exit.Size = new Size(35, 35);
            bt_exit.TabIndex = 9;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
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
        private Button btAdmin;
        private Button bt_add;
        private Button bt_edit;
        private Button bt_delete;
        private Panel panel2;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}