using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raven.Client;
using Raven.Client.Document;


namespace FuncionalidadesRavenDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manipulador manipulador = new Manipulador();            
            manipulador.insertUsuario(4, "andre", 'M', 29,Convert.ToDateTime("28/08/1985"), 04730371557);
            MessageBox.Show("Incluido usuário", "Incluindo usuario no RavenBD");
        }

        private void bt_Buscar_Click(object sender, EventArgs e)
        {
            Manipulador m = new Manipulador();
            try
            {
                Usuario u = m.buscaUsuario(edit_nomebusca.Text);
                if (u != null)
                {
                    tb_usuarioEncontrado.Text = u.nome;
                }
            }
            catch (NotSupportedException ex )
            {
                MessageBox.Show(ex.Message+"", "Erro ao buscar usuário!");                
            }
           
        }
    }
}
