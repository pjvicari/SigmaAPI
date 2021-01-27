using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APISigmaSystek.wsSigma7;

namespace APISigmaSystek.Mocks
{
    public interface WsInt_DevKitSoapClient
    {
        string DEVKIT_CreacionCasos(string parm);
        string DEVKIT_ConsultaCasos(string parm);
    }
    public partial class WsInt_DevKitSoapClientI : WsInt_DevKitSoapClient
    {
        private string xmlResultado;
        public WsInt_DevKitSoapClientI(string xmlResultado)
        {
            this.xmlResultado = xmlResultado;
        }
        public string DEVKIT_CreacionCasos(string parm)
        {
            return xmlResultado;
        }

        public string DEVKIT_ConsultaCasos(string parm)
        {
            return xmlResultado;
        }
    }
}
