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
    public partial class Form2 : Form
    {
        Caja caja=new Caja();
        public Form2()
        {
            InitializeComponent();
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtID.Text = txtCodigoBarras.Text = txtZona.Text = txtSeccion.Text = txtNivel.Text = txtCara.Text = txtEntidadId.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            caja.ID = int.Parse(txtID.Text);
            caja.CodigoBarras = txtCodigoBarras.Text.Trim();
            caja.Zona = int.Parse(txtZona.Text);
            caja.Seccion = int.Parse(txtSeccion.Text);
            caja.Nivel = int.Parse(txtNivel.Text);
            caja.Cara = txtCara.Text.Trim();
            caja.EntidadID = int.Parse(txtEntidadId.Text);
            using (pruebaEntities db = new pruebaEntities())
            {
                db.Cajas.Add(caja);
                db.SaveChanges();
            }
            clear();
            MessageBox.Show("guardado exitosamente");
        }
    }
}
