using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionSimple.Models;

namespace GestionSimple.Services {
    public class PersonasService {
        private static PersonasDAL GetDAL() {
            return new PersonasDAL();
        }
        
        public static Persona GetById(int intId) {
            Persona     returnEntity;
            PersonasDAL currentDAL = GetDAL();

            returnEntity = currentDAL.GetById(intId);

            return returnEntity;
        }

        public static List<Persona> GetAll() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetAll();

            return returnList;
        }

        public static List<Persona> GetActivos() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(true);

            return returnList;
        }

        public static List<Persona> GetInActivos() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(false);

            return returnList;
        }

        public static int Insert(Persona newEntity) {
            int         intNewId;
            PersonasDAL currentDAL = GetDAL();

            intNewId = currentDAL.Insert(newEntity);
            return intNewId;
        }

        public static int InsertScalar(Persona newEntity) {
            int         intNewId;
            PersonasDAL currentDAL = GetDAL();

            intNewId = currentDAL.InsertScalar(newEntity);
            return intNewId;
        }

        public static int InsertValid(Persona newEntity, out string strErrores) {
            int         intNewId = 0;
            PersonasDAL currentDAL = GetDAL();

            if (IsValid(newEntity, out strErrores)) {
                intNewId = currentDAL.InsertScalar(newEntity);
            }

            return intNewId;
        }

        public static bool IsValid(Persona testEntity, out string strErrores) {
            bool blnReturnValue = true;
            strErrores = "";

            if (testEntity != null) {
                // Valido el nombre.
                if (testEntity.Nombre.Trim().Length == 0) {
                    strErrores += "El nombre es invalido.";
                    blnReturnValue = false;
                }

                // Valido el email, si lo puso quye haya puesto un arroba.
                if ((testEntity.Email.Trim().Length > 0) && (!testEntity.Email.Contains("@"))) {
                    strErrores += "Falta el arroba en el email.";
                    blnReturnValue = false;
                }
            } else {
                strErrores += "El objeto es NULL!!";
                blnReturnValue = false;
            }
            return blnReturnValue;
        }
    }
}
