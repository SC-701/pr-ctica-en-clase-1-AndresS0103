namespace Abstracciones.Modelos
{
    public class Perfil
    {
        public Guid IdPersona { get; set; }
        public string? Video { get; set; }
    }

    //Hola
    public class PerfilBD : Perfil
    {        
        public Guid? Curriculum { get; set; }
        public Guid? Foto { get; set; }

    }
    public class PerfilRequest:Perfil
    {
        public DocumentoContenido? Curriculum { get; set; }
        public DocumentoContenido? Foto { get; set; }

    }
}
