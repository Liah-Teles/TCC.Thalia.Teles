using TCC.Thalia.Teles.Dominio.Features.Servicos;

namespace TCC.Thalia.Teles.Dominio.Features.Atendimentos;

public class Atendimento
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string ClienteCpf { get; set; }
    public DateTime Data { get; set; }
    public List<Servico> Servicos { get; set; }
    public bool Concluido { get; set; }


    public static string CabecalhoCsv => "Id;Cliente;Data;Servicos;Concluido;CPF do Cliente";


    public string ObterMensagemNaoValidado()
    {
        if (string.IsNullOrEmpty(Cliente))
            return $"Cliente é obrigatorio";
        if (string.IsNullOrEmpty(ClienteCpf))
            return $"CPF do cliente é obrigatorio";
        if (Data == default)
            return "Data é obrigatoria";
        if (Servicos == null || Servicos.Count == 0)
            return "Servicos é obrigatorio";

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
            Cliente = colunas[1];
            Data = DateTime.Parse(colunas[2]);

            Servicos = new List<Servico>();

            var listaServicoEmString = colunas[3].Split('|', StringSplitOptions.RemoveEmptyEntries);
            foreach (var servicoString in listaServicoEmString)
            {
                var dadosServico = servicoString.Split(':', StringSplitOptions.RemoveEmptyEntries);
                var servico = new Servico
                {
                    Id = int.Parse(dadosServico[0]),
                    Nome = dadosServico[1],
                    Valor = decimal.Parse(dadosServico[2])
                };
                Servicos.Add(servico);
            }


            Concluido = bool.Parse(colunas[4].ToLower());
            ClienteCpf = colunas[5];

            return true;
        }
        catch
        {
            return false;
        }
    }

    public string ParaLinhaCsv()
    {
        string servicosEmString = "";

        foreach (var servico in Servicos)
        {
            servicosEmString += $"{servico.Id}:{servico.Nome}:{servico.Valor}|";
        }


        return $"{Id};{Cliente};{Data};{servicosEmString};{Concluido};{ClienteCpf}";
    }
}