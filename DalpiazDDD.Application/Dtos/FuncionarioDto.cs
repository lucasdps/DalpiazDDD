﻿using DalpiazDDD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalpiazDDD.Application.Dtos
{
    public class FuncionarioDto
    {
        public static decimal SalarioMinimo = 1000;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public int AreaAtuacao { get; set; }
        public int Cargo { get; set; }
        public string SalarioBruto { get; set; }
        public string DataAdmissao { get; set; }

        


    }
}