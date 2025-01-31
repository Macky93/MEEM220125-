using System;
using System.Collections.Generic;

class Program
{
    // Diccionario simula una base de datos de usuarios con nombre de usuario y contraseña
    static Dictionary<string, string> usuarios = new Dictionary<string, string>
    {
        { "admin", "1234" },
        { "usuario1", "clave1" },
        { "usuario2", "clave2" }
    };

    static void Main()
    {
        Console.WriteLine("--- Sistema de Login ---");
        Console.Write("Ingrese su usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese su contraseña: ");
        string contraseña = LeerContraseña();

        if (ValidarCredenciales(usuario, contraseña))
        {
            Console.WriteLine("\nAcceso concedido. ¡Bienvenido, " + usuario + "!");
        }
        else
        {
            Console.WriteLine("\nAcceso denegado. Usuario o contraseña incorrectos.");
        }
    }

    static bool ValidarCredenciales(string usuario, string contraseña)
    {
        return usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña;
    }

    static string LeerContraseña()
    {
        //cambio realizados cambie asteriscos por signos +
        string contraseña = +++;
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Enter)
            {
                contraseña += key.KeyChar;
                Console.Write("*"); // Muestra asteriscos en lugar de la contraseña real
            }
        } while (key.Key != ConsoleKey.Enter);

        return contraseña;
    }
}
