using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDiscrepancia {
        [DataMember]
        public string NroReferencia {
            get;
            set;
        }
        [DataMember]
        public string Tipo {
            get;
            set;
        }
        [DataMember]
        public string Descripcion {
            get;
            set;
        }
    }
}
