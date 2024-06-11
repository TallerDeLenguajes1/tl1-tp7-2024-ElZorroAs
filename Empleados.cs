using System;

namespace Company.ClassLibrary1;

/*
1. Crear una clase Empleado para almacenar la siguiente información:
    a. Nombre (string),
    b. Apellido (string),
    c. Fecha de nacimiento (datetime),
    d. Estado civil (char),
    e. Fecha de ingreso en la empresa (datetime),
    f. Sueldo Básico (double),
    g. Cargo (cargos)La variable cargos es una variable de tipo enumeración
    con los siguientes elementos: Auxiliar; Administrativo; Ingeniero;
    Especialista; Investigador. (investigue el uso de enum en C# para
    realizar esto)
*/

public enum estructuraCargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
public class Empleados
{
    private string nombre;
    private string apellido;
    private DateTime fechaDeNacimiento;
    private char estadoCivil;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private estructuraCargos cargo;

    public global::System.String Nombre { get => nombre; set => nombre = value; }
    public global::System.String Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public global::System.Char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public global::System.Double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public estructuraCargos Cargo { get => cargo; set => cargo = value; }
    /*
    2. Cree los métodos necesarios para poder obtener los datos que se detallan a continuación:
    */
    public Empleados(string nombre, string apellido, DateTime fechaDeNacimiento, char estadoCivil, DateTime fechaDeIngreso, double sueldoBasico, estructuraCargos cargo)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaDeNacimiento = fechaDeNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaDeIngreso = fechaDeIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }
    /*
    a. Calcular lo siguiente:
        i. La antigüedad del empleado en la empresa.
        ii. La edad del empleado,
        iii. La cantidad de años que le falta al empleado para poder
        jubilarse, considerando que la edad de jubilación es de 65.
    */
    public int Antiguedad()
    {
        return DateTime.Now.Year - fechaDeIngreso.Year;
    }
    public int edad()
    {
        return DateTime.Now.Year - fechaDeNacimiento.Year;
    }
    public int AniosHastaJubilacion()
    {
        return 65 - edad();
    }

    /*
    b. Calcular el salario, de acuerdo a la fórmula: Salario = Sueldo Básico +
    Adicional. Para ello el Adicional contempla la antigüedad en años, el
    cargo y si es casado:
        i) 1 % del sueldo básico por cada año de antigüedad hasta los
        20 años, a partir de este, el porcentaje se fija en 25%.

        ii) Si el cargo es Ingeniero o Especialista, el Adicional se
        incrementa en un 50%.

        iii) Si es casado al Adicional se le aumenta $150.000.
        Por ejemplo, si la antigüedad es de 15 años y el Sueldo Básico =
        $650.000, el Adicional es 65.0000 * 0.15 = 97.500. Si además el
        cargo es Ingeniero o Especialista, se incrementa el Adicional en
        un 50%. Esto es: 97.500* 1.50 = 146.250. Si a su vez es casado
        el Adicional será: 146.250+ 150.000= 296.250
    */

    public double calcularSalario()
    {
        double adicional = 0;
        if (Antiguedad() < 20)
        {
            adicional = 0.01 * sueldoBasico * Antiguedad();
        }
        else
        {
            adicional = 0.25 * sueldoBasico;
        }

        if (cargo == estructuraCargos.Ingeniero || cargo == estructuraCargos.Especialista)
        {
            adicional = adicional * 1.50;
        }

        if (EstadoCivil == 'C' || estadoCivil == 'C')
        {
            adicional += 150.000;
        }
        return sueldoBasico + adicional;
    }
}
