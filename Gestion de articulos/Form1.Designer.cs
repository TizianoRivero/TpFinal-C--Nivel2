namespace Gestion_de_articulos
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbxGestion = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 53);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(565, 255);
            this.dgvArticulos.TabIndex = 7;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(12, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Location = new System.Drawing.Point(255, 314);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 4;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(93, 314);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(336, 314);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(174, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbxGestion
            // 
            this.pbxGestion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbxGestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxGestion.Location = new System.Drawing.Point(583, 53);
            this.pbxGestion.Name = "pbxGestion";
            this.pbxGestion.Size = new System.Drawing.Size(239, 255);
            this.pbxGestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGestion.TabIndex = 7;
            this.pbxGestion.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "GESTION DE ARTICULOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(418, 316);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(159, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(832, 349);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxGestion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(848, 388);
            this.MinimumSize = new System.Drawing.Size(848, 388);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de articulos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbxGestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}

