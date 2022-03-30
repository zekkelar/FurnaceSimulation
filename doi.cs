using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FURNACE_SIMULATION_REALLLLLLL
{
    public partial class doi : Form
    {
        public doi()
        {
            InitializeComponent();
            create_file();
            read_data();
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
            if (label13.Text.Contains("1%") || label13.Text.Contains("2%") ||
               (label13.Text.Contains("3%") || label13.Text.Contains("4%")))
            {
                
                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = false;
                    //pictureBox1.Visible = false;

                }
            }
            if (label13.Text.Contains("5%") || label13.Text.Contains("6%") ||
               (label13.Text.Contains("7%") || label13.Text.Contains("8%")))
            {
                
                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    //pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                }
            }

            if (label13.Text.Contains("9%") || label13.Text.Contains("10%") ||
               (label13.Text.Contains("11%") || label13.Text.Contains("12%")))
            {
                
                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("13%") || label13.Text.Contains("14%") ||
               (label13.Text.Contains("15%") || label13.Text.Contains("16%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
           
            }

            if (label13.Text.Contains("17%") || label13.Text.Contains("19%") ||
               (label13.Text.Contains("19%") || label13.Text.Contains("20%")))
            {
                
                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

            }

            if (label13.Text.Contains("21%") || label13.Text.Contains("22%") ||
              (label13.Text.Contains("23%") || label13.Text.Contains("24%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("25%") || label13.Text.Contains("26%") ||
              (label13.Text.Contains("27%") || label13.Text.Contains("28%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("29%") || label13.Text.Contains("30%") ||
              (label13.Text.Contains("31%") || label13.Text.Contains("32%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("33%") || label13.Text.Contains("34%") ||
              (label13.Text.Contains("35%") || label13.Text.Contains("36%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }
            if (label13.Text.Contains("37%") || label13.Text.Contains("38%") ||
              (label13.Text.Contains("39%") || label13.Text.Contains("40%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("41%") || label13.Text.Contains("42%") ||
              (label13.Text.Contains("43%") || label13.Text.Contains("44%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("45%") || label13.Text.Contains("46%") ||
              (label13.Text.Contains("47%") || label13.Text.Contains("48%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("49%") || label13.Text.Contains("50%") ||
              (label13.Text.Contains("51%") || label13.Text.Contains("52%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("53%") || label13.Text.Contains("54%") ||
              (label13.Text.Contains("55%") || label13.Text.Contains("56%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("57%") || label13.Text.Contains("58%") ||
              (label13.Text.Contains("59%") || label13.Text.Contains("60%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("61%") || label13.Text.Contains("62%") ||
              (label13.Text.Contains("63%") || label13.Text.Contains("64%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("65%") || label13.Text.Contains("66%") ||
              (label13.Text.Contains("67%") || label13.Text.Contains("68%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
             
            }

            if (label13.Text == ("69%") || label13.Text == ("70%") ||
              (label13.Text == ("71%") || label13.Text == ("72%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("73%") || label13.Text.Contains("74%") ||
              (label13.Text.Contains("75%") || label13.Text.Contains("76%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("77%") || label13.Text.Contains("78%") ||
              (label13.Text.Contains("79%") || label13.Text.Contains("80%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("81%") || label13.Text.Contains("82%") ||
              (label13.Text.Contains("83%") || label13.Text.Contains("84%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox21.Visible == true)
                {
                    pictureBox22.Visible = true;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("85%") || label13.Text.Contains("86%") ||
              (label13.Text.Contains("87") || label13.Text.Contains("88%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox21.Visible == true)
                {
                    pictureBox22.Visible = true;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox22.Visible == true)
                {
                    pictureBox23.Visible = true;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("89%") || label13.Text.Contains("90%") ||
              (label13.Text.Contains("91") || label13.Text.Contains("92%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox21.Visible == true)
                {
                    pictureBox22.Visible = true;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox22.Visible == true)
                {
                    pictureBox23.Visible = true;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox23.Visible == true)
                {
                    pictureBox24.Visible = true;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("93%") || label13.Text.Contains("94%") ||
              (label13.Text.Contains("95") || label13.Text.Contains("96%")))
            {
                

                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox21.Visible == true)
                {
                    pictureBox22.Visible = true;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox22.Visible == true)
                {
                    pictureBox23.Visible = true;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox23.Visible == true)
                {
                    pictureBox24.Visible = true;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox24.Visible == true)
                {
                    pictureBox25.Visible = true;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }

            if (label13.Text.Contains("97%") || label13.Text.Contains("98%") ||
              (label13.Text.Contains("99") || label13.Text.Contains("100%")))
            {
                if (pictureBox1.Visible == true)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox2.Visible == true)
                {
                    pictureBox3.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox3.Visible == true)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox4.Visible == true)
                {
                    pictureBox5.Visible = true;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox5.Visible == true)
                {
                    pictureBox6.Visible = true;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox6.Visible == true)
                {
                    pictureBox7.Visible = true;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox7.Visible == true)
                {
                    pictureBox8.Visible = true;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox8.Visible == true)
                {
                    pictureBox9.Visible = true;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox9.Visible == true)
                {
                    pictureBox10.Visible = true;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox10.Visible == true)
                {
                    pictureBox11.Visible = true;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox11.Visible == true)
                {
                    pictureBox12.Visible = true;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox12.Visible == true)
                {
                    pictureBox13.Visible = true;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox13.Visible == true)
                {
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox14.Visible == true)
                {
                    pictureBox15.Visible = true;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox15.Visible == true)
                {
                    pictureBox16.Visible = true;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox16.Visible == true)
                {
                    pictureBox17.Visible = true;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox17.Visible == true)
                {
                    pictureBox18.Visible = true;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox18.Visible == true)
                {
                    pictureBox19.Visible = true;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox19.Visible == true)
                {
                    pictureBox20.Visible = true;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox20.Visible == true)
                {
                    pictureBox21.Visible = true;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox21.Visible == true)
                {
                    pictureBox22.Visible = true;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox22.Visible == true)
                {
                    pictureBox23.Visible = true;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox23.Visible == true)
                {
                    pictureBox24.Visible = true;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox24.Visible == true)
                {
                    pictureBox25.Visible = true;
                    pictureBox24.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox25.Visible == true)
                {
                    pictureBox26.Visible = true;
                    pictureBox25.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }

                else if (pictureBox26.Visible == true)
                {
                    pictureBox27.Visible = true;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox27.Visible == true)
                {
                    pictureBox28.Visible = true;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox28.Visible == true)
                {
                    pictureBox29.Visible = true;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox29.Visible == true)
                {
                    pictureBox30.Visible = true;
                    pictureBox29.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox30.Visible == true)
                {
                    pictureBox31.Visible = true;
                    pictureBox30.Visible = false;
                    pictureBox29.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox31.Visible == true)
                {
                    pictureBox32.Visible = true;
                    pictureBox31.Visible = false;
                    pictureBox30.Visible = false;
                    pictureBox29.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
                else if (pictureBox32.Visible == true)
                {
                    pictureBox33.Visible = true;
                    pictureBox32.Visible = false;
                    pictureBox31.Visible = false;
                    pictureBox30.Visible = false;
                    pictureBox29.Visible = false;
                    pictureBox28.Visible = false;
                    pictureBox27.Visible = false;
                    pictureBox26.Visible = false;
                    pictureBox23.Visible = false;
                    pictureBox22.Visible = false;
                    pictureBox21.Visible = false;
                    pictureBox20.Visible = false;
                    pictureBox19.Visible = false;
                    pictureBox18.Visible = false;
                    pictureBox17.Visible = false;
                    pictureBox16.Visible = false;
                    pictureBox15.Visible = false;
                    pictureBox14.Visible = false;
                    pictureBox13.Visible = false;
                    pictureBox12.Visible = false;
                    pictureBox11.Visible = false;
                    pictureBox10.Visible = false;
                    pictureBox9.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox1.Visible = false;

                }
            }
        }

        private void penurunan_guys()
        {
            pictureBox1.Visible = true;
            
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;
            pictureBox31.Visible = false;
            pictureBox32.Visible = false;
            pictureBox33.Visible = false;
            
        }
        private void create_file()
        {
            var curDir = Directory.GetCurrentDirectory();

            string text1 = curDir + "/Settings/oxygen_used.owl";
            string text2 = curDir + "/Settings/udara_used.owl";
            string text3 = curDir + "/Settings/temperature_used.owl";
            string text4 = curDir + "/Settings/enrichment_used.owl";


            if (!File.Exists(text1))
            {
                using (StreamWriter sw = new StreamWriter(text1))
                {
                    sw.WriteLine("");

                }


            }

            if (!File.Exists(text2))
            {
                using (StreamWriter sw = new StreamWriter(text2))
                {
                    sw.WriteLine("");

                }


            }

            if (!File.Exists(text3))
            {
                using (StreamWriter sw = new StreamWriter(text3))
                {
                    sw.WriteLine("");

                }


            }
            if (!File.Exists(text4))
            {
                using (StreamWriter sw = new StreamWriter(text4))
                {
                    sw.WriteLine("");

                }


            }
        }

        int oxygen_f;
        int udara_f;
        private void input_data()
        {
            var curDir = Directory.GetCurrentDirectory();

            string text4 = curDir + "/Settings/oxygen.owl";
            string text5 = curDir + "/Settings/air.owl";

            string text1 = curDir + "/Settings/oxygen_used.owl";
            string text2 = curDir + "/Settings/udara_used.owl";


            string get_max_oxygen_info = (File.ReadLines(text4).FirstOrDefault());
            string get_max_udara_info = (File.ReadLines(text5).FirstOrDefault());

            string get_oxygen_used = File.ReadLines(text1).FirstOrDefault();
            string get_udara_used = File.ReadLines(text2).FirstOrDefault();

            if (get_max_oxygen_info == null)
            {
                MessageBox.Show("Please settings max oxygen first");
            }
            else
            {
                if (get_oxygen_used == null)
                {
                    using (StreamWriter sw = new StreamWriter(text1))
                    {
                        sw.WriteLine(textBox1.Text);

                    }
                    label11.Text = textBox1.Text;
                    oxygen_f = int.Parse(textBox1.Text);
                }
                else
                {
                    int calculate = int.Parse(get_oxygen_used) + int.Parse(textBox1.Text);
                    if(calculate > int.Parse(get_max_oxygen_info))
                    {
                        MessageBox.Show("AIR IS OVER !, TOTAL : " + calculate.ToString());
                    }
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(text1))
                        {
                            sw.WriteLine(calculate);

                        }
                        label11.Text = calculate.ToString();
                        oxygen_f = calculate;
                    }
                }
            }


            if(get_max_udara_info == null)
            {
                MessageBox.Show("Please settings max air first");
            }
            else
            {

                if (get_udara_used == null)
                {
                    using (StreamWriter sw = new StreamWriter(text2))
                    {
                        sw.WriteLine(textBox2.Text);

                    }
                    label10.Text = textBox2.Text;

                    udara_f = int.Parse(textBox2.Text);

                }

                else
                {
                    int get_current_number_airUsed = int.Parse(get_udara_used);
                    int get_input_user_air = int.Parse(textBox2.Text);
                    int calculate_total_used = get_current_number_airUsed + get_input_user_air;
                    if(calculate_total_used > int.Parse(get_max_udara_info))
                    {
                        MessageBox.Show("AIR IS OVER !, TOTAL : " + calculate_total_used.ToString());
                    }
               
                    else
                    {
                        using (StreamWriter sw = new StreamWriter(text2))
                        {
                            sw.WriteLine(calculate_total_used);

                        }
                        label10.Text = calculate_total_used.ToString();
                        udara_f = calculate_total_used;

                    }

                }

            }

            read_all();
        }

        private void read_all()
        {
            var curDir = Directory.GetCurrentDirectory();
            string text1 = curDir + "/Settings/oxygen_used.owl";
            string text2 = curDir + "/Settings/udara_used.owl";
            string get_oxygen_used = File.ReadLines(text1).FirstOrDefault();
            string get_udara_used = File.ReadLines(text2).FirstOrDefault();

            calculate_enrichment(int.Parse(get_oxygen_used), int.Parse(get_udara_used));

        }
        private void read_data()
        {
            var curDir = Directory.GetCurrentDirectory();
            string text1 = curDir + "/Settings/oxygen_used.owl";
            string text2 = curDir + "/Settings/udara_used.owl";
            string text3 = curDir + "/Settings/temperature_used.owl";
            string ngawur = curDir + "/Settings/enrichment_used.owl";

            string text4 = curDir + "/Settings/oxygen.owl";
            string text5 = curDir + "/Settings/air.owl";
            string text6 = curDir + "/Settings/enrichment.owl";

            string text7 = curDir + "/Settings/target_temp.owl";

            try
            {
                var target_temp = File.ReadLines(text7).First();
                label17.Text = target_temp;

            }
            catch
            {
                label17.Text = "NULL";

            }
            try
            {
                var oxygen_used = File.ReadLines(text1).First();
                label11.Text = oxygen_used;

            }
            catch
            {
                label11.Text = "NULL";

            }
            try
            {
                var udara_used = File.ReadLines(text2).First();
                label10.Text = udara_used;

            }
            catch
            {
                label10.Text = "NULL";

            }
            try
            {
                var temperature_used = File.ReadLines(text3).First();
                label14.Text = temperature_used;

            }
            catch
            {
                label14.Text = "NULL";

            }
            try
            {
                var enrichment_used = File.ReadLines(ngawur).First();
                label13.Text = enrichment_used;

            }
            catch
            {
                label13.Text = "NULL";

            }
            try
            {
                var oxygen = File.ReadLines(text4).First();
                label9.Text = oxygen;


            }
            catch
            {
                label9.Text = "0";

            }
            try
            {
                var udara = File.ReadLines(text5).First();
                label8.Text = udara;
            }
            catch
            {
                label8.Text = "0";

            }
            try
            {
                var enrichment = File.ReadLines(text6).First();
                label12.Text = enrichment;

            }
            catch
            {
                label12.Text = "0%";

            }



            

     
        }
        private void calculate_enrichment(int oxygen, int udara)
        {
            int oksil = int.Parse(textBox1.Text);
            int udarl = int.Parse(textBox2.Text);
            float calculate_enrichment_atas =  udarl * 21 / 100;
            float total_enrich_atas = oksil + calculate_enrichment_atas;

            float calculate_enrichment_bawah = oksil + udarl;
            float total_enrichment = total_enrich_atas / calculate_enrichment_bawah;
            int total_final = (int)(total_enrichment * 100);
            label13.Text = total_final.ToString() + "%";
            calculate_temperature(total_final);

        }

        private void calculate_temperature(int enrichment_now)
        {
            var curDir = Directory.GetCurrentDirectory();

            string target_temp = File.ReadLines(curDir + "/Settings/target_temp.owl").FirstOrDefault();
            string max_enrichment = File.ReadLines(curDir + "/Settings/enrichment.owl").FirstOrDefault();

            string remove_percent = max_enrichment.Replace("%", "");
            int calculate_one = int.Parse(target_temp) * 100;
            int calculate_two = calculate_one / int.Parse(remove_percent); //MAXIMAL TEMPERATURE
            int calculate_three = calculate_two * enrichment_now/100;
            //MessageBox.Show(calculate_two.ToString());
            label14.Text = calculate_three.ToString();    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            if(textBox2.Text == "")
            {
                textBox2.Text = "0";
            }
            if(textBox1.Text.Contains("INPUT OXYGEN"))
            {
                MessageBox.Show("Please input OXYGEN MINIMUM IS ZERO");
            }
            if (textBox2.Text.Contains("INPUT UDARA"))
            {
                MessageBox.Show("Please input UDARA MINIMUM IS ZERO");
            }
            else
            {
                input_data();
                string remove_percent_one = label13.Text.Replace("%", "");
                string remove_percent_two = label12.Text.Replace("%", "");
                //MessageBox.Show(remove_percent_one);
                //MessageBox.Show(remove_percent_two);


                //label15.Text = "STABLE";
                //

                //Thread.Sleep(5000);
                //penurunan_guys();
                //penurunan_guys();
                // timer1.Enabled = true;
                if (int.Parse(remove_percent_one) > int.Parse(remove_percent_two))
                {
                    label15.Text = "FULL";
                    timer2.Enabled = true;

                }
                else
                {
                    timer2.Enabled = false;
                    label15.Text = "STABLE";
                    penurunan_guys();
                    timer1.Enabled = true;
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UDARA TERPAKAI
            //OXYGEN TERPAKAI
            //TEMPERATURE SEKARANG
            var curDir = Directory.GetCurrentDirectory();
            string dir_oxygen = curDir + "/Settings/oxygen_used.owl";
            string dir_air = curDir + "/Settings/udara_used.owl";
            string dir_temperature = curDir + "/Settings/temperature_used.owl";


            using (StreamWriter sw = new StreamWriter(dir_oxygen))
            {
                sw.WriteLine("0");
            }
            using (StreamWriter sw = new StreamWriter(dir_air))
            {
                sw.WriteLine("0");
            }
            using (StreamWriter sw = new StreamWriter(dir_temperature))
            {
                sw.WriteLine("0");
            }

            string oxygen_used = File.ReadLines(dir_oxygen).First();
            string air_used = File.ReadLines(dir_air).First();
            string temperature_used = File.ReadLines(dir_temperature).First();

            label11.Text = oxygen_used;
            label10.Text = air_used;
            label14.Text = temperature_used;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox1.Visible == true)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;

            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox3.Visible = true;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox4.Visible = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox7.Visible = true;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox7.Visible == true)
            {
                pictureBox8.Visible = true;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox8.Visible == true)
            {
                pictureBox9.Visible = true;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox9.Visible == true)
            {
                pictureBox10.Visible = true;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox10.Visible == true)
            {
                pictureBox11.Visible = true;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox11.Visible == true)
            {
                pictureBox12.Visible = true;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox12.Visible == true)
            {
                pictureBox13.Visible = true;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox13.Visible == true)
            {
                pictureBox14.Visible = true;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox14.Visible == true)
            {
                pictureBox15.Visible = true;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox15.Visible == true)
            {
                pictureBox16.Visible = true;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox16.Visible == true)
            {
                pictureBox17.Visible = true;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox17.Visible == true)
            {
                pictureBox18.Visible = true;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox18.Visible == true)
            {
                pictureBox19.Visible = true;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox19.Visible == true)
            {
                pictureBox20.Visible = true;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox20.Visible == true)
            {
                pictureBox21.Visible = true;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox21.Visible == true)
            {
                pictureBox22.Visible = true;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox22.Visible == true)
            {
                pictureBox23.Visible = true;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox23.Visible == true)
            {
                pictureBox24.Visible = true;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox24.Visible == true)
            {
                pictureBox25.Visible = true;
                pictureBox24.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox25.Visible == true)
            {
                pictureBox26.Visible = true;
                pictureBox25.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            else if (pictureBox26.Visible == true)
            {
                pictureBox27.Visible = true;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox27.Visible == true)
            {
                pictureBox28.Visible = true;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox28.Visible == true)
            {
                pictureBox29.Visible = true;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox29.Visible == true)
            {
                pictureBox30.Visible = true;
                pictureBox29.Visible = false;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox30.Visible == true)
            {
                pictureBox31.Visible = true;
                pictureBox30.Visible = false;
                pictureBox29.Visible = false;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox31.Visible == true)
            {
                pictureBox32.Visible = true;

                pictureBox31.Visible = false;
                pictureBox30.Visible = false;
                pictureBox29.Visible = false;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }
            else if (pictureBox32.Visible == true)
            {
                pictureBox33.Visible = true;
                pictureBox32.Visible = false;
                pictureBox31.Visible = false;
                pictureBox30.Visible = false;
                pictureBox29.Visible = false;
                pictureBox28.Visible = false;
                pictureBox27.Visible = false;
                pictureBox26.Visible = false;
                pictureBox23.Visible = false;
                pictureBox22.Visible = false;
                pictureBox21.Visible = false;
                pictureBox20.Visible = false;
                pictureBox19.Visible = false;
                pictureBox18.Visible = false;
                pictureBox17.Visible = false;
                pictureBox16.Visible = false;
                pictureBox15.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                pictureBox12.Visible = false;
                pictureBox11.Visible = false;
                pictureBox10.Visible = false;
                pictureBox9.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;

            }

            
        }
    }
}
