using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiedadesConstrutor
{
    class Animal
    {

        private string name;
        private string sound;

        public const string Shelter = "A casa do brunão tem espaço para animais";

        public readonly int idNum;

        public void MakeSound()
        {
            Console.WriteLine("{0} fala {1}", name, sound);
        }

        public Anima()
        :this("No Sound","No Name"){}

            public Anima(string name)
            : this(name, "No Sound") { }

        public Anima(string name, string sound)
        {
            SetName(name);
            Sound = sound;

            NumDeAnimais = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 2047586396);
        }

        //getter e setter
        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("nome não pode haver números");
            }
        }

        public string GetName()
        {
            return name;
        }

        //definer getter e setter por propiedades
        public string Sound
        {
            get { return sound; }
            set {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Som é muito longo"); 
                }
                sound = value;  
                    
            }
        }

        public string Propietario { get; set; } = "Sem propietário";

        public static int numDeAnimais = 0;

            public static int NumDeAnimais
        {
            get { return numDeAnimais; }
            set { numDeAnimais += value; }
        }

    }
}
