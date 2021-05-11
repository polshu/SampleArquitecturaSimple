using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Helpers;
using GestionSimple.Models;
using GestionSimple.ModelsDTO;
using GestionSimple.Services;
using GestionSimple.Mappers;

namespace GestionSimple.Controllers {
    public class PersonasController : ApiController {

        [HttpGet]
        [Route("api/v1/personas/{id}")]
        public IHttpActionResult GetById(int id) {
            IHttpActionResult   respuesta;
            Persona             oPersona;
        
            oPersona = PersonasService.GetById(id);
            if (oPersona != null) {
                respuesta = Ok(oPersona);
            } else {
                respuesta = NotFound();
            }

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/personas")]
        public IHttpActionResult GetAll() {
            IHttpActionResult   respuesta;
            List<Persona>       personasList;
            List<PersonaDTO>    personasDTOList;

            personasList    = PersonasService.GetAll();
            personasDTOList = PersonasMapper.ToDTOList(personasList);
            respuesta       = Ok(personasDTOList);

            return respuesta;
        }


        [HttpGet]
        [Route("api/v1/personas/activos")]
        public IHttpActionResult GetActivos() {
            IHttpActionResult respuesta;
            List<Persona> personasList;

            personasList = PersonasService.GetActivos();
            respuesta = Ok(personasList);

            return respuesta;
        }

        [HttpGet]
        [Route("api/v1/personas/inactivos")]
        public IHttpActionResult GetInActivos() {
            IHttpActionResult respuesta;
            List<Persona> personasList;

            personasList = PersonasService.GetInActivos();
            respuesta = Ok(personasList);

            return respuesta;
        }


        [HttpPost]
        [Route("api/v1/personas")]
        public IHttpActionResult Insert(Persona requestDTO) {
            IHttpActionResult   respuesta;
            ResponseDTO         responseDTO = new ResponseDTO();

            int     intNewId;
            string  strErrores = "";

            //intNewId = PersonasService.Insert(newPersona);
            //intNewId = PersonasService.InsertScalar(newPersona);
            intNewId = PersonasService.InsertValid(requestDTO, out strErrores);

            if (intNewId > 0) {
                responseDTO.NewId = intNewId;
                respuesta = Ok(responseDTO);
            } else {
                responseDTO.NewId   = 0;
                responseDTO.Errores = strErrores;
                respuesta = Ok(responseDTO);
            }
            return respuesta;
        }


        
    }
}