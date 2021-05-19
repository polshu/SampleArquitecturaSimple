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

            personasList    = PersonasService.GetAll();
            respuesta       = Ok(personasList);

            return respuesta;
        }


        [HttpGet]
        [Route("api/v1/personasextended")]
        public IHttpActionResult GetAllExtended() {
            IHttpActionResult   respuesta;
            List<Persona>       personasList;

            personasList    = PersonasService.GetAll(true);
            respuesta       = Ok(personasList);

            return respuesta;
        }

        /*
        [HttpGet]
        [Route("api/v1/personasdto")]
        public IHttpActionResult GetAllDTO() {
            IHttpActionResult respuesta;
            List<Persona> personasList;
            List<PersonaDTO>    personasDTOList;

            personasList = PersonasService.GetAll();
            personasDTOList = PersonasMapper.ToDTOList(personasList);
            respuesta       = Ok(personasDTOList);

            return respuesta;
        }
        */

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
        public IHttpActionResult Insert(Persona nuevaPersona) {
            IHttpActionResult respuesta;

            //respuesta = Insert_ReturnRegsAffected(nuevaPersona);
            //respuesta = Insert_ReturnNewId(nuevaPersona);
            //respuesta = Insert_Validando(nuevaPersona);
            respuesta = Insert_Validando_ReturnDTO(nuevaPersona);


            return respuesta;
        }

        public IHttpActionResult Insert_ReturnRegsAffected(Persona nuevaPersona) {
            IHttpActionResult   respuesta;
            int                 intRegsAffected;

            intRegsAffected = PersonasService.Insert(nuevaPersona);
            respuesta       = Ok(intRegsAffected); 

            return respuesta;
        }

        public IHttpActionResult Insert_ReturnNewId(Persona nuevaPersona) {
            IHttpActionResult   respuesta;
            int                 intNewId;

            intNewId        = PersonasService.InsertScalar(nuevaPersona);
            respuesta       = Ok(intNewId);

            return respuesta;
        }


        public IHttpActionResult Insert_Validando(Persona nuevaPersona) {
            IHttpActionResult   respuesta;
            int                 intNewId;
            string              strErrores = "";

            intNewId = PersonasService.InsertValid(nuevaPersona, out strErrores);
            if (intNewId > 0) {
                respuesta = Ok(intNewId);
            } else {
                respuesta = BadRequest(strErrores);
            }

            return respuesta;
        }

        public IHttpActionResult Insert_Validando_ReturnDTO(Persona nuevaPersona) {
            IHttpActionResult   respuesta;
            int                 intNewId;
            string              strErrores = "";
            ResponseDTO         responseDTO = new ResponseDTO();

            intNewId = PersonasService.InsertValid(nuevaPersona, out strErrores);

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