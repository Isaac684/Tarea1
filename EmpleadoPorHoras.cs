// La clase EmpleadoPorHoras que extiende a Empleado.
public class EmpleadoPorHoras : Empleado
{
    private decimal sueldo; // sueldo por hora
    private decimal horas; // horas trabajadas durante la semana

    // constructor con cinco parámetros
    public EmpleadoPorHoras(string nombre, string apellido, string nss,
    decimal sueldoPorHoras, decimal horasTrabajadas)
    : base(nombre, apellido, nss)
    {
        Sueldo = sueldoPorHoras; // valida el sueldo por horas a través de una propiedad
        Horas = horasTrabajadas; // valida las horas trabajadas a través de una propiedad
    } // fin del constructor de EmpleadoPorHoras con cinco parámetros

    // propiedad que obtiene y establece el sueldo del empleado por horas
    public decimal Sueldo
    {
        get
        {
            return sueldo;
        } // fin de get
        set
        {
            sueldo = (value >= 0) ? value : 0; // validación
        } // fin de set
    } // fin de la propiedad Sueldo

    // propiedad que obtiene y establece las horas del empleado por horas
    public decimal Horas
    {
        get
        {
            return horas;
        } // fin de get
        set
        {
            horas = ((value >= 0) && (value <= 168)) ?
            value : 0; // validación
        } // fin de set
    } // fin de la propiedad Horas

    // calcula los ingresos; redefine el método abstracto Ingresos de Empleado
    public override decimal Ingresos()
    {
        if (Horas <= 40) // no hay tiempo extra
                         // La clase EmpleadoPorHoras que extiende a Empleado.
            return Sueldo * Horas;
        else
            return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M);
        } // fin del método Ingresos

    // devuelve representación string del objeto EmpleadoPorHoras
    public override string ToString()
    {
        return string.Format(
        "empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}",
        base.ToString(), "sueldo por horas", Sueldo, "horas trabajadas", Horas );
    } // fin del método ToString
} // fin de la clase EmpleadoPorHoras
