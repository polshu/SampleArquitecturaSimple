using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using GestionSimple.Models;

namespace GestionSimple.ModelsDTO {
    public class ResponseDTO {
        public ResponseDTO() {
            NewId           = 0;
            Errores         = "";
        }

        public int NewId { get; set; }

        public string Errores { get; set; }
    }
}