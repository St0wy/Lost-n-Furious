using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFLostNFurious
{
    public partial class frmLogin : Form
    {
        string usernameAdmin = "Admin";
        string mdpAdmin = "Super";
        string difficulte = "";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxNomUser.Text == usernameAdmin)
            {
                if (tbxMdp.Text == mdpAdmin)
                {
                    if (rbtnGrand.Checked == true)
                    {
                        difficulte = "Grand";
                    }
                    else if (rbtnMoyen.Checked == true)
                    {
                        difficulte = "Moyen";
                    }
                    else if (rbtnPetit.Checked == true)
                    {
                        difficulte = "Petit";
                    }

                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Le nom ou le mot de passe est incorrect");
                    tbxMdp.Text = "";
                    tbxNomUser.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Le nom ou le mot de passe est incorrect");
                tbxMdp.Text = "";
                tbxNomUser.Text = "";
            }
        }

        public string GetDifficulte()
        {
            return difficulte;
        }
    }
}
