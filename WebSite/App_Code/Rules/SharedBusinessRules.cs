using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using eaton.Data;
using System.Collections.Specialized;
using System.Net;
using System.Xml.XPath;
using System.Xml;

namespace eaton.Rules
{
	public partial class SharedBusinessRules : eaton.Data.BusinessRules
    {
        //
        Globales g = new Globales();

        public SharedBusinessRules()
        {
        }
        public override bool SupportsVirtualization(string controllerName)
        {
            if (controllerName == "Etiqueta_Perfil_Material_V1")
                return true;
            else
                return false;
        }//End  public override bool SupportsVirtualization(string controllerName)
        public override void VirtualizeController(string controllerName,
           XPathNavigator navigator, XmlNamespaceManager resolver)
        {
            if (controllerName == "Etiqueta_Perfil_Material_V1")
            {
                bool obtenerConfiguracionMaterial;
                int num_configuracion = 0;
                string campo_A_ocultar = "";
                string valorCualitativo;
                decimal valorCuantitativo;
                for (int x = 0; x < 3; x++)
                {
                    if (x == 0)
                    {
                        num_configuracion = 387;
                        campo_A_ocultar = "URL_Codigo_Material";
                    }
                    if (x == 1)
                    {
                        num_configuracion = 388;
                        campo_A_ocultar = "URL_Codigo_Cantidad";
                    }
                    if (x == 2)
                    {
                        num_configuracion = 389;
                        campo_A_ocultar = "URL_Codigo_Numero_Orden_Produccion";
                    }

                    obtenerConfiguracionMaterial = ObtenerConfiguracionSistema(num_configuracion, 1, out valorCualitativo, 0, out valorCuantitativo);
                    if (Convert.ToInt32(valorCualitativo) == 0)
                    {

                        // Mark all data fields named "Country" as "hidden"
                        XPathNodeIterator countryFieldIterator = navigator.Select(
                            "//c:dataField[@fieldName='" + campo_A_ocultar + "']",
                            resolver);
                        while (countryFieldIterator.MoveNext())
                        {
                            XPathNavigator dataFieldNav = countryFieldIterator.Current;
                            if (dataFieldNav.MoveToAttribute("hidden", String.Empty))
                                dataFieldNav.SetValue("true");
                            else
                                dataFieldNav.CreateAttribute(
                                    String.Empty, "hidden", String.Empty, "true");
                        }


                    }

                    //Limpiar variables:
                    valorCualitativo = "0";
                    campo_A_ocultar = "";
                }//Cierre del for
            }
        }// public override void VirtualizeController(string controllerName,   XPathNavigator navigator, XmlNamespaceManager resolver)

        // START private bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)
        public bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)
        {
            intValue = 0;
            strValue = "";
            try
            {
                object obj = SqlText.ExecuteScalar(SQL, g.connection);
                string getValue = "";
                if (obj == null)
                    getValue = null;
                else
                    getValue = obj.ToString();

                if (returnInt && getValue != null)
                    intValue = int.Parse(getValue);
                else if (returnStr && getValue != null)
                    strValue = getValue;
            }
            catch (Exception e)
            {
                strValue = e.Message;
                return false;
            }
            return true;
        }
        //END private bool ReturnScalarValue(string SQL, bool returnInt, out int intValue, bool returnStr, out string strValue)

        // START public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)
        public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)
        {
            mensajeSistema = "";
            int intValue = 0;
            string returnStr = "";
            bool resultadoObtenerMensajeSistema;
            string sqlCommand = "SELECT TOP 1 Mensaje_Amigable_Usuario FROM dbo.Mensaje_Sistema WHERE Mensaje_Sistema_Id = " + mensajeSistemaId.ToString();
            resultadoObtenerMensajeSistema = ReturnScalarValue(sqlCommand, false, out intValue, true, out returnStr);

            if (resultadoObtenerMensajeSistema)
            {
                mensajeSistema = returnStr;
            }
            else
            {
                mensajeSistema = "Sin mensaje de sistema";
                return false;
            }

            return true;
        }
        // END public bool obtenerMensajeSistema(int mensajeSistemaId, out string mensajeSistema)

        // START public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)
        public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)
        {
            using (SqlProcedure SqlServerCommand = new SqlProcedure("[dbo].[sp_Registrar_Bitacora]"))
            {
                try
                {
                    SqlServerCommand.Command.CommandTimeout = 60 * 10;

                    SqlServerCommand.AddParameter("@Fecha_Inicio", System.Data.SqlDbType.DateTime).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Fecha_Fin", System.Data.SqlDbType.DateTime).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Proceso_Sistema_Id", System.Data.SqlDbType.Int).Value = procesoSistemaId;
                    //SqlServerCommand.AddParameter("@Aplicacion_Id", System.Data.SqlDbType.Int).Value = mensajeDeSistemaId;
                    SqlServerCommand.AddParameter("@Mensaje_Sistema_Id", System.Data.SqlDbType.Int).Value = mensajeDeSistemaId;
                    SqlServerCommand.AddParameter("@System_Error_Number", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorSeverity", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorState", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorProcedure", System.Data.SqlDbType.NVarChar).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorLine", System.Data.SqlDbType.Int).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@System_ErrorMessage", System.Data.SqlDbType.NVarChar).Value = mensajeErrorSistema;
                    SqlServerCommand.AddParameter("@Transaccion_Id", System.Data.SqlDbType.VarChar).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Rastreo", System.Data.SqlDbType.VarChar).Value = trace;
                    SqlServerCommand.AddParameter("@Creado_Por_Id", System.Data.SqlDbType.UniqueIdentifier).Value = DBNull.Value;
                    SqlServerCommand.AddParameter("@Mostrar_Tablas_Sistema", System.Data.SqlDbType.Bit).Value = 0;
                    SqlServerCommand.AddParameter("@Simular", System.Data.SqlDbType.Bit).Value = 0;
                    SqlServerCommand.AddParameter("@Trace", System.Data.SqlDbType.VarChar).Value = trace;
                    SqlServerCommand.AddParameter("@Debug", System.Data.SqlDbType.Bit).Value = 0;

                    SqlServerCommand.ExecuteNonQuery();

                }//try
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }//catch (Exception e)
            }// END using

            return true;
        }
        // END public bool RegistrarEnBitacora(int procesoSistemaId, int mensajeDeSistemaId, string trace, string mensajeErrorSistema)

        // START public bool AdministrarSolicitudMaterial(int tipoOperacionId, Int64 ordenProduccionId,Int64 ordenProduccionDetalleId,out string mensajeSistema, out int mensajeSistemaId)
        public bool AdministrarSolicitudMaterial(int tipoOperacionId, Int64 ordenProduccionId,Int64 ordenProduccionDetalleId,out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 1; // Creación de Solicitudes de Materiales
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Administrar_Solicitud_Material]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Id", ordenProduccionId);
                    sp.AddParameter("@Orden_Produccion_Detalle_Id", ordenProduccionDetalleId);                    
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    //sp.AddParameter("@Fecha_Creacion", DBNull.Value);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    //sp.AddParameter("@Mensaje_Sistema", "");
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Mensaje_Sistema"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Mensaje_Sistema"].Size = 500;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "Ha ocurrido un error al tratar de generar las solicitudes!.";
                        else
                            mensajeSistema = "Generación de Solicitud exitosa!";
                    }
                    return true;                  
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 227;
                return false;
            }//catch (Exception e)
        }
        // END public bool AdministrarSolicitudMaterial(int tipoOperacionId, Int64 ordenProduccionId,Int64 ordenProduccionDetalleId,out string mensajeSistema, out int mensajeSistemaId)

        // START public bool GenerarRutaOptima(out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarRutaOptima(string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 2; // Generar Ruta Optima
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Generar_Ruta_Optima]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    //sp.AddParameter("@Usuario_Aplicacion_Id", UserId);
                    //Parámetros de Salida
                    sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 227;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarRutaOptima(out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool GenerarOrdenProduccionDetalle(Int64 ordenProduccionId,out string mensajeSistema, out int mensajeSistemaId)
        public bool GenerarOrdenProduccionDetalle(long ordenProduccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 0; // Generar Orden Produccion Detalle
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Orden_Produccion_Detalle]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    //sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Id", ordenProduccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar los detalles de la orden!.";
                        else
                            mensajeSistema = "Generación de Detalles exitoso!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarOrdenProduccionDetalle(Int64 ordenProduccionId,out string mensajeSistema, out int mensajeSistemaId)

        // START public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ActualizarSurtido(int tipoOperacionId, long rutaOptimaId, long materialSurtidoId, long materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, long Material_Ubicacion_Stock_Id, int motivoCancelacionId, string comentarioCancelacion, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {

            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 4;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Actualizar_Surtido_Ro]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP       
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    //sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    sp.AddParameter("@Ruta_Optima_Id", rutaOptimaId);
                    sp.AddParameter("@Material_Surtido_Id", materialSurtidoId);
                    sp.AddParameter("@Material_Id", materialId);
                    sp.AddParameter("@Cantidad_Solicitado", cantidadSolicitado);
                    sp.AddParameter("@Cantidad_Entregado", cantidadEntregado);
                    sp.AddParameter("@Unidad_Material_Entregado_Id", unidadMaterialEntregadoId);
                    sp.AddParameter("@Ubicacion_Almacenamiento_De_Surtido_Id", ubicacionAlmacenamientoDeSurtidoId);
                    sp.AddParameter("@Material_Ubicacion_Stock_Id", Material_Ubicacion_Stock_Id);
                    sp.AddParameter("@Motivo_Cancelacion_Id", motivoCancelacionId);
                    sp.AddParameter("@Comentario_Cancelacion", comentarioCancelacion);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);

                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Mensaje_Sistema", mensajeSistema);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    mensajeSistema = Convert.ToString(sp.Parameters["@Mensaje_Sistema"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    if (mensajeSistema == "" || mensajeSistema == null)
                    {
                        resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                        if (!resultadoObtenerMensajeSistema)
                        {
                            if (mensajeSistemaId != 1)
                                mensajeSistema = "00: Ha ocurrido un error al tratar de actualizar el surtido.";
                            else
                                mensajeSistema = "Actualización de surtido exitoso!";
                        }
                        else
                        if (mensajeSistemaId != 1)
                        {
                            // Indicamos mensaje id de error
                            mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                        }
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }

        // END public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ActualizarSurtidoMs(int tipoOperacionId, long rutaOptimaId, long materialSurtidoId, long materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, long materialUbicacionStockId, int motivoCancelacionId, string comentarioCancelacion, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 4;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Actualizar_Surtido_Ms]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP       
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    //sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    sp.AddParameter("@Ruta_Optima_Id", rutaOptimaId);
                    sp.AddParameter("@Material_Surtido_Id", materialSurtidoId);
                    sp.AddParameter("@Material_Id", materialId);
                    sp.AddParameter("@Cantidad_Solicitado", cantidadSolicitado);
                    sp.AddParameter("@Cantidad_Entregado", cantidadEntregado);
                    sp.AddParameter("@Unidad_Material_Entregado_Id", unidadMaterialEntregadoId);
                    sp.AddParameter("@Ubicacion_Almacenamiento_De_Surtido_Id", ubicacionAlmacenamientoDeSurtidoId);
                    sp.AddParameter("@Material_Ubicacion_Stock_Id", materialUbicacionStockId);

                    sp.AddParameter("@Motivo_Cancelacion_Id", motivoCancelacionId);
                    sp.AddParameter("@Comentario_Cancelacion", comentarioCancelacion);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Mensaje_Sistema", mensajeSistema);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Mensaje_Sistema"].Size = 8000;
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    mensajeSistema = Convert.ToString(sp.Parameters["@Mensaje_Sistema"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    if (mensajeSistema == "" || mensajeSistema == null)
                    {

                        resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                        if (!resultadoObtenerMensajeSistema)
                        {
                            if (mensajeSistemaId != 1)
                                mensajeSistema = "00: Ha ocurrido un error al tratar de actualizar el surtido.";
                            else
                                mensajeSistema = "Actualización de surtido exitoso!";
                        }
                        else
                        if (mensajeSistemaId != 1)
                        {
                            // Indicamos mensaje id de error
                            mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                        }

                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool AdministrarOrdenProduccionDetalle(int tipoOperacionId, long ordenProduccionDetalleId, decimal cantidadMatASolicitar, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool AdministrarOrdenProduccionDetalle(int tipoOperacionId, long ordenProduccionDetalleId, decimal cantidadMatASolicitar, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 6; // Administrar Orden Produccion Detalle
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Administrar_Orden_Produccion_Detalle]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Detalle_Id", ordenProduccionDetalleId);
                    sp.AddParameter("@Cantidad_Material_A_Solicitar", cantidadMatASolicitar);
                    sp.AddParameter("@Area_Entrega_Id", areaEntregaId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar el registro de orden producción detalle!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool AdministrarOrdenProduccionDetalle(int tipoOperacionId, long ordenProduccionDetalleId, decimal cantidadMatASolicitar, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool GenerarSolicitudMaterial(int tipoOperacionId, long ordenProduccionId, long ordenProduccionDetalleId, int productoId, long materialASolicitarId, decimal cantidadMatASolicitar, decimal cantidadMatRestantePorSolicitar, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarSolicitudMaterial(int tipoOperacionId, long ordenProduccionId, long ordenProduccionDetalleId, int productoId, long materialASolicitarId, decimal cantidadMatASolicitar, decimal cantidadMatRestantePorSolicitar, int areaEntregaId, int areaServicioId, int familiaId, Int16 registradoDesdeId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 7; // Generar Solicitud de Material
            bool resultadoObtenerMensajeSistema;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Solicitud_Material]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Id", ordenProduccionId);
                    sp.AddParameter("@Orden_Produccion_Detalle_Id", ordenProduccionDetalleId);
                    sp.AddParameter("@Producto_Id", productoId);
                    sp.AddParameter("@Material_A_Solicitar_Id", materialASolicitarId);
                    sp.AddParameter("@Cantidad_Material_A_Solicitar", cantidadMatASolicitar);
                    sp.AddParameter("@Cantidad_Material_Restante_Por_Solicitar", cantidadMatRestantePorSolicitar);
                    sp.AddParameter("@Area_Entrega_Id", areaEntregaId);
                    sp.AddParameter("@Area_Servicio_Id", areaServicioId);
                    sp.AddParameter("@Familia_Id", familiaId);
                    sp.AddParameter("@Registrado_Desde_Id", registradoDesdeId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la solicitud de material!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarSolicitudMaterial(int tipoOperacionId, long ordenProduccionId, long ordenProduccionDetalleId, int productoId, long materialASolicitarId, decimal cantidadMatASolicitar, decimal cantidadMatRestantePorSolicitar, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool GenerarTemporalRutaOptima(Int64 materialASolicitarId, decimal cantidadSolicitado,Int32 unidadMaterialASurtirId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarTemporalRutaOptima(Int64 materialASolicitarId, decimal cantidadSolicitado,Int32 unidadMaterialASurtirId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 8; // Generar Temporal Ruta Optima
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Generar_Temporal_Ruta_Optima]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Material_Solicitado_Id", materialASolicitarId);
                    sp.AddParameter("@Cantidad_Solicitado", cantidadSolicitado);
                    sp.AddParameter("@Unidad_Material_A_Surtir_Id", unidadMaterialASurtirId);
                    sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarTemporalRutaOptima(Int64 materialASolicitarId, decimal cantidadSolicitado,Int32 unidadMaterialASurtirId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool AdministrarOrdenProduccion(Int32 tipoOperacionId, Int64 ordenProduccionId, Int64 productoId, Int32 estatusOrdenProduccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool AdministrarOrdenProduccion(Int32 tipoOperacionId, Int64 ordenProduccionId, Int64 productoId, Int32 estatusOrdenProduccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 12; // Administrar Orden Produccion
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Administrar_Orden_Produccion]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Id",ordenProduccionId);
                    sp.AddParameter("@Producto_Id", productoId);
                    sp.AddParameter("@Estatus_Orden_Produccion_Id", estatusOrdenProduccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar la orden de producción!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool AdministrarOrdenProduccion(Int32 tipoOperacionId, Int64 ordenProduccionId, Int64 productoId, Int32 estatusOrdenProduccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool ObtenerLayoutHtmlHojaRutaOptima(/*long rutaOptimaId, string tmpRutaOptimaTransaccionId,*/ out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ObtenerLayoutHtmlHojaRutaOptima(int tipoHojaId, out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            layoutHtmlGenerado = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 12; 
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Layout_Html_Hoja_Ruta_Optima]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Hoja_Id", tipoHojaId);                    
                    sp.AddParameter("@Layout_Html_Generado", layoutHtmlGenerado);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Layout_Html_Generado"].Direction = ParameterDirection.Output;

                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Layout_Html_Generado"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);
                    layoutHtmlGenerado = sp.Parameters["@Layout_Html_Generado"].Value.ToString();

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar el PDF!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool ObtenerLayoutHtmlHojaRutaOptima(/*long rutaOptimaId, string tmpRutaOptimaTransaccionId,*/ out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool ObtenerLayoutHtmlHojaRutaOptimaPrueba(/*long rutaOptimaId, string tmpRutaOptimaTransaccionId,*/ out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ObtenerLayoutHtmlHojaRutaOptimaPrueba(int tipoHojaId, out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            layoutHtmlGenerado = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 12;
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Layout_Html_Hoja_Ruta_Optima_Prueba]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Hoja_Id", tipoHojaId);
                    sp.AddParameter("@Layout_Html_Generado", layoutHtmlGenerado);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Layout_Html_Generado"].Direction = ParameterDirection.Output;

                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Layout_Html_Generado"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);
                    layoutHtmlGenerado = sp.Parameters["@Layout_Html_Generado"].Value.ToString();

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar el PDF!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool ObtenerLayoutHtmlHojaRutaOptimaPrueba(/*long rutaOptimaId, string tmpRutaOptimaTransaccionId,*/ out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool ObtenerConfiguracionSistema(int configuracionSistemaId, int obtenerValorCualitativo, out string valorCualitativo, int obtenerValorCuantitativo, out decimal valorCuantitativo)
        public bool ObtenerConfiguracionSistema(int configuracionSistemaId, int obtenerValorCualitativo, out string valorCualitativo, int obtenerValorCuantitativo, out decimal valorCuantitativo)
        {
            valorCuantitativo = 0;
            valorCualitativo = "";

            int intValue = 0;
            string returnStr = "";

            bool resultadoObtenerConfigSistemaValorCualitativo;
            bool resultadoObtenerConfigSistemaValorCuantitativo;

            if(obtenerValorCualitativo == 1)
            {
                string sqlCommand = "SELECT TOP 1 Valor_Cualitativo FROM dbo.Configuracion_Sistema WHERE Configuracion_Sistema_Id = " + configuracionSistemaId.ToString();
                resultadoObtenerConfigSistemaValorCualitativo = ReturnScalarValue(sqlCommand, false, out intValue, true, out returnStr);

                if (resultadoObtenerConfigSistemaValorCualitativo)
                {
                    valorCualitativo = returnStr;
                }
                else
                {
                    valorCualitativo = "Sin mensaje de sistema";
                    return false;
                }
            }
            else
            if (obtenerValorCuantitativo == 1)
            {
                string sqlCommand = "SELECT TOP 1 Valor_Cuantitativo FROM dbo.Configuracion_Sistema WHERE Configuracion_Sistema_Id = " + configuracionSistemaId.ToString();
                resultadoObtenerConfigSistemaValorCuantitativo = ReturnScalarValue(sqlCommand, true, out intValue, false, out returnStr);

                if (resultadoObtenerConfigSistemaValorCuantitativo)
                {
                    valorCuantitativo = intValue;
                }
                else
                {
                    valorCualitativo = "Sin mensaje de sistema";
                    return false;
                }
            }

            return true;
        }
        // END public bool ObtenerConfiguracionSistema(int configuracionSistemaId, int obtenerValorCualitativo, out string valorCualitativo, int obtenerValorCuantitativo, out decimal valorCuantitativo)

        // START public bool GenerarPDF(string value, out string mensajeSistema)
        public bool GenerarPDF(string apiKey, string value, out string mensajeSistema)
        {
            PreventDefault();
            bool obtenerApiKey;
            string urlPdfRocket;
            string valorCualitativo;
            decimal valorCuantitativo;
            obtenerApiKey = ObtenerConfiguracionSistema(1003, 1, out valorCualitativo, 0, out
            valorCuantitativo); //PROD
            urlPdfRocket = valorCualitativo;
            
               
            //string apiKey = "52ae72cc-de0c-4e79-b7ed-82617e634029";
            NameValueCollection options = new NameValueCollection();
            options.Add("apikey", apiKey);
            options.Add("value", value);

            var client = new WebClient();
            try
            {
                byte[] reportData = client.UploadValues(urlPdfRocket, options);

                Context.Response.Clear();
                Context.Response.ContentType = "application/pdf";
                Context.Response.AddHeader("content-disposition", "attachment; filename=myfilename.pdf");
                Context.Response.AddHeader("Content-Length", reportData.Length.ToString());
                Context.Response.OutputStream.Write(reportData, 0, reportData.Length);
                mensajeSistema = "Ok";
                //return true;
            }
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                return false;
            }
            return true;
        }
        // END public bool GenerarPDF(string value, out string mensajeSistema)

        public void errorResponse(string mensajeSistemaError)
        {
            Context.Response.Clear();
            Context.Response.ContentType = "text/html";
            Context.Response.Write("Error generando etiqueta - " + mensajeSistemaError);
        }

        public bool BorrarOrdenProduccionSeleccionTemporal(string seleccionTemporalTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 13; // Borrar selección temporal de orden producción
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Borrar_Orden_Produccion_Seleccion_Temporal]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Seleccion_Temporal_Transaccion_Id", seleccionTemporalTransaccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de borrar la seleccion temporal de producción!";
                        else
                            mensajeSistema = "Borrado exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }

        public bool AdministrarMaterialSurtido(int tipoOperacionId, string tmpMaterialSurtidoTransaccionId, long materialSolicitadoId, decimal cantidadSolicitado, int ubicacionAlmacenamientoId, long materialUbicacionStockId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 8; // Generar Temporal Ruta Optima
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Administrar_Material_Surtido]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Tmp_Material_Surtido_Transaccion_Id", tmpMaterialSurtidoTransaccionId);
                    sp.AddParameter("@Material_Solicitado_Id", materialSolicitadoId);
                    sp.AddParameter("@Cantidad_Solicitado", cantidadSolicitado);
                    sp.AddParameter("@Ubicacion_Almacenamiento_Id", ubicacionAlmacenamientoId);
                    sp.AddParameter("@Material_Ubicacion_Stock_Id", materialUbicacionStockId);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }


        // START public bool ActualizarUsuarioAplicacionAcceso(int pUsuarioAplicacionAccesoId, string pNip, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ActualizarUsuarioAplicacionAcceso(int tipoOperacionId, int pUsuarioAplicacionAccesoId, string pNip, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 4;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Actualizar_Usuario_Aplicacion_Acceso]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP       
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@pUsuario_Aplicacion_Acceso_Id", pUsuarioAplicacionAccesoId);
                    sp.AddParameter("@pNip", pNip);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Mensaje_Sistema", "");
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    mensajeSistema = sp.Parameters["@Mensaje_Sistema"].Value.ToString();
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;

                    }
                    //else                    
                     //   mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;                    
                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool ActualizarUsuarioAplicacionAcceso(int pUsuarioAplicacionAccesoId, string pNip, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool ValidarUsuarioAplicacionAcceso(string userName, string password, int mensajeSistemaId, out string mensajeSistema, out int usuarioValido)
        public bool ValidarUsuarioAplicacionAcceso(string userName, string password, out int mensajeSistemaId, out string mensajeSistema, out int usuarioValido)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            usuarioValido = 0;

            // START using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Validar_Usuario_Aplicacion_Acceso]"))
            using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Validar_Usuario_Aplicacion_Acceso]"))
            {
                // START try
                try
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@UserName", userName);
                    sp.AddParameter("@Password", password);

                    //Definición de parámetros de salida
                    sp.AddParameter("@UsuarioValido", 0);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 1);
                    sp.AddParameter("@Mensaje_Sistema", "");
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                   
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema"].Direction = ParameterDirection.Output;
                    sp.Parameters["@UsuarioValido"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                                      
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Mensaje_Sistema"].Size = 8000;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Ejecución de SP
                    sp.ExecuteNonQuery();

                    // Asignamos los valores de salida
                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    mensajeSistema = Convert.ToString(sp.Parameters["@Mensaje_Sistema"].Value);
                    usuarioValido = Convert.ToInt32(sp.Parameters["@UsuarioValido"].Value);

                    if (mensajeSistemaId != 1 && usuarioValido == 0)
                    {                        
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                        return false;
                    }
                                       
                }//END try
                // START catch (Exception e)
                catch (Exception e)
                {
                    mensajeSistema = e.Message;
                    return false;

                }//END catch (Exception e)
            }// END using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Validar_Usuario_Aplicacion_Acceso]"))

            return true;
        }
        // END public bool ValidarUsuarioAplicacionAcceso(string userName, string password, int mensajeSistemaId, out string mensajeSistema, out int usuarioValido)

        // START public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ValidarDocumentoComentario(int tipoOperacionId, int registradoDesdeId, long materialId, int documentoComentarioId, long rutaOptimaId, long materialSurtidoId, out  string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            //procesoSistemaId = 4;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Validar_Documento_Comentario]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP       
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Registrado_Desde_Id", registradoDesdeId);
                    sp.AddParameter("@Material_Id", materialId);
                    sp.AddParameter("@Documento_Comentario_Id", documentoComentarioId);
                    sp.AddParameter("@Ruta_Optima_Id", rutaOptimaId);
                    sp.AddParameter("@Material_Surtido_Id", materialSurtidoId);
                    //sp.AddParameter("@Solicitud_Material", solicitudMaterial);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Mensaje_Sistema", mensajeSistema);
                    //sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    //sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    //sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                   // procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de actualizar el surtido.";
                        else
                            mensajeSistema = "Actualización de surtido exitoso!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }
                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool ActualizarSurtido( int tipoOperacionId, string tmpRutaOptimaTransaccionId, Int64 rutaOptimaId, Int64 materialId, decimal cantidadSolicitado, decimal cantidadEntregado, int unidadMaterialEntregadoId, int ubicacionAlmacenamientoDeSurtidoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool AdministrarMaterialAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId, string materialAgrupadoDeMultipleOrdenProdTransaccionId, long materialId, decimal cantidadMaterialASolicitar, string materialOrdenProduccion, string materialProducto ,string materialOrdenProduccionDetalle , out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool AdministrarMaterialAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId, string materialAgrupadoDeMultipleOrdenProdTransaccionId, long materialId, decimal cantidadMaterialASolicitar, string materialOrdenProduccion, string materialProducto ,string materialOrdenProduccionDetalle, int areaEntregaId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 6; // Administrar Orden Produccion Detalle
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Administrar_Material_Agrupado_De_Multiple_Orden_Produccion]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Material_Agrupado_De_Multiple_Orden_Produccion_Id", materialAgrupadoDeMultipleOrdenProdId);
                    sp.AddParameter("@Material_Agrupado_De_Multiple_Orden_Produccion_Transaccion_Id", materialAgrupadoDeMultipleOrdenProdTransaccionId);
                    sp.AddParameter("@Material_Id", materialId);
                    sp.AddParameter("@Cantidad_Material_A_Solicitar", cantidadMaterialASolicitar);
                    sp.AddParameter("@Material_Orden_Produccion", materialOrdenProduccion);
                    sp.AddParameter("@Material_Producto", materialProducto);
                    sp.AddParameter("@Material_Orden_Produccion_Detalle", materialOrdenProduccionDetalle);
                    sp.AddParameter("@Area_Entrega_Id", areaEntregaId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);                   
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;                    
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;                   
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar el registro de material agrupado!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool AdministrarMaterialAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId, string materialAgrupadoDeMultipleOrdenProdTransaccionId, long materialId, decimal cantidadMaterialASolicitar, string materialOrdenProduccion, string materialProducto ,string materialOrdenProduccionDetalle , out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool GenerarSolicitudMaterialDeMatAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId, string materialAgrupadoDeMultipleOrdenProdTransaccionId, long materialId, decimal cantidadMaterialASolicitar, string materialOrdenProduccion, string materialOrdenProduccionDetalle , out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarSolicitudMaterialDeMatAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId,long materialId, decimal cantidadMaterialASolicitar, decimal cantidadMaterialRestantePorSolicitar, string materialOrdenProduccion,string materialOrdenProduccionDetalle, int areaEntregaId, Int16 registradoDesdeId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 6; // Administrar Orden Produccion Detalle
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Solicitud_Material_De_Mat_Agrupado_De_Multiple_Orden_Produccion]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Material_Agrupado_De_Multiple_Orden_Produccion_Id", materialAgrupadoDeMultipleOrdenProdId);                    
                    sp.AddParameter("@Material_A_Solicitar_Id", materialId);
                    sp.AddParameter("@Cantidad_Material_A_Solicitar", cantidadMaterialASolicitar);
                    sp.AddParameter("@Cantidad_Material_Restante_Por_Solicitar", cantidadMaterialRestantePorSolicitar);
                    sp.AddParameter("@Material_Orden_Produccion", materialOrdenProduccion);
                    sp.AddParameter("@Material_Orden_Produccion_Detalle", materialOrdenProduccionDetalle);
                    sp.AddParameter("@Area_Entrega_Asignada_Id", areaEntregaId);
                    //Parámetros para el control de la solicitud
                    sp.AddParameter("@Registrado_Desde_Id", registradoDesdeId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar el registro de material agrupado!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarSolicitudMaterialDeMatAgrupadoDeMultipleOrdenProduccion(int tipoOperacionId, long materialAgrupadoDeMultipleOrdenProdId, string materialAgrupadoDeMultipleOrdenProdTransaccionId, long materialId, decimal cantidadMaterialASolicitar, string materialOrdenProduccion, string materialOrdenProduccionDetalle , out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        //START METODOS MÓDULO DEVOLUCIONES Y TRANSFERENCIAS
        //-------------------------------------------------

        //START public bool GenerarTmpMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)
        public bool GenerarTmpMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Generar_Tmp_Mov_Ruta_Optima]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Movimiento_Id", Movimiento_Id);
                    sp.AddParameter("@Tipo_Movimiento_Id", Tipo_Movimiento_Id);
                    sp.AddParameter("@Tmp_Mov_Ruta_Optima_Transaccion_Id", tmpMovRutaOptimaTransaccionId);
                    //sp.AddParameter("@Tmp_Mov_Ruta_Optima_Transaccion", DBNull.Value);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Size = 80;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                //procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool GenerarTmpMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)

        //START public bool GenerarMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)
        public bool GenerarMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Generar_Mov_Ruta_Optima]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    //sp.AddParameter("@Movimiento_Id", Movimiento_Id);
                    sp.AddParameter("@Tmp_Mov_Ruta_Optima_Transaccion_Id", tmpMovRutaOptimaTransaccionId);
                    sp.AddParameter("@Tipo_Movimiento_Id", Tipo_Movimiento_Id);                    
                    //sp.AddParameter("@Tmp_Mov_Ruta_Optima_Transaccion", DBNull.Value);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Size = 80;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                //procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool GenerarMovRutaOptima(Int64 Movimiento_Id, int Tipo_Movimiento_Id, string tmpMovRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId)

        //START public bool ObtenerMaterialesDeUbicacionOrigen(long MovimientoId, int UbicacionOrigenId, int UbicacionDestinoId, int AreaEntregaId, out string mensajeSistema, out int mensajeSistemaId)
        public bool ObtenerMaterialesDeUbicacionOrigen(long MovimientoId, int UbicacionOrigenId, int UbicacionDestinoId, int AreaEntregaId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Obtener_Ubicacion_Material]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP      
                    //----- Parametros de entrada --              
                    sp.AddParameter("@Movimiento_Id", MovimientoId);
                    sp.AddParameter("@Ubicacion_Origen_Id", UbicacionOrigenId);
                    sp.AddParameter("@Ubicacion_Destino_Id", UbicacionDestinoId);
                    sp.AddParameter("@Area_Entrega_Id", AreaEntregaId);
                    //----- Parametros de salida --
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);                    
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de obtener los materiales!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool ObtenerMaterialesDeUbicacionOrigen(long MovimientoId, int UbicacionOrigenId, int UbicacionDestinoId, int AreaEntregaId, out string mensajeSistema, out int mensajeSistemaId)

        //START public bool ActualizarMovimientoMaterial(int TipoOperacionId, long MovimientoRutaOptimaId, int TipoMovimientoId, long DevolucionMaterialId, decimal CantidadADevolver, decimal CantidadDevuelto, int UnidadMaterialDevueltoId, int DevUbicacionAlmacenamientoId, out string mensajeSistema, out int mensajeSistemaId)
        public bool ActualizarMovimientoMaterial(int TipoOperacionId, long MovimientoRutaOptimaId, int TipoMovimientoId
            ,long DevolucionMaterialId, decimal CantidadADevolver, decimal CantidadDevuelto, int UnidadMaterialDevueltoId, int DevUbicacionAlmacenamientoId, long Dev_Material_Ubicacion_Stock_Id
            , long TransferenciaMaterialId, decimal CantidadATransferir, decimal CantidadTransferido, int UnidadMaterialTransferidoId, int TransferUbicacionAlmacenamientoId, long Transfer_Material_Ubicacion_Stock_Id
            , string Movimiento, string Tmp_Mov_Ruta_Optima_Transaccion_Id
            , int Motivo_Cancelacion_Id, string Comentario_Cancelacion
            ,out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Actualizar_Movimiento_Material]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP      
                    //----- Parametros de entrada --              
                    sp.AddParameter("@Tipo_Operacion_Id", TipoOperacionId);
                    sp.AddParameter("@Movimiento_Ruta_Optima_Id", MovimientoRutaOptimaId);
                    sp.AddParameter("@Tipo_Movimiento_Id", TipoMovimientoId);
                    //Para devoluciones
                    sp.AddParameter("@Devolucion_Material_Id", DevolucionMaterialId);
                    sp.AddParameter("@Cantidad_A_Devolver", CantidadADevolver);
                    sp.AddParameter("@Cantidad_Devuelto", CantidadDevuelto);
                    sp.AddParameter("@Unidad_Material_Devuelto_Id", UnidadMaterialDevueltoId);
                    sp.AddParameter("@Devolucion_Ubicacion_Almacenamiento_Id", DevUbicacionAlmacenamientoId);
                    sp.AddParameter("@Devolucion_Material_Ubicacion_Stock_Id", Dev_Material_Ubicacion_Stock_Id);
                    //Para transferencias
                    sp.AddParameter("@Transferencia_Material_Id", TransferenciaMaterialId);
                    sp.AddParameter("@Cantidad_A_Transferir", CantidadATransferir);
                    sp.AddParameter("@Cantidad_Transferido", CantidadTransferido);
                    sp.AddParameter("@Unidad_Material_Transferido_Id", UnidadMaterialTransferidoId);
                    sp.AddParameter("@Transferencia_Ubicacion_Almacenamiento_Id", TransferUbicacionAlmacenamientoId);
                    sp.AddParameter("@Transfer_Material_Ubicacion_Stock_Id", Transfer_Material_Ubicacion_Stock_Id);
                    //
                    sp.AddParameter("@Movimiento", Movimiento);
                    sp.AddParameter("@Tmp_Mov_Ruta_Optima_Transaccion_Id", Tmp_Mov_Ruta_Optima_Transaccion_Id);
                    sp.AddParameter("@Motivo_Cancelacion_Id", Motivo_Cancelacion_Id);
                    sp.AddParameter("@Comentario_Cancelacion", Comentario_Cancelacion);
                    //----- Parametros de salida --
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de actualizar el movimiento del material!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool ActualizarMovimientoMaterial(int TipoOperacionId, long MovimientoRutaOptimaId, int TipoMovimientoId, long DevolucionMaterialId, decimal CantidadADevolver, decimal CantidadDevuelto, int UnidadMaterialDevueltoId, int DevUbicacionAlmacenamientoId, out string mensajeSistema, out int mensajeSistemaId)

        //START public bool ProcesarTransferenciaMaterialUpload(long MovimientoId, out string mensajeSistema, out int mensajeSistemaId)
        public bool ProcesarTransferenciaMaterialUpload(long MovimientoId, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {
                using (SqlProcedure sp = new SqlProcedure("[dbo].[sp_Procesar_Transferencia_Material_Upload]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP      
                    //----- Parametros de entrada --              
                    sp.AddParameter("@Movimiento_Id", MovimientoId);
                    //----- Parametros de salida --
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de procesar los materiales!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool ProcesarTransferenciaMaterialUpload(long MovimientoId, out string mensajeSistema, out int mensajeSistemaId)

        //END METODOS MÓDULO DEVOLUCIONES Y TRANSFERENCIAS
        //-------------------------------------------------

        //START METODOS MÓDULO INCANDESCENCIAS - PICKEO
        //-------------------------------------------------

        //START public bool AdministrarOrdenProduccionPickeo(int tipoOperacionId, long ordenProduccionId, long numeroOrdenProduccion, long productoId, int areaServicioId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool AdministrarOrdenProduccionPickeo(int tipoOperacionId, long ordenProduccionId, long numeroOrdenProduccion, long productoId, int areaServicioId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 12; // Administrar Orden Produccion
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Administrar_Orden_Prod_Pickeo]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Orden_Produccion_Id", ordenProduccionId);
                    sp.AddParameter("@Numero_Orden_Produccion", numeroOrdenProduccion);
                    sp.AddParameter("@Producto_Id", productoId);
                    sp.AddParameter("@Area_Servicio_Id", areaServicioId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar la orden de producción!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool AdministrarOrdenProduccionPickeo(int tipoOperacionId, long ordenProduccionId, long numeroOrdenProduccion, long productoId, int areaServicioId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        //START public bool GenerarSolicitudMatPickeo(int Tipo_Operacion_Id, long Orden_Produccion_Id, int Producto_Id, long Orden_Produccion_Detalle_Id, long Material_Id, decimal Cantidad_A_Solicitar, int Area_Entrega_Id, string Transaccion_Tmp_Id, out string mensajeSistema, out int mensajeSistemaId)
        public bool GenerarSolicitudMatPickeo(int Tipo_Operacion_Id, long Orden_Produccion_Id, int Producto_Id, long Orden_Produccion_Detalle_Id, long Material_Id, decimal Cantidad_A_Solicitar, int Area_Entrega_Id, string Transaccion_Tmp_Id, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Solicitud_Material_Pickeo]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Operacion_Id", Tipo_Operacion_Id);
                    sp.AddParameter("@Orden_Produccion_Id", Orden_Produccion_Id);
                    sp.AddParameter("@Producto_Id", Producto_Id);
                    sp.AddParameter("@Orden_Produccion_Detalle_Id", Orden_Produccion_Detalle_Id);
                    sp.AddParameter("@Material_Id", Material_Id);
                    sp.AddParameter("@Cantidad_A_Solicitar", Cantidad_A_Solicitar);
                    sp.AddParameter("@Area_Entrega_Id", Area_Entrega_Id);
                    sp.AddParameter("@Transaccion_Tmp_Id", Transaccion_Tmp_Id);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    //sp.Parameters["@Tmp_Mov_Ruta_Optima_Transaccion"].Size = 80;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                //procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool GenerarSolicitudMatPickeo(int Tipo_Operacion_Id, long Orden_Produccion_Id, int Producto_Id, long Orden_Produccion_Detalle_Id, long Material_Id, decimal Cantidad_A_Solicitar, int Area_Entrega_Id, string Transaccion_Tmp_Id, out string mensajeSistema, out int mensajeSistemaId)

        //START  public bool GenerarTmpRutaOptimaIncan(long ordenProduccionId, long numeroOrdenProduccion, string solicitudesMaterial, string materialesId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarTmpRutaOptimaIncan(long ordenProduccionId, long numeroOrdenProduccion, string solicitudesMaterial, string materialesId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            //procesoSistemaId = ; // Generar Temporal Ruta Optima
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Temporal_Ruta_Optima_Incan]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Orden_Produccion_Id", ordenProduccionId);
                    sp.AddParameter("@Numero_Orden_Produccion", numeroOrdenProduccion);
                    sp.AddParameter("@Orden_Solicitud", solicitudesMaterial);
                    sp.AddParameter("@Material", materialesId);
                    sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END  public bool GenerarTmpRutaOptimaIncan(long ordenProduccionId, long numeroOrdenProduccion, string solicitudesMaterial, string materialesId, string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        // START public bool GenerarRutaOptimaIncan(string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool GenerarRutaOptimaIncan(string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {   
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 0; // Generar Ruta Optima
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Ruta_Optima_Incan]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                                        
                    sp.AddParameter("@Tmp_Ruta_Optima_Transaccion_Id", tmpRutaOptimaTransaccionId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar la ruta optima!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarRutaOptimaIncan(string tmpRutaOptimaTransaccionId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        //END METODOS MÓDULO INCANDESCENCIAS - PICKEO
        //-------------------------------------------------

        //START public bool ObtenerLayoutHtmlHojaCaptura(int tipoHojaId, out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        public bool ObtenerLayoutHtmlHojaCaptura(int tipoHojaId, out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            layoutHtmlGenerado = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 12;
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Generar_Html_Hoja_Captura]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                    
                    sp.AddParameter("@Tipo_Hoja_Id", tipoHojaId);
                    sp.AddParameter("@Layout_Html_Generado", layoutHtmlGenerado);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Layout_Html_Generado"].Direction = ParameterDirection.Output;

                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP                       
                    sp.Parameters["@Layout_Html_Generado"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);
                    layoutHtmlGenerado = sp.Parameters["@Layout_Html_Generado"].Value.ToString();

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar el PDF!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0;
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        //END public bool ObtenerLayoutHtmlHojaCaptura(int tipoHojaId, out string layoutHtmlGenerado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)



        // START public bool AdministrarSolicitudCadista(int tipoOperacionId, long solicitudId, out string mensajeSistema, out int mensajeSistemaId)
        public bool AdministrarSolicitudCadista(int tipoOperacionId, long solicitudId, out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Administrar_Solicitudes_Cadista]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Solicitud_Id", solicitudId);
                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al administrar la solicitud cadista";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1293; // Ha ocurrido un error en la invocación de AdministrarSolicitudCadista
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarRutaOptima(int tipoOperacionId, long solicitudId, out string mensajeSistema, out int mensajeSistemaId)


        // START public bool GenerarEtiquetaDetalleProveedor(int etiquetaProveedorId, out string mensajeSistema, out int mensajeSistemaId)
        public bool GenerarEtiquetaDetalleProveedor(int etiquetaProveedorId, out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Generar_Etiqueta_Detalle_Proveedor]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Etiqueta_Proveedor_Id", etiquetaProveedorId);
                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarEtiquetaDetalleProveedor(int etiquetaProveedorId, out string mensajeSistema, out int mensajeSistemaId)

        public bool GenerarLayoutEtiquetaProveedor(int Tipo_Operacion_Id, int Etiqueta_Proveedor_Id, int Etiqueta_Detalle_Proveedor_Id, int Tipo_Etiqueta_Id, int Tamanio_Etiqueta_Id, out string Layout_HTML_Generado, out string Page_Size, out string PageWidth, out string PageHeight, out string Landscape, out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            Layout_HTML_Generado = "";
            Page_Size = "";
            PageWidth = "";
            PageHeight = "";
            Landscape = "";
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Generar_Layout_Etiqueta_Proveedor]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", Tipo_Operacion_Id);
                    sp.AddParameter("@Etiqueta_Proveedor_Id", Etiqueta_Proveedor_Id);
                    sp.AddParameter("@Etiqueta_Detalle_Proveedor_Id", Etiqueta_Detalle_Proveedor_Id);
                    sp.AddParameter("@Tipo_Etiqueta_Id", Tipo_Etiqueta_Id);
                    sp.AddParameter("@Tamanio_Etiqueta_Id", Tamanio_Etiqueta_Id);

                    //Parámetros de Salida
                    sp.AddParameter("@Layout_HTML_Generado", Layout_HTML_Generado);
                    sp.AddParameter("@Page_Size", Page_Size);
                    sp.AddParameter("@PageWidth", PageWidth);
                    sp.AddParameter("@PageHeight", PageHeight);
                    sp.AddParameter("@Landscape", Landscape);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Layout_HTML_Generado"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Page_Size"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageWidth"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageHeight"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Landscape"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Layout_HTML_Generado"].Size = 10000;
                    sp.Parameters["@Page_Size"].Size = 10000;
                    sp.Parameters["@PageWidth"].Size = 10000;
                    sp.Parameters["@PageHeight"].Size = 10000;
                    sp.Parameters["@Landscape"].Size = 10000;
                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    Layout_HTML_Generado = Convert.ToString(sp.Parameters["@Layout_HTML_Generado"].Value);
                    Page_Size = Convert.ToString(sp.Parameters["@Page_Size"].Value);
                    PageWidth = Convert.ToString(sp.Parameters["@PageWidth"].Value);
                    PageHeight = Convert.ToString(sp.Parameters["@PageHeight"].Value);
                    Landscape = Convert.ToString(sp.Parameters["@Landscape"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarEtiquetaDetalleProveedor(int etiquetaProveedorId, out string mensajeSistema, out int mensajeSistemaId)
        // END public bool GenerarEtiquetaDetalleProveedor(int etiquetaProveedorId, out string mensajeSistema, out int mensajeSistemaId)

        public bool ProcesarEtiquetaMasivamente( out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Procesar_Temporal_Etiqueta_Proveedor]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    

                    //Parámetros de Salida
                    
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;
                   
                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                   
                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }

        public bool GenerarLayoutCapturaRecivosEtiquetas(int Tipo_Operacion_Id, string Etiqueta_Proveedor, int Etiqueta_Proveedor_Id, out string Layout_HTML_Generado, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            Layout_HTML_Generado = "";
            procesoSistemaId = 12;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Generar_Hoja_Captura_Etiqueta]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Tipo_Operacion_Id", Tipo_Operacion_Id);
                    sp.AddParameter("@Etiqueta_Proveedor", Etiqueta_Proveedor);
                    sp.AddParameter("@Etiqueta_Proveedor_Id", Etiqueta_Proveedor_Id);

                    //Parámetros de Salida
                    sp.AddParameter("@Layout_Html_Generado", Layout_HTML_Generado);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Layout_Html_Generado"].Direction = ParameterDirection.Output;


                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Layout_Html_Generado"].Size = 10000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    Layout_HTML_Generado = Convert.ToString(sp.Parameters["@Layout_Html_Generado"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);


                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }

        public bool ValidarEtiquetas(string Folio_Etiqueta_Embarque, string Material_Tarima, string SOrde_SItem_Tarima, string Delivery,string SOrde_SItem_Packing_List,string Delivery_Packing_List,decimal? Cantidad, int Validar,int Seccion_Capturada ,out string resultadoValidacion, long Escaneo_Validador_Embarque_Id,out long Escaneo_Validador_Embarque_Id_Out, string Transaccion_Escaneo, out string Transaccion_Escaneo_Out, out string mensajeSistema, out int mensajeSistemaId, out string  Trace)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;
            resultadoValidacion = "";
            Trace = "";
            Escaneo_Validador_Embarque_Id_Out = Escaneo_Validador_Embarque_Id;
            Transaccion_Escaneo_Out = Transaccion_Escaneo;
            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Procesar_Validaciones_Etiquetas]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Seccion_Capturada", Seccion_Capturada);
                    sp.AddParameter("@Etiqueta_Embarque_Detalle", Folio_Etiqueta_Embarque);
                    sp.AddParameter("@SOrden_SItem_Tarima", SOrde_SItem_Tarima);
                    sp.AddParameter("@Material_Tarima", Material_Tarima);
                    //Paso 2
                    sp.AddParameter("@Delivery", Delivery);
                    //Paso 3

                    sp.AddParameter("@SOrden_SItem_PackingLIst",SOrde_SItem_Packing_List);
                    sp.AddParameter("@Delivery_Packing_List", Delivery_Packing_List);
                    sp.AddParameter("@Validar", Validar);
                    sp.AddParameter("@Cantidad", Cantidad);
                    sp.AddParameter("@Escaneo_Validador_Embarque_Id", Escaneo_Validador_Embarque_Id);
                    sp.AddParameter("@Transaccion_Escaneo_Inicial", Transaccion_Escaneo_Out);
                    //Parámetros de Salida
                    sp.AddParameter("@Escaneo_Validador_Embarque_Id_Out", Escaneo_Validador_Embarque_Id_Out);
                    sp.AddParameter("@Resultado_Validacion", resultadoValidacion);
                    sp.AddParameter("@Transaccion_Escaneo", Transaccion_Escaneo_Out);


                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                  //  sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                   
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Resultado_Validacion"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Escaneo_Validador_Embarque_Id_Out"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Transaccion_Escaneo"].Direction = ParameterDirection.Output;


                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Resultado_Validacion"].Size = 10000;
                    sp.Parameters["@Escaneo_Validador_Embarque_Id_Out"].Size = 6;
                    sp.Parameters["@Transaccion_Escaneo"].Size = 50;
                    

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    resultadoValidacion = Convert.ToString(sp.Parameters["@Resultado_Validacion"].Value);
                   Trace= Convert.ToString(sp.Parameters["@Trace"].Value);
                    Escaneo_Validador_Embarque_Id_Out = Convert.ToInt64(sp.Parameters["@Escaneo_Validador_Embarque_Id_Out"].Value);
                    Transaccion_Escaneo_Out = Convert.ToString(sp.Parameters["@Transaccion_Escaneo"].Value);


                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al validar las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Sp_Procesar_Validaciones_Etiquetas
                return false;
            }//catch (Exception e)
        }// public bool ValidarEtiquetas(int Etiqueta_Embarque_Detalle_Id, string Material_Tarima, string SOrde_SItem_Tarima, long Delivery_Id,string SOrde_SItem_Packing_List,string Delivery_Packing_List,long Delivery_Dos, decimal Cantidad, int Validar,int Seccion_Capturada ,out string resultadoValidacion, out string mensajeSistema, out int mensajeSistemaId, out string  Trace)

        public bool ProcesarTemporalEtiquetaProveedorUsuarioCooper(out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Procesar_Temporal_Etiqueta_Proveedor_Usuario_Cooper]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP


                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId.ToString());
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de procesar las etiquetas de forma masiva.";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 0; // Ha ocurrido un error en la invocación de Procesar_Temporal_Etiqueta_Proveedor_Usuario_Cooper
                return false;
            }//catch (Exception e)
        }// END ProcesarTemporalEtiquetaProveedorUsuarioCooper(out string mensajeSistema, out int mensajeSistemaId)


        public bool ProcesarMaterialClasificacion(out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Procesar_Temporal_Material_Clasificacion]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP


                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }

        public bool ProcesarInventarioLx03(int Registrado_Desde, out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Procesar_Carga_Temporal_lx03_Inventario]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Registrado_Desde", Registrado_Desde);

                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }

        public bool ProcesarInventarioZinv(int Registrado_Desde, out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[sp_Procesar_Carga_Temporal_ZINV_Inventario]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP
                    sp.AddParameter("@Registrado_Desde", Registrado_Desde);

                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1322; // Ha ocurrido un error en la invocación de Generar_Etiqueta_Detalle_Proveedor
                return false;
            }//catch (Exception e)
        }

        public bool administrarMovimiento(int tipoOperacionId, long MovimientoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            procesoSistemaId = 0; // Administrar Movimiento
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Administrar_Movimiento]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                                        
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Movimiento_Id", MovimientoId);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Proceso_Sistema_Id"].Size = 4;

                    //Definición parámetro para recibir el return
                    sp.AddParameter("RetVal", 0);
                    sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    procesoSistemaId = Convert.ToInt32(sp.Parameters["@Proceso_Sistema_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de administrar el movimiento!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1406; // Ocurrió un error en la invocación de proceso Administrar_Movimiento (SBR.administrarMovimiento).
                procesoSistemaId = 0;
                return false;
            }//catch (Exception e)
        }
        // END public bool administrarMovimiento(int tipoOperacionId, long MovimientoId, out string mensajeSistema, out int mensajeSistemaId, out int procesoSistemaId)

        public bool GenerarDetallesEtiquetaEmbarque(int etiquetaEmbarqueId, int Operacion, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;
            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Detalles_Etiqueta_Embarque]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                                        
                    sp.AddParameter("@Etiqueta_Embarque_Id", etiquetaEmbarqueId);
                    sp.AddParameter("@Tipo_Operacion_Id", Operacion);
                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    // sp.Parameters["@Proceso_Sistema_Id"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    //sp.Parameters["@Proceso_Sistema_Id"].Size = 4;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);


                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar los detalles de etiqueta embarque!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1425; // Ocurrió un error en la invocación de proceso Generar detalles etiqueta embarque (SBR.GenerarDetallesEtiquetaEmbarque).
                return false;
            }//catch (Exception e)
        }

        // END public bool GenerarDetallesEtiquetaEmbarque(int etiquetaEmbarqueId, out string mensajeSistema, out int mensajeSistemaId)

        public bool GenerarLayoutEtiquetaEmbarque(int tipoOperacionId, int etiquetaEmbarqueId, int etiquetaEmbarqueDetalleId, int tamanioEtiquetaId, out string layoutHTMLGenerado, out string pageSize, out string pageWidth, out string pageHeight, out string landscape, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;

            layoutHTMLGenerado = "";
            pageSize = "";
            pageWidth = "";
            pageHeight = "";
            landscape = "";

            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Layout_Etiqueta_Embarque]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                                        
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Etiqueta_Embarque_Id", etiquetaEmbarqueId);
                    sp.AddParameter("@Etiqueta_Embarque_Detalle_Id", etiquetaEmbarqueDetalleId);
                    sp.AddParameter("@Tamanio_Etiqueta_Id", tamanioEtiquetaId);
                    sp.AddParameter("@Layout_HTML_Generado", layoutHTMLGenerado);
                    sp.AddParameter("@Page_Size", pageSize);
                    sp.AddParameter("@PageWidth", pageWidth);
                    sp.AddParameter("@PageHeight", pageHeight);
                    sp.AddParameter("@Landscape", landscape);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Layout_HTML_Generado"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Page_Size"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageWidth"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageHeight"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Landscape"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Layout_HTML_Generado"].Size = 10000;
                    sp.Parameters["@PageWidth"].Size = 10;
                    sp.Parameters["@PageHeight"].Size = 10;
                    sp.Parameters["@Landscape"].Size = 50;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    layoutHTMLGenerado = sp.Parameters["@Layout_HTML_Generado"].Value.ToString();
                    pageSize = sp.Parameters["@Page_Size"].Value.ToString();
                    pageWidth = sp.Parameters["@PageWidth"].Value.ToString();
                    pageHeight = sp.Parameters["@PageHeight"].Value.ToString();
                    landscape = sp.Parameters["@Landscape"].Value.ToString();


                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar el layout para la etiqueta embarque!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1426; // Ocurrió un error en la invocación de proceso Generar layout etiqueta embarque (SBR.GenerarLayoutEtiquetaEmbarque).
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarLayoutEtiquetaEmbarque(int tipoOperacionId, int etiquetaEmbarqueId, int etiquetaEmbarqueDetalleId, int tamanioEtiquetaId, out string layoutHTMLGenerado, out string pageSize, out string pageWidth, out string pageHeight, out string landscape, out string mensajeSistema, out int mensajeSistemaId)


        public bool ProcesarMaterialTemporal(out string mensajeSistema, out int mensajeSistemaId)
        {
            //RutaOptimaTransaccionId = "";
            mensajeSistema = "";
            mensajeSistemaId = 0;

            bool resultadoObtenerMensajeSistema;
            try
            {

                using (SqlProcedure sp = new SqlProcedure("dbo.[Procesar_Temporal_Carga_Masiva_Material]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP

                    //Parámetros de Salida

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    //sp.Parameters["@Ruta_Optima_Transaccion_Id"].Size = 8000;
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 100;
                    sp.Parameters["@Trace"].Size = 8000;

                    //Definición parámetro para recibir el return
                    //sp.AddParameter("RetVal", 0);
                    //sp.Parameters["RetVal"].Direction = ParameterDirection.ReturnValue;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);

                    //RutaOptimaTransaccionId = Convert.ToString(sp.Parameters["@Ruta_Optima_Transaccion_Id"].Value);

                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al genrar los detalles de las etiquetas";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1445; // Ha ocurrido un error en la invocación de Procesar_Temporal_Carga_Masiva_Material
                return false;
            }//catch (Exception e)
        }



        public bool GenerarLayoutEtiquetaEmbarqueEmpaque(int tipoOperacionId, int etiquetaEmbarqueId, int etiquetaEmbarqueDetalleId, int tamanioEtiquetaId, out string layoutHTMLGenerado, out string pageSize, out string pageWidth, out string pageHeight, out string landscape, out string mensajeSistema, out int mensajeSistemaId)
        {
            mensajeSistema = "";
            mensajeSistemaId = 0;

            layoutHTMLGenerado = "";
            pageSize = "";
            pageWidth = "";
            pageHeight = "";
            landscape = "";

            bool resultadoObtenerMensajeSistema;

            try
            {

                using (SqlProcedure sp = new SqlProcedure("[dbo].[Generar_Layout_Etiqueta_Embarque_Empaque]"))
                {
                    sp.Command.CommandTimeout = 60 * 10;

                    //Definicion Parámetros específicos del SP                                        
                    sp.AddParameter("@Tipo_Operacion_Id", tipoOperacionId);
                    sp.AddParameter("@Etiqueta_Embarque_Id", etiquetaEmbarqueId);
                    sp.AddParameter("@Etiqueta_Embarque_Detalle_Id", etiquetaEmbarqueDetalleId);
                    sp.AddParameter("@Tamanio_Etiqueta_Id", tamanioEtiquetaId);
                    sp.AddParameter("@Layout_HTML_Generado", layoutHTMLGenerado);
                    sp.AddParameter("@Page_Size", pageSize);
                    sp.AddParameter("@PageWidth", pageWidth);
                    sp.AddParameter("@PageHeight", pageHeight);
                    sp.AddParameter("@Landscape", landscape);

                    //Definición de parámetros de Sistema
                    sp.AddParameter("@Creado_Por_Id", UserId);
                    sp.AddParameter("@Transaccion_Id", DBNull.Value);
                    sp.AddParameter("@Fijar_Bitacora", 1);
                    sp.AddParameter("@Mostrar_Tablas_Sistema", 0);
                    sp.AddParameter("@Mensaje_Sistema_Id", 0);
                    // sp.AddParameter("@Proceso_Sistema_Id", 0);
                    sp.AddParameter("@Simular", 0);
                    sp.AddParameter("@Trace", "");
                    sp.AddParameter("@Debug", 0);

                    //Definición de dirección para parametros de salida                       
                    sp.Parameters["@Trace"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Mensaje_Sistema_Id"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Layout_HTML_Generado"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Page_Size"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageWidth"].Direction = ParameterDirection.Output;
                    sp.Parameters["@PageHeight"].Direction = ParameterDirection.Output;
                    sp.Parameters["@Landscape"].Direction = ParameterDirection.Output;

                    //Definición de tamaños que soporten los tipos de datos de los parametros del salida del SP   
                    sp.Parameters["@Mensaje_Sistema_Id"].Size = 4;
                    sp.Parameters["@Trace"].Size = 8000;
                    sp.Parameters["@Layout_HTML_Generado"].Size = 10000;
                    sp.Parameters["@PageWidth"].Size = 10;
                    sp.Parameters["@PageHeight"].Size = 10;
                    sp.Parameters["@Landscape"].Size = 50;

                    // Ejecutar sp
                    sp.ExecuteNonQuery();

                    mensajeSistemaId = Convert.ToInt32(sp.Parameters["@Mensaje_Sistema_Id"].Value);
                    layoutHTMLGenerado = sp.Parameters["@Layout_HTML_Generado"].Value.ToString();
                    pageSize = sp.Parameters["@Page_Size"].Value.ToString();
                    pageWidth = sp.Parameters["@PageWidth"].Value.ToString();
                    pageHeight = sp.Parameters["@PageHeight"].Value.ToString();
                    landscape = sp.Parameters["@Landscape"].Value.ToString();


                    resultadoObtenerMensajeSistema = obtenerMensajeSistema(mensajeSistemaId, out mensajeSistema);
                    if (!resultadoObtenerMensajeSistema)
                    {
                        if (mensajeSistemaId != 1)
                            mensajeSistema = "00: Ha ocurrido un error al tratar de generar el layout para la etiqueta embarque empaque!";
                        else
                            mensajeSistema = "Ejecución exitosa!";
                    }
                    else
                    if (mensajeSistemaId != 1)
                    {
                        // Indicamos mensaje id de error
                        mensajeSistema = "(" + mensajeSistemaId + "): " + mensajeSistema;
                    }

                    return true;
                }
            }//try
            catch (Exception e)
            {
                mensajeSistema = e.Message;
                mensajeSistemaId = 1426; // Ocurrió un error en la invocación de proceso Generar layout etiqueta embarque (SBR.GenerarLayoutEtiquetaEmbarque).
                return false;
            }//catch (Exception e)
        }
        // END public bool GenerarLayoutEtiquetaEmbarque(int tipoOperacionId, int etiquetaEmbarqueId, int etiquetaEmbarqueDetalleId, int tamanioEtiquetaId, out string layoutHTMLGenerado, out string pageSize, out string pageWidth, out string pageHeight, out string landscape, out string mensajeSistema, out int mensajeSistemaId)




    }//END public partial class SharedBusinessRules : eaton.Data.BusinessRules
}// END namespace
