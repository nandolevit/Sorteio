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

        public bool SerializarObjeto(object objeto, string fileName, bool ocultar = false)
        {
            try
            {
                CriarPasta();

                using (Stream Serial = File.Create(Path.Combine(Path.GetDirectoryName(Caminho), fileName)))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(Serial, objeto);
                }

                if (ocultar)
                {
                    FileInfo f = new FileInfo(Caminho + fileName);
                    f.Attributes = FileAttributes.Hidden;
                    //using (StreamReader sr = new StreamReader(f.Open(FileMode.Open)))
                    //{
                    //    Encryptar encryptar = new Encryptar(CryptProvider.RC2); // escolhe o tipo de criptografia, neste caso escolhemos o RC2
                    //    string crypto = encryptar.Crypto(sr.ReadToEnd());

                    //    GravarTxt(crypto, "crypto_" + fileName);
                    //}
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
                        //Desserial.Close();

                        //if (fileName.EndsWith(".lvt"))
                        //{
                        //    FileInfo f = new FileInfo(Caminho + "crypto_" + fileName);
                        //    using (StreamReader sr = new StreamReader(f.Open(FileMode.Open)))
                        //    {
                        //        Encryptar encryptar = new Encryptar(CryptProvider.RC2); // escolhe o tipo de criptografia, neste caso escolhemos o RC2
                        //        string crypto = encryptar.DeCrypto(sr.ReadToEnd());

                        //        GravarTxt(crypto, "decrypto_" + fileName);
                        //    }
                        //}

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

        public void GravarTxt(string str, string filelName)
        {
            FileInfo f = new FileInfo(Caminho + filelName);

            if (f.Exists)
                f.Delete();

            using (StreamWriter sw = f.AppendText())
            {
                sw.Write(str);
            }

            //FormMessage.ShowMessageSave();

            //FormMessage.ShowMessegeInfo("Relatório realizado com sucesso! Foi criada uma pasta na ÁREA DE TRABALHO/BANCOSORTEIO, lá estará os relatório!");
        }
    }
}
