using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidades
{
    public class DetalleFacturacion
    {
        private int numComercial;
        private int numEmpresa;
        private int[] arrayfacturacion;

        public DetalleFacturacion(int numComercial, int numEmpresa, int[] arrayfacturacion)
        {
            this.numComercial = numComercial;
            this.numEmpresa = numEmpresa;
            this.arrayfacturacion = arrayfacturacion;
        }

        public int NumComercial { get => numComercial; set => numComercial = value; }
        public int NumEmpresa { get => numEmpresa; set => numEmpresa = value; }
        public int[] Arrayfacturacion { get => arrayfacturacion; set => arrayfacturacion = value; }
    }
}
