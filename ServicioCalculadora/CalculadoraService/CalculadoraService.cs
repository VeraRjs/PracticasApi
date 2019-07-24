using System;

namespace CalculadoraService
{
    public class CalculadoraService
    {
        public int? suma (int? numeroUno, int? numeroDos)
        {
            int? resultado;
            if(numeroDos == null || numeroUno == null)
            throw new ArgumentNullException();
            
            
            resultado=numeroUno+numeroDos;

            return resultado;
            
        }
    }
}
