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
        public clsPersona(string nombre)
        {
            Nombre = nombre;
        }
    }
}
