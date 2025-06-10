namespace controlDeTareas
{
    public class Tarea
    {
        private int tareaId;
        private string descripcion;
        private int duracion;

        public Tarea(int tareaId, string descripcion, int duracion)
        {
            this.tareaId = tareaId;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public int TareaId { get => tareaId; set => tareaId = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }

    public enum Acciones
    {
        Alimentar = 0,
        Despiojar = 1,
        Baniar = 2,
        Pasear = 3,
        Buscar = 4,
        Despasear = 5,
        Perseguir = 6,
        Hidratar = 7,
        Peinar = 8,
        Despeinar = 9,
    }
}

public enum Mascota
{
    gato = 0,
    perro = 1,
    quirquincho = 2,
    carpincho = 3,
    hamster = 4,
}