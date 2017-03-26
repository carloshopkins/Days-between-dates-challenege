using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //Set the selected calendars dates to usable DateTime values
            DateTime cal1 = Calendar1.SelectedDate;
            DateTime cal2 = Calendar2.SelectedDate;

            //Determine the number of days between the selected dates
            TimeSpan calSpan = cal2.Subtract(cal1);

            //If the number of days between the days is a negative value
            //This will change it to a positive value i.e. the user selected a later date on the first calendar
            int daySpanTest = Int32.Parse(calSpan.Days.ToString());
            if (daySpanTest < 0)
            {
                daySpanTest *= -1;
            }

            //Prints the results to the screen below the "Ok" button
            resultLabel.Text = "There are " + daySpanTest + " days between " + cal1.ToShortDateString() + " & " + cal2.ToShortDateString();
            
        }
    }
}