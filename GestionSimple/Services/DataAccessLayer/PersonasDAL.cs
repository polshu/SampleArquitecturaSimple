using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionSimple.Models;
using GestionSimple.Helpers;

namespace GestionSimple.Services {
    internal class PersonasDAL {

        public Persona GetById(int intId) {
            Persona         returnEntity = null;
            SqlParameter[]  parameterArray = new SqlParameter[1];
            SqlDataReader   currentReader = null;

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

        public List<Persona> GetByActivo(bool blnActivo) {
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

        public int Insert(Persona newEntity) {
            List<Persona>   returnList = new List<Persona>();
            SqlParameter[]  parameterArray = new SqlParameter[3];
            int             intNewId = 0;

            parameterArray[0] = new SqlParameter("@strNombre"   , newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail"    , newEntity.Email);
            parameterArray[2] = new SqlParameter("@blnActivo"   , newEntity.Activo);

            try {
                intNewId = DatabaseHelper.ExecuteNonQuery("Personas_Insert", parameterArray);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public int InsertScalar(Persona newEntity) {
            List<Persona>   returnList = new List<Persona>();
            SqlParameter[]  parameterArray = new SqlParameter[3];
            int             intNewId = 0;
            object          currentObject;

            parameterArray[0] = new SqlParameter("@strNombre", newEntity.Nombre);
            parameterArray[1] = new SqlParameter("@strEmail", newEntity.Email);
            parameterArray[2] = new SqlParameter("@blnActivo", newEntity.Activo);

            try {
                currentObject = DatabaseHelper.ExecuteScalar("Personas_InsertScalar", parameterArray);
                intNewId = Convert.ToInt32(currentObject);
            } catch (Exception ex) {
                CustomLog.LogException(ex);
            }

            return intNewId;
        }

        public List<Persona> GetAll() {
            List<Persona>   returnList = new List<Persona>();
            Persona         currentEntity;
            SqlDataReader   currentReader = null;

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

        private Persona DataReaderToObject(SqlDataReader currentReader) {
            Persona returnEntity = null;

            if (currentReader != null) {
                returnEntity = new Persona();
                returnEntity.Id     = (currentReader["Id"] != DBNull.Value ? (int)currentReader["Id"] : 0);
                returnEntity.Nombre = (currentReader["Nombre"] != DBNull.Value ? (string)currentReader["Nombre"] : "");
                returnEntity.Email  = (currentReader["Email"] != DBNull.Value ? (string)currentReader["Email"] : "");
                returnEntity.Activo = (currentReader["Activo"] != DBNull.Value ? (bool)currentReader["Activo"] : false);
            }

            return returnEntity;
        }
    }
}
