using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public string Objetivo { get; set; }
        public int PlanoCodigo { get; set; }
    }
}
