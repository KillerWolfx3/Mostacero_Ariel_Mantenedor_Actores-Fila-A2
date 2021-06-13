
namespace Mostacero_Ariel_Mantenedor_Actores
{
    partial class MantenedorActores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenedorActores));
            this.btModificar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgvActor = new System.Windows.Forms.DataGridView();
            this.lbListaActor = new System.Windows.Forms.Label();
            this.PnModificar = new System.Windows.Forms.Panel();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.txtIdActor = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbPel = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbApe = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbDatosAc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).BeginInit();
            this.PnModificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(587, 297);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(77, 40);
            this.btModificar.TabIndex = 0;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(587, 75);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(77, 38);
            this.btEditar.TabIndex = 1;
            this.btEditar.Text = "Editar Datos";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(587, 343);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(77, 36);
            this.btCancelar.TabIndex = 2;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // dgvActor
            // 
            this.dgvActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActor.Location = new System.Drawing.Point(58, 25);
            this.dgvActor.Name = "dgvActor";
            this.dgvActor.Size = new System.Drawing.Size(514, 208);
            this.dgvActor.TabIndex = 3;
            this.dgvActor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvActor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbListaActor
            // 
            this.lbListaActor.AutoSize = true;
            this.lbListaActor.Location = new System.Drawing.Point(55, 9);
            this.lbListaActor.Name = "lbListaActor";
            this.lbListaActor.Size = new System.Drawing.Size(86, 13);
            this.lbListaActor.TabIndex = 4;
            this.lbListaActor.Text = "Lista de Actores:";
            // 
            // PnModificar
            // 
            this.PnModificar.Controls.Add(this.txtPelicula);
            this.PnModificar.Controls.Add(this.txtIdActor);
            this.PnModificar.Controls.Add(this.txtApellido);
            this.PnModificar.Controls.Add(this.txtNombre);
            this.PnModificar.Controls.Add(this.lbPel);
            this.PnModificar.Controls.Add(this.lbId);
            this.PnModificar.Controls.Add(this.lbApe);
            this.PnModificar.Controls.Add(this.lbName);
            this.PnModificar.Controls.Add(this.lbDatosAc);
            this.PnModificar.Location = new System.Drawing.Point(58, 253);
            this.PnModificar.Name = "PnModificar";
            this.PnModificar.Size = new System.Drawing.Size(514, 136);
            this.PnModificar.TabIndex = 5;
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(66, 105);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(226, 20);
            this.txtPelicula.TabIndex = 14;
            // 
            // txtIdActor
            // 
            this.txtIdActor.Location = new System.Drawing.Point(66, 81);
            this.txtIdActor.Name = "txtIdActor";
            this.txtIdActor.Size = new System.Drawing.Size(226, 20);
            this.txtIdActor.TabIndex = 13;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(66, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // lbPel
            // 
            this.lbPel.AutoSize = true;
            this.lbPel.Location = new System.Drawing.Point(13, 108);
            this.lbPel.Name = "lbPel";
            this.lbPel.Size = new System.Drawing.Size(47, 13);
            this.lbPel.TabIndex = 10;
            this.lbPel.Text = "Pelicula:";
            this.lbPel.Click += new System.EventHandler(this.lbPel_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(13, 84);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(44, 13);
            this.lbId.TabIndex = 9;
            this.lbId.Text = "IdActor:";
            // 
            // lbApe
            // 
            this.lbApe.AutoSize = true;
            this.lbApe.Location = new System.Drawing.Point(13, 58);
            this.lbApe.Name = "lbApe";
            this.lbApe.Size = new System.Drawing.Size(47, 13);
            this.lbApe.TabIndex = 8;
            this.lbApe.Text = "Apellido:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(13, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Nombre:";
            // 
            // lbDatosAc
            // 
            this.lbDatosAc.AutoSize = true;
            this.lbDatosAc.Location = new System.Drawing.Point(26, 0);
            this.lbDatosAc.Name = "lbDatosAc";
            this.lbDatosAc.Size = new System.Drawing.Size(89, 13);
            this.lbDatosAc.TabIndex = 6;
            this.lbDatosAc.Text = "Datos de Actores";
            // 
            // MantenedorActores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 401);
            this.Controls.Add(this.PnModificar);
            this.Controls.Add(this.lbListaActor);
            this.Controls.Add(this.dgvActor);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenedorActores";
            this.Text = "MantenedorActores";
            this.Load += new System.EventHandler(this.MantenedorActores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActor)).EndInit();
            this.PnModificar.ResumeLayout(false);
            this.PnModificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.DataGridView dgvActor;
        private System.Windows.Forms.Label lbListaActor;
        private System.Windows.Forms.Panel PnModificar;
        private System.Windows.Forms.Label lbPel;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbApe;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDatosAc;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.TextBox txtIdActor;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

