namespace TCC.Thalia.Teles.Dominio.Features.Servicos
{
    public class Servico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public static string CabecalhoCsv => "Id;Nome;Valor";

        public string ObterMensagemNaoValidado()
        {
            if (string.IsNullOrEmpty(Nome))
                return "Nome do serviço é obrigatório";
            if (Valor <= 0)
                return "Valor deve ser um número positivo válido";

            Nome = Nome.Replace(";", ",");

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
                Nome = colunas[1];
                Valor = decimal.Parse(colunas[2]);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ParaLinhaCsv()
        {
            return $"{Id};{Nome};{Valor}";
        }
    }
}
