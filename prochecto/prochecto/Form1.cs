using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prochecto
{
    public partial class Form1 : Form

	{
        public Form1()
        {
        }

		int nrominijuego = 1;

		private void BtnImita_Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.Show();
			this.Hide();
		}

		private void BtnflechaD_Click(object sender, EventArgs e)
		{
			if (nrominijuego < 5)
				{
				nrominijuego = nrominijuego + 1;
				}
		}

		private void BtnflechaI_Click(object sender, EventArgs e)
		{

		}
	}
}
