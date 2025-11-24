using System;

namespace TiposYMatricula
{
    /// <summary>
    /// Clase principal que contiene el menú y las operaciones con tipos de datos.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos (no se utilizan).</param>
        static void Main(string[] args)
        {
            bool continuar = true;
            
            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine() ?? "";
                
                switch (opcion)
                {
                    case "1":
                        OperacionesConInt();
                        break;
                    case "2":
                        OperacionesConString();
                        break;
                    case "3":
                        OperacionesConDouble();
                        break;
                    case "4":
                        OperacionesConFloat();
                        break;
                    case "5":
                        OperacionesConBoolean();
                        break;
                    case "6":
                        OperacionesConObjeto();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                
                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        
        /// <summary>
        /// Muestra el menú principal de opciones en la consola.
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║      MENÚ - TIPOS DE DATOS         ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║  1. Operaciones con Int           ║");
            Console.WriteLine("║  2. Operaciones con String        ║");
            Console.WriteLine("║  3. Operaciones con Double        ║");
            Console.WriteLine("║  4. Operaciones con float         ║");
            Console.WriteLine("║  5. Operaciones con boolean       ║");
            Console.WriteLine("║  6. Operaciones con Objeto       ║");
            Console.WriteLine("║  0. Salir                         ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Seleccione una opción: ");
        }
        
        /// <summary>
        /// Realiza operaciones aritméticas básicas con dos números enteros ingresados por el usuario.
        /// </summary>
        static void OperacionesConInt()
        {
            Console.WriteLine("\n=== OPERACIONES CON INT ===");
            
            Console.Write("Ingrese el primer número entero: ");
            if (int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.Write("Ingrese el segundo número entero: ");
                if (int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}");
                    Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
                    if (num2 != 0)
                    {
                        Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
                        Console.WriteLine($"Módulo: {num1} % {num2} = {num1 % num2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: El segundo valor no es un número entero válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer valor no es un número entero válido.");
            }
        }
        
        /// <summary>
        /// Realiza operaciones comunes con dos cadenas de texto ingresadas por el usuario.
        /// </summary>
        static void OperacionesConString()
        {
            Console.WriteLine("\n=== OPERACIONES CON STRING ===");
            
            Console.Write("Ingrese la primera cadena: ");
            string cadena1 = Console.ReadLine() ?? "";
            
            Console.Write("Ingrese la segunda cadena: ");
            string cadena2 = Console.ReadLine() ?? "";
            
            Console.WriteLine($"\nConcatenación: \"{cadena1}\" + \"{cadena2}\" = \"{cadena1 + cadena2}\"");
            Console.WriteLine($"Longitud de cadena 1: {cadena1.Length} caracteres");
            Console.WriteLine($"Longitud de cadena 2: {cadena2.Length} caracteres");
            Console.WriteLine($"¿Son iguales?: {cadena1.Equals(cadena2)}");
            Console.WriteLine($"¿Cadena 1 contiene 'a'?: {cadena1.Contains('a')}");
            Console.WriteLine($"Cadena 1 en mayúsculas: {cadena1.ToUpper()}");
            Console.WriteLine($"Cadena 1 en minúsculas: {cadena1.ToLower()}");
        }
        
        /// <summary>
        /// Realiza operaciones aritméticas con dos números de tipo double ingresados por el usuario.
        /// </summary>
        static void OperacionesConDouble()
        {
            Console.WriteLine("\n=== OPERACIONES CON DOUBLE ===");
            
            Console.Write("Ingrese el primer número decimal: ");
            if (double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.Write("Ingrese el segundo número decimal: ");
                if (double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}");
                    Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
                    if (num2 != 0)
                    {
                        Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    Console.WriteLine($"Potencia: {num1} ^ 2 = {Math.Pow(num1, 2)}");
                    Console.WriteLine($"Raíz cuadrada de {num1}: {Math.Sqrt(num1)}");
                }
                else
                {
                    Console.WriteLine("Error: El segundo valor no es un número decimal válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer valor no es un número decimal válido.");
            }
        }
        
        /// <summary>
        /// Realiza operaciones aritméticas básicas con dos números de tipo float ingresados por el usuario.
        /// </summary>
        static void OperacionesConFloat()
        {
            Console.WriteLine("\n=== OPERACIONES CON FLOAT ===");
            
            Console.Write("Ingrese el primer número float: ");
            if (float.TryParse(Console.ReadLine(), out float num1))
            {
                Console.Write("Ingrese el segundo número float: ");
                if (float.TryParse(Console.ReadLine(), out float num2))
                {
                    Console.WriteLine($"\nSuma: {num1} + {num2} = {num1 + num2}");
                    Console.WriteLine($"Resta: {num1} - {num2} = {num1 - num2}");
                    Console.WriteLine($"Multiplicación: {num1} * {num2} = {num1 * num2}");
                    if (num2 != 0)
                    {
                        Console.WriteLine($"División: {num1} / {num2} = {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                    Console.WriteLine($"Valor absoluto de {num1}: {Math.Abs(num1)}");
                }
                else
                {
                    Console.WriteLine("Error: El segundo valor no es un número float válido.");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer valor no es un número float válido.");
            }
        }
        
        /// <summary>
        /// Realiza operaciones lógicas con dos valores booleanos ingresados por el usuario.
        /// </summary>
        static void OperacionesConBoolean()
        {
            Console.WriteLine("\n=== OPERACIONES CON BOOLEAN ===");
            
            Console.Write("Ingrese true o false para el primer valor: ");
            if (bool.TryParse(Console.ReadLine(), out bool valor1))
            {
                Console.Write("Ingrese true o false para el segundo valor: ");
                if (bool.TryParse(Console.ReadLine(), out bool valor2))
                {
                    Console.WriteLine($"\nValor 1: {valor1}");
                    Console.WriteLine($"Valor 2: {valor2}");
                    Console.WriteLine($"AND (&&): {valor1} && {valor2} = {valor1 && valor2}");
                    Console.WriteLine($"OR (||): {valor1} || {valor2} = {valor1 || valor2}");
                    Console.WriteLine($"NOT (!): !{valor1} = {!valor1}");
                    Console.WriteLine($"NOT (!): !{valor2} = {!valor2}");
                    Console.WriteLine($"XOR (^): {valor1} ^ {valor2} = {valor1 ^ valor2}");
                }
                else
                {
                    Console.WriteLine("Error: El segundo valor no es un boolean válido (true/false).");
                }
            }
            else
            {
                Console.WriteLine("Error: El primer valor no es un boolean válido (true/false).");
            }
        }
        
        /// <summary>
        /// Crea un objeto de tipo Persona, muestra su información y permite modificarla.
        /// </summary>
        static void OperacionesConObjeto()
        {
            Console.WriteLine("\n=== OPERACIONES CON OBJETO (Persona) ===");
            
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine() ?? "";
            
            Console.Write("Ingrese la edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Persona persona = new Persona(nombre, edad);
                
                Console.WriteLine("\n=== Información de la Persona ===");
                Console.WriteLine(persona.MostrarInformacion());
                Console.WriteLine($"¿Es mayor de edad?: {persona.EsMayorDeEdad()}");
                
                Console.Write("\n¿Desea cambiar la edad? (s/n): ");
                string respuesta = Console.ReadLine() ?? "";
                if (respuesta.ToLower() == "s")
                {
                    Console.Write("Ingrese la nueva edad: ");
                    if (int.TryParse(Console.ReadLine(), out int nuevaEdad))
                    {
                        persona.Edad = nuevaEdad;
                        Console.WriteLine($"\nEdad actualizada. {persona.MostrarInformacion()}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: La edad debe ser un número entero válido.");
            }
        }
    }
    
    /// <summary>
    /// Representa a una persona con nombre y edad.
    /// </summary>
    class Persona
    {
        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Nombre { get; set; }
        
        /// <summary>
        /// Obtiene o establece la edad de la persona.
        /// </summary>
        public int Edad { get; set; }
        
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Persona"/>.
        /// </summary>
        /// <param name="nombre">El nombre de la persona.</param>
        /// <param name="edad">La edad de la persona.</param>
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        
        /// <summary>
        /// Devuelve una cadena con la información completa de la persona.
        /// </summary>
        /// <returns>Una cadena que representa el nombre y la edad de la persona.</returns>
        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre}, Edad: {Edad} años";
        }
        
        /// <summary>
        /// Comprueba si la persona es mayor de edad (18 años o más).
        /// </summary>
        /// <returns>Verdadero si la persona es mayor de edad, de lo contrario, falso.</returns>
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }
}

