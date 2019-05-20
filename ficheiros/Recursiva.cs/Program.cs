using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Recursiva
{
    class Program
    {
     
           public static List<Diretorio> diretorio = new List<Diretorio>();
        
        static void Main(string[] args)
        {
            string path = @"C:\Program Files\AMD";
            string[] diretorios = Directory.GetDirectories(path);
            int size = 0;
            // RECURSIVIDADE(diretorios, size);
           
            
            DisplayDriveDirectories(path);

            var javascript = new JavaScriptSerializer();
            var javaScriptSerializer = new JavaScriptSerializer();

  

            var jsonSerializado = javaScriptSerializer.Serialize(diretorio);

            var json = javascript.Serialize(diretorio);

            Console.WriteLine(json);


            Console.ReadKey();
        }

        private static String[] RECURSIVIDADE(string[] diretorios, int size)
        {
            if (size <= diretorios.Count()&& diretorios.Count()>0)
            {
                diretorios = Directory.GetDirectories(diretorios[size]);
                size = 0;
                if (diretorios.Count() > 0)
                {
                    Console.WriteLine(diretorios[size]);
                    return diretorios = RECURSIVIDADE(diretorios, size+1);
                }
                return diretorios = RECURSIVIDADE(diretorios, size = 0); ;
            }
            return diretorios;
        }

        public static void DisplayDriveDirectories(string drivePath)
        {
            if (Directory.Exists(drivePath))
            {
                try
                {

                    foreach (String dirPath in Directory.GetDirectories(drivePath))
                        DisplayDriveDirectories(dirPath);
                    
                    DirectoryInfo dir = new DirectoryInfo(drivePath);
                    Console.WriteLine("++++++++"+dir.Name);
                    int numFiles = dir.GetFiles().Length;
                    Diretorio pasta = new Diretorio();
                    pasta.Pasta = dir.Name;
                    pasta.Caminho = dir.FullName;
                    pasta.arq = new List<Arquivos>();
                    Arquivos fi;
                    foreach (FileInfo file in dir.GetFiles()){
                        Console.WriteLine("<br>{0} file.", file.Name);
                         fi  = new Arquivos();
                         fi.Arquivo = file.Name;
                         pasta.arq.Add(fi);
                        //Console.WriteLine("<br>{0} : {1} files.", drivePath, numFiles);
                        Console.WriteLine("<br>{0} :", numFiles);

                    }
                    diretorio.Add(pasta);
                   Console.WriteLine("                             "+dir.Name);
                    
                }
                catch (Exception erro)
                {

                }
            }
            
        }


    
    }
}
