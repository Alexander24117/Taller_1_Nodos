using System;
using Taller_1_Nodos.Capa_Lógica;

namespace Taller_1_Nodos.Capa_Estructural
{
    internal class ServicioLista
    {
        private static Huesped cabecera;

        public ServicioLista()
        {
            cabecera = null;
        }

        public static void AdicionarNodoFinalLista(Huesped pHuesped)
        {
            if (cabecera == null)
            {
                //pEst.setSgte(null);
                cabecera = pHuesped;
            }
            else
            {
                Huesped temp = cabecera;
                

                while (temp.GetSiguiente() != null)
                {

                    temp = temp.GetSiguiente();
                }

                //<1><1
                temp.SetSiguiente(pHuesped);
                pHuesped.SetAnterior(temp);
            }
        }

        public static void AdicionarNodoInicioLista(Huesped pHuespedes)
        {
            if (cabecera != null)
            {   //1><1
                cabecera.SetAnterior(pHuespedes);
                pHuespedes.SetSiguiente(cabecera);
                cabecera = pHuespedes;
            }
            //1><1>
            else {
                
                cabecera = pHuespedes;
            }
            
        }

        public static void AdicionarNodoPosicionLista(Huesped pHuesped, int pos)
        {
            Huesped tem = cabecera;
            int cont = 0;
            pos--;

            if (cabecera == null)
            {
                throw new Exception("El valor de pos = " + (pos + 1) + ", es mayor que el tamaño de la lista " + Environment.NewLine + "El estudiante no puede ser agregado" + Environment.NewLine + "Revise la lista y la posición que quiere agregar e intente de nuevo");
            }

            if (pos == 0)
            {
                pHuesped.SetSiguiente(cabecera);
                cabecera = pHuesped;
                return;
            }

            while (tem != null)
            {
                if (cont == pos)
                {
                    break;
                }

                tem = tem.GetSiguiente();
                cont++;
            }

            if (cont < pos || tem == null)
            {
                throw new Exception("El valor de pos = " + (pos + 1) + ", es mayor al tamaño de la lista! " + Environment.NewLine + "Estudiante NO adicionado!");
            }

            // pHuespedes.SetSiguiente(tem.GetSiguiente());

            // tem.SetSiguiente(pHuespedes);
            //<1><1><1><1>
            tem.GetAnterior().SetSiguiente(pHuesped);
            pHuesped.SetAnterior(tem.GetAnterior());
            pHuesped.SetSiguiente(tem);
            tem.SetAnterior(pHuesped);
        }

        public static void EliminarInicio()
        {
            // 1><1><1>
            if (cabecera.GetSiguiente() == null)
            {
                cabecera = null;
            }else
            {
                cabecera.GetSiguiente().SetAnterior(null);
                cabecera = cabecera.GetSiguiente();
            }

            
        }
        public static void EliminarFinal()
        {
            Huesped temp = cabecera;
            // 1><1><1>
            if (cabecera.GetSiguiente() == null)
            {
                cabecera = null;
            }
            else
            {
                while (temp.GetSiguiente() != null)
                {
                    

                    temp = temp.GetSiguiente();
                    
                }
                temp.GetAnterior().SetSiguiente(null);
                temp.SetAnterior(null);
            }

        }

        public static void EliminarPocision(int pos)
        {
            pos--;
            Huesped tem = cabecera;
            int cont = 0;
            if (pos == 0 && tem.GetSiguiente() == null)
            {
                EliminarInicio();
            }
            else
            {
                while (tem != null)
                {
                    if (cont == pos)
                    {
                        break;
                    }

                    tem = tem.GetSiguiente();
                    cont++;
                }
                if (tem.GetSiguiente() != null && tem.GetAnterior() != null)
                {
                    tem.GetSiguiente().SetAnterior(tem.GetAnterior());
                    tem.GetAnterior().SetSiguiente(tem.GetSiguiente());
                }else if (tem.GetSiguiente() == null)
                {
                    EliminarFinal();
                }else if (tem.GetAnterior() == null)
                {
                    EliminarInicio();
                }
            }
            
        }
        
        public static Huesped GetCabecera()
        {
            return cabecera;
        }

        public static void SetHuesped(Huesped pCabecera)
        {
            cabecera = pCabecera;
        }
    }
}