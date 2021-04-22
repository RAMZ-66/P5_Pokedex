namespace P5_Pokedex
{
    public enum Genero
    {
        MACHO,
        HEMBRA,
        INDEFINIDO

    }
    class PokemonCapturado : Pokemon
    {


        public Genero genero;



        public PokemonCapturado(int id, string nombre, Genero genero) : base (id, nombre)
        {
            
            this.id = id;

            this.nombre = nombre;

            this.genero = genero;


        }

                
    
    }
}