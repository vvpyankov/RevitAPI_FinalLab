using Autodesk.Revit.UI;
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

namespace RevitAPI_FinalLab
{
    /// <summary>
    /// Логика взаимодействия для MainViewFinal.xaml
    /// </summary>
    public partial class MainViewFinal : Window
    {
        public MainViewFinal(ExternalCommandData commandData)
        {
            InitializeComponent();
            MainViewFinalViewModel vm = new MainViewFinalViewModel(commandData);
            vm.CloseRequest += (s, e) => this.Close();
            DataContext = vm;
        }
    }
}
