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
namespace FURNACE_SIMULATION_REALLLLLLL
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void create_dir()
        {
            var curDir = Directory.GetCurrentDirectory();
            string dir = curDir + "/Settings";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string text1 = curDir + "/Settings/oxygen.owl";
            string text2 = curDir + "/Settings/air.owl";
            string text3 = curDir + "/Settings/enrichment.owl";


            if (!File.Exists(text1))
            {
                using (StreamWriter sw = new StreamWriter(text1, true))
                {
                    sw.WriteLine("");

                }


            }
            if (!File.Exists(text2))
            {
                using (StreamWriter sw = new StreamWriter(text2, true))
                {
                    sw.WriteLine("");

                }


            }
            if (!File.Exists(text3))
            {
                using (StreamWriter sw = new StreamWriter(text3, true))
                {
                    sw.WriteLine("");
                }


            }
        }

        private void settings_Load(object sender, EventArgs e)
        {
            create_dir();
            read_data();
        }

        private void save_result()
        {
            var curDir = Directory.GetCurrentDirectory();

            string oxygen = bunifuTextBox1.Text;
            string udara = bunifuTextBox2.Text;
            string enrichment = bunifuTextBox3.Text + "%";
            string temperature_target = bunifuTextBox4.Text;

            string text1 = curDir + "/Settings/oxygen.owl";
            string text2 = curDir + "/Settings/air.owl";
            string text3 = curDir + "/Settings/enrichment.owl";
            string text4 = curDir + "/Settings/target_temp.owl";

            using (StreamWriter sw = new StreamWriter(text1))
            {
                sw.WriteLine(oxygen);
            }
            using (StreamWriter sw = new StreamWriter(text2))
            {
                sw.WriteLine(udara);
            }
            using (StreamWriter sw = new StreamWriter(text3))
            {
                sw.WriteLine(enrichment);
            }
            using (StreamWriter sw = new StreamWriter(text4))
            {
                sw.WriteLine(temperature_target);
            }


        }

        private void read_data()
        {
            var curDir = Directory.GetCurrentDirectory();
            string dir = curDir + "/Settings";
            // If directory does not exist, create it
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string text1 = curDir + "/Settings/oxygen.owl";
            string text2 = curDir + "/Settings/air.owl";
            string text3 = curDir + "/Settings/enrichment.owl";
            string text4 = curDir + "/Settings/target_temp.owl";

            var oxygen = File.ReadLines(text1).First();
            var udara = File.ReadLines(text2).First();
            var enrichment = File.ReadLines(text3).First();
            var target_temp = File.ReadLines(text4).First();

            label4.Text = oxygen;
            label5.Text = udara;
            label6.Text = enrichment;
            label8.Text = target_temp;
            bunifuTextBox1.Text = oxygen;
            bunifuTextBox2.Text = udara;

            string en = enrichment.Replace("%", "");
            bunifuTextBox3.Text = en;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            save_result();
            read_data();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            read_data();
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
