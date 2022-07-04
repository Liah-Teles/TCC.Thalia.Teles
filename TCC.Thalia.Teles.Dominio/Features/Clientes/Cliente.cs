namespace TCC.Thalia.Teles.Dominio.Features.Clientes;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Celular { get; set; }
    public string Endereco { get; set; }
    public string Cpf { get; set; }
    public static string CabecalhoCsv => "Id;Nome;Celular;CPF;Endereço";


    public string ObterMensagemNaoValidado()
    {
        if (string.IsNullOrEmpty(Nome))
            return $"Nome é obrigatório";

        if (string.IsNullOrEmpty(Celular))
            return "Celular é obrigatório";

        var celularSemCaracteresApenasNumeros = Celular.Replace("(", "").Replace(")", "").Replace("-", "").Trim();

        if(celularSemCaracteresApenasNumeros.Count() != 12)
            return "Celular inválido";

        if (string.IsNullOrEmpty(Endereco))
            return "Endereço é obrigatório";
        if (string.IsNullOrEmpty(Cpf))
            return "CPF é obrigatório";
        if(!ValidadorCPF.Valida(Cpf))
            return "CPF não é válido";

        Nome = Nome.Replace(";", ",");
        Celular = Celular.Replace(";", ",");
        Cpf = Cpf.Replace(";", ",");
        Endereco = Endereco.Replace(";", ",");

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
            Celular = colunas[2];
            Cpf = colunas[3];
            Endereco = colunas[4];

            return true;
        }
        catch
        {
            return false;
        }
    }

    public string ParaLinhaCsv()
    {
        return $"{Id};{Nome};{Celular};{Cpf};{Endereco}";
    }
}