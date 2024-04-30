namespace ejercicio_grupoFatima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mtbDuiCliente.Mask = "00000000-0";
            mtbDuiCliente.MaskInputRejected += new MaskInputRejectedEventHandler(mtbDuiCliente_MaskInputRejected);

            mtbTelefonoCliente.Mask = "0000-0000";
            mtbTelefonoCliente.MaskInputRejected += new MaskInputRejectedEventHandler(mtbTelefonoCliente_MaskInputRejected);

            mtbPrecioCliente.Mask = "00.00";
            mtbPrecioCliente.MaskInputRejected += new MaskInputRejectedEventHandler(mtbPrecioCliente_MaskInputRejected);

            cbProductos.Items.Add("JERINGAS");
            cbProductos.Items.Add("ACETAMINOFEN");
            cbProductos.Items.Add("VIROGRIP");
            cbProductos.Items.Add("SUEROS");
            cbProductos.Items.Add("CATETERS");


        }
        private void mtbPrecioCliente_MaskInputRejected(object sender, EventArgs e)
        {

        }
        private void mtbDuiCliente_MaskInputRejected(object sender, EventArgs e)
        {

        }
        private void mtbTelefonoCliente_MaskInputRejected(object sender, EventArgs e)
        {

        }
        private void verificarRango(decimal cantidad)
        {
            if (cantidad < 0 || cantidad > 10)
            {
                MessageBox.Show("SOLO SE PUEDEN COMPRAR ENTRE 1 Y 10 PRODUCTOS POR CLIENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EspaciosEnBlanco()
        {
            foreach (Control control in gbDatosCliente.Controls)
            {
                if ((control is TextBox || control is MaskedTextBox) && string.IsNullOrWhiteSpace(control.Text))
                {
                    return false;
                }

            }
            return true;
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            bool boleano = false;
            string nombre = txtNombreCliente.Text;
            string DUI = mtbDuiCliente.Text;
            string telefono = mtbTelefonoCliente.Text;
            string email = txtEmailCliente.Text;
            string precio = mtbPrecioCliente.Text;
            string cantidad = nupCantidad.Value.ToString();

            if (!EspaciosEnBlanco())
            {
                MessageBox.Show("ERROR HAY CASILLAS VACIAS, INGRESA TODOS LOS DATOS REQUERIDOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvDatos.Rows.Add(nombre, DUI, telefono, email, cantidad, precio, boleano);
                gbDatosCliente.Enabled = false;
            }

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDatos.Columns[e.ColumnIndex].Name == "Editar")
            {
                gbDatosCliente.Enabled = true;
                DataGridViewRow edit = dgvDatos.Rows[e.RowIndex];
                txtNombreCliente.Text = edit.Cells[0].Value.ToString();
                mtbDuiCliente.Text = edit.Cells[1].Value.ToString();
                mtbTelefonoCliente.Text = edit.Cells[2].Value.ToString();
                txtEmailCliente.Text = edit.Cells[3].Value.ToString();
                int cantidad = Convert.ToInt32(edit.Cells[4].Value);
                nupCantidad.Value = cantidad;
                mtbPrecioCliente.Text = edit.Cells[5].Value.ToString();
            }
            if (dgvDatos.Columns[e.ColumnIndex].Name == "ActualizarDatos")
            {
                gbDatosCliente.Enabled=false;
                string nombre = txtNombreCliente.Text;
                string DUI = mtbDuiCliente.Text;
                string telefono = mtbTelefonoCliente.Text;
                string email = txtEmailCliente.Text;
                string precio = mtbPrecioCliente.Text;
                string cantidad = nupCantidad.Value.ToString();

                DataGridViewRow Actualizar = dgvDatos.Rows[e.RowIndex];
                Actualizar.Cells[0].Value = nombre;
                Actualizar.Cells[1].Value = DUI;
                Actualizar.Cells[2].Value = telefono;
                Actualizar.Cells[3].Value = email;
                Actualizar.Cells[4].Value = cantidad;
                Actualizar.Cells[5].Value = precio;

            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Verificar si se hizo clic en el botón "Descuento"
                if (dgvDatos.Columns[e.ColumnIndex].Name == "Descuento")
                {
                    // Obtener el valor actual de la celda de precio
                    DataGridViewCell precioCell = dgvDatos.Rows[e.RowIndex].Cells["Precio"];
                    string precioString = precioCell.Value.ToString(); // Eliminar símbolo de dólar y comas

                    // Verificar si el valor ingresado es un número válido
                    if (decimal.TryParse(precioString, out decimal precio))
                    {
                        // Verificar si el precio es mayor a 25
                        if (precio > 25)
                        {
                            // Aplicar un descuento del 10%
                            precio *= 0.9m;

                            // Actualizar el valor en la celda de precio y convertirlo a formato de moneda
                            precioCell.Value = precio.ToString("00.00");
                            MessageBox.Show("Se aplicó un descuento del 10%.", "DESCUENTO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("El precio no cumple con la condición para aplicar descuento.", "NO CUMPLE REQUISITO", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Precio inválido.");
                    }
                }

            }



            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)

                if (dgvDatos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    DialogResult resultado = MessageBox.Show("Seguro que desea eliminar esta fila?", "Confirmacion de Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        int filaSeleccionada = dgvDatos.Rows[e.RowIndex].Index;

                        dgvDatos.Rows.RemoveAt(filaSeleccionada);

                        MessageBox.Show("DATOS ELIMINADOS CORRECTAMENTE", "DATOS ELIMINADOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
        }


    }
}
