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
    public partial class AreaResultForm : Form
    {
        public AreaResultForm()
        {
            InitializeComponent();
        }

        private void AreaResultForm_Load(object sender, EventArgs e)
        {
            ResultLabel.Text = Storage.getArea().ToString();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
