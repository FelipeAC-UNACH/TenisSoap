using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Xml;

namespace TenisWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private ServiTenisSoap.indexPortTypeClient con = new ServiTenisSoap.indexPortTypeClient();
        //string resultado;
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = con.GetSnikear(txtID.Text).ToString();  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = con.DelSnikear(txtID.Text).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            txtResultado.Text = con.insertSnikear(txtMarca.Text, txtNombre.Text, Convert.ToInt32(txtPrecio.Text), txtColor.Text, txtMaterial.Text).ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = con.UpdaSnikear(Convert.ToInt32(txtID.Text), txtMarca.Text, txtNombre.Text, Convert.ToInt32(txtPrecio.Text), txtColor.Text, txtMaterial.Text).ToString(); ;
        }
    }
}
