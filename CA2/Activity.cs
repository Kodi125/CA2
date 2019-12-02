/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 1-12-2019
 * Description : CA2 C# Code
 *
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    #region enum
    public enum ActivityType
    {
        Land,
        Air,
        Water
    }
    #endregion enum
    public class Activity : IComparable<Activity>//icomparable that is set to only compare the object activity
    {
        #region Properties
        public string Name { get; set; }

        public DateTime ActivityDate { get; set; }

        public decimal Cost { get; set; }

        public ActivityType TypeOfActivity { get; set; }

        public string _description;

        public string  Description
        {
            get
            {
                return $"{_description}  - { Cost:c} ";
            }
        }

        #endregion Properties


        #region Constructors
        public Activity(string name, string description, DateTime date, ActivityType category, decimal price)
        {
            Name = name;
            _description = description;
            ActivityDate = date;
            TypeOfActivity = category;
            Cost = price;
        }

        #endregion Constructors

        #region ToString()
        public override string ToString()
        {
            return $"{Name}  - { ActivityDate.ToShortDateString()} ";
        }
        #endregion ToString();

        #region IComparable Method
        public int CompareTo(Activity date)
        {
            return this.ActivityDate.CompareTo(date.ActivityDate);
        }
        #endregion IComparable Method
    }
}
