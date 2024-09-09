
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProgP1ST10380589.UserControls
{
    
    public partial class Claims : UserControl
    {
        public Claims()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return (string)GetValue(Titleproperty); }
            set { SetValue(Titleproperty, value); }
        }
        public static readonly DependencyProperty Titleproperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Claims));


        public string Time
        {
            get { return (string)GetValue(Timeproperty); }
            set { SetValue(Timeproperty, value); }
        }
        public static readonly DependencyProperty Timeproperty =
            DependencyProperty.Register("Time", typeof(string), typeof(Claims));


        public string Number
        {
            get { return (string)GetValue(Numberproperty); }
            set { SetValue(Numberproperty, value); }
        }
        public static readonly DependencyProperty Numberproperty =
            DependencyProperty.Register("Number", typeof(string), typeof(Claims));


        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveproperty); }
            set { SetValue(IsActiveproperty, value); }
        }
        public static readonly DependencyProperty IsActiveproperty =
            DependencyProperty.Register("IsActive", typeof(string), typeof(Claims));


        public string Image
        {
            get { return (string)GetValue(Imageproperty); }
            set { SetValue(Imageproperty, value); }
        }
        public static readonly DependencyProperty Imageproperty =
            DependencyProperty.Register("Image", typeof(string), typeof(Claims));


       
    }
}
