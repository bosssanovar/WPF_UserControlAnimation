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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// UserControl1.xaml の相互作用ロジック
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

        }

        public void Open()
        {
            Visibility = Visibility.Visible;

            var sb = FindResource("OpenAnimation") as Storyboard;
            if (sb is not null)
            {
                sb.Begin();
            }
        }

        public void Close()
        {
            var sb = FindResource("CloseAnimation") as Storyboard;
            if (sb is not null)
            {
                sb.Completed += (sender, e) =>
                {
                    Visibility = Visibility.Collapsed;
                };

                sb.Begin();

            }
            else
            {
                Visibility = Visibility.Collapsed;
            }
        }
    }
}
