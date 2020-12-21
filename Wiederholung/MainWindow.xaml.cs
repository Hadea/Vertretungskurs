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

namespace Wiederholung
{
    public delegate void MeinDelegate();

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MeinDelegate lustigesEvent;
        Action anderesEvent;
        public MainWindow()
        {
            InitializeComponent();

            tblDemoBlock.Inlines.Add(new Run("c# gesetzter text"));
            tblDemoBlock.Inlines.Add(new Bold(new Run("im Konstruktor!")));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn) btn.Background = Brushes.Red;

            List<int> lst = new();
            lst.ForEach((item) => Console.WriteLine(item));

            Parallel.ForEach(lst, (item) => Console.WriteLine(item));

            int zahl = 0;

            Parallel.Invoke(
                () => somthingZ(ref zahl),
                () => somthingZ(ref zahl),
                () => somthingZ(ref zahl),
                () => somthing(ref zahl),
                () => somthing(ref zahl),
                () => somthing(ref zahl),
                () => somthing(ref zahl),
                () => somthing(ref zahl));
        }



        void somthing(ref int a) => a++;
        
        void somthingZ(ref int a)
        {
            a--;
        }
    }
}
