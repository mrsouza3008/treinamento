using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MRS.Api
{
    public class SettingsJWT
    {
        public string Secret { get; set; } // segredo

        public int ExpiracaoHoras { get; set; } // Quantas horas leva até expiracao

        public string Emissor { get; set; }  // QUem emitiu (API)

        public string ValidoEm { get; set; } // Em qual URL é valido
    }
}
