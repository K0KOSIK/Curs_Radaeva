using Curs_Radaeva.Models;
using Microsoft.EntityFrameworkCore;
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
        private Avtorisation _form1;
        public Admin(Avtorisation form1)
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Admins.ToList();
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Admins.ToList();
        }

        private void Avtorizacia_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Authorizations.ToList();
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
            dataGridView1.DataSource = context.Routes.ToList();//
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

        private void UpdateInfo()
        {
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context = new();
            var Admins = context.Admins
                .OrderBy(x => x.IdAdmin)
                .Select(x => new
                {
                    x.IdAdmin,
                    x.NameAdmin,
                    x.TelAdmin,
                    x.IdAuthorization,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext contex = new();
            var Clients = contex.Clients
                .Include(x => x.IdAvtorizacia)
                .OrderBy(x => x.IdClient)
                .Select(x => new
                {
                    x.IdClient,
                    x.NameClient,
                    x.TelClient,
                    x.DataRegisteredClient,
                    x.IdAvtorizacia,

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context2 = new();
            var Drivers = context2.Drivers
                .Include(x => x.IdStatusDrivers)
                .Include(x => x.IdAuthorization)
                .OrderBy(x => x.IdDrivers)
                .Select(x => new
                {
                    x.IdDrivers,
                    x.NameDrivers,
                    x.LicenseNumberDrivers,
                    x.TelDrivers,
                    x.IdStatusDrivers,
                    x.IdAuthorization,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context3 = new();
            var Roles = context3.Roles
                .OrderBy(x => x.IdRole)
                .Select(x => new
                {
                    x.IdRole,
                    x.NameRole,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context4 = new();
            var Routes = context4.Routes
                .OrderBy(x => x.IdRoutes)
                .Select(x => new
                {
                    x.IdRoutes,
                    x.StartLocationRoutes,
                    x.EndLocationRoutes,
                    x.DistanceRoutes,
                    x.TravelTimeRoutes,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context5 = new();
            var StatusDrivers = context5.StatusDrivers
                .OrderBy(x => x.IdStatusDrivers)
                .Select(x => new
                {
                    x.IdStatusDrivers,
                    x.NameStatusDrivers,
                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context6 = new();
            var TimeTables = context6.TimeTables
                .Include(x => x.IdRoutes)
                .Include(x => x.IdTransport)
                .Include(x => x.IdDrivers)
                .OrderBy(x => x.IdTimeTable)
                .Select(x => new
                {
                    x.IdTimeTable,
                    x.IdRoutes,
                    x.IdTransport,
                    x.IdDrivers,
                    x.DepartureTime,
                    x.ArrivalTime,
                });
            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context7 = new();
            var Transports = context5.Transports
                .OrderBy(x => x.IdTransport)
                .Select(x => new
                {
                    x.IdTransport,
                    x.NumberplateTransport,
                    x.HeightTransport,
                    x.LongTransport,
                    x.WidthTransport,
                    x.MaxSpeedTransport,

                });

            if (dataGridView1.DataSource != null)
            {
                dataGridView1.DataSource = null;
            }
            Ispr2525RadaevaVaKursachContext context8 = new();
            var Authorizations = context6.Authorizations
                .Include(x => x.IdRole)
                .OrderBy(x => x.IdAuthorization)
                .Select(x => new
                {
                    x.IdAuthorization,
                    x.Login,
                    x.Password,
                    x.IdRole,

                });
        }

        private void bt_add_Click(object sender, EventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
