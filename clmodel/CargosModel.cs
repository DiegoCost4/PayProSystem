using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace clmodel
{
    public class CargosModel
    {
        private int _id;
        private string _cargos;

        public int Id { get => _id; set => _id = value; }
        public string Cargo { get => _cargos; set => _cargos = value; }
    }
}
