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
    /// Interaction logic for SymbolKeyboard.xaml
    /// </summary>
    public partial class SymbolKeyboard : UserControl
    {

        public SymbolKeyboard()
        {
            InitializeComponent();
        }

        public ICommand SwitchKeyboardLanguage
        {
            get { return (ICommand)GetValue(SwitchKeyboardLanguageProperty); }
            set { SetValue(SwitchKeyboardLanguageProperty, value); }
        }

        public string SymbolKeyboardInput
        {
            get { return (string)GetValue(SymbolKeyboardInputProperty); }
            set { SetValue(SymbolKeyboardInputProperty, value); }
        }

        public static readonly DependencyProperty SwitchKeyboardLanguageProperty =
            DependencyProperty.Register(
                "SwitchKeyboardLanguage", 
                typeof(ICommand), 
                typeof(SymbolKeyboard), 
                new PropertyMetadata(null));

        public static readonly DependencyProperty SymbolKeyboardInputProperty =
            DependencyProperty.Register(
                "SymbolKeyboardInput", 
                typeof(string), 
                typeof(SymbolKeyboard), 
                new PropertyMetadata(""));

        private void Button_Click_Key(object sender, RoutedEventArgs e)
        {
            Button buttonKey = (Button)sender;
            Viewbox viewBox = (Viewbox)buttonKey.Content;
            TextBlock keyContent = (TextBlock)viewBox.Child;
            SymbolKeyboardInput += keyContent.Text;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            int countInput = SymbolKeyboardInput.Length - 1;
            SymbolKeyboardInput = countInput >= 0 ? SymbolKeyboardInput.Remove(countInput) : SymbolKeyboardInput;
        }

        private void Button_Click_Space(object sender, RoutedEventArgs e)
        {
            SymbolKeyboardInput += " ";
        }
    }
}
