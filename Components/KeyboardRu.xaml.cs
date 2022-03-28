using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp.Components
{
    /// <summary>
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class KeyboardRu : UserControl
    {
        private bool isCapsLock = true;
        private bool engLanguage = false;
        private bool symbolKeyboard = false;

        public string KeyboardInput
        {
            get { return (string)GetValue(KeyboardInputProperty); }
            set { SetValue(KeyboardInputProperty, value); }
        }

        // Using a DependencyProperty as the backing store for KeyboardInput.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty KeyboardInputProperty =
            DependencyProperty.Register("KeyboardInput", typeof(string), typeof(KeyboardRu), new PropertyMetadata(""));


        public KeyboardRu()
        {
            InitializeComponent();
        }

        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            //KeyboardInput += ((TextBlock)((Viewbox)((Button)sender).Content).Child).Text;

            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            KeyboardInput += keyContent.Text;
        }

        private void Button_Click_CapsLock(object sender, RoutedEventArgs e)
        {
            isCapsLock = !isCapsLock;
            List<Button> buttonList = mainGrid.Children.OfType<Button>().ToList();
            
            foreach(Button buttonKey in buttonList)
            {
                Viewbox viewBox = (Viewbox)buttonKey.Content;
                TextBlock keyContent = (TextBlock)viewBox.Child;

                keyContent.Text = isCapsLock == true ? keyContent.Text.ToUpper() : keyContent.Text.ToLower();
            }
        }

        private void Button_Click_ChangeLanguage(object sender, RoutedEventArgs e)
        {
            engLanguage = true;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int countInput = KeyboardInput.Length - 1;
            KeyboardInput = countInput >= 0 ? KeyboardInput.Remove(countInput) : KeyboardInput;
        }

        private void Button_Click_Space(object sender, RoutedEventArgs e)
        {
            KeyboardInput += " ";
        }

        private void Button_Click_SymbolKeyboard(object sender, RoutedEventArgs e)
        {
            symbolKeyboard = true;
        }
    }
}
