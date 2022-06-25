using TCC.Thalia.Teles.Dominio.Features.Atendimentos;
using TCC.Thalia.Teles.Dominio.Features.Descontos;

namespace TCC.Thalia.Teles.Dominio.Features.Financeiros
{
    public class Financeiro
    {
        public int Id { get; set; }
        public decimal ValorParcial { get; set; }
        public decimal DescontoAplicado { get; set; }
        public decimal Total { get; set; }
        public Atendimento Atendimento { get; set; }
        public List<Desconto> Descontos { get; set; } = new List<Desconto>();


        public static string CabecalhoCsv => "Id;ValorParcial;DescontoAplicado;Total;Atendimento;Descontos";


        public string ObterMensagemNaoValidado()
        {
            if (ValorParcial > 0)
                return "Valor parcial é obrigatorio";
            if (Total > 0)
                return "Valor total é obrigatorio";
            if (Atendimento == null)
                return "Atendimento é obrigatorio";
            if (Descontos.Count == 0)
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

                if (Descontos == null)
                    Descontos = new List<Desconto>();


                if(colunas.Length == 6)
                {
                    var promocoesTexto = $"{colunas[5]}".Split('|', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var descontoTexto in promocoesTexto)
                    {
                        var desconto = new Desconto();

                        if (!desconto.CriarPorLinhaCsv(descontoTexto.Replace("#", ";")))
                            return false;

                        Descontos.Add(desconto);
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
            foreach (var desconto in Descontos)
            {
                promocoesString += $"{desconto.ParaLinhaCsv().Replace(";", "#")}|";
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
            foreach (var desconto in Descontos)
            {
                DescontoAplicado += desconto.Valor;
            }

            Total = ValorParcial - DescontoAplicado;
        }
    }
}
