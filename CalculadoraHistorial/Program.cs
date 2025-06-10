using Calculadora;

int bandera = 1;

List<Operacion> operaciones = new List<Operacion>();
int i = 0;
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
            foreach (var item in operaciones)
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
            double segundoValor;

            Console.WriteLine("Ingrese el segundo termino:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            operaciones.Add(new Operacion(operaciones[i - 1].ResultadoAnterior, segundoValor, operacionSigno));
            break;
    }
    i++;
}
    /*switch (operacionSigno)
    {
        case (TipoOperacion)1:
            Console.WriteLine("Ingrese el segundo termino:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            operaciones.Add(new Operacion(segundoValor, operacionSigno));
            break;
        case (TipoOperacion)2:
            Console.WriteLine("Ingrese el segundo termino:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            operaciones.Add(new Operacion(segundoValor, operacionSigno));
            break;
        case (TipoOperacion)3:
            Console.WriteLine("Ingrese el segundo termino:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            operaciones.Add(new Operacion(segundoValor, operacionSigno));
            break;
        case (TipoOperacion)4:
            Console.WriteLine("Ingrese el dicisor:");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out segundoValor);
            operaciones.Add(new Operacion(segundoValor, operacionSigno));
            break;
    }
    i++;
}*/