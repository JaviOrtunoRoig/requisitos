using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CampusApS.Modelo.Logica;

namespace CampusApS.Modelo.Logica {
    class Permisos {
        private bool puedeCrearCurso;
        private bool puedeBorrarCurso;
        private bool puedeCrearForo;
        private bool puedeBorrarForo;
        private bool puedeCrearActividadSocial;
        private bool puedeBorrarActividadSocial;

        public Permisos() {
            this.puedeCrearCurso = false;
            this.puedeBorrarCurso = false;
            this.puedeCrearForo = false;
            this.puedeBorrarForo = false;
            this.puedeCrearActividadSocial = false;
            this.puedeBorrarActividadSocial = false;
        }

    }
}
