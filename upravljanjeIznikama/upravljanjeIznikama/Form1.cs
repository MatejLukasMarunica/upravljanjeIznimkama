using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljanjeIznikama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void unos_Click(object sender, EventArgs e)
        {
            try
            {
                int godStick = Convert.ToInt16(txtunos.Text);

                txtunos1.Text = godStick.ToString();
                txtunos.Clear();
            }
            catch(Exception greska)
            {
                DialogResult odabir = MessageBox.Show("Molim vas da Upišete broj. \nDa li želite izbrisati postojeći tekst?", "Pogrešan unos. ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);  

                switch (odabir)
                {
                    case DialogResult.Yes:
                        txtunos.Clear(); break;
                    case DialogResult.No:
                        break;
                }
                txtunos.Select();
            }
        }
    }
}
