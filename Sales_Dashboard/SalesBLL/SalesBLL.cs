using System;
using System.Collections.Generic;
using Utilidades;
using SalesDAL;


namespace SalesBLL
{
    public class SalesBLLMVC
    {
        public static List<Persona> LeerEmpleados()
        {
            return SalesDALMVC.LeerEmpleados();     
        }

        public static List<DetalleFacturacion> LeerFacturacion()
        {
            return SalesDALMVC.LeerFacturacion();
        }

        public int[] FacturacionPorEmpresa(int numComercial, int numEmpresa)
        {
            List<DetalleFacturacion> listaDetalles = LeerFacturacion();
            int[] facturacion= new int[12];

            for (int i=0; i<listaDetalles.Count; i++)
            {
                DetalleFacturacion unDetalle = listaDetalles[i];
                if (unDetalle.NumComercial == numComercial)
                {
                    if (unDetalle.NumEmpresa ==numEmpresa)
                    {
                        return facturacion= unDetalle.Arrayfacturacion;
                    }
                }
            }
            return facturacion;
        }

        public int[] FacturacionTotalAnual(int numComercial)
        {
            int[] total = new int[2];
            int[] totalEmpresa1 = FacturacionPorEmpresa(numComercial, 1);
            int[] totalEmpresa2 = FacturacionPorEmpresa(numComercial, 2);

            for (int i=0; i < 12; i++)
            {
                total[0] = total[0] + totalEmpresa1[i];
                total[1] = total[1] + totalEmpresa2[i];
            }

            return total;
        }

        public string DatosMostrarComercial(Persona unaPersona)
        {
            string texto = "Nombre y apellidos: " + unaPersona.NombreCompleto + "\r\n";
            texto = texto + "Ciudad: " + unaPersona.Ciudad + "\r\n";
            texto = texto + "Edad: " + unaPersona.Edad + "\r\n";
            return texto;
            
        }
    }
}
