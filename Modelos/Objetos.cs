public enum TipoEntidad{
    Serie = 'S',
    Pelicula = 'P',
    Libro = 'L'
}

public class SeriePeliculaLibro{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";
    public TipoEntidad Tipo {get; set;} = TipoEntidad.Serie;
    public string Pais {get; set;} = "";
    public string Idioma {get; set;} = "";
    public string FotoUrl {get; set;} = "";
    public string Resumen {get; set;} = "";

//Relacion con los personajes
public List<Personaje> Personajes {get; set; } = new List<Personaje>();

}

public class Personaje{
    public int Id {get; set;}
    public string Nombre {get; set;} = "";
    public string Apodo {get; set;} = "";
    public string Raza {get; set;} = "";
    public string FotoUrl {get; set;} = "";
    public int Edad {get; set;} = 0;
    public string PoderCaracteristico {get; set;} = "";

    // Relacionado con SeriePeliculaLibro
    public int SeriePeliculaLibroId {get; set; }
    public SeriePeliculaLibro seriePeliculaLibro {get; set; } = null!;
}
