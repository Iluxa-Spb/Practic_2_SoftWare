using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    [Serializable]
    class SoftwareList
    {
        List<Software> _SoftwareList;
        /// <summary>
        /// default
        /// </summary>
        public SoftwareList()
        {
            _SoftwareList = new List<Software>();
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
            _SoftwareList.Add(software);
        }
        /// <summary>
        /// show all list
        /// </summary>
        public void Show()
        {
            foreach (Software soft in _SoftwareList)
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
            foreach (Software soft in _SoftwareList)
            {
                if (soft.GetTitle().Contains(searchString)||soft.GetManufacturer().Contains(searchString))
                {
                    if (soft.IsActive())
                        soft.Display();
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
                FileStream stream = File.Create($"{path}\\{fileName}");
                BinaryFormatter formatter = new BinaryFormatter();
                //Сериализация
                formatter.Serialize(stream, _SoftwareList);
                stream.Close();
            }
            catch
            {
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
                FileStream stream = File.OpenRead($"{path}\\{fileName}");
                BinaryFormatter formatter = new BinaryFormatter();
                _SoftwareList = formatter.Deserialize(stream) as List<Software>;
            }
            catch
            {
                throw new ArgumentNullException();
            }
        }
    }
}
