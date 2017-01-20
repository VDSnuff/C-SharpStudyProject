using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalckSimplTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //CalckLogik
        #region
        public static double Plus(double a, double b)
        {
            return a + b;
        }

        public static double Minus(double a, double b)
        {
            return a - b;
        }

        public static double Multiplay(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Square(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Root(double a, double b)
        {
            return Math.Pow(a, 1 / b);
        }
        #endregion

        private void btPlus_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Plus(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Minus(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }

        private void btMultiplay_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Multiplay(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Divide(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Square(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }

        private void btRoot_Click(object sender, EventArgs e)
        {
            tbResult.Text = Convert.ToString(Root(Convert.ToDouble(tbFirstNum.Text), Convert.ToDouble(tbSecondNum.Text)));
        }
    }
}
