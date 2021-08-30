using CSV_Read.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSV_Read
{
    class ClassService : IClassService
    {

        string file;

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
            file = "";
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Title = "Select A File";
                openDialog.Filter = "Excel (*.xlsx)|*.xlsx";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    file = openDialog.FileName;
                }
            }
            catch (Exception e)
            {
                StreamWriter vWriter = new StreamWriter($@"{AppDomain.CurrentDomain.BaseDirectory}/LOG.txt");

                vWriter.WriteLine("MostrarArquivCSV : " + e + "" + DateTime.Now.ToString());
                vWriter.Flush();
                vWriter.Close();
            }

            return file;
        }
    }
}
