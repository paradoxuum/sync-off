using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SyncOff
{
    public partial class SyncOff : Form
    {
        private List<ClasseFuncionario> listaFuncionarioMemoria = new List<ClasseFuncionario>();

        public SyncOff()
        {
            InitializeComponent();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            ClasseFuncionario funcionario = new ClasseFuncionario();

            funcionario.Nome = txtNome.Text;
            funcionario.Matricula = txtMatricula.Text;
            funcionario.Nascimento = txtNascimento.Text;
            funcionario.Departamento = cboDepartamentos.Text;

            listaFuncionarioMemoria.Add(funcionario);

            dvgFuncionarioMemoria.DataSource = null;
            dvgFuncionarioMemoria.DataSource = listaFuncionarioMemoria;

            txtNome.Text = "";
            txtMatricula.Text = "";
            txtNascimento.Text = "";
        }

        private void BtnSync_Click(object sender, EventArgs e)
        {
            foreach (ClasseFuncionario item in listaFuncionarioMemoria)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = Program.conexaoBD;
                conexao.Open();

                string ComandoSQL = "INSERT INTO Funcionarios (matricula, nmFuncionario, nascFuncionario, departamentoFunc) VALUES ('" + item.Matricula + "', '" + item.Nome + "', '" + item.Nascimento + "', '" + item.Departamento + "')";

                SqlCommand sqlCommand = new SqlCommand(ComandoSQL, conexao);

                sqlCommand.ExecuteNonQuery();

                conexao.Close();

                listaFuncionarioMemoria = new List<ClasseFuncionario>();
                dvgFuncionarioMemoria.DataSource = null;
            }
            MessageBox.Show("Dados Sincronizados com Sucesso!");
        }

        private void SyncOff_Load(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = Program.conexaoBD;
            conexao.Open();


            string comandoSQL = "SELECT * FROM Departamentos";

            SqlCommand sqlCommand = new SqlCommand(comandoSQL, conexao);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            DataTable dtFuncionariosBD = new DataTable();

            sda.Fill(dtFuncionariosBD);

            cboDepartamentos.DataSource = dtFuncionariosBD;

            cboDepartamentos.DisplayMember = "departamento";

            conexao.Close();
        }

        private void inputNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ClasseFuncionario funcionario = new ClasseFuncionario();

                funcionario.Nome = txtNome.Text;

                listaFuncionarioMemoria.Add(funcionario);

                dvgFuncionarioMemoria.DataSource = null;
                dvgFuncionarioMemoria.DataSource = listaFuncionarioMemoria;

                txtNome.Text = "";
            }
        }
    }
}
