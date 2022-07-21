using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColor.Items.Add("Blanco");
            cbColor.Items.Add("Rojo");
            cbColor.Items.Add("Negro");
            cbColor.Items.Add("Amarillo");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //Operador ternario
            string chocolate = ckbChoco.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate" ;
            string tipo;
            if (rbtagua.Checked)
                tipo = "Agua";
            else if (rbtFuego.Checked)
                tipo = "Fuego";
            else
                tipo = "Hierba";
            string colorFavorito = cbColor.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            MessageBox.Show($"Nombre {nombre}, Fecha: {fecha}, {chocolate}, su color favorito es el {colorFavorito}, le gustan los pokemones de {tipo} y su numero favorito es el {numeroFavorito}");

        }
    }
}
