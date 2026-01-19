using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Cyrus-Beck Line Clipping Algorithm
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //polygon points
        double V1X = 300;
        double V1Y = 0;

        double V2X = 100;
        double V2Y = 200;

        double V3X = 100;
        double V3Y = 400;

        double V4X = 300;
        double V4Y = 600;

        double V5X = 500;
        double V5Y = 400;

        double V6X = 500;
        double V6Y = 200;

        //line points
        double P1X = 50;
        double P1Y = 150;

        double P2X = 600;
        double P2Y = 300;

        //normal vectors
        double V1V2X = 1;
        double V1V2Y = 1;

        double V2V3X = 1;
        double V2V3Y = 0;

        double V3V4X = 1;
        double V3V4Y = -1;

        double V4V5X = -1;
        double V4V5Y = -1;

        double V5V6X = -1;
        double V5V6Y = 0;

        double V6V1X = -1;
        double V6V1Y = 1;

        //.................................................

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);

            Point[] shape =
            {
                new Point ((int)V1X,(int)V1Y),
                new Point ((int)V2X,(int)V2Y),
                new Point ((int)V3X,(int)V3Y),
                new Point ((int)V4X,(int)V4Y),
                new Point ((int)V5X,(int)V5Y),
                new Point ((int)V6X,(int)V6Y)
            };

            g.DrawPolygon(pen1, shape);
            g.DrawLine(pen1, (int)P1X, (int)P1Y, (int)P2X, (int)P2Y);

            //.....................................................

            //list of tL
            List<double> tL = new List<double>();

            //list of tU
            List<double> tU = new List<double>();

            //distance between points
            double DX = P2X - P1X;
            double DY = P2Y - P1Y;

            //edge V1V2
            double V1V2fX = V1X;
            double V1V2fY = V1Y;

            double V1V2nX = V1V2X;
            double V1V2nY = V1V2Y;

            double V1V2wX = P1X - V1V2fX;
            double V1V2wY = P1Y - V1V2fY;

            double V1V2wn = (V1V2wX * V1V2nX) + (V1V2wY * V1V2nY);

            double V1V2Dn = (DX * V1V2nX) + (DY * V1V2nY);

            double V1V2result = -V1V2wn / V1V2Dn;

            if (V1V2Dn > 0)
            {
                tL.Add(V1V2result);
            }
            else
            {
                tU.Add(V1V2result);
            }

            //edge V2V3
            double V2V3fX = V3X;
            double V2V3fY = V3Y;

            double V2V3nX = V2V3X;
            double V2V3nY = V2V3Y;

            double V2V3wX = P1X - V2V3fX;
            double V2V3wY = P1Y - V2V3fY;

            double V2V3wn = (V2V3wX * V2V3nX) + (V2V3wY * V2V3nY);

            double V2V3Dn = (DX * V2V3nX) + (DY * V2V3nY);

            double V2V3result = -V2V3wn / V2V3Dn;

            if (V2V3Dn > 0)
            {
                tL.Add(V2V3result);
            }
            else
            {
                tU.Add(V2V3result);
            }

            //edge V3V4
            double V3V4fX = V4X;
            double V3V4fY = V4Y;

            double V3V4nX = V3V4X;
            double V3V4nY = V3V4Y;

            double V3V4wX = P1X - V3V4fX;
            double V3V4wY = P1Y - V3V4fY;

            double V3V4wn = (V3V4wX * V3V4nX) + (V3V4wY * V3V4nY);

            double V3V4Dn = (DX * V3V4nX) + (DY * V3V4nY);

            double V3V4result = -V3V4wn / V3V4Dn;

            if (V3V4Dn > 0)
            {
                tL.Add(V3V4result);
            }
            else
            {
                tU.Add(V3V4result);
            }

            //edge V4V5
            double V4V5fX = V5X;
            double V4V5fY = V5Y;

            double V4V5nX = V4V5X;
            double V4V5nY = V4V5Y;

            double V4V5wX = P1X - V4V5fX;
            double V4V5wY = P1Y - V4V5fY;

            double V4V5wn = (V4V5wX * V4V5nX) + (V4V5wY * V4V5nY);

            double V4V5Dn = (DX * V4V5nX) + (DY * V4V5nY);

            double V4V5result = -V4V5wn / V4V5Dn;

            if (V4V5Dn > 0)
            {
                tL.Add(V4V5result);
            }
            else
            {
                tU.Add(V4V5result);
            }

            //edge V5V6
            double V5V6fX = V6X;
            double V5V6fY = V6Y;

            double V5V6nX = V5V6X;
            double V5V6nY = V5V6Y;

            double V5V6wX = P1X - V5V6fX;
            double V5V6wY = P1Y - V5V6fY;

            double V5V6wn = (V5V6wX * V5V6nX) + (V5V6wY * V5V6nY);

            double V5V6Dn = (DX * V5V6nX) + (DY * V5V6nY);

            double V5V6result = -V5V6wn / V5V6Dn;

            if (V5V6Dn > 0)
            {
                tL.Add(V5V6result);
            }
            else
            {
                tU.Add(V5V6result);
            }

            //edge V6V1
            double V6V1fX = V1X;
            double V6V1fY = V1Y;

            double V6V1nX = V6V1X;
            double V6V1nY = V6V1Y;

            double V6V1wX = P1X - V6V1fX;
            double V6V1wY = P1Y - V6V1fY;

            double V6V1wn = (V6V1wX * V6V1nX) + (V6V1wY * V6V1nY);

            double V6V1Dn = (DX * V6V1nX) + (DY * V6V1nY);

            double V6V1result = -V6V1wn / V6V1Dn;

            if (V6V1Dn > 0)
            {
                tL.Add(V6V1result);
            }
            else
            {
                tU.Add(V6V1result);
            }


            //intersection points

            //I1
            double P1_P0X = P2X - P1X;
            double P1_P0Y = P2Y - P1Y;

            double P1_P0MaxtLX = P1_P0X * tL.Max();
            double P1_P0MaxtLY = P1_P0Y * tL.Max();

            double I1X = P1X + P1_P0MaxtLX;
            double I1Y = P1Y + P1_P0MaxtLY;

            //tU

            double P1_P0MintUX = P1_P0X * tU.Min();
            double P1_P0MintUY = P1_P0Y * tU.Min();

            double I2X = P1X + P1_P0MintUX;
            double I2Y = P1Y + P1_P0MintUY;

            //clipping line
            g.DrawLine(pen2, (int)I1X, (int)I1Y, (int)I2X, (int)I2Y);
        }
    }
}
