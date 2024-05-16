using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebaformularios
{
    public partial class Form1 : Form
    {
        Cliente c = new Cliente();
        Form2 ventana1=new Form2();
        Form3 ventana2 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtTipoIdentificacion.Text = txtNumeroDocumento.Text = txtNombres.Text = txtApellidos.Text = txtDireccion.Text = txtTelefonoFijo.Text = txtTelefonoCelular.Text = txtID.Text = "";
            BtnEliminar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            c.ID = int.Parse(txtID.Text);
            c.TipoIdentificacion = txtTipoIdentificacion.Text.Trim();
            c.NumeroDocumento = txtNumeroDocumento.Text.Trim();
            c.Nombres = txtNombres.Text.Trim();
            c.Apellidos = txtApellidos.Text.Trim();
            c.Direccion = txtDireccion.Text.Trim();
            c.TelefonoFijo = txtTelefonoFijo.Text.Trim();
            c.TelefonoCelular = txtTelefonoCelular.Text.Trim();
            using (pruebaEntities db=new pruebaEntities())
            {
                db.Clientes.Add(c);
                db.SaveChanges();
            }
            clear();
            MessageBox.Show("guardado exitosamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventana1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ventana2.Visible = true;
        }
    }
}
