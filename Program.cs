using System;

namespace P5_Pokedex
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("------Pokemon edición Negro - Naranja------");

            Console.WriteLine("");

            Pokedex pokedex = new Pokedex();
            
            Pokemon necrozma = new Pokemon(800, "Necrozma");
            Pokemon charizard = new Pokemon(006, "Charizard");
            Pokemon porygonZ = new Pokemon(474, "Porygon-Z");        
            Pokemon mightYena = new Pokemon(262, "Mightyena");
            Pokemon mareep = new Pokemon(179, "Mareep");
            Pokemon articuno = new Pokemon(144, "Articuno");
            Pokemon machoke = new Pokemon(067, "Machoke");
            Pokemon liepard = new Pokemon(510, "Liepard ");
            Pokemon murkrow = new Pokemon(198, "Murkrow  ");
            Pokemon thievul = new Pokemon(828, "Thievul  ");
            
            pokedex.registroPokedex.Add(necrozma);
            pokedex.registroPokedex.Add(charizard);
            pokedex.registroPokedex.Add(porygonZ);
            pokedex.registroPokedex.Add(mightYena);
            pokedex.registroPokedex.Add(mareep);
            pokedex.registroPokedex.Add(articuno);
            pokedex.registroPokedex.Add(machoke);
            pokedex.registroPokedex.Add(liepard);
            pokedex.registroPokedex.Add(murkrow);
            pokedex.registroPokedex.Add(thievul);             


            // Buscar pokemon por ID
                                     
            pokedex.BuscarPorId(800);

            Console.WriteLine("");
            
            // Buscar pokemon por nombre

            pokedex.BuscarPorNombre("Charizard");

            Console.WriteLine("");

            // Buscar Todos los pokemon

            pokedex.BuscarTodos();
              

            
        }

    }

}