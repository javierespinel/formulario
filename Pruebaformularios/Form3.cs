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
    public partial class Form3 : Form
    {
        Carpeta carpeta=new Carpeta();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            clear();
            cargartabla();
        }

        private void Closed(object sender, FormClosingEventArgs e)
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
            txtID.Text = txtCodigoBarras.Text = txtCajaId.Text = txtClienteId.Text = txtEntidadId.Text = "";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            carpeta.ID = int.Parse(txtID.Text);
            carpeta.CodigoBarras = txtCodigoBarras.Text.Trim();
            carpeta.CajaID = int.Parse(txtCajaId.Text);
            carpeta.ClienteID = int.Parse(txtClienteId.Text);
            carpeta.EntidadID = int.Parse(txtEntidadId.Text);
            using (pruebaEntities db = new pruebaEntities())
            {
                db.Carpetas.Add(carpeta);
                db.SaveChanges();
            }
            clear();
            MessageBox.Show("guardado exitosamente");
        }

        void cargartabla()
        {
            dgvCarpetas.AutoGenerateColumns = false;
            using (pruebaEntities db = new pruebaEntities())
            {
                dgvCarpetas.DataSource= db.Carpetas.ToList<Carpeta>();
            }
        }
    }
}
