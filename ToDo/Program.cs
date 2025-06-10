using controlDeTareas;

Random aleatorio = new Random();
int n = aleatorio.Next(5, 16);

Tarea[] Pendientes = new Tarea[n];
for (int i = 0; i < n; i++)
{
    int m = aleatorio.Next(0, 10); //aleatorio para las acciones
    int l = aleatorio.Next(0, 5); //aleatorio para las mascotas
    string descripcion = ((Acciones)m).ToString() + " al " + ((Mascota)l).ToString(); //cast explicito del int aleatorio al enum correspondiente, luego toString para obtener la descropcion del enum
    Pendientes[i] = new Tarea(i+1000, descripcion, l+1); //uso l porque me parece comodo
    Console.WriteLine($"Tarea {Pendientes[i].TareaId}: {Pendientes[i].Descripcion}. Duracion: {Pendientes[i].Duracion} Horas;");
}