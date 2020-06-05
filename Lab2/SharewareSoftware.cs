using System;

namespace Lab2
{
    [Serializable]
    class SharewareSoftware : Software
    {
        private DateTime _DataUseful { get; set; }
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
            _DataUseful = dateuseful;
        }
        /// <summary>
        /// display method
        /// </summary>
        public override void Display()
        {
            DateTime DateNow = DateTime.Now;
            Console.WriteLine($"Shareware = Title: {GetTitle()}, manufacturer: {GetManufacturer()}, install data: {GetDateCreate()}, date useful: {_DataUseful.Subtract(DateNow)}");
        }
        /// <summary>
        /// boolean method return active software or not
        /// </summary>
        /// <returns>true or false</returns>
        public override bool IsActive()
        {
            DateTime DateNow = DateTime.Now;
            if (_DataUseful < DateNow) return false;
            else return true;
        }
        public DateTime GetDataUseful()
        {
            return _DataUseful;
        }
    }
}
