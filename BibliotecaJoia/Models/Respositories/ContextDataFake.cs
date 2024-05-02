using BibliotecaJoia.Models.Dtos;
using System;
using System.Collections.Generic;

namespace BibliotecaJoia.Models.Respositories
{
    public static class ContextDataFake
    {
        public static List<LivroDto> Livros;

        static ContextDataFake()
        {
            Livros = new List<LivroDto>();
            InitializeDate();
        }

        private static void InitializeDate()
        {
            var livro = new LivroDto("Conhecimento", "Norton", "NN");
            Livros.Add(livro);

            livro = new LivroDto("Reconhecimento", "Toresant", "TT");
            Livros.Add(livro);
            livro = new LivroDto("Impedimento", "Tramontini", "TR");
            Livros.Add(livro);
            livro = new LivroDto("Sucesso", "Fiedler", "FF");
            Livros.Add(livro);
        }
    }
}
