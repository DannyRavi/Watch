using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Watch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Timer timer = new Timer(1000);
        public MainWindow()
        {
            InitializeComponent();
            // PersianCalendar pc = new PersianCalendar();
            // DateTime gg = new DateTime(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now), pc.GetDayOfMonth(DateTime.Now));
            // txtData.Text=gg.ToString("yyyy/MM/dd");
            txtData.Text = DateTime.Now.ToString("yyyy/MM/dd");
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke((Action)(() =>
            {
                SecondTi.Angle = DateTime.Now.Second * 6;
                MinuteTi.Angle = DateTime.Now.Minute * 6;
                HourTi.Angle = DateTime.Now.Hour * 30;
            }));
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
