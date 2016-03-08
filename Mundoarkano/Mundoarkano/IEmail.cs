using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundoarkano
{
    interface IEmail
    {
        void EnviarEmail(string remitente, string destinatario, string asunto, string cuerpo);
    }
}
