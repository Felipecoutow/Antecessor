using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antecessor
{
    public partial class FrmAntecessor : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );
        public FrmAntecessor()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int N, R;

            N = Convert.ToInt32(txtvalor.Text);

            R = N - 1;

            txtresultado.Text = Convert.ToString(R);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtvalor.Clear();
            txtresultado.Clear();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
