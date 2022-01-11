using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtLijevi.Text !="")
            {
            txtLijevi.Text = txtDesni.Text;
            txtDesni.Clear();

            }
            else
            {
                MessageBox.Show("Upiši text!", "Nema teksta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void desnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtDesni.Text != "")
            {
            txtDesni.Text = txtLijevi.Text;
            txtLijevi.Clear();
            }
            else
            {
                MessageBox.Show("Upiši text!", "Nema teksta", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
    }
}
