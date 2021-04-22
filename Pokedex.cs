using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    class Pokedex
    {


        // Metodo constructor
        
        // Crear una lista
        

        // Crear 10 pokemon con el metodo constructor y añadirlos a la lista dentro de un método
        public List<Pokemon> registroPokedex;

        
        public Pokedex()
        {
        registroPokedex = new List<Pokemon>();

        }

        // Busca dentro de los pokemon, el que tenga el id igual al que se proporciona

        bool pokemonEncontrado = false;
        public void BuscarPorId(int id)
        {
        
            for (int i = 0; i < registroPokedex.Count; i++)
            {
                if (registroPokedex[i].id == id)
                {
                    Console.WriteLine("Buscando pokemon....");

                    Console.WriteLine("Pokemon encontrado: " + registroPokedex[i].nombre + "ID: " + registroPokedex[i].id);
               
                    pokemonEncontrado = true;

                    break;
                }
            

            }        
            
            if (!pokemonEncontrado)
            {

                Console.WriteLine("No se encontró ningun pokemon");

            }

        }

        

        public void BuscarPorNombre(string nombre)
        {
            
            bool pokemonEncontrado = false;

            for (int i = 0; i < registroPokedex.Count; i++)
            {
                if (registroPokedex[i].nombre == nombre) 
                {
                    Console.WriteLine("Buscando pokemon....");

                    Console.WriteLine("Pokemon encontrado: " + registroPokedex[i].nombre + "ID:  " +  registroPokedex[i].id);
                
                    pokemonEncontrado = true;

                    break;

                }


            } 

            if(!pokemonEncontrado)
            {

                Console.WriteLine("No se encontro ningun pokemon");

            }

        }

        public void BuscarTodos()
        {

            Console.WriteLine("Mostrando todos los pokemon registrados");

            for(int i = 0; i < registroPokedex.Count; i++)
            {

                Console.WriteLine($"{registroPokedex[i].nombre}ID: {registroPokedex[i].id}");

            }


        }

            
        
            
    }
}