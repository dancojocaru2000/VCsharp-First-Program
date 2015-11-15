using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMMDC
{
    public partial class Form1 : Form
    {
        int OK1 = 0;

        private long cmmdc(decimal deimpartit, decimal impartitor)
        {
            decimal rest = deimpartit % impartitor;
            while (rest != 0)
            {
                deimpartit = impartitor;
                impartitor = rest;
                rest = deimpartit % impartitor;
            }
            label7.Text = impartitor.ToString();
            return (long)impartitor;
        }

        private void cmmmc()
        {
            long cmmmc = (int)numericUpDown1.Value * (int)numericUpDown2.Value / cmmdc(numericUpDown1.Value, numericUpDown2.Value);
            label8.Text = cmmmc.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
            {
                cmmdc(numericUpDown1.Value, numericUpDown2.Value);
                button2.Enabled = true;
                label4.Visible = false;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
                label4.Visible = true;
                label8.Text = "";
                label7.Text = "";
            }
            else
            {
                if (checkBox1.Checked == true && numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    label4.Visible = false;
                    cmmdc(numericUpDown1.Value, numericUpDown2.Value);
                    cmmmc();
                }
                else
                {
                    label8.Text = "";
                    label7.Text = "";
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
                label4.Visible = true;
                label8.Text = "";
                label7.Text = "";
            }
            else
            {
                if (checkBox1.Checked == true && numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    label4.Visible = false;
                    cmmdc(numericUpDown1.Value, numericUpDown2.Value);
                    cmmmc();
                }
                else
                {
                    label8.Text = "";
                    label7.Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmmmc();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                button1.Enabled = true;
                button2.Enabled = false;
                label4.Visible = true;
                label8.Text = "";
                label7.Text = "";
            }
            else
            {
                if (checkBox1.Checked == true && numericUpDown1.Value != 0 && numericUpDown2.Value != 0)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    label4.Visible = false;
                    cmmdc(numericUpDown1.Value, numericUpDown2.Value);
                    cmmmc();
                }
                else
                {
                    label8.Text = "";
                    label7.Text = "";
                }
            }
        }
    }
}
