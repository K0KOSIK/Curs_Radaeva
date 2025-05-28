using Curs_Radaeva.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
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
            text1.Text = "IdAdmin";
            text2.Text = "NameAdmin";
            text3.Text = "TelAdmin";
            text4.Text = "IdAuthorization";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            text5.Visible = false;
            text6.Visible = false;
            data5.Visible = false;
            data6.Visible = false;
        }

        private void BindAuthorization(Authorization Authorization)
        {
            data1.DataBindings.Add("Text", Authorization, nameof(Authorization.IdAuthorization));
            data2.DataBindings.Add("Text", Authorization, nameof(Authorization.Login));
            data3.DataBindings.Add("Text", Authorization, nameof(Authorization.Password));
            data4.DataBindings.Add("Text", Authorization, nameof(Authorization.IdRole));
            text1.Text = "IdAuthorization";
            text2.Text = "Login";
            text3.Text = "Password";
            text4.Text = "IdRole";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            text5.Visible = false;
            text6.Visible = false;
            data5.Visible = false;
            data6.Visible = false;
        }
        private void BindClient(Client Client)
        {
            data1.DataBindings.Add("Text", Client, nameof(Client.IdClient));
            data2.DataBindings.Add("Text", Client, nameof(Client.NameClient));
            data3.DataBindings.Add("Text", Client, nameof(Client.TelClient));
            dateTimePicker1.DataBindings.Add("Text", Client, nameof(Client.DataRegisteredClient));
            data5.DataBindings.Add("Text", Client, nameof(Client.IdAvtorizacia));
            text1.Text = "IdClient";
            text2.Text = "NameClient";
            text3.Text = "TelClient";
            text4.Text = "DataRegisteredClient";
            text5.Text = "IdAvtorizacia";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            data4.Visible = false;
            data6.Visible = false;
            text6.Visible = false;
        }
        private void BindDriver(Driver Driver)
        {
            data1.DataBindings.Add("Text", Driver, nameof(Driver.IdDrivers));
            data2.DataBindings.Add("Text", Driver, nameof(Driver.NameDrivers));
            data3.DataBindings.Add("Text", Driver, nameof(Driver.LicenseNumberDrivers));
            data4.DataBindings.Add("Text", Driver, nameof(Driver.TelDrivers));
            data5.DataBindings.Add("Text", Driver, nameof(Driver.IdStatusDrivers));
            data6.DataBindings.Add("Text", Driver, nameof(Driver.IdAuthorization));
            text1.Text = "IdDrivers";
            text2.Text = "NameDrivers";
            text3.Text = "LicenseNumberDrivers";
            text4.Text = "TelDrivers";
            text5.Text = "IdStatusDrivers";
            text6.Text = "IdAuthorization";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
        }
        private void BindRole(Role role)
        {
            data1.DataBindings.Add("Text", role, nameof(role.IdRole));
            data2.DataBindings.Add("Text", role, nameof(role.NameRole));
            text1.Text = "IdRole";
            text2.Text = "NameRole";
            text3.Visible = false;
            text4.Visible = false;
            text5.Visible = false;
            text6.Visible = false;
            data3.Visible = false;
            data4.Visible = false;
            data5.Visible = false;
            data6.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
        }
        private void BindRoute(Route route)
        {
            data1.DataBindings.Add("Text", route, nameof(route.IdRoutes));
            data2.DataBindings.Add("Text", route, nameof(route.StartLocationRoutes));
            data3.DataBindings.Add("Text", route, nameof(route.EndLocationRoutes));
            data4.DataBindings.Add("Text", route, nameof(route.DistanceRoutes));
            dateTimePicker2.DataBindings.Add("Text", route, nameof(route.TravelTimeRoutes));
            text1.Text = "IdRoutes";
            text2.Text = "StartLocationRoutes";
            text3.Text = "EndLocationRoutes";
            text4.Text = "DistanceRoutes";
            text5.Text = "TravelTimeRoutes";
            dateTimePicker1.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker2.CustomFormat = "hh:mm:ss";
            data5.Visible = false;
            data6.Visible = false;
            text6.Visible = false;
        }
        private void BindStatusDriver(StatusDriver statusDriver)
        {
            data1.DataBindings.Add("Text", statusDriver, nameof(statusDriver.IdStatusDrivers));
            data2.DataBindings.Add("Text", statusDriver, nameof(statusDriver.NameStatusDrivers));
            text1.Text = "IdStatusDrivers";
            text2.Text = "NameStatusDrivers";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            data3.Visible = false;
            data4.Visible = false;
            data5.Visible = false;
            data6.Visible = false;
            text3.Visible = false;
            text4.Visible = false;
            text5.Visible = false;
            text6.Visible = false;
        }
        private void BindTimeTable(TimeTable TimeTable)
        {
            data1.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdTimeTable));
            data2.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdRoutes));
            data3.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdTransport));
            data4.DataBindings.Add("Text", TimeTable, nameof(TimeTable.IdDrivers));
            data5.DataBindings.Add("Text", TimeTable, nameof(TimeTable.DepartureTime));
            data6.DataBindings.Add("Text", TimeTable, nameof(TimeTable.ArrivalTime));
            text1.Text = "IdTimeTable";
            text2.Text = "IdRoutes";
            text3.Text = "IdTransport";
            text4.Text = "IdDrivers";
            text5.Text = "DepartureTime";
            text6.Text = "ArrivalTime";
            dateTimePicker1.Visible = false;
            dateTimePicker2.CustomFormat = "hh:mm:ss";
            dateTimePicker3.CustomFormat = "hh:mm:ss";
        }
        private void BindTransport(Transport Transport)
        {
            data1.DataBindings.Add("Text", Transport, nameof(Transport.IdTransport));
            data2.DataBindings.Add("Text", Transport, nameof(Transport.NumberplateTransport));
            data3.DataBindings.Add("Text", Transport, nameof(Transport.HeightTransport));
            data4.DataBindings.Add("Text", Transport, nameof(Transport.LongTransport));
            data5.DataBindings.Add("Text", Transport, nameof(Transport.WidthTransport));
            data6.DataBindings.Add("Text", Transport, nameof(Transport.MaxSpeedTransport));
            text1.Text = "IdTransport";
            text2.Text = "NumberplateTransport";
            text3.Text = "HeightTransport";
            text4.Text = "LongTransport";
            text5.Text = "WidthTransport";
            text6.Text = "MaxSpeedTransport";
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
        }
        private void Redact_Load(object sender, EventArgs e)
        {
            if (x == ActiveEntity.TimeTable && isEdit == IsEdit.Y)
            {
                using (var context = new Ispr2525RadaevaVaKursachContext())
                {
                    // Получаем pm из БД IdTimeTable, IdRoutes, IdTransport, IdDrivers, DepartureTime, ArrivalTime
                    var pm = context.TimeTables
                        .FirstOrDefault(p => p.IdTimeTable == Convert.ToInt32(data1.Text) &&
                        p.IdRoutes == Convert.ToInt32(data2.Text) && p.IdDrivers == Convert.ToInt32(data3.Text) && 
                        p.IdDrivers == Convert.ToInt32(data4.Text));

                    if (pm != null)
                    {
                        data1.Text = pm.IdTimeTable.ToString();
                        data2.Text = pm.IdRoutes.ToString();
                        data3.Text = pm.IdTransport.ToString();
                        data4.Text = pm.IdDrivers.ToString();
                        data1.Tag = pm.IdTimeTable;
                        data2.Tag = pm.IdRoutes;
                        data3.Tag = pm.IdTransport;
                        data4.Tag = pm.IdDrivers;
                    }
                    else
                    {
                        MessageBox.Show("Запись не найдена!");
                        this.Close();
                    }
                }
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            int Count;
            try
            {
                switch (x)
                {
                    case ActiveEntity.Admin:
                        Models.Admin Admin = new();
                        Admin.IdAdmin = Convert.ToInt32(data1.Text);
                        Admin.NameAdmin = data2.Text;
                        Admin.TelAdmin = (long)Convert.ToDouble(data3.Text);
                        Ispr2525RadaevaVaKursachContext context10 = new();
                        Count = context10.Authorizations.Count();
                        if (Convert.ToInt32(data4.Text) < 0 || Convert.ToInt32(data4.Text) > Count)
                        {
                            MessageBox.Show("IdAuthorization не может быть меньше нуля или больше:" + Count);
                            isError = IsError.Y;
                            return;
                        }
                        Admin.IdAuthorization = Convert.ToInt32(data4.Text);
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
                        Ispr2525RadaevaVaKursachContext context11 = new();
                        Count = context11.Roles.Count();
                        if (Convert.ToInt32(data4.Text) < 0 || Convert.ToInt32(data4.Text) > Count)
                        {
                            MessageBox.Show("IdRole не может быть меньше нуля или больше:" + Count);
                            isError = IsError.Y;
                            return;
                        }
                        Avtorizacium.IdRole = Convert.ToInt32(data4.Text);
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
                        Client.TelClient = Convert.ToInt64(data3.Text);
                        Client.DataRegisteredClient = DateOnly.FromDateTime(dateTimePicker1.Value);
                        Ispr2525RadaevaVaKursachContext context12 = new();
                        Count = context12.Authorizations.Count();
                        if (Convert.ToInt32(data5.Text) < 1 || Convert.ToInt32(data5.Text) > Count)
                        {
                            MessageBox.Show("IdAuthorization не может быть меньше нуля или больше:" + Count);
                            isError = IsError.Y;
                            return;
                        }
                        Client.IdAvtorizacia = Convert.ToInt32(data5.Text);
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
                        Driver.TelDrivers = (long)Convert.ToDouble(data4.Text);
                        Ispr2525RadaevaVaKursachContext context13 = new();
                        Count = context13.StatusDrivers.Count();
                        if (Convert.ToInt32(data5.Text) < 1 || Convert.ToInt32(data5.Text) > Count)
                        {
                            MessageBox.Show("IdStatusDrivers не может быть меньше нуля или больше:" + Count);
                            isError = IsError.Y;
                            return;
                        }
                        Driver.IdStatusDrivers = Convert.ToInt32(data5.Text);
                        Ispr2525RadaevaVaKursachContext context14 = new();
                        Count = context14.Authorizations.Count();
                        if (Convert.ToInt32(data6.Text) < 1 || Convert.ToInt32(data6.Text) > Count)
                        {
                            MessageBox.Show("IdAuthorization не может быть меньше нуля или больше:" + Count);
                            isError = IsError.Y;
                            return;
                        }
                        Driver.IdAuthorization = Convert.ToInt32(data6.Text);
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
                    case ActiveEntity.StatusDriver:
                        StatusDriver StatusDriver = new();
                        StatusDriver.IdStatusDrivers = Convert.ToInt32(data1.Text);
                        StatusDriver.NameStatusDrivers = data2.Text;
                        Ispr2525RadaevaVaKursachContext context7 = new();
                        if (isEdit == IsEdit.Y)
                            context7.Update(StatusDriver);
                        if (isEdit == IsEdit.N)
                            context7.Add(StatusDriver);
                        context7.SaveChanges();
                        break;
                    case ActiveEntity.Transport:
                        Transport Transport = new();
                        Transport.IdTransport = Convert.ToInt32(data1.Text);
                        Transport.NumberplateTransport = data2.Text;
                        Transport.HeightTransport = Convert.ToDecimal(data3.Text);
                        Transport.LongTransport = Convert.ToDecimal(data4.Text);
                        Transport.WidthTransport = Convert.ToDecimal(data5.Text);
                        Transport.MaxSpeedTransport = (long)Convert.ToDouble(data6.Text);
                        Ispr2525RadaevaVaKursachContext context9 = new();
                        if (isEdit == IsEdit.Y)
                            context9.Update(Transport);
                        if (isEdit == IsEdit.N)
                            context9.Add(Transport);
                        context9.SaveChanges();
                        break;
                    //case ActiveEntity.TimeTable:
                    //    TimeTable TimeTable = new();
                    //    TimeTable.IdTimeTable = Convert.ToInt32(data1.Text);
                    //    TimeTable.IdRoutes = Convert.ToInt32(data2.Text);
                    //    TimeTable.IdTransport = Convert.ToInt32(data3.Text);
                    //    TimeTable.IdDrivers = Convert.ToInt32(data4.Text);
                    //    TimeTable.DepartureTime = TimeOnly.FromDateTime(dateTimePicker2.Value);
                    //    TimeTable.ArrivalTime = TimeOnly.FromDateTime(dateTimePicker3.Value);
                    //    Ispr2525RadaevaVaKursachContext context8 = new();
                    //    if (isEdit == IsEdit.Y)
                    //        context8.Update(TimeTable);
                    //    if (isEdit == IsEdit.N)
                    //        context8.Add(TimeTable);
                    //    context8.SaveChanges();
                    //    break;
                    case ActiveEntity.TimeTable:
                        if (isEdit == IsEdit.N)
                        {
                            TimeTable TimeTable = new();
                            Ispr2525RadaevaVaKursachContext context8 = new();
                            //Count = context8.TimeTables.Count();
                            //if (Convert.ToInt32(data1.Text) > Count || Convert.ToInt32(data1.Text) < 0)
                            //{
                            //    MessageBox.Show("IdTimeTable не может быть меньше нуля или больше:" + Count);
                            //    isError = IsError.Y;
                            //    break;
                            //}
                            //else
                            TimeTable.IdTimeTable = Convert.ToInt32(data1.Text);
                            Count = context8.Routes.Count();
                            if (Convert.ToInt32(data2.Text) > Count || Convert.ToInt32(data2.Text) < 0)
                            {
                                MessageBox.Show("IdRoutes не может быть меньше нуля или больше:" + Count);
                                isError = IsError.Y;
                                return;
                                return;
                            }
                            else
                                TimeTable.IdRoutes = Convert.ToInt32(data2.Text);
                            Count = context8.Transports.Count();
                            if (Convert.ToInt32(data3.Text) > Count || Convert.ToInt32(data3.Text) < 0)
                            {
                                MessageBox.Show("IdTransport не может быть меньше нуля или больше:" + Count);
                                isError = IsError.Y;
                                return;
                            }
                            else
                                TimeTable.IdTransport = Convert.ToInt32(data3.Text);
                            Count = context8.Drivers.Count();
                            if (Convert.ToInt32(data4.Text) > Count || Convert.ToInt32(data4.Text) < 0)
                            {
                                MessageBox.Show("IdTransport не может быть меньше нуля или больше:" + Count);
                                isError = IsError.Y;
                                return;
                            }
                            else
                                TimeTable.IdDrivers = Convert.ToInt32(data4.Text);
                            Ispr2525RadaevaVaKursachContext context1 = new();
                            if (isEdit == IsEdit.Y)
                                context1.Update(TimeTable);
                            if (isEdit == IsEdit.N)
                                context1.Add(TimeTable);
                            context1.SaveChanges();
                        }
                        if (isEdit == IsEdit.Y)
                        {
                            using (var context15 = new Ispr2525RadaevaVaKursachContext())
                            {
                                int oldIdTimeTable = (data1.Tag as int?) ?? 0;//IdTimeTable, IdRoutes, IdTransport, IdDrivers, DepartureTime, ArrivalTime
                                int oldIdRoutes = (data2.Tag as int?) ?? 0;
                                int oldIdTransport = (data3.Tag as int?) ?? 0;
                                int oldIdDrivers = (data4.Tag as int?) ?? 0;
                                int IdTimeTable = Convert.ToInt32(data1.Text);
                                int IdRoutesNew = Convert.ToInt32(data2.Text);
                                int IdTransportNew = Convert.ToInt32(data3.Text);
                                int IdDriversNew = Convert.ToInt32(data4.Text);
                                TimeOnly DepartureTime = TimeOnly.FromDateTime(dateTimePicker2.Value);
                                TimeOnly ArrivalTime = TimeOnly.FromDateTime(dateTimePicker3.Value);

                                // Проверка существования проекта и материала
                                if (!context15.TimeTables.Any(p => p.IdTimeTable == IdTimeTable) || 
                                    !context15.Routes.Any(p => p.IdRoutes == IdRoutesNew) ||
                                    !context15.Transports.Any(m => m.IdTransport == IdTransportNew) || 
                                    !context15.Drivers.Any(p => p.IdDrivers == IdDriversNew))
                                {
                                    MessageBox.Show("Проект или материал не найден!");
                                    return;
                                }

                                // Проверка на дубликат новой записи
                                if (context15.TimeTables.Any(p => p.IdTimeTable == IdTimeTable && p.IdRoutes == IdRoutesNew &&
                                    p.IdTransport == IdTransportNew && p.IdDrivers == IdDriversNew))
                                {
                                    MessageBox.Show("Такая связь уже существует!");
                                    return;
                                }

                                // Удаление старой записи
                                var oldPm = context15.TimeTables
                                    .FirstOrDefault(p => p.IdTimeTable == oldIdTimeTable && p.IdRoutes == oldIdRoutes && 
                                    p.IdTransport == oldIdTransport && p.IdDrivers == oldIdDrivers);
                                //IdTimeTable, IdRoutes, IdTransport, IdDrivers, DepartureTime, ArrivalTime

                                if (oldPm == null)
                                {
                                    context15.TimeTables.Add(new TimeTable
                                    {
                                        IdTimeTable = IdTimeTable,
                                        IdRoutes = IdRoutesNew,
                                        IdTransport = IdTransportNew,
                                        IdDrivers = IdDriversNew,
                                        DepartureTime = DepartureTime,
                                        ArrivalTime = ArrivalTime
                                    });

                                    context15.SaveChanges();
                                    break;
                                }

                                context15.TimeTables.Remove(oldPm);

                                // Добавление новой записи
                                context15.TimeTables.Add(new TimeTable
                                {
                                    IdTimeTable = IdTimeTable,
                                    IdRoutes = IdRoutesNew,
                                    IdTransport = IdTransportNew,
                                    IdDrivers = IdDriversNew,
                                    DepartureTime = DepartureTime,
                                    ArrivalTime = ArrivalTime
                                });

                                context15.SaveChanges();
                            }
                        }
                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                MessageBox.Show("Ошибка: данные были изменены другим пользователем. Обновите данные.");
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
                ExceptionToFile.SaveExceptionToDesktop(ex);
            }
        }

        private void cancellation_Click(object sender, EventArgs e)
        {
            if (isEdit == IsEdit.Y)
            {
                switch (x)
                {
                    case ActiveEntity.Admin:
                        Ispr2525RadaevaVaKursachContext context = new();
                        context.SaveChanges();
                        break;
                    case ActiveEntity.Avtorizacium:
                        Ispr2525RadaevaVaKursachContext context2 = new();
                        context2.SaveChanges();
                        break;
                    case ActiveEntity.Client:
                        Ispr2525RadaevaVaKursachContext context3 = new();
                        context3.SaveChanges();
                        break;
                    case ActiveEntity.Driver:
                        Ispr2525RadaevaVaKursachContext context4 = new();
                        context4.SaveChanges();
                        break;
                    case ActiveEntity.Role:
                        Ispr2525RadaevaVaKursachContext context5 = new();
                        context5.SaveChanges();
                        break;
                    case ActiveEntity.Route:
                        Ispr2525RadaevaVaKursachContext context6 = new();
                        context6.SaveChanges();
                        break;
                    case ActiveEntity.StatusDriver:
                        Ispr2525RadaevaVaKursachContext context7 = new();
                        context7.SaveChanges();
                        break;
                    case ActiveEntity.TimeTable:
                        Ispr2525RadaevaVaKursachContext context8 = new();
                        context8.SaveChanges();
                        break;
                    case ActiveEntity.Transport:
                        Ispr2525RadaevaVaKursachContext context9 = new();
                        context9.SaveChanges();
                        break;
                    default:
                        break;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
