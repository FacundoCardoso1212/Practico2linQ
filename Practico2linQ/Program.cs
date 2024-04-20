﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2linQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1:

            List<Persona> personas = new List<Persona>
        {

            new Persona(50, "Juan", "Lima"),
            new Persona(31, "Maria", "Bogota"),
            new Persona(35, "Pedro", "Madrid"),
            new Persona(40, "Ana", "Lima"),
            new Persona(40, "Jose", "Buenos Aires")

        };


            personas.OrderBy(p => p.Nombre).ToList() .Where(p => p.Edad > 30 && p.Ciudad == "Lima").ToList().ForEach(p => Console.WriteLine(p.Nombre));
            Console.ReadLine();

            //Ejercicio 2

             personas.Where(p => p.Edad >= 25 && p.Edad <= 35).ToList().OrderBy(p => p.Nombre).ToList().ForEach(p => Console.WriteLine(p.Nombre));
             Console.ReadLine();

            ControlEmpresasEmpleados prueba1 = new ControlEmpresasEmpleados();

            prueba1.getCeo("CEO");

            prueba1.getEmpleadosOrdenados();


            List<int> valores = new List<int>() { 1, 32, 22, 13, 98, 8, 7, 4, 16 };

            for (var i = 0; i < valores.Count - 1; i++)
            {
                if (valores[i] > valores[i + 1])
                {
                    var temp = valores[i];
                    valores[i] = valores[i + 1];
                    valores[i + 1] = temp;

                    i = -1;
                }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            }

            //Ejecicio 3b:
            valores.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //Ejercicio 4 a/b:

            Console.WriteLine(valores.Sum());

            Console.WriteLine(valores.Where(v => v % 2 == 0).ToList().Sum());


            //Ejercicio 5.1 = 7.

            //Eercicio 5.2

            List<int> valores2 = new List<int>() { 1, 5, 6, 32, 22, 13, 98, 8, 7, 4, 16 };

            int sumaTotalValoresMayoresAOCHO = valores2.Where(v => v > 8 && v % 2 == 0).Sum();
            int sumaTotalValoresMenoresAOCHO = valores2.Where(v => v < 8 && v % 2 == 0).Sum();

            Console.WriteLine(sumaTotalValoresMayoresAOCHO);
            Console.WriteLine(sumaTotalValoresMenoresAOCHO);


            //Ejercicio 6.1 = 6.
            //Ejercicio 6.2 = 4


            Console.WriteLine("Coloque una letra de la A a la F");
            string letra = Console.ReadLine();

            string[] letras = { "a", "b", "c", "d", "e", "f" };

            for (int i = 0; i < letras.Length; i++)
            {
                if (letras[i] == "f")
                {
                    Console.WriteLine("no hay mas letras");
                    break;
                }
                else if (letras[i] == letra)
                {
                    Console.WriteLine($"La letra siguiente del abecedario es {letras[i + 1]}");
                    break;
                }
            }
        }

    }
}
