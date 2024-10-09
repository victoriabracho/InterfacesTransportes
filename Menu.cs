using System;
using Interfaces;
using System.Collections.Generic;
using Interfaces.Interfaces;

namespace Interfaces
{
    internal class Menu
    {
        private List<Opciones> opciones;

        public Menu()
        {

            opciones = new List<Opciones>()
            {
                new Opciones("Carro", HacerCarro),
                new Opciones("Avión", HacerAvion),
                new Opciones("Barco", HacerBarco),
                new Opciones("Salir", ()=>Environment.Exit(0))
            };

            while (true)
            {
                MostrarMenu();
                SeleccionarOpcion();
            }
        }

        public void MostrarMenu()
        {
            Console.WriteLine("\n¿Con qué método de transporte deseas trabajar?");
            for (int i = 0; i < opciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {opciones[i].Message}");
            }
        }

        private void SeleccionarOpcion()
        {
            Console.Write("\nSeleccione una opción: ");
            int numOpcion = int.Parse(Console.ReadLine()) - 1;

            if (numOpcion >= 0 && numOpcion < opciones.Count)
            {
                opciones[numOpcion].Action.Invoke();
            }
            else
            {
                Console.WriteLine("La opción no es válida.");
            }
        }

        private void HacerCarro()
        {
            Carro carro = new Carro("Carroo");
            SubMenu(carro);
        }

        private void HacerAvion()
        {
            Avion avion = new Avion("Avioon");
            SubMenu(avion);
        }

        private void HacerBarco()
        {
            Barco barco = new Barco("Barcoo");
            SubMenu(barco);
        }
       

        //MANEJO DE SUBOPCIONES DEPENDIENDO EL TRANSPORTE Y A QUE INTERFAZ PERTENECE
        private void SubMenu(Transporte transporte)
        {
            List<Opciones> subOpciones = new List<Opciones>()//LISTA DE LOS BÁSICOS QUE REALIZA UN TRANSPORTE
            {
                new Opciones("Encender", () => Encender(transporte)),//A ESTOS METODOS SE LES DEBE MANDAR EL TIPO DE TRANSPORTE
                new Opciones("Apagar", () => Apagar(transporte)),
                new Opciones("Acelerar", () => Console.WriteLine(((IVehiculo)transporte).Acelerar())), //CASTING PARA PODER INVOCAR ACCIONES QUE NO PERTENECEN A LA CLASE TRANSPORTE
                new Opciones("Frenar", () => Console.WriteLine(((IVehiculo)transporte).Frenar())),//CASTING PARA PODER INVOCAR ACCIONES QUE NO PERTENECEN A LA CLASE TRANSPORTE
                new Opciones("Obtener velocidad", () => Console.WriteLine(((IVehiculo)transporte).ObtenerVelocidad())),//CASTING PARA PODER INVOCAR ACCIONES QUE NO PERTENECEN A LA CLASE TRANSPORTE
                new Opciones("Volver al Menú Principal", () => { /* Sale del submenú */ })
            };

            //MANEJO DE SUBINTERFACES
            //DETECTAR SI ES TERRESTRE PARA AGREGAR LAS OPCIONES DE TERRESTRE A SUBOPCIONES
            if (transporte is IVehiculoTerrestre vehiculoTerrestre) 
            {
                subOpciones.Insert(2, new Opciones("Cambiar Marcha", () => Console.WriteLine(vehiculoTerrestre.CambiarMarcha())));
                subOpciones.Insert(3, new Opciones("Chocar", () => Console.WriteLine(vehiculoTerrestre.Chocar())));
            }

            //DETECTAR SI ES AEREO PARA AGREGAR LAS OPCIONES DE AEREO A SUBOPCIONES
            if (transporte is IVehiculoAereo vehiculoAereo)
            {
                subOpciones.Insert(2, new Opciones("Despegar", () => Console.WriteLine(vehiculoAereo.Despegar())));
                subOpciones.Insert(3, new Opciones("Aterrizar", () => Console.WriteLine(vehiculoAereo.Aterrizar())));
                subOpciones.Insert(4, new Opciones("Accidente", () => Console.WriteLine(vehiculoAereo.Accidente())));
            }

            //DETECTAR SI ES ARITIMO PARA AGREGAR LAS OPCIONES DE MARITIMO A SUBOPCIONES
            if (transporte is IVehiculoMaritimo vehiculoMaritimo)
            {
                subOpciones.Insert(2, new Opciones("Anclarse", () => Console.WriteLine(vehiculoMaritimo.Anclarse())));
                subOpciones.Insert(3, new Opciones("Hundirse", () => Console.WriteLine(vehiculoMaritimo.Hundirse())));
            }

           //MUESTRA Y ELECCIÓN DE OPCIONES
            while (true)
            {
                Console.WriteLine($"\n¿Qué deseas hacer con el {transporte.Nombre()}?");
                for (int i = 0; i < subOpciones.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {subOpciones[i].Message}");
                }

                Console.Write("\nSeleccione una opción: ");
                int numSubOpcion = int.Parse(Console.ReadLine()) - 1;
                Console.Clear();

                if (numSubOpcion >= 0 && numSubOpcion < subOpciones.Count)
                {
                    subOpciones[numSubOpcion].Action.Invoke();
                    if (numSubOpcion == subOpciones.Count - 1)
                    {
                        // Sale del submenú si elige "Volver al Menú Principal"
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
        private void Encender(Transporte transporte)
        {
            Console.WriteLine(transporte.Encender());
        }

        private void Apagar(Transporte transporte)
        {
            Console.WriteLine(transporte.Apagar());
        }

    }
}
