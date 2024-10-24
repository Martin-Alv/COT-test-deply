using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using eaton.Data;
using eaton.Models;

namespace eaton.Rules
{
	public partial class Grid_Transfer_Material_Upload_VBusinessRules : eaton.Rules.SharedBusinessRules
    {
        
        /// <summary>Rule "Procesar_Mat_Cargado" implementation:
        /// This method will execute in any view after an action
        /// with a command name that matches "Custom" and argument that matches "ExecCS01".
        /// </summary>
        [Rule("r101")]
        //START public void r101Implementation(Grid_Transfer_Material_Upload_VModel instance)
        public void r101Implementation(Grid_Transfer_Material_Upload_VModel instance)
        {
            // This is the placeholder for method implementation.
            // Declaración de variables
            long Movimiento_Id = instance.Movimiento_Id ?? 0;

            if (Movimiento_Id == 0)
            {
                Result.ShowAlert("El identificador de Movimiento (Movimiento_Id) es obligatorio!");
                PreventDefault();
            }
            else
            {
                string Mensaje_Sistema = "";
                int Mensaje_Sistema_Id = 0;
                bool resultadoProcesarTransferMatUpload;

                resultadoProcesarTransferMatUpload = ProcesarTransferenciaMaterialUpload(
                    Movimiento_Id
                    , out Mensaje_Sistema
                    , out Mensaje_Sistema_Id
                    );

                //START if (resultadoProcesarTransferMatUpload == false || (resultadoProcesarTransferMatUpload == true && Mensaje_Sistema_Id != 1))
                if (resultadoProcesarTransferMatUpload == false || (resultadoProcesarTransferMatUpload == true && Mensaje_Sistema_Id != 1))
                {
                    RegistrarEnBitacora(0, Mensaje_Sistema_Id, "", Mensaje_Sistema);
                    Result.ShowMessage(Mensaje_Sistema);
                }
                else
                {
                    if (resultadoProcesarTransferMatUpload == true && Mensaje_Sistema_Id == 1)
                    {
                        Result.ShowMessage(Mensaje_Sistema);
                        Result.Refresh();
                    }
                }// END else
            }
            //
        }
        //END public void r101Implementation(Grid_Transfer_Material_Upload_VModel instance)
    }
}
