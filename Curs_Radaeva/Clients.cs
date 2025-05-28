using Curs_Radaeva.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curs_Radaeva
{
    public partial class Clients : Form
    {
        private Avtorisation _form1;
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        public Clients(Avtorisation form1)
        {
            InitializeComponent();
            this.FormClosed += Klients_FormClosed;
            _form1 = form1;
            foreach (Control control in panel3.Controls)
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
        private void Klients_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }
        public void ClearColor()
        {
            Drivers.ForeColor = Color.White;
            Routes.ForeColor = Color.White;
            TimeTable.ForeColor = Color.White;
        }
        private void Klients_Load(object sender, EventArgs e)
        {
            
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Avtorizacia_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
            
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Drivers.ToList();
            activeEntity = ActiveEntity.Driver;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            ClearColor();
            Drivers.ForeColor = Color.Lime;
        }

        private void Role_Click(object sender, EventArgs e)
        {

        }

        private void Routes_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Routes.ToList();
            dataGridView1.Columns[5].Visible = false;
            activeEntity = ActiveEntity.Route;
            ClearColor();
            Routes.ForeColor = Color.Lime;
        }

        private void StatusDrivers_Click(object sender, EventArgs e)
        {
            
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            try
            {
                Ispr2525RadaevaVaKursachContext context = new();
                var data = context.TimeTables
                    .Include(t => t.Route)
                    .Include(t => t.Driver)
                    .Include(t => t.Transport)
                    .Select(t => new
                    {
                        IdTimeTable = t.IdTimeTable,
                        IdRoutes = t.IdRoutes,
                        IdTransport = t.IdTransport,
                        IdDrivers = t.IdDrivers,
                        StartLocationRoutes = t.Route.StartLocationRoutes,
                        EndLocationRoutes = t.Route.EndLocationRoutes,
                        NameDrivers = t.Driver.NameDrivers,
                        LicenseNumberDrivers = t.Driver.LicenseNumberDrivers,
                        NumberplateTransport = t.Transport.NumberplateTransport,
                        DepartureTime = t.DepartureTime,
                        ArrivalTime = t.ArrivalTime,
                    }).ToList();
                dataGridView1.DataSource = data;
                activeEntity = ActiveEntity.TimeTable;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                ClearColor();
                TimeTable.ForeColor = Color.Lime;
            }
            catch (Exception ex)
            {
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
        }

        private void Transport_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateInfo()
        {
           
        }    }
}
