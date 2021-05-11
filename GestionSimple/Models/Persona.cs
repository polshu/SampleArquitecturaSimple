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

        public bool Activo { get; set; }

        public override string ToString() {
            string strReturnValue = "";
            strReturnValue = string.Format("Id:{0}, Nombre:'{1}', Email:'{2}', Activo:{3}",
                Id,
                Nombre,
                Email,
                (Activo ? "True" : "False")
                );
            return strReturnValue;
        }
    }
}
