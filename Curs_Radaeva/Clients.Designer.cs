namespace Curs_Radaeva
{
    partial class Clients
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
            TimeTable = new Button();
            Routes = new Button();
            Drivers = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(TimeTable);
            panel1.Controls.Add(Routes);
            panel1.Controls.Add(Drivers);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(658, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 415);
            panel1.TabIndex = 0;
            // 
            // TimeTable
            // 
            TimeTable.BackColor = SystemColors.ControlDarkDark;
            TimeTable.FlatAppearance.BorderSize = 0;
            TimeTable.FlatStyle = FlatStyle.Flat;
            TimeTable.Font = new Font("Microsoft Sans Serif", 12F);
            TimeTable.ForeColor = SystemColors.ActiveCaptionText;
            TimeTable.Location = new Point(0, 63);
            TimeTable.Name = "TimeTable";
            TimeTable.Size = new Size(140, 30);
            TimeTable.TabIndex = 7;
            TimeTable.Text = "TimeTable";
            TimeTable.UseVisualStyleBackColor = false;
            TimeTable.Click += TimeTable_Click;
            // 
            // Routes
            // 
            Routes.BackColor = SystemColors.ControlDarkDark;
            Routes.FlatAppearance.BorderSize = 0;
            Routes.FlatStyle = FlatStyle.Flat;
            Routes.Font = new Font("Microsoft Sans Serif", 12F);
            Routes.ForeColor = SystemColors.ActiveCaptionText;
            Routes.Location = new Point(0, 32);
            Routes.Name = "Routes";
            Routes.Size = new Size(140, 30);
            Routes.TabIndex = 5;
            Routes.Text = "Routes";
            Routes.UseVisualStyleBackColor = false;
            Routes.Click += Routes_Click;
            // 
            // Drivers
            // 
            Drivers.BackColor = SystemColors.ControlDarkDark;
            Drivers.FlatAppearance.BorderSize = 0;
            Drivers.FlatStyle = FlatStyle.Flat;
            Drivers.Font = new Font("Microsoft Sans Serif", 12F);
            Drivers.ForeColor = SystemColors.ActiveCaptionText;
            Drivers.Location = new Point(0, 1);
            Drivers.Name = "Drivers";
            Drivers.Size = new Size(140, 30);
            Drivers.TabIndex = 3;
            Drivers.Text = "Drivers";
            Drivers.UseVisualStyleBackColor = false;
            Drivers.Click += Drivers_Click;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDarkDark;
            panel3.Controls.Add(bt_min);
            panel3.Controls.Add(bt_max);
            panel3.Controls.Add(bt_exit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 35);
            panel3.TabIndex = 2;
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
            bt_min.TabIndex = 17;
            bt_min.UseVisualStyleBackColor = false;
            bt_min.Click += bt_Min_Click;
            // 
            // bt_max
            // 
            bt_max.BackColor = Color.Transparent;
            bt_max.BackgroundImage = Properties.Resources.MaxB;
            bt_max.BackgroundImageLayout = ImageLayout.Zoom;
            bt_max.Dock = DockStyle.Right;
            bt_max.FlatAppearance.BorderSize = 0;
            bt_max.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            bt_max.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            bt_max.FlatStyle = FlatStyle.Flat;
            bt_max.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bt_max.Location = new Point(730, 0);
            bt_max.Margin = new Padding(4, 3, 4, 3);
            bt_max.Name = "bt_max";
            bt_max.Size = new Size(35, 35);
            bt_max.TabIndex = 16;
            bt_max.UseVisualStyleBackColor = false;
            bt_max.Click += bt_max_Click;
            // 
            // bt_exit
            // 
            bt_exit.BackColor = Color.Transparent;
            bt_exit.BackgroundImage = Properties.Resources.ExitB;
            bt_exit.BackgroundImageLayout = ImageLayout.Zoom;
            bt_exit.Dock = DockStyle.Right;
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
            bt_exit.TabIndex = 15;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Klients_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Button TimeTable;
        private Button Routes;
        private Button Drivers;
        private Panel panel3;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
    }
}