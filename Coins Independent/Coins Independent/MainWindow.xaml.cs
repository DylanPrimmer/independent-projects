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

namespace Coins_Independent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Toonies = new int();
        int Loonies = new int();
        int Quarters = new int();
        int Dimes = new int();
        int Nickels = new int();
        double ToonieValue = 2;
        double LoonieValue = 1;
        double QuarterValue = 0.25;
        double DimeValue = 0.10;
        double NickelValue = 0.05;
        double TotalValue;

        public MainWindow()
        {
            InitializeComponent();
            // Prompt the user for the number of nickels, dimes, quarters, Loonies and Toonies and then displays the total dollar amount.The application should have a method called getDollarAmount() that takes five parameters corresponding to the number of coins.The method should return a string which is a total with the dollar sign.


        }

        public void Click_Calc(object Sender, RoutedEventArgs e)
        {
            {
                int.TryParse(inpt_Toonies.Text, out Toonies);
                int.TryParse(inpt_Loonies.Text, out Loonies);
                int.TryParse(inpt_Quarters.Text, out Quarters);
                int.TryParse(inpt_Dimes.Text, out Dimes);
                int.TryParse(inpt_Nickels.Text, out Nickels);

                TotalValue = Nickels * NickelValue;
                TotalValue = TotalValue + (Dimes * DimeValue);
                TotalValue = TotalValue + (Quarters * QuarterValue);
                TotalValue = TotalValue + (Loonies * LoonieValue);
                TotalValue = TotalValue + (Toonies * ToonieValue);

                Output.Text = "$" + TotalValue.ToString();


            }
        }

  
        
    }
}
