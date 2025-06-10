using Calculadora;

int bandera = 1;

List<Operacion> operaciones = new List<Operacion>();
int i = 0;
Console.WriteLine("---Bienvenido a la calculadora:");

while (bandera == 1)
{
    Console.WriteLine("Elija la operacion que desea realizar:");
    Console.WriteLine("1. Mostrar el historial.");
    Console.WriteLine("2. Operar");
    string entrada = Console.ReadLine();
    int opcion;
    int.TryParse(entrada, out opcion);
    switch (opcion)
    {
        case 1:
            foreach (Operacion item in operaciones)
            {
                Console.WriteLine($"La {item.OperacionSigno} de {item.ResultadoAnterior} y {item.NuevoValor} es {item.Resultado()}");
            }
            break;
        default:
            Console.WriteLine("Elija la operacion que desea realizar:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Producto");
            Console.WriteLine("4. Division");

            entrada = Console.ReadLine();
            TipoOperacion operacionSigno;
            TipoOperacion.TryParse(entrada, out operacionSigno);

            double nuevoValor;
            Console.WriteLine("Ingrese el segundo termino:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out nuevoValor);
            if (operaciones.Count == 0) //diferencio entre primer componente y el resto porque el resultado anterior, la primera vez debe ser 0
            {
                operaciones.Add(new Operacion(0, nuevoValor, operacionSigno));
            }
            else
            {
                double resultadoAnterior = operaciones[i].Resultado(); //i aun no fue incrementado, ni se agrego un  nuebo elemetno a la lista, por lo que es el indice del ultimo elemento
                operaciones.Add(new Operacion(resultadoAnterior, nuevoValor, operacionSigno));
                i++;
                Console.WriteLine($"La {operaciones[i].OperacionSigno} de {operaciones[i].ResultadoAnterior} y {operaciones[i].NuevoValor} es {operaciones[i].Resultado()}");
            }
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? \n1-Si. \n2-No.");
    entrada = Console.ReadLine();
    int.TryParse(entrada, out bandera);
}