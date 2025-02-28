using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfBeauty.Models;
using System.Data.Entity;

namespace WpfBeauty.Pages
{
    /// <summary>
    /// Логика взаимодействия для Upcoming.xaml
    /// </summary>
    public partial class Upcoming : Window
    {
        List<ClientService> _cservices = new List<ClientService>();

        private DispatcherTimer counterTimer;
        private int counterValue;

        public Upcoming()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeCounter();
            LoadAppointments();
            this.Closing += Upcoming_Closing;
        }

        private void Upcoming_Closing(object sender, System.ComponentModel.CancelEventArgs e) // остановка таймера
        {
            // Остановка таймера, когда окно закрывается
            if (counterTimer != null)
            {
                counterTimer.Stop();
            }
        }
        private void InitializeCounter() // создание счетчика на 30 секунд
        {
            counterTimer = new DispatcherTimer();
            counterTimer.Interval = TimeSpan.FromSeconds(1);
            counterTimer.Tick += CounterTimer_Tick;
            counterTimer.Start();
            counterValue = 0; // Инициализация счетчика
        }

        private void CounterTimer_Tick(object sender, EventArgs e) // запуск счетчика на 30 секунд, при 30 - обнуляемся
        {
            counterValue++;
            tb_timer_2.Text = counterValue.ToString();

            if (counterValue >= 30)
            {
                counterValue = 0; // Обнуление счетчика
                LoadAppointments();
            }
        }

        private void InitializeTimer() // создание локального времени
        {

            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick_1;
            LiveTime.Start();
        }

        void timer_Tick_1(object sender, EventArgs e) // показ локального времени в окне
        {
            tb_timer.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void LoadAppointments()  // обновление списков
        {
            _cservices = new List<ClientService>();
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var cserviceList = Helper.GetContext().ClientService
                                    .Include(cs => cs.Service)
                                    .Include(cs => cs.Client)
                                    .OrderBy(cs => cs.StartTime)
                                    
                                    .ToList();
            _cservices.Clear();


            foreach (ClientService cs in cserviceList)
            {
                if (cs.StartTime >= today && cs.StartTime < tomorrow.AddDays(1))
                {
                    if (cs.StartTime > DateTime.Now)
                    {
                        if ((cs.StartTime - DateTime.Now).TotalMinutes < 60)
                            cs.HasTime = true; // если услуга через час
                        else
                            cs.HasTime = false;

                        cs.TimeRemaining = (cs.StartTime - DateTime.Now).ToString(@"hh\:mm");
                        
                    }
                    else
                    {
                        cs.TimeRemaining = "Пройдена"; // или null, если время услуги уже прошло
                        
                    }
                    _cservices.Add(cs);
                }
            }
            Grid.ItemsSource = _cservices;
        }
    }

}
