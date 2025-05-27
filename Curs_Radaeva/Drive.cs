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
    public partial class Drive : Form
    {
        private Avtorisation _form1;
        public ActiveEntity activeEntity;
        public IsEdit isEdit;
        public Drive(Avtorisation form1)
        {
            InitializeComponent();
            this.FormClosed += Admin_FormClosed;
            _form1 = form1;
        }
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form1.Show();
        }

        private void Drive_Load(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Clients.ToList();
            activeEntity = ActiveEntity.Client;
            dataGridView1.Columns[5].Visible = false;
        }

        private void btAdmin_Click(object sender, EventArgs e)
        {

        }

        private void Avtorizacia_Click(object sender, EventArgs e)
        {

        }

        private void Client_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Clients.ToList();
            activeEntity = ActiveEntity.Client;
            dataGridView1.Columns[5].Visible = false;
        }

        private void Drivers_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Drivers.ToList();
            activeEntity = ActiveEntity.Driver;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
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
        }

        private void StatusDrivers_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.StatusDrivers.ToList();
            activeEntity = ActiveEntity.StatusDriver;
            dataGridView1.Columns[2].Visible = false;
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
            }
            catch (Exception ex)
            {
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
        }

        private void Transport_Click(object sender, EventArgs e)
        {
            Ispr2525RadaevaVaKursachContext context = new();
            dataGridView1.DataSource = context.Transports.ToList();
            activeEntity = ActiveEntity.Transport;
            dataGridView1.Columns[6].Visible = false;
        }

        private void UpdateInfo()
        {
            
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
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.N;
            if (activeEntity == ActiveEntity.Client)
            {
                try
                {
                    var Client = new Client
                    {
                        IdClient = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        NameClient = "",
                        TelClient = 0,
                        DataRegisteredClient = DateOnly.FromDateTime(DateTime.Now),
                        IdAvtorizacia = 0,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Client, Client);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context2 = new();
                        dataGridView1.DataSource = context2.Clients.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Driver)
            {
                try
                {
                    var Driver = new Driver
                    {
                        IdDrivers = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        NameDrivers = "",
                        LicenseNumberDrivers = 0,
                        TelDrivers = 0,
                        IdStatusDrivers = 0,
                        IdAuthorization = 0,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Driver, Driver);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context3 = new();
                        dataGridView1.DataSource = context3.Drivers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Route)
            {
                try
                {
                    var Route = new Route
                    {
                        IdRoutes = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        StartLocationRoutes = "",
                        EndLocationRoutes = "",
                        DistanceRoutes = 0,
                        TravelTimeRoutes = TimeOnly.FromDateTime(DateTime.Now)
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Route, Route);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context5 = new();
                        dataGridView1.DataSource = context5.Routes.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.StatusDriver)
            {
                try
                {
                    var StatusDriver = new StatusDriver
                    {
                        IdStatusDrivers = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        NameStatusDrivers = "",
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.StatusDriver, StatusDriver);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context6 = new();
                        dataGridView1.DataSource = context6.StatusDrivers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.TimeTable)
            {
                try
                {
                    var TimeTable = new TimeTable
                    {
                        IdTimeTable = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        IdRoutes = 0,
                        IdTransport = 0,
                        IdDrivers = 0,
                        DepartureTime = TimeOnly.FromDateTime(DateTime.Now),
                        ArrivalTime = TimeOnly.FromDateTime(DateTime.Now)
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.TimeTable, TimeTable);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
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
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Transport)
            {
                try
                {
                    var Transport = new Transport
                    {
                        IdTransport = (int)dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value + 1,
                        NumberplateTransport = "",
                        HeightTransport = 0,
                        LongTransport = 0,
                        WidthTransport = 0,
                        MaxSpeedTransport = 0,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Transport, Transport);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context8 = new();
                        dataGridView1.DataSource = context8.Transports.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось добавить: " + ex.Message);
                }
            }
        }


        private void bt_edit_Click(object sender, EventArgs e)
        {
            isEdit = IsEdit.Y;
            if (activeEntity == ActiveEntity.Client)
            {
                try
                {
                    var Client = new Client
                    {
                        IdClient = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        NameClient = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        TelClient = (long)dataGridView1.SelectedRows[0].Cells[2].Value,
                        DataRegisteredClient = (DateOnly)dataGridView1.SelectedRows[0].Cells[3].Value,
                        IdAvtorizacia = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Client, Client);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context2 = new();
                        dataGridView1.DataSource = context2.Clients.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                    ExceptionToFile.SaveExceptionToDesktop(ex);
                }
            }
            if (activeEntity == ActiveEntity.Driver)
            {
                try
                {
                    var Driver = new Driver
                    {
                        IdDrivers = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        NameDrivers = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        LicenseNumberDrivers = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                        TelDrivers = (long)dataGridView1.SelectedRows[0].Cells[3].Value,
                        IdStatusDrivers = (int)dataGridView1.SelectedRows[0].Cells[4].Value,
                        IdAuthorization = (int)dataGridView1.SelectedRows[0].Cells[5].Value,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Driver, Driver);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context3 = new();
                        dataGridView1.DataSource = context3.Drivers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.StatusDriver)
            {
                try
                {
                    var StatusDriver = new StatusDriver
                    {
                        IdStatusDrivers = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        NameStatusDrivers = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.StatusDriver, StatusDriver);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context5 = new();
                        dataGridView1.DataSource = context5.StatusDrivers.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.TimeTable)
            {
                try
                {
                    var TimeTable = new TimeTable
                    {
                        IdTimeTable = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        IdRoutes = (int)dataGridView1.SelectedRows[0].Cells[1].Value,
                        IdTransport = (int)dataGridView1.SelectedRows[0].Cells[2].Value,
                        IdDrivers = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                        DepartureTime = (TimeOnly)dataGridView1.SelectedRows[0].Cells[9].Value,
                        ArrivalTime = (TimeOnly)dataGridView1.SelectedRows[0].Cells[10].Value,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.TimeTable, TimeTable);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
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
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Route)
            {
                try
                {
                    var Route = new Route
                    {
                        IdRoutes = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        StartLocationRoutes = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        EndLocationRoutes = (string)dataGridView1.SelectedRows[0].Cells[2].Value,
                        DistanceRoutes = (int)dataGridView1.SelectedRows[0].Cells[3].Value,
                        TravelTimeRoutes = (TimeOnly)dataGridView1.SelectedRows[0].Cells[4].Value
                    };
                    this.Hide();
                    var red = new Redact(ActiveEntity.Route, Route);
                    red.isEdit = isEdit;
                    if (red.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context = new();
                        dataGridView1.DataSource = context.Routes.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
            if (activeEntity == ActiveEntity.Transport)
            {
                try
                {
                    var Transport = new Transport
                    {
                        IdTransport = (int)dataGridView1.SelectedRows[0].Cells[0].Value,
                        NumberplateTransport = (string)dataGridView1.SelectedRows[0].Cells[1].Value,
                        HeightTransport = (Decimal)dataGridView1.SelectedRows[0].Cells[2].Value,
                        LongTransport = (Decimal)dataGridView1.SelectedRows[0].Cells[3].Value,
                        WidthTransport = (Decimal)dataGridView1.SelectedRows[0].Cells[4].Value,
                        MaxSpeedTransport = (long)dataGridView1.SelectedRows[0].Cells[5].Value,
                    };
                    this.Hide();
                    var editing = new Redact(ActiveEntity.Transport, Transport);
                    editing.isEdit = isEdit;
                    if (editing.ShowDialog() == DialogResult.OK)
                    {
                        Ispr2525RadaevaVaKursachContext context8 = new();
                        dataGridView1.DataSource = context8.Transports.ToList();
                        dataGridView1.Refresh();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не получилось изменить: " + ex.Message);
                }
            }
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            if (activeEntity == ActiveEntity.Client)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex2 = new();
                        var Client = contex2.Clients.Where(x => x.IdClient == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Client.ExecuteDelete();
                            contex2.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex2.Clients.ToList();
                            dataGridView1.Columns[5].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Driver)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex3 = new();
                        var Driver = contex3.Drivers.Where(x => x.IdDrivers == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Driver.ExecuteDelete();
                            contex3.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex3.Drivers.ToList();
                            dataGridView1.Columns[6].Visible = false;
                            dataGridView1.Columns[7].Visible = false;
                            dataGridView1.Columns[8].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.Route)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex5 = new();
                        var Route = contex5.Routes.Where(x => x.IdRoutes == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Route.ExecuteDelete();
                            contex5.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex5.Routes.ToList();
                            dataGridView1.Columns[5].Visible = false;


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }

            if (activeEntity == ActiveEntity.StatusDriver)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex6 = new();
                        var StatusDriver = contex6.StatusDrivers.Where(x => x.IdStatusDrivers == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            StatusDriver.ExecuteDelete();
                            contex6.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex6.StatusDrivers.ToList();
                            dataGridView1.Columns[2].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }
            if (activeEntity == ActiveEntity.TimeTable)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex6 = new();
                        var TimeTable = contex6.TimeTables.Where(x => x.IdTimeTable == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            TimeTable.ExecuteDelete();
                            contex6.SaveChanges();
                            UpdateInfo();
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
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }
            if (activeEntity == ActiveEntity.Transport)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var result = MessageBox.Show("Удалить?", "?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Ispr2525RadaevaVaKursachContext contex6 = new();
                        var Transport = contex6.Transports.Where(x => x.IdTransport == (int)dataGridView1.SelectedRows[0].Cells[0].Value);
                        try
                        {
                            Transport.ExecuteDelete();
                            contex6.SaveChanges();
                            UpdateInfo();
                            dataGridView1.DataSource = contex6.Transports.ToList();
                            dataGridView1.Columns[6].Visible = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Не получилось удалить: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Выберете строчку для удаления");
                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMax_Click(object sender, EventArgs e)
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

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
