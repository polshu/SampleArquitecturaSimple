using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSimple.Models {
    public class Persona {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public int? IdProvincia { get; set; }

        public bool Activo { get; set; }

        public override string ToString() {
            string strReturnValue = "";
            strReturnValue = string.Format("Id:{0}, Nombre:'{1}', Email:'{2}', IdProvincia:'{3}', Activo:{4}",
                    Id,
                    Nombre,
                    Email,
                    ((IdProvincia != null) ? IdProvincia.ToString() : "NULL"),
                    (Activo ? "True" : "False")
                );
            return strReturnValue;
        }



        /*
         *  Propiedades extendidas (JOINS)
         * 
         */

        public string Provincia { get; set; }

        public string ToStringExtended() {
            string strReturnValue = "";
            strReturnValue = string.Format(" EXTENDED Provincia:{0}",
                    Provincia
                );
            return strReturnValue;
        }
    }
}
