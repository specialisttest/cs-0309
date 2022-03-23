using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace AsyncPattern
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int LongExecute()
        {
            Thread.Sleep(3000);
            return 1;
        }


        private void MyCallBack(IAsyncResult r)
        {
            if (r.IsCompleted)
                label.Dispatcher.Invoke(() => label.Content = "Finished");

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Func<int> t = this.LongExecute;
            t.BeginInvoke(MyCallBack, new object());
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int result = LongExecute();
            label.Content = result.ToString();
        }
        private async void button2_Click(object sender, RoutedEventArgs e)
        {
            int result =  await Task.Run(() => LongExecute());
            label.Dispatcher.Invoke(() => label.Content = result);
        }
    }
}
