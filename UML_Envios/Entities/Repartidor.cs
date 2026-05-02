namespace UML_Envios.Entities;

public class Repartidor
{
    public string Dni { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public List<Envio> Pedidos { get; set; }

    public void ActualizarEstado()
    {
        
    }
}