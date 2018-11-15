using EntidadesNegocio;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace AccesoDatos
{
    public class MedicosDAL
    {
        public static string ConexionMedicos()
        {
            string pathBDDoctores = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            return pathBDDoctores;
        }
    }
}
