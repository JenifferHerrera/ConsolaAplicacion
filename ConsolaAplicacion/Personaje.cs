internal abstract class Personaje
{
    public string Nombre { get; set; }

    public int estatura { get; set; }

    public string genero { get; set; }

    public bool flaco { get; set; }

    public string genero { get; set; }

    public string color de piel { get; set; }

    public string color de ojos { get; set; }

    public string color de camiseta { get; set; }

    public string color de pantalon { get; set; }

    public byte zapatos { get; set; }

    public string Caminar() 
    {
        var caminar = $"Hola soy {Nombre}, camino hacia la mision";
    }
    public string Saltar() 
    {
        var caminar = $"Hola soy {Nombre}, salto de los precipicios";
    }
    public string Golpear() 
    {
        var caminar = $"Comi espinacas {Nombre}, ahorra tengo fuerzas";
    }
    public string Correr() 
    {
        var caminar = $"Corro de {Nombre}, es mi enemigo";
    }
    public string Volar() 
    {
        var caminar = $"Atrape un dragon {Nombre}, estoy volando al tesoro";
    }

}
