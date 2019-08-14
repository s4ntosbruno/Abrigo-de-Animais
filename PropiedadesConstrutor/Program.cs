using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Anima gato = new Anima();

            gato.SetName("pelota");
            gato.Sound="meow";

            Console.WriteLine("O gato se chama {0} e faz {1}", gato.GetName(), gato.Sound);

            gato.Propietario = "Brunão";

            Console.WriteLine("O dono do {0} é o {1}", gato.GetName(), gato.Propietario);

            Console.WriteLine("O id do {0} é {1}", gato.GetName(), gato.idNum);

            Anima dog = new Anima();

            Console.WriteLine("# numero de animais: {0}", Anima.NumDeAnimais);



            Console.ReadLine();
        }
    }
}
