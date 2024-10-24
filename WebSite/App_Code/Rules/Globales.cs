using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Globales
/// </summary>
public class Globales
{
    public bool debug;//CADA QUE PUBLICAMOS A PRODUCTIVO CAMBIAR A TRUE;
    public bool utilizarBaseDatosDesarrollo;//true para EatonDb_Dev, false para EatonDb
    public bool utilizarBaseDatosQA;//true EatonDb_QA,false para EatonDb
    public string connection;

    public Globales()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
        debug = false;
        utilizarBaseDatosDesarrollo = true;
        utilizarBaseDatosQA = false;

        //string connection = "";

        if (utilizarBaseDatosDesarrollo == true)
        {
            connection = "eaton";//nombre de la conexion en webconfig
        }
        else if (utilizarBaseDatosQA == true)
        {
            connection = "eatonQA";
        }
        else
        {
            connection = "EatonDb";
        }

    }
}