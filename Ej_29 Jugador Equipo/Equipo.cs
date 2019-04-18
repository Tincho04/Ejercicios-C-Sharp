﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_29_Jugador_Equipo
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool returnAux = false;
            if (!e.jugadores.Contains(j) && !(e.jugadores.Count >= e.cantidadDeJugadores))
            {
                e.jugadores.Add(j);
                returnAux = true;
            }
            return returnAux;
        }
    }
}
