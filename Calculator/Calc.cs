using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        private enum OPERATION { SUM, SUB, MULTI, DIV, NONE }
        private string _operatingFirst, _operatingSecond;
        private OPERATION _operation;

        public Calc()
        {
            InitializeComponent();
            _operatingFirst = _operatingSecond = "0";
            _operation = OPERATION.NONE;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            ButtonNumberClicked(0);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            ButtonOperationClicked(OPERATION.SUM);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            ButtonOperationClicked(OPERATION.SUB);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            ButtonOperationClicked(OPERATION.MULTI);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            ButtonOperationClicked(OPERATION.DIV);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = DoTheMath(_operation);
        }

        private void ButtonNumberClicked(int value)
        {
            if (_operation == OPERATION.NONE)
            {
                textBoxResult.Text = _operatingFirst = (_operatingFirst == "0" ? value.ToString() : _operatingFirst + value);
            }
            else
            {
                textBoxResult.Text = _operatingSecond = (_operatingSecond == "0" ? value.ToString() : _operatingSecond + value);
            }
        }

        private void ButtonOperationClicked(OPERATION operation)
        {
            if (_operation == OPERATION.NONE)
            {
                _operation = operation;
            }
            else
            {
                textBoxResult.Text = DoTheMath(_operation);
            }
        }

        private string DoTheMath(OPERATION operation)
        {
            _operation = OPERATION.NONE;
            int operatingFirst= int.Parse(_operatingFirst), operatingSecond= int.Parse(_operatingSecond);
            _operatingFirst = _operatingSecond = "0";
            switch (operation)
            {
                case OPERATION.DIV:
                    if (operatingSecond == 0)
                    {
                        return "ERROR";
                    }
                    else
                    {
                        return (operatingFirst / operatingSecond).ToString();
                    }
                case OPERATION.MULTI:
                    return (operatingFirst * operatingSecond).ToString();
                case OPERATION.SUB:
                    return (operatingFirst - operatingSecond).ToString();
                case OPERATION.SUM:
                    return (operatingFirst + operatingSecond).ToString();
                default:
                    return "0";
            }
        }
    }
}
