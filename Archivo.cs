using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SAP_BMPro
{
    class Archivo
    {
        private static String localDirectory = "c:/bmpro/";
        private String fileName;//With directory included
        private String name;//Just the file name
        private String content;

        private Archivo(String nameOfFile)
        {
            fileName = nameOfFile ;
            //Gets only name of the file
            //no path of directory that is establish as local
            name = nameOfFile.Substring(20);
            content = File.ReadAllText(nameOfFile);
        }
        public Archivo()
        {
        }
        public Archivo getLocalFile(){
           //Create array of all the files that where downloaded
           String[] files= Directory.GetFiles(localDirectory);
           Archivo constructedFiles = new Archivo();

           constructedFiles=new Archivo(files[0]);

           return constructedFiles;
        }
        public void clearLocalDirectory()
        {
            Array.ForEach(Directory.GetFiles(localDirectory), File.Delete);
        }

        public bool hasFile()
        {
            if (Directory.GetFiles(localDirectory).Length > 0){
                return true;
            }else{
                return false;
            }
        }

        public void setFileName(String namePath)
        {
            fileName = namePath;
        }
        public String getFileName()
        {
            return fileName;
        }
        public void setName(String nameOfFile)
        {
            name = nameOfFile;
        }
        public String getName()
        {
            return name;
        }
        public void setContent(String newcontent)
        {
            content = newcontent;
        }
        public String[] getContent()
        {
            String[] lines = File.ReadAllLines(fileName);

            return lines;
        }
        public String getLocalDirectory()
        {
            return localDirectory;
        }
    }
}
