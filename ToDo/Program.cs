using controlDeTareas;
//crear listas de pendientes y realizadas
Random aleatorio = new Random();
int n = aleatorio.Next(5, 16);
List<Tarea> tareasPendientes = new List<Tarea>();
for (int i = 0; i < n; i++)
{
    int m = aleatorio.Next(0, 10); //aleatorio para las acciones
    int l = aleatorio.Next(0, 5); //aleatorio para las mascotas
    string descripcion = ((Acciones)m).ToString() + " al " + ((Mascota)l).ToString(); //cast explicito del int aleatorio al enum correspondiente, luego toString para obtener la descropcion del enum
    tareasPendientes.Add(new Tarea(i + 1000, descripcion, l + 1)); //uso l porque me parece comodo
}
List<Tarea> tareasRealizadas = new List<Tarea>();

int bandera=1;
while (bandera == 1)
{
    //interfaz
    Console.WriteLine("---Bienvenido a control de tareas---");
    Console.WriteLine("Ingrese la opcion que desee:");
    Console.WriteLine("1. Mostrar tareas.");
    Console.WriteLine("2. Mover tareas de pendientes a realizadas.");
    Console.WriteLine("3. Buscar tareas pendientes por descripcion.");
    string entrada = Console.ReadLine();
    int opcion;
    int.TryParse(entrada, out opcion);
    switch (opcion)
    {
        case 1:
            Console.WriteLine("--- Tareas pendientes: ---");
            foreach (var item in tareasPendientes)
            {
                Console.WriteLine($"Tarea {item.TareaId}: {item.Descripcion}. Duracion: {item.Duracion} horas. Estado: {(item.Estado).ToString()}");
            }
            Console.WriteLine("--- Tareas realizadas: ---");
            foreach (var item in tareasRealizadas)
            {
                Console.WriteLine($"Tarea {item.TareaId}: {item.Descripcion}. Duracion: {item.Duracion} horas. Estado: {(item.Estado).ToString()}");
            }
            break;
        case 2:
            Console.WriteLine("Ingrese el ID de la tarea que desea mover a la lista de realizadas:");
            entrada = Console.ReadLine();
            int IdElegido;
            int.TryParse(entrada, out IdElegido);
            Tarea tareaBuscada = tareasPendientes.Find(item => item.TareaId == IdElegido);
            if (tareaBuscada != null)
            {
                tareasPendientes.Remove(tareaBuscada);
                tareaBuscada.Estado = PendienteORealizada.realizada;
                tareasRealizadas.Add(tareaBuscada);
            }
            break;
        case 3:
            Console.WriteLine("Ingrese la descipcion de la tarea que desea ver:");
            string descripcionBuscada = Console.ReadLine();
            Tarea tareaAMostrar = tareasPendientes.Find(item => item.Descripcion == descripcionBuscada);
            if (tareaAMostrar != null)
            {
                Console.WriteLine($"Tarea {tareaAMostrar.TareaId}: {tareaAMostrar.Descripcion}. Duracion: {tareaAMostrar.Duracion} horas");
            }
            break;
    }
    Console.WriteLine("Desea realizar otra operacion?1.Si / 2.No");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out bandera);
}