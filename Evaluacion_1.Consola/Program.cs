using Evaluacion_1.Back;
Console.WriteLine("Programación II - 2026 - Evaluación 1");

Console.WriteLine("============instancias de Persona============");
Persona persona = new Persona(0, "00000000", "Sergio Algorry");
persona.MostrarInformacion();


Console.WriteLine("============instancias de Alumno============");
Alumno alumno = new Alumno(1, "12345678", "Juan Pérez", "Matemáticas");

Console.WriteLine("============instancias de Empleado============");
Empleado empleado = new Empleado(2, "20-87654321-9", "María Gómez");