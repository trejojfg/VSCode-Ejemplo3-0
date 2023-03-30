using System;

namespace Ejemplos_Cont_Acu
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONTADORES, cuenta según el valor del incremento/disminucion del contador. Siempre tiene un valor inicial y casi siempre, es 0
            //se pueden usar operadores de contadores ->  ++ "INCREMENTO" (cuenta de uno en uno) y -- "DISMINUCION" (resta de uno en uno)
            //ACUMULADORES, acumula el valor del incremento/disminucion a acumular. Siempre tiene un valor inicial y casi siempre, es 0
            //se pueden usar operadores de acumulacion ->  += "INCREMENTO" (acumula el valor) y -= "DISMINUCION" (disminuye el valor)
            //int acumulador = 0;
            //acumulador = acumulador + valor (numero fijo ó variable u operación)
            //int contador = 0;
            //contador = contador + 1;

                                // Ejemplo 1 - saber cuantas edades tienen mas de 18 años (con condicionales)
            //int contador = 0
            //int e1 = 20, e2 = 30, e3 = 15;
            //if (e1 > 18)
            //    contador = contador + 1;
            //if (e2 > 18)
            //    contador = contador + 1;
            //if (e3 > 18)
            //    contador = contador + 1;
            //Console.WriteLine("El conteo es: " + contador);

                                // Ejemplo 1 - saber cuantas edades tienen mas de 18 años, con operadores de contar
            //int contador = 0;
            //int e1 = 20, e2 = 30, e3 = 15;
            //if (e1 > 18)
            //    contador++;
            //if (e2 > 18)
            //    contador++;
            //if (e3 > 18)
            //    contador++;
            //Console.WriteLine("El conteo es: " + contador);

                                // Ejemplo 1 - saber cuantas edades tienen mas de 18 años y cuanto suman, con operadores de contar
            int contador = 0;
            int acumulador = 0, promedio;
            int e1 = 20, e2 = 30, e3 = 15;
            if (e1 > 18){
                contador++;
                acumulador = acumulador + e1;
            }
            if (e2 > 18){
                contador++;
                acumulador += e2;
            }
            if (e3 > 18){
                contador++;
                acumulador += e3;
            }
            promedio = acumulador / contador;

            Console.WriteLine("El conteo es: " + contador);
            Console.WriteLine("El acumulado es: "+ acumulador);
            Console.WriteLine("El promedio de edad mayores de 18 es: " + promedio);
            Console.WriteLine("Fin del programa");
        }
    }
}
