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

namespace WpfApp.Components
{
    /// <summary>
    /// Interaction logic for NumericKeypad.xaml
    /// </summary>
    public partial class NumericKeypad : UserControl
    {
        public NumericKeypad()
        {
            InitializeComponent();
        }

        public string KeyboardNumericInput
        {
            get { return (string)GetValue(KeyboardNumericInputProperty); }
            set { SetValue(KeyboardNumericInputProperty, value); }
        }

       
        public static readonly DependencyProperty KeyboardNumericInputProperty =
            DependencyProperty.Register(
                "KeyboardNumericInput", 
                typeof(string), 
                typeof(NumericKeypad), 
                new PropertyMetadata(0));


        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            KeyboardNumericInput += keyContent.Text;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int position = KeyboardNumericInput.Length - 1;
            KeyboardNumericInput = position >= 0 ? KeyboardNumericInput.Remove(position) : KeyboardNumericInput;
        }
    }
}
