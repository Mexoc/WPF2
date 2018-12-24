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

namespace Lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository data;

        public MainWindow()
        {

            InitializeComponent();
            data = new Repository(3, 12);
            DataContext = data;
        }       

        private void cmbxDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listEmployees.ItemsSource = data.EmployeeDb.Where(
                w => w.DepartmentId == (cmbxDepartment.SelectedValue as Department)?.DepartmentId); 
        }
    }
}
