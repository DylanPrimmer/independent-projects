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

namespace math_tutor_independent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();

        string[] MathSign = new string[4];
        int answer;
        string question;
        int rnumberoperator;
        int Number;
        int Number2;

        public MainWindow()
        {
            InitializeComponent();

            MathSign[0] = "+";
            MathSign[1] = "-";
            MathSign[2] = "*";
            MathSign[3] = "/";


            setupQuestion();



        }
        public void setupQuestion()
        {
            Number = rnd.Next(1, 11); //creates a random number between 0 and 10
            Number2 = rnd.Next(1, 11); //creates a random number between 0 and 10


            rnumberoperator = rnd.Next(0, 4);
            question = Number.ToString() + " " + MathSign[rnumberoperator] + " " + Number2.ToString();
            rndquestion.Text = question;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                if (MathSign[rnumberoperator] == "-")
                {
                
                answer = Number - Number2;
                }
                else if (MathSign[rnumberoperator] == "*")
                {
                    answer = Number * Number2;
                }
                else if (MathSign[rnumberoperator] == "/")
                {
                    answer = Number / Number2;
                }
                else if (MathSign[rnumberoperator] == "+")
                {
                    answer = Number + Number2;
                }

                if (enter.Text == answer.ToString())
                {
                    MessageBox.Show("Correct");

                }
                else if (enter.Text != answer.ToString())
                {
                    MessageBox.Show("Incorrect");
                }

            //run setupQuestion
            setupQuestion();
            }

        private void Whole_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

       
    

        
    

