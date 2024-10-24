using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;
using System.Data.Common;

namespace eaton.Rules
{
    public partial class Handler_Ultima_Carga_Etiqueta : eaton.Rules.SharedBusinessRules
    {

        [AccessControl("Etiqueta_Proveedor1_1", "Transaccion_Procesamiento", "[Transaccion_Procesamiento] = @Transaccion_Procesamiento")]
        public void RestringirPorMaxFecha()
        {
            var dt = new DataTable();
            dt = null;
            string sentenciaSQl = "";
            SqlText dataResult;
            DbDataReader Reader; 

            //sentenciaSQl = "SELECT TOP 1 MAX(Fecha_Creacion) AS Fecha_Creacion FROM APP.Etiqueta_Proveedor";
            //sentenciaSQl = "SELECT TOP 1 MAX(CONVERT(VARCHAR(16), Fecha_Creacion,121)) AS Fecha_Creacion FROM [dbo].[Grid_Etiqueta_Proveedor_V] WHERE Usuario_Sistema_Proveedor_Id = '" + UserId.ToString() + "' AND Es_Cargado_Por_Excel = 1";
            sentenciaSQl = "SELECT TOP 1 Transaccion_Procesamiento AS Transaccion_Procesamiento FROM APP.Temporal_Etiqueta_Proveedor WHERE Creado_Por_Id = '" + UserId.ToString() + "' AND Carga = ( SELECT MAX(Carga) FROM APP.Temporal_Etiqueta_Proveedor WHERE Creado_Por_Id = '" + UserId.ToString() + "')";


            try
            {
                dataResult = new SqlText(sentenciaSQl);
                Reader = dataResult.ExecuteReader();

                Guid Transaccion_Procesamiento;
                while (Reader.Read())
                {
                    Transaccion_Procesamiento = Guid.Parse(Reader["Transaccion_Procesamiento"].ToString());
                    RestrictAccess("@Transaccion_Procesamiento", Transaccion_Procesamiento.ToString());

                }


            }
            catch (Exception e)
            {
                Result.ShowMessage(e.Message);
            }

        }
    }
}
