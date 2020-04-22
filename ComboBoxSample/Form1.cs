using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>-1)
            {
                label1.Text = String.Format("Pozycja {0} - kolor {1}",
                    comboBox1.SelectedIndex, comboBox1.SelectedItem);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        panel1.BackColor = Color.Black;
                        break;
                    case 1:
                        panel1.BackColor = Color.Brown;
                        break;
                    case 2:
                        panel1.BackColor = Color.Red;
                        break;
                    case 3:
                        panel1.BackColor = Color.Orange;
                        break;
                    case 4:
                        panel1.BackColor = Color.Yellow;
                        break;
                    case 5:
                        panel1.BackColor = Color.Green;
                        break;
                    case 6:
                        panel1.BackColor = Color.Blue;
                        break;
                    case 7:
                        panel1.BackColor = Color.Violet;
                        break;
                    case 8:
                        panel1.BackColor = Color.Gray;
                        break;
                    case 9:
                        panel1.BackColor = Color.AntiqueWhite;
                        break;
                    case 10:
                        panel1.BackColor = Color.Gold;
                        break;
                    case 11:
                        panel1.BackColor = Color.Silver;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
