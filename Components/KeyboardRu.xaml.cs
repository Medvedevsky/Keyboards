using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp.Components
{

    public partial class KeyboardRu : UserControl
    {
        private bool isCapsLock = false;

        public KeyboardRu()
        {
            InitializeComponent();

        }

        public ICommand SwitchToEngKeyboard
        {
            get { return (ICommand)GetValue(SwitchToEngKeyboardProperty); }
            set { SetValue(SwitchToEngKeyboardProperty, value); }
        }

        public ICommand SwitchToSymbolKeyboard
        {
            get { return (ICommand)GetValue(SwitchToSymbolKeyboardProperty); }
            set { SetValue(SwitchToSymbolKeyboardProperty, value); }
        }

        public string KeyboardRuInput
        {
            get { return (string)GetValue(KeyboardRuInputProperty); }
            set { SetValue(KeyboardRuInputProperty, value); }
        }


        public static readonly DependencyProperty SwitchToEngKeyboardProperty =
            DependencyProperty.Register(
                "SwitchToEngKeyboard",
                typeof(ICommand),
                typeof(KeyboardRu),
                new PropertyMetadata(null));


        public static readonly DependencyProperty SwitchToSymbolKeyboardProperty =
            DependencyProperty.Register(
                "SwitchToSymbolKeyboard",
                typeof(ICommand),
                typeof(KeyboardRu),
                new PropertyMetadata(null));


        public static readonly DependencyProperty KeyboardRuInputProperty =
            DependencyProperty.Register(
                "KeyboardRuInput",
                typeof(string),
                typeof(KeyboardRu),
                new PropertyMetadata(""));

        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            KeyboardRuInput += keyContent.Text;
        }

        private void Button_Click_CapsLock(object sender, RoutedEventArgs e)
        {
            isCapsLock = !isCapsLock;
            List<Button> buttonList = mainGrid.Children.OfType<Button>().ToList();

            foreach (Button buttonKey in buttonList)
            {
                if(buttonKey.Content is Viewbox viewBox)
                {
                    TextBlock keyContent = (TextBlock)viewBox.Child;
                    keyContent.Text = isCapsLock == true ? keyContent.Text.ToUpper() : keyContent.Text.ToLower();
                }
            }
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int position = KeyboardRuInput.Length - 1;
            KeyboardRuInput = position >= 0 ? KeyboardRuInput.Remove(position) : KeyboardRuInput;
        }

        private void Button_Click_Space(object sender, RoutedEventArgs e)
        {
            KeyboardRuInput += " ";
        }
    }
}
