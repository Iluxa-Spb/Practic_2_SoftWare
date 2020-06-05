using System;

namespace Lab2
{
    [Serializable]
    class CommercialSoftware : Software
    {
        private int _Price { get; set; }
        private DateTime _DataUseful { get; set; }
        /// <summary>
        /// class commercial software include from Software
        /// </summary>
        /// <param name="title">title name software</param>
        /// <param name="manufacturer">manufacter software</param>
        /// <param name="date">data create software</param>
        /// <param name="price">price software</param>
        /// <param name="dateuseful">data final using software</param>
        public CommercialSoftware(string title, string manufacturer, DateTime date, int price, DateTime dateuseful)
            :base(title, manufacturer, date)
        {
            _Price = price;
            _DataUseful = dateuseful;
        }
        /// <summary>
        /// display method
        /// </summary>
        public override void Display()
        {
            DateTime DateNow = DateTime.Now;
            Console.WriteLine($"Commercial = Title: {GetTitle()}, manufacturer: {GetManufacturer()}, install data: {GetDateCreate()}, price: {_Price}, date useful: {_DataUseful.Subtract(DateNow)}");
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
        public int GetPrice()
        {
            return _Price;
        }
        public DateTime GetDataUseful()
        {
            return _DataUseful;
        }
    }
}
