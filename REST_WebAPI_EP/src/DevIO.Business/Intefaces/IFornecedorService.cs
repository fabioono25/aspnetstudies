using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adicionar(Fornecedor fornecedor);
        Task<bool> Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}