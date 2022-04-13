using System;
namespace Chamada.src
{
    public class Presenca
    {
        public string Nome { get; set; }
        public int Numero { get; set; }
        public string Serie { get; set; }
        //public char P { get; set; }

        //public char F { get; set;}

        public Presenca() { }

        public Presenca(string nome, int numero, string serie)
        {
            Nome = nome;
            Numero = numero;
            Serie = serie;
        }
        public virtual void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }


    }

}