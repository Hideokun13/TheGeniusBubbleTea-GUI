using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TheGenuisBubbleTea_GUI
{
    class FileManagement
    {
        private string filename;

        public FileManagement(string filename)
        {
            this.filename = filename;
        }

        public List<string> ReadFile()
        {
            List<string> content = new List<string>();
            StreamReader sr = new StreamReader(filename);
            string line = sr.ReadLine();
            while (line != null && line != "")
            {
                content.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return content;
        }
        public bool WriteAppendFile(List<string> texts)
        {
            bool isDone = true;

            StreamReader sr = new StreamReader(filename);
            List<string> temp = new List<string>();
            string line = sr.ReadLine();
            while (line != null)
            {
                temp.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(filename);
            if(temp != null)
            {
                foreach (string i in temp)
                {
                    sw.WriteLine(i);
                }
            }
            foreach (string j in texts)
            {
                sw.WriteLine(j);
            }
            sw.Close();
            return isDone;
        }
        public bool WriteFile(List<string> texts)
        {
            bool isDone = true;
            StreamWriter sw = new StreamWriter(filename);

            foreach (string i in texts)
            {
                if(i == "DEL TEXT")
                {
                    sw.Write("");
                }
                else
                {
                    sw.WriteLine(i);
                }
            }
            sw.Close();
            return isDone;
        }


    }
}
