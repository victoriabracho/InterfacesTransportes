using Interfaces;
using System;


namespace Interfaces
{ 
            internal class Program
            {
                static void Main(string[] args)
                {
                    // Crear instancia de la clase Menú
                    Menu menu = new Menu();

                    // Llamar al método que maneja el flujo del menú
                    menu.MostrarMenu();
                }
            }

}