using DalpiazDDD.Application.Dtos;
using DalpiazDDD.Application.Interfaces.Mappers;
using DalpiazDDD.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalpiazDDD.Application.Mappers
{
    public class MapperFuncionario : IMapperFuncionario
    {
        private IList<FuncionarioDto> funcionarioDtos = new List<FuncionarioDto>();

        public Funcionario MapperDtoToEntity(FuncionarioDto funcionarioDto)
        {
            //Convertendo salário bruto para decimal
            string valor = funcionarioDto.SalarioBruto;
            // or i.e. string amount = "12,33";

            var c = System.Threading.Thread.CurrentThread.CurrentCulture;
            var s = c.NumberFormat.CurrencyDecimalSeparator;

            valor = valor.Replace(",", s);
            valor = valor.Replace(".", s);

            decimal valorConvertido = Convert.ToDecimal(valor);

            var funcionario = new Funcionario()
            {
                Id = funcionarioDto.Id,
                AreaAtuacao = funcionarioDto.AreaAtuacao,
                Cargo = funcionarioDto.Cargo,
                DataAdmissao = Convert.ToDateTime( funcionarioDto.DataAdmissao),
                Matricula = funcionarioDto.Matricula,
                SalarioBruto = valorConvertido,
                Nome = funcionarioDto.Nome
            };

            return funcionario;
        }

        public FuncionarioDto MapperEntityToDto(Funcionario funcionario)
        {
            var funcionarioDto = new FuncionarioDto
            { 
                Id=funcionario.Id,
                Nome= funcionario.Nome,
                Matricula= funcionario.Matricula,
                Cargo = funcionario.Cargo,
                AreaAtuacao = funcionario.AreaAtuacao,
                SalarioBruto= funcionario.SalarioBruto.ToString(),
                DataAdmissao = funcionario.DataAdmissao.ToShortDateString()
            };

            return funcionarioDto;
        }

        public IEnumerable<FuncionarioDto> MapperListFuncionariosDto(IEnumerable<Funcionario> funcionarios)
        {
            var dto = funcionarios.Select(funcionario =>
                new FuncionarioDto
                {
                    Id = funcionario.Id,
                    Nome = funcionario.Nome,
                    Matricula = funcionario.Matricula,
                    Cargo = funcionario.Cargo,
                    AreaAtuacao = funcionario.AreaAtuacao,
                    SalarioBruto = funcionario.SalarioBruto.ToString(),
                    DataAdmissao = funcionario.DataAdmissao.ToShortDateString()
                });

            return dto;
        }
    }
}
