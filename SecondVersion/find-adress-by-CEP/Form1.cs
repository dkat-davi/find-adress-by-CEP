using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace find_adress_by_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// Call the method FindAdress when click on BUSCAR button
        /// 
        private void btnFindAdress_Click(object sender, EventArgs e)
        {
            FindAdress();
        }

        /// Call the method FindAdress when KeyUp the Key Enter
        /// 
        private void masktxtboxCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindAdress();
            }
        }

        /// Fill the search fields with the return data from API
        /// 
        private void FillAdress(Adress adress)
        {
            txtboxState.Text = adress.Uf;
            txtboxCity.Text = adress.Localidade;
            txtboxDistrict.Text = adress.Bairro;
            txtboxStreet.Text = adress.Logradouro;
        }

        /// Verify the CEP entered and return an error
        /// 
        private void VerifyCEP(String cep)
        {
            if (cep.Length == 0)
            {
                MessageBox.Show("CEP não digitado", "NO TYPED", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                masktxtboxCEP.Focus();
                masktxtboxCEP.Clear();
            }
            if (cep.Length > 0 && cep.Length < 8)
            {
                MessageBox.Show("CEP incompleto", "INCOMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                masktxtboxCEP.Focus();
                masktxtboxCEP.Clear();
            }

        }

        /// Find the adress by CEP entered
        /// Verify the search field 
        /// If the CEP entered is valid, fill the searchs fields 
        /// Else return an error
        private async void FindAdress()
        {
            String cep = masktxtboxCEP.Text;

            if (cep.Length == 8)
            {
                Adress adress = await AdressQuery.GetAdress(masktxtboxCEP.Text);
                if (adress.Cep == null)
                {
                    MessageBox.Show("CEP não encontrado", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    masktxtboxCEP.Focus();
                    masktxtboxCEP.Clear();
                }
                else
                {
                    FillAdress(adress);
                }
            }
            else
            {
                VerifyCEP(cep);
            }
        }

        /// Clear the fields when click on LIMPAR button 
        /// 
        private void btnClearAdressSearch_Click(object sender, EventArgs e)
        {
            txtboxState.Text = null;
            txtboxCity.Text = null;
            txtboxDistrict.Text = null;
            txtboxStreet.Text = null;
            masktxtboxCEP.Text = null;
            masktxtboxCEP.Focus();
        }

        /// Clear the fields when search again
        /// 
        private void masktxtboxCEP_TextChanged(object sender, EventArgs e)
        {
            txtboxState.Text = null;
            txtboxCity.Text = null;
            txtboxDistrict.Text = null;
            txtboxStreet.Text = null;
        }
    }
}
