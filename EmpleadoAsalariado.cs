// La clase EmpleadoAsalariado que extiende a Empleado.
public class EmpleadoAsalariado : Empleado
{
    private decimal salarioSemanal;

    // constructor con cuatro parámetros
    public EmpleadoAsalariado(string nombre, string apellido, string nss,
    decimal salario) : base(nombre, apellido, nss)
    {
        SalarioSemanal = salario; // valida el salario a través de una propiedad
    } // fin del constructor de EmpleadoAsalariado con cuatro parámetros

     // propiedad que obtiene y establece el salario del empleado asalariado
    public decimal SalarioSemanal
    {
        get
        {
            return salarioSemanal;
        } // fin de get
        set
        {
            salarioSemanal = ((value >= 0) ? value : 0); // validación
        } // fin de set
    } // fin de la propiedad SalarioSemanal

     // calcula los ingresos; redefine el método abstracto Ingresos en Empleado
    public override decimal Ingresos()
    {
        return SalarioSemanal;
    } // fin del método Ingresos

 // devuelve representación string del objeto EmpleadoAsalariado
    public override string ToString()
    {
        return string.Format("empleado asalariado: {0}\n{1}: {2:C}",
        base.ToString(), "salario semanal", SalarioSemanal);
    } // fin del método ToString
} // fin de la clase EmpleadoAsalariado

