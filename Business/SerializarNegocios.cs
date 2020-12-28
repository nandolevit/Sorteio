using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Object;
using DB;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Business
{
    public class SerializarNegocios
    {
        private string Caminho { get; set; }

        public SerializarNegocios(string path)
        {
            Caminho = path;
        }

        public bool ArquivoExiste(string fileName)
        {
            try
            {
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public bool ExcluirArquivo(string fileName)
        {
            try
            {
                if (File.Exists(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                {
                    File.Delete(Path.Combine(Path.GetDirectoryName(Caminho), fileName));

                    if (File.Exists(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                        return ExcluirArquivo(fileName);
                    else
                        return true;
                }
                else
                    return false;
                
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }
        
        public void CriarPasta()
        {
            if (!Directory.Exists(Path.GetDirectoryName(Caminho)))
                Directory.CreateDirectory(Path.GetDirectoryName(Caminho));
        }

        public bool SerializarObjeto(object objeto, string fileName)
        {
            try
            {
                CriarPasta();

                using (Stream Serial = File.Create(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(Serial, objeto);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public object DesserializarObjeto(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            object obj;
            try
            {
                if (ArquivoExiste(fileName))
                {
                    using (Stream Desserial = File.OpenRead(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                    {
                        obj = (object)bf.Deserialize(Desserial);
                        Desserial.Close();
                        return obj;
                    }
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                bf = null;
                obj = null;
            }
        }
    }
}
