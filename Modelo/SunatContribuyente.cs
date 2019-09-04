using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatContribuyente {
        [DataMember]
        public string NroDocumento {
            get;
            set;
        }
        [DataMember]
        public string TipoDocumento {
            get;
            set;
        }
        [DataMember]
        public string NombreLegal {
            get;
            set;
        }
        [DataMember]
        public string NombreComercial {
            get;
            set;
        }
        [DataMember]
        public string Ubigeo {
            get;
            set;
        }
        [DataMember]
        public string Direccion {
            get;
            set;
        }
        [DataMember]
        public string Urbanizacion {
            get;
            set;
        }
        [DataMember]
        public string Departamento {
            get;
            set;
        }
        [DataMember]
        public string Provincia {
            get;
            set;
        }
        [DataMember]
        public string Distrito {
            get;
            set;
        }
    }
}
