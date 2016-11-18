using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSampleBL.Manejadora;
using WPFSampleDAL.Manejadora;
using WPFSampleEntities;

namespace WPFSampleBL.Manejadora
{
    public class clsManejadoraPersonaBL
    {
        public clsPersona obtenerPersonaBL(int id)
        {
            clsPersona i = new clsManejadoraPersonaDAL().obtenerPersonaDAL(id);

            return i;
        }

        public int insertarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().insertarPersonaDAL(persona);

            return i;
        }

        public int actualizarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().actualizarPersonaDAL(persona);

            return i;
        }

        public int borrarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().borrarPersonaDAL(persona);

            return i;
        }
    }
}
