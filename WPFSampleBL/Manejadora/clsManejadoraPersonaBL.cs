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
        public int insertarPersonaBL(clsPersona persona)
        {
            int i = new clsManejadoraPersonaDAL().insertarPersonaDAL(persona);

            return i;
        }
    }
}
