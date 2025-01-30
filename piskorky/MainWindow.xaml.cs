using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace piskorky
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public char LastPlayer { get; set; } = 'O';

        public char PlayerOne { get; set; } = 'X';

        public char PlayerTwo { get; set; } = 'O';



        public MainWindow()
        {
            InitializeComponent();
        }

        public void ProcessClick(Button button)
        {
            var buttonContent = button.Content.ToString();
            if (buttonContent.Contains(PlayerOne) || buttonContent.Contains(PlayerTwo))
            {
                return;
            }

            if (LastPlayer == PlayerOne)
            {
                button.Content = PlayerTwo;
                LastPlayer = PlayerTwo;
            }
            else if (LastPlayer == PlayerTwo)
            {
                button.Content = PlayerOne;
                LastPlayer = PlayerOne;
            }

            var isWinner = CheckWInner();
            if (isWinner)
            {
                MessageBox.Show("the one who has won is:" + LastPlayer);
            }
        }

        private void Button_00_Click(object sender, RoutedEventArgs e)
        {
            ProcessClick(sender as Button);
        }

        public bool CheckWInner()
        {
            var b_01 = Button_00.Content.ToString();
            var b_02 = Button_00_Copy.Content.ToString();
            var b_03 = Button_00_Copy1.Content.ToString();
            var b_04 = Button_00_Copy2.Content.ToString();
            var b_05 = Button_00_Copy3.Content.ToString();
            var b_06 = Button_00_Copy4.Content.ToString();
            var b_07 = Button_00_Copy5.Content.ToString();
            var b_08 = Button_00_Copy6.Content.ToString();
            var b_09 = Button_00_Copy7.Content.ToString();
            
            if (b_01 == b_02 && b_01 == b_03)
            {
                return true;
            }
            if (b_04 == b_05 && b_04 == b_06)
            {
                return true;
            }
            if (b_07 == b_08 && b_07 == b_09)
            {
                return true;
            }

            if (b_01 == b_02 && b_01 == b_03)
            {
                return true;
            }
            if (b_02 == b_05 && b_02 == b_08)
            {
                return true;
            }
            if (b_03 == b_06 && b_03 == b_09)
            {
                return true;
            }
            
            if (b_01 == b_05 && b_01 == b_09)
            {
                return true;
            }
            if (b_03 == b_05 && b_03 == b_07)
            {
                return true;
            }

            return false;
        }
    }
}