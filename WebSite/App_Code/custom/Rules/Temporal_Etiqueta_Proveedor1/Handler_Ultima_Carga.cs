using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;
using System.Data.Common;

namespace eaton.Rules
{
    public partial class Handler_Ultima_Carga : eaton.Rules.SharedBusinessRules
    {
        [AccessControl("Temporal_Etiqueta_Proveedor1", "Carga", "[Carga] = @Carga")]
        public void RestringirPorMaxFecha()
        {
            var dt = new DataTable();
            dt = null;
            string sentenciaSQl = "";
            SqlText dataResult;
            DbDataReader Reader;

           // sentenciaSQl = "SELECT TOP 1 MAX(Fecha_Creacion) AS Fecha_Creacion FROM APP.Temporal_Etiqueta_Proveedor WHERE Creado_Por_Id = '" + UserId.ToString() + "'";

            //sentenciaSQl = "SELECT  MAX(CONVERT(VARCHAR(16), Fecha_Creacion,121)) AS Fecha_Creacion FROM APP.Temporal_Etiqueta_Proveedor WHERE Creado_Por_Id = '" + UserId.ToString() + "'";

            // sentenciaSQl = "SELECT*FROM APP.Temporal_Etiqueta_Proveedor WHERE CONVERT(VARCHAR(16),Fecha_Creacion,121) = (SELECT  MAX(CONVERT(VARCHAR(16), Fecha_Creacion,121)) AS Fecha_Creacion FROM APP.Temporal_Etiqueta_Proveedor)";
            //sentenciaSQl = "SELECT  MAX(CONVERT(VARCHAR(16), Fecha_Creacion,121)) AS Fecha_Creacion FROM APP.Temporal_Etiqueta_Proveedor";
            sentenciaSQl = "SELECT TOP 1 ISNULL(MAX(Carga),0) AS Carga FROM APP.Temporal_Etiqueta_Proveedor WHERE Creado_Por_Id = '" + UserId.ToString() + "'";

            try
            {
                dataResult = new SqlText(sentenciaSQl);
                Reader = dataResult.ExecuteReader();

                int Carga;
                while (Reader.Read())
                {
                    Carga = Convert.ToInt32(Reader["Carga"]);
                    RestrictAccess("@Carga", Carga);

                }


            }
            catch (Exception e)
            {
                Result.ShowMessage(e.Message);
            }

        }
    }
}
