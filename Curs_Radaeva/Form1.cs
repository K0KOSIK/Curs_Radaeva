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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                    //Deputy_Director form3 = new Deputy_Director(this);
                    //form3.Show();
                }
                if (authorization.IdRole == 3)
                {
                    //MessageBox.Show(user.Role);
                    Avtoris_role.Text = "Водитель";
                    Avtoris_role.ForeColor = Color.ForestGreen;
                    await Task.Delay(1500);
                    //director form3 = new director(this);
                    //form3.Show();
                }
                this.Hide();
                textBox1.Text = "";
                textBox2.Text = "";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
