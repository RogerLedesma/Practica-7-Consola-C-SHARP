using System;

namespace Ejercicios_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

            Console.WriteLine("1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.");
            Console.WriteLine("Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.");


            int precioArticulo, cantidadVendida, montoTotal;

            Console.WriteLine("Ingresar el precio del articulo");
            precioArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar la cantidad de articulos");
            cantidadVendida = int.Parse(Console.ReadLine());

            montoTotal = producto(precioArticulo, cantidadVendida);

            Console.WriteLine("El monto total a pagar: " + montoTotal);

            //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares

            Console.WriteLine("2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.");
            Console.WriteLine("Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares");

            int numerito, con = 0;
            bool resultado ;

            Console.WriteLine("Ingresar un numero");
            numerito = int.Parse(Console.ReadLine());


            for (int x = 0; x < 5; x++)
            {
                resultado = par(numerito);

                if (resultado)
                {
                    con++;
                }
                else resultado = false;

                Console.WriteLine("Ingresar un numero");
                numerito = int.Parse(Console.ReadLine());

            }             

            Console.WriteLine("La cantidad de numeros pares son : " + con);


            // 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.Informar el promedio teniendo en cuenta sólo los números primos

            Console.WriteLine("3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.");
            Console.WriteLine("Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero.Informar el promedio teniendo en cuenta sólo los números primos");


            int a, acum = 0;
            float promedio, contador = 0;

            Console.WriteLine("Ingresar un numero para saber el promedio de los numeros primos");
            a = int.Parse(Console.ReadLine());

            while (a!=0)

            {
                contador++;

                if (primo (a))
                {
                    acum += a;
                } 

                Console.WriteLine("Ingresar un numero para saber el promedio de los numeros primos");
                a = int.Parse(Console.ReadLine());

            }

            promedio = acum / contador;

            Console.WriteLine("El promedio de los numero primos : " + promedio);

            // 4. Hacer una función de tipo void llamada “positivoNegativoCero” 
            // que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con: 
            // a. 1 si el número es positivo.
            // b.- 1 si el número es negativo.
            // c. 0 si el número es cero

            Console.WriteLine(" 4. Hacer una función de tipo void llamada “positivoNegativoCero ” ");
            Console.WriteLine("que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:");
            Console.WriteLine(" A).  1 si el número es positivo.");
            Console.WriteLine(" B).- 1 si el número es negativo.");
            Console.WriteLine(" C).  0 si el número es cero");


            int numero, status = 9;

            Console.WriteLine("Ingresar un numero");
            numero = int.Parse(Console.ReadLine());

            positivoNegativoCero(numero,  ref status);

            Console.WriteLine(" El estado del valor " + numero + " es " + status);
            

       }

        static int producto(int a, int b)
        {
           int calculo = a * b; 
           return calculo;
         }


        static bool par( int n)
        {
           bool res = true;

           if (n % 2 == 0)
           {
             res =true;
           } else res = false;

            return res ;
         }

        static bool primo (int num)
        {
           
           
           bool banderaPrimo = true;

           int con = 0;     
        
           for (int x = 1; x <= num; x++)
           {
                
              if (num % x == 0)
               {
                   con++ ;                  
               }
           }

          if (con == 2)

               {
                   banderaPrimo = true;
                }

           else
               {
                    banderaPrimo = false;
                }
            

            return banderaPrimo; 

        }

        static void positivoNegativoCero (int n,  ref int estado)
        {

            if (n > 0)
            {
                estado = 1;
            }
            else if (n == 0)
            {
                estado = 0;
            }
            else

                estado = -1;

            Console.WriteLine("FIn del PROGRAMA");
        }

    }

}
