using System;

namespace MisClases
{
    
    public class clsPersona
    {
        #region atributos privados
        private string nombre;
        #endregion
        #region propiedades publicas
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        #endregion
        #region constructores
        //constructor por defecto
        public clsPersona()
        {

        }
        //constructor por parámetros
        public clsPersona(string nombre)
        {
            Nombre = nombre;
        }
        #endregion
    }
}
