using CSV_Read.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSV_Read
{
    class ClassService : IClassService
    {
        public bool AbrirCSV()
        {
            throw new NotImplementedException();
        }

        public bool EditarCSV()
        {
            throw new NotImplementedException();
        }

        public bool FecharCSV()
        {
            throw new NotImplementedException();
        }

        public string MostrarArquivCSV()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(@"C:\Users\Ruann\OneDrive\Documentos\GitHub\Leitor-de-arquivo-CSV\Config.xml");

            return Doc.GetElementsByTagName("Diretorio")[0].InnerText;
        }
    }
}
