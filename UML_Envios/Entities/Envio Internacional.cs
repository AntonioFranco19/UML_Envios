namespace UML_Envios.Entities;

public class Envio_Internacional : Envio
{
    public string CodigoAduana {get; set;}
    public string PaisOrigen { get; set; }
    public string PaisDestino { get; set; }
}