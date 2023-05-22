namespace I07_Recibo_de_sueldo_ConsoleApp
{
    internal class Program
    {
        /*
        Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años)
        y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
        Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de 
        multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad
        de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13%
        en concepto de descuentos.
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total
        a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados. 
         */
        static void Main(string[] args)
        {
            bool deseaSeguir = false;
            do
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                string? nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el valor por hora del empleado: ");
                decimal valorHora = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la de horas del empleado: ");
                int cantidadHoras = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la de horas del empleado: ");
                int antiguedad = int.Parse(Console.ReadLine());
                decimal porcentajeDescuentos = 0.13M;
                decimal sueldoBruto = (valorHora * cantidadHoras) + (antiguedad * 150);
                decimal sueldoNeto = sueldoBruto - (sueldoBruto * porcentajeDescuentos);

                Console.WriteLine($"Nombre: {nombre}\n" +
                                  $"Antiguedad: {antiguedad}\n" +
                                  $"Valor por Hora: {valorHora}\n" +
                                  $"Total a cobrar en bruto: {sueldoBruto}\n" +
                                  $"Total a cobrar neto: {sueldoNeto}");    
                Console.WriteLine("\nDesea seguir ingresando empleados(s = seguir): ");
                if (Console.ReadLine() == "s")
                {
                    deseaSeguir = true;
                }
            } while (deseaSeguir);
        }
    }
}