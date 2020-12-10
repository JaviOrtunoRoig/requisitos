using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CampusApS.Modelo.Logica;

namespace CampusApS {
    interface Usuario {

        void crearCurso();
        void borrarCurso();
       
        void crearForo();
        void borrarForo();

        void crearActividadSocial();
        void borrarActividadSocial();

        string getRol();
        Permisos getPermisos();
        string getNombre();
    }
}
