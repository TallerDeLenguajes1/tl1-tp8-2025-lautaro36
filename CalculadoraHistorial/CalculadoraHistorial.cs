using System.Runtime.CompilerServices;

namespace Calculadora
{
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacionSigno;
        public double Resultado()
        {
            double resultado=0;
            switch (operacionSigno)
            {
                case (TipoOperacion)1:
                    resultado = ResultadoAnterior + nuevoValor;
                    break;
                case (TipoOperacion)2:
                    resultado = ResultadoAnterior - nuevoValor;
                    break;
                case (TipoOperacion)3:
                    resultado = ResultadoAnterior * nuevoValor;
                    break;
                case (TipoOperacion)4:
                    resultado = ResultadoAnterior / nuevoValor;
                    break;
            }
            return resultado;
        }
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
        public TipoOperacion OperacionSigno { get => operacionSigno; set => operacionSigno = value; }

        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacionSigno = operacion;
        }
    }

    public enum TipoOperacion
    {
        Suma = 1,
        Resta = 2,
        Multiplicacion = 3,
        Division = 4
    }
}