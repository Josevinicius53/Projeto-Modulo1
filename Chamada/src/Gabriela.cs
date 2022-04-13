using System;
using System.Collections.Generic;

namespace Chamada.src

{
    public class Gabriela : Presenca
    {
        public Gabriela() { }
        public Gabriela(string nome, int numero, string serie) : base(nome, numero, serie) { }
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
    }
}
