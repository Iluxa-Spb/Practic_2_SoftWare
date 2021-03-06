﻿using System;
using System.Diagnostics;

namespace Lab2
{
    [Serializable]
    class FreeSoftware : Software
    {
        /// <summary>
        /// class free Software include from Software
        /// </summary>
        /// <param name="title">title name software</param>
        /// <param name="manufacturer">manufacter software</param>
        /// <param name="date">data create software</param>
        public FreeSoftware(string title, string manufacturer, DateTime date)
            :base(title, manufacturer, date)
        {
            Trace.WriteLine("Software create: "+GetTitle()+"/"+GetManufacturer()+"/"+GetDateCreate());
        }
        /// <summary>
        /// display method
        /// </summary>
        public override void Display()
        {
            Trace.WriteLine("Display: " + ToString());
            Console.WriteLine($"Free = Title: {GetTitle()}, manufacturer: {GetManufacturer()}, install data: {GetDateCreate()}");
        }
        /// <summary>
        /// boolean method return active software or not
        /// </summary>
        /// <returns>true</returns>
        public override bool IsActive()
        {
            return true;
        }
    }
}
