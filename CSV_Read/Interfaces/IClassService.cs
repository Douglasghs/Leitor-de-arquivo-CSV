using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Read.Interfaces
{
    public interface IClassService
    {
        public bool AbrirCSV();
        public bool FecharCSV();
        public bool EditarCSV();
    }
}
