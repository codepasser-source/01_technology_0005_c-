using System;
using System.IO;

namespace WFCore.util
{
    /// <summary>
    /// Read data from properties file.
    /// </summary>
    public class PropertyFileOperator
    {
        private StreamReader sr = null;
        private string filePath;

        /// <summary>
        /// set the properties file path.
        /// </summary>
        /// <param name="strFilePath">properties file path</param>
        public PropertyFileOperator(string strFilePath)
        {
            filePath = strFilePath;
        }

        /// <summary>
        /// Read data from properties file.
        /// </summary>
        /// <param name="strKey">keyWord</param>
        /// <returns>return propertyText</returns>
        public string GetPropertiesText(string strKey)
        {
            string strResult = string.Empty;
            string str = string.Empty;
            try
            {
                sr = new StreamReader(filePath, System.Text.Encoding.Default);
                sr.BaseStream.Seek(0, SeekOrigin.End);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while ((str = sr.ReadLine()) != null)
                {
                    if (str.Substring(0, str.IndexOf('=')).Equals(strKey))
                    {
                        strResult = str.Substring(str.IndexOf('=') + 1);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                //ignor
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                    sr = null;
                }
            }
            return strResult;
        }
    }
}
