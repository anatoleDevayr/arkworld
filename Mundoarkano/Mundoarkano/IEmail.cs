﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mundoarkano
{
    public interface IEmail
    {
        void EnviarMail(string remitente, string destinatario, string asunto, string cuerpo);
    }
}
