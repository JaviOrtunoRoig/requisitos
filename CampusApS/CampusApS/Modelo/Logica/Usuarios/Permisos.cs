using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CampusApS.Modelo.Logica;

namespace CampusApS.Modelo.Logica.Usuarios {
    public class Permisos {
        private bool puedeCrearCurso;
        private bool puedeBorrarCurso;
        private bool puedeCrearForo;
        private bool puedeBorrarForo;
        private bool puedeCrearActividadSocial;
        private bool puedeBorrarActividadSocial;
        private bool puedeGenerarCodigoAdmin;
        private bool puedeInscribirseCurso;

        public Permisos(bool crearCurso, bool borrarCurso, bool crearForo, bool borrarForo, bool crearActividadSocial, bool borrarActivisadSocial, bool codigoAdmin, bool inscribirseCurso) {
            this.puedeCrearCurso = crearCurso;
            this.puedeBorrarCurso = borrarCurso;
            this.puedeCrearForo = crearForo;
            this.puedeBorrarForo = borrarForo;
            this.puedeCrearActividadSocial = crearActividadSocial;
            this.puedeBorrarActividadSocial = borrarActivisadSocial;
            this.puedeGenerarCodigoAdmin = codigoAdmin;
            this.puedeInscribirseCurso = inscribirseCurso;
        }

        public bool getPuedeCrearCurso() {
            return this.puedeCrearCurso;
        }

        public bool getPuedeBorrarCurso() {
            return this.puedeBorrarCurso;
        }
        
        public bool getPuedeCrearForo() {
            return this.puedeCrearForo;
        }
        
        public bool getPuedeBorrarForo() {
            return this.puedeBorrarForo;
        }
        
        public bool getPuedeCrearActividadSocial() {
            return this.puedeCrearActividadSocial;
        }

        public bool getPuedeBorrarActividadSocial() {
            return this.puedeBorrarActividadSocial;
        }

        public bool getPuedeGenerarCodigoAdmin()
        {
            return this.puedeGenerarCodigoAdmin;
        }

        public bool getPuedeInscribirseCurso()
        {
             return this.puedeInscribirseCurso;
        }
    }
}
