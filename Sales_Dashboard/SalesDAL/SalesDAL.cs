using System;
using System.Collections.Generic;
using System.IO;
using Utilidades;

namespace SalesDAL
{
    public class SalesDALMVC
    {
        public static  List<Persona> LeerEmpleados()
        {
            var reader = new StreamReader(File.OpenRead(@".\..\..\..\BD\1_datos_comerciales.csv"));
            List<Persona> list = new List<Persona>();

            var line = reader.ReadLine(); //Cabecera

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split(',');
                int numComercial= int.Parse(values[0]);
                string nombre = values[1];
                string apellido = values[2];
                string ciudad = values[3];
                int edad = int.Parse(values[4]);
                Persona unaPersona = new Persona(nombre, apellido, ciudad, edad, numComercial);
                list.Add(unaPersona);
            }
            return list;

        }

        public static List<DetalleFacturacion> LeerFacturacion()
        {
            var reader = new StreamReader(File.OpenRead(@".\..\..\..\BD\2_facturacion_comercial.csv"));
            List<DetalleFacturacion> list = new List<DetalleFacturacion>();

            var line = reader.ReadLine(); //Cabecera

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                var values = line.Split(',');
                int numComercial = int.Parse(values[0]);
                int numEmpresa = int.Parse(values[1]);
                int[] listaFacturacion = new int[12];

                for (int i=2; i < 14; i++)
                {
                    listaFacturacion[i-2]= int.Parse(values[i]);
                }

                DetalleFacturacion unDetalleFacturacion = new DetalleFacturacion(numComercial, numEmpresa, listaFacturacion);
                list.Add(unDetalleFacturacion);
            }
            return list;

        }

    }
}
