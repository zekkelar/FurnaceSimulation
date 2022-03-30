using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace FURNACE_SIMULATION_REALLLLLLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;


        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Thread t = new Thread(() => formkecil(new home()));
                t.Start();
            });
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Thread t = new Thread(() => formkecil(new home()));
                t.Start();
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;

            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Thread t = new Thread(() => formkecil(new doi()));
                t.Start();
            });
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;

            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Thread t = new Thread(() => formkecil(new settings()));
                t.Start();
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                Thread t = new Thread(() => formkecil(new about()));
                t.Start();
            });
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private Form activeForm = null;

        private void formkecil(Form childForm)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;

            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.BeginInvoke((Action)(() =>
            {
                panel8.Controls.Add(childForm);
                panel8.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }));
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
