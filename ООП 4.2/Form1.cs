using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_4._2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
            model.setA(Properties.Settings.Default.A);
            model.setB(Properties.Settings.Default.B);
            model.setC(Properties.Settings.Default.C);

        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            textA.Text = model.getA().ToString();
            numericA.Value = model.getA();
            trackA.Value = model.getA();
            textB.Text = model.getB().ToString();
            numericB.Value = model.getB();
            trackB.Value = model.getB();
            textC.Text = model.getC().ToString();
            numericC.Value = model.getC();
            trackC.Value = model.getC();
        }

        private void numericA_ValueChanged(object sender, EventArgs e)
        {
            model.setA(Decimal.ToInt32(numericA.Value));
        }

        private void trackA_Scroll(object sender, EventArgs e)
        {
            model.setA(trackA.Value);
        }

        private void numericB_ValueChanged(object sender, EventArgs e)
        {
            model.setB(Decimal.ToInt32(numericB.Value));
        }

        private void trackB_Scroll(object sender, EventArgs e)
        {
            model.setB(trackB.Value);
        }

        private void numericC_ValueChanged(object sender, EventArgs e)
        {
            model.setC(Decimal.ToInt32(numericC.Value));
        }

        private void trackC_Scroll(object sender, EventArgs e)
        {
            model.setC(trackC.Value);
        }

        private void textA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setA(Int32.Parse(textA.Text));
        }

        private void textB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setB(Int32.Parse(textB.Text));
        }

        private void textC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.setC(Int32.Parse(textC.Text));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.A = model.getA();
            Properties.Settings.Default.B = model.getB();
            Properties.Settings.Default.C = model.getC();
            Properties.Settings.Default.Save();
        }
    }

    public class Model
    {
        private int A = 0;
        private int B = 50;
        private int C = 100;

        public System.EventHandler observers;
        public void setA(int A)
        {
            if (A <= B && B <= C)
                this.A = A;

            else if (A > B && B <= C)
            {
                this.A = A;
                B = A;
            }

            else
            {
                B = A;
                C = A;
            }

            observers.Invoke(this, null);
        }
        public void setB(int B)
        {
            if (A <= B && B <= C)
                this.B = B;
            observers.Invoke(this, null);
        }
        public void setC(int C)
        {
            if (A <= B && B <= C)
                this.C = C;
            else if (A <= B && B > C)
            {
                this.C = C;
                B = C;
            }
            else
            {
                this.C = C;
                B = C;
                A = C;
            }
            
            observers.Invoke(this, null);


        }
        public int getA()
        {
            return A;
        }
        public int getB()
        {
            return B;
        }
        public int getC()
        {
            return C;
        }
    }
}
