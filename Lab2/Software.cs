using System;
using System.Diagnostics;

namespace Lab2
{
    /// <summary>
    /// abstract class Software
    /// </summary>
    [Serializable]
    abstract class Software
{
    private string Title { get; set; }
    private string Manufacturer { get; set; }
    private DateTime DateCreate { get; set; }
        /// <summary>
        /// init Software class
        /// </summary>
        /// <param name="title">title name software</param>
        /// <param name="manufacturer">manufacter software</param>
        /// <param name="date">data create software</param>
        public Software(string title, string manufacturer, DateTime date)
    {
            Trace.WriteLine("Software create: " + ToString());
            Trace.Indent();
            Title = title;
            Manufacturer = manufacturer;
            DateCreate = date;
    }
        /// <summary>
        /// abstract display method
        /// </summary>
        public abstract void Display();
        /// <summary>
        /// abstract boolean method return active software or not
        /// </summary>
        /// <returns>true or false</returns>
        public abstract bool IsActive();

        public string GetTitle()
        {
            return Title;
        }

        public string GetManufacturer()
        {
            return Manufacturer;
        }

        public DateTime GetDateCreate()
        {
            return DateCreate;
        }
    }
}
