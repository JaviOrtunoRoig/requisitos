﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampusApS.Modelo.Logica.Recursos {
    class ForoRecurso {

        private string nombre;
        private string descripcion;

        public ForoRecurso(string nombre) {
            this.nombre = nombre;
        }

        public ForoRecurso(string nombre, string descripcion) {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public string getNombre() {
            return this.nombre;
        }

        public string getdescripcion() {
            return this.descripcion;
        }
    }
}