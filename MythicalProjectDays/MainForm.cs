using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace MythicalProjectDays
{
    
    public partial class MainForm : Form
    {

     
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
        }



        private string CalculateDays(DateTime startDate, DateTime endDate)
        {
            int noOfDays = 0;
            int noOfHolidays = 0;

            //Add date of holiday but set clock to midnight
            //Array is only made when the button is pressed allowing for alterations between presses.
            DateTime[] arrayofPublicHolidays = new DateTime[] { new DateTime(2022, 12, 02), new DateTime(2022, 01, 31) };

           if (DateTime.Compare(startDate, endDate) == 1)
                MessageBox.Show("Input should be \"Start Date < End Date \" !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (DateTime.Compare(startDate, endDate) <= 0)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    string holiday =
                        (from date in arrayofPublicHolidays
                            where DateTime.Compare(startDate, date) == 0 select "True").FirstOrDefault();

                    

                    if (holiday!="True")
                    {
                        noOfDays += 1; //counting no of working days.
                    }
                    else
                    {
                        noOfHolidays += 1;
                    }
                    startDate = startDate.AddDays(1);
                }
                else
                    startDate = startDate.AddDays(1);
            }
            return string.Concat("Days = " + noOfDays + "\n" + "Holidays = " + noOfHolidays);
        }

        private void btn_days_between_Click(object sender, EventArgs e)
        {
            //get DateTime using only Year, Month and Day and clock at midnight.
            DateTime startDateTime = DateTime.Parse(DatePick_StartDate.Value.Day + "/" + DatePick_StartDate.Value.Month + "/" + DatePick_StartDate.Value.Year);
            DateTime endDateTime = DateTime.Parse(DatePick_EndDate.Value.Day + "/" + DatePick_EndDate.Value.Month + "/" + DatePick_EndDate.Value.Year);

            lbl_days_between.Text = CalculateDays(startDateTime, endDateTime);
           
        }

       

        //-------------------------------------------------------------------------------

        //no days in year
        //var user = "05-08-2012";
        //var date = DateTime.ParseExact(user, "MM-dd-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        //var lastdate = new DateTime(date.Year, 12, 31);
        //var diff = lastdate - date;

        //------------------------------------------------------------------------------

        //shows leap years
        //DateTime dec31 = new DateTime(2000, 12, 31);
        //    for (int ctr = 0; ctr <= 20; ctr++) {
        //    DateTime dateToDisplay = dec31.AddYears(ctr);
        //    Console.WriteLine("{0:d}: day {1} of {2} {3}", dateToDisplay, 
        //        dateToDisplay.DayOfYear,
        //        dateToDisplay.Year,   
        //        DateTime.IsLeapYear(dateToDisplay.Year)? 
        //            "(Leap Year)" : ""); 
    }
}
