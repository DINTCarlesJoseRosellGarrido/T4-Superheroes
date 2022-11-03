using T4_Superheroes.Modelos;
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

namespace T4_Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> super = Superheroe.GetSamples();
        int index = 0;
        
        public MainWindow()
        {
            InitializeComponent();
            DatosSuper.DataContext = super[index];
        }

        private void buttonPrevious_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(index == 0)
            {
                index = 2;
            }
            else
            {
                index--;
            }

            DatosSuper.DataContext = super[index];
            numberChange.Text = (index+1).ToString();
        }

        private void buttonNext_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (index == 2)
            {
                index = 0;
            }
            else
            {
                index++;
            }

            DatosSuper.DataContext = super[index];
            numberChange.Text = (index + 1).ToString();
        }
    }
}
