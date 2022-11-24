using System;
using MosaicoSolutions.ViaCep.Modelos;
using MosaicoSolutions.ViaCep;
using System.Windows.Forms;


namespace find_adress_by_Cep
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// Search the adress when the Buscar button is clicked
        private void btnFindAdress_Click(object sender, EventArgs e)
        {
            FindAdressByCep(masktxtboxCEP.Text);
        }

        /// Search the adress when the key Enter is pressed
        private void masktxtboxCEP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindAdressByCep(masktxtboxCEP.Text);
            }
        }

        /// Click on the button to clear the search
        private void btnClearAdressSearch_Click(object sender, EventArgs e)
        {
            txtboxState.Text = null;
            txtboxCity.Text = null;
            txtboxDistrict.Text = null;
            txtboxStreet.Text = null;

            masktxtboxCEP.Clear();
            masktxtboxCEP.Focus();
        }

        /// Clear the search result when entering a new CEP
        private void masktxtboxCEP_TextChanged(object sender, EventArgs e)
        {
            txtboxState.Text = null;
            txtboxCity.Text = null;
            txtboxDistrict.Text = null;
            txtboxStreet.Text = null;
        }


        /// Method to search the adress
        /// This method will make the request in the API ViaCEP using the package MosaicoSolutions.ViaCep 
        /// And will fill the textBox with the adress 
        private void GetAdress(String cep)
        {
            var viaCepService = ViaCepService.Default();

            try
            {
                Endereco adress = viaCepService.ObterEndereco(cep);

                txtboxState.Text = adress.UF;
                txtboxCity.Text = adress.Localidade;
                txtboxDistrict.Text = adress.Bairro;
                txtboxStreet.Text = adress.Logradouro;

            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "CEP não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                masktxtboxCEP.Focus();
            }
        }

        /// Method to verify de CEP entered
        /// This method wil verify the exeptions in the CEP 
        /// Will show alert messages when these exeptions are throw <summary>
        /// And finally will call the method GetAdress
        private void VerifyCEP (String cep)
        {
            if (cep.Length != 8)
            {
                if (cep.Length == 0)
                {
                    MessageBox.Show("CEP não digitado", "CEP não digitado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    masktxtboxCEP.Focus();
                }
                if (cep.Length > 0 && cep.Length < 8)
                {
                    MessageBox.Show("CEP incompleto", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    masktxtboxCEP.Focus();
                    masktxtboxCEP.Clear();
                }
            }
            else
            {
                GetAdress(cep);
            }
        }

        /// Method FindAdressByCEP
        /// This method will call the others methods to finish the search
        private void FindAdressByCep(String cep)
        {
            VerifyCEP(cep);
        }
    }
}
