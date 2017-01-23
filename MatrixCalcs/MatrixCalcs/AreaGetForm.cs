using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalcs
{
    public partial class AreaGetForm : Form
    {
        public AreaGetForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double temp = 0;

            if(double.TryParse(r1c1.Text, out temp))
            {
                Storage.m1row1.Add(temp);
            }
            else
            {
                Storage.m1row1.Add(0);
            }

            if (double.TryParse(r1c2.Text, out temp))
            {
                Storage.m1row1.Add(temp);
            }
            else
            {
                Storage.m1row1.Add(0);
            }

            //row 2
            if (double.TryParse(r2c1.Text, out temp))
            {
                Storage.m1row2.Add(temp);
            }
            else
            {
                Storage.m1row2.Add(0);
            }

            if (double.TryParse(r2c2.Text, out temp))
            {
                Storage.m1row2.Add(temp);
            }
            else
            {
                Storage.m1row2.Add(0);
            }

            //row 3

            if (double.TryParse(r3c1.Text, out temp))
            {
                Storage.m1row3.Add(temp);
            }
            else
            {
                Storage.m1row3.Add(0);
            }

            if (double.TryParse(r3c2.Text, out temp))
            {
                Storage.m1row3.Add(temp);
            }
            else
            {
                Storage.m1row3.Add(0);
            }

            //the third column is filled in with ones

            Storage.m1row1.Add(1);
            Storage.m1row2.Add(1);
            Storage.m1row3.Add(1);

            //finally, we call the result form
            Hide();
            Form areaResForm = new AreaResultForm();
            areaResForm.ShowDialog();
        }
    }
}
