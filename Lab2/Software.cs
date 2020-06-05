using System;

namespace Lab2
{
    /// <summary>
    /// abstract class Software
    /// </summary>
    [Serializable]
    abstract class Software
{
    private string _Title { get; set; }
    private string _Manufacturer { get; set; }
    private DateTime _DateCreate { get; set; }
        /// <summary>
        /// init Software class
        /// </summary>
        /// <param name="title">title name software</param>
        /// <param name="manufacturer">manufacter software</param>
        /// <param name="date">data create software</param>
        public Software(string title, string manufacturer, DateTime date)
    {
            _Title = title;
            _Manufacturer = manufacturer;
            _DateCreate = date;
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
            return _Title;
        }

        public string GetManufacturer()
        {
            return _Manufacturer;
        }

        public DateTime GetDateCreate()
        {
            return _DateCreate;
        }
    }
}
