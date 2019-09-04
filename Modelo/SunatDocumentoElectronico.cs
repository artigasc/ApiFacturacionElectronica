using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDocumentoElectronico {
        [DataMember]
        public string IdDocumento { get; set; }
        [DataMember]
        public string TipoDocumento { get; set; }
        [DataMember]
        public SunatContribuyente Emisor { get; set; }
        [DataMember]
        public SunatContribuyente Receptor { get; set; }
        [DataMember]
        public string FechaEmision { get; set; }
        [DataMember]
        public string Moneda { get; set; }
        [DataMember]
        public string TipoOperacion { get; set; }
        [DataMember]
        public decimal Gravadas { get; set; }
        [DataMember]
        public decimal Gratuitas { get; set; }
        [DataMember]
        public decimal Inafectas { get; set; }
        [DataMember]
        public decimal Exoneradas { get; set; }
        [DataMember]
        public decimal DescuentoGlobal { get; set; }
        [DataMember]
        public List<SunatDetalleDocumento> Items { get; set; }
        [DataMember]
        public decimal TotalVenta { get; set; }
        [DataMember]
        public decimal TotalIgv { get; set; }
        [DataMember]
        public decimal TotalIsc { get; set; }
        [DataMember]
        public decimal TotalOtrosTributos { get; set; }
        [DataMember]
        public string MontoEnLetras { get; set; }
        [DataMember]
        public string PlacaVehiculo { get; set; }
        [DataMember]
        public decimal MontoPercepcion { get; set; }
        [DataMember]
        public decimal MontoDetraccion { get; set; }
        [DataMember]
        public List<SunatDatoAdicional> DatoAdicionales { get; set; }
        [DataMember]
        public string TipoDocAnticipo { get; set; }
        [DataMember]
        public string DocAnticipo { get; set; }
        [DataMember]
        public string MonedaAnticipo { get; set; }
        [DataMember]
        public decimal MontoAnticipo { get; set; }
        [DataMember]
        public SunatDatosGuia DatosGuiaTransportista { get; set; }
        [DataMember]
        public List<SunatDocumentoRelacionado> Relacionados { get; set; }
        [DataMember]
        public List<SunatDiscrepancia> Discrepancias { get; set; }
        [DataMember]
        public decimal CalculoIgv { get; set; }
        [DataMember]
        public decimal CalculoIsc { get; set; }
        [DataMember]
        public decimal CalculoDetraccion { get; set; }

        public SunatDocumentoElectronico() {
            Emisor = new SunatContribuyente {
                TipoDocumento = "6" // RUC.
            };
            Receptor = new SunatContribuyente {
                TipoDocumento = "6" // RUC.
            };
            CalculoIgv = 0.18m;
            CalculoIsc = 0.10m;
            CalculoDetraccion = 0.04m;
            Items = new List<SunatDetalleDocumento>();
            DatoAdicionales = new List<SunatDatoAdicional>();
            Relacionados = new List<SunatDocumentoRelacionado>();
            Discrepancias = new List<SunatDiscrepancia>();
            TipoDocumento = "01"; // Factura.
            TipoOperacion = "01"; // Venta Interna.
            Moneda = "PEN"; // Soles.
        }
    }
}
