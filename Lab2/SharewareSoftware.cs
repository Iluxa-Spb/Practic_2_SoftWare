using System;
using System.Diagnostics;

namespace Lab2
{
    [Serializable]
    class SharewareSoftware : Software
    {
        private DateTime DataUseful { get; set; }
        /// <summary>
        /// class shareware software include from Software
        /// </summary>
        /// <param name="title">title name software</param>
        /// <param name="manufacturer">manufacter software</param>
        /// <param name="date">data create software</param>
        /// <param name="dateuseful">data final using software</param>
        public SharewareSoftware(string title, string manufacturer, DateTime date, DateTime dateuseful)
            :base (title, manufacturer, date)
        {
            Trace.WriteLine("Software create " + DataUseful + GetDataUseful());
            DataUseful = dateuseful;
        }
        /// <summary>
        /// display method
        /// </summary>
        public override void Display()
        {
            Trace.WriteLine("Display: " + ToString());
            DateTime DateNow = DateTime.Now;
            Console.WriteLine($"Shareware = Title: {GetTitle()}, manufacturer: {GetManufacturer()}, install data: {GetDateCreate()}, date useful: {DataUseful.Subtract(DateNow)}");
        }
        /// <summary>
        /// boolean method return active software or not
        /// </summary>
        /// <returns>true or false</returns>
        public override bool IsActive()
        {
            DateTime DateNow = DateTime.Now;
            if (DataUseful < DateNow) return false;
            else return true;
        }
        public DateTime GetDataUseful()
        {
            return DataUseful;
        }
    }
}
