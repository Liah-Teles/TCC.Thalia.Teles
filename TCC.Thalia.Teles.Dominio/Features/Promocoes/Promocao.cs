using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Thalia.Teles.Dominio.Features.Promocoes
{
    public class Promocao
    {
        public int Id { get; set; }
        public decimal Desconto { get; set; }
        public string NomeServico { get; set; }

        public static string CabecalhoCsv => "Id;NomeServico;Desconto";

        public string ObterMensagemNaoValidado()
        {
            if (string.IsNullOrEmpty(NomeServico))
                return $"Nome do serviço é obrigatorio";
            if (Desconto <= 0)
                return "Desconto deve ser um numero positivo valido";

            return "";
        }

        public bool CriarPorLinhaCsv(string linhaCsv)
        {
            try
            {
                if (string.IsNullOrEmpty(linhaCsv))
                    return false;

                string[] colunas = linhaCsv.Split(";", StringSplitOptions.RemoveEmptyEntries);

                if (colunas == null || colunas.Length == 0) return false;

                Id = int.Parse(colunas[0]);
                NomeServico = colunas[1];
                Desconto = decimal.Parse(colunas[2]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ParaLinhaCsv()
        {
            return $"{Id};{NomeServico};{Desconto}";
        }
    }
}
