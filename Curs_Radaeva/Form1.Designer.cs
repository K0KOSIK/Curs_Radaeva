namespace Curs_Radaeva
{
    partial class Avtorisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Avtorises = new Button();
            panel2 = new Panel();
            bt_min = new Button();
            bt_max = new Button();
            bt_exit = new Button();
            Avtoris_role = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 14.25F);
            textBox1.Location = new Point(18, 16);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Логин";
            textBox1.Size = new Size(285, 35);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 14.25F);
            textBox2.Location = new Point(18, 61);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.PlaceholderText = "Пароль";
            textBox2.Size = new Size(285, 35);
            textBox2.TabIndex = 2;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // Avtorises
            // 
            Avtorises.BackColor = SystemColors.ControlDarkDark;
            Avtorises.FlatAppearance.BorderSize = 0;
            Avtorises.FlatStyle = FlatStyle.Flat;
            Avtorises.Font = new Font("Microsoft Sans Serif", 14.25F);
            Avtorises.ForeColor = SystemColors.ActiveCaptionText;
            Avtorises.Location = new Point(18, 151);
            Avtorises.Margin = new Padding(4, 3, 4, 3);
            Avtorises.Name = "Avtorises";
            Avtorises.Size = new Size(285, 35);
            Avtorises.TabIndex = 5;
            Avtorises.Text = "Войти";
            Avtorises.UseVisualStyleBackColor = false;
            Avtorises.Click += Avtorises_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(bt_min);
            panel2.Controls.Add(bt_max);
            panel2.Controls.Add(bt_exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 35);
            panel2.TabIndex = 6;
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
            bt_min.TabIndex = 5;
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
            bt_max.TabIndex = 4;
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
            bt_exit.TabIndex = 3;
            bt_exit.UseVisualStyleBackColor = false;
            bt_exit.Click += bt_exit_Click;
            // 
            // Avtoris_role
            // 
            Avtoris_role.Font = new Font("Microsoft Sans Serif", 14.25F);
            Avtoris_role.Location = new Point(18, 106);
            Avtoris_role.Margin = new Padding(4, 0, 4, 0);
            Avtoris_role.Name = "Avtoris_role";
            Avtoris_role.Size = new Size(285, 35);
            Avtoris_role.TabIndex = 7;
            Avtoris_role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(250, 250, 250);
            panel1.Controls.Add(Avtoris_role);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Avtorises);
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(241, 123);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 203);
            panel1.TabIndex = 8;
            // 
            // Avtorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Avtorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avtorisation";
            FormClosing += Avtorisation_FormClosing;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Avtorises;
        private Panel panel2;
        private Button bt_min;
        private Button bt_max;
        private Button bt_exit;
        private Label Avtoris_role;
        private Panel panel1;
    }
}
