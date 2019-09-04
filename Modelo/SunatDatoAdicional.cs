using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Galac.Administrativo.FactElecApi {
    public class SunatDatoAdicional {
        [DataMember]
        public string Codigo {
            get;
            set;
        }
        [DataMember]
        public string Contenido {
            get;
            set;
        }
    }
}
