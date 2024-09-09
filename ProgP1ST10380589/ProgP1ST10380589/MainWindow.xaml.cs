
using System.Windows;
using System.Windows.Input;
namespace ProgP1ST10380589
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            { 
                this.DragMove();
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            { 
                this.WindowState = WindowState.Normal;
            }
        }

        private void MyTextBox_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}