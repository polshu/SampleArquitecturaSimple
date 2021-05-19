using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestionSimple.Models;
using GestionSimple.Helpers;

namespace GestionSimple.Utils {
    public class CustomLog {
        /// <summary>
        ///     Obtengo el nombre del Archivos de LOGS (desde un archivo de configuracion!)
        /// </summary>
        /// <returns></returns>
        public static string GetLogFile() {
            string strReturnValue;
            strReturnValue = AppSettingsHelper.GetAppSetting("LogFile", "");
            return strReturnValue;
        }

        #region LogException
        public static bool LogException(Exception ex) {
            bool    blnReturnValue      = false;
            string  strInnerException   = "";

            if (ex.StackTrace != null) {
                strInnerException = Environment.NewLine + ex.StackTrace;
            }

            blnReturnValue = LogLine(ex.Message + strInnerException);

            return blnReturnValue;
        }

        public static bool LogLine(string strData) {
            bool    blnReturnValue = false;
            string  strPathFile;
            string  strTextToLog;

            strPathFile = CustomLog.GetLogFile();

            if (!string.IsNullOrEmpty(strPathFile)) {
                strTextToLog = string.Format("{0} {1}{2}",
                    DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff"),
                    strData,
                    Environment.NewLine);

                blnReturnValue = IOHelper.AppendToFile(strPathFile, strTextToLog);
            }
            return blnReturnValue;
        }
        #endregion
    }
}
