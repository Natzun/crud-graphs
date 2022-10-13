using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_GRAPHS.Cadastros {
    public partial class CadastroClientes : Form {
        public CadastroClientes() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            Show();
        }

        private void label14_Click(object sender, EventArgs e) {

        }

        private void CadastroClientes_Load(object sender, EventArgs e) {

        }

        private void botaoSalvar_Click(object sender, EventArgs e) {
            string nomeCliente;
            string tipoDeDocumento;
            double numeroDocumento;
            string emailCliente;
            int telefoneCliente1;
            int telefoneCliente2;
            string enderecoCliente;
            int numeroEndereco;
            string complementoEndereco;
            int cepEndereco;
            string bairroEndereco;
            string cidadeEndereco;

            nomeCliente = textNome.Text;
            tipoDeDocumento = comboBoxTipo.Text;
            numeroDocumento = double.Parse(textDocumento.Text);
            emailCliente = textEmail.Text;
            telefoneCliente1 = Convert.ToInt32(maskedTelefone1.Text); // colocar outra variável, uma vez que Int32 não tem espaço para armazenar
            telefoneCliente2 = Convert.ToInt32(maskedTelefone2.Text);
            enderecoCliente = textEndereco.Text;
            numeroEndereco = Convert.ToInt32(textNumero.Text);
            complementoEndereco = textComplemento.Text;
            cepEndereco = Convert.ToInt32(maskedCep.Text);
            bairroEndereco = textBairro.Text;
            cidadeEndereco = textCidade.Text;
        }
    }
}
