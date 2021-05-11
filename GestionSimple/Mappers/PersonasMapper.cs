using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GestionSimple.Models;
using GestionSimple.ModelsDTO;

namespace GestionSimple.Mappers {
    public class PersonasMapper {
        public static PersonaDTO ToDTO(Persona source) {
            PersonaDTO returnEntity = null;

            if (source != null) {
                returnEntity = new PersonaDTO();
                returnEntity.Id             = source.Id;
                returnEntity.NombreCompleto = source.Nombre;
                returnEntity.Mail           = source.Email;
                returnEntity.Activo         = source.Activo;
            }

            return returnEntity;
        }

        public static Persona FromDTO(PersonaDTO source) {
            Persona returnEntity = null;

            if (source != null) {
                returnEntity = new Persona();
                returnEntity.Id     = source.Id;
                returnEntity.Nombre = source.NombreCompleto;
                returnEntity.Email  = source.Mail;
                returnEntity.Activo = source.Activo;
            }

            return returnEntity;
        }

        public static List<PersonaDTO> ToDTOList(List<Persona> sourceList) {
            List<PersonaDTO> returnList = null;
            PersonaDTO      tempEntity;

            if (sourceList != null) {
                returnList = new List<PersonaDTO>();
                foreach (Persona currentItem in sourceList) {
                    tempEntity = ToDTO(currentItem);
                    returnList.Add(tempEntity);
                }
            }

            return returnList;
        }

        public static List<Persona> FromDTOList(List<PersonaDTO> sourceList) {
            List<Persona> returnList = null;
            Persona tempEntity;

            if (sourceList != null) {
                returnList = new List<Persona>();
                foreach (PersonaDTO currentItem in sourceList) {
                    tempEntity = FromDTO(currentItem);
                    returnList.Add(tempEntity);
                }
            }

            return returnList;
        }
    }
}
