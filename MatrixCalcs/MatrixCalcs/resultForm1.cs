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
    public partial class resultForm1 : Form
    {
        public resultForm1()
        {
            InitializeComponent();
        }

        private void resultForm1_Load(object sender, EventArgs e)
        {
            r1c1.Text = Storage.arow1[0].ToString();
            r1c2.Text = Storage.arow1[1].ToString();
            r1c3.Text = Storage.arow1[2].ToString();

            r2c1.Text = Storage.arow2[0].ToString();
            r2c2.Text = Storage.arow2[1].ToString();
            r2c3.Text = Storage.arow2[2].ToString();

            r3c1.Text = Storage.arow3[0].ToString();
            r3c2.Text = Storage.arow3[1].ToString();
            r3c3.Text = Storage.arow3[2].ToString();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
