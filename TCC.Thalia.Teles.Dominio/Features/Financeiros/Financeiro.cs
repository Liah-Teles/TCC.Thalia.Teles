using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Promocoes;

namespace TCC.Thalia.Teles.Dominio.Features.Financeiros
{
    public class Financeiro
    {
        public int Id { get; set; }
        public decimal ValorParcial { get; set; }
        public decimal DescontoAplicado { get; set; }
        public decimal Total { get; set; }
        public Atendimento Atendimento { get; set; }
        public List<Promocao> Promocoes { get; set; } = new List<Promocao>();


        public static string CabecalhoCsv => "Id;ValorParcial;DescontoAplicado;Total;Atendimento;Promocoes";


        public string ObterMensagemNaoValidado()
        {
            if (ValorParcial > 0)
                return "Valor parcial é obrigatorio";
            if (Total > 0)
                return "Valor total é obrigatorio";
            if (Atendimento == null)
                return "Atendimento é obrigatorio";
            if (Promocoes.Count == 0)
                return "Valor total é obrigatorio";

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
                ValorParcial = decimal.Parse(colunas[1]);
                DescontoAplicado = decimal.Parse(colunas[2]);
                Total = decimal.Parse(colunas[3]);

                var atendimentoTexto = $"{colunas[4]}".Replace("#", ";");
                Atendimento = new Atendimento();
                if (!Atendimento.CriarPorLinhaCsv(atendimentoTexto))
                    return false;

                if (Promocoes == null)
                    Promocoes = new List<Promocao>();


                if(colunas.Length == 6)
                {
                    var promocoesTexto = $"{colunas[5]}".Split('|', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var promocaoTexto in promocoesTexto)
                    {
                        var promocao = new Promocao();

                        if (!promocao.CriarPorLinhaCsv(promocaoTexto.Replace("#", ";")))
                            return false;

                        Promocoes.Add(promocao);
                    }
                }


                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ParaLinhaCsv()
        {
            CalculaValoresFinanceiro();

            var atendimentoString = Atendimento.ParaLinhaCsv().Replace(";", "#");

            var promocoesString = "";
            foreach (var promocao in Promocoes)
            {
                promocoesString += $"{promocao.ParaLinhaCsv().Replace(";", "#")}|";
            }

            return $"{Id};{ValorParcial};{DescontoAplicado};{Total};{atendimentoString};{promocoesString}";
        }

        public void CalculaValoresFinanceiro()
        {
            ValorParcial = 0;
            foreach (var servico in Atendimento.Servicos)
            {
                ValorParcial += servico.Valor;
            }

            DescontoAplicado = 0;
            foreach (var promocao in Promocoes)
            {
                DescontoAplicado += promocao.Desconto;
            }

            Total = ValorParcial - DescontoAplicado;
        }
    }
}
