using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 30; //mērogs
            int xc = pictureBox1.Width / 2;   // centra koordinātes
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // punktu "ekrāna" koordinātes
            double x, y;   // punktu "matemātiskās" koordinātes
            double step = 0.005;    // solis
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // asis
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // funkcijas grafika konstruēšanas cikls
            while (x < Math.PI)
            {
                try   // ja funkcija kādā punktā neeksistē 
                {
                    y = 1/Math.Sin(x);   // Funkcijas formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double m = 30; //mērogs
            int xc = pictureBox1.Width / 2;   // centra koordinātes
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // punktu "ekrāna" koordinātes
            double x, y;   // punktu "matemātiskās" koordinātes
            double step = 0.005;    // solis
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // asis
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // funkcijas grafika konstruēšanas cikls
            while (x < Math.PI)
            {
                try   // ja funkcija kādā punktā neeksistē 
                {
                    y = x * x; // Funkcijas formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }
    }
}
