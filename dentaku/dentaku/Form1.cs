using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentaku
{
    public partial class Form1 : Form
    {
        string message1 = "";
        string message2 = "";
        string message3 = "";
        int flag = 0;
        float a;
        float b;
        float c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                message1 = message1 + "1";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "1";
                label1.Text = message2;
            }
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "0";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "0";
                label1.Text = message2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "2";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "2";
                label1.Text = message2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "3";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "3";
                label1.Text = message2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "4";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "4";
                label1.Text = message2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "5";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "5";
                label1.Text = message2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "6";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "6";
                label1.Text = message2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "7";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "7";
                label1.Text = message2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "8";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "8";
                label1.Text = message2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + "9";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + "9";
                label1.Text = message2;
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {

            }
            else
            {
                message3 = message3 + message2 + " = ";
                label2.Text = message3;
                b = float.Parse(message2);
                if (flag == 1)
                {
                    c = a + b;
                }else if (flag == 2)
                {
                    c = a - b;
                }else if(flag == 3)
                {
                    c = a * b;
                }
                else
                {
                    c = a / b;
                }
                label1.Text = c.ToString();
                message1 = c.ToString();
                message2 = "";
                flag = 0;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if(flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
               /* b = float.Parse(message2);
                if (flag == 1)
                {
                    c = a + b;
                }
                else if (flag == 2)
                {
                    c = a - b;
                }
                else if (flag == 3)
                {
                    c = a * b;
                }
                else
                {
                    c = a / b;
                }
                label2.Text = c.ToString() + "+";
                label1.Text = "0";
                message1 = c.ToString();
                message2 = "";
                c = a;
                flag = 1; */
            }
            else
            {
                a = float.Parse(message1);
                message3 = message1 + " + ";
                message1 = "";
                label2.Text = message3;
                label1.Text = "0";
                flag = 1;
            }
           
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
               /* b = float.Parse(message2);
                if (flag == 1)
                {
                    c = a + b;
                }
                else if (flag == 2)
                {
                    c = a - b;
                }
                else if (flag == 3)
                {
                    c = a * b;
                }
                else
                {
                    c = a / b;
                }
                label2.Text = c.ToString() + "-";
                label1.Text = "0";
                message1 = c.ToString();
                message2 = "";
                c = a;
                flag = 2;*/
            }
            else
            {
                a = float.Parse(message1);
                message3 = message1 + " - ";
                message1 = "";
                label2.Text = message3;
                label1.Text = "0";
                flag = 2;
            }
        }

        private void times_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
                /*b = float.Parse(message2);
                if (flag == 1)
                {
                    c = a + b;
                }
                else if (flag == 2)
                {
                    c = a - b;
                }
                else if (flag == 3)
                {
                    c = a * b;
                }
                else
                {
                    c = a / b;
                }
                label2.Text = c.ToString() + "×";
                label1.Text = "0";
                message1 = c.ToString();
                message2 = "";
                c = a;
                flag = 3;*/
            }
            else
            {
                a = float.Parse(message1);
                message3 = message1 + " × ";
                message1 = "";
                label2.Text = message3;
                label1.Text = "0";
                flag = 3;
            }
        }

        private void divid_Click(object sender, EventArgs e)
        {
            if (flag == 1 || flag == 2 || flag == 3 || flag == 4)
            {
               /* b = float.Parse(message2);
                if (flag == 1)
                {
                    c = a + b;
                }
                else if (flag == 2)
                {
                    c = a - b;
                }
                else if (flag == 3)
                {
                    c = a * b;
                }
                else
                {
                    c = a / b;
                }
                label2.Text = c.ToString() + "÷";
                label1.Text = "0";
                message1 = c.ToString();
                message2 = "";
                c = a;
                flag = 4;*/
            }
            else
            {
                a = float.Parse(message1);
                message3 = message1 + " ÷ ";
                message1 = "";
                label2.Text = message3;
                label1.Text = "0";
                flag = 4;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            message1 = "";
            message2 = "";
        }

        private void allclear_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            message1 = "";
            message2 = "";
            message3 = "";
            flag = 0;
            a = 0;
            b = 0;
            c = 0;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                message1 = message1 + ".";
                label1.Text = message1;
            }
            else
            {
                message2 = message2 + ".";
                label1.Text = message1 + message2;
            }
        }
    }
}
