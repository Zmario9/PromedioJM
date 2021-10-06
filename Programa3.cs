using System;
using Controlador;
using Modelo;

namespace Modelo
{
    public class ContenedorArreglo
    {
        public int[] ingresarArreglo(int cantidad)
        {
			int[] arreglo = new int[cantidad];	
			for (int i = 0; i < cantidad ; i++)
			{
				Console.WriteLine("Ingrese elemento " + (i  + 1)+ " = ");
				int value = int.Parse(Console.ReadLine());				
				arreglo[i] = value;				
			}			
			return arreglo;		
        }
    }
}

namespace Controlador
{
  public class procesocontrolador 
  {
     
	public int calculaPromedio(int[] arreglo, int cantidad)
	{
		int total=0;
		for (int i = 0; i < cantidad ; i++)
		{
			int value = arreglo[i];
			total = total +value;
		}
		return total/cantidad;		
	}

  }
}

namespace Vista
{
    public class Program
    {
        public static void Main(string[] args)
        {            
			//procesocontrolador controlador = new procesocontrolador();
			int cantidad = -1;
            do {            
				Console.WriteLine("Ingrese la cantidad de elementos del arreglo o ingrese un Cero para salir:");
				cantidad = int.Parse(Console.ReadLine());
				if (cantidad>0){
					ContenedorArreglo modelo = new ContenedorArreglo();
					int[] arreglo = modelo.ingresarArreglo(cantidad);
					procesocontrolador controlador = new procesocontrolador();
					int promedio = controlador.calculaPromedio(arreglo, cantidad);
					Console.WriteLine("Promedio :" + promedio);
				}
			} while (cantidad != 0);
        }        
    }        
}