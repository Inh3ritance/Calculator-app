using System;
using System.Data;
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

namespace Calculator_App {
    public partial class MainWindow : Window {

        private string parser = "";
        private Object res = 0;
        bool clr = true;

        public MainWindow() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 1;
            textHandler();
        }

        private void Button2_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 2;
            textHandler();
        }

        private void Button3_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 3;
            textHandler();
        }

        private void Button4_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 4;
            textHandler();
        }

        private void Button5_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 5;
            textHandler();
        }

        private void Button6_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 6;
            textHandler();
        }

        private void Button7_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 7;
            textHandler();
        }

        private void Button8_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 8;
            textHandler();
        }

        private void Button9_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 9;
            textHandler();
        }

        private void Button0_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            parser += 0;
            textHandler();
        }

        private void ButtonNeg_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Length <= 0) {
                return;
            } else if (parser.Substring(0, 1).Equals("-")) {
                parser = parser.Substring(1);
            } else {
                parser = "-" + parser;
            }
            textHandler();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Equals("") || parser.Substring(parser.Length - 1).Equals("+")) {
                return;
            } else if (parser.Substring(parser.Length - 1).Equals("-")  || parser.Substring(parser.Length - 1).Equals("/") || parser.Substring(parser.Length - 1).Equals("*")) {
                parser = parser.Substring(0,parser.Length - 1) + "+";
            } else{
                parser += "+";
            }
            textHandler();
        }

        private void ButtonSub_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Equals("") || parser.Substring(parser.Length - 1).Equals("-")){
                return;
            } else if (parser.Substring(parser.Length - 1).Equals("+") || parser.Substring(parser.Length - 1).Equals("*") || parser.Substring(parser.Length - 1).Equals("/")) {
                parser = parser.Substring(0,parser.Length - 1) + "-";
            } else {
                parser += "-";
            }
            textHandler();
        }

        private void ButtonDiv_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Equals("") || parser.Substring(parser.Length - 1).Equals("/")){
                return;
            } else if (parser.Substring(parser.Length - 1).Equals("+") || parser.Substring(parser.Length - 1).Equals("*") || parser.Substring(parser.Length - 1).Equals("-")) {
                parser = parser.Substring(0,parser.Length - 1) + "/";
            } else {
                parser += "/";
            }
            textHandler();
        }

        private void ButtonMult_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Equals("") || parser.Substring(parser.Length - 1).Equals("*")){
                return;
            } else if (parser.Substring(parser.Length - 1).Equals("+") || parser.Substring(parser.Length - 1).Equals("/") || parser.Substring(parser.Length - 1).Equals("-")) {
                parser = parser.Substring(0,parser.Length - 1) + "*";
            } else {
                parser += "*";
            }
            textHandler();
        }

        private void ButtonDec_Click(object sender, RoutedEventArgs e){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (parser.Length == 0 || parser.Substring(parser.Length-1).Equals(".") || containsDec(parser.Substring(0,parser.Length-1))){
                return;
            } else if (parser.Substring(parser.Length - 1).Equals("+") || parser.Substring(parser.Length - 1).Equals("*") || parser.Substring(parser.Length - 1).Equals("/") || parser.Substring(parser.Length - 1).Equals("-")) {
                parser = parser.Substring(0,parser.Length - 1) + ".";
            } else {
                parser += ".";
            }
            textHandler();
        }

        private bool containsDec(String str){
            if (!clr){
                parser = "";
                clr = true;
            }
            if (str.Length < 1) {
                return false;
            } else if(str.Substring(str.Length - 1).Equals("+") || str.Substring(str.Length - 1).Equals("*") || str.Substring(str.Length - 1).Equals("/") || str.Substring(str.Length - 1).Equals("-")) {
                return false;
            } else if (str.Substring(str.Length - 1).Equals(".")) {
                return true;
            } else {
                return containsDec(str.Substring(0,str.Length-1));
            }
        }

        private void ButtonClr_Click(object sender, RoutedEventArgs e){
            parser = "";
            textHandler();
        }

        private void ButtonEq_Click(object sender, RoutedEventArgs e){
            Console.WriteLine(parser);
            res = parserSolution(parser);
            parser = res.ToString();
            textHandler();
        }

        /*private float parserSolution(string str, string temp){
            Console.WriteLine("str: " + str);
            Console.WriteLine("sub: " + temp);
            if (str.Length <= 0){
                if(temp.Equals(""))return 0;
                return float.Parse(temp);
            } else if (str.Substring(str.Length-1).Equals("+")) {
                return parserSolution(str.Substring(0,str.Length - 1),"") + float.Parse(temp);
            } else if (str.Substring(str.Length - 1).Equals("-")) {
                return parserSolution(str.Substring(0,str.Length - 1), "") - float.Parse(temp);
            } else if (str.Substring(str.Length - 1).Equals("*")) {
                return parserSolution(str.Substring(0,str.Length - 1) , "") * float.Parse(temp);
            } else if (str.Substring(str.Length - 1).Equals("/")) {
                return parserSolution(str.Substring(0,str.Length - 1), "") / float.Parse(temp);
            } else {
                temp = str.Substring(str.Length-1) + temp;
                return parserSolution(str.Substring(0,str.Length-1),temp);
            }
        }*/

        private Object parserSolution(string str){
            try {
                return new DataTable().Compute(str, null);
            } catch (Exception e) { // Display error over exception
                clr = false;
                Console.WriteLine("Exception Error: " + e.ToString());
                return "Error";
            }
        }

        private void textHandler() {
            this.label.Content = parser;
        }
    }

}
