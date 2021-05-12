using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using GestionSimple.Helpers;
using GestionSimple.Models;
using GestionSimple.ModelsDTO;
using GestionSimple.Services;
using GestionSimple.Mappers;

namespace GestionSimple.Controllers {
    public class UtilsController : ApiController {

        [HttpGet]
        [Route("api/v1/utils/version")]
        public IHttpActionResult GetVersion() {
            IHttpActionResult   respuesta;
            string              strVersion;

            strVersion  = "1.0.1";
            respuesta   = Ok(strVersion);

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/utils/fecha")]
        public IHttpActionResult GetFecha() {
            IHttpActionResult respuesta;
            DateTime dtmFechaActual;

            dtmFechaActual = DateTime.Now;
            respuesta = Ok(dtmFechaActual);

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/utils/saludo")]
        public IHttpActionResult GetSaludo(string nombre) {
            IHttpActionResult respuesta;
            string strTexto;

            strTexto = "Hola Queridisimo: " + nombre;
            respuesta = Ok(strTexto);

            return respuesta;
        }


        [HttpGet]
        [Route("api/v1/utils/dividir")]
        public IHttpActionResult GetDividir(int dividendo, int divisor) {
            IHttpActionResult respuesta;
            int intCociente;
            // 125 / 5 = 25 y resto 0
            // 125  es el dividendo
            // 5    es el divisor
            // 25   es el cociente (resultado)
            // 0    es el resto

            intCociente = dividendo / divisor;
            respuesta = Ok(intCociente);

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/utils/dividirconchequeo")]
        public IHttpActionResult GetDividirConChequeoDeErrores(int dividendo, int divisor) {
            IHttpActionResult respuesta;
            int intCociente;

            //if (divisor == 0) {
            //    BadRequest("El divisor no puede ser cero");
            //}
            
            try {
                intCociente = dividendo / divisor;
                respuesta = Ok(intCociente);
            }catch(Exception ex) {
                respuesta = BadRequest("Error");
            }

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/utils/dividircompleto")]
        public IHttpActionResult GetDividirCompleto(int dividendo, int divisor) {
            IHttpActionResult respuesta = null;
            int     intCociente;
            bool    blnDatosValidos = true;

            if (divisor > dividendo) {
                respuesta = BadRequest("El divisor no puede mayor que el dividendo");
                blnDatosValidos = false;
            }

            if (divisor == 0) {
                respuesta = BadRequest("El divisor no puede ser 0");
                blnDatosValidos = false;
            }


            // Si la validacion fue exitosa!
            if (blnDatosValidos) {
                try {
                    intCociente = dividendo / divisor;
                    respuesta = Ok(intCociente);
                } catch (Exception ex) {
                    respuesta = InternalServerError();
                }
            }


            return respuesta;
        }



    }
}