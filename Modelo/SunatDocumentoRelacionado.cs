using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDocumentoRelacionado {
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
    }
}
