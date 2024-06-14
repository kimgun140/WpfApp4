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

namespace WpfApp4
{
    /// <summary>
    /// CS_CC.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CS_CC : Page
    {

        public CS_CC()
        {
            InitializeComponent();
            var mainWindow = Application.Current.MainWindow;
            if (mainWindow != null)
            {
                mainWindow.Width = 600; // 원하는 너비로 설정
                mainWindow.Height = 1000; // 원하는 높이로 설정
            }
        }
    }
}
