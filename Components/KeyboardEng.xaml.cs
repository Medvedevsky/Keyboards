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
    /// Interaction logic for KeyboardEng.xaml
    /// </summary>
    public partial class KeyboardEng : UserControl
    {
        private bool isCapsLock = false;
        public KeyboardEng()
        {
            InitializeComponent();
        }


        public ICommand SwitchToRuKeyboard
        {
            get { return (ICommand)GetValue(SwitchToRuKeyboardProperty); }
            set { SetValue(SwitchToRuKeyboardProperty, value); }
        }


        public ICommand SwitchToSymbolKeyboard
        {
            get { return (ICommand)GetValue(SwitchToSymbolKeyboardProperty); }
            set { SetValue(SwitchToSymbolKeyboardProperty, value); }
        }


        public string KeyboardEngInput
        {
            get { return (string)GetValue(KeyboardEngInputProperty); }
            set { SetValue(KeyboardEngInputProperty, value); }
        }


        public static readonly DependencyProperty SwitchToRuKeyboardProperty =
            DependencyProperty.Register(
                "SwitchToRuKeyboard", 
                typeof(ICommand), 
                typeof(KeyboardEng), 
                new PropertyMetadata(null));


        public static readonly DependencyProperty SwitchToSymbolKeyboardProperty =
            DependencyProperty.Register(
                "SwitchToSymbolKeyboard", 
                typeof(ICommand), 
                typeof(KeyboardEng), 
                new PropertyMetadata(null));


        public static readonly DependencyProperty KeyboardEngInputProperty =
            DependencyProperty.Register(
                "KeyboardEngInput",
                typeof(string),
                typeof(KeyboardEng),
                new PropertyMetadata(""));

        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            KeyboardEngInput += keyContent.Text;
        }

        private void Button_Click_CapsLock(object sender, RoutedEventArgs e)
        {

            isCapsLock = !isCapsLock;
            List<Grid> gridsList = mainGrid.Children.OfType<Grid>().ToList();

            foreach (Grid grid in gridsList)
            {
                List<Button> buttonList = grid.Children.OfType<Button>().ToList();

                foreach (Button buttonKey in buttonList)
                {
                    Viewbox viewBox = (Viewbox)buttonKey.Content;
                    TextBlock keyContent = (TextBlock)viewBox.Child;

                    keyContent.Text = isCapsLock == true ? keyContent.Text.ToUpper() : keyContent.Text.ToLower();
                }
            }
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int position = KeyboardEngInput.Length - 1;
            KeyboardEngInput = position >= 0 ? KeyboardEngInput.Remove(position) : KeyboardEngInput;
        }

        private void Button_Click_Space(object sender, RoutedEventArgs e)
        {
            KeyboardEngInput += " ";
        }
    }
}
