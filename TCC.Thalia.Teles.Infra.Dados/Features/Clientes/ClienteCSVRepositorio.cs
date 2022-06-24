using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Thalia.Teles.Dominio.Features.Clientes;

namespace TCC.Thalia.Teles.Infra.Dados.Features.Clientes
{
    public class ClienteCSVRepositorio : ContratoClienteRepositorio
    {
        private object _aguardarExecucao = new object();
        private string _localizacaoCsv;

        public ClienteCSVRepositorio(string localizacaoCsv)
        {
            _localizacaoCsv = $"{localizacaoCsv}\\Clientes.csv";
        }

        public void Atualizar(Cliente cliente)
        {
            var clientes = ObterTodos();

            var csvCliente = clientes.FirstOrDefault(cli => cli.Id == cliente.Id);

            if (csvCliente != null)
            {
                clientes.Remove(csvCliente);

                csvCliente.Nome = cliente.Nome;
                csvCliente.Celular = cliente.Celular;
                csvCliente.Cpf = cliente.Cpf;
                csvCliente.Endereco = cliente.Endereco;

                clientes.Add(csvCliente);

                SalvarClientes(clientes);
            }
        }

        public void Deletar(int id)
        {
            var clientes = ObterTodos();

            var cliente = clientes.FirstOrDefault(cli => cli.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                SalvarClientes(clientes);
            }
        }

        public Cliente ObterPorId(int id)
        {
            var clientes = ObterTodos();

            return clientes.FirstOrDefault(cliente => cliente.Id == id);
        }

        public List<Cliente> ObterTodos()
        {
            lock (_aguardarExecucao)
            {
                var listaParaRetornar = new List<Cliente>();
                try
                {
                    var existeArquiv = File.Exists(_localizacaoCsv);

                    if (!existeArquiv)
                    {
                        var stream = File.Create(_localizacaoCsv);
                        stream.Close();

                        return listaParaRetornar;
                    }

                    var linhasCsv = File.ReadAllLines(_localizacaoCsv);

                    for (int i = 1; i < linhasCsv.Length; i++)
                    {
                        var cliente = new Cliente();

                        if (cliente.CriarPorLinhaCsv(linhasCsv[i]))
                        {
                            listaParaRetornar.Add(cliente);
                        }
                    }


                    return listaParaRetornar.OrderBy(cliente => cliente.Id).ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado ao obter clientes", ex);
                }
            }
        }

        public void Salvar(Cliente cliente)
        {
            var clientes = ObterTodos();

            if (clientes.Any(cli => cli.Cpf == cliente.Cpf))
            {
                throw new Exception("Já existe um usuario com o documento informado");
            }

            var ultimoCliente = clientes.LastOrDefault();

            var ultimoId = 1;

            if (ultimoCliente != null)
            {
                ultimoId = ultimoCliente.Id + 1;
            }

            cliente.Id = ultimoId;

            clientes.Add(cliente);

            SalvarClientes(clientes);
        }
        private void SalvarClientes(List<Cliente> clientes)
        {
            try
            {
                lock (_aguardarExecucao)
                {
                    var existeArquiv = File.Exists(_localizacaoCsv);

                    if (!existeArquiv)
                    {
                        var arquivo = File.Create(_localizacaoCsv);
                        arquivo.Close();
                    }

                    var linhasCsv = new List<string>();
                    linhasCsv.Add(Cliente.CabecalhoCsv);

                    foreach (var cliente in clientes)
                    {
                        linhasCsv.Add(cliente.ParaLinhaCsv());
                    }

                    File.WriteAllLines(_localizacaoCsv, linhasCsv);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao salvar clientes", ex);
            }
        }
    }
}
