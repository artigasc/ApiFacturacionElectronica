using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDatosGuia {
        [DataMember]
        public SunatContribuyente DireccionDestino { get; set; }
        [DataMember]
        public SunatContribuyente DireccionOrigen { get; set; }
        [DataMember]
        public string RucTransportista { get; set; }
        [DataMember]
        public string TipoDocTransportista { get; set; }
        [DataMember]
        public string NombreTransportista { get; set; }
        [DataMember]
        public string NroLicenciaConducir { get; set; }
        [DataMember]
        public string PlacaVehiculo { get; set; }
        [DataMember]
        public string CodigoAutorizacion { get; set; }
        [DataMember]
        public string MarcaVehiculo { get; set; }
        [DataMember]
        public string ModoTransporte { get; set; }
        [DataMember]
        public string UnidadMedida { get; set; }
        [DataMember]
        public decimal PesoBruto { get; set; }

        public SunatDatosGuia()
        {
            DireccionDestino = new SunatContribuyente();
            DireccionOrigen = new SunatContribuyente();
        }
    }
}
