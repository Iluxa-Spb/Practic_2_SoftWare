using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    [Serializable]
    class SoftwareList
    {
        List<Software> SoftList;
        /// <summary>
        /// default
        /// </summary>
        public SoftwareList()
        {
            Trace.WriteLine("List create: "+ToString());
            SoftList = new List<Software>();
        }
        /// <summary>
        /// overloading in file
        /// </summary>
        /// <param name="path">file URL</param>
        /// <param name="fileName">file name</param>
        public SoftwareList(string path, string fileName)
        {
            ReadingFile(path, fileName);
        }
        /// <summary>
        /// add new software in list
        /// </summary>
        /// <param name="software"></param>
        public void Add(Software software)
        {
            Trace.WriteLine(ToString() + " Add to " + software.ToString());
            SoftList.Add(software);
        }
        /// <summary>
        /// show all list
        /// </summary>
        public void Show()
        {
            foreach (Software soft in SoftList)
            {
                soft.Display();
            }
        }
        /// <summary>
        /// search in list
        /// </summary>
        /// <param name="searchString">search string</param>
        public void Search(string searchString)
        {
            foreach (Software soft in SoftList)
            {
                if (soft.GetTitle().Contains(searchString)||soft.GetManufacturer().Contains(searchString))
                {
                    if (soft.IsActive())
                    {
                        Trace.WriteLine("Find: "+soft.ToString());
                        soft.Display();
                    }
                }
            }
        }
        /// <summary>
        /// wrire in file
        /// </summary>
        /// <param name="path">file URL</param>
        /// <param name="fileName">file name</param>
        public void WriteFile(string path, string fileName)
        {
            try
            {
                Trace.WriteLine("File write starting..."+path+fileName);
                FileStream stream = File.Create($"{path}\\{fileName}");
                BinaryFormatter formatter = new BinaryFormatter();
                //Сериализация
                formatter.Serialize(stream, SoftList);
                stream.Close();
                Trace.WriteLine("File write complete..."+path+fileName);
            }
            catch
            {
                Trace.TraceError("Error write file!");
                throw new ArgumentNullException();
            }
            
        }
        /// <summary>
        /// reading from file
        /// </summary>
        /// <param name="path">file URL</param>
        /// <param name="fileName">file name</param>
        public void ReadingFile(string path, string fileName)
        {
            try
            {
                Trace.WriteLine("File reading start..." + path + fileName);
                FileStream stream = File.OpenRead($"{path}\\{fileName}");
                BinaryFormatter formatter = new BinaryFormatter();
                SoftList = formatter.Deserialize(stream) as List<Software>;
                Trace.WriteLine("File reading..."+path+fileName);
            }
            catch
            {
                Trace.TraceError("Error reading file!");
                throw new ArgumentNullException();
            }
        }
    }
}
