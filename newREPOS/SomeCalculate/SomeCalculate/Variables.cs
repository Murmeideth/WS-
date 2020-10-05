using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomeCalculate
{
    public class Variables
    {   
        //Сложение
        public static void Plus(TextBox Pole, double Num1, int Type)
        {
            Type = 1;
            Num1 = Convert.ToDouble(Pole.Text);
            Pole.Text = "";
            Pole.Focus();
        }

        //Вычитание
        public static void Minus(TextBox Pole, double Num1, int Type)
        {
            Type = 2;
            Num1 = Convert.ToDouble(Pole.Text);
            Pole.Text = "";
            Pole.Focus();
        }

        //Умножение
        public static void Multipe(TextBox Pole, double Num1, int Type)
        {
            Type = 3;
            Num1 = Convert.ToDouble(Pole.Text);
            Pole.Text = "";
            Pole.Focus();
        }

        //Деление
        public static void Divide(TextBox Pole, double Num1, int Type)
       {
            if(Pole.Text == "0" || Pole.Text == "")
                Pole.Text = "";
            else{    
            Type = 4;
            Num1 = Convert.ToDouble(Pole.Text);
            Pole.Text = "";
            Pole.Focus();
            }
        }

        //Равно
        public static void Result(TextBox Pole, int Type, double Num1, double Num2, double Num3)
        {
            switch (Type)
            {
            case 1:
            Num2 = Double.Parse(Pole.Text);
            Num3 = Num1 + Num2;
            Pole.Text = Num3.ToString();
            break;

            case 2:
            Num2 = Double.Parse(Pole.Text);
            Num3 = Num1 - Num2;
            Pole.Text = Num3.ToString();
            break;

            case 3:
            Num2 = Double.Parse(Pole.Text);
            Num3 = Num1 *+ Num2;
            Pole.Text = Num3.ToString();
            break;

            case 4:
            Num2 = Double.Parse(Pole.Text);
            Num3 = Num1 / Num2;
            Pole.Text = Num3.ToString();
            break;

            default:
            break;
            }
            
        }

        //Площадь квадрата
        public static void PloKvad(TextBox KvadA, TextBox KvadB,TextBox Pole)
        {
            Pole.Text = Convert.ToString(Convert.ToDouble(KvadA.Text) * Convert.ToDouble(KvadB.Text));
        }

        //Площадь параллелепипеда
        public static void PloParall(TextBox ParallOsnov, TextBox ParallVisot, TextBox Pole)
        {
            Pole.Text = Convert.ToString(Convert.ToDouble(ParallOsnov.Text) * Convert.ToDouble(ParallVisot.Text));
        }

        //Площадь круга
        public static void PloCircle(TextBox Radius, TextBox Pole)
        {
            Pole.Text = Convert.ToString(Math.Pow(Convert.ToDouble(Radius.Text), 2) * 3.14);
        }


    }
}
