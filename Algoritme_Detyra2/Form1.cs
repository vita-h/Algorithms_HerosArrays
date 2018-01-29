using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritme_Detyra2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtResult.Clear();
            rtbResult.Clear();

            try
            {

                DivFree df = new DivFree();
                int res = df.dfcount((int)nupN.Value, (int)nupK.Value);
                txtResult.Text = res.ToString();
                rtbResult.Text = df.QueueToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rtbResult_TextChanged(object sender, EventArgs e)
        {
            rtbResult.SelectionStart = rtbResult.Text.Length;
            rtbResult.ScrollToCaret();
        }
    }
}
