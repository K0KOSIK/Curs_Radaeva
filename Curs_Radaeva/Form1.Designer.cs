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
            Login = new Label();
            pasword = new Label();
            Avtorises = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Avtoris_role = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 2;
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Microsoft Sans Serif", 14.25F);
            Login.ForeColor = SystemColors.ActiveCaptionText;
            Login.Location = new Point(333, 148);
            Login.Name = "Login";
            Login.Size = new Size(64, 24);
            Login.TabIndex = 3;
            Login.Text = "Логин";
            Login.Click += Login_Click;
            // 
            // pasword
            // 
            pasword.AutoSize = true;
            pasword.Font = new Font("Microsoft Sans Serif", 14.25F);
            pasword.ForeColor = SystemColors.ActiveCaptionText;
            pasword.Location = new Point(333, 209);
            pasword.Name = "pasword";
            pasword.Size = new Size(76, 24);
            pasword.TabIndex = 4;
            pasword.Text = "Пароль";
            pasword.Click += label3_Click;
            // 
            // Avtorises
            // 
            Avtorises.BackColor = SystemColors.ControlDarkDark;
            Avtorises.Font = new Font("Microsoft Sans Serif", 14.25F);
            Avtorises.ForeColor = SystemColors.ActiveCaptionText;
            Avtorises.Location = new Point(333, 295);
            Avtorises.Name = "Avtorises";
            Avtorises.Size = new Size(135, 35);
            Avtorises.TabIndex = 5;
            Avtorises.Text = "Войти";
            Avtorises.UseVisualStyleBackColor = false;
            Avtorises.Click += Avtorises_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 35);
            panel2.TabIndex = 6;
            // 
            // button3
            // 
            button3.BackColor = Color.LimeGreen;
            button3.Dock = DockStyle.Right;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(695, 0);
            button3.Name = "button3";
            button3.Size = new Size(35, 35);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(730, 0);
            button2.Name = "button2";
            button2.Size = new Size(35, 35);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(765, 0);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = false;
            // 
            // Avtoris_role
            // 
            Avtoris_role.Location = new Point(333, 270);
            Avtoris_role.Name = "Avtoris_role";
            Avtoris_role.Size = new Size(135, 18);
            Avtoris_role.TabIndex = 7;
            Avtoris_role.Text = "label3";
            Avtoris_role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Avtorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(Avtoris_role);
            Controls.Add(panel2);
            Controls.Add(Avtorises);
            Controls.Add(pasword);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Avtorisation";
            Text = "Avtorisation";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private Label Login;
        private Label pasword;
        private Button Avtorises;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label Avtoris_role;
    }
}
