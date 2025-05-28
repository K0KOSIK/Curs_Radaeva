using Curs_Radaeva.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Metrics;
using System.IO;

namespace Curs_Radaeva
{
    public partial class Avtorisation : Form
    {
        public Avtorisation()
        {
            InitializeComponent();
            textBox2.Focus();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            foreach (Control control in panel2.Controls)
            {
                if (control is System.Windows.Forms.Button button &&
                    (button.Name == "bt_max" || button.Name == "bt_min" || button.Name == "bt_exit"))
                {
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                }

            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            if (button == bt_exit)
                bt_exit.BackgroundImage = Properties.Resources.ExitR;
            if (button == bt_min)
                bt_min.BackgroundImage = Properties.Resources.MinO;
            if (button == bt_max)
                bt_max.BackgroundImage = Properties.Resources.MaxG;
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as System.Windows.Forms.Button;
            if (button == bt_exit)
                bt_exit.BackgroundImage = Properties.Resources.ExitB;
            if (button == bt_min)
                bt_min.BackgroundImage = Properties.Resources.MinB;
            if (button == bt_max)
                bt_max.BackgroundImage = Properties.Resources.MaxB;
        }
        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void bt_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Avtorisation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private async void Avtorises_Click(object sender, EventArgs e)
        {
            try
            {
                Ispr2525RadaevaVaKursachContext context = new();
                Authorization? authorization = context.Authorizations
                    .Where(authorization => authorization.Login == textBox1.Text && authorization.Password == textBox2.Text)
                    .FirstOrDefault();
                if (authorization.IdRole == 1)
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = "Администратор";
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    Admin form2 = new Admin(this);
                    form2.Show();
                }
                if (authorization.IdRole == 2)
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = "Клиент";
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    Klients form3 = new Klients(this);
                    form3.Show();
                }
                if (authorization.IdRole == 3)
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = "Водитель";
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    Drive form3 = new Drive(this);
                    form3.Show();
                }
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
                Avtoris_role.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неправильный логин или пароль:");
                Avtoris_role.Text = "Неправильный логин или пароль";
                Avtoris_role.ForeColor = Color.IndianRed;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
