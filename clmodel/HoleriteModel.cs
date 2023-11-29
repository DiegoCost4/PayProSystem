using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class HoleriteModel
    {
        // Membros da classe HoleriteModel
        public string NomeFuncionario { get; set; }

        public double SubtotalProventos { get; set; }
        public Dictionary<string, double> Proventos { get; } = new Dictionary<string, double>();
        public Dictionary<string, double> Descontos { get; } = new Dictionary<string, double>();
        public double SalarioLiquido { get; set; }

        public double SubtotalDescontos { get; set; }
        public double TotalLiquido { get; set; }

        // Campos adicionados para corresponder à API Java SpringBoot
        public double ImpostoRenda { get; set; }
        public double INSS { get; set; }
        public float HorasExtrasTrabalhadas { get; set; }
        public double SalarioTotal { get; set; }

        // Outros membros, se houver
    }
}
