namespace clmodel
{
    public class FuncionarioModel
    {
        private int _id;
        private string _name;
        private decimal _cpf;
        private string _adress;
        private string _phone;
        private string _office;
        private float _salary;
        private string _observation;
        private double _salarioLiquido;
        private double _impostoRenda;
        private double _inss;
        private float _horasExtrasTrabalhadas;
        private double _salarioTotal;
        private string _tipo;
        private DateTime _dtInicio;
        private DateTime _dtFinal;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; } 
        public decimal Cpf { get => _cpf; set => _cpf = value; } 
        public string Adress { get => _adress; set => _adress = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Office { get => _office; set => _office = value; }
        public float Salary { get => _salary; set => _salary = value; }
        public string Observation { get => _observation; set => _observation = value; }
        public double SalarioLiquido { get => _salarioLiquido; set => _salarioLiquido = value; }
        public double ImpostoRenda { get => _impostoRenda; set => _impostoRenda = value; }
        public double Inss { get => _inss; set => _inss = value; }
        public float HorasExtrasTrabalhadas { get => _horasExtrasTrabalhadas; set => _horasExtrasTrabalhadas = value; }
        public double SalarioTotal { get => _salarioTotal; set => _salarioTotal = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public DateTime DtInicio { get => _dtInicio; set => _dtInicio = value; }
        public DateTime DtFinal { get => _dtFinal; set => _dtFinal = value; }
    }
}