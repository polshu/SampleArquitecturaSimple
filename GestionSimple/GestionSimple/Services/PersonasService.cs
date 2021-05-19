using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionSimple.Models;
using GestionSimple.Helpers;
using GestionSimple.Utils;

namespace GestionSimple.Services {
    public class PersonasService {
        public static Persona GetById(int intId) {
            Persona         returnEntity    = null;
            SqlParameter[]  parameterArray  = new SqlParameter[1];
            SqlDataReader   currentReader   = null;

            parameterArray[0] = new SqlParameter("@intId", intId);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Personas_GetById", parameterArray);
                if (currentReader != null) {
                    if (currentReader.HasRows) {
                        currentReader.Read();
                        returnEntity = DataReaderToObject(currentReader);
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnEntity;
        }

        public static List<Persona> GetAll() {
            List<Persona>   returnList      = new List<Persona>();
            Persona         currentEntity;
            SqlDataReader   currentReader   = null;

            try {
                currentReader = DatabaseHelper.ExecuteReader("Personas_GetAll", null);
                if (currentReader.HasRows) {
                    while (currentReader.Read()) {
                        currentEntity = DataReaderToObject(currentReader);
                        returnList.Add(currentEntity);
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnList;
        }

        public static List<Persona> GetAll(bool blnExtended) {
            List<Persona>   returnList      = new List<Persona>();
            Persona         currentEntity;
            SqlDataReader   currentReader   = null;

            try {
                currentReader = DatabaseHelper.ExecuteReader("Personas_GetAll" + (blnExtended ? "_Extended" : ""), null);
                if (currentReader.HasRows) {
                    while (currentReader.Read()) {
                        currentEntity = DataReaderToObject(currentReader, blnExtended);
                        returnList.Add(currentEntity);
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnList;
        }

        public static List<Persona> GetActivos() {
            return GetByActivo(true);
        }

        public static List<Persona> GetInActivos() {
            return GetByActivo(false);
        }

        private static List<Persona> GetByActivo(bool blnActivo) {
            List<Persona>   returnList = new List<Persona>();
            Persona         currentEntity;
            SqlParameter[]  parameterArray = new SqlParameter[1];
            SqlDataReader   currentReader = null;


            parameterArray[0] = new SqlParameter("@blnActivo", blnActivo);

            try {
                currentReader = DatabaseHelper.ExecuteReader("Personas_GetByActivo", parameterArray);
                if (currentReader != null) {
                    if (currentReader.HasRows) {
                        while (currentReader.Read()) {
                            currentEntity = DataReaderToObject(currentReader);
                            returnList.Add(currentEntity);
                        }
                    }
                }
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            DatabaseHelper.CloseAndDisposeReader(ref currentReader);

            return returnList;
        }

        public static int Insert(Persona newEntity) {
            List<Persona>   returnList = new List<Persona>();
            SqlParameter[]  parameterArray = new SqlParameter[4];
            int             intRecordsAffected = 0;

            parameterArray[0] = new SqlParameter("@strNombre"       , newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail"        , newEntity.Email);
            parameterArray[2] = new SqlParameter("@intIdProvincia"  , newEntity.IdProvincia);
            parameterArray[3] = new SqlParameter("@blnActivo"       , newEntity.Activo);

            try {
                intRecordsAffected = DatabaseHelper.ExecuteNonQuery("Personas_Insert", parameterArray);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intRecordsAffected;
        }

        public static int InsertScalar(Persona newEntity) {
            List<Persona>   returnList = new List<Persona>();
            SqlParameter[]  parameterArray = new SqlParameter[4];
            int             intNewId = 0;
            object          currentObject;

            parameterArray[0] = new SqlParameter("@strNombre"       , newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail"        , newEntity.Email);
            parameterArray[2] = new SqlParameter("@intIdProvincia"  , newEntity.IdProvincia);
            parameterArray[3] = new SqlParameter("@blnActivo"       , newEntity.Activo);

            try {
                currentObject = DatabaseHelper.ExecuteScalar("Personas_InsertScalar", parameterArray);
                intNewId = Convert.ToInt32(currentObject);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public static int InsertValid(Persona newEntity, out string strErrores) {
            int         intNewId = 0;

            if (IsValid(newEntity, out strErrores)) {
                intNewId = InsertScalar(newEntity);
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

        #region Metodos Utiles de la Clase
        private static Persona DataReaderToObject(SqlDataReader currentReader) {
            Persona returnEntity = null;

            if (currentReader != null) {
                returnEntity = new Persona();
                returnEntity.Id             = ((currentReader["Id"] != DBNull.Value)            ? (int)currentReader["Id"] : 0);
                returnEntity.Nombre         = ((currentReader["Nombre"] != DBNull.Value)        ? (string)currentReader["Nombre"] : "");
                returnEntity.Email          = ((currentReader["Email"] != DBNull.Value)         ? (string)currentReader["Email"] : "");
                returnEntity.IdProvincia    = ((currentReader["IdProvincia"] != DBNull.Value)   ? (int)currentReader["IdProvincia"] : 0);
                returnEntity.Activo         = ((currentReader["Activo"] != DBNull.Value)        ? (bool)currentReader["Activo"] : false);
            }

            return returnEntity;
        }
        #endregion

        #region Metodos Utiles de la Clase (Extended)
        private static Persona DataReaderToObject(SqlDataReader currentReader, bool blnExtended) {
            Persona returnEntity = null;

            if (currentReader != null) {
                returnEntity = new Persona();
                returnEntity.Id             = ((currentReader["Id"] != DBNull.Value)            ? (int)currentReader["Id"] : 0);
                returnEntity.Nombre         = ((currentReader["Nombre"] != DBNull.Value)        ? (string)currentReader["Nombre"] : "");
                returnEntity.Email          = ((currentReader["Email"] != DBNull.Value)         ? (string)currentReader["Email"] : "");
                returnEntity.IdProvincia    = ((currentReader["IdProvincia"] != DBNull.Value)   ? (int)currentReader["IdProvincia"] : 0);
                returnEntity.Activo         = ((currentReader["Activo"] != DBNull.Value)        ? (bool)currentReader["Activo"] : false);

                /*
                returnEntity.Id             = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "Id"          , 0);
                returnEntity.Nombre         = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "Nombre"      , "");
                returnEntity.Email          = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "Email"       , "");
                returnEntity.IdProvincia    = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "IdProvincia" , 0);
                returnEntity.Activo         = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "Activo"      , false);
                */

                if (blnExtended) {
                    returnEntity = DataReaderToObjectExtended(currentReader, returnEntity);
                }
            }

            return returnEntity;
        }

        private static Persona DataReaderToObjectExtended(SqlDataReader currentReader, Persona returnEntity) {
            if ((currentReader != null) && (returnEntity!=null)){
                returnEntity.Provincia = ((currentReader["Provincias_Nombre"] != DBNull.Value)   ? (string)currentReader["Provincias_Nombre"] : "");
                //returnEntity.Provincia = DatabaseHelper.GetValueOrDefaultIfNull(currentReader, "Provincias_Nombre", false);
            }
            return returnEntity;
        }
        #endregion
    }
}
