using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=OSA0625222W10-1;Initial Catalog=Ex1;Integrated Security=True");
        SqlCommand comando = new SqlCommand();
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarLista()
        {
                conexao.Open();
                comando.CommandText = "select * from Produto";
                dr = comando.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        lbProduto.Items.Add(dr[0].ToString());
                        lbNome.Items.Add(dr[1].ToString());
                        lbEstoque.Items.Add(dr[2].ToString());
                        lbValor.Items.Add(dr[3].ToString());
                        lbCnpj.Items.Add(dr[4].ToString());
                    
                    }
                }
                conexao.Close();
        }

        private void Alinhar(object sender)
        {
                ListBox l = sender as ListBox;

                //Se algum dado na listbox estiver selecionado:
                if (l.SelectedIndex != -1)
                {
                    lbProduto.SelectedIndex = l.SelectedIndex; // Todas as listbox recebem a seleção equivalente.
                    lbNome.SelectedIndex = l.SelectedIndex;
                    lbEstoque.SelectedIndex = l.SelectedIndex;
                    lbValor.SelectedIndex = l.SelectedIndex;
                    lbCnpj.SelectedIndex = l.SelectedIndex;
                }
        }

        private void Media(object sender)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                lbValor.SelectedIndex = l.SelectedIndex;
                lbEstoque.SelectedIndex = l.SelectedIndex;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comando.Connection = conexao;
            CarregarLista();
        }

        private void lbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
            ;
        }

        private void lbEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void lbCnpj_SelectedIndexChanged(object sender, EventArgs e)
        {
            Alinhar(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Media de todos os itens
        private void button1_Click(object sender, EventArgs e)
        {
            while (dr.Read())
            {;
                lbEstoque.Items.Add(dr[2].ToString());
                lbValor.Items.Add(dr[3].ToString());
                MessageBox.Show(dr[2].ToString());
            }
        }
    }
}
