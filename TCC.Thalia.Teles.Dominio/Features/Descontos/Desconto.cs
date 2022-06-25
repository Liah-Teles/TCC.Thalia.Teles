namespace TCC.Thalia.Teles.Dominio.Features.Descontos
{
    public class Desconto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string NomeServico { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }

        public static string CabecalhoCsv => "Id;Nome do servico;Desconto;Data inicial;Data final";

        public string ObterMensagemNaoValidado()
        {
            if (string.IsNullOrEmpty(NomeServico))
                return $"Nome do serviço é obrigatorio";
            if (DataInicio == default)
                return $"Data de inicio é obrigatoria";
            if (DataFinal == default)
                return $"Data final é obrigatoria";
            if (Valor <= 0)
                return "Desconto deve ser um numero positivo valido";

            NomeServico = NomeServico.Replace(";", ",");

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
                Valor = decimal.Parse(colunas[2]);
                DataInicio = DateTime.Parse(colunas[3]);
                DataFinal = DateTime.Parse(colunas[4]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ParaLinhaCsv()
        {
            return $"{Id};{NomeServico};{Valor};{DataInicio};{DataFinal}";
        }
    }
}
