using System;

namespace Detranplate
{
    class Program
    {
        static void Main(string[] args)
        {
            string brand,
            model,
            plate,
            platefinal;
            
            int manufacture;

            char random;
          
            char[] shift1 = new char[10] {'0', '1', '2','3','4','5','6','7','8','9'};
            char[] shift2 = new char[10] {'A', 'B', 'C','D','E','F','G','H','I','J'};

            Console.WriteLine("Type car's make: (AND HIT ENTER):");
            brand = Console.ReadLine();

            Console.WriteLine("Type the model: (AND HIT ENTER):");
            model = Console.ReadLine();

            Console.WriteLine("Type year of manufacture: (AND HIT ENTER):");
            manufacture = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the plate with ' - ': (AND HIT ENTER):");
            plate = Console.ReadLine();

            platefinal = "";
            for (int i = 0; i < plate.Length; i++)
            {
               random = plate[i];
               
               if (plate[i] == plate[5])
               {
                   random = plate[5];
                    for (int j = 0; j < shift1.Length; j++)
                    {
                        if (random == shift1[j])
                        {
                            random = shift2[j];
                            
                        }
                    }
                      
               } 
               platefinal += random; 
            }

            Console.WriteLine("The car {0} {1} year {2} has as new plate {3}", brand, model, manufacture, platefinal);

        }
    }
}
