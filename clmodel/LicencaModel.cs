using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class LicencaModel
    {
        private long _id;
        private string _tipo;
        private string _descricao;


        public long Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }

    }
}
