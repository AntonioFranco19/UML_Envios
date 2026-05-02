using UML_Envios.Entities;

namespace UML_Envios.Control;

public class GestorLogistica
{
    public List<Envio> Pedidos { get; set; }
    public Repartidor Repartidor { get; set; }

    public void CalularCoste()
    {
        
    }
}