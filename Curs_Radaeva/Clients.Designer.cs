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
            panel2 = new Panel();
            TimeTable = new Button();
            Routes = new Button();
            Drivers = new Button();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btMin = new Button();
            btMax = new Button();
            btExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(TimeTable);
            panel1.Controls.Add(Routes);
            panel1.Controls.Add(Drivers);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(658, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 415);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(0, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 329);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // TimeTable
            // 
            TimeTable.BackColor = SystemColors.AppWorkspace;
            TimeTable.Dock = DockStyle.Top;
            TimeTable.Font = new Font("Stencil", 12F);
            TimeTable.ForeColor = SystemColors.ActiveCaptionText;
            TimeTable.Location = new Point(0, 55);
            TimeTable.Name = "TimeTable";
            TimeTable.Size = new Size(142, 28);
            TimeTable.TabIndex = 7;
            TimeTable.Text = "TimeTable";
            TimeTable.UseVisualStyleBackColor = false;
            TimeTable.Click += TimeTable_Click;
            // 
            // Routes
            // 
            Routes.BackColor = SystemColors.AppWorkspace;
            Routes.Dock = DockStyle.Top;
            Routes.Font = new Font("Stencil", 12F);
            Routes.ForeColor = SystemColors.ActiveCaptionText;
            Routes.Location = new Point(0, 25);
            Routes.Name = "Routes";
            Routes.Size = new Size(142, 30);
            Routes.TabIndex = 5;
            Routes.Text = "Routes";
            Routes.UseVisualStyleBackColor = false;
            Routes.Click += Routes_Click;
            // 
            // Drivers
            // 
            Drivers.BackColor = SystemColors.AppWorkspace;
            Drivers.Dock = DockStyle.Top;
            Drivers.Font = new Font("Stencil", 12F);
            Drivers.ForeColor = SystemColors.ActiveCaptionText;
            Drivers.Location = new Point(0, 0);
            Drivers.Name = "Drivers";
            Drivers.Size = new Size(142, 25);
            Drivers.TabIndex = 3;
            Drivers.Text = "Drivers";
            Drivers.UseVisualStyleBackColor = false;
            Drivers.Click += Drivers_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
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
            panel3.Controls.Add(btMin);
            panel3.Controls.Add(btMax);
            panel3.Controls.Add(btExit);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 35);
            panel3.TabIndex = 2;
            // 
            // btMin
            // 
            btMin.BackColor = Color.LimeGreen;
            btMin.Dock = DockStyle.Right;
            btMin.FlatStyle = FlatStyle.Flat;
            btMin.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            btMin.Location = new Point(695, 0);
            btMin.Name = "btMin";
            btMin.Size = new Size(35, 35);
            btMin.TabIndex = 8;
            btMin.UseVisualStyleBackColor = false;
            btMin.Click += btMin_Click;
            // 
            // btMax
            // 
            btMax.BackColor = Color.SandyBrown;
            btMax.Dock = DockStyle.Right;
            btMax.FlatStyle = FlatStyle.Flat;
            btMax.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btMax.Location = new Point(730, 0);
            btMax.Name = "btMax";
            btMax.Size = new Size(35, 35);
            btMax.TabIndex = 7;
            btMax.UseVisualStyleBackColor = false;
            btMax.Click += btMax_Click;
            // 
            // btExit
            // 
            btExit.BackColor = Color.IndianRed;
            btExit.Dock = DockStyle.Right;
            btExit.FlatStyle = FlatStyle.Flat;
            btExit.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btExit.ForeColor = SystemColors.ControlText;
            btExit.Location = new Point(765, 0);
            btExit.Name = "btExit";
            btExit.Size = new Size(35, 35);
            btExit.TabIndex = 6;
            btExit.UseVisualStyleBackColor = false;
            btExit.Click += btExit_Click;
            // 
            // Klients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Klients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosing += Admin_FormClosing;
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
        private Panel panel2;
        private Panel panel3;
        private Button btMin;
        private Button btMax;
        private Button btExit;
    }
}