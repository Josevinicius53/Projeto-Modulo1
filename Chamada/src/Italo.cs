using System;
using System.Collections.Generic;

namespace Chamada.src

{
    public class Italo : Presenca
    {
        public Italo() { }
        
        public Italo(string nome, int numero, string serie) : base(nome, numero, serie) { }
        
        public override void Presente(string presente)
        {
            Console.WriteLine($"{presente}");
        }
    }
}