using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace SistemaTiendaAAA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ProductoNormal> Productos = new List<ProductoNormal>();
        List<Tarjetas> Tarjetas = new List<Tarjetas>();
        List<Detalle> detalles = new List<Detalle>();
        List<Venta> ventas = new List<Venta>();
        List<Cliente> clientes = new List<Cliente>();
        OleDbCommand cmd = new OleDbCommand();

        byte numero = 0;
        byte eliminar = 0;

        private OleDbConnection con;
        private String conStr;
        private String Path;
        Venta compra;
        Cliente nuevo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAgregarItem_Click(object sender, RoutedEventArgs e)
        {
            string tipo = null, nombre = null; byte cantidad = 0; float precioU = 0;
            tipo = cbxtipoProducto.Text;
            try
            { nombre = txtNombreProducto.Text; }
            catch(Exception ex) { MessageBox.Show("Ingrese un nombre de producto válido."); return; }
            try
            { cantidad = byte.Parse(txtCantidadItems.Text); }
            catch(Exception ex) { MessageBox.Show("Ingrese unaa cantidad válida."); return; }
            try
            {
                precioU = float.Parse(txtPrecioProducto.Text);
                numero++;
                ProductoNormal nuevoProducto = new ProductoNormal(nombre, tipo, precioU, numero);
                Detalle detallado = new Detalle(nuevoProducto.NombreProducto, cantidad);
                detallado.calcularTotal(float.Parse(nuevoProducto.PrecioUnitario));
                dtgProducto.Items.Add(nuevoProducto);
                dtgDetalle.Items.Add(detallado);
                compra.calcularTotal(detallado.TotalProducto);
                lblTotalVenta.Content = compra.Total;
                Productos.Add(nuevoProducto);
                detalles.Add(detallado);
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtCantidadItems.Clear();
            }
            catch(Exception ex) { MessageBox.Show("Ingrese el precio unitario válido."); return; }
        }

        private void btnEliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                eliminar = byte.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número del producto a Eliminar", "Eliminar Elemento"));
                if (eliminar < 1 || eliminar > dtgProducto.Items.Count)
                   { MessageBox.Show("Ingrese un número de la lista de detalle de la compra."); }
                else
                {
                    for (int i = 0; i < Productos.Count; i++)
                    {
                        if (Productos[i].Numero == eliminar)
                        {
                            compra.Total = (compra.Total - detalles[i].TotalProducto);
                            lblTotalVenta.Content = compra.Total;
                            Productos.RemoveAt(i);
                            detalles.RemoveAt(i);
                            dtgProducto.Items.RemoveAt(i);
                            dtgDetalle.Items.RemoveAt(i);
                        }
                    }
                }
            }
            catch(FormatException ex) { MessageBox.Show("Ingrese un número de la lista de detalle de la compra."); return; }
        }

        private void btnVerificarCliente_Click(object sender, RoutedEventArgs e)
        {
            verificarCliente(txtNombreCliente, txtTelfCliente);
        }

        private void verificarCliente(TextBox nombre, TextBox telefono)
        {
            DataRow[] foundrow = null;
            try
            {
                int telf = int.Parse(telefono.Text);
                string strSelectCmd = "SELECT * FROM Cliente";
                OleDbDataAdapter objDataAdapter = new OleDbDataAdapter(strSelectCmd, con);
                DataTable ds = new DataTable();
                objDataAdapter.Fill(ds);
                foundrow = ds.Select("telefono = " + telf);
                if (foundrow.Length > 0)
                {
                    nombre.Text = foundrow[0][0].ToString();
                }
                else
                {
                    MessageBox.Show("El cliente no esta registrado.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Ingrese un número de teléfono registrado."); return; }
        }

        private void btnRegistrarCliente_Click(object sender, RoutedEventArgs e)
        {
            string nombre;
            try
            {
                nombre = txtNombreCliente.Text;
                if(nombre == "")
                { throw new Exception("Ingrese un nombre de cliente válido."); }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return; }
            try
            { 
                int telefono = int.Parse(txtTelfCliente.Text);
                verificarRegistro(nombre, telefono);
            }
            catch(Exception ex) { MessageBox.Show("Ingrese un número de teléfono válido."); return; }
        }

        private void verificarRegistro(string nombre, int telefono)
        {
            bool registro = verificarTelefono(telefono);
            if(registro == true)
            {
                MessageBox.Show("El cliente ya esta registrado");
            }
            else
            {
                Cliente nuevo = new Cliente("Normal");
                nuevo.Nombre = nombre;
                nuevo.Telefono = telefono;

                String query;
                cmd.Connection = con;
                query = "INSERT INTO Cliente(nombreCompleto, telefono, tipoCliente) VALUES('" + nuevo.Nombre + "','" + nuevo.Telefono + "','" + nuevo.Tipo + "')";
                cmd.CommandText = @query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Registrado");
            }
        }

        private bool verificarTelefono(int telefono)
        {
            DataRow[] foundrow = null;
            int telf = telefono;
            string strSelectCmd = "SELECT * FROM Cliente";
            OleDbDataAdapter objDataAdapter = new OleDbDataAdapter(strSelectCmd, con);
            DataTable ds = new DataTable();
            objDataAdapter.Fill(ds);
            foundrow = ds.Select("telefono = " + telf);
            if (foundrow.Length > 0)
            {
               return true;
            }
            else
            {
               return false;
            }
        }

        private void btnNuevaVenta_Click(object sender, RoutedEventArgs e)
        {
                nuevo.Nombre = txtNombreCliente.Text;
                if(txtTelfCliente.Text != "")
                { nuevo.Telefono = int.Parse(txtTelfCliente.Text); }
                String query;
                cmd.Connection = con;
                query = "INSERT INTO Venta(fechaVenta, totalVenta, nombreCliente) VALUES('" + compra.Fecha + "','" + compra.Total + "','" + nuevo.Nombre + "')";
                cmd.CommandText = @query;
                cmd.ExecuteNonQuery();
                for (int i = 0; i < Productos.Count; i++)
                {
                    query = "INSERT INTO Producto(PrecioUnitario) VALUES('" + Productos[i].PrecioUnitario + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                    query = "INSERT INTO ProductoNormal(nombreProducto,tipoProducto) VALUES('" + Productos[i].NombreProducto + "','" + Productos[i].TipoProducto + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                    query = "INSERT INTO Detalle(nombreProducto,totalProducto,cantidadComprada) VALUES('" + detalles[i].Nombre + "','" + detalles[i].TotalProducto + "','" + detalles[i].Cantidad + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Venta Registrada");
                dtgProducto.Items.Clear();
                dtgDetalle.Items.Clear();
                Productos.Clear();
                detalles.Clear();
                txtCantidadItems.Clear();
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                lblTotalVenta.Content = "";
                numero = 0;
                compra = new Venta();
                nuevo = new Cliente("Normal");
                btnNuevaVenta.IsEnabled = false;
                btnEliminarProducto.IsEnabled = false;
        }

        void conectar()
        {
            try
            {
                Path = Directory.GetCurrentDirectory();
                conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Path + "\\DBtienda.mdb";
                con = new OleDbConnection(conStr);
                con.Open();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); this.Close(); }
        }

        private void btnAgregarTarjeta_Click(object sender, RoutedEventArgs e)
        {
            string tipoTarjeta = cbxTipoTarjeta.Text;
            string valor = cbxValorTarjeta.Text;
            try
            {
                string codigo = txtCodigoTarjeta.Text;
                if(codigo == "")
                { throw new Exception("Ingrese un código de tarjeta válido"); }
                numero++;
                Tarjetas tarjetaNueva = new Tarjetas("Tarjeta", tipoTarjeta, valor, codigo, numero);
                Detalle detallado = new Detalle(tarjetaNueva.TipoTarjeta, 1);
                tarjetaNueva.CalcularPrecioBs();
                tarjetaNueva.CalcularComision();
                detallado.calcularTotal(tarjetaNueva.PrecioBS);
                dtgDetalleCard.Items.Add(tarjetaNueva);
                compra.calcularTotal(detallado.TotalProducto);
                lblTotalCodigos.Content = compra.Total;
                Tarjetas.Add(tarjetaNueva);
                detalles.Add(detallado);
                txtNombreProducto.Clear();
                txtPrecioProducto.Clear();
                txtCantidadItems.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
        }

        private void btnEliminarTarjeta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                eliminar = byte.Parse(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número del producto a Eliminar", "Eliminar Elemento"));
                if(eliminar < 1 || eliminar > dtgDetalleCard.Items.Count)
                { MessageBox.Show("Ingrese un número de la lista de detalle de la compra."); }
                else
                {
                    for (int i = 0; i < Tarjetas.Count; i++)
                    {
                        if (Tarjetas[i].Numero == eliminar)
                        {
                            compra.Total = (compra.Total - detalles[i].TotalProducto);
                            lblTotalVenta.Content = compra.Total;
                            Tarjetas.RemoveAt(i);
                            detalles.RemoveAt(i);
                            dtgDetalleCard.Items.RemoveAt(i);
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show("Ingrese un número de la lista de detalle de la compra."); }
        }

        private void btnVerificarClienteCard_Click(object sender, RoutedEventArgs e)
        {
            verificarCliente(txtNombreClienteCard, txtTelfClienteCard);
        }

        private void btnRegistrarClienteCard_Click(object sender, RoutedEventArgs e)
        {
            string nombre;
            try
            {
                nombre = txtNombreClienteCard.Text;
                if (nombre == "")
                { throw new Exception("Ingrese un nombre de cliente válido."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            try
            {
                int telefono = int.Parse(txtTelfClienteCard.Text);
                verificarRegistro(nombre, telefono);
            }
            catch (Exception ex) { MessageBox.Show("Ingrese un número de teléfono válido."); return; }
        }

        private void btnNuevaVentaCard_Click(object sender, RoutedEventArgs e)
        {
                nuevo.Nombre = txtNombreClienteCard.Text;
                if (txtTelfClienteCard.Text != "")
                { nuevo.Telefono = int.Parse(txtTelfClienteCard.Text); }
                String query;
                cmd.Connection = con;
                query = "INSERT INTO Venta(fechaVenta, totalVenta, nombreCliente) VALUES('" + compra.Fecha + "','" + compra.Total + "','" + nuevo.Nombre + "')";
                cmd.CommandText = @query;
                cmd.ExecuteNonQuery();
                for (int i = 0; i < Tarjetas.Count; i++)
                {
                    query = "INSERT INTO Producto(PrecioUnitario) VALUES('" + Tarjetas[i].PrecioUnitario + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                    query = "INSERT INTO ProductoTarjeta(nombreProducto,tipoTarjeta,valor,codigo,precioBS,comision) VALUES('" + Tarjetas[i].Nombre + "','" + Tarjetas[i].TipoTarjeta + "','" + Tarjetas[i].Valor + "','" + Tarjetas[i].Codigo + "','" + Tarjetas[i].PrecioBS + "','" + Tarjetas[i].Comision + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                    query = "INSERT INTO Detalle(nombreProducto,totalProducto,cantidadComprada) VALUES('" + detalles[i].Nombre + "','" + detalles[i].TotalProducto + "','" + detalles[i].Cantidad + "')";
                    cmd.CommandText = @query;
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Venta Registrada");
                dtgDetalleCard.Items.Clear();
                Tarjetas.Clear();
                detalles.Clear();
                txtCodigoTarjeta.Clear();
                lblTotalCodigos.Content = "";
                numero = 0;
                compra = new Venta();
                nuevo = new Cliente("Normal");
                btnNuevaVentaCard.IsEnabled = false;
                btnEliminarTarjeta.IsEnabled = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            conectar();
            compra = new Venta();
            nuevo = new Cliente("Normal");
            DateTime hoy = DateTime.Now.Date;
            lblFecha.Content = "Hoy es: " + hoy.Day + "/" + hoy.Month + "/" + hoy.Year;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            numero = 0;
            btnNuevaVentaCard.IsEnabled = false;
            btnEliminarTarjeta.IsEnabled = false;
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            numero = 0;
            btnNuevaVenta.IsEnabled = false;
            btnEliminarProducto.IsEnabled = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            con.Close();
        }

        private void txtTelfCliente_KeyDown(object sender, KeyEventArgs e)
        {
            verificar(sender, e);
        }

        private void verificar(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtCantidadItems_KeyDown(object sender, KeyEventArgs e)
        {
            verificar(sender, e);
        }

        private void txtTelfClienteCard_KeyDown(object sender, KeyEventArgs e)
        {
            verificar(sender, e);
        }

        private void txtNombreCliente_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validarTexto(sender, e);
        }

        private void validarTexto(object sender, TextCompositionEventArgs e)
        {
            int character = Convert.ToInt32(Convert.ToChar(e.Text));
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNombreClienteCard_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            validarTexto(sender, e);
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dtgProducto.Items.Count > 0)
            {
                btnNuevaVenta.IsEnabled = true;
                btnEliminarProducto.IsEnabled = true;
            }
        }

        private void textbox1_TextChanged(object sender, DataGridRowEventArgs e)
        {
            if (dtgDetalleCard.Items.Count > 0)
            {
                btnNuevaVentaCard.IsEnabled = true;
                btnEliminarTarjeta.IsEnabled = true;
            }
        }
    }
}
