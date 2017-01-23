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
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            //begin to parse every text field.
            double temp;


            //matrix 1
            //row 1
            if(double.TryParse(M1R1C1.Text, out temp))
            {
                Storage.m1row1.Add(temp);
            }
            else
            {
                Storage.m1row1.Add(0);
            }

            if (double.TryParse(M1R1C2.Text, out temp))
            {
                Storage.m1row1.Add(temp);
            }
            else
            {
                Storage.m1row1.Add(0);
            }

            if (double.TryParse(M1R1C3.Text, out temp))
            {
                Storage.m1row1.Add(temp);
            }
            else
            {
                Storage.m1row1.Add(0);
            }


            //row 2
            if (double.TryParse(M1R2C1.Text, out temp))
            {
                Storage.m1row2.Add(temp);
            }
            else
            {
                Storage.m1row2.Add(0);
            }

            if (double.TryParse(M1R2C2.Text, out temp))
            {
                Storage.m1row2.Add(temp);
            }
            else
            {
                Storage.m1row2.Add(0);
            }

            if (double.TryParse(M1R2C3.Text, out temp))
            {
                Storage.m1row2.Add(temp);
            }
            else
            {
                Storage.m1row2.Add(0);
            }

            //row 3

            if (double.TryParse(M1R3C1.Text, out temp))
            {
                Storage.m1row3.Add(temp);
            }
            else
            {
                Storage.m1row3.Add(0);
            }

            if (double.TryParse(M1R3C2.Text, out temp))
            {
                Storage.m1row3.Add(temp);
            }
            else
            {
                Storage.m1row3.Add(0);
            }

            if (double.TryParse(M1R3C3.Text, out temp))
            {
                Storage.m1row3.Add(temp);
            }
            else
            {
                Storage.m1row3.Add(0);
            }

            //matrix 2
            //row1

            if (double.TryParse(M2R1C1.Text, out temp))
            {
                Storage.m2row1.Add(temp);
            }
            else
            {
                Storage.m2row1.Add(0);
            }

            if (double.TryParse(M2R1C2.Text, out temp))
            {
                Storage.m2row1.Add(temp);
            }
            else
            {
                Storage.m2row1.Add(0);
            }

            if (double.TryParse(M2R1C3.Text, out temp))
            {
                Storage.m2row1.Add(temp);
            }
            else
            {
                Storage.m2row1.Add(0);
            }

            //row 2

            if (double.TryParse(M2R2C1.Text, out temp))
            {
                Storage.m2row2.Add(temp);
            }
            else
            {
                Storage.m2row2.Add(0);
            }

            if (double.TryParse(M2R2C2.Text, out temp))
            {
                Storage.m2row2.Add(temp);
            }
            else
            {
                Storage.m2row2.Add(0);
            }

            if (double.TryParse(M2R2C3.Text, out temp))
            {
                Storage.m2row2.Add(temp);
            }
            else
            {
                Storage.m2row2.Add(0);
            }

            //row 3

            if (double.TryParse(M2R3C1.Text, out temp))
            {
                Storage.m2row3.Add(temp);
            }
            else
            {
                Storage.m2row3.Add(0);
            }

            if (double.TryParse(M2R3C2.Text, out temp))
            {
                Storage.m2row3.Add(temp);
            }
            else
            {
                Storage.m2row3.Add(0);
            }

            if (double.TryParse(M2R3C3.Text, out temp))
            {
                Storage.m2row3.Add(temp);
            }
            else
            {
                Storage.m2row3.Add(0);
            }

            //the conversions are finally complete. Now we need to decide what to do with this information.
            //once the decision is made, we will perform the operations, before preparing the final window.
            switch (Storage.operation)
            {
                case "+":
                    Storage.arow1.Add(Storage.m1row1[0] + Storage.m2row1[0]);
                    Storage.arow1.Add(Storage.m1row1[1] + Storage.m2row1[1]);
                    Storage.arow1.Add(Storage.m1row1[2] + Storage.m2row1[2]);

                    Storage.arow2.Add(Storage.m1row2[0] + Storage.m2row2[0]);
                    Storage.arow2.Add(Storage.m1row2[1] + Storage.m2row2[1]);
                    Storage.arow2.Add(Storage.m1row2[2] + Storage.m2row2[2]);

                    Storage.arow3.Add(Storage.m1row3[0] + Storage.m2row3[0]);
                    Storage.arow3.Add(Storage.m1row3[1] + Storage.m2row3[1]);
                    Storage.arow3.Add(Storage.m1row3[2] + Storage.m2row3[2]);

                    showResultForm();
                    break;

                case "-":
                    Storage.arow1.Add(Storage.m1row1[0] - Storage.m2row1[0]);
                    Storage.arow1.Add(Storage.m1row1[1] - Storage.m2row1[1]);
                    Storage.arow1.Add(Storage.m1row1[2] - Storage.m2row1[2]);

                    Storage.arow2.Add(Storage.m1row2[0] - Storage.m2row2[0]);
                    Storage.arow2.Add(Storage.m1row2[1] - Storage.m2row2[1]);
                    Storage.arow2.Add(Storage.m1row2[2] - Storage.m2row2[2]);

                    Storage.arow3.Add(Storage.m1row3[0] - Storage.m2row3[0]);
                    Storage.arow3.Add(Storage.m1row3[1] - Storage.m2row3[1]);
                    Storage.arow3.Add(Storage.m1row3[2] - Storage.m2row3[2]);

                    showResultForm();
                    break;

                case "*":
                    
                    Storage.arow1.Add((Storage.m1row1[0] * Storage.m2row1[0] + Storage.m1row1[1] * Storage.m2row2[0] + Storage.m1row1[2] * Storage.m2row3[0]));
                    Storage.arow1.Add((Storage.m1row1[0] * Storage.m2row1[1] + Storage.m1row1[1] * Storage.m2row2[1] + Storage.m1row1[2] * Storage.m2row3[1]));
                    Storage.arow1.Add((Storage.m1row1[0] * Storage.m2row1[2] + Storage.m1row1[1] * Storage.m2row2[2] + Storage.m1row1[2] * Storage.m2row3[2]));

                    Storage.arow2.Add((Storage.m1row2[0] * Storage.m2row1[0] + Storage.m1row2[1] * Storage.m2row2[0] + Storage.m1row2[2] * Storage.m2row3[0]));
                    Storage.arow2.Add((Storage.m1row2[0] * Storage.m2row1[1] + Storage.m1row2[1] * Storage.m2row2[1] + Storage.m1row2[2] * Storage.m2row3[1]));
                    Storage.arow2.Add((Storage.m1row2[0] * Storage.m2row1[2] + Storage.m1row2[1] * Storage.m2row2[2] + Storage.m1row2[2] * Storage.m2row3[2]));

                    Storage.arow3.Add((Storage.m1row3[0] * Storage.m2row1[0] + Storage.m1row3[1] * Storage.m2row2[0] + Storage.m1row3[2] * Storage.m2row3[0]));
                    Storage.arow3.Add((Storage.m1row3[0] * Storage.m2row1[1] + Storage.m1row3[1] * Storage.m2row2[1] + Storage.m1row3[2] * Storage.m2row3[1]));
                    Storage.arow3.Add((Storage.m1row3[0] * Storage.m2row1[2] + Storage.m1row3[1] * Storage.m2row2[2] + Storage.m1row3[2] * Storage.m2row3[2]));

                    showResultForm();
                    break;

                case "det":
                    Hide();
                    Form resultForm = new DetResultForm();
                    resultForm.ShowDialog();
                    break;

                default:
                    MessageBox.Show("A WTF error has occurred. Better tell the programmer to get his act together.");
                    Application.Exit();
                    break;
            }
        }

        private void showResultForm()
        {
            Hide();
            Form resultForm = new resultForm1();
            resultForm.ShowDialog();
        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {
            M1R1C1.Focus();
            if (Storage.operation == "det")
            {
                M2Box.Visible = false;
            }
        }
    }
}
