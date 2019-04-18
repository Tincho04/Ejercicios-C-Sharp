using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_17
{
    class Program
    {
    static void Main(string[] args)
    {
      string color, cant, continuar, recarga;
      int cantInt;

            Console.Title = "Ej_17_Class_Boligrafo";

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(100, ConsoleColor.Red);
            Boligrafo boligrafo3 = new Boligrafo(100, ConsoleColor.Green);
            Boligrafo boligrafo4 = new Boligrafo(100, ConsoleColor.Yellow);
            Boligrafo boligrafo5 = new Boligrafo(100, ConsoleColor.White);
      string dibujo;
      do
      { 
      Console.WriteLine("Indique que color desea emplear:");
      Console.WriteLine("R-Rojo");
      Console.WriteLine("A-Azul");
      Console.WriteLine("V-Verde");
      Console.WriteLine("M-Amarillo");
      Console.WriteLine("B-Blanco");
      color = Console.ReadLine();
      Console.WriteLine("Indique la cantidad de tinta a utilizar");
      cant = Console.ReadLine();
      cantInt = int.Parse(cant);

      if (color=="A" || color=="A")
      { 
      Console.WriteLine("Dibujo de boligrafoazul");
            if(boligrafo1.Pintar(cantInt, out dibujo))
            {
                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}", boligrafo1.GetTinta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
            }
      }
      else if(color=="R" || color=="r")
      { 
      Console.Clear();
            Console.WriteLine("Dibujo de boligrafo rojo");
            if (boligrafo2.Pintar(cantInt, out dibujo))
            {
                Console.ForegroundColor = boligrafo2.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Nivel de tinta restante: {0}", boligrafo2.GetTinta());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
             }
      }
      else if (color == "V" || color == "v")
      {
        Console.Clear();
        Console.WriteLine("Dibujo de boligrafo verde");
        if (boligrafo3.Pintar(cantInt, out dibujo))
        {
          Console.ForegroundColor = boligrafo3.GetColor();
          Console.WriteLine(dibujo);
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Nivel de tinta restante: {0}", boligrafo3.GetTinta());
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
        }
      }
      else if (color == "M" || color == "m")
        {
          Console.Clear();
          Console.WriteLine("Dibujo de boligrafo amarillo");
          if (boligrafo4.Pintar(cantInt, out dibujo))
          {
            Console.ForegroundColor = boligrafo4.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Nivel de tinta restante: {0}", boligrafo4.GetTinta());
            Console.ReadKey();
          }
          else
          {
            Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
          }
      }
      else if (color == "B" || color == "b")
      {
        Console.Clear();
        Console.WriteLine("Dibujo de boligrafo blanco");
        if (boligrafo5.Pintar(cantInt, out dibujo))
        {
          Console.ForegroundColor = boligrafo5.GetColor();
          Console.WriteLine(dibujo);
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Nivel de tinta restante: {0}", boligrafo5.GetTinta());
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("Nivel de tinta requerido superior a la capacidad disponible");
        }
      }
      else
      {
        Console.WriteLine("No ha agregado un color válido");
      }

        Console.Clear();
        Console.WriteLine("¿Desea Continuar?");
        continuar = Console.ReadLine();
        Console.WriteLine("¿Desea recargar la tinta?");
        recarga = Console.ReadLine();
        if (recarga == "s" || recarga == "S")
        {
          boligrafo1.Recargar();
          boligrafo2.Recargar();
          boligrafo3.Recargar();
          boligrafo4.Recargar();
          boligrafo5.Recargar();
        }
      } while (continuar!="n" && continuar!="N");
    }
  }
}
