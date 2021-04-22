using System;
using System.Collections.Generic;

namespace P5_Pokedex
{
    public class Party
    {
        List<PokemonCapturado> party = new List<PokemonCapturado>();
        
        public Party()
        {
            // Crear pokemones capturados 

            PokemonCapturado necrozmaParty = new PokemonCapturado (800, "Necrozma",Genero.INDEFINIDO);
            PokemonCapturado liepardParty = new PokemonCapturado (510, "Liepard",Genero.HEMBRA);
            PokemonCapturado thievulParty = new PokemonCapturado (828, "Thievul",Genero.HEMBRA);
            PokemonCapturado machokeParty = new PokemonCapturado (067, "Machoke",Genero.MACHO);
            PokemonCapturado porygonZParty = new PokemonCapturado (067, "Porygon Z",Genero.INDEFINIDO);
            PokemonCapturado charizardParty = new PokemonCapturado (006, "Charizard",Genero.HEMBRA);

            // Crear una lista de pokemon capturados


            // Agragar los pokemon capturados a la lista
            
            party.Add(necrozmaParty);
            party.Add(liepardParty);
            party.Add(thievulParty);
            party.Add(machokeParty);
            party.Add(porygonZParty);
            party.Add(charizardParty);
            
            

        }

    
        
    }
}
