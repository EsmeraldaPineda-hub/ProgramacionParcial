namespace TiendaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            lblNombre = new Label();
            lblPrecio = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            cmbCategorias = new ComboBox();
            lblCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(380, 44);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(359, 228);
            dgvProductos.TabIndex = 0;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(74, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "NOMBRE";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(75, 119);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(48, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "PRECIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 179);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(152, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 25);
            txtNombre.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(152, 116);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 25);
            txtPrecio.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(79, 321);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 26);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(199, 321);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 26);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(320, 321);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 26);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(438, 321);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 26);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(152, 170);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(121, 25);
            cmbCategorias.TabIndex = 11;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(74, 178);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(72, 15);
            lblCategoria.TabIndex = 12;
            lblCategoria.Text = "CATEGORIA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategorias);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(dgvProductos);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "CRUD de Productos y Categorías";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private Label lblNombre;
        private Label lblPrecio;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private ComboBox cmbCategorias;
        private Label lblCategoria;
    }
}
