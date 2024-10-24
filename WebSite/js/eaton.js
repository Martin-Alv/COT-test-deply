// Declaración de variables globales
var debug = 0;
var limpiarCacheErsl = 1;

function fnDebug(object) {
    if (debug === 1) {
        console.log(object);
    }
}

if(limpiarCacheErsl == 1) {
    fnDebug("Llamar a Function LimpiarCacheErsl();");
    LimpiarCacheErsl();
}

function validaretiquetas(
    Folio_Etiqueta_Embarque_SeccionUno
    ,Material_Tarima
    ,SOrde_SItem_Tarima
    ,Delivery_Delivery
    ,SOrde_SItem_Packing_List
    ,Delivery_Packing_List
    ,Cantidad
    ,Validar
    ,Seccion_Capturada
    ,Folio_Escaneo_Id
    ,Transaccion_Escaneo
) {
	
    console.log('Realizando BR C#');
    fnDebug('Folio_Etiqueta_Embarque_SeccionUno: ' + Folio_Etiqueta_Embarque_SeccionUno);
    fnDebug('Material_Tarima: ' + Material_Tarima);
    fnDebug('SOrde_SItem_Tarima: ' + SOrde_SItem_Tarima);
    fnDebug('Delivery_Delivery: ' + Delivery_Delivery);
    fnDebug('SOrde_SItem_Packing_List: ' + SOrde_SItem_Packing_List);
    fnDebug('Delivery_Packing_List: ' + Delivery_Packing_List);
    fnDebug('Cantidad: ' + Cantidad);
    fnDebug('Validar: ' + Validar);
    fnDebug('Seccion_Capturada: ' + Seccion_Capturada);
    fnDebug('Folio_Escaneo_Id: ' + Folio_Escaneo_Id);
    fnDebug('Transaccion_Escaneo: ' + Transaccion_Escaneo);
    if(Transaccion_Escaneo === '') Transaccion_Escaneo = null;
    
	return $app.execute({
		controller: 'Escaneo_Validador_Embarque1',
		command: 'Custom',
		argument: 'ExecCS001',
		values: [
			  { name: 'Folio_Etiqueta_Embarque_SeccionUno', newValue: Folio_Etiqueta_Embarque_SeccionUno }
			, { name: 'Material_Tarima', newValue: Material_Tarima }
			, { name: 'SOrde_SItem_Tarima', newValue: SOrde_SItem_Tarima }
			, { name: 'Delivery_Delivery', newValue: Delivery_Delivery }
			, { name: 'SOrde_SItem_Packing_List', newValue: SOrde_SItem_Packing_List }
			, { name: 'Delivery_Packing_List', newValue: Delivery_Packing_List }
			// , { name: 'Delivery_Dos', newValue: Delivery_Dos }
			, { name: 'Cantidad_Material', newValue: Cantidad }
			, { name: 'Validar', newValue: Validar }
			, { name: 'Seccion_Capturada', newValue: Seccion_Capturada }
            , { name: 'Folio_Escaneo_Id', newValue: Folio_Escaneo_Id }
			, { name: 'Transaccion_Escaneo', newValue: Transaccion_Escaneo }
		]
	});
}//function validaretiquetas(

function validaretiquetasSinObligatoriedad(
    Folio_Etiqueta_Embarque_SeccionUno
    , Material_Tarima
    , SOrde_SItem_Tarima
    , Delivery_Delivery
    , SOrde_SItem_Packing_List
    , Delivery_Packing_List
    //,Delivery_Dos
    , Cantidad
    , Validar
    , Seccion_Capturada
    , Folio_Escaneo_Id
    , Transaccion_Escaneo
) {
    console.log('Realizando BR 2 C#');
    fnDebug('Folio_Etiqueta_Embarque_SeccionUno: ' + Folio_Etiqueta_Embarque_SeccionUno);
    fnDebug('Material_Tarima: ' + Material_Tarima);
    fnDebug('SOrde_SItem_Tarima: ' + SOrde_SItem_Tarima);
    fnDebug('Delivery_Delivery: ' + Delivery_Delivery);
    fnDebug('SOrde_SItem_Packing_List: ' + SOrde_SItem_Packing_List);
    fnDebug('Delivery_Packing_List: ' + Delivery_Packing_List);
    fnDebug('Cantidad: ' + Cantidad);
    fnDebug('Validar: ' + Validar);
    fnDebug('Seccion_Capturada: ' + Seccion_Capturada);
    fnDebug('Folio_Escaneo_Id: ' + Folio_Escaneo_Id);
    fnDebug('Transaccion_Escaneo: ' + Transaccion_Escaneo);
    if(Transaccion_Escaneo === '') Transaccion_Escaneo = null;

    return $app.execute({
        controller: 'Escaneo_Validador_Embarque1',
        command: 'Custom',
        argument: 'ExecCS002',
        values: [
			  { name: 'Folio_Etiqueta_Embarque_SeccionUno', newValue: Folio_Etiqueta_Embarque_SeccionUno }
			, { name: 'Material_Tarima', newValue: Material_Tarima }
			, { name: 'SOrde_SItem_Tarima', newValue: SOrde_SItem_Tarima }
			, { name: 'Delivery_Delivery', newValue: Delivery_Delivery }
			, { name: 'SOrde_SItem_Packing_List', newValue: SOrde_SItem_Packing_List }
			, { name: 'Delivery_Packing_List', newValue: Delivery_Packing_List }
			// , { name: 'Delivery_Dos', newValue: Delivery_Dos }
			, { name: 'Cantidad_Material', newValue: Cantidad }
			, { name: 'Validar', newValue: Validar }
			, { name: 'Seccion_Capturada', newValue: Seccion_Capturada }
            , { name: 'Folio_Escaneo_Id', newValue: Folio_Escaneo_Id }
            , { name: 'Transaccion_Escaneo', newValue: Transaccion_Escaneo }
        ]
    });
}//function validaretiquetas(


function agregarEventoValidadorEmbarques(){
    fnDebug('START Metodo para agregar eventos de cambio de seccion para capturar en el validador de embarques');

    // var _Transaccion_Escaneo = $app.touch.contextDataView().fieldValue('Transaccion_Escaneo','');
    const observer = new MutationObserver((mutationList) => {
    mutationList.forEach((mutation) => {
        // console.log(mutation.type);
        // console.log(mutation.attributeName);
        //console.log(mutation.target);
        if(mutation.attributeName == 'class'){
            var nodo = mutation.target;
            var id_categoria = nodo.getAttribute('data-category');
            var clase = nodo.getAttribute('class');
            if(!clase.includes('app-container-collapsed')){
                // significa que se descolapsó (se abrió)
                var seccionCapturada;
                var Num_Category = id_categoria.substring(1);
                var cat;
                var _Captura_Iniciada = $app.touch.contextDataView().fieldValue('Captura_Iniciada');
                var _Folio_Escaneo_Id = $app.touch.contextDataView().fieldValue('Folio_Escaneo_Id');

                switch(Num_Category) {
                    case '2':
                        //seccionCapturada = 1;
                        $app.input.execute({
                        values: [
                            { name: 'Resultado_Validacion', value: null }
                            , { name: 'Folio_Escaneo_Id', value: (_Captura_Iniciada == true)?null:_Folio_Escaneo_Id }

                        ]
                        });
                        cat = document.querySelector('div[data-category="c3"]');
                        cat.className = "app-container-collapsed";
                        cat = document.querySelector('div[data-category="c5"]');
                        cat.className = "app-container-collapsed";

                        $app.touch.contextDataView().updateFieldValue('Seccion_Capturada', 1);
                        $app.touch.contextDataView()._focus('Etiqueta_Embarque_Detalle_Id');
                        break;
                    case '3':
                        //seccionCapturada = 2;
                        $app.input.execute({
                        values: [
                              { name: 'Resultado_Validacion', value: null }
                            , { name: 'Folio_Escaneo_Id', value: (_Captura_Iniciada == true)?null:_Folio_Escaneo_Id }
                        ]
                        });
                        
                        cat = document.querySelector('div[data-category="c2"]');
                        cat.className = "app-container-collapsed";
                        cat = document.querySelector('div[data-category="c5"]');
                        cat.className = "app-container-collapsed";

                        $app.touch.contextDataView().updateFieldValue('Seccion_Capturada', 2);
                        $app.touch.contextDataView()._focus('Delivery_Delivery');
                        break;
                    case '5':
                        //seccionCapturada = 3;
                        $app.input.execute({
                            values: [
                                 {name: 'Resultado_Validacion', value: null }
                                ,{ name: 'Folio_Escaneo_Id', value: (_Captura_Iniciada == true)?null:_Folio_Escaneo_Id }
                            ]
                        });
                        
                        cat = document.querySelector('div[data-category="c2"]');
                        cat.className = "app-container-collapsed";
                        cat = document.querySelector('div[data-category="c3"]');
                        cat.className = "app-container-collapsed";

                        $app.touch.contextDataView().updateFieldValue('Seccion_Capturada', 3);
                        $app.touch.contextDataView()._focus('SOrde_SItem_Packing_List');
                        break;
                    default:
                        // seccionCapturada = null;
                        break;
                }
            }
        }
    })

    });
    const categorias = document.querySelectorAll('div[data-category]');
    const observerOptions = {
        attributes: true,
        childList: false,
        subtree: false
    }
    categorias.forEach((categoria) => {
        observer.observe(categoria, observerOptions);
    });

    fnDebug('END Metodo para agregar eventos de cambio de seccion para capturar en el validador de embarques');

}

function fnOpenModalNuevoValidador(Transaccion_Escaneo){

	fnDebug("Inicio fnOpenModalNuevoValidador()");
	fnDebug("Transaccion_Escaneo: " + Transaccion_Escaneo);
	//fnDebug('START ExecJS004 Execute');

    // validar si existen elementos seleccionados para deseleccionarlos antes de que se abra el modal
    if($app.touch.dataView()._selectedKeyList.length > 0){
        selected = document.querySelector('.app-grid-header span.app-btn-check.app-btn-check-selected');
        selected.click();
    }

    // crear un nuevo registro
    $app.execute({
         controller: 'Escaneo_Validador_Embarque1'
        , command: 'Insert'
        , values: [            
              { name: 'Escaneo_Validador_Embarque_Id', value: null }
            , { name: 'Transaccion_Escaneo', newValue: null }
        ]
        , done: function (result) {
            fnDebug("Insert result : ");
            fnDebug(result);

            // Consultar la transacción del rgistro creado
            $app.execute({
                controller: 'Escaneo_Validador_Embarque1',
                view: 'Escaneo_Validador_Embarque_LookUp_List',
                pageSize: 1,
                filter: [
                    { field: 'Escaneo_Validador_Embarque_Id', operator: '=', value: result.Escaneo_Validador_Embarque1.Escaneo_Validador_Embarque_Id }
                ],
                done: function (result) {
                    fnDebug("result select:");
                    fnDebug("result select Escaneo_Validador_Embarque_Id:" + result.Escaneo_Validador_Embarque1[0].Escaneo_Validador_Embarque_Id);
                    fnDebug("result select Transaccion_Escaneo:" + result.Escaneo_Validador_Embarque1[0].Transaccion_Escaneo);

                    // -------- Abrir el modal
                    $app.touch.show({
                        controller: 'Escaneo_Validador_Embarque1',
                        startCommand: 'Edit',
                        startArgument: 'FormNuevo',
                        // startArgument: 'editForm1',
                        filter: [
                            { name: 'Escaneo_Validador_Embarque_Id', value: result.Escaneo_Validador_Embarque1[0].Escaneo_Validador_Embarque_Id }
                        ],
                        defaultValues: [
                            // Seccion 1	
                            { name: 'Folio_Etiqueta_Embarque_SeccionUno', value: null }
                            ,{ name: 'SOrde_SItem_Tarima', value: null }
                            ,{ name: 'Material_Tarima', value: null } 
                            // Seccion 2
                            ,{ name: 'Delivery_Delivery', value: null } 
                            ,{ name: 'Folio_Etiqueta_Embarque_SeccionDos', value: null } 
                            ,{ name: 'SOrde_SItem_Tarima_Dos', value: null } 
                            ,{ name: 'Material_Tarima_Dos', value: null } 
                            // Seccion 3
                            ,{ name: 'SOrde_SItem_Packing_List', value: null } 
                            ,{ name: 'Delivery_Packing_List', value: null } 
                            ,{ name: 'Delivery_SeccionTres', value: null } 
                            ,{ name: 'Folio_Etiqueta_Embarque_SeccionTres', value: null } 
                            ,{ name: 'SOrde_SItem_Tarima_Tres', value: null } 
                            ,{ name: 'Material_Tarima_Tres', value: null } 
                            ,{ name: 'Cantidad_Material', value: null }
                            // resultados
                            ,{ name: 'Resultado_Validacion', value: null }
                            // ,{ name: 'Transaccion_Escaneo', value: '1a900bf8-8e4f-4f4b-88c9-282e49bb7e07' }
                            //,{ name: 'Transaccion_Escaneo', value: null }
                            // ,{ name: 'Transaccion_Escaneo', value: '' }
                            ,{ name: 'Transaccion_Escaneo', value: result.Escaneo_Validador_Embarque1[0].Transaccion_Escaneo }
                            ,{ name: 'Folio_Escaneo_Id', value: result.Escaneo_Validador_Embarque1[0].Escaneo_Validador_Embarque_Id }
                            ,{ name: 'Folio_Escaneo_Anterior', value: result.Escaneo_Validador_Embarque1[0].Escaneo_Validador_Embarque_Id }
                            ,{ name: 'Captura_Iniciada', value: false }
                            ,{ name: 'Seccion_Capturada', value: undefined }
                        ]
                    });
                }
            });

        }
    });	
	/*fnDebug("Sync Evidencia_Escaneo_Validador_Embarque1");
        $appfactory.find('Evidencia_Escaneo_Validador_Embarque1').sync();
        fnDebug("Fin Sync Evidencia_Escaneo_Validador_Embarque1");
    */
	// setTimeout(function(){ 
        // $app.input.execute({
        //     values: [
                
        //         { name: 'Seccion_Capturada', value: undefined }
        //         // Seccion 1
        //         ,{ name: 'Folio_Etiqueta_Embarque_SeccionUno', value: null }
        //         ,{ name: 'SOrde_SItem_Tarima', value: null } 
        //         ,{ name: 'Material_Tarima', value: null } 
        //         // Seccion 2
        //         ,{ name: 'Delivery_Delivery', value: null } 
        //         ,{ name: 'Folio_Etiqueta_Embarque_SeccionDos', value: null } 
        //         ,{ name: 'SOrde_SItem_Tarima_Dos', value: null } 
        //         ,{ name: 'Material_Tarima_Dos', value: null } 
        //         // Seccion 3
        //         ,{ name: 'SOrde_SItem_Packing_List', value: null } 
        //         ,{ name: 'Delivery_Packing_List', value: null } 
        //         ,{ name: 'Delivery_SeccionTres', value: null } 
        //         ,{ name: 'Folio_Etiqueta_Embarque_SeccionTres', value: null } 
        //         ,{ name: 'SOrde_SItem_Tarima_Tres', value: null } 
        //         ,{ name: 'Material_Tarima_Tres', value: null } 
        //         ,{ name: 'Cantidad_Material', value: null }
        //         // resultados
        //         ,{ name: 'Resultado_Validacion', value: null }
        //         ,{ name: 'Transaccion_Escaneo', value: '' }
        //         // ,{ name: 'Transaccion_Escaneo', value: null }
        //         ,{ name: 'Folio_Escaneo_Id', value: null }
        //         //,{ name: 'Evidencia_Escaneo_Validador_Embarque1', value: null }
        //     ]
        //     ,raiseCalculate: false
        // });
        
        // $app.touch.contextDataView().updateFieldValue('Transaccion_Escaneo', '');
        // $appfactory.find('Evidencia_Escaneo_Validador_Embarque1').sync();
  
	// }, 350);
	

	// $appfactory.find('Evidencia_Escaneo_Validador_Embarque1').sync();

	fnDebug('END ExecJS004 Execute');

	fnDebug("Fin fnOpenModalNuevoValidador()");
	// fnRefresh();
}

function fnRefresh(){
	fnDebug("Inicio fnRefresh()");
	//$appfactory.find('Evidencia_Escaneo_Validador_Embarque1').sync();
}

function fnResetSeccion_Capturada(){
	fnDebug("START fnResetSeccion_Capturada()");
    // $app.touch.contextDataView().updateFieldValue('Seccion_Capturada', undefined);
    grupo = document.querySelector('div[data-category="c2"]');
    grupo.className = "app-container-collapsed";
    grupo = document.querySelector('div[data-category="c3"]');
    grupo.className = "app-container-collapsed";
    grupo = document.querySelector('div[data-category="c5"]');
    grupo.className = "app-container-collapsed";
	//$appfactory.find('Evidencia_Escaneo_Validador_Embarque1').sync();
    fnDebug("END fnResetSeccion_Capturada()");
}





//START function LimpiarCacheErsl(){
function LimpiarCacheErsl(){
    var limpiarCacheEnGridMatPtePorSurtiConAreaAsignada = 1;
    var limpiarCacheEnConsultaEntregaSemaforAdmin = 1;
    var limpiarCacheCrearSolicitudMaterial = 1;
    var limpiarCacheEnSolicitud = 1; //Solicitud
    var limpiarCacheEnSolicitud1 = 1; //Solicitud Manual
    var limpiarCacheEnConsultaSurtidoMaterial = 1;
    var limpiarCacheEnCrearSolicMatAgrupado = 1;
    var limpiarCacheEnConsultaEntregaSemaforSolic = 1;
    var limpiarCacheEnEjecutarSurtido = 1;
    var limpiarCacheEnGridMatSurtidoAEjecutar = 1;
    var limpiarCacheEnRutaOptimaAEjecutar = 1;
    var limpiarCacheEnCrearSolMatDesdeMatAgrupadoMultOp = 1;
    var limpiarCacheEnCrearSolMatDesdeOrdenDetalleMultOp = 1;
    var limpiarCacheEnadvancedSearchFilter = 1;
    var limpiarCacheEnViewTabs = 1;

    fnDebug("limpiarCacheEnGridMatPtePorSurtiConAreaAsignada: " + limpiarCacheEnGridMatPtePorSurtiConAreaAsignada);
    fnDebug("limpiarCacheEnConsultaEntregaSemaforAdmin:" + limpiarCacheEnConsultaEntregaSemaforAdmin);
    fnDebug("limpiarCacheCrearSolicitudMaterial:" + limpiarCacheCrearSolicitudMaterial);
    fnDebug("limpiarCacheEnSolicitud:" + limpiarCacheEnSolicitud);
    fnDebug("limpiarCacheEnSolicitud1:" + limpiarCacheEnSolicitud1);
    fnDebug("limpiarCacheEnConsultaSurtidoMaterial:" + limpiarCacheEnConsultaSurtidoMaterial);
    fnDebug("limpiarCacheEnCrearSolicMatAgrupado:" + limpiarCacheEnCrearSolicMatAgrupado);
    fnDebug("limpiarCacheEnConsultaEntregaSemaforSolic:" + limpiarCacheEnConsultaEntregaSemaforSolic);
    fnDebug("limpiarCacheEnEjecutarSurtido:" + limpiarCacheEnEjecutarSurtido);
    fnDebug("limpiarCacheEnGridMatSurtidoAEjecutar:" + limpiarCacheEnGridMatSurtidoAEjecutar);
    fnDebug("limpiarCacheEnRutaOptimaAEjecutar:" + limpiarCacheEnRutaOptimaAEjecutar);
    fnDebug("limpiarCacheEnCrearSolMatDesdeMatAgrupadoMultOp:" + limpiarCacheEnCrearSolMatDesdeMatAgrupadoMultOp);
    fnDebug("limpiarCacheEnCrearSolMatDesdeOrdenDetalleMultOp:" + limpiarCacheEnCrearSolMatDesdeOrdenDetalleMultOp);

    fnDebug("START Function LimpiarCacheErsl();")

    var key = "";

    if (limpiarCacheEnGridMatPtePorSurtiConAreaAsignada == 1) {  
        var pMatPtePorSurtiConAreaAsignada = 'grid_material_pte_por_surtir_con_area_asignada_v';

        for ( key in localStorage)
            if (key.indexOf(pMatPtePorSurtiConAreaAsignada) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnConsultaEntregaSemaforAdmin == 1) {
        var pConsultaEntregaSemafor = 'consultaentregasemafor_admin';

        for ( key in localStorage)
            if (key.indexOf(pConsultaEntregaSemafor) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheCrearSolicitudMaterial == 1) {
        var pCrearSolicMat = 'crear_solicitud_material';

        for ( key in localStorage)
            if (key.indexOf(pCrearSolicMat) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnSolicitud1 == 1) {
        var pSolicitud1 = 'solicitud_1';

        for ( key in localStorage)
            if (key.indexOf(pSolicitud1) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnSolicitud == 1) {
        var pSolicitud = 'solicitud_';

        for (var key in localStorage)
            if (key.indexOf(pSolicitud) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnConsultaSurtidoMaterial == 1) {
        var pConsultaSurtidoMat = 'grid_consulta_surtido_material_v';

        for (var key in localStorage)
            if (key.indexOf(pConsultaSurtidoMat) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnCrearSolicMatAgrupado == 1) {
        var pCrearSolicMatAgrupado = 'crear_solicitud_material_grid_matagrupadomultorden_produccion_v';

        for (var key in localStorage)
            if (key.indexOf(pCrearSolicMatAgrupado) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnConsultaEntregaSemaforSolic == 1) {
        var pConsultaEntregaSemaforSolic = 'grid_consulta_entrega_semaforizada_para_retro_a_solicitante_v';

        for (var key in localStorage)
            if (key.indexOf(pConsultaEntregaSemaforSolic) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnEjecutarSurtido == 1) {
        var pEjecutarSurtido = 'ejecutar_surtido';

        for (var key in localStorage)
            if (key.indexOf(pEjecutarSurtido) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnGridMatSurtidoAEjecutar == 1) {
        var pMatSurtidoAEjecutar = 'grid_material_surtido_a_ejecutar_v';

        for (var key in localStorage)
            if (key.indexOf(pMatSurtidoAEjecutar) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnRutaOptimaAEjecutar == 1) {
        var pRutaOptimaAEjecutar = 'ruta_optima_a_ejecutar_v';

        for (var key in localStorage)
            if (key.indexOf(pRutaOptimaAEjecutar) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnCrearSolMatDesdeMatAgrupadoMultOp == 1) {
        var p1 = 'crear_solicitud_material_grid_material_agrupado_de_multiples_ordenes_produccion_v';

        for (var key in localStorage)
            if (key.indexOf(p1) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }

    if (limpiarCacheEnCrearSolMatDesdeOrdenDetalleMultOp == 1) {
        var p11 = 'crear_solicitud_material_grid_orden_detalle_de_multiple_orden_prod_v';

        for (var key in localStorage)
            if (key.indexOf(p11) >= 0) {
                localStorage.removeItem(key);
                if (debug == 1) {
                    console.log("Item removido:" + key);
                }
            }
    }
    
    //EATON___Replenishment_System_yesika_rivera_e23001ae_498c_4c26_889b_48d0bc25e854__pages_crear_solicitud_material_view1_gridOrdenProduccionPorFechaImpresionRelDate_advancedSearchFilter
    if (limpiarCacheEnadvancedSearchFilter == 1) {
        var p100 = '_advancedSearchFilter';

        for (var key in localStorage)
            if (key.indexOf(p100) >= 0) {
                localStorage.removeItem(key);
                fnDebug("Item removido:" + key);
            }
    }

    //EATON___Replenishment_System_yesika_rivera_e23001ae_498c_4c26_889b_48d0bc25e854__pages_crear_solicitud_material_view1_viewTabs
    if (limpiarCacheEnViewTabs == 1) {
        var p200 = '_viewTabs';

        for (var key in localStorage)
            if (key.indexOf(p200) >= 0) {
                localStorage.removeItem(key);
                fnDebug("Item removido:" + key);
            }
    }

    fnDebug("END Function LimpiarCacheErsl();");
    
};//function LimpiarCacheErsl()
//END function LimpiarCacheErsl(){



function BotonCerrarPersonalizado(){
    fnDebug("Personalizando botón close...");
    // identificar el botón natural de COT y removerlo
    btn = document.querySelector('.app-btn.app-btn4.app-btn-close');
    if(!btn) return;
    padre = btn.parentNode;
    padre.removeChild(btn);

    // crear un nuevo botón muy parecido al original y agregarlo al html
    var nuevoBtn = document.createElement("span");
    nuevoBtn.className = 'custom-btn custom-btn4 custom-btn-close'
    padre.appendChild(nuevoBtn);

    var cerrar = () => {
        fnDebug("Se dió clic en el botón [X]");
        // $app.touch.contextDataView().discard();
        // $app.touch.contextDataView().cancel();
        regresar = document.querySelector('a[data-action-path="ag2/a104"]');
        regresar.click()
    }

    nuevoBtn.addEventListener('click', cerrar);
    nuevoBtn.addEventListener('touchend', cerrar);

}


var reeplazarCaracter = true;
function reemplazarCaracterField(e, nombreCampo){
    if(e.keyCode == 46 || e.keyCode == 8){
        reeplazarCaracter = false;
    }
    if (reeplazarCaracter == true){
        var fieldCot = document.querySelector('span[data-control="field"][data-field="' + nombreCampo + '"] > span.app-data-input-container > input');
        var valorField = fieldCot.value;
        valorField = valorField.replace("'", "-");
        fieldCot.value = valorField;    
    }
}

function addRemplazarValoresMaterial(){   
    $('span[data-field="Material_Tarima"]').keyup(function(e){
        reemplazarCaracterField(e, 'Material_Tarima')
    })
    $('span[data-field="Material_Tarima_Dos"]').keyup(function(e){
        reemplazarCaracterField(e, 'Material_Tarima_Dos')
    })
    $('span[data-field="Material_Tarima_Tres"]').keyup(function(e){
        reemplazarCaracterField(e, 'Material_Tarima_Tres')
    })
    
    const observer = new MutationObserver((mutationList) => {
        mutationList.forEach((mutation) => {
            if(mutation.attributeName == 'class'){
                var nodo = mutation.target;
                var clase = nodo.getAttribute('class');
                if(clase.includes('app-has-focus')){
                    console.log("Campo tiene el foco");
                    reeplazarCaracter = true;
                }
            }
        })
    
    });
    const observerOptions = {
        attributes: true,
        childList: false,
        subtree: false
    }
    observer.observe(document.querySelector('span[data-control="field"][data-field="Material_Tarima"]'), observerOptions);
    observer.observe(document.querySelector('span[data-control="field"][data-field="Material_Tarima_Dos"]'), observerOptions);
    observer.observe(document.querySelector('span[data-control="field"][data-field="Material_Tarima_Tres"]'), observerOptions);

}

function ObservarModal(){
    fnDebug("Agregando observadores....");

    // este es el id del formulario que se va a observar
    identificadorModalAObservar = 'escaneo_validador_embarque1';

    const observerModalAdded = new MutationObserver((mutationList) => {
        mutationList.forEach((mutation) => {
            if (mutation.addedNodes.length > 0){
                mutation.addedNodes.forEach((nodo) => {
                    identificador = nodo.id;
                    if(identificador === 'escaneo_validador_embarque1'){
                        // Cuando el modal ya esté listo en el dom se ejecutará el siguiente código
                        // console.log('NODO AGREGADO',nodo);
                        // console.log('IDENTIFICADOR',identificador)
                        agregarEventoValidadorEmbarques();
                        BotonCerrarPersonalizado(); // función que reemplaza el botón original
                        addRemplazarValoresMaterial(); // agregar eventos para que se detecte en los campos de materiales una ' para reemplazar por -
                    }
                });
            }
        })
    });
    
    const pagina = document.querySelector('body');
    observerModalAdded.observe(pagina, {
        attributes: false,
        childList: true, // De la página solo se va a observar cuando se agreguen nuevas páginas
        subtree: false
    });
    
}


if(window.location.pathname == '/pages/validar_etiquetas'){
    ObservarModal();
}


// metodos para acceder a la camara
const formatDate = (current_datetime)=>{
    let formatted_date = current_datetime.getFullYear() + "" + (current_datetime.getMonth() + 1) + "" + current_datetime.getDate() + "" + current_datetime.getHours() + "" + current_datetime.getMinutes() + "" + current_datetime.getSeconds();
    return formatted_date;
}

function IniciarVideo(){
    const player = document.getElementById('player');
    const canvas = document.getElementById('canvas');
    canvas.style.display = "none";
    player.style.display = "block";

    const constraints = {
        video: {
            width: { min: 854, ideal: 2560, max: 3840  },
            height: { min: 480, ideal: 1440, max: 2160 },
            facingMode: "environment"
        }
    };

    navigator.mediaDevices.getUserMedia(constraints).then((stream) => {
        player.srcObject = stream;
    });

}



var tomarFoto = () => {
    const player = document.getElementById('player');
    const canvas = document.getElementById('canvas');
    const context = canvas.getContext('2d');
    canvas.style.display = "block";
    canvas.setAttribute("width", player.videoWidth);
    canvas.setAttribute("height", player.videoHeight);
    context.drawImage(player, 0, 0, player.videoWidth, player.videoHeight);
    player.style.display = "none";
    // Stop all video streams. 
    player.srcObject.getVideoTracks().forEach(track => track.stop());
}


var establecerFotoForm = () => {
    var canvaimg = document.getElementById('canvas');
    canvaimg.toBlob(function(blob) {
        fnDebug("Se convirtio a blob el canvas");
        fnDebug(blob);
        var opt = { 
            field: $app.touch.contextDataView().findField('Picture'), 
            container: '.app-drop-box', 
            files: blob 
        }
        fnDebug(opt);
        $app.upload('capture', opt);
        $app.touch.contextDataView().updateFieldValue('PictureFileName', formatDate(new Date()) + '.jpg');

    }, 'image/jpeg', 0.95);
}





//Obtenemos ruta
//var URLProtocoloDomain = window.location.protocol; // Devuelve http:
//var URLProtocoloDomain = window.location.host;//localhost:9709
//var URLProtocoloDomain = String(window.location); // Devuelve ruta absoluta http://localhost:9709/pages/crear-solicitud-material
var URLProtocoloDomain = getAbsolutePath(); // Devueve http://localhost:9709/pages/
URLProtocoloDomain = URLProtocoloDomain.replace('pages/', ''); // Retornamos como http://localhost:9709/

if (debug === 1) {
    console.log("URLProtocoloDomain: " + URLProtocoloDomain);
}

function getAbsolutePath() {
    var loc = window.location;
    var pathName = loc.pathname.substring(0, loc.pathname.lastIndexOf('/') + 1);
    return loc.href.substring(0, loc.href.length - ((loc.pathname + loc.search + loc.hash).length - pathName.length));
}

setTimeout(function () {
    preseleccionarRegistrosEnEjecutarSurtido();
},5000)

// START function abrirModalActualizarRutaOptima(RutaOptimaId, OrdenProduccionId,SolicitudId) {
function abrirModalActualizarRutaOptima(RutaOptimaId, OrdenProduccionId, SolicitudId) {

    if (debug === 1) {
        console.log("Inicia funcion abrirModalActualizarRutaOptima();");
        console.log("Valores:");
        console.log("RutaOptimaId:" + RutaOptimaId + ";");
        console.log("OrdenProduccionId:" + OrdenProduccionId + ";");
        console.log("SolicitudId:" + SolicitudId + ";");
    }

    //Declaraciones
    var htmlModalAlertifyActualizarRutaOptima = "";
    var select_Unidad_Mat_Entregado = "";

    // PENDIENTE Llenar select Unidad_Material_Entregado CON RETURN
    // var selectHtmlUnidadMaterial = obtenerSelectUnidadMaterial();
    if (debug === 1) {
        console.log("Inicia creación de div;");
    }

    //Empezamos a crear div
    htmlModalAlertifyActualizarRutaOptima += '<div class="alertifyModalDivContainer">'
    htmlModalAlertifyActualizarRutaOptima += '<div class="alertifyModalDivRow">'
    htmlModalAlertifyActualizarRutaOptima += '<label class="alertifyModalLabel">*Cantidad Entregado:</label>'
    htmlModalAlertifyActualizarRutaOptima += '</div>'
    htmlModalAlertifyActualizarRutaOptima += '<div class="alertifyModalDivRow">'
    htmlModalAlertifyActualizarRutaOptima += '<input type="text" id="Cantidad_Entregado" value="" class="alertifyModalInput"/>'
    htmlModalAlertifyActualizarRutaOptima += '</div>'
    htmlModalAlertifyActualizarRutaOptima += '<div class="alertifyModalDivRow">'
    htmlModalAlertifyActualizarRutaOptima += '<label class="alertifyModalLabel">*Unidad Material:</label>'
    htmlModalAlertifyActualizarRutaOptima += '</div>'

    //Empezamos a crear select Unidad_Material_Entregado
    select_Unidad_Mat_Entregado += '<div class="alertifyModalDivRow">';
    select_Unidad_Mat_Entregado += '<select id="Unidad_Material_Entregado" class="alertifyModalSelect">';

    // Llenamos select
    //START $app.execute({
    $app.execute({
        controller: 'Unidad_Material',
        view: 'Unidad_Material_LookUp_List',
        done: function (result) {

            if (debug === 1) {
                console.log("Result:" + result);
                //console.log("Array Unidad Material:" + result.Unidad_Material);
                console.log("Primeros valores de Array Unidad Material");
                console.log("   Unidad_Material_Id :" + result.Unidad_Material[0].Unidad_Material_Id + ";");
                console.log("   Unidad_Material:" + result.Unidad_Material[0].Unidad_Material + ";");
                console.log("Inicia  $.each(result.Unidad_Material, function (index, value) {");
            }

            // Recorremos result
            $.each(result.Unidad_Material, function (index, value) {

                if (debug === 1) {
                    console.log("Unidad_Material_Id: " + value.Unidad_Material_Id + "/ Unidad_Material: " + value.Unidad_Material + ";");
                }

                if (value.Unidad_Material_Id == 0) {
                    select_Unidad_Mat_Entregado += '<option selected value="' + value.Unidad_Material_Id + '">' + value.Unidad_Material + '</option>';
                } else {
                    select_Unidad_Mat_Entregado += '<option value="' + value.Unidad_Material_Id + '">' + value.Unidad_Material + '</option>';
                }

            });

            if (debug == 1) {
                console.log("Termina  $.each(result.Unidad_Material, function (index, value) {");
            }
        }
    }); // END $app.execute({

    // Esperamos a creacion de options del select
    setTimeout(function () {

        // Terminamos de crear select_Unidad_Mat_Entregado
        select_Unidad_Mat_Entregado += '</select>';
        select_Unidad_Mat_Entregado += '</div>';
        if (debug == 1) {
            console.log("Termina creación de select;");
        }

        htmlModalAlertifyActualizarRutaOptima += select_Unidad_Mat_Entregado;
        if (debug == 1) {
            console.log("Se agrega select Unidad_Material_Entregado a div;");
        }

        htmlModalAlertifyActualizarRutaOptima += '</div>'
        if (debug === 1) {
            console.log("Termina creación de div;");
            console.log("Div Final: " + htmlModalAlertifyActualizarRutaOptima);
        }

        // Ajustes a modal Alertify
        // set multiple settings/options
        alertify.confirm().setting({ 'modal': true, 'closable': true, 'maximizable': false });
        alertify.confirm().set('labels', {
            ok: 'Aceptar' //'<label class="alertifyModalLabelOk">Aceptar</label>'
            , cancel: 'Cancelar' //'<label class="alertifyModalLabelCancel">Cancelar</label>'
        });

        //Set header
        alertify.confirm().setHeader('<div class="alertifyModalHeader"><h1> Actualizar </h1></div>').show();
        //Set content
        alertify.confirm().setContent(htmlModalAlertifyActualizarRutaOptima).show();

        // Actions
        // Al dar clic en aceptar       
        alertify.confirm().set('onok', function (closeEvent) {

            //Obtenemos los valores 
            var CantidadEntregado = $("#Cantidad_Entregado").val() || 0;
            var UnidadMaterialEntregado = $("#Unidad_Material_Entregado").val() || 0;

            //Obligatoriedad
            if (CantidadEntregado == 0) {
                $("#Cantidad_Entregado").focus();
                return false;
            }
            if (debug === 1) {
                console.log("CantidadEntregado:" + CantidadEntregado + ";");
                console.log("UnidadMaterialEntregado:" + UnidadMaterialEntregado + ";");
            }
            // START if (CantidadEntregado > 0 ){
            if (CantidadEntregado > 0) {
                //Llamamos a funcion actualizar surtido
                ActualizarSurtido(RutaOptimaId, OrdenProduccionId, SolicitudId, CantidadEntregado, UnidadMaterialEntregado);
            }// END if (CantidadEntregado > 0 ){
        });


    }, 3000);

    if (debug == 1) {
        console.log("Termina function abrirModalActualizarRutaOptima();");
    }
}
// END function abrirModalActualizarRutaOptima(RutaOptimaId, OrdenProduccionId,SolicitudId) {

// START function ActualizarSurtido(RutaOptimaId, OrdenProduccionId, SolicitudId, CantidadEntregado, UnidadMaterialEntregado) {
function ActualizarSurtido(RutaOptimaId, OrdenProduccionId, SolicitudId, CantidadEntregado, UnidadMaterialEntregado) {

    if (debug == 1) {
        console.log("Inicia function ActualizarSurtido();");
        console.log("Inicia Ejecutar Modal_Actualizar_Ruta_Optima -> Custom -> ExecCS01;");
        console.log("Valores:");
        console.log("RutaOptimaId:" + RutaOptimaId + ";");
        console.log("OrdenProduccionId:" + OrdenProduccionId + ";");
        console.log("SolicitudId:" + SolicitudId + ";");
    }

    $app.execute({
        controller: 'Modal_Actualizar_Ruta_Optima',
        command: 'Custom',
        argument: 'ExecCS01', values: [
            { name: 'Ruta_Optima_Id', newValue: RutaOptimaId },
            { name: 'Orden_Produccion_Id', newValue: OrdenProduccionId },
            { name: 'Solicitud_Id', newValue: SolicitudId },
            { name: 'Cantidad_Entregado', newValue: CantidadEntregado },
            { name: 'Unidad_Material_Entregado_Id', newValue: UnidadMaterialEntregado }
        ],
        done: function (result) {
            eval(result.clientScript);

            if (debug == 1) {
                console.log(result.clientScript);
                console.log("Termina Ejecutar Modal_Actualizar_Ruta_Optima -> Custom -> ExecCS01;");
            }
        }
    }) // $app.execute finaliza

    if (debug == 1) {
        console.log("Termina function ActualizarSurtido();");
    }

};
// END function ActualizarSurtido(RutaOptimaId, OrdenProduccionId, SolicitudId, CantidadEntregado, UnidadMaterialEntregado) {

function abrirModalActualizarRutaOptimaApi(RutaOptimaId, OrdenProduccionId, SolicitudId) {
    var selectUnidadMaterialEntregado = administrarObjetoHtml(1);
    // Ajustes a modal Alertify
    // set multiple settings/options
    alertify.confirm().setting({ 'modal': true, 'closable': true, 'maximizable': false });
    alertify.confirm().set('labels', {
        ok: 'Aceptar'
        , cancel: 'Cancelar'
    });

    //Set header
    alertify.confirm().setHeader('<div class="alertifyModalHeader"><h1> Actualizar </h1></div>').show();
    //Set content
    alertify.confirm().setContent(selectUnidadMaterialEntregado).show();
}

// START function administrarObjetoHtml(objetoId) {
function administrarObjetoHtml(objetoId) {
    var Objeto_Html = "";
    //var userId = $appfactory.userId();
    //var userId = $app.userId();
    var data = {
        "objetoId": objetoId
        , "creadoPorId": $app.userId() //$appfactory.userId() // $app.userId();
    }

    if (debug === 1) {
        console.log("data:" + JSON.stringify(data));
    }
    var settings = {
        "async": false,
        "crossDomain": true,
        "url": "https://prod-04.southcentralus.logic.azure.com/workflows/4529165797b344a1b1e9e677c3593bf0/triggers/manual/paths/invoke/AdministrarObjetoHtml?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=YabgsAv_HlCWwYajpiaqWS1ReOXo0zuBRJyUic1mRxU",
        "method": "POST",
        "headers": {
            "content-type": "application/json",
            "cache-control": "no-cache",
        },
        "processData": false,
        "data": JSON.stringify(data)
    }

    $.ajax(settings).done(function (response) {
        if (debug === 1) {
            console.log("Objeto_Html in response:" + response.Objeto_Html_Result);
        }
        Objeto_Html = response.Objeto_Html_Result;
    });

    if (debug === 1) {
        console.log("Objeto_Html to return:" + Objeto_Html);
    }
    return Objeto_Html;
}
// END function administrarObjetoHtml(objetoId) {

//START function obtenerSelectUnidadMaterial() {
/*function obtenerSelectUnidadMaterial() {
    var select_Unidad_Mat_Entregado = "";

    $app.execute({
        controller: 'Unidad_Material',
        view: 'Unidad_Material_LookUp_List',      
        done: function (result) {

            select_Unidad_Mat_Entregado += '<select>';

            if (debug == 1) {
                console.log("Result:" + result);
                console.log("Array Unidad Material:" + result.Unidad_Material);
                console.log("Primeros valores de Array Unidad Material");
                console.log("   Unidad_Material_Id :" + result.Unidad_Material[0].Unidad_Material_Id);
                console.log("   Unidad_Material:" + result.Unidad_Material[0].Unidad_Material);
                console.log("  $.each(result.Unidad_Material, function (index, value) {")
            }
            // Recorremos result
            $.each(result.Unidad_Material, function (index, value) {

                if (value.Unidad_Material_Id == 0) {
                    select_Unidad_Mat_Entregado += '<option selected value="' + value.Unidad_Material_Id + '">' + value.Unidad_Material + '</option>';
                } else {
                    select_Unidad_Mat_Entregado += '<option value="' + value.Unidad_Material_Id + '">' + value.Unidad_Material + '</option>';
                }

                if (debug == 1) {
                    console.log("Unidad_Material_Id: " + value.Unidad_Material_Id);
                    console.log("Unidad_Material: " + value.Unidad_Material);
                }

            });

            // Terminamos de crear select_Unidad_Mat_Entregado
            select_Unidad_Mat_Entregado += '</select>';

            if (debug == 1) {
                //console.log("select_Unidad_Mat_Entregado:" + select_Unidad_Mat_Entregado);
                console.log("Termina  $.each(result.Unidad_Material, function (index, value) {");
            }

        }
    })
    console.log("return select_Unidad_Mat_Entregado:" + select_Unidad_Mat_Entregado);
    return select_Unidad_Mat_Entregado;
};
*/
//END function obtenerSelectUnidadMaterial() {

// START function focusInField(field){
function focusInField(field) {
    window.setTimeout(function () {
        field.setSelectionRange(0, 99999);
        //console.log("Estoy en focusInField(field)");
    }, 10);
};// END function focusInField(field){


// START var eaton = {
var eaton = {
    /*"servicios": [
        {
            "nombre": "ObtenerSheetDetailsRQs",
            "url": "../Services/SheetDetailCustomControllerService.asmx/getSheetDetailsRQs",
            "estatus": 1
        }
        
    ],*/
    // START "mensajes": [
    "mensajes": [
        {
            "id": 0,
            "texto": "Sin mensaje",
            "tipo": "Sistema",
            "estatus": 1
        },
        {
            "id": 1,
            "texto": "No se encontraron registros para el datatable.",
            "tipo": "Sistema",
            "estatus": 1
        },
        {
            "id": 2,
            "texto": "Ocurrió un error al tratar de obtener los materiales.",
            "tipo": "Sistema",
            "estatus": 1
        }
    ],
    // END "mensajes": [
    // START "configDatatable": [
    "configDatatable": [
        {
            "id": 0,
            "description": "Config Lenguaje Español",
            "sProcessing": "Procesando ...",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sZeroRecords": "No se encontraron resultados.",
            "sEmptyTable": "Ningún dato disponible en esta tabla.",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sSearch": "Buscar:",
            "sLengthMenu": "Mostrar _MENU_ registros",
            "estatus": 1
        }
    ],
    // END "configDatatable": [
    // START "scripts": [
    "scripts": [
        // SCRIPTS NUBE
        // Alertify
        /*        
        { 
            "url" : "https://cdn.jsdelivr.net/npm/alertifyjs@1.11.0/build/alertify.min.js",
            "estatus" : 1 
        },*/
        //DataTables
		{
            "url": "https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js",
		    "estatus": 1
		},
		{
		    "url": "https://cdn.datatables.net/responsive/2.1.1/js/dataTables.responsive.min.js",
		    "estatus": 1
		}/*,
        {
            "url": "https://cdn.datatables.net/select/1.2.7/js/dataTables.select.min.js",
            "estatus": 1
        },
        {
            "url": "https://gyrocode.github.io/jquery-datatables-checkboxes/1.2.11/js/dataTables.checkboxes.min.js",
            "estatus": 1
        },
        {
            "url": "https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js",
            "estatus": 1
        }*/,
        // SCRIPTS LOCAL
        //Alertify
        {
            "url": URLProtocoloDomain + "/utilerias/alertifyjs/alertify.min.js",
            "estatus": 1
        },
        //NumPad
        {
            "url": URLProtocoloDomain + "/utilerias/jQuery.NumPad-master/jquery.numpad.js",
            "estatus": 1
        },
        // DataTables        

        /*{
            "url": URLProtocoloDomain + "/utilerias/DataTables/datatable.min.js",
            "estatus": 1
        },
        {
            "url": URLProtocoloDomain + "/utilerias/DataTables/Responsive-2.2.2/js/dataTables.responsive.min.js",
            "estatus": 1
        }*/
        {
            "url": URLProtocoloDomain + "utilerias/DataTables/Select-1.2.6/js/dataTables.select.min.js",
            "estatus": 1
        },
        {
            "url": URLProtocoloDomain + "utilerias/DataTables/jquery-datatables-checkboxes/1.2.11/dataTables.checkboxes.min.js",
            "estatus": 1
        },
        {
            "url": URLProtocoloDomain + "utilerias/DataTables/moment-2.18/moment.min.js",
            "estatus": 1
        }
    ],
    // END "scripts": [
    // START "styles": [
    "styles": [
        //Styles nube
        /*
        //Alertify
        {
            "url": "https://cdn.jsdelivr.net/npm/alertifyjs@1.11.0/build/css/alertify.min.css",
            "estatus": 1
        },
        {
            "url": "https://cdn.jsdelivr.net/npm/alertifyjs@1.11.0/build/css/themes/default.min.css",
            "estatus": 1
        },*/
        //DataTables
        {
            "url": "https://cdn.datatables.net/1.10.19/css/jquery.dataTables.min.css",
            "estatus": 1
        },
        //Alertify
        {
            "url": URLProtocoloDomain + "/utilerias/alertifyjs/css/alertify.min.css",
            "estatus": 1
        },
        /*{
            "url": URLProtocoloDomain + "/utilerias/alertifyjs/css/themes/default.min.css",
            "estatus": 1
        },*/
        //Numpad
        {
            "url": URLProtocoloDomain + "/utilerias/jQuery.NumPad-master/jquery.numpad.css",
            "estatus": 1
        },
        // Datatables
        {
            "url": URLProtocoloDomain + "/utilerias/DataTables/datatables.min.css",
            "estatus": 1
        },
        {
            "url": URLProtocoloDomain + "/utilerias/DataTables/Responsive-2.2.2/css/responsive.dataTables.min.css",
            "estatus": 1
        },
        {
            "url": "https://cdn.datatables.net/select/1.2.7/css/select.dataTables.min.css",
            "estatus": 1
        },
        {
            "url": "https://gyrocode.github.io/jquery-datatables-checkboxes/1.2.11/css/dataTables.checkboxes.css",
            "estatus": 1
        }
    ],
    // END "styles": [
    // START "cargarScripts": function () {
    "cargarScripts": function () {

        var scripts = this.scripts;

        $.each(scripts, function (key, value) {
            if (value.estatus == 1) {
                var script = document.createElement('script');
                script.type = "text/javascript";
                script.src = value.url;
                script.async = false;
                document.getElementsByTagName('head')[0].appendChild(script);
            }
        });

    },
    // END "cargarScripts": function () {
    // START "cargarEstilos": function () {
    "cargarEstilos": function () {

        var estilos = this.styles;

        $.each(estilos, function (key, value) {
            if (value.estatus == 1) {
                var head = document.getElementsByTagName('head')[0];
                var link = document.createElement('link');
                link.rel = 'stylesheet';
                link.type = 'text/css';
                link.href = value.url;

                head.appendChild(link);
            }
        });
    },
    // END "cargarEstilos": function () {
    "createGuid": function (){
        function S4() {  
            return (((1+Math.random())*0x10000)|0).toString(16).substring(1);  
        }  
        return (S4() + S4() + "-" + S4() + "-4" + S4().substr(0,3) + "-" + S4() + "-" + S4() + S4() + S4()).toLowerCase();  
    },
    // START "cargarDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (ordenesProdSeleccionados) {
    "cargarDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (ordenesProdSeleccionados) {

        if (debug === 1) {
            console.log("ordenesProdSeleccionados:" + ordenesProdSeleccionados);
        }
        // Declaracion de variables
        var $this = eaton;

        var jsonParaBodyDatatable;
        // Para columnas del DataTable
        var colummnas;
        var dataTableConfiguracionColumnas;
        // Validar consulta de registros 
        var resultado = false;
        var table;
        var htmlDatatable;

        // Configuracion de datatable
        var idConfigDatatable = 0;
        var configDatatable;

        // 
        var materialesSeleccionados;

        // Obtener configuración del datatable
        configDatatable = this.configDatatable[0];

        if (debug === 1) {
            console.log("configDatatable:");
            console.log(configDatatable);
        }

        //Obtenemos registros
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Produccion_V'
            , command: 'Select'
            , argument: 'grid1'
            , filter: [
                { name: 'Orden_Produccion_Id', operator: 'IN', value: ordenesProdSeleccionados }
            ]
            , dataType: 'json'
            , done: function (result) {

                if (debug === 1) {
                    console.log("result: ");
                    console.log(result.Grid_Orden_Detalle_De_Multiple_Orden_Produccion_V);
                    console.log("result.fields: ");
                    console.log(result.fields);
                }

                try {

                    jsonParaBodyDatatable = result.Grid_Orden_Detalle_De_Multiple_Orden_Produccion_V;
                    columnas = result.fields;
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {

                    if (debug === 1) {
                        console.log("result === true");
                    }

                    dataTableConfiguracionColumnas = [];
                    // START $.each(columnas, function (index, columna) {
                    $.each(columnas, function (index, columna) {
                        if (debug === 1) {
                            console.log("Columna:");
                            console.log(columna.Name);
                        }

                        // Mostraremos solo algunas columnas
                        if (columna.Name == 'Orden_Produccion_Id'
                             || columna.Name == 'Numero_Orden_Produccion'
                            || columna.Name == 'Material'
                            || columna.Name == 'Material_Descripcion'
                            || columna.Name == 'Material_Ubicacion_Piso'
                            || columna.Name == 'Valida_Existencia_En_Piso'
                            //|| columna.Name == 'Cantidad_Mat_Para_Producir_Un_Prod'
                            || columna.Name == 'Cantidad_Mat_Total_Para_Producir'
                            || columna.Name == 'Cantidad_Mat_Solicitado_Previamente'
                            || columna.Name == 'Cantidad_Mat_Restante_Por_Solicitar'
                            || columna.Name == 'Cantidad_Mat_A_Solicitar'
                            || columna.Name == 'Material_Ubicacion_Almacen'
                            || columna.Name == 'Valida_Existencia_En_Almacen'
                            //|| columna.Name == 'Fecha_Produccion'
                            ) {

                            dataTableConfiguracionColumnas.push({
                                sTitle: $this.validarNombreColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(columna.Name),
                                mDataProp: columna.Name,
                                orderable: $this.validarPermitirOrdenarInfoColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(columna.Name), // 0 no permite ordenar los datos en la columna, 1 si permite ordenar
                                ordenDeColumna: $this.validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(columna.Name),
                            })
                        }

                    });
                    // END $.each(columnas, function (index, columna) {

                    // Ordenamos el arreglo de acuerdo al orden de columna
                    dataTableConfiguracionColumnas.sort($this.OrdenarPorOrdenDeColumna);
                    if (debug === 1) {
                        console.log("dataTableConfiguracionColumnas ordenado por campo ordenDeColumna:");
                        console.log(dataTableConfiguracionColumnas);
                    }

                    //htmlDatatable = '<button id="button">Row count</button><br/>'
                    htmlDatatable = '<div id="divBtnAccionesListaMatPtePorSurtir" class="divBtnAccionesListaMatPtePorSurtir">';
                    htmlDatatable += '<input class="btnAccionesListaMatPtePorSurtir" style="display:none;" type ="button" id="btnActualizarMatPtePorSurtir" value="Actualizar">';
                    htmlDatatable += '<input class="btnAccionesListaMatPtePorSurtir" style="display:none;" type ="button" id="btnDesviacionMat" name="" value="Desviación de Material">';
                    htmlDatatable += '<input class="btnAccionesListaMatPtePorSurtir" style="display:none;" type ="button" id="btnColocarNotaComentImg" name="" value="Colocar Nota/Comentario">';
                    htmlDatatable += '<input class="btnAccionesListaMatPtePorSurtir" style="display:none;" type ="button" id="btnCrearSolicitud" name="" value="Crear Solicitud">';
                    htmlDatatable += '</div><br/>';
                    htmlDatatable += '<table id="listaMatPtePorSurtir" class="display nowrap" cellspacing="0" width="100%"></table>';

                    // START alertify.alert(htmlDatatable)
                    alertify.alert(htmlDatatable)
                        .maximize()
                        .set({
                            onclose: function () {
                                // Refrescamos
                                window.location.reload();
                                //Limpiamos datatable
                                if ($.fn.DataTable.isDataTable('#listaMatPtePorSurtir')) {
                                    table.destroy();
                                    table.clear();
                                    $('#listaMatPtePorSurtir').empty();
                                    table.rows('.selected').data().empty();
                                    // Ocultamos los botones de acciones                        
                                    $("#btnActualizarMatPtePorSurtir").hide();
                                    $("#btnDesviacionMat").hide();
                                    $("#btnColocarNotaComentImg").hide();
                                }
                            },
                            maximizable: true
                            , frameless: true // Desactivamos encabezado y pie de página
                        })//.setHeader('<b>LISTA DE MATERIALES PENDIENTES POR SURTIR</b>');
                    // END alertify.alert(htmlDatatable)

                    // Generar el datatable
                    table = $('#listaMatPtePorSurtir').DataTable({
                        responsive: true,
                        paging: false,
                        searching: true,
                        select: true,
                        aaData: jsonParaBodyDatatable,
                        //refresh:true,
                        fnInitComplete: function () {

                            if (debug === 1) {
                                console.log("fnInitComplete");
                            }
                            // Agregamos estilo de seleccion
                            $('#listaMatPtePorSurtir tbody').on('click', 'tr', function () {
                                // Estilo selected
                                $(this).toggleClass('selected');

                                var cantRegSelecccionado = table.rows('.selected').data().length;
                                if (cantRegSelecccionado === 0) {
                                    cantRegSelecccionado = table.rows({ selected: true }).data().length;
                                }

                                if (debug === 1) {
                                    console.log("cantRegSelecccionado: " + cantRegSelecccionado);
                                }
                               
                                // Acciones 1 a 1
                                if (cantRegSelecccionado === 1) {
                                    if (debug === 1) {
                                        console.log("mostrando botones...");
                                    }
                                    // Mostramos los botones de acciones
                                    $("#btnActualizarMatPtePorSurtir").show();
                                    $("#btnDesviacionMat").show();
                                    $("#btnColocarNotaComentImg").show();
                                    $("#btnCrearSolicitud").show();
                                } else {
                                    if (cantRegSelecccionado > 1) {
                                        if (debug === 1) {
                                            console.log("ocultando botones...");
                                        }
                                        // Ocultamos los botones de acciones
                                        $("#btnActualizarMatPtePorSurtir").hide();
                                        $("#btnDesviacionMat").hide();
                                        $("#btnColocarNotaComentImg").hide();
                                        $("#btnCrearSolicitud").show();
                                    } else {
                                        if (cantRegSelecccionado === 0) {
                                            if (debug === 1) {
                                                console.log("ocultando botones...");
                                            }
                                            // Ocultamos los botones de acciones
                                            $("#btnActualizarMatPtePorSurtir").hide();
                                            $("#btnDesviacionMat").hide();
                                            $("#btnColocarNotaComentImg").hide();
                                            $("#btnCrearSolicitud").hide();
                                        }
                                    }
                                }
                                
                            });
                        },
                        //Configuración de columnas
                        columnDefs: [
                            {
                                targets: 0,
                                "width": "10%",
                                checkboxes:
                                {
                                    selectRow: true,
                                    selectAllPages: false
                                }
                            },
                            {
                                targets: 1,
                                "width": "10%",
                                className: 'dt-body-center', // Centramos el texto
                            },
                            {
                                targets: 2,
                                "width": "10%",
                                className: 'dt-body-center', // Centramos el texto
                                /*type: 'date',
                                def: function () { return new Date(); },
                                format: 'MM/DD/YYYY',
                                render: function (data, type, row) {
                                    //data = moment(data).format('DD/MMM/YYYY'); // Regresa 12/Dec/2018
                                    data = moment(data).format('DD/MM/YYYY'); // Regresa 21/12/2018
                                    return data;
                                }*/
                            },
                            {
                                targets: 3,
                                "width": "15%",
                                className: 'dt-body-center', // Centramos el texto
                            },
                            {
                                targets: 4,
                                "width": "15%",
                                className: 'dt-body-center', // Centramos el texto
                               
                            }
                        ],
                        select: {
                            style: 'multi' // Activamos multiselection
                        },
                        aoColumns: dataTableConfiguracionColumnas,
                        language: {
                            sProcessing: configDatatable.sProcessing
                            , sInfo: configDatatable.sInfo
                            , sZeroRecords: configDatatable.sZeroRecords
                            , sEmptyTable: configDatatable.sEmptyTable
                            , sInfoEmpty: configDatatable.sInfoEmpty
                            , sSearch: configDatatable.sSearch
                            , sLengthMenu: configDatatable.sLengthMenu                            
                        }
                    });

                    // START $("#btnActualizarMatPtePorSurtir").click(function () {
                    $("#btnActualizarMatPtePorSurtir").click(function () {
                        if (debug === 1) {
                            console.log("click en btnActualizarMatPtePorSurtir");
                        }

                        setTimeout(function () {
                            if (debug === 1) {
                                console.log("Removiendo clase app-page-modal");
                            }
                            $("#grid_orden_detalle_de_orden_produccion_v").removeClass("app-page-modal");
                            if (debug === 1) {
                                console.log("Agregando clase app-page-modal");
                            }
                            $("#grid_orden_detalle_de_orden_produccion_v").addClass("app-page-modal-custom1");
                        }, 1000)

                        // Datos de fila                                            
                        var datosFilaSeleccionada = table.rows({ selected: true }).data();

                        if (debug === 1) {
                            console.log('Row selected:' + table.rows('.selected').data().length + ' row(s) selected');
                            console.log("Datos de registro seleccionado:");                                                      
                            console.log(datosFilaSeleccionada[0]);
                            console.log("Orden_Produccion_Id: " + datosFilaSeleccionada[0]["Orden_Produccion_Id"]);
                            console.log("Orden_Produccion_Detalle_Id: " + datosFilaSeleccionada[0]["Orden_Produccion_Detalle_Id"]);
                            console.log("Material_Id: " + datosFilaSeleccionada[0]["Material_Id"]);
                        }
                          
                        $app.touch.show({
                            controller: 'Grid_Orden_Detalle_De_Orden_Produccion_V'
                          , startCommand: 'Edit'
                          , startArgument: 'editForm1'
                          , filter: [
                            { name: 'Orden_Produccion_Id', value: datosFilaSeleccionada[0]["Orden_Produccion_Id"] }
                            , { name: 'Orden_Produccion_Detalle_Id', value: datosFilaSeleccionada[0]["Orden_Produccion_Detalle_Id"] }
                            , { name: 'Material_Id', value: datosFilaSeleccionada[0]["Material_Id"] }
                          ]                          
                        }).done(function () {

                            if (debug === 1) {
                                console.log("ordenesProdSeleccionados atfer show:" + ordenesProdSeleccionados);
                            }
                            //Limpiamos datatable
                            if ($.fn.DataTable.isDataTable('#listaMatPtePorSurtir')) {
                                table.destroy();
                                table.clear();
                                $('#listaMatPtePorSurtir').empty();
                                table.rows('.selected').data().empty();


                            }

                            //Cargar datatable
                            eaton.cargarDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(ordenesProdSeleccionados);

                        });


                      
                        /*$.each(table.rows('.selected').data(), function (index, value) {
                            if (debug === 1) {
                                console.log("index: " + index);
                                console.log("value: ");
                                console.log(value);
                                console.log("Orden_Produccion_Id: " + value.Orden_Produccion_Id);
                            }
                        })*/            
                        
                    });
                    // END $("#btnActualizarMatPtePorSurtir").click(function () {
                    
                    // START $("#btnDesviacionMat").click(function () {
                    $("#btnDesviacionMat").click(function () {
                        if (debug === 1) {
                            console.log("click en btnDesviacionMat");
                        }
                      
                        setTimeout(function () {
                            if (debug === 1) {
                                console.log("Removiendo clase app-page-modal a div desviacion_material");
                            }
                            $("#desviacion_material").removeClass("app-page-modal");                            
                            if (debug === 1) {
                                console.log("Agregando clase app-page-modal a div desviacion_material");
                            }
                            $("#desviacion_material").addClass("app-page-modal-custom1");
                            /*$.each($("#desviacion_material").find('span.app-caret-r'), function () {
                                $(this).on("click", function () {
                                    console.log("click");
                                    setTimeout(function () {
                                        if (debug === 1) {
                                            console.log("Removiendo clase app-page-modal a div categoria_desviacion");
                                        }
                                        $("#categoria_desviacion").removeClass("app-page-modal");
                                        if (debug === 1) {
                                            console.log("Agregando clase app-page-modal-custom1 a div categoria_desviacion");
                                        }
                                        $("#categoria_desviacion").addClass("app-page-modal-custom1");
                                    }, 50)

                                });
                            });*/
                        }, 1000)

                        /*$("#desviacion_material span.app-caret-r").on('click',function () {
                            console.log("click");
                        });*/

                        // Datos de fila                                            
                        var datosFilaSeleccionada = table.rows({ selected: true }).data();
                        //Declaraciones
                        var Orden_Produccion_Id = datosFilaSeleccionada[0]["Orden_Produccion_Id"];
                        var Numero_Orden_Produccion = datosFilaSeleccionada[0]["Numero_Orden_Produccion"];
                        var Orden_Produccion_Detalle_Id = datosFilaSeleccionada[0]["Orden_Produccion_Detalle_Id"];
                        var Familia_Id = datosFilaSeleccionada[0]["Familia_Id"];
                        var Familia_Descripcion = datosFilaSeleccionada[0]["Familia_Descripcion"];
                        var Producto_Id = datosFilaSeleccionada[0]["Producto_Id"];
                        var Producto_Descripcion = datosFilaSeleccionada[0]["Producto_Descripcion"];
                        var Material_Id = datosFilaSeleccionada[0]["Material_Id"];
                        var Material = datosFilaSeleccionada[0]["Material"];

                        if (debug === 1) {
                            console.log('Row selected:' + table.rows('.selected').data().length + ' row(s) selected');
                            console.log("Datos de registro seleccionado:");
                            console.log(datosFilaSeleccionada[0]);
                            console.log("Orden_Produccion_Id: " + Orden_Produccion_Id);
                            console.log("Orden_Produccion_Detalle_Id: " + Orden_Produccion_Detalle_Id);
                            console.log("Material_Id: " + Material_Id);
                        }
                        

                        $app.touch.show({
                            controller: 'Desviacion_Material',
                            startCommand: 'New',
                            startArgument: 'createForm1',
                            defaultValues: [
                              { name: 'Orden_Produccion_Id', value: Orden_Produccion_Id }
                              , { name: 'Numero_Orden_Produccion', value: Numero_Orden_Produccion }
                              , { name: 'Orden_Produccion_Detalle_Id', value: Orden_Produccion_Detalle_Id }
                              , { name: 'Familia_Id', value: 0 }
                              , { name: 'Familia_Descripcion', value: Familia_Descripcion }
                              , { name: 'Producto_Id', value: Producto_Id }
                              , { name: 'Producto_Descripcion', value:Producto_Descripcion  }
                              , { name: 'Material_Id', value: Material_Id }
                              , { name: 'Material', value: Material }
                            ]
                          , filter: [
                              { name: 'Orden_Produccion_Id', value: Orden_Produccion_Id }
                              , { name: 'Numero_Orden_Produccion', value: Numero_Orden_Produccion }
                              , { name: 'Orden_Produccion_Detalle_Id', value: Orden_Produccion_Detalle_Id }
                              , { name: 'Familia_Id', value: 0 }
                              , { name: 'Familia_Descripcion', value: Familia_Descripcion }
                              , { name: 'Producto_Id', value: Producto_Id }
                              , { name: 'Producto_Descripcion', value: Producto_Descripcion }
                          ]                            
                        });

                        // PTE TRAER PARA ENFRENTE MODAL DE CATEGORIA DESVIACION
                        //setTimeout(function () {
                            $.each($("#desviacion_material").find('span.app-caret-r'), function () {
                                $(this).on("click", function () {
                                    console.log("click");
                                    setTimeout(function () {
                                        if (debug === 1) {
                                            console.log("Removiendo clase app-page-modal a div categoria_desviacion");
                                        }
                                        $("#categoria_desviacion").removeClass("app-page-modal");
                                        if (debug === 1) {
                                            console.log("Agregando clase app-page-modal-custom1 a div categoria_desviacion");
                                        }
                                        $("#categoria_desviacion").addClass("app-page-modal-custom1");
                                    }, 50)

                                });
                            });
                       // }, 3000)

                        /*$(".app-field-Categoria_Desviacion_Id").click(function () {
                            console.log("cccc");
                            setTimeout(function () {
                                if (debug === 1) {
                                    console.log("Removiendo clase app-page-modal");
                                }
                                $("#categoria_desviacion").removeClass("app-page-modal");
                                if (debug === 1) {
                                    console.log("Agregando clase app-page-modal");
                                }
                                $("#categoria_desviacion").addClass("app-page-modal-custom1");
                            }, 1000)
                        })*/

                        

                    });
                    // END $("#btnDesviacionMat").click(function () {

                    // START $("#btnColocarNotaComentImg").click(function () {
                    $("#btnColocarNotaComentImg").click(function () {
                        if (debug === 1) {
                            console.log("click en btnColocarNotaComentImg");
                        }

                        setTimeout(function () {
                            if (debug === 1) {
                                console.log("Removiendo clase app-page-modal");
                            }
                            $("#documento_comentario").removeClass("app-page-modal");
                            
                            if (debug === 1) {
                                console.log("Agregando clase app-page-modal");
                            }
                            $("#documento_comentario").addClass("app-page-modal-custom1");
                            
                        }, 1000)

                        // Datos de fila                                            
                        var datosFilaSeleccionada = table.rows({ selected: true }).data();
                        //Declaraciones
                        var Orden_Produccion_Id = datosFilaSeleccionada[0]["Orden_Produccion_Id"];
                        var Numero_Orden_Produccion = datosFilaSeleccionada[0]["Numero_Orden_Produccion"];
                        var Orden_Produccion_Detalle_Id = datosFilaSeleccionada[0]["Orden_Produccion_Detalle_Id"];
                        var Familia_Id = datosFilaSeleccionada[0]["Familia_Id"];
                        var Familia_Descripcion = datosFilaSeleccionada[0]["Familia_Descripcion"];
                        var Producto_Id = datosFilaSeleccionada[0]["Producto_Id"];
                        var Producto_Descripcion = datosFilaSeleccionada[0]["Producto_Descripcion"];
                        var Material_Id = datosFilaSeleccionada[0]["Material_Id"];
                        var Material = datosFilaSeleccionada[0]["Material"];

                        if (debug === 1) {
                            console.log('Row selected:' + table.rows('.selected').data().length + ' row(s) selected');
                            console.log("Datos de registro seleccionado:");
                            console.log(datosFilaSeleccionada[0]);
                            console.log("Orden_Produccion_Id: " + Orden_Produccion_Id);
                            console.log("Orden_Produccion_Detalle_Id: " + Orden_Produccion_Detalle_Id);
                            console.log("Material_Id: " + Material_Id);
                        }

                        $app.touch.show({
                            controller: 'Documento_Comentario',
                            startCommand: 'New',
                            startArgument: 'createForm1',
                            defaultValues: [
                                { name: 'Orden_Produccion_Id', value: Orden_Produccion_Id }
                                , { name: 'Orden_Produccion_Detalle_Id', value: Orden_Produccion_Detalle_Id }
                                , { name: 'Producto_Id', value: Producto_Id }
                                , { name: 'Material_Id', value: Material_Id }
                                , { name: 'Registrado_Desde_Id', value: 2 } // Registrado desde Materiales Pendientes por Solicitar por Multiple Orden de Produccion
                            ]
                            , filter: [
                            { name: 'Orden_Produccion_Id', value: Orden_Produccion_Id }
                            , { name: 'Orden_Produccion_Detalle_Id', value: Orden_Produccion_Detalle_Id }
                            , { name: 'Producto_Id', value: Producto_Id }
                            ]
                        });
                        
                    });
                    // END $("#btnColocarNotaComentImg").click(function () {

                    // START $("#btnCrearSolicitud").click(function () {
                    $("#btnCrearSolicitud").click(function () {
                        if (debug === 1) {
                            console.log("click en btnCrearSolicitud");
                        }                        

                        // Datos de fila                                            
                        var datosFilasSeleccionadas = table.rows({ selected: true }).data();                                                

                        if (debug === 1) {
                            console.log('Row selected:' + table.rows('.selected').data().length + ' row(s) selected');
                            console.log("Filas seleccionadas");
                            console.log(datosFilasSeleccionadas);                            
                        }
                        $.each(datosFilasSeleccionadas, function (index, value) {
                            var Orden_Produccion_Id = value.Orden_Produccion_Id;
                            var Orden_Produccion_Detalle_Id = value.Orden_Produccion_Detalle_Id;
                            var Producto_Id = value.Producto_Id;
                            var Material_Id = value.Material_Id;
                            var Cant_Mat_A_Solicitar = value.Cantidad_Mat_A_Solicitar;
                            var Cantidad_Mat_Restante_Por_Solicitar = value.Cantidad_Mat_Restante_Por_Solicitar;

                           if (debug === 1) {
                               console.log("index: " + index);
                               console.log("value: ");
                               console.log(value);
                               console.log("Orden_Produccion_Id: " + Orden_Produccion_Id);
                               console.log("Orden_Produccion_Detalle_Id: " + Orden_Produccion_Detalle_Id);
                               console.log("Producto_Id: " + Producto_Id);
                               console.log("Material_Id: " + Material_Id);
                               console.log("Cant_Mat_A_Solicitar: " + Cant_Mat_A_Solicitar);
                               console.log("Cantidad_Mat_Restante_Por_Solicitar: " + Cantidad_Mat_Restante_Por_Solicitar);
                           }
                            // Crear Solicitud
                            // Ejecutamos BR ExecCS02
                            // START $app.execute({
                           $app.execute({
                               controller: 'Grid_Orden_Detalle_De_Orden_Produccion_V'                               
                             , command: 'Custom'
                             , argument: 'ExecCS02'
                             , values: [
                                   { name: 'Orden_Produccion_Id', newValue: Orden_Produccion_Id }
                                 , { name: 'Orden_Produccion_Detalle_Id', newValue: Orden_Produccion_Detalle_Id }
                                 , { name: 'Producto_Id', newValue: Producto_Id }
                                 , { name: 'Material_Id', newValue: Material_Id }
                                 , { name: 'Cantidad_Mat_A_Solicitar', newValue: Cant_Mat_A_Solicitar }
                                 , { name: 'Cantidad_Mat_Restante_Por_Solicitar', newValue: Cantidad_Mat_Restante_Por_Solicitar }
                             ]
                             , done: function (result) {
                                 eval(result.clientScript);
                                 if (debug === 1) {
                                     console.log("ExecCS01 result : ");
                                     console.log(result);
                                 }
                                 
                             }
                           });
                            // END $app.execute({
                       })
                    });
                    // END $("#btnCrearSolicitud").click(function () {
                }
                // END if (resultado === true) 
                else {
                    id = 1;
                    msg = $this.mensajes[id];//No se encontraron registros para el datatable.
                    console.log(msg);
                    alertify.alert(msg.tipo + ' (' + id + ') ' + msg.texto).setHeader(msg.tipo);
                    return false;
                }
            }
            // END ,done: function (result){
            , fail: function () {
                id = 2;
                msg = $this.mensajes[id];//Ocurrió un error al tratar de obtener los materiales.
                console.log(msg);
                alertify.alert(msg.tipo + ' (' + id + ') ' + msg.texto).setHeader(msg.tipo);
                return false;
            }
        })
        // END $app.execute({
    },
    // END "cargarDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (ordenesProdSeleccionados) {
    // START "validarNombreColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    "validarNombreColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
        var nombreDeColumna;
        //Validamos titulos de columna
        switch (columnaName) {
            case 'Orden_Produccion_Id':
                nombreDeColumna = "Orden Produccion";
                break;
            case 'Numero_Orden_Produccion':
                nombreDeColumna = "Orden de Producción";
                break;
            case 'Material':
                nombreDeColumna = "Material";
                break;
            case 'Fecha_Produccion':
                nombreDeColumna = "Fecha de Producción";
                break;
            case 'Material_Descripcion':
                nombreDeColumna = "Descripción <br> de Material";
                break;
            case 'Material_Ubicacion_Piso':
                nombreDeColumna = "Ubicaciones en Piso";
                break;
            case 'Valida_Existencia_En_Piso':
                nombreDeColumna = "Valida Existencia en Piso";
                break;
            case 'Cantidad_Mat_Para_Producir_Un_Prod':
                nombreDeColumna = "Cantidad de Mat para Producir un Prod";
                break;
            case 'Cantidad_Mat_Total_Para_Producir':
                nombreDeColumna = "Cantidad de Mat <br> Total para producir";
                break;
            case 'Cantidad_Mat_Solicitado_Previamente':
                nombreDeColumna = "Cantidad de Mat <br>Solicitado Previamente";
                break;
            case 'Cantidad_Mat_Restante_Por_Solicitar':
                nombreDeColumna = "Cantidad de Mat <br> Restante por Solicitar";
                break;
            case 'Cantidad_Mat_A_Solicitar':
                nombreDeColumna = "Cantidad de Mat <br> a Solicitar";
                break;
            case 'Material_Ubicacion_Almacen':
                nombreDeColumna = "Ubicaciones en Almacén";
                break;
            case 'Valida_Existencia_En_Almacen':
                nombreDeColumna = "Valida Existencia en Almacén";
                break;
            default:
                nombreDeColumna = columnaName;
        }
        return nombreDeColumna;
    },
    // END "validarNombreColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    // START "validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    "validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
        var ordenDeColumna;
        //Validamos orden de columna
        switch (columnaName) {
            case 'Orden_Produccion_Id':
                ordenDeColumna = 0;
                break;
            case 'Numero_Orden_Produccion':
                ordenDeColumna = 0.5;
                break;
            case 'Material':
                ordenDeColumna = 1;
                break;
            case 'Fecha_Produccion':
                ordenDeColumna = 0.6;
                break;
            case 'Material_Descripcion':
                ordenDeColumna = 2;
                break;
            case 'Material_Ubicacion_Piso':
                ordenDeColumna = 3;
                break;
            case 'Valida_Existencia_En_Piso':
                ordenDeColumna = 4; 
                break;
            case 'Cantidad_Mat_Para_Producir_Un_Prod':
                ordenDeColumna = 2.1;
                break;
            case 'Cantidad_Mat_Total_Para_Producir':
                ordenDeColumna = 2.2;
                break;
            case 'Cantidad_Mat_Solicitado_Previamente':
                ordenDeColumna = 2.3;
                break;
            case 'Cantidad_Mat_Restante_Por_Solicitar':
                ordenDeColumna = 2.4;
                break;
            case 'Cantidad_Mat_A_Solicitar':
                ordenDeColumna = 2.5;
                break;
            case 'Material_Ubicacion_Almacen':
                ordenDeColumna = 10;
                break;
            case 'Valida_Existencia_En_Almacen':
                ordenDeColumna = 11;
                break;
            default:
                ordenDeColumna = 0;
        }

        return ordenDeColumna;
    },
    // END "validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    // START "validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    "validarPermitirOrdenarInfoColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
        var permitirOrdenarInfoEnColumna;
        //Validamos orden de columna
        // 0 = No permite
        // 1= Si permite ordenar la información en la columna
        switch (columnaName) {
            case 'Orden_Produccion_Id':
                permitirOrdenarInfoEnColumna = 0;
                break;
            case 'Numero_Orden_Produccion':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Material':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Fecha_Produccion':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Material_Descripcion':
                permitirOrdenarInfoEnColumna = 0;
                break;
            case 'Material_Ubicacion_Piso':
                permitirOrdenarInfoEnColumna = 0;
                break;
            case 'Valida_Existencia_En_Piso':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Cantidad_Mat_Para_Producir_Un_Prod':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Cantidad_Mat_Total_Para_Producir':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Cantidad_Mat_Solicitado_Previamente':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Cantidad_Mat_Restante_Por_Solicitar':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Cantidad_Mat_A_Solicitar':
                permitirOrdenarInfoEnColumna = 1;
                break;
            case 'Material_Ubicacion_Almacen':
                permitirOrdenarInfoEnColumna = 0;
                break;
            case 'Valida_Existencia_En_Almacen':
                permitirOrdenarInfoEnColumna = 1;
                break;
            default:
                permitirOrdenarInfoEnColumna = 0;
        }

        return permitirOrdenarInfoEnColumna;
    },
    // END "validarOrdenColumnaEnDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd": function (columnaName) {
    // START "OrdenarPorOrdenDeColumna": function (a, b) {
    "OrdenarPorOrdenDeColumna": function (a, b) {
        if (debug === 1) {
            console.log("a" + a.ordenDeColumna);
            console.log("b" + b.ordenDeColumna);
        }

        var aName = a.ordenDeColumna;
        var bName = b.ordenDeColumna;

        return ((aName < bName) ? -1 : ((aName > bName) ? 1 : 0));
    }
    // END "OrdenarPorOrdenDeColumna": function (a, b) {
}; // END var eaton = {

// Cargar scripts
eaton.cargarScripts();
// Cargar estilos
eaton.cargarEstilos();

// START function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(ordenesProdSeleccionados) {
function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(ordenesProdSeleccionados) {
    if (debug == 1) {
        console.log("function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd");
        console.log(ordenesProdSeleccionados);
        console.log("prime pos:" + ordenesProdSeleccionados[0]);
    }
    //Cargar datatable
    eaton.cargarDataTableListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(ordenesProdSeleccionados);
}
// END function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd(ordenesProdSeleccionados) {

// START function incrementarDecrementar(botonValor, input, permitirDecrementarMenosQueCero) {
function incrementarDecrementar(botonValor, input, permitirDecrementarMenosQueCero) {
    var nuevoValor = 0;

    if (debug === 1) {
        console.log("incrementarDecrementar()");
        console.log("botonValor:" + botonValor);
        console.log("input:" + input);//Objeto donde colocar el valor
    }

    var valorAnterior = $('#' + input + '').val() || 0;// Obtenemos el valor anterior
    if (debug === 1) {
        console.log(valorAnterior);
    }

    if (botonValor === '+') {
        if (debug === 1) {
            console.log("Incrementar");
        }
        nuevoValor = parseFloat(valorAnterior) + 1;
    } else {
        if (botonValor === '-') {
            if (debug === 1) {
                console.log("Decrementar");
            }
            //Validamos si se permitir decrementar menos que cero
            if (permitirDecrementarMenosQueCero === 1) {
                if (debug === 1) {
                    console.log("Decrementar menos que cero");
                }
                if (valorAnterior > 0) {
                    nuevoValor = parseFloat(valorAnterior) - 1;
                } else {
                    nuevoValor = valorAnterior - 1;
                }
            } else {
                if (valorAnterior > 0) {
                    nuevoValor = parseFloat(valorAnterior) - 1;
                }
                else {
                    nuevoValor = 0;
                }
            }

        }
    }

    if (debug === 1) {
        console.log("nuevoValor:" + nuevoValor);
    }
    //Establecemos el nuevo valor
    $('#' + input + '').val(nuevoValor);

}
// END function incrementarDecrementar(botonValor, input, permitirDecrementarMenosQueCero) {

// START function preseleccionarRegistrosEnEjecutarSurtido() {
function preseleccionarRegistrosEnEjecutarSurtido() {
    // Obtenemos url actual
    var urlEjecutarSurtido  = String(window.location);
    if (debug === 1) {
        console.log(urlEjecutarSurtido);
    }

    // Validamos si estamos en la pagina Si estamos en la pagina de ejecutar surtido
    if (urlEjecutarSurtido.indexOf("ejecutar_surtido") != -1) {
    if (debug === 1) {
        console.log("estoy en ejecutarsurtido");
    }

    var totalRegistros = 0;
    var spanEncontrado = [];

    var configSistemaCantSolicitudPreseleccionado = 0;
    // START $(document).ready(function () {
    $(document).ready(function () {
        // Obtenemos total de registros
        totalRegistros = $app.touch.dataView('Grid_Material_Pte_Por_Surtir_V', 'controller')._totalRowCount;

        if (debug === 1) {
            console.log("totalRegistros: " + totalRegistros);
            // Cantidad de elementos en la lista/grid
            console.log("No. items: ");
            console.log($("ul.app-listview li.dv-item .app-btn-check").length);
            console.log("No. items , + check select all: ");
            console.log($("ul.app-listview .app-btn-check").length);
        }

        // START if (totalRegistros > 0){    
        if (totalRegistros > 0) {
            // Asignamos al arreglo los span
            spanEncontrado.push($("li.dv-item").find(".app-btn-check"));
            //spanEncontrado.push($("li.dv-item"));

            if (debug === 1) {
                console.log("spanEncontrado:");
                console.log(spanEncontrado);
            }

            // PTE OBTENER VALOR DE CONFIG DE SISTEMA.
            configSistemaCantSolicitudPreseleccionado = 5;

            // Si la cantidad de registros es menor igual a la cantidad configurada para preseleccionar
            if (totalRegistros <= configSistemaCantSolicitudPreseleccionado) {
                if (debug === 1) {
                    console.log("totalRegistros: " + totalRegistros);
                    console.log("configSistemaCantSolicitudPreseleccionado: " + configSistemaCantSolicitudPreseleccionado);
                }
                // Ejecutamos accion de seleccionar todo
                $("ul .app-list-instruction").find(".app-btn-check").click();
            }
            else {
                // Recorremos el arreglo de span con check
                $.each(spanEncontrado[0], function (index, value) {
                    if (debug === 1) {
                        console.log("index: " + index);
                    }
                    // Si la posicion actual es menos que configSistemaCantSolicitudPreseleccionado    
                    if (index < configSistemaCantSolicitudPreseleccionado) {

                        //fila de lista
                        var fila = $(this).parents("li").index();
                        if (debug === 1) {
                            console.log("fila: " + fila);
                        }

                        // Agregamos la clase
                        $(this).parents("li").addClass("app-checked");
                        //$(this).parents("li").find("a.ui-btn").addClass("app-checked app-selected");
                        $(this).parents("li").find("a.ui-btn").addClass("app-checked");
                        $(this).parents("li").find("a.ui-btn").addClass("app-selected");
                        $(this).parents("li").find("span.app-btn-check").addClass("app-btn-check-selected");
                    }
                });
            }
        }
    });
    // END $(document).ready(function () {
    }
    // END if (totalRegistros > 0){

    /*$("li.dv-item").click(function (index) {
        console.log("click ");
        var fila =$(this).index();// $(this).parents("li").index();
        if (debug === 1) {
            console.log("click en: " + fila);
        }
        //console.log($(this).find("span.app-btn-check"));
        //$(this).eq(fila).find("span.app-btn-check").removeClass("app-btn-check-selected");
    })*/
};
// END function preseleccionarRegistrosEnEjecutarSurtido() {

// START function IniciarSurtido(materialesSeleccionados) {
function IniciarSurtido(materialesSeleccionados) {
    var Tmp_Ruta_Optima_Transaccion_Id;    
    var cantMaterialesSeleccionados;
    var datos;
    var resultado = false;

    Tmp_Ruta_Optima_Transaccion_Id = eaton.createGuid();
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    if (debug == 1) {
        console.log("function IniciarSurtido");
        console.log(materialesSeleccionados);
        console.log("prime pos:" + materialesSeleccionados[0]);
        console.log("Tmp_Ruta_Optima_Transaccion_Id: " + Tmp_Ruta_Optima_Transaccion_Id);
        console.log(cantMaterialesSeleccionados);
    }
    
    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, value) {
        if (debug === 1) {
            console.log("index: " + index);
            console.log("value: " + value);
        }
        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_Material_Pte_Por_Surtir_V'
            //pageSize: 10,
            , filter: [
                { field: 'Material_Id', operator: '=', value: value }
            ]
            , dataType: 'json'
            , done: function (result) {

                if (debug === 1) {
                    console.log("result: ");
                    console.log(result.Grid_Material_Pte_Por_Surtir_V);
                }

                try {

                    datos = result.Grid_Material_Pte_Por_Surtir_V;
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {

                    if (debug === 1) {
                        console.log("result === true");
                        console.log("datos:"); 
                        console.log(datos);
                        console.log("Cantidad_Solicitado:");
                        console.log(datos[0].Cantidad_Solicitado);
                        console.log("Unidad_Material_Id:");
                        console.log(datos[0].Unidad_Material_Id);
                    }
                    
                    // Generar Temporal Ruta Optima
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_Material_Pte_Por_Surtir_V'
                      //,async: false
                      , command: 'Custom'
                      , argument: 'ExecCS01'
                      , values: [
                            { name: 'Material_Id', newValue: value }
                          , { name: 'Tmp_Ruta_Optima_Transaccion_Id', newValue: Tmp_Ruta_Optima_Transaccion_Id }
                          , { name: 'Cantidad_Solicitado', newValue: datos[0].Cantidad_Solicitado }
                          , { name: 'Unidad_Material_Id', newValue: datos[0].Unidad_Material_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);
                          if (debug === 1) {
                              console.log("ExecCS01 result : ");
                              console.log(result);
                          }              
                          compruebaIteracion(index,cantMaterialesSeleccionados,Tmp_Ruta_Optima_Transaccion_Id);
                      }
                    });
                    // END $app.execute({
                }
            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {   
}
// END function IniciarSurtido(materialesSeleccionados) {

var iteraciones = [];

// START function compruebaIteracion(indice) {
function compruebaIteracion(indice,cantMaterialesSeleccionados, Tmp_Ruta_Optima_Transaccion_Id) {
    // Agregamos al arreglo
    iteraciones.push(indice);
    if (debug === 1) {
        console.log("arr iteraciones: ");
        console.log(iteraciones);
    }
    // START if (iteraciones.length === cantMaterialesSeleccionados) {
    if (iteraciones.length === cantMaterialesSeleccionados) {
        if (debug === 1) {
            console.log("arreglos iguales!");
        }
        // Generar Ruta Optima
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Material_Pte_Por_Surtir_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Tmp_Ruta_Optima_Transaccion_Id', newValue: Tmp_Ruta_Optima_Transaccion_Id }
          ]
          , done: function (result) {
              eval(result.clientScript);
              if (debug == 1) {
                  console.log("ExecCS02 result : ");
                  console.log(result);
                  console.log("Tmp_Ruta_Optima_Transaccion_Id: " + Tmp_Ruta_Optima_Transaccion_Id);
              }
          }
        });
        // END $app.execute({

        iteraciones = [];
    }
    // END if (iteraciones.length === cantMaterialesSeleccionados) {
}
// END function compruebaIteracion(indice) {

var iteracionesDos = [];
// START function compruebaIteracionMultipleOrdenProdSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
function compruebaIteracionMultipleOrdenProdSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
    // Agregamos al arreglo
    iteracionesDos.push(indice);

    fnDebug("Estamos en funcion compruebaIteracionMultipleOrdenProdSeleccionado: ");
    fnDebug("arr iteracionesDos: ");
    fnDebug(iteracionesDos);
    
    // START if (iteraciones.length === cantMaterialesSeleccionados) {
    if (iteracionesDos.length === cantOrdenProdSeleccionados) {

        fnDebug("arreglos iguales!");
        $app.touch.show({
            controller: 'Grid_orden_detalle_de_multiple_orden_prod_v',
            startCommand: 'grid1',
            startArgument: 'select',
            filter: [
                { name: 'Seleccion_Temporal_Transaccion_Id', value: Seleccion_Temporal_Transaccion_Id }               
            ]
        });

        iteracionesDos = [];

    }
    // END if (iteraciones.length === cantMaterialesSeleccionados) {

    fnDebug("Salimos de funcion compruebaIteracionMultipleOrdenProdSeleccionado: ");
}
// END function compruebaIteracionMultipleOrdenProdSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {

// START function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProdV20(ordenesProdSeleccionados) {
function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProdV20(ordenesProdSeleccionados) {
    var Seleccion_Temporal_Transaccion_Id = eaton.createGuid();    

    fnDebug("function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd");
    fnDebug("ordenesProdSeleccionados");
    fnDebug(ordenesProdSeleccionados);
    fnDebug("Seleccion_Temporal_Transaccion_Id: " + Seleccion_Temporal_Transaccion_Id);
    
    // START $.each(ordenesProdSeleccionados, function (i, value) {
    $.each(ordenesProdSeleccionados, function (i, value) {
        fnDebug("i: " + i);
        fnDebug("value: " + value);
    
        // START $app.execute({
        $app.execute({
            controller: 'Orden_Produccion_Seleccion_Temporal'        
          , command: 'Insert'
          , values: [            
              { name: 'Orden_Produccion_Seleccion_Temporal_Id', value: null }
            , { name: 'Seleccion_Temporal_Transaccion_Id', newValue: Seleccion_Temporal_Transaccion_Id }
            , { name: 'Tipo_Seleccion_Temporal_Id', newValue: 1 } // 1: Para listar materiales de multiples ordenes
            , { name: 'Orden_Produccion_Id', newValue: value }
          ]
          , done: function (result) {
              eval(result.clientScript);

              fnDebug("Insert result : ");
              fnDebug(result);

              compruebaIteracionMultipleOrdenProdSeleccionado(i, ordenesProdSeleccionados.length, Seleccion_Temporal_Transaccion_Id);
          }
        });
        // END $app.execute({
    });
    // END $.each(ordenesProdSeleccionados, function (i, value) {
}
// END function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProdV20(ordenesProdSeleccionados) {

// START function CrearSolicitudMaterial(materialesSeleccionados, SeleccionTemporalTransaccionId) {
function CrearSolicitudMaterial(materialesSeleccionados, SeleccionTemporalTransaccionId) {
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    fnDebug("function CrearSolicitudMaterial");
    fnDebug(materialesSeleccionados);
    fnDebug("prime pos:" + materialesSeleccionados[0]);        
    fnDebug(cantMaterialesSeleccionados);
    fnDebug("SeleccionTemporalTransaccionId " + SeleccionTemporalTransaccionId);    

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, valor) {
        var n = valor.search(",");

        if (n == -1) {
            //valor.replace(",", ";")
            var valores = valor.split(";");
        } else {
            var valores = valor.split(",");
        }

        fnDebug("index: " + index);
        fnDebug("valor: " + valor);
        fnDebug(valores);
        
        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Prod_V'

            , filter: [
                { field: 'Orden_Produccion_Detalle_Id', operator: '=', value: valores[1] }
                , { field: 'Seleccion_Temporal_Transaccion_Id', operator: '=', value: SeleccionTemporalTransaccionId }
            ]
            , dataType: 'json'
            , done: function (result){                
                fnDebug("result: ");
                fnDebug(result.Grid_Orden_Detalle_De_Multiple_Orden_Prod_V);

                try {

                    datos = result.Grid_Orden_Detalle_De_Multiple_Orden_Prod_V;
                    //console.log(datos);
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {
                  
                    // Generar Temporal Ruta Optima
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Prod_V'
                        //,async: false
                      , command: 'Custom'
                      , argument: 'ExecCS01'
                      , values: [                            
                           { name: 'Orden_Produccion_Id', newValue: datos[0].Orden_Produccion_Id }
                          , { name: 'Orden_Produccion_Detalle_Id', newValue: datos[0].Orden_Produccion_Detalle_Id }
                          , { name: 'Producto_Id', newValue: datos[0].Producto_Id }
                          , { name: 'Material_Id', newValue: datos[0].Material_Id }
                          , { name: 'Cantidad_Mat_A_Solicitar', newValue: datos[0].Cantidad_Mat_A_Solicitar }
                          , { name: 'Cantidad_Mat_Restante_Por_Solicitar', newValue: datos[0].Cantidad_Mat_Restante_Por_Solicitar }
                          , { name: 'Area_Entrega_Id', newValue: datos[0].Area_Entrega_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);
                          
                          fnDebug("Grid_Orden_Detalle_De_Multiple_Orden_Prod_V=>ExecCS01 result : ");
                              fnDebug(result);
                              
                          CompruebaIteracionParaCrearSolicitudMaterial(index, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId);
                      }
                    });
                    // END $app.execute({
                }
            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {  
}
// END function CrearSolicitudMaterial(materialesSeleccionados, SeleccionTemporalTransaccionId) {

// START function CompruebaIteracionParaCrearSolicitudMaterial(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
var iteracionesCrearSolicitudMaterial = [];
function CompruebaIteracionParaCrearSolicitudMaterial(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
    // Agregamos al arreglo
    iteracionesCrearSolicitudMaterial.push(indice);

    fnDebug("arr iteracionesCrearSolicitudMaterial: ");
    fnDebug(iteracionesCrearSolicitudMaterial);
    fnDebug("SeleccionTemporalTransaccionId: " + SeleccionTemporalTransaccionId);

    // START if (iteraciones.length === cantMaterialesSeleccionados) {
    if (iteracionesCrearSolicitudMaterial.length === cantMaterialesSeleccionados) {        
        fnDebug("arreglos iguales!");

        // Borrar seleccion temporal
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Prod_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Seleccion_Temporal_Transaccion_Id', newValue: SeleccionTemporalTransaccionId }
          ]
          , done: function (result) {
            eval(result.clientScript);              
            fnDebug("Grid_Orden_Detalle_De_Multiple_Orden_Prod_V=>ExecCS02 result : ");
            fnDebug(result);
            fnDebug("Seleccion_Temporal_Transaccion_Id: " + SeleccionTemporalTransaccionId);              
          }
        });
        // END $app.execute({

        iteracionesCrearSolicitudMaterial = [];
    }
    // END if (iteraciones.length === cantMaterialesSeleccionados) {
}
// END function CompruebaIteracionParaCrearSolicitudMaterial(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {

// START function IniciarSurtidoConAreaAsignada(materialesSeleccionados) {
function IniciarSurtidoConAreaAsignada(materialesSeleccionados) {
    var Tmp_Material_Surtido_Transaccion_Id;
    var cantMaterialesSeleccionados;
    var datos;
    var resultado = false;

    Tmp_Material_Surtido_Transaccion_Id = eaton.createGuid();
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    if (debug == 1) {
        console.log("function IniciarSurtido");
        console.log(materialesSeleccionados);
        console.log("prime pos:" + materialesSeleccionados[0]);
        console.log("Tmp_Material_Surtido_Transaccion_Id: " + Tmp_Material_Surtido_Transaccion_Id);
        console.log(cantMaterialesSeleccionados);
    }

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, value) {
        if (debug === 1) {
            console.log("index: " + index);
            console.log("value: " + value);
        }
        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_V'
            //pageSize: 10,
            , filter: [
                { field: 'Material_Id', operator: '=', value: value }
            ]
            , dataType: 'json'
            , done: function (result) {

                if (debug === 1) {
                    console.log("result: ");
                    console.log(result.Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_V);
                }

                try {

                    datos = result.Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_V;
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {

                    if (debug === 1) {
                        console.log("result === true");
                        console.log("datos:");
                        console.log(datos[0]);
                        console.log("Cantidad_Solicitado:");
                        console.log(datos[0].Cantidad_Solicitado);
                        console.log("Unidad_Material_Id:");
                        console.log(datos[0].Unidad_Material_Id);
                        console.log("Ubicacion_Almacenamiento_Id:");
                        console.log(datos[0].Ubicacion_Almacenamiento_Id);
                    }

                    // Generar Temporal Ruta Optima
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_Material_Pte_Por_Surtir_Con_Area_Asignada_V'
                        //,async: false
                      , command: 'Custom'
                      , argument: 'ExecCS01'
                      , values: [
                            { name: 'Material_Id', newValue: value }
                          , { name: 'Tmp_Material_Surtido_Transaccion_Id', newValue: Tmp_Material_Surtido_Transaccion_Id }
                          , { name: 'Cantidad_Solicitado', newValue: datos[0].Cantidad_Solicitado }
                          , { name: 'Unidad_Material_Id', newValue: datos[0].Unidad_Material_Id }
                          , { name: 'Ubicacion_Almacenamiento_Id', newValue: datos[0].Ubicacion_Almacenamiento_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);
                          if (debug === 1) {
                              console.log("ExecCS01 result : ");
                              console.log(result);
                          }
                         compruebaIteracionMaterialSurtidoConAreaAsignada(index, cantMaterialesSeleccionados, Tmp_Material_Surtido_Transaccion_Id);
                      }
                    });
                    // END $app.execute({
                }
            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {   
}
// END function IniciarSurtido(materialesSeleccionados) {

var iteracionesMaterialSurtidoConAreaAsignada = [];
// START function compruebaIteracionMaterialSurtidoConAreaAsignada(indice, cantMaterialesSeleccionados, Tmp_Material_Surtido_Transaccion_Id) {
function compruebaIteracionMaterialSurtidoConAreaAsignada(indice, cantMaterialesSeleccionados, Tmp_Material_Surtido_Transaccion_Id) {
    // Agregamos al arreglo
    iteracionesMaterialSurtidoConAreaAsignada.push(indice);
    if (debug === 1) {
        console.log("arr iteracionesMaterialSurtidoConAreaAsignada: ");
        console.log(iteracionesMaterialSurtidoConAreaAsignada);
    }
    // START if (iteracionesMaterialSurtidoConAreaAsignada.length === cantMaterialesSeleccionados) {
    if (iteracionesMaterialSurtidoConAreaAsignada.length === cantMaterialesSeleccionados) {
        if (debug === 1) {
            console.log("arreglos iguales!");
        }
        window.location.replace('Grid_Material_Surtido_A_Ejecutar_V?Tmp_Material_Surtido_Transaccion_Id=' + Tmp_Material_Surtido_Transaccion_Id);

        iteracionesMaterialSurtidoConAreaAsignada = [];
    }
    // END if (iteracionesMaterialSurtidoConAreaAsignada.length === cantMaterialesSeleccionados) {
}
// END function compruebaIteracionMaterialSurtidoConAreaAsignada(indice, cantMaterialesSeleccionados, Tmp_Material_Surtido_Transaccion_Id) {

// START function MostrarListaDeMaterialPtePorSurtirAgrupadoDeMultiplesOrdenesProd(ordenesProdSeleccionados) {
function MostrarListaDeMaterialPtePorSurtirAgrupadoDeMultiplesOrdenesProd(ordenesProdSeleccionados) {
    var Seleccion_Temporal_Transaccion_Id = eaton.createGuid();
    var stringOrdenesProdSeleccionados = ordenesProdSeleccionados.toString();

    fnDebug("function MostrarListaDeMaterialPtePorSurtirAgrupadoDeMultiplesOrdenesProd");
    fnDebug("ordenesProdSeleccionados");
    fnDebug(ordenesProdSeleccionados);
    fnDebug("Seleccion_Temporal_Transaccion_Id: " + Seleccion_Temporal_Transaccion_Id);
  
    // END $app.execute({
    $.each(ordenesProdSeleccionados, function (i, value) {
        fnDebug("i: " + i);
        fnDebug("value: " + value);

        // START $app.execute({
        $app.execute({
            controller: 'Orden_Produccion_Seleccion_Temporal'
          , command: 'Insert'
          , values: [
              { name: 'Orden_Produccion_Seleccion_Temporal_Id', value: null }
            , { name: 'Seleccion_Temporal_Transaccion_Id', newValue: Seleccion_Temporal_Transaccion_Id }
            , { name: 'Tipo_Seleccion_Temporal_Id', newValue: 2 } //2: Para listar materiales agrupados de multiples ordenes
            , { name: 'Orden_Produccion_Id', newValue: value }
          ]
          , done: function (result){
              eval(result.clientScript);
              fnDebug("Insert result : ");
              fnDebug(result);
              compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado(i, ordenesProdSeleccionados.length, Seleccion_Temporal_Transaccion_Id);
          }
        });
        // END $app.execute({
    });    
}
// END function MostrarListaDeMaterialPtePorSurtirAgrupadoDeMultiplesOrdenesProd(ordenesProdSeleccionados) {

var iteracionesMultipleOrdenProdPorFechaImpresion = [];
// START function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
    // Agregamos al arreglo
    iteracionesMultipleOrdenProdPorFechaImpresion.push(indice);

    fnDebug("Estamos en funcion compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado: ");
    fnDebug("arr iteracionesDos: ");
    fnDebug(iteracionesMultipleOrdenProdPorFechaImpresion);

    // START if (iteracionesMultipleOrdenProdPorFechaImpresion.length === cantOrdenProdSeleccionados) {
    if (iteracionesMultipleOrdenProdPorFechaImpresion.length === cantOrdenProdSeleccionados) {

        fnDebug("arreglos iguales!");       

        $app.touch.show({
            controller: 'Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V',
            startCommand: 'grid1',
            startArgument: 'select',
            filter: [
                // { name: 'Tipo_Seleccion_Temporal_Id', value: 2 }
                // ,
                { name: 'Seleccion_Temporal_Transaccion_Id', value: Seleccion_Temporal_Transaccion_Id }
            ]
        });

        iteracionesMultipleOrdenProdPorFechaImpresion = [];

    }
    // END if (iteracionesMultipleOrdenProdPorFechaImpresion.length === cantOrdenProdSeleccionados) {

    fnDebug("Salimos de funcion compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado: ");
}
// END function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionado(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {

// START function CrearSolicitudMaterialDeMatAgrupado(materialesSeleccionados) {
function CrearSolicitudMaterialDeMatAgrupado(materialesSeleccionados) {
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    fnDebug("function CrearSolicitudMaterialDeMatAgrupado");
    fnDebug(materialesSeleccionados);
    fnDebug("prime pos:" + materialesSeleccionados[0]);
    fnDebug(cantMaterialesSeleccionados);

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, valor) {

        var n = valor.search(",");

        if (n == -1) {
            //valor.replace(",", ";")
            var valores = valor.split(";");
        } else {
            var valores = valor.split(",");
        }
        //valor.replace(",", ";");
        //var valores = valor.split(",");

        fnDebug("index: " + index);
        fnDebug("valor: " + valor);
        fnDebug("valores");
        fnDebug(valores);
        fnDebug("Material_Id " + valores[0]);
        fnDebug("SeleccionTemporalTransaccionId " + valores[1]);

        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V'
            , filter: [
                { field: 'Material_Id', operator: '=', value: valores[0] }
                , { field: 'Seleccion_Temporal_Transaccion_Id', operator: '=', value: valores[1] }
            ]
            , dataType: 'json'
            , done: function (result) {
                fnDebug("result: ");
                fnDebug(result.Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V);
                
                try {

                    datos = result.Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V;
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {
                  
                   /* fnDebug("result === true");
                    fnDebug("datos:");
                    fnDebug(datos);
                    //fnDebug("Material_Agrupado_De_Multiple_Orden_Produccion_Id:");
                    //fnDebug(datos[0].Material_Agrupado_De_Multiple_Orden_Produccion_Id);
                    fnDebug("Material_Id:");
                    fnDebug(datos[0].Material_Id);
                    fnDebug("Cantidad_Mat_A_Solicitar:");
                    fnDebug(datos[0].Cantidad_Mat_A_Solicitar);
                    fnDebug("Cantidad_Mat_Restante_Por_Solicitar:");
                    fnDebug(datos[0].Cantidad_Mat_Restante_Por_Solicitar);
                    fnDebug("Material_Orden_Produccion:");
                    fnDebug(datos[0].Material_Orden_Produccion);
                    fnDebug("Material_Orden_Produccion_Detalle:");
                    fnDebug(datos[0].Material_Orden_Produccion_Detalle);
                    fnDebug("Area_Entrega_Id:");
                    fnDebug(datos[0].Area_Entrega_Id);
                    */
                    // Generar Temporal Ruta Optima
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V'
                      , command: 'Custom'
                      , argument: 'ExecCS02' //Crear solicitud de material
                      , values: [
                           { name: 'Material_Agrupado_De_Multiple_Orden_Produccion_Id', newValue: datos[0].Material_Agrupado_De_Multiple_Orden_Produccion_Id }
                          , { name: 'Material_Id', newValue: datos[0].Material_Id }
                          , { name: 'Cantidad_Mat_A_Solicitar', newValue: datos[0].Cantidad_Mat_A_Solicitar }
                          , { name: 'Cantidad_Mat_Restante_Por_Solicitar', newValue: datos[0].Cantidad_Mat_Restante_Por_Solicitar }
                          , { name: 'Material_Orden_Produccion', newValue: datos[0].Material_Orden_Produccion }                          
                          , { name: 'Material_Orden_Produccion_Detalle', newValue: datos[0].Material_Orden_Produccion_Detalle }
                          , { name: 'Area_Entrega_Id', newValue: datos[0].Area_Entrega_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);
                          fnDebug("Grid_Material_Agrupado_De_Multiples_Ordenes_Produccion_V=>ExecCS02 result : ");
                          fnDebug(result);

                         CompruebaIteracionParaCrearSolicitudMaterialDeMatagrupadp(index, cantMaterialesSeleccionados,valores[1]);
                      }
                    });
                    // END $app.execute({
                }
                
            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {  
}
// END function CrearSolicitudMaterialDeMatAgrupado(materialesSeleccionados) {

// START function CompruebaIteracionParaCrearSolicitudMaterialDeMatagrupadp(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
var iteracionesCrearSolicitudMaterialDeMatAgrupado = [];
function CompruebaIteracionParaCrearSolicitudMaterialDeMatagrupadp(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
    // Agregamos al arreglo
    iteracionesCrearSolicitudMaterialDeMatAgrupado.push(indice);

    fnDebug("arr iteracionesCrearSolicitudMaterialDeMatAgrupado: ");
    fnDebug(iteracionesCrearSolicitudMaterialDeMatAgrupado);
    fnDebug("SeleccionTemporalTransaccionId: " + SeleccionTemporalTransaccionId);

    // START if (iteraciones.length === cantMaterialesSeleccionados) {
    if (iteracionesCrearSolicitudMaterialDeMatAgrupado.length === cantMaterialesSeleccionados) {
        fnDebug("arreglos iguales!");

        // Borrar seleccion temporal
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Prod_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Seleccion_Temporal_Transaccion_Id', newValue: SeleccionTemporalTransaccionId }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_Orden_Detalle_De_Multiple_Orden_Prod_V=>ExecCS02 result : ");
              fnDebug(result);
              fnDebug("Seleccion_Temporal_Transaccion_Id: " + SeleccionTemporalTransaccionId);
          }
        });
        // END $app.execute({

        iteracionesCrearSolicitudMaterialDeMatAgrupado = [];
    }
    // END if (iteraciones.length === cantMaterialesSeleccionados) {
}
// END function CompruebaIteracionParaCrearSolicitudMaterialDeMatagrupadp(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {

/*===== START FUNCIONES DE DEVOLUCION DE MATERIALES */

var indexError = 0;
//START function IniciarDevolucion(solicDevSeleccionados) {
function IniciarDevolucion(solicDevSeleccionados) {
    var Tmp_Mov_Ruta_Optima_Transaccion_Id;
    var cantSolicDevSeleccionados;
    var datos;
    var resultado = false;
    var Movimiento_Id = 0;
    var Tipo_Movimiento_Id = 0;

    Tmp_Mov_Ruta_Optima_Transaccion_Id = eaton.createGuid();
    cantSolicDevSeleccionados = solicDevSeleccionados.length;

    fnDebug("function IniciarDevolucion");
    fnDebug(solicDevSeleccionados);
    fnDebug("prime pos:" + solicDevSeleccionados[0]);
    fnDebug("Tmp_Mov_Ruta_Optima_Transaccion_Id: " + Tmp_Mov_Ruta_Optima_Transaccion_Id);
    fnDebug("cantSolicDevSeleccionados: " + cantSolicDevSeleccionados);    

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(solicDevSeleccionados, function (index, value) {

        var valor = value.search(",");
        if (valor == -1) {
            var valores = value.split(";");
        } else {
            var valores = value.split(",");
        }

        var MovimientoId = valores[0];
        var TipoMovimientoId = valores[1];
        var CantError = 0;
        

        fnDebug("index: " + index);
        fnDebug("value: " + value);
        fnDebug("valores: " + valores);
        fnDebug("MovimientoId: " + MovimientoId);
        fnDebug("TipoMovimientoId: " + TipoMovimientoId);

        try{
            // Generar Temporal Mov Ruta Optima
            // Ejecutamos BR ExecCS01
            // START $app.execute({
            $app.execute({
                controller: 'Grid_Movimiento_Dev_Pte_V'
              , command: 'Custom'
              , argument: 'ExecCS01'
              , values: [
                    { name: 'Movimiento_Id', newValue: MovimientoId }
                  , { name: 'Tipo_Movimiento_Id', newValue: TipoMovimientoId }
                  , { name: 'Tmp_Mov_Ruta_Optima_Transaccion_Id', newValue: Tmp_Mov_Ruta_Optima_Transaccion_Id }
              ]
              , done: function (result) {
                  eval(result.clientScript);
                  fnDebug("ExecCS01 result : ");
                  fnDebug(result);
                  fnDebug("ExecCS01 result.clientScript");
                  fnDebug(result.clientScript);

                  //Verificamos que existan errores
                  fnDebug("ExecCS01 result.errors");
                  CantError = result.errors.length;                  
                  
                  fnDebug("CantError" + CantError);

                  if (CantError > 0) {
                      $app.showMessage("Ocurrió un error en el movimiento" + MovimientoId);
                      //Incrementamos indice de error
                      indexError = indexError + 1 ;
                  } 
                  //Comprobamos iteración
                  CompruebaIteracionDevolucionPte(index, indexError, cantSolicDevSeleccionados,Tmp_Mov_Ruta_Optima_Transaccion_Id,TipoMovimientoId);
              }
            });
            // END $app.execute({
        }
        catch(e){
            $app.showMessage(e.message);
        }
       
    });
    // END $.each(materialesSeleccionados, function (i, value) {   

}
//END function IniciarDevolucion(solicDevSeleccionados) {

var iteracionDevolucionPte = [];
//START function CompruebaIteracionDevolucionPte(indice, indexError, cantSolicDevSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId){
function CompruebaIteracionDevolucionPte(indice, indexError, cantSolicDevSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId) {

    // Agregamos al arreglo
    iteracionDevolucionPte.push(indice);

    fnDebug("indice: " + indice);
    fnDebug("indexError: " + indexError);

    fnDebug("arr iteracionDevolucionPte: " + iteracionDevolucionPte);
    fnDebug("cant iteracionDevolucionPte: " + iteracionDevolucionPte.length);
    fnDebug("cantSolicDevSeleccionados: " + cantSolicDevSeleccionados);
    fnDebug("Tmp_Mov_Ruta_Optima_Transaccion_Id: " + Tmp_Mov_Ruta_Optima_Transaccion_Id);

    //START if (iteracionDevolucionPte.length - indexError === cantSolicDevSeleccionados - indexError) {
    if (iteracionDevolucionPte.length - indexError === cantSolicDevSeleccionados - indexError) {
        fnDebug("arreglos iguales!");
        
        //Generar Movimiento Ruta Optima
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Movimiento_Dev_Pte_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              {name:'Tmp_Mov_Ruta_Optima_Transaccion_Id', newValue: Tmp_Mov_Ruta_Optima_Transaccion_Id }
             ,{name:'Tipo_Movimiento_Id', newValue: TipoMovimientoId }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_Movimiento_Dev_Pte_V=>ExecCS02 result : ");
              fnDebug(result);
          }
        });
        // END $app.execute({
        
        iteracionDevolucionPte = [];
    }
    // END if (iteracionDevolucionPte.length - indexError === cantSolicDevSeleccionados - indexError) {
    
}
//END function CompruebaIteracionDevolucionPte(indice, indexError, cantSolicDevSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId){

/*===== END FUNCIONES DE DEVOLUCION DE MATERIALES */

/*===== START FUNCIONES DE TRANSFERENCIAS DE MATERIALES */

//START function IniciarTransferencia(solicTransfSeleccionados) {
var indexErrorTransf = 0;
function IniciarTransferencia(solicTransfSeleccionados) {
    var Tmp_Mov_Ruta_Optima_Transaccion_Id;
    var cantSolicTransfSeleccionados;
    var datos;
    var resultado = false;
    var Movimiento_Id = 0;
    var Tipo_Movimiento_Id = 0;

    Tmp_Mov_Ruta_Optima_Transaccion_Id = eaton.createGuid();
    cantSolicTransfSeleccionados = solicTransfSeleccionados.length;

    fnDebug("function IniciarTransferencia");
    fnDebug(solicTransfSeleccionados);
    fnDebug("prime pos:" + solicTransfSeleccionados[0]);
    fnDebug("Tmp_Mov_Ruta_Optima_Transaccion_Id: " + Tmp_Mov_Ruta_Optima_Transaccion_Id);
    fnDebug("cantSolicTransfSeleccionados: " + cantSolicTransfSeleccionados);
    
    
    // START $.each(solicTransfSeleccionados, function (i, value) {
    $.each(solicTransfSeleccionados, function (index, value) {

        var valor = value.search(",");
        if (valor == -1) {
            var valores = value.split(";");
        } else {
            var valores = value.split(",");
        }

        var MovimientoId = valores[0];
        var TipoMovimientoId = valores[1];
        var CantError = 0;


        fnDebug("index: " + index);
        fnDebug("value: " + value);
        fnDebug("valores: " + valores);
        fnDebug("MovimientoId: " + MovimientoId);
        fnDebug("TipoMovimientoId: " + TipoMovimientoId);
        
        try {
            // Generar Temporal Mov Ruta Optima
            // Ejecutamos BR ExecCS01
            // START $app.execute({
            $app.execute({
                controller: 'Grid_Movimiento_Transfer_Pte_V'
              , command: 'Custom'
              , argument: 'ExecCS01'
              , values: [
                    { name: 'Movimiento_Id', newValue: MovimientoId }
                  , { name: 'Tipo_Movimiento_Id', newValue: TipoMovimientoId }
                  , { name: 'Tmp_Mov_Ruta_Optima_Transaccion_Id', newValue: Tmp_Mov_Ruta_Optima_Transaccion_Id }
              ]
              , done: function (result) {
                  eval(result.clientScript);
                  fnDebug("Grid_Movimiento_Transfer_Pte_V=>ExecCS01 result : ");
                  fnDebug(result);
                  fnDebug("Grid_Movimiento_Transfer_Pte_V=>ExecCS01 result.clientScript");
                  fnDebug(result.clientScript);

                  //Verificamos que existan errores
                  fnDebug("Grid_Movimiento_Transfer_Pte_V=>ExecCS01 result.errors");
                  CantError = result.errors.length;

                  fnDebug("CantError" + CantError);

                  if (CantError > 0) {
                      $app.showMessage("Ocurrió un error en el movimiento" + MovimientoId);
                      //Incrementamos indice de error
                      indexErrorTransf = indexErrorTransf + 1;
                  }
                  //Comprobamos iteración
                  CompruebaIteracionTransferenciaPte(index, indexErrorTransf, cantSolicTransfSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId);
              }
            });
            // END $app.execute({
        }
        catch (e) {
            $app.showMessage(e.message);
        }
        
    });
    // END $.each(solicTransfSeleccionados, function (i, value) {   
    
}
//END function IniciarTransferencia(solicTransfSeleccionados) {

var iteracionTransferenciaPte = [];
//START function CompruebaIteracionTransferenciaPte(index, indexErrorTransf, cantSolicTransfSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId)
function CompruebaIteracionTransferenciaPte(index, indexErrorTransf, cantSolicTransfSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId){

    // Agregamos al arreglo
    iteracionTransferenciaPte.push(index);

    fnDebug("index: " + index);
    fnDebug("indexErrorTransf: " + indexErrorTransf);

    fnDebug("arr iteracionDevolucionPte: " + iteracionTransferenciaPte);
    fnDebug("cant iteracionDevolucionPte: " + iteracionTransferenciaPte.length);
    fnDebug("cantSolicDevSeleccionados: " + cantSolicTransfSeleccionados);
    fnDebug("Tmp_Mov_Ruta_Optima_Transaccion_Id: " + Tmp_Mov_Ruta_Optima_Transaccion_Id);

    // START if (iteracionTransferenciaPte.length - indexErrorTransf === cantSolicTransfSeleccionados - indexErrorTransf) {
    if (iteracionTransferenciaPte.length - indexErrorTransf === cantSolicTransfSeleccionados - indexErrorTransf) {
        fnDebug("arreglos iguales!");
        
        //Generar Movimiento Ruta Optima
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Movimiento_Transfer_Pte_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Tmp_Mov_Ruta_Optima_Transaccion_Id', newValue: Tmp_Mov_Ruta_Optima_Transaccion_Id }
             , { name: 'Tipo_Movimiento_Id', newValue: TipoMovimientoId }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_Movimiento_Transfer_Pte_V=>ExecCS02 result : ");
              fnDebug(result);              
          }
        });
        // END $app.execute({
        
        iteracionTransferenciaPte = [];
    }
    // END if (iteracionTransferenciaPte.length - indexErrorTransf === cantSolicTransfSeleccionados - indexErrorTransf) {

}
//END CompruebaIteracionTransferenciaPte(index, indexErrorTransf, cantSolicTransfSeleccionados, Tmp_Mov_Ruta_Optima_Transaccion_Id, TipoMovimientoId)

/*===== END FUNCIONES DE TRANSFERENCIAS DE MATERIALES */


/*===== START FUNCIONES DE INCANDESCENCIAS - SURTIDO DE PICKEO */

// START function IniciarSurtidoIncan(ordenProduccionSeleccionado) {
var indexErrorOrdenIncan = 0;
function IniciarSurtidoIncan(ordenProduccionSeleccionado) {
    var Tmp_Ruta_Optima_Transaccion_Id;
    var cantMaterialesSeleccionados;
    var datos;
    var resultado = false;
    
    Tmp_Ruta_Optima_Transaccion_Id = eaton.createGuid();
    cantRegSeleccionados = ordenProduccionSeleccionado.length;

    fnDebug("function IniciarSurtidoIncan");
    fnDebug("prime pos:" + ordenProduccionSeleccionado[0]);
    fnDebug("Tmp_Ruta_Optima_Transaccion_Id: " + Tmp_Ruta_Optima_Transaccion_Id);
    fnDebug("cantRegSeleccionados:" + cantRegSeleccionados);

    var ordenProduccionId;
    var numeroOrdenProdccion;
    var solicitudes;
    var materialesId;
    

    //START if (cantRegSeleccionados > 0) {
    if (cantRegSeleccionados > 0) {

        // START $.each(ordenProduccionSeleccionado, function (index, ordenProduccion) {
        $.each(ordenProduccionSeleccionado, function (index, ordenProduccion) {

            fnDebug("index:" + index);
            fnDebug("ordenProduccionId:" + ordenProduccion);
         
            // START Obtener datos             
            $app.execute({
                controller: 'Grid_Mat_Incan_Pte_Por_Surtir_V'
                , filter: [
                    { field: 'Orden_Produccion_Id', operator: '=', value: ordenProduccion }
                    , { field: 'Usuario_Id', operator: '=', value: $app.userId() }
                ]
                , dataType: 'json'
                , done: function (result) {

                    fnDebug("result: ");
                    fnDebug(result.Grid_Mat_Incan_Pte_Por_Surtir_V);

                    try {

                        datos = result.Grid_Mat_Incan_Pte_Por_Surtir_V;
                        resultado = true;

                    }//try
                    catch (e) {

                        resultado = false;
                        fnDebug("result === true");                        

                    }//catch (e)

                    // START if (resultado === true) {
                    if (resultado === true) {

                        fnDebug("result == true");
                        fnDebug("datos:");
                        fnDebug(datos);
                        fnDebug("Numero_Orden_Produccion:" + datos[0].Numero_Orden_Produccion);
                        fnDebug("Orden_Solicitud:" + datos[0].Orden_Solicitud);
                        fnDebug("Orden_Material_Id:" + datos[0].Orden_Material_Id);                            

                        // Generar Temporal Ruta Optima para incandescencias
                        // Ejecutamos BR ExecCS01
                        // START $app.execute({
                        $app.execute({
                            controller: 'Grid_Mat_Incan_Pte_Por_Surtir_V'
                          , command: 'Custom'
                          , argument: 'ExecCS01'
                          , values: [
                                { name: 'Orden_Produccion_Id', newValue: ordenProduccion }
                              , { name: 'Numero_Orden_Produccion', newValue: datos[0].Numero_Orden_Produccion }
                                , { name: 'Orden_Solicitud', newValue: datos[0].Orden_Solicitud }
                                , { name: 'Orden_Material_Id', newValue: datos[0].Orden_Material_Id }
                                , { name: 'Tmp_Ruta_Optima_Transaccion_Id', newValue: Tmp_Ruta_Optima_Transaccion_Id }
                          ]
                          , done: function (result) {
                              eval(result.clientScript);
                              fnDebug("Grid_Mat_Incan_Pte_Por_Surtir_V => ExecCS01 result : ");
                              fnDebug(result);
                              fnDebug("Grid_Mat_Incan_Pte_Por_Surtir_V => ExecCS01 result.clientScript");
                              fnDebug(result.clientScript);
            
                              //Verificamos que existan errores
                              fnDebug("Grid_Mat_Incan_Pte_Por_Surtir_V => ExecCS01 result.errors");
                              CantError = result.errors.length;
            
                              fnDebug("CantError" + CantError);
            
                              if (CantError > 0) {
                                  $app.alert("Ocurrió un error en el movimiento de la orden" + numeroOrdenProdccion);
                                  //Incrementamos indice de error
                                  indexErrorOrdenIncan = indexErrorOrdenIncan + 1;
                              }
            
                              //Comprobamos iteración
                              CompruebaIteracionRegIncanPte(index, indexErrorOrdenIncan, cantRegSeleccionados, Tmp_Ruta_Optima_Transaccion_Id);
                          }
                        });
                        // END $app.execute({
                                    
                    }
                    // END if (resultado === true) {
                }
                //END done
            });
            // END Obtener datos 
        });
        // END $.each(ordenProduccionSeleccionado, function (index, ordenProduccion) {
    }
    //END if (cantRegSeleccionados > 0) {
}
// END function IniciarSurtidoIncan(registrosSeleccionados) {

//START function CompruebaIteracionRegIncanPte(index, indexErrorOrdenIncan, cantRegSeleccionados, Tmp_Ruta_Optima_Transaccion_Id)
var iteracionOrdenIncanPte = [];
function CompruebaIteracionRegIncanPte(index, indexErrorOrdenIncan, cantRegSeleccionados, Tmp_Ruta_Optima_Transaccion_Id) {

    // Agregamos al arreglo
    iteracionOrdenIncanPte.push(index);

    fnDebug("index: " + index);
    fnDebug("indexErrorOrdenIncan: " + indexErrorOrdenIncan);

    fnDebug("arr iteracionOrdenIncanPte: " + iteracionOrdenIncanPte);
    fnDebug("cant iteracionOrdenIncanPte: " + iteracionOrdenIncanPte.length);
    fnDebug("cantSolicDevSeleccionados: " + cantRegSeleccionados);
    fnDebug("Tmp_Ruta_Optima_Transaccion_Id: " + Tmp_Ruta_Optima_Transaccion_Id);

    // START if (iteracionOrdenIncanPte.length - indexErrorTransf === cantRegSeleccionados - indexErrorTransf) {
    if (iteracionOrdenIncanPte.length - indexErrorTransf === cantRegSeleccionados - indexErrorTransf) {
        fnDebug("arreglos iguales!");

        //Generar Ruta Optima de incandescencias
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Mat_Incan_Pte_Por_Surtir_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Tmp_Ruta_Optima_Transaccion_Id', newValue: Tmp_Ruta_Optima_Transaccion_Id }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_Movimiento_Transfer_Pte_V=>ExecCS02 result : ");
              fnDebug(result);
          }
        });
        // END $app.execute({
        
        iteracionOrdenIncanPte = [];
    }
    // END if (iteracionTransferenciaPte.length - indexErrorTransf === cantSolicTransfSeleccionados - indexErrorTransf) {

}
//END CompruebaIteracionRegIncanPte(index, indexErrorOrdenIncan, cantRegSeleccionados, Tmp_Ruta_Optima_Transaccion_Id)

// START function MostrarListaDeMaterialDeMultiplesOrdenesProdIncan(ordenesProdSeleccionados) {
function MostrarListaDeMaterialDeMultiplesOrdenesProdIncan(ordenesProdSeleccionados) {
    var Seleccion_Temporal_Transaccion_Id = eaton.createGuid();

    fnDebug("START function MostrarListaDeMaterialPtePorSurtirDeMultiplesOrdenesProd");
    fnDebug("ordenesProdSeleccionados");
    fnDebug(ordenesProdSeleccionados);
    fnDebug("Seleccion_Temporal_Transaccion_Id: " + Seleccion_Temporal_Transaccion_Id);

    // START $.each(ordenesProdSeleccionados, function (i, value) {
    $.each(ordenesProdSeleccionados, function (i, value) {
        fnDebug("i: " + i);
        fnDebug("value: " + value);

        // START $app.execute({
        $app.execute({
            controller: 'Orden_Produccion_Seleccion_Temporal'
          , command: 'Insert'
          , values: [
              { name: 'Orden_Produccion_Seleccion_Temporal_Id', value: null }
            , { name: 'Seleccion_Temporal_Transaccion_Id', newValue: Seleccion_Temporal_Transaccion_Id }
            , { name: 'Tipo_Seleccion_Temporal_Id', newValue: 3 } /*-- 1: Materiales de múltiples órdenes prod; 
                                                                        2: Materiales agrupados de múltiples órdenes prod; 
                                                                        3: Materiales de múltiples órdenes prod INCAN; 
                                                                        4: Materiales agrupados de múltiples órdenes prod; 
                                                                 */
            , { name: 'Orden_Produccion_Id', newValue: value }
          ]
          , done: function (result) {
              eval(result.clientScript);

              fnDebug("Insert result : ");
              fnDebug(result);

              compruebaIteracionMultipleOrdenProdSeleccionadoIncan(i, ordenesProdSeleccionados.length, Seleccion_Temporal_Transaccion_Id);
          }
        });
        // END $app.execute({
    });
    // END $.each(ordenesProdSeleccionados, function (i, value) {
}
// END function MostrarListaDeMaterialDeMultiplesOrdenesProdIncan(ordenesProdSeleccionados) {

var iteracionesOrdenProdIncan = [];
// START function compruebaIteracionMultipleOrdenProdSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
function compruebaIteracionMultipleOrdenProdSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
    // Agregamos al arreglo
    iteracionesOrdenProdIncan.push(indice);

    fnDebug("Estamos en funcion compruebaIteracionMultipleOrdenProdSeleccionadoIncan: ");
    fnDebug("arr iteracionesOrdenProdIncan: ");
    fnDebug(iteracionesOrdenProdIncan);

    // START if (iteraciones.length === cantMaterialesSeleccionados) {
    if (iteracionesOrdenProdIncan.length === cantOrdenProdSeleccionados) {

        fnDebug("arreglos iguales!");
        $app.touch.show({
            controller: 'Grid_OrdenDet_DeMultipleOrdenProd_Incan_V',
            startCommand: 'grid1',
            startArgument: 'select',
            filter: [
                { name: 'Seleccion_Temporal_Transaccion_Id', value: Seleccion_Temporal_Transaccion_Id }
            ]
        });

        iteracionesOrdenProdIncan = [];

    }
    // END if (iteraciones.length === cantMaterialesSeleccionados) {

    fnDebug("Salimos de funcion compruebaIteracionMultipleOrdenProdSeleccionadoIncan: ");
}
// END function compruebaIteracionMultipleOrdenProdSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {

// START function MostrarListaDeMaterialPtePorSurtirAgrupDeMultOrdenesProdIncan(ordenesProdSeleccionados) {
function MostrarListaDeMaterialPtePorSurtirAgrupDeMultOrdenesProdIncan(ordenesProdSeleccionados) {
    var Seleccion_Temporal_Transaccion_Id = eaton.createGuid();
    var stringOrdenesProdSeleccionados = ordenesProdSeleccionados.toString();

    fnDebug("function MostrarListaDeMaterialPtePorSurtirAgrupoDeMultOrdenesProdIncan");
    fnDebug("ordenesProdSeleccionados");
    fnDebug(ordenesProdSeleccionados);
    fnDebug("Seleccion_Temporal_Transaccion_Id: " + Seleccion_Temporal_Transaccion_Id);

    // END $app.execute({
    $.each(ordenesProdSeleccionados, function (i, value) {
        fnDebug("i: " + i);
        fnDebug("value: " + value);

        // START $app.execute({
        $app.execute({
            controller: 'Orden_Produccion_Seleccion_Temporal'
          , command: 'Insert'
          , values: [
              { name: 'Orden_Produccion_Seleccion_Temporal_Id', value: null }
            , { name: 'Seleccion_Temporal_Transaccion_Id', newValue: Seleccion_Temporal_Transaccion_Id }
            , { name: 'Tipo_Seleccion_Temporal_Id', newValue:4 } /*-- 1: Materiales de múltiples órdenes prod; 
                                                                        2: Materiales agrupados de múltiples órdenes prod; 
                                                                        3: Materiales de múltiples órdenes prod INCAN; 
                                                                        4: Materiales agrupados de múltiples órdenes prod; 
                                                                 */
            , { name: 'Orden_Produccion_Id', newValue: value }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Insert result : ");
              fnDebug(result);
              compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan(i, ordenesProdSeleccionados.length, Seleccion_Temporal_Transaccion_Id);
          }
        });
        // END $app.execute({
    });
}
// END function MostrarListaDeMaterialPtePorSurtirAgrupoDeMultOrdenesProdIncan(ordenesProdSeleccionados) {

var iteracionesMultipleOrdenProdPorFechaImpresionIncan = [];
// START function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {
    // Agregamos al arreglo
    iteracionesMultipleOrdenProdPorFechaImpresionIncan.push(indice);

    fnDebug("Estamos en funcion compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan: ");
    fnDebug("arr iteracionesMultipleOrdenProdPorFechaImpresionIncan: ");
    fnDebug(iteracionesMultipleOrdenProdPorFechaImpresionIncan);

    // START if (iteracionesMultipleOrdenProdPorFechaImpresionIncan.length === cantOrdenProdSeleccionados) {
    if (iteracionesMultipleOrdenProdPorFechaImpresionIncan.length === cantOrdenProdSeleccionados) {

        fnDebug("arreglos iguales!");

        $app.touch.show({
            controller: 'Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V',
            startCommand: 'grid1',
            startArgument: 'select',
            filter: [
                { name: 'Tipo_Seleccion_Temporal_Id', value: 4 }
                , { name: 'Seleccion_Temporal_Transaccion_Id', value: Seleccion_Temporal_Transaccion_Id }
            ]
        });

        iteracionesMultipleOrdenProdPorFechaImpresionIncan = [];

    }
    // END if (iteracionesMultipleOrdenProdPorFechaImpresionIncan.length === cantOrdenProdSeleccionados) {

    fnDebug("Salimos de funcion compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan: ");
}
// END function compruebaIteracionMultipleOrdenProdPorFechaImpresionSeleccionadoIncan(indice, cantOrdenProdSeleccionados, Seleccion_Temporal_Transaccion_Id) {

// START function CrearSolicitudMaterialIncan(materialesSeleccionados, SeleccionTemporalTransaccionId) {
function CrearSolicitudMaterialIncan(materialesSeleccionados, SeleccionTemporalTransaccionId) {
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    fnDebug("function CrearSolicitudMaterialIncan");
    fnDebug(materialesSeleccionados);
    fnDebug("prime pos:" + materialesSeleccionados[0]);
    fnDebug(cantMaterialesSeleccionados);
    fnDebug("SeleccionTemporalTransaccionId " + SeleccionTemporalTransaccionId);

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, valor) {
        var n = valor.search(",");

        if (n == -1) {
            //valor.replace(",", ";")
            var valores = valor.split(";");
        } else {
            var valores = valor.split(",");
        }

        fnDebug("index: " + index);
        fnDebug("valor: " + valor);
        fnDebug(valores);

        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_OrdenDet_DeMultipleOrdenProd_Incan_V'

            , filter: [
                { field: 'Orden_Produccion_Detalle_Id', operator: '=', value: valores[1] }
                , { field: 'Seleccion_Temporal_Transaccion_Id', operator: '=', value: SeleccionTemporalTransaccionId }
            ]
            , dataType: 'json'
            , done: function (result) {
                fnDebug("result: ");
                fnDebug(result.Grid_OrdenDet_DeMultipleOrdenProd_Incan_V);

                try {

                    datos = result.Grid_OrdenDet_DeMultipleOrdenProd_Incan_V;
                    //console.log(datos);
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {
                    //Creamos solicitud
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_OrdenDet_DeMultipleOrdenProd_Incan_V'
                        //,async: false
                      , command: 'Custom'
                      , argument: 'ExecCS01'
                      , values: [
                           { name: 'Orden_Produccion_Id', newValue: datos[0].Orden_Produccion_Id }
                          , { name: 'Orden_Produccion_Detalle_Id', newValue: datos[0].Orden_Produccion_Detalle_Id }
                          , { name: 'Producto_Id', newValue: datos[0].Producto_Id }
                          , { name: 'Material_Id', newValue: datos[0].Material_Id }
                          , { name: 'Cantidad_Mat_A_Solicitar', newValue: datos[0].Cantidad_Mat_A_Solicitar }
                          , { name: 'Cantidad_Mat_Restante_Por_Solicitar', newValue: datos[0].Cantidad_Mat_Restante_Por_Solicitar }
                          , { name: 'Area_Entrega_Id', newValue: datos[0].Area_Entrega_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);

                          fnDebug("Grid_OrdenDet_DeMultipleOrdenProd_Incan_V=>ExecCS01 result : ");
                          fnDebug(result);

                          CompruebaIteracionParaCrearSolicitudMaterialIncan(index, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId);
                      }
                    });
                    // END $app.execute({
                }
            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {  
}
// END function CrearSolicitudMaterialIncan(materialesSeleccionados, SeleccionTemporalTransaccionId) {

// START function CompruebaIteracionParaCrearSolicitudMaterialIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
var iteracionesCrearSolicitudMatIncan = [];
function CompruebaIteracionParaCrearSolicitudMaterialIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
    // Agregamos al arreglo
    iteracionesCrearSolicitudMatIncan.push(indice);

    fnDebug("arr iteracionesCrearSolicitudMatIncan: ");
    fnDebug(iteracionesCrearSolicitudMatIncan);
    fnDebug("SeleccionTemporalTransaccionId: " + SeleccionTemporalTransaccionId);

    // START if (iteracionesCrearSolicitudMatIncan.length === cantMaterialesSeleccionados) {
    if (iteracionesCrearSolicitudMatIncan.length === cantMaterialesSeleccionados) {
        fnDebug("arreglos iguales!");

        // Borrar seleccion temporal
        // START $app.execute({
        $app.execute({
            controller: 'Grid_OrdenDet_DeMultipleOrdenProd_Incan_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Seleccion_Temporal_Transaccion_Id', newValue: SeleccionTemporalTransaccionId }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_OrdenDet_DeMultipleOrdenProd_Incan_V=>ExecCS02 result : ");
              fnDebug(result);
              fnDebug("Seleccion_Temporal_Transaccion_Id: " + SeleccionTemporalTransaccionId);
          }
        });
        // END $app.execute({

        iteracionesCrearSolicitudMatIncan = [];
    }
    // END if (iteracionesCrearSolicitudMatIncan.length === cantMaterialesSeleccionados) {
}
// END function CompruebaIteracionParaCrearSolicitudMaterialIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {

// START function CrearSolicitudMaterialDeMatAgrupIncan(materialesSeleccionados) {
function CrearSolicitudMaterialDeMatAgrupIncan(materialesSeleccionados) {
    cantMaterialesSeleccionados = materialesSeleccionados.length;

    fnDebug("function CrearSolicitudMaterialDeMatAgrupIncan");
    fnDebug(materialesSeleccionados);
    fnDebug("prime pos:" + materialesSeleccionados[0]);
    fnDebug(cantMaterialesSeleccionados);

    // START $.each(materialesSeleccionados, function (i, value) {
    $.each(materialesSeleccionados, function (index, valor) {

        var n = valor.search(",");

        if (n == -1) {
            //valor.replace(",", ";")
            var valores = valor.split(";");
        } else {
            var valores = valor.split(",");
        }
        //valor.replace(",", ";");
        //var valores = valor.split(",");

        fnDebug("index: " + index);
        fnDebug("valor: " + valor);
        fnDebug("valores");
        fnDebug(valores);
        fnDebug("Material_Id " + valores[0]);
        fnDebug("SeleccionTemporalTransaccionId " + valores[1]);

        // START Obtener datos del material pte por surtir
        $app.execute({
            controller: 'Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V'
            , filter: [
                { field: 'Material_Id', operator: '=', value: valores[0] }
                , { field: 'Seleccion_Temporal_Transaccion_Id', operator: '=', value: valores[1] }
            ]
            , dataType: 'json'
            , done: function (result) {
                fnDebug("result: ");
                fnDebug(result.Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V);

                try {

                    datos = result.Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V;
                    resultado = true;

                }//try
                catch (e) {

                    resultado = false;
                    if (debug === 1) {
                        console.log("result === true");
                    }

                }//catch (e)

                // START if (resultado === true) {
                if (resultado === true) {

                    
                    // Ejecutamos BR ExecCS01
                    // START $app.execute({
                    $app.execute({
                        controller: 'Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V'
                      , command: 'Custom'
                      , argument: 'ExecCS02' //Crear solicitud de material
                      , values: [
                           { name: 'Material_Agrupado_De_Multiple_Orden_Produccion_Id', newValue: datos[0].Material_Agrupado_De_Multiple_Orden_Produccion_Id }
                          , { name: 'Material_Id', newValue: datos[0].Material_Id }
                          , { name: 'Cantidad_Mat_A_Solicitar', newValue: datos[0].Cantidad_Mat_A_Solicitar }
                          , { name: 'Cantidad_Mat_Restante_Por_Solicitar', newValue: datos[0].Cantidad_Mat_Restante_Por_Solicitar }
                          , { name: 'Material_Orden_Produccion', newValue: datos[0].Material_Orden_Produccion }
                          , { name: 'Material_Orden_Produccion_Detalle', newValue: datos[0].Material_Orden_Produccion_Detalle }
                          , { name: 'Area_Entrega_Id', newValue: datos[0].Area_Entrega_Id }
                      ]
                      , done: function (result) {
                          eval(result.clientScript);
                          fnDebug("Grid_OrdenDet_AgrupDeMultipleOrdenProd_Incan_V=>ExecCS02 result : ");
                          fnDebug(result);

                          CompruebaIteracionParaCrearSolicitudMaterialDeMatAgrupIncan(index, cantMaterialesSeleccionados, valores[1]);
                      }
                    });
                    // END $app.execute({
                }

            }
        });
        // END Obtener datos del material pte por surtir
    });
    // END $.each(materialesSeleccionados, function (i, value) {  
}
// END function CrearSolicitudMaterialDeMatAgrupIncan(materialesSeleccionados) {

// START function CompruebaIteracionParaCrearSolicitudMaterialDeMatAgrupIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
var iteracionesCrearSolicitudMaterialDeMatAgrupIncan = [];
function CompruebaIteracionParaCrearSolicitudMaterialDeMatAgrupIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {
    // Agregamos al arreglo
    iteracionesCrearSolicitudMaterialDeMatAgrupIncan.push(indice);

    fnDebug("arr iteracionesCrearSolicitudMaterialDeMatAgrupIncan: ");
    fnDebug(iteracionesCrearSolicitudMaterialDeMatAgrupIncan);
    fnDebug("SeleccionTemporalTransaccionId: " + SeleccionTemporalTransaccionId);

    // START if (iteracionesCrearSolicitudMaterialDeMatAgrupIncan.length === cantMaterialesSeleccionados) {
    if (iteracionesCrearSolicitudMaterialDeMatAgrupIncan.length === cantMaterialesSeleccionados) {
        fnDebug("arreglos iguales!");

        // Borrar seleccion temporal
        // START $app.execute({
        $app.execute({
            controller: 'Grid_Orden_Detalle_De_Multiple_Orden_Prod_V'
          , command: 'Custom'
          , argument: 'ExecCS02'
          , values: [
              { name: 'Seleccion_Temporal_Transaccion_Id', newValue: SeleccionTemporalTransaccionId }
          ]
          , done: function (result) {
              eval(result.clientScript);
              fnDebug("Grid_Orden_Detalle_De_Multiple_Orden_Prod_V=>ExecCS02 result : ");
              fnDebug(result);
              fnDebug("Seleccion_Temporal_Transaccion_Id: " + SeleccionTemporalTransaccionId);
          }
        });
        // END $app.execute({

        iteracionesCrearSolicitudMaterialDeMatAgrupIncan = [];
    }
    // END if (iteracionesCrearSolicitudMaterialDeMatAgrupIncan.length === cantMaterialesSeleccionados) {
}
// END function CompruebaIteracionParaCrearSolicitudMaterialDeMatAgrupIncan(indice, cantMaterialesSeleccionados, SeleccionTemporalTransaccionId) {

/*===== END FUNCIONES DE INCANDESCENCIAS - SURTIDO DE PICKEO */



function filterOperatorRequiresValues(op) {
    return op.match(/^(=|<>|<|>|<=|>=|(\$(between|in|notin|beginswith|doesnotbeginwith|contains|doesnotcontain|endswith|doesnotendwith)))$/) != null;
}