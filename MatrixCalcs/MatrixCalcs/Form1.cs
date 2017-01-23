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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void callMatrixForm()
        {
            Form matrixform = new MatrixForm();
            matrixform.ShowDialog();
        }

        private void AddButton_CheckedChanged(object sender, EventArgs e)
        {
            if(AddButton.Checked)
            {
                StartButton.Enabled = true;
            }
        }

        private void SubButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SubButton.Checked)
            {
                StartButton.Enabled = true;
            }
        }

        private void MultButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MultButton.Checked)
            {
                StartButton.Enabled = true;
            }
        }

        private void AreaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AreaButton.Checked)
            {
                StartButton.Enabled = true;
            }
        }

        private void DetButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DetButton.Checked)
            {
                StartButton.Enabled = true;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if(AddButton.Checked || SubButton.Checked)
            {
                        if (AddButton.Checked) {
                            Storage.operation = "+";
                        }
                        else
                        {
                            Storage.operation = "-";
                        }

                        Hide();
                        callMatrixForm();

            }
            else if (MultButton.Checked)
            {
                        Storage.operation = "*";
                        Hide();
                        callMatrixForm();
            }
            else if(DetButton.Checked)
            {
                        Storage.operation = "det";
                        callMatrixForm();
                        Hide();
                        Close();
            }
            else if (AreaButton.Checked)
            {
                Storage.operation = "area";
                Hide();
                Form areaForm = new AreaGetForm();
                areaForm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Uh oh, an impossible error occurred...");
            }
        }
    }
}
