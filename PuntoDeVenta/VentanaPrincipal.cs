using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using Entidades;
using FluentValidation.Results; //para usar el ValidationResult
using System.Drawing.Printing; //Para trabajar con el método Imprimir Factura
using iTextSharp.text; //Para generar el PDF al facturar
using iTextSharp.text.pdf;
using System.IO;

using MaterialSkin.Controls; //Para cambiar el aspecto del form


namespace PuntoDeVenta
{
    //Form
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        ConexionSQL2 cn = new ConexionSQL2();
        private double subtotal = 0;
        private double total = 0;
        private double desc = 0;
        private string cliente = "";
 
        
        public VentanaPrincipal()
        {
            InitializeComponent();

            txt_impVentaEdit.Text = "0.12";

            txt_impVenta.Text = txt_impVentaEdit.Text;
            txt_descuento.Text = txt_descEdit.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dtg_facturacion.DataSource = dt;

            txt_nofactura.Text = cn.consultaFactura();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();

            txt_empleado.Text = (Empleado.Nombre + " " + Empleado.Apellido);



        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario v1 = new Usuario(); //se crea el objeto del Form Uauario
            this.Hide(); //Se oculta este form
            v1.ShowDialog(); //Abre el form de Usuario
            this.Show(); //Cuando se cierre el form Usuario, va a regresar a la Ventana Principal
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario v2 = new Inventario();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }

        private void abrirFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(CerrarForm);
        }

        private void CerrarForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ImpVentaYDescChanged(object sender, EventArgs e)
        {
            txt_impVenta.Text = txt_impVentaEdit.Text;
            txt_descuento.Text = txt_descEdit.Text;
        }

        private void btn_agregarProducto_Click(object sender, EventArgs e)
        {
            if (txt_cproducto.Text == "" || txt_cantidad.Text == "")
            {
                MessageBox.Show("Codigo producto o Cantidad no ingresado.");
            }
            else
            {
                try
                {
                    var resultado = cn.ConsultaInventario(txt_cproducto.Text);
                    DataRow row = dt.NewRow();

                    row["Codigo"] = txt_cproducto.Text;
                    row["Producto"] = resultado.Item1;
                    row["Precio unidad"] = resultado.Item2;
                    row["Cantidad"] = txt_cantidad.Text;
                    row["Descuento"] = txt_descuento.Text;
                    row["Precio Total"] = (Int32.Parse(txt_cantidad.Text) * double.Parse(resultado.Item2));

                    dt.Rows.Add(row);

                    subtotal = subtotal + (Int32.Parse(txt_cantidad.Text) * double.Parse(resultado.Item2));
                    lbl_subtotal.Text = subtotal.ToString();

                    if (desc == 0)
                    {
                        total = subtotal + (subtotal * double.Parse(txt_impVentaEdit.Text));
                    }
                    else
                    {
                        total = subtotal + (subtotal * double.Parse(txt_impVentaEdit.Text));
                        total = total - (total * desc);
                    }
                    lbl_total.Text = total.ToString();

                }
                catch (Exception x)
                {
                    MessageBox.Show("Error: " + x);
                }
            }
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cCliente.Text == "")
            {
                MessageBox.Show("Codigo no ingresado. Por favor, ingrese un codigo de Cliente");
            }
            else {
                var resultado2 = cn.ConsultaCliente(Convert.ToString(txt_cCliente.Text));
                txt_cliente.Text = resultado2.Item1 + ". DESC: " + resultado2.Item2;
                desc = resultado2.Item2;
                cliente = resultado2.Item1;
            }

        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            var NIT = txt_cCliente.Text;
            var idEmp = Empleado.Id.ToString();
            var ClienteD = desc.ToString();

            List<FacturaDatos> listF = new List<FacturaDatos>();
            FacturaDatos fact = new FacturaDatos();

            fact.NITc = NIT;
            fact.idEmpleado = idEmp;
            fact.ClienteDesc = ClienteD;

            listF.Add(fact);

            foreach (DataRow row in dt.Rows)
            {

                var Cod = row["Codigo"];
                var PrecioU = row["Precio Unidad"];
                var Cant = row["Cantidad"];

                fact.codigo = Convert.ToString(Cod);
                fact.PrecioUnidad = Convert.ToString(PrecioU);
                fact.cantidad = Convert.ToString(Cant);

                listF.Add(fact);
            }



            if (fact != null)
            {
                ValidacionFactura validar = new ValidacionFactura();
                ValidationResult resultado = validar.Validate(fact);
                List<ValidationFailure> error = resultado.Errors;

                if (!resultado.IsValid)
                {
                    foreach (ValidationFailure failure in error)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string NITcliente = Convert.ToString(txt_cCliente.Text);
                int idEmpleado = Convert.ToInt32(Empleado.Id);
                float ClienteDesc = float.Parse(desc.ToString());

                List<Factura> listFact = new List<Factura>();
                List<Factura> listFactEnc = new List<Factura>();
                Factura factura = new Factura();

                factura.Cliente = Convert.ToString(NITcliente);
                factura.IdEmpleado = Convert.ToInt32(idEmpleado);
                factura.ClienteDesc = float.Parse(ClienteDesc.ToString());

                listFactEnc.Add(factura);

                foreach (DataRow row in dt.Rows)
                {
                    Factura factura2 = new Factura();

                    int Codigo = Convert.ToInt32(row["Codigo"]);
                    decimal PrecioUnidad = Convert.ToDecimal(row["Precio Unidad"]);
                    int Cantidad = Convert.ToInt32(row["Cantidad"]);

                    factura2.Codigo = Codigo;
                    factura2.PrecioUnidad = PrecioUnidad;
                    factura2.Cantidad = Cantidad;

                    listFact.Add(factura2);
                }

                cn.InsertarFacturaEncabezado(listFactEnc);
                cn.insertarFactura(listFact);
                MessageBox.Show("Factura creada");

                txt_nofactura.Text = cn.consultaFactura();

                //----------------  Proceso de impresión de factura ------------------------
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps; //Se conectan
                printDocument1.PrintPage += ImprimirFactura;

                printDocument1.Print();

                //---------------   Creación de factura en PDF  ------------------------------
                FacturaPDF(); 
            }
        }

        private void ImprimirFactura(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font font = new System.Drawing.Font("Arial", 12);
            int ancho = 150;
            int y = 20;

            e.Graphics.DrawString("FACTURA", font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            e.Graphics.DrawString("Fecha: "+lbl_fecha.Text, font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
            e.Graphics.DrawString("Factura No. " + cn.ConsultaSelectFacturaPDF(), font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            e.Graphics.DrawString("Empleado: " + Empleado.Nombre + " " + Empleado.Apellido, font, Brushes.Black, new RectangleF(20, y += 25, ancho, 20));
            e.Graphics.DrawString("Cliente: " + cliente, font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            e.Graphics.DrawString("PRODUCTOS: ", font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));

            foreach (DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["Codigo"].ToString() + " " +
                    row["Producto"].ToString() + " " +
                    row["Cantidad"].ToString() + " " +
                    row["Precio Unidad"].ToString() + " " +
                    row["Precio Total"].ToString(),
                    font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            }

            e.Graphics.DrawString("Subtotal: " + subtotal, font, Brushes.Black, new RectangleF(20, y += 25, ancho, 20));
            e.Graphics.DrawString("Total: Q" + total, font, Brushes.Black, new RectangleF(20, y += 20, ancho, 20));
            e.Graphics.DrawString("¡Gracias por su compra!", font, Brushes.Black, new RectangleF(20, y += 40, ancho, 20));
        }

        private void FacturaPDF() 
        {
            //----------------  Proceso de Creación de Factura en PDF   -------------------
            FileStream fs = new FileStream(@"C:\Users\angel\OneDrive\Documentos\Angel\C# proyectos\PuntoDeVenta\Facturas PDF\Factura No " + Convert.ToString(cn.ConsultaSelectFacturaPDF()) + ".pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter wr = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //Definir la fuente
            iTextSharp.text.Font fuenteestandar = new iTextSharp.text.Font(iTextSharp.text.Font.HELVETICA, 12, iTextSharp.text.Font.NORMAL, iTextSharp.text.Color.BLACK);

            //Escribir el encabezado
            doc.Add(new Paragraph("FACTURA"));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Fecha: " + lbl_fecha.Text));
            doc.Add(new Paragraph("Factura No." + cn.ConsultaSelectFacturaPDF()));
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Empleado: " + Empleado.Nombre + " " + Empleado.Apellido));
            doc.Add(new Paragraph("Cliente: " + cliente));
            doc.Add(Chunk.NEWLINE);

            //Creación de título de columnas
            PdfPTable tablaProductos = new PdfPTable(5);
            tablaProductos.WidthPercentage = 100;

            PdfPCell Codigo = new PdfPCell(new Phrase("Código", fuenteestandar));
            Codigo.BorderWidth = 0;
            Codigo.BorderWidthBottom = 0.75f;

            PdfPCell Producto = new PdfPCell(new Phrase("Producto", fuenteestandar));
            Producto.BorderWidth = 0;
            Producto.BorderWidthBottom = 0.75f;

            PdfPCell Cantidad = new PdfPCell(new Phrase("Cantidad", fuenteestandar));
            Cantidad.BorderWidth = 0;
            Cantidad.BorderWidthBottom = 0.75f;

            PdfPCell PrecioUnidad = new PdfPCell(new Phrase("Precio Unidad", fuenteestandar));
            PrecioUnidad.BorderWidth = 0;
            PrecioUnidad.BorderWidthBottom = 0.75f;

            PdfPCell PrecioTotal = new PdfPCell(new Phrase("Precio Total", fuenteestandar));
            PrecioTotal.BorderWidth = 0;
            PrecioTotal.BorderWidthBottom = 0.75f;

            tablaProductos.AddCell(Codigo);
            tablaProductos.AddCell(Producto);
            tablaProductos.AddCell(Cantidad);
            tablaProductos.AddCell(PrecioUnidad);
            tablaProductos.AddCell(PrecioTotal);

            foreach (DataRow row in dt.Rows)
            {
                Codigo = new PdfPCell(new Phrase(row["Codigo"].ToString(), fuenteestandar));
                Codigo.BorderWidth = 0;

                Producto = new PdfPCell(new Phrase(row["Producto"].ToString(), fuenteestandar));
                Producto.BorderWidth = 0;

                Cantidad = new PdfPCell(new Phrase(row["Cantidad"].ToString(), fuenteestandar));
                Cantidad.BorderWidth = 0;

                PrecioUnidad = new PdfPCell(new Phrase(row["Precio Unidad"].ToString(), fuenteestandar));
                PrecioUnidad.BorderWidth = 0;

                PrecioTotal = new PdfPCell(new Phrase(row["Precio Total"].ToString(), fuenteestandar));
                PrecioTotal.BorderWidth = 0;

                tablaProductos.AddCell(Codigo);
                tablaProductos.AddCell(Producto);
                tablaProductos.AddCell(Cantidad);
                tablaProductos.AddCell(PrecioUnidad);
                tablaProductos.AddCell(PrecioTotal);
            }

            doc.Add(tablaProductos);

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("Subtotal: " + subtotal));
            doc.Add(new Paragraph("Total: " + total));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(new Paragraph("¡Gracias por su compra!"));

            doc.Close();
            wr.Close();

            MessageBox.Show("Factura creada en PDF","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_nofactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_empleado_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_idEmpleadoC_Click(object sender, EventArgs e)
        {
        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes v3 = new Clientes();
            this.Hide();
            v3.ShowDialog();
            this.Show();
        }

        private void historialDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialFacturacion v4 = new HistorialFacturacion();
            this.Hide();
            v4.ShowDialog();
            this.Show();
        }

        
    }
}
