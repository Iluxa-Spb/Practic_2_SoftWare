using System;
namespace Lab2
{
    class Program
    {
        /// <summary>
        /// Run program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //SoftwareList Software = new SoftwareList();
            //Software.Add(new FreeSoftware("Visual Studio", "Microsoft", new DateTime(2020, 1, 12, 00, 00, 00)));
            //Software.Add(new SharewareSoftware("Outlook", "Microsoft", new DateTime(2020, 1, 12, 00, 00, 00), new DateTime(2021, 6, 12, 00, 00, 00)));
            //Software.Add(new CommercialSoftware("Word", "Microsoft", new DateTime(2020, 1, 12, 00, 00, 00), 200, new DateTime(2021, 12, 12, 00, 00, 00)));
            //Software.Add(new CommercialSoftware("Exel", "Microsoft", new DateTime(2020, 1, 12, 00, 00, 00), 300, new DateTime(2021, 12, 12, 00, 00, 00)));
            //Software.Add(new CommercialSoftware("PowerPoint", "Microsoft", new DateTime(2020, 12, 12, 00, 00, 00), 400, new DateTime(2021, 12, 12, 00, 00, 00)));
            //Software.Add(new CommercialSoftware("MKPleer", "www...", new DateTime(2020, 1, 12, 00, 00, 00), 200, new DateTime(2021, 12, 12, 00, 00, 00)));
            //Software.Add(new CommercialSoftware("Logick", "company", new DateTime(2020, 1, 12, 00, 00, 00), 200, new DateTime(2020, 4, 12, 00, 00, 00)));

            string path = @"E:\TestLogs\Folder_1";
            string fileName = "input.txt";
            //Software.WriteFile(path, fileName);

            SoftwareList NewSoftwareList = new SoftwareList(path, fileName);
            NewSoftwareList.Show();

            Console.WriteLine("Enter search string...");
            string searchString = Console.ReadLine();
            NewSoftwareList.Search(searchString);
        }
    }
}
