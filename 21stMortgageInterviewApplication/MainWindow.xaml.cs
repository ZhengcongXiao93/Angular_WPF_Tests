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

namespace _21stMortgageInterviewApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void user_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            //set as placeholder
            if (user_input.Text == "User Input")
            {
                user_input.Text = "";
                user_input.Foreground = Brushes.Black;
            }

        }

        private void user_input_show_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //Find Lagest
        private void button_Click(object sender, RoutedEventArgs e)
        {
            //input show in the input textbox
            string userInput = user_input.Text;
            user_input_show.Text = userInput;

            //find largest number
            int maxNumber = 0, num = 0, i = 0;
            //list to save number
            List<int> numList = new List<int>();
            string[] nums = this.user_input.Text.Trim().Split(',');

            for (; i < nums.Length; i++)
            {
                num = Convert.ToInt32(nums[i]);
                numList.Add(num);
            }

            maxNumber = numList.Max();
            result_textbox.Text = Convert.ToString(maxNumber);
        }

        //odd sum
        private void odd_sum_Click(object sender, RoutedEventArgs e)
        {
            string userInput = user_input.Text;
            user_input_show.Text = userInput;

            int sum = 0, num = 0, i = 0;
            string[] nums = this.user_input.Text.Trim().Split(',');
            for (; i < nums.Length; i++)
            {
                num = Convert.ToInt32(nums[i]);
                if (num%2 != 0)
                {
                    sum = sum + num;
                }
            }

            if (sum > 0)
            {
                result_color.Background = Brushes.Green;
            }else if(sum < 0)
            {
                result_color.Background = Brushes.Red;
            }

            result_textbox.Text = Convert.ToString(sum);
        }

        //even sum
        private void even_sum_Click(object sender, RoutedEventArgs e)
        {
            string userInput = user_input.Text;
            user_input_show.Text = userInput;

            int sum = 0, num = 0, i = 0;
            string[] nums = this.user_input.Text.Trim().Split(',');
            for (; i < nums.Length; i++)
            {
                num = Convert.ToInt32(nums[i]);
                if (num % 2 == 0)
                {
                    sum = sum + num;
                }
            }

            if (sum > 0)
            {
                result_color.Background = Brushes.Green;
            }
            else if (sum < 0)
            {
                result_color.Background = Brushes.Red;
            }

            result_textbox.Text = Convert.ToString(sum);
        }
    }
}
