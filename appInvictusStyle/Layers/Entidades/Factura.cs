using ServicioBCCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.InvictusStyle.Layers.Entidades
{
    class Factura
    {
        public string ID { set; get; }
        public DateTime Fecha { set; get; }
        public string ID_Cliente { set; get; }

        public List<DetalleFactura> _ListaFacturaDetalle { get; } = new List<DetalleFactura>();

        public void AddDetalle(DetalleFactura pFacturaDetalle) {
            _ListaFacturaDetalle.Add(pFacturaDetalle);
        }

        /// <summary>
        /// Metodo que calcula el descuento
        /// </summary>
        /// <param name="id_descuentoArticulo"></param>
        /// <param name="id_tipoCliente"></param>
        /// <returns>valor de descuento</returns>
        public double calcularDescuento(string id_descuentoArticulo, string id_tipoCliente)
        {
            double descuentoFrecuente = 0.05;
            double descuentoDiamante = 0.1;


            double totalDescuento = 0;

            if(id_descuentoArticulo == "1" && id_tipoCliente == "2")
            {
                totalDescuento = calcularSubtotal() * descuentoFrecuente;
            }
            if(id_descuentoArticulo == "2" && id_tipoCliente == "3")
            {
                totalDescuento = calcularSubtotal() * descuentoDiamante;
            }
            return totalDescuento;
            
        }

        /// <summary>
        /// Metodo que calcula el iva
        /// </summary>
        /// <returns>valor de iva</returns>
        public double calcularIVA()
        {
            return _ListaFacturaDetalle.Sum(f => calcularSubtotal() * 0.13);
        }

        /// <summary>
        /// Metodo que calcula el subtotal
        /// </summary>
        /// <returns>valor del subtotal</returns>
        public double calcularSubtotal()
        {           
            return _ListaFacturaDetalle.Sum(f => f.Cantidad * f.Subtotal);
        }

        /// <summary>
        /// Metodo que calcula el descuento en dolares
        /// </summary>
        /// <param name="des"></param>
        /// <param name="precioDolar"></param>
        /// <returns>valor del descuento en dolares</returns>
        public double calcularDescuentoDolares(double des, double precioDolar)
        {
            return des / precioDolar;
        }

        /// <summary>
        /// Metodo que calcula el iva en dolares
        /// </summary>
        /// <param name="iva"></param>
        /// <param name="precioDolar"></param>
        /// <returns>valor del iva en dolares</returns>
        public double calcularIVADolares(double iva, double precioDolar)
        {
            return iva / precioDolar;
        }

        /// <summary>
        /// Metodo que calcula el subtotal en dolares
        /// </summary>
        /// <param name="sub"></param>
        /// <param name="precioDolar"></param>
        /// <returns>valor del subtotal en dolares</returns>
        public double calcularSubtotalDolares(double sub, double precioDolar)
        {
            return sub / precioDolar;
        }
    }
}
