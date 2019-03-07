using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QPICalculatior
{
    public partial class MainPage : ContentPage
    {
        int c = 0;
        double total = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        //This Function lets you convert the text to specific numbers
        void OnSelect(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String txt = button.Text;
            switch (txt)
            {
                case "A":
                    total += 4*3;
                    break;
                case "B+":
                    total += 3.5 * 3;
                    break;
                case "B":
                    total += 3 * 3;
                    break;
                case "C+":
                    total += 2.5 * 3;
                    break;
                case "C":
                    total += 2 * 3;
                    break;
                case "D":
                    total += 1 * 3;
                    break;
                case "F/FD":
                    total += 0 * 3;
                    break;
                default:
                    break;
            }
            if (c == 0)
            {
                eqTxt.Text = "(" + txt + ")";
                c++;
            }
            else
            {
                eqTxt.Text += "+(" + txt + ")";
                c++;
            }
        }
        //This Function clears all the pre-stored data and clears the texts
        void onClr(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            eqTxt.Text = null;
            result.Text = null;
            total = 0;
            c = 0;

        }
        //This functions displays the result of your given grade/s
        void onEq(Object sender, EventArgs e)
        {
            result.Text = total.ToString() + "/" + (c * 3).ToString() + " = " + (total / (c * 3)).ToString();
        }
    }
}
