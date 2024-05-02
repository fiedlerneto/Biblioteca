using BibliotecaJoia.Models.Contracts.Respositories;
using BibliotecaJoia.Models.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace BibliotecaJoia.Models.Respositories
{
    public class LivroRepository : ILivroRepository
    {
        public List<LivroDto> Listar()
        {
<<<<<<< HEAD
           var livros = ContextDataFake.Livros;
            return livros.OrderBy(p => p.Nome).ToList();
=======
            throw new System.NotImplementedException();
            return null;
>>>>>>> fe7ad3bdfc507306f5ca1ebdee14d9511f3a93e2
        }
    }
}
