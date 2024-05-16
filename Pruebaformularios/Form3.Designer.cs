namespace Pruebaformularios
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.txtCajaId = new System.Windows.Forms.TextBox();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.txtEntidadId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvCarpetas = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCajaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEntidadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarpetas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCarpetas);
            this.splitContainer1.Size = new System.Drawing.Size(853, 450);
            this.splitContainer1.SplitterDistance = 305;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.txtEntidadId);
            this.groupBox1.Controls.Add(this.txtClienteId);
            this.groupBox1.Controls.Add(this.txtCajaId);
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Accion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo de Barras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caja Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entidad ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(136, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(136, 60);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoBarras.TabIndex = 6;
            // 
            // txtCajaId
            // 
            this.txtCajaId.Location = new System.Drawing.Point(136, 97);
            this.txtCajaId.Name = "txtCajaId";
            this.txtCajaId.Size = new System.Drawing.Size(100, 20);
            this.txtCajaId.TabIndex = 7;
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(136, 134);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(100, 20);
            this.txtClienteId.TabIndex = 8;
            // 
            // txtEntidadId
            // 
            this.txtEntidadId.Location = new System.Drawing.Point(136, 173);
            this.txtEntidadId.Name = "txtEntidadId";
            this.txtEntidadId.Size = new System.Drawing.Size(100, 20);
            this.txtEntidadId.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(81, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(81, 77);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvCarpetas
            // 
            this.dgvCarpetas.AllowUserToDeleteRows = false;
            this.dgvCarpetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarpetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgCodigoBarras,
            this.dgCajaID,
            this.dgClienteID,
            this.dgEntidadID});
            this.dgvCarpetas.Location = new System.Drawing.Point(17, 12);
            this.dgvCarpetas.Name = "dgvCarpetas";
            this.dgvCarpetas.ReadOnly = true;
            this.dgvCarpetas.Size = new System.Drawing.Size(517, 426);
            this.dgvCarpetas.TabIndex = 0;
            // 
            // dgID
            // 
            this.dgID.DataPropertyName = "ID";
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            this.dgID.ReadOnly = true;
            // 
            // dgCodigoBarras
            // 
            this.dgCodigoBarras.DataPropertyName = "CodigoBarras";
            this.dgCodigoBarras.HeaderText = "Codigo de Barras";
            this.dgCodigoBarras.Name = "dgCodigoBarras";
            this.dgCodigoBarras.ReadOnly = true;
            // 
            // dgCajaID
            // 
            this.dgCajaID.DataPropertyName = "CajaID";
            this.dgCajaID.HeaderText = "Caja ID";
            this.dgCajaID.Name = "dgCajaID";
            this.dgCajaID.ReadOnly = true;
            // 
            // dgClienteID
            // 
            this.dgClienteID.DataPropertyName = "ClienteID";
            this.dgClienteID.HeaderText = "Cliente ID";
            this.dgClienteID.Name = "dgClienteID";
            this.dgClienteID.ReadOnly = true;
            // 
            // dgEntidadID
            // 
            this.dgEntidadID.DataPropertyName = "EntidadID";
            this.dgEntidadID.HeaderText = "Entidad ID";
            this.dgEntidadID.Name = "dgEntidadID";
            this.dgEntidadID.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarpetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtEntidadId;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.TextBox txtCajaId;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCarpetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCajaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntidadID;
    }
}