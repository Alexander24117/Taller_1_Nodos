using System;

namespace Taller_1_Nodos.Capa_Lógica
{
    internal class Huesped
    {
        private Huesped anterior;
        private String apellido;
        private DateTime fechaNacimiento;
        private String nombre;
        private int numeroDocumento;
        private Huesped siguiente;
        private String tipoDocumento;
        public Huesped(string nombre, string apellido, string tipoDocumento, int numeroDocumento, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.siguiente = null;
            this.anterior = null;
        }

        public Huesped(string nombre, string apellido, string tipoDocumento, int numeroDocumento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipoDocumento = tipoDocumento;
            this.numeroDocumento = numeroDocumento;
            this.anterior = null;
            this.siguiente = null;
        }

        public Huesped GetAnterior()
        {
            return anterior;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public DateTime GetFechaNacimiento()
        {
            return fechaNacimiento;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetNumeroDocumento()
        {
            return numeroDocumento;
        }

        public Huesped GetSiguiente()
        {
            return siguiente;
        }

        public string GetTipoDocumento()
        {
            return tipoDocumento;
        }

        public void SetAnterior(Huesped pAnterior)
        {
            anterior = pAnterior;
        }

        public void SetApellido(string pApellido)
        {
            apellido = pApellido;
        }

        public void SetFechaNacimiento(DateTime pFechaNacimiento)
        {
            fechaNacimiento = pFechaNacimiento;
        }

        public void SetNombre(string pNombre)
        {
            nombre = pNombre;
        }
        public void SetNumeroDocumento(int value)
        {
            numeroDocumento = value;
        }

        public void SetSiguiente(Huesped pSiguiente)
        {
            siguiente = pSiguiente;
        }

        public void SetTipoDOcumento(string pTipoDocumento)
        {
            tipoDocumento = pTipoDocumento;
        }
    }
}