using System;
using System.Collections.Generic;

public class Usuario
{
    // Propiedades de la clase Usuario
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public List<string> BilleterasVirtuales { get; set; }

    // Constructor sin parámetros
    public Usuario()
    {
        BilleterasVirtuales = new List<string>();
    }

    // Constructor con parámetros para Nombre, Edad, Telefono y Correo
    public Usuario(string nombre, int edad, string telefono, string correo)
    {
        Nombre = nombre;
        Edad = edad;
        Telefono = telefono;
        Correo = correo;
        BilleterasVirtuales = new List<string>();
    }

    // Constructor adicional con parámetro para el número de billeteras virtuales
    public Usuario(string nombre, int edad, string telefono, string correo, int numeroBilleteras)
    {
        Nombre = nombre;
        Edad = edad;
        Telefono = telefono;
        Correo = correo;
        BilleterasVirtuales = new List<string>();

        // Agregar el número especificado de billeteras virtuales
        for (int i = 0; i < numeroBilleteras; i++)
        {
            BilleterasVirtuales.Add($"Billetera {i + 1}");
        }
    }
}
