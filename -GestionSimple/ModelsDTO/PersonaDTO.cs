using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionSimple.ModelsDTO {
    public class PersonaDTO {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public string Mail { get; set; }

        public bool Activo { get; set; }
    }
}
