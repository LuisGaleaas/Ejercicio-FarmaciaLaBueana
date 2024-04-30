namespace ejercicio_grupoFatima
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
            gbDatosCliente = new GroupBox();
            nupCantidad = new NumericUpDown();
            label6 = new Label();
            cbProductos = new ComboBox();
            Producto = new Label();
            mtbPrecioCliente = new MaskedTextBox();
            label5 = new Label();
            btSiguiente = new Button();
            txtEmailCliente = new TextBox();
            mtbTelefonoCliente = new MaskedTextBox();
            mtbDuiCliente = new MaskedTextBox();
            txtNombreCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvDatos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            DUI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewLinkColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewButtonColumn();
            Editar = new DataGridViewImageColumn();
            ActualizarDatos = new DataGridViewImageColumn();
            Eliminar = new DataGridViewCheckBoxColumn();
            label7 = new Label();
            gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // gbDatosCliente
            // 
            gbDatosCliente.BackColor = SystemColors.ActiveCaption;
            gbDatosCliente.Controls.Add(nupCantidad);
            gbDatosCliente.Controls.Add(label6);
            gbDatosCliente.Controls.Add(cbProductos);
            gbDatosCliente.Controls.Add(Producto);
            gbDatosCliente.Controls.Add(mtbPrecioCliente);
            gbDatosCliente.Controls.Add(label5);
            gbDatosCliente.Controls.Add(btSiguiente);
            gbDatosCliente.Controls.Add(txtEmailCliente);
            gbDatosCliente.Controls.Add(mtbTelefonoCliente);
            gbDatosCliente.Controls.Add(mtbDuiCliente);
            gbDatosCliente.Controls.Add(txtNombreCliente);
            gbDatosCliente.Controls.Add(label4);
            gbDatosCliente.Controls.Add(label3);
            gbDatosCliente.Controls.Add(label2);
            gbDatosCliente.Controls.Add(label1);
            gbDatosCliente.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            gbDatosCliente.Location = new Point(35, 25);
            gbDatosCliente.Name = "gbDatosCliente";
            gbDatosCliente.Size = new Size(294, 436);
            gbDatosCliente.TabIndex = 0;
            gbDatosCliente.TabStop = false;
            gbDatosCliente.Text = "FARMACIA LA BUENA ";
            // 
            // nupCantidad
            // 
            nupCantidad.Location = new Point(112, 274);
            nupCantidad.Name = "nupCantidad";
            nupCantidad.Size = new Size(156, 33);
            nupCantidad.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 276);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 13;
            label6.Text = "Cantidad";
            // 
            // cbProductos
            // 
            cbProductos.FormattingEnabled = true;
            cbProductos.Location = new Point(112, 223);
            cbProductos.Name = "cbProductos";
            cbProductos.Size = new Size(156, 33);
            cbProductos.TabIndex = 12;
            // 
            // Producto
            // 
            Producto.AutoSize = true;
            Producto.Location = new Point(7, 231);
            Producto.Name = "Producto";
            Producto.Size = new Size(90, 25);
            Producto.TabIndex = 11;
            Producto.Text = "Producto";
            // 
            // mtbPrecioCliente
            // 
            mtbPrecioCliente.Location = new Point(113, 330);
            mtbPrecioCliente.Name = "mtbPrecioCliente";
            mtbPrecioCliente.Size = new Size(155, 33);
            mtbPrecioCliente.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 336);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 9;
            label5.Text = "Precio";
            // 
            // btSiguiente
            // 
            btSiguiente.Location = new Point(66, 392);
            btSiguiente.Name = "btSiguiente";
            btSiguiente.Size = new Size(116, 38);
            btSiguiente.TabIndex = 8;
            btSiguiente.Text = "Siguiente";
            btSiguiente.UseVisualStyleBackColor = true;
            btSiguiente.Click += btSiguiente_Click;
            // 
            // txtEmailCliente
            // 
            txtEmailCliente.Location = new Point(112, 181);
            txtEmailCliente.Name = "txtEmailCliente";
            txtEmailCliente.Size = new Size(156, 33);
            txtEmailCliente.TabIndex = 7;
            // 
            // mtbTelefonoCliente
            // 
            mtbTelefonoCliente.Location = new Point(114, 138);
            mtbTelefonoCliente.Name = "mtbTelefonoCliente";
            mtbTelefonoCliente.Size = new Size(154, 33);
            mtbTelefonoCliente.TabIndex = 6;
            // 
            // mtbDuiCliente
            // 
            mtbDuiCliente.Location = new Point(112, 91);
            mtbDuiCliente.Name = "mtbDuiCliente";
            mtbDuiCliente.Size = new Size(156, 33);
            mtbDuiCliente.TabIndex = 5;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(112, 46);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(156, 33);
            txtNombreCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 184);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 91);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "DUI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // dgvDatos
            // 
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvDatos.BackgroundColor = SystemColors.ActiveCaption;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Nombre, DUI, Telefono, Email, Cantidad, Precio, Descuento, Editar, ActualizarDatos, Eliminar });
            dgvDatos.Location = new Point(351, 116);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(664, 144);
            dgvDatos.TabIndex = 1;
            dgvDatos.CellContentClick += dgvDatos_CellContentClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // DUI
            // 
            DUI.HeaderText = "DUI";
            DUI.Name = "DUI";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.Resizable = DataGridViewTriState.True;
            Precio.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Descuento
            // 
            Descuento.HeaderText = "Descuento";
            Descuento.Name = "Descuento";
            Descuento.Text = "Descuento";
            Descuento.UseColumnTextForButtonValue = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Image = Properties.Resources.editar_codigo;
            Editar.Name = "Editar";
            // 
            // ActualizarDatos
            // 
            ActualizarDatos.HeaderText = "Actualizar";
            ActualizarDatos.Image = Properties.Resources.disco_flexible;
            ActualizarDatos.Name = "ActualizarDatos";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(468, 81);
            label7.Name = "label7";
            label7.Size = new Size(507, 32);
            label7.TabIndex = 2;
            label7.Text = "REGISTRO DE VENTAS FARMACIA LA BUENA ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 473);
            Controls.Add(label7);
            Controls.Add(dgvDatos);
            Controls.Add(gbDatosCliente);
            Name = "Form1";
            Text = "Form1";
            gbDatosCliente.ResumeLayout(false);
            gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbDatosCliente;
        private TextBox txtEmailCliente;
        private MaskedTextBox mtbTelefonoCliente;
        private MaskedTextBox mtbDuiCliente;
        private TextBox txtNombreCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtbPrecioCliente;
        private Label label5;
        private Button btSiguiente;
        private DataGridView dgvDatos;
        private ComboBox cbProductos;
        private Label Producto;
        private NumericUpDown nupCantidad;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DUI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewLinkColumn Email;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewButtonColumn Descuento;
        private DataGridViewImageColumn Editar;
        private DataGridViewImageColumn ActualizarDatos;
        private DataGridViewCheckBoxColumn Eliminar;
    }
}