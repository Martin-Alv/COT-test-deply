namespace eaton.Handlers
{


    public partial class BlobFactoryConfig : BlobFactory
    {

        public static void Initialize()
        {
            // register blob handlers
            RegisterHandler("Documento_ComentarioPicture", "\"APP\".\"Documento_Comentario\"", "\"Picture\"", new string[] {
                        "\"Documento_Comentario_Id\""}, "Documento Comentario Archivo", "Documento_Comentario", "Picture");
            RegisterHandler("PictureBlobHandler", "\"APP\".\"Documento_Material\"", "\"Picture\"", new string[] {
                        "\"Documento_Material_Id\""}, "Documento Material Documento", "Documento_Material", "Picture");
            RegisterHandler("Evidencia_EscaneoPictureBlobHandler", "\"APP\".\"Evidencia_Escaneo_Validador_Embarque\"", "\"Picture\"", new string[] {
                        "\"Evidencia_Escaneo_Validador_Embarque_Id\""}, "Evidencia Escaneo Validador Embarque Picture", "Evidencia_Escaneo_Validador_Embarque", "Picture");
        }
    }
}
