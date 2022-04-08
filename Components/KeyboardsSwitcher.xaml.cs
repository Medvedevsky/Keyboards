using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WpfApp.Components.Enums;

namespace WpfApp.Components
{
    public sealed class MyCommand : ICommand
    {
        private readonly Action _execute;

        public MyCommand(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        { 
            _execute?.Invoke();
        }
    }
    public partial class KeyboardsSwitcher : UserControl
    {
        private int _pastIndex;
      
        public KeyboardsSwitcher()
        {
            InitializeComponent();
            
            SwitchLanguageRu = new MyCommand(() => tabControl.SelectedIndex = (int)KeyboardType.KeyboardRu);
            SwitchLanguageEng = new MyCommand(() => tabControl.SelectedIndex = (int)KeyboardType.KeyboardEng);
            SwitchSymbols = new MyCommand(() => SwitchToSymbolKeyboard());
            SwitchKeyboard = new MyCommand(() => SwitchLanguage());
        }

        public ICommand SwitchKeyboard
        {
            get { return (ICommand)GetValue(SwitchKeyboardProperty); }
            set { SetValue(SwitchKeyboardProperty, value); }
        }

        public ICommand SwitchLanguageEng
        {
            get { return (ICommand)GetValue(SwitchLanguageEngProperty); }
            set { SetValue(SwitchLanguageEngProperty, value); }
        }

        public ICommand SwitchLanguageRu
        {
            get { return (ICommand)GetValue(SwitchLanguageRuProperty); }
            set { SetValue(SwitchLanguageRuProperty, value); }
        }


        public ICommand SwitchSymbols
        {
            get { return (ICommand)GetValue(SwitchSymbolsProperty); }
            set { SetValue(SwitchSymbolsProperty, value); }
        }


        public string KeyboardInput
        {
            get { return (string)GetValue(KeyboardInputProperty); }
            set { SetValue(KeyboardInputProperty, value); }
        }


        public static readonly DependencyProperty SwitchKeyboardProperty =
            DependencyProperty.Register(
                "SwitchKeyboard", 
                typeof(ICommand), 
                typeof(KeyboardsSwitcher), 
                new PropertyMetadata(null));


        public static readonly DependencyProperty SwitchLanguageEngProperty =
            DependencyProperty.Register(
                "SwitchLanguageEng",
                typeof(ICommand),
                typeof(KeyboardsSwitcher),
                new PropertyMetadata(null));


        public static readonly DependencyProperty SwitchLanguageRuProperty =
            DependencyProperty.Register(
                "SwitchLanguageRu", 
                typeof(ICommand), 
                typeof(KeyboardsSwitcher), 
                new PropertyMetadata(null));



        public static readonly DependencyProperty SwitchSymbolsProperty =
            DependencyProperty.Register(
                "SwitchSymbols", 
                typeof(ICommand), 
                typeof(KeyboardsSwitcher), 
                new PropertyMetadata(null));


        public static readonly DependencyProperty KeyboardInputProperty =
            DependencyProperty.Register(
                "KeyboardInput", 
                typeof(string), 
                typeof(KeyboardsSwitcher), 
                new PropertyMetadata(""));

        public void SwitchToSymbolKeyboard()
        {
            _pastIndex = tabControl.SelectedIndex;
            symbolKeyboard.PastKeyboard = _pastIndex;
            tabControl.SelectedIndex = (int)KeyboardType.SymbolsKeyboard;
        }

        public void SwitchLanguage()
        {
            
            switch ((KeyboardType)_pastIndex)
            {
                case KeyboardType.KeyboardRu:
                    tabControl.SelectedIndex = (int)KeyboardType.KeyboardRu;
                    break;
                case KeyboardType.KeyboardEng:
                    tabControl.SelectedIndex = (int)KeyboardType.KeyboardEng;
                    break;
            }

        }
    }
}

