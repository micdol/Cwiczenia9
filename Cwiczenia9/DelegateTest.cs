using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenia9
{
    public partial class DelegateTest : Form
    {
        private static string[] oneArgOperations = { "sqrt", "factorial" };
        private static string[] twoArgOperations = { "+", "-", "*", "/" };

        public Action<string> resultAction;
        public Func<double, double> oneArgOp;
        public Func<double, double, double> twoArgsOp;

        public delegate void ReturnResult(string text);
        private ReturnResult resultDelegate;

        public DelegateTest()
        {
            InitializeComponent();
            buttonGo.Enabled = checkBoxSave.Checked || checkBoxDialog.Checked;
            radioButtonOneArg_CheckedChanged(null, null);
        }

        private void checkBoxDialog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDialog.Checked)
            {
                resultDelegate += new ReturnResult(Output.ShowDialogBox);
            }
            else
            {
                resultDelegate -= new ReturnResult(Output.ShowDialogBox);
            }
            buttonGo.Enabled = checkBoxSave.Checked || checkBoxDialog.Checked;
        }

        private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSave.Checked)
            {
                resultDelegate += new ReturnResult(Output.SaveToFile);
            }
            else
            {
                resultDelegate -= new ReturnResult(Output.SaveToFile);
            }
            buttonGo.Enabled = checkBoxSave.Checked || checkBoxDialog.Checked;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            // RestOfTheProgram.ShowResult(resultDelegate, "Result: 0");
            if(radioButtonOneArg.Checked)
            {
                try
                {
                    RestOfTheProgram.ShowResult(resultDelegate, oneArgOp, Double.Parse(textBoxLeft.Text));
                }
                catch (Exception ex)
                {
                    RestOfTheProgram.ShowResult(resultDelegate, "ERRORRRRR: wrong input");
                }
            }
            else
            {
                try
                {
                    RestOfTheProgram.ShowResult(resultDelegate, twoArgsOp, Double.Parse(textBoxLeft.Text), Double.Parse(textBoxRight.Text));
                }
                catch (Exception ex)
                {
                    RestOfTheProgram.ShowResult(resultDelegate, "ERRORRRRR: wrong input");
                }
            }

        }

        private void radioButtonOneArg_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOperation.Items.Clear();
            comboBoxOperation.SelectedIndex = -1;
            foreach (string i in oneArgOperations) comboBoxOperation.Items.Add(i);
            textBoxRight.Hide();
        }

        private void radioButtonTwoArgs_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOperation.Items.Clear();
            comboBoxOperation.SelectedIndex = -1;
            foreach (string i in twoArgOperations) comboBoxOperation.Items.Add(i);
            textBoxRight.Show();
        }

        private void comboBoxOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButtonOneArg.Checked)
            {
                twoArgsOp = null;
                if (comboBoxOperation.Text == "sqrt")
                {
                    oneArgOp = x => Math.Sqrt(x);
                }
                else // "factorial"
                {
                    oneArgOp = x => { double r = 1; while (x > 1) r *= x--; return r; };
                }
            }

            else if (radioButtonTwoArgs.Checked)
            {
                oneArgOp = null;
                string o = comboBoxOperation.Text;
                twoArgsOp = (x, y) => { return o == "+" ? x + y : o == "-" ? x - y : o == "*" ? x * y : x / y; };
            }
        }
    }
}
