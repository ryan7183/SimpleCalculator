using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private ExpressionHolder expression;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expression = new SimpleCalculator.ExpressionHolder();
        }

        private void allClearButton_Click(object sender, EventArgs e)
        {
            expression.resetExpression();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();//Exits Application
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            expression.addToExpression("+");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            expression.addToExpression("-");
        }

        private void inputNum0_Click(object sender, EventArgs e)
        {
            expression.addToExpression("0");
        }
    }
}
