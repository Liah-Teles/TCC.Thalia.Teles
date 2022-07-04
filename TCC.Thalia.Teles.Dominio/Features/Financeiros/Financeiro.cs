using TCC.Thalia.Teles.Dominio.Features.Agendamentos;
using TCC.Thalia.Teles.Dominio.Features.Descontos;

namespace TCC.Thalia.Teles.Dominio.Features.Financeiros
{
    public class Financeiro
    {
        public int Id { get; set; }
        public decimal ValorParcial { get; set; }
        public decimal DescontoAplicado { get; set; }
        public decimal Total { get; set; }
        public Agendamento Agendamento { get; set; }
        public List<Desconto> Descontos { get; set; } = new List<Desconto>();


        public static string CabecalhoCsv => "Id;ValorParcial;DescontoAplicado;Total;Agendamento;Descontos";


        public string ObterMensagemNaoValidado()
        {
            if (ValorParcial > 0)
                return "Valor parcial é obrigatório";
            if (Total > 0)
                return "Valor total é obrigatório";
            if (Agendamento == null)
                return "Agendamento é obrigatório";
            if (Descontos.Count == 0)
                return "Valor total é obrigatório";

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

                var agendamentoTexto = $"{colunas[4]}".Replace("#", ";");
                Agendamento = new Agendamento();
                if (!Agendamento.CriarPorLinhaCsv(agendamentoTexto))
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

            var agendamentoString = Agendamento.ParaLinhaCsv().Replace(";", "#");

            var promocoesString = "";
            foreach (var desconto in Descontos)
            {
                promocoesString += $"{desconto.ParaLinhaCsv().Replace(";", "#")}|";
            }

            return $"{Id};{ValorParcial};{DescontoAplicado};{Total};{agendamentoString};{promocoesString}";
        }

        public void CalculaValoresFinanceiro()
        {
            ValorParcial = 0;
            foreach (var servico in Agendamento.Servicos)
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
