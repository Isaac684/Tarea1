// Aplicación de prueba de la jerarquía de Empleado.
using System;

public class PruebaSistemaNomina
{
    public static void Main(string[] args)
    {
        // crea objetos de clases derivadas
        EmpleadoAsalariado empleadoAsalariado =
            new EmpleadoAsalariado("John", "Smith", "111-11-1111", 800.00M);
        EmpleadoPorHoras empleadoPorHoras =
            new EmpleadoPorHoras("Karen", "Price",
            "222-22-2222", 16.75M, 40.0M);
        EmpleadoPorComision empleadoPorComision =
            new EmpleadoPorComision("Sue", "Jones",
            "333-33-3333", 10000.00M, .06M);
        EmpleadoBaseMasComision empleadoBaseMasComision =
            new EmpleadoBaseMasComision("Bob", "Lewis",
            "444-44-4444", 5000.00M, .04M, 300.00M);
        
        Console.WriteLine("Empleados procesados en forma individual:\n");
        
        Console.WriteLine("{0}\n{1}: {2:C}\n",
            empleadoAsalariado, "ingresos", empleadoAsalariado.Ingresos());
        Console.WriteLine("{0}\n{1}: {2:C}\n",
            empleadoPorHoras, "ingresos", empleadoPorHoras.Ingresos());
        Console.WriteLine("{0}\n{1}: {2:C}\n",
            empleadoPorComision, "ingresos", empleadoPorComision.Ingresos());
        Console.WriteLine("{0}\n{1}: {2:C}\n",
            empleadoBaseMasComision,"ingresos", empleadoBaseMasComision.Ingresos());
   
        // crea arreglo Empleado de cuatro elementos
        Empleado[] empleados = new Empleado[4];
        
        // inicializa arreglo con objetos Empleado de tipos derivados
        empleados[0] = empleadoAsalariado;
        empleados[1] = empleadoPorHoras;
        empleados[2] = empleadoPorComision;
        empleados[3] = empleadoBaseMasComision;
        
        Console.WriteLine("Empleados procesados en forma polimórfica:\n");
        
        // procesa en forma generica cada elemento en el arreglo de empleados
        foreach (Empleado empleadoActual in empleados)
        {
            Console.WriteLine(empleadoActual); // invoca a ToString
            
            // determina si el elemento es un EmpleadoBaseMasComision
            if (empleadoActual is EmpleadoBaseMasComision)
            {
                // conversión descendente de referencia de Empleado a
                // referencia de EmpleadoBaseMasComision
                EmpleadoBaseMasComision empleado =
                (EmpleadoBaseMasComision) empleadoActual;
                
                empleado.SalarioBase *= 1.10M;
                Console.WriteLine(
                    "nuevo salario base con incremento del 10%: {0:C}",
                    empleado.SalarioBase);
            } // fin de if
            
            Console.WriteLine(
                "ingresos {0:C}\n", empleadoActual.Ingresos());
        } // fin de foreach
        
        // obtiene el nombre del tipo de cada objeto en el arreglo de empleados
        for (int j = 0; j < empleados.Length; j++)
            Console.WriteLine("Empleado {0} es un {1}", j,
            empleados[j].GetType());
        Console.ReadKey();
    } // fin de Main
} // fin de la clase PruebaSistemaNomina
