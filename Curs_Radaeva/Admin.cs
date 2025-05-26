using Curs_Radaeva.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curs_Radaeva
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Admins.ToList();
        }

        private void Admin_BUT_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Admins.ToList();
        }

        private void Avtorizacia_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Avtorizacia.ToList();
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Clients.ToList();
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Drivers.ToList();
        }

        private void Role_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Roles.ToList();
        }

        private void Routes_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Routes.ToList();
        }

        private void StatusDrivers_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.StatusDrivers.ToList();
        }

        private void TimeTable_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.TimeTables.ToList();
        }

        private void Transport_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Transports.ToList();
        }
    }
}
