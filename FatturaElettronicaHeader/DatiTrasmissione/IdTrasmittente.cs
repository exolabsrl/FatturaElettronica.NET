﻿using System.Xml;
using FatturaElettronica.Common;

namespace FatturaElettronica.FatturaElettronicaHeader.DatiTrasmissione
{
    public class IdTrasmittente : IdFiscaleIVA
    {
        public IdTrasmittente() { }
        public IdTrasmittente(XmlReader r) : base(r) { }
    }
}
