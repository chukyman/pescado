using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LN.Clases;
using LN.Persistente;


namespace LN.Gestores
{
    public class GestorCurso
    {
        public static void registrarCurso(String pcodigo, String pnombre, 
                                           int pidCarrera, Boolean pestado)
        {

            Curso objCurso;
            objCurso = new Curso(pcodigo, pnombre,  pidCarrera, pestado);
            CursoPersistente objCursoPersistente = new CursoPersistente();
            objCursoPersistente.insertar(objCurso);


        }

        public static void modificarCurso(String pcodigo, String pnombre, 
                                     int pidCarrera, Boolean pestado)
        {

            Curso objCurso;
            objCurso = new Curso(pcodigo, pnombre,pidCarrera,pestado);
            CursoPersistente objCursoPersistente = new CursoPersistente();
            objCursoPersistente.modificar(objCurso);

        }

        public static void eliminarCurso(String pcodigo)
        {

            CursoPersistente objCursoPersistente= new CursoPersistente();
            objCursoPersistente.eliminar(pcodigo);

        }

       




    }
}
