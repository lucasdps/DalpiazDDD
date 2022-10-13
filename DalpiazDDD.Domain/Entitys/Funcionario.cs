using DalpiazDDD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalpiazDDD.Domain.Entitys
{
    public class Funcionario 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int AreaAtuacao { get; set; }
        public int Cargo { get; set; }
        public decimal SalarioBruto { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataCadastro { get; set; }

     


    }
}
