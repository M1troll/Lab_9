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
using System.IO;
using BL;
using Shared;
using System.Diagnostics;

namespace Evil_List
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComeIn.Click += Check_Click;
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BlackList blacklist = new BlackList
                {
                    DataContext = new Logic(Login.Text, Password.Password)
                };
                blacklist.Show();
                this.Close();
            }
            catch (AccessException)
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации");
            }
            catch (FileNotFoundException) 
            {
            MessageBox.Show("Ваш список мести нашли преподаватели ...\r\nБегите!", "ОПАСНОСТЬ");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("В вашем списке пропущена строка!\r\nВам нужно исправить это!", "ERRORinTXT");
                Process.Start(@"BlackList.txt");
            }
        }
    }
}
