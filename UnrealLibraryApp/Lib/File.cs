using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace UnrealLibraryApp.Lib
{
    internal class File
    {
        private string path;
        private bool fileChanged = false;
        public File(string path)
        {
            this.path = path;
        }

        public File()
        {
            this.path = Environment.CurrentDirectory + @"\openme.json";
        }

        public string Path { get => path; set => path = value; }
        public bool FileChanged { get => fileChanged; set => fileChanged = value; }

        public Library Load()
        {
            try
            {
                StreamReader fStream = new StreamReader(path);
                Library libOut = JsonConvert.DeserializeObject<Library>(fStream.ReadToEnd());
                fStream.Close();
                return libOut;
            }
            catch (Exception e)
            {
                Console.WriteLine("File reading error!");
                Console.WriteLine(e.Message);
                Library exLib = new Library();
                return exLib;
            }
        }

        public void Save(Library libIn)
        {
            try
            {
                StreamWriter fStream = new StreamWriter(path);
                fStream.Write(JsonConvert.SerializeObject(libIn));
                fStream.Close();
                this.FileChanged = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("File writing error!");
                Console.WriteLine(e.Message);
            }
        }

    }
}
