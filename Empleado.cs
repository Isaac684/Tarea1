// La clase base abstracta Empleado.
 public abstract class Empleado
{
    private string primerNombre;
    private string apellidoPaterno;
    private string numeroSeguroSocial;
    // constructor con tres parámetros
    public Empleado(string nombre, string apellido, string nss)
    {
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        } // fin de constructor de Empleado con tres parámetros

    // propiedad de sólo lectura que obtiene el primer nombre del empleado
    public string PrimerNombre
    {
        get
        {
            return primerNombre;
        } // fin de get
    } // fin de la propiedad PrimerNombre

    // propiedad de sólo lectura que obtiene el apellido paterno del empleado
    public string ApellidoPaterno
    {
        get
        {
            return apellidoPaterno;
        } // fin de get
    } // fin de la propiedad ApellidoPaterno

     // propiedad de sólo lectura que obtiene el número de seguro social del empleado
    public string NumeroSeguroSocial
    {
        get
        {
            return numeroSeguroSocial;
        } // fin de get
    } // fin de la propiedad NumeroSeguroSocial

    // devuelve representación string del objeto Empleado, usando las propiedades
    public override string ToString()
    {
        return string.Format("{0} {1}\nnúmero de seguro social: {2}",
        PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
    } // fin del método ToString

    // método abstracto redefinido por las clases derivadas
    public abstract decimal Ingresos(); // no hay implementación aquí
     } // fin de la clase abstracta Empleado