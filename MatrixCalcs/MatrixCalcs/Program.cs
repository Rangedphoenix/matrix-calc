using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalcs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Storage.m1row1 = new List<double>();
            Storage.m1row2 = new List<double>();
            Storage.m1row3 = new List<double>();
            Storage.m2row1 = new List<double>();
            Storage.m2row2 = new List<double>();
            Storage.m2row3 = new List<double>();
            Storage.arow1 = new List<double>();
            Storage.arow2 = new List<double>();
            Storage.arow3 = new List<double>();
            Application.Run(new Form1());
        }
    }

    class Storage
    {
        //matrix 1
        static public List<double> m1row1;
        static public List<double> m1row2;
        static public List<double> m1row3;
        
        //matrix 2
        static public List<double> m2row1;
        static public List<double> m2row2;
        static public List<double> m2row3;

        static public List<double> arow1;
        static public List<double> arow2;
        static public List<double> arow3;

        static public string operation;

        //function for returning the determinant
        static public double getDet()
        {
            double cof1, cof2, cof3;

            cof1 = m1row1[0] * (m1row2[1] * m1row3[2] - m1row2[2] * m1row3[1]);
            cof2 = (-1 * m1row2[0]) * (m1row1[1] * m1row3[2] - m1row1[2] * m1row3[1]);
            cof3 = m1row3[0] * (m1row1[1] * m1row2[2] - m1row1[2] * m1row2[1]);

            return cof1 + cof2 + cof3;
        }
        
        /*Implementation of the principle that "The area of a triangle with verticies
        (x1,y1) (x2, y2) (x3, y3) is half of the determinant of the following matrix:
        x1  y1  1
        x2  y2  1
        x3  y3  1
        */
        static public double getArea()
        {
            double value = .5 * getDet();
            if(value > 0)
            {
                return value;
            }
            else
            {
                return -value;
            }

        }
    }
}
