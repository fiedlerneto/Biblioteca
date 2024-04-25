using BibliotecaJoia.Models.Dtos;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Contracts.Respositories
{
    public interface ILivroRepository
    {
        List<LivroDto> Listar();
    }
}
