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
    /// Interaction logic for Keyboard.xaml
    /// </summary>
    public partial class KeyboardRu : UserControl
    {
        private bool isCapsLock = false;
        private bool engLanguage = false;
       
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Й" : "й";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ц" : "ц";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "У" : "у";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "К" : "к";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "E" : "e";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Н" : "н";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Г" : "г";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ш" : "ш";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Щ" : "щ";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "З" : "з";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Х" : "х";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "1";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "2";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "3";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ф" : "ф";
        }
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ы" : "ы";
        }
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "В" : "в";
        }
        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "А" : "а";
        }
        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "П" : "п";
        }
        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Р" : "р";
        }
        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "О" : "о";
        }
        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Л" : "л";
        }
        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Д" : "д";
        }
        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ж" : "ж";
        }
        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Э" : "э";
        }
        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "4";
        }
        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "5";
        }
        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "6";
        }
        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "Я";
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ч" : "ч";
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "С" : "с";
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "М" : "м";
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "И" : "и";
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Т" : "т";
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ь" : "ь";
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Б" : "б";
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ю" : "ю";
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ъ" : "ъ";
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ё" : "ё";
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "7";
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "8";
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "9";
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {
            engLanguage = true;
        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            KeyboardInput += " ";
        }

        private void Button_Click_45(object sender, RoutedEventArgs e)
        {
            isCapsLock = !isCapsLock;
        }

        private void Button_Click_46(object sender, RoutedEventArgs e)
        {
            KeyboardInput += isCapsLock == true ? "Ё" : "ё";
        }

        private void Button_Click_47(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "-";
        }

        private void Button_Click_48(object sender, RoutedEventArgs e)
        {
            KeyboardInput += "0";
        }

        private void Button_Click_49(object sender, RoutedEventArgs e)
        {
            int temp = KeyboardInput.Length - 1;
            KeyboardInput = temp >= 0 ? KeyboardInput.Remove(temp) : KeyboardInput;
        }
    }
}
