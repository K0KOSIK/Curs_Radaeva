using Curs_Radaeva.Models;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Curs_Radaeva
{

    public partial class Redact : Form
    {
        public int IdAdmin { get; set; }

        public string NameAdmin { get; set; } = null!;

        public long TelAdmin { get; set; }

        public int? IdAuthorization { get; set; }

        public string Login { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int IdRole { get; set; }

        public virtual Admin? Admin { get; set; }

        public virtual Client? Client { get; set; }

        public virtual Driver? Driver { get; set; }
        public int IdClient { get; set; }

        public string NameClient { get; set; } = null!;

        public long TelClient { get; set; }

        public DateOnly DataRegisteredClient { get; set; }

        public int? IdAvtorizacia { get; set; }
        public int IdDrivers { get; set; }

        public string NameDrivers { get; set; } = null!;

        public int LicenseNumberDrivers { get; set; }

        public long TelDrivers { get; set; }

        public int IdStatusDrivers { get; set; }

        public int IdRoutes { get; set; }

        public string StartLocationRoutes { get; set; } = null!;

        public string EndLocationRoutes { get; set; } = null!;

        public int DistanceRoutes { get; set; }

        public string NameRole { get; set; } = null!;

        public string NameStatusDrivers { get; set; } = null!;

        public int IdTimeTable { get; set; }

        public int IdTransport { get; set; }

        public TimeOnly DepartureTime { get; set; }

        public TimeOnly ArrivalTime { get; set; }

        public string NumberplateTransport { get; set; } = null!;

        public decimal HeightTransport { get; set; }

        public decimal LongTransport { get; set; }

        public decimal WidthTransport { get; set; }

        public long MaxSpeedTransport { get; set; }

        public ActiveEntity x { get; set; }

        public IsEdit isEdit { get; set; }
        public IsError isError;
        public Redact(ActiveEntity activeEntity, object entityData)
        {
            InitializeComponent();
            x = activeEntity;
            ConfigureForm(entityData);
            isError = IsError.N;
        }

        private void ConfigureForm(object entityData)
        {
            switch (x)
            {
                case ActiveEntity.Admin:
                    BindAdmin((Models.Admin)entityData);
                    break;
                case ActiveEntity.Avtorizacium:
                    BindAuthorization((Authorization)entityData);
                    break;
                case ActiveEntity.Client:
                    BindClient((Client)entityData);
                    break;
                case ActiveEntity.Driver:
                    BindDriver((Driver)entityData);
                    break;
                case ActiveEntity.Role:
                    BindRole((Role)entityData);
                    break;
                case ActiveEntity.Route:
                    BindRoute((Route)entityData);
                    break;
                case ActiveEntity.StatusDriver:
                    BindStatusDriver((StatusDriver)entityData);
                    break;
                case ActiveEntity.TimeTable:
                    BindTimeTable((TimeTable)entityData);
                    break;
                case ActiveEntity.Transport:
                    BindTransport((Transport)entityData);
                    break;
            }
        }

        private void BindAdmin(Models.Admin Admin)
        {
            data1.DataBindings.Add("Text", Admin, nameof(Admin.IdAdmin));
            data2.DataBindings.Add("Text", Admin, nameof(Admin.NameAdmin));
            data3.DataBindings.Add("Text", Admin, nameof(Admin.TelAdmin));
            data4.DataBindings.Add("Text", Admin, nameof(Admin.IdAuthorization));
        }

        private void BindAuthorization(Authorization Authorization)
        {
            data1.DataBindings.Add("Text", Authorization, nameof(Authorization.IdAuthorization));
            data2.DataBindings.Add("Text", Authorization, nameof(Authorization.Login));
            data3.DataBindings.Add("Text", Authorization, nameof(Authorization.Password));
            data4.DataBindings.Add("Text", Authorization, nameof(Authorization.IdRole));
        }
        private void BindClient(Client Client)
        {
            data1.DataBindings.Add("Text", Client, nameof(Client.IdClient));
            data2.DataBindings.Add("Text", Client, nameof(Client.NameClient));
            data3.DataBindings.Add("Text", Client, nameof(Client.TelClient));
            dateTimePicker1.DataBindings.Add("Text", Client, nameof(Client.DataRegisteredClient));
            data5.DataBindings.Add("Text", Client, nameof(Client.IdAvtorizacia));
        }
        private void BindDriver(Driver Driver)
        {
            data1.DataBindings.Add("Text", Driver, nameof(Driver.IdDrivers));
            data2.DataBindings.Add("Text", Driver, nameof(Driver.NameDrivers));
            data3.DataBindings.Add("Text", Driver, nameof(Driver.LicenseNumberDrivers));
            data4.DataBindings.Add("Text", Driver, nameof(Driver.TelDrivers));
            data5.DataBindings.Add("Text", Driver, nameof(Driver.IdStatusDrivers));
            data6.DataBindings.Add("Text", Driver, nameof(Driver.IdAuthorization));
        }
        private void BindRole(Role role)
        {
            data1.DataBindings.Add("Text", role, nameof(role.IdRole));
            data2.DataBindings.Add("Text", role, nameof(role.NameRole));
        }
        private void BindRoute(Route route)
        {
            data1.DataBindings.Add("Text", route, nameof(route.IdRoutes));
            data2.DataBindings.Add("Text", route, nameof(route.StartLocationRoutes));
            data3.DataBindings.Add("Text", route, nameof(route.EndLocationRoutes));
            data4.DataBindings.Add("Text", route, nameof(route.DistanceRoutes));
            data5.DataBindings.Add("Text", route, nameof(route.TravelTimeRoutes));
        }
        private void BindStatusDriver(StatusDriver statusDriver)
        {
            data1.DataBindings.Add("Text", statusDriver, nameof(statusDriver.IdStatusDrivers));
            data2.DataBindings.Add("Text", statusDriver, nameof(statusDriver.NameStatusDrivers));
        }
        private void BindTimeTable(TimeTable TimeTable)
        {
            data1.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdTimeTable));
            data2.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdRoutes));
            data3.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdTransport));
            data4.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdDrivers));
            data5.DataBindings.Add("Text", TimeTable, nameof(TimeTable.DepartureTime));
            data6.DataBindings.Add("Text", TimeTable, nameof(TimeTable.ArrivalTime));
        }
        private void BindTransport(Transport Transport)
        {
            data1.DataBindings.Add("Text", Transport, nameof(Transport.IdTransport));
            data2.DataBindings.Add("Text", Transport, nameof(Transport.NumberplateTransport));
            data3.DataBindings.Add("Text", Transport, nameof(Transport.HeightTransport));
            data4.DataBindings.Add("Text", Transport, nameof(Transport.LongTransport));
            data5.DataBindings.Add("Text", Transport, nameof(Transport.WidthTransport));
            data6.DataBindings.Add("Text", Transport, nameof(Transport.MaxSpeedTransport));
        }

        private void save_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case ActiveEntity.Admin:
                    Models.Admin Admin = new();
                    Admin.IdAdmin = Convert.ToInt32(data1.Text);
                    Admin.NameAdmin = data2.Text;
                    Admin.TelAdmin = Convert.ToInt32(data3.Text);
                    Admin.IdAuthorization = Convert.ToInt32(data4.Text);
                    if (Convert.ToInt32(data4.Text) < 1 || Convert.ToInt32(data4.Text) > 2)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 2", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525RadaevaVaKursachContext context = new();
                    if (isEdit == IsEdit.Y)
                        context.Update(Admin);
                    if (isEdit == IsEdit.N)
                        context.Add(Admin);
                    context.SaveChanges();
                    break;
                case ActiveEntity.Avtorizacium:
                    Authorization Avtorizacium = new();
                    Avtorizacium.IdAuthorization = Convert.ToInt32(data1.Text);
                    Avtorizacium.Login = data2.Text;
                    Avtorizacium.Password = data3.Text;
                    Avtorizacium.IdRole = Convert.ToInt32(data4.Text);
                    if (Convert.ToInt32(data4.Text) < 1 || Convert.ToInt32(data4.Text) > 3)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 3", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525RadaevaVaKursachContext context2 = new();
                    if (isEdit == IsEdit.Y)
                    {
                        context2.Update(Avtorizacium);
                    }
                    if (isEdit == IsEdit.N)
                    {
                        context2.Add(Avtorizacium);
                    }
                    context2.SaveChanges();
                    break;
                case ActiveEntity.Client:
                    Client Client = new();
                    Client.IdClient = Convert.ToInt32(data1.Text);
                    Client.NameClient = data2.Text;
                    Client.TelClient = Convert.ToInt32(data3.Text);
                    Client.DataRegisteredClient = DateOnly.FromDateTime(dateTimePicker1.Value);
                    Client.IdAvtorizacia = Convert.ToInt32(data5.Text);
                    if (Convert.ToInt32(data5.Text) < 1 || Convert.ToInt32(data5.Text) > 15)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 15", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525RadaevaVaKursachContext context3 = new();
                    if (isEdit == IsEdit.Y)
                        context3.Update(Client);
                    if (isEdit == IsEdit.N)
                        context3.Add(Client);
                    context3.SaveChanges();
                    break;
                case ActiveEntity.Driver:
                    Driver Driver = new();
                    Driver.IdDrivers = Convert.ToInt32(data1.Text);
                    Driver.NameDrivers = data2.Text;
                    Driver.LicenseNumberDrivers = Convert.ToInt32(data3.Text);
                    Driver .TelDrivers = Convert.ToInt32(data4.Text);
                    Driver.IdStatusDrivers = Convert.ToInt32(data5.Text);
                    if (Convert.ToInt32(data5.Text) < 1 || Convert.ToInt32(data5.Text) > 2)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 2", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Driver.IdAuthorization = Convert.ToInt32(data6.Text);
                    if (Convert.ToInt32(data5.Text) < 1 || Convert.ToInt32(data6.Text) > 5)
                    {
                        MessageBox.Show("Значение должно быть от 1 до 5", "Ошибка",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isError = IsError.Y;
                        break;
                    }
                    Ispr2525RadaevaVaKursachContext context4 = new();
                    if (isEdit == IsEdit.Y)
                        context4.Update(Driver);
                    if (isEdit == IsEdit.N)
                        context4.Add(Driver);
                    context4.SaveChanges();
                    break;
                case ActiveEntity.Role:
                    Role Role = new();
                    Role.IdRole = Convert.ToInt32(data1.Text);
                    Role.NameRole = data2.Text;
                    Ispr2525RadaevaVaKursachContext context5 = new();
                    if (isEdit == IsEdit.Y)
                        context5.Update(Role);
                    if (isEdit == IsEdit.N)
                        context5.Add(Role);
                    context5.SaveChanges();
                    break;
                case ActiveEntity.Route:
                    Route Route = new();
                    Route.IdRoutes = Convert.ToInt32(data1.Text);
                    Route.StartLocationRoutes = data2.Text;
                    Route.EndLocationRoutes = data3.Text;
                    Route.DistanceRoutes = Convert.ToInt32(data4.Text);
                    Route.TravelTimeRoutes = TimeOnly.FromDateTime(dateTimePicker2.Value);
                    Ispr2525RadaevaVaKursachContext context6 = new();
                    if (isEdit == IsEdit.Y)
                        context6.Update(Route);
                    if (isEdit == IsEdit.N)
                        context6.Add(Route);
                    context6.SaveChanges();
                    break;
                //case ActiveEntity.Status:
                //    Status status = new();
                //    status.IdStatus = Convert.ToInt32(input.Text);
                //    status.Status1 = input4.Text;
                //    Ispr2525RadaevaVaKursachContext context7 = new();
                //    if (isEdit == IsEdit.Y)
                //        context7.Update(status);
                //    if (isEdit == IsEdit.N)
                //        context7.Add(status);
                //    context7.SaveChanges();
                //    break;
                default:
                    break;
            }
            if (isError == IsError.N)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
