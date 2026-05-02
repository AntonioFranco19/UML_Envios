namespace UML_Envios.Entities;

public abstract class Envio
{
    public string Codigo { get; set; }
    public string Direccion { get; set; }
    public double Peso { get; set; }
    public string DNIRepartidor { get; set; }
}