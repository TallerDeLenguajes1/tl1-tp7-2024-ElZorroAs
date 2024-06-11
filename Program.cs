using System;
using System.Globalization;
using Company.ClassLibrary1;

;
//c. Cargue los datos para 3 empleados en un arreglo de tipo empleados.

Empleados empleado1 = new Empleados("Juan", "Pérez", new DateTime(1990, 5, 15), 'S', new DateTime(2010, 3, 20), 50000, estructuraCargos.Ingeniero);
Empleados empleado2 = new Empleados("María", "González", new DateTime(1985, 8, 10), 'C', new DateTime(2005, 6, 12), 60000, estructuraCargos.Especialista);
Empleados empleado3 = new Empleados("Pedro", "López", new DateTime(1995, 2, 25), 'S', new DateTime(2018, 9, 5), 45000, estructuraCargos.Auxiliar);
Empleados[] arreglo = new Empleados[] { empleado1, empleado2, empleado3 };

//d. Obtener el Monto Total de lo que se paga en concepto de Salarios.

double salarioTotal = 0;
foreach (Empleados item in arreglo)
{
    salarioTotal = salarioTotal + item.calcularSalario();
}
Console.WriteLine($"Monto Total de salarios {salarioTotal}");

/*
e. Muestre por pantalla los datos del empleado que esté más próximo a jubilarse
(incluyendo los datos del apartado 2.a y el salario
correspondiente.
*/

Empleados proximoJubilacion = arreglo.OrderBy(emp => emp.AniosHastaJubilacion()).First();
Console.WriteLine($"Empleado más próximo a jubilarse: {proximoJubilacion.Nombre} {proximoJubilacion.Apellido}");
Console.WriteLine($"Edad: {proximoJubilacion.edad()}");
Console.WriteLine($"Antigüedad: {proximoJubilacion.Antiguedad()} años");
Console.WriteLine($"Años hasta jubilación: {proximoJubilacion.AniosHastaJubilacion()}");
Console.WriteLine($"Salario: {proximoJubilacion.calcularSalario()}");
