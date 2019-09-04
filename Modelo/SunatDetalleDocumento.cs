using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDetalleDocumento {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public decimal Cantidad { get; set; }
        [DataMember]
        public string UnidadMedida { get; set; }
        [DataMember]
        public string CodigoItem { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public decimal PrecioUnitario { get; set; }
        [DataMember]
        public decimal PrecioReferencial { get; set; }
        [DataMember]
        public string TipoPrecio { get; set; }
        [DataMember]
        public string TipoImpuesto { get; set; }
        [DataMember]
        public decimal Impuesto { get; set; }
        [DataMember]
        public decimal ImpuestoSelectivo { get; set; }
        [DataMember]
        public decimal OtroImpuesto { get; set; }
        [DataMember]
        public decimal Descuento { get; set; }
        [DataMember]
        public decimal TotalVenta { get; set; }
        [DataMember]
        public decimal Suma { get; set; }

        public SunatDetalleDocumento() {
            Id = 1;
            UnidadMedida = "NIU";
            TipoPrecio = "01";
            TipoImpuesto = "10";
        }
    }
}
