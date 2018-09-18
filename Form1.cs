using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGE_CALCULATE
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";

            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                comboBox2.Items.Add(i);
            }
            for (int i = 1950; i <= 2050; i++)
            {
                comboBox3.Items.Add(i);
            }
        }
   private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text.Trim())
            {
                case "1":
                    label5.Text = "January";
                    break;
                case "2":
                    label5.Text = "February";
                    break;
                case "3":
                    label5.Text = "Murch";
                    break;
                case "4":
                    label5.Text = "April";
                    break;
                case "5":
                    label5.Text = "May";
                    break;
                case "6":
                    label5.Text = "June";
                    break;
                case "7":
                    label5.Text = "July";
                    break;
                case "8":
                    label5.Text = "August";
                    break;
                case "9":
                    label5.Text = "September";
                    break;
                case "10":
                    label5.Text = "October";
                    break;
                case "11":
                    label5.Text = "November";
                    break;
                default:
                    label5.Text = "december";
                    break;
            }

        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Year >= Convert.ToInt32(comboBox3.Text.Trim()))
            {
                int y = 0, y1, y2, m = 0, m1, m2, d = 0, d1, d2;

                //y1 = DateTime.Now.Year;
                y1 = dateTimePicker1.Value.Year;
                y2 = Convert.ToInt32(comboBox3.Text.Trim());
                //m1 = DateTime.Now.Month;
                m1 = dateTimePicker1.Value.Month;
                m2 = Convert.ToInt32(comboBox2.Text.Trim());
                //d1 = DateTime.Now.Day;
                d1 = dateTimePicker1.Value.Day;
                d2 = Convert.ToInt32(comboBox1.Text.Trim());

                if (d1 < d2)
                {
                    //d1 = d1 + 30;
                    d1 += 30;
                    d = d1 - d2;
                    //m2 = m2 + 1;
                    m2++;
                }
                else
                {
                    d = d1 - d2;
                }

                if (m1 < m2)
                {
                    m1 += 12;
                    m = m1 - m2;
                    y2++;
                }
                else
                {
                    m = m1 - m2;
                }

                y = y1 - y2;

                label11.Text = y.ToString();
                label9.Text = m.ToString();
                label10.Text = d.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dateTimePicker1.Value > DateTime.Now)
            //{
            //    MessageBox.Show("test");
            //}
            MessageBox.Show(Math.Pow(4, 3).ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                switch (comboBox1.Text.Trim())
                {
                    case "1":
                        label12.Text = "Friday";
                        break;
                    case "2":
                        label12.Text = "Saturday";
                        break;
                    case "3":
                        label12.Text = "Sunday";
                        break;
                    case "4":
                        label12.Text = "Monday";
                        break;
                    case "5":
                        label12.Text = "Tuesday";
                        break;
                    case "6":
                        label12.Text = "Wednesday";
                        break;
                    case "7":
                        label12.Text = "Thursday";
                        break;
                }


            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label5.Text = string.Empty;
        }
    }
}



