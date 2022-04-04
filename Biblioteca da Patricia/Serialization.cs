using System.Collections.Generic;

namespace Biblioteca_da_Patricia
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Subgenero { get; set; }
        public string Pratileira { get; set; }
        public int Ano { get; set; }
        public bool Lido { get; set; }
        
    }

    public class RootObject
    {
        public List<Livro> Livros { get; set; }
    }
}
