using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Drawing;


namespace MythicalProjectDays
{
    public partial class MainForm : Form
	{
		 private List<DateTime> AnnualHoliday = new List<DateTime>();
		 private BindingSource AnnualHolidaySource = new BindingSource();
    	 
		 private List<DateTime> PublicHoliday = new List<DateTime>();
		 private BindingSource PublicHolidaySource = new BindingSource();
		 
		 bool flag = true;
		 
		    
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			AnnualHolidaySource.DataSource = AnnualHoliday;	
			PublicHolidaySource.DataSource = PublicHoliday;	
			
			lbl_days_req.Visible = false;
			txtbx_days_req.Visible = false;
				
			lbl_date_to.Visible = true;
			DatePick_EndDate.Visible = true;

            Text += " : v" + Assembly.GetExecutingAssembly().GetName().Version; // put in the version number
		}
		
		void Btn_closeClick(object sender, EventArgs e)
		{
			Close();
		}


		private string[] CalculateDays(DateTime startDate, DateTime endDate)
		{
			int noOfDays = 0;
            int numPublicHolidays = 0;
            int numAnnualHolidays = 0;
            string[] CalculatedDays = new string[3];

           if (DateTime.Compare(startDate, endDate) == 1)
                MessageBox.Show("Input should be \"Start Date < End Date \" !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);

            while (DateTime.Compare(startDate, endDate) <= 0)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    string PublicHoliday = (from date in PublicHolidaysArray() where DateTime.Compare(startDate, date) == 0 select "True").FirstOrDefault();  
                    string AnnualHoliday = (from date in AnnualHolidaysArray() where DateTime.Compare(startDate, date) == 0 select "True").FirstOrDefault();  
                    
                    if (PublicHoliday=="True")
                    {
                        numPublicHolidays += 1;
                        PublicHoliday = "False";
                    }
                    else if (AnnualHoliday=="True")
                    {
                        numAnnualHolidays += 1;
                        AnnualHoliday = "False";
                    }
                    else
                    {
                    	noOfDays += 1; //counting no of working days.        
                    }
                    
                    startDate = startDate.AddDays(1);
                }
                else
                    startDate = startDate.AddDays(1);
            	}
            
            CalculatedDays[0] = noOfDays.ToString();
            CalculatedDays[1] = numPublicHolidays.ToString();
            CalculatedDays[2] = numAnnualHolidays.ToString();
            
            return  CalculatedDays;
        }
		
		
		private DateTime[] PublicHolidaysArray()
		{
			DateTime[] arrayofPublicHolidays = new DateTime[] { }; 
			
			List<String> lines = new List<String>();
			
			for (int i = 0; i < lstbx_public_hol.Items.Count; i++)
			{
				lines.Add(lstbx_public_hol.Items[i].ToString().Substring(0,lstbx_public_hol.Items[i].ToString().LastIndexOf('/')+5)); // we only want date so remove time
			}
				
			foreach (var line in lines)
			{
				string[] DateTimeStrings = line.Split('/');
				arrayofPublicHolidays = arrayofPublicHolidays.Append(new DateTime(int.Parse(DateTimeStrings[2]),
				                                                                  int.Parse(DateTimeStrings[1]),
				                                                                  int.Parse(DateTimeStrings[0]))).ToArray();
			}
		   			
			return arrayofPublicHolidays;
		}
		
		
		private DateTime[] AnnualHolidaysArray()
		{
			DateTime[] arrayofAnnualHolidays = new DateTime[] { }; 
			
			List<String> lines = new List<String>();
			
			for (int i = 0; i < lstbx_annual_hol.Items.Count; i++)
			{
				lines.Add(lstbx_annual_hol.Items[i].ToString().Substring(0,lstbx_annual_hol.Items[i].ToString().LastIndexOf('/')+5)); // we only want date so remove time
			}
				
			foreach (var line in lines)
			{
				string[] DateTimeStrings = line.Split('/');
				arrayofAnnualHolidays = arrayofAnnualHolidays.Append(new DateTime(int.Parse(DateTimeStrings[2]),
				                                                                  int.Parse(DateTimeStrings[1]),
				                                                                  int.Parse(DateTimeStrings[0]))).ToArray();
			}
		   			
			return arrayofAnnualHolidays;
		}
		
		
		
		void Btn_days_betweenClick(object sender, EventArgs e)
		{
			lbl_days_between.Text = lbl_project_days.Text = ""; //Clear the screen
			int AddedDays = 0;
			
			if (flag) //flag = percentage number is in range
           	{
				
				if ((rdobtn_days_req.Checked)&&(txtbx_days_req.Text != ""))
				{
					if (DatePick_EndDate.Value.AddDays(int.Parse(txtbx_days_req.Text)) >= DatePick_StartDate.Value)
					{
						DatePick_EndDate.Value = DatePick_EndDate.Value.AddDays(int.Parse(txtbx_days_req.Text));
					}
					else
					{
						txtbx_days_req.BackColor = Color.Red;
						MessageBox.Show("Check the date as you appear to be ending before you start");
					}
					
					
				}
				
				
				//get DateTime using only Year, Month and Day and clock at midnight.
            	DateTime startDateTime = DateTime.Parse(DatePick_StartDate.Value.Day + "/" + DatePick_StartDate.Value.Month + "/" + DatePick_StartDate.Value.Year);
            	DateTime endDateTime = DateTime.Parse(DatePick_EndDate.Value.Day + "/" + DatePick_EndDate.Value.Month + "/" + DatePick_EndDate.Value.Year);

            	string[] returnedCalculatedDays = CalculateDays(startDateTime, endDateTime);
                       
           		lbl_days_between.Text = "Work Days = " + returnedCalculatedDays[0] + "\n" + 
           								"Public Holidays = " + returnedCalculatedDays[1] + "\n" + 
           								"Annual Holidays = " + returnedCalculatedDays[2];
            
           	
           		int MythicalDays = (int)Math.Round(float.Parse(returnedCalculatedDays[0]) * ((100+(100-float.Parse(txtbx_project_days_percentage.Text)))/100));
	           	int ExtraDaysReq = (int)Math.Round(MythicalDays - float.Parse(returnedCalculatedDays[0])); //due to percentage on project
	
	           	for (int i = 1; i < (ExtraDaysReq+AddedDays); i++)
	            {	            
	           		if ((DatePick_EndDate.Value.AddDays(i).DayOfWeek == DayOfWeek.Saturday)||(DatePick_EndDate.Value.AddDays(i).DayOfWeek == DayOfWeek.Sunday))
                	{
						AddedDays++; // A weekend day so add an extra day.
					}
	           		else if (PublicHoliday.Contains(DateTime.Parse(DatePick_EndDate.Value.AddDays(i).ToShortDateString())))
					{
						AddedDays++; // Public Holiday day so add an extra day
					}
					else if (AnnualHoliday.Contains(DateTime.Parse(DatePick_EndDate.Value.AddDays(i).ToShortDateString())))
					{
						AddedDays++; // Annual Holiday day so add an extra day
					}
	            }
					
	            string AdjustedEndDate = DatePick_EndDate.Value.AddDays(ExtraDaysReq + AddedDays).ToString();
	            AdjustedEndDate = AdjustedEndDate.Substring(0, AdjustedEndDate.LastIndexOf('/') + 5);
	            	
	            	
	            
           	
				lbl_project_days.Text = "Number of Real Days required = " + MythicalDays.ToString() + "\n" +
	                                	"\nEnd Date now = " + AdjustedEndDate +
										"\nExtra Days = " + ExtraDaysReq +
										"\nAdded Days = " + AddedDays;
			
				if ((rdobtn_days_req.Checked)&&(txtbx_days_req.Text != ""))
				{
					DatePick_EndDate.Value = DatePick_EndDate.Value.AddDays(-int.Parse(txtbx_days_req.Text));
				}
			}
			else
			{
				MessageBox.Show("Please correct the Percentage on project");
				
			}
		}
		
		void Btn_add_holidayClick(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Parse(DatePick_Hol_Date.Text); //put clock back to midnight
			 
			if (PublicHoliday.Contains(dt) == true) //only add if item does not already exist as a public holiday
			{
				MessageBox.Show("You already have that day off as a public holiday");
			}
			else if (AnnualHoliday.Contains(dt) == false) //only add if item does not already exist as annual holiday
			{
				{
	        		lstbx_annual_hol.DataSource = AnnualHolidaySource;			
	        		AnnualHoliday.Add(dt);
	        		AnnualHoliday.Sort();
	        		AnnualHolidaySource.ResetBindings(false);
				}
			}
			
		}
		
		
		void Btn_public_holidaysClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog_pub_hols = new OpenFileDialog();
			
			if (openFileDialog_pub_hols.ShowDialog() == DialogResult.OK)
			{
				lstbx_public_hol.DataSource = null; //clear any existing data
				PublicHoliday.Clear();
			
				lstbx_public_hol.DataSource = PublicHolidaySource;
				
				System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog_pub_hols.FileName);
    			
				while (!sr.EndOfStream) 
    			{
    				DateTime dt = DateTime.Parse(sr.ReadLine());
    				
    				if (PublicHoliday.Contains(dt) == false) //only add if item does not already exist
					{
						PublicHoliday.Add(dt);
	        			PublicHoliday.Sort();
	        			PublicHolidaySource.ResetBindings(false);
    				}
				}
				
				sr.Close();
			}
		}
		
		
		void Btn_open_private_holidayClick(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog_private_hols = new OpenFileDialog();
			
			if (openFileDialog_private_hols.ShowDialog() == DialogResult.OK)
			{
				lstbx_annual_hol.DataSource = null; //clear any existing data
				AnnualHoliday.Clear();
			
				lstbx_annual_hol.DataSource = AnnualHolidaySource;
				
				System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog_private_hols.FileName);
    			
    			while (!sr.EndOfStream) 
    			{
    				DateTime dt = DateTime.Parse(sr.ReadLine());
    				
    				if (AnnualHoliday.Contains(dt) == false) //only add if item does not already exist
					{
						AnnualHoliday.Add(dt);
	        			AnnualHoliday.Sort();
	        			AnnualHolidaySource.ResetBindings(false);
    				}
				}
    			
    			
    			sr.Close();
			}
		}
		
		
		void Btn_save_private_holClick(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
			  	using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(saveFileDialog1.FileName))
	    		{
	        		foreach (var item in lstbx_annual_hol.Items)
	        		{
	        			SaveFile.WriteLine(item.ToString().Substring(0,item.ToString().LastIndexOf('/')+5));
	        		}
	    		}
			}
		}
		
		
		void Btn_annual_holiday_clearClick(object sender, EventArgs e)
		{
			lstbx_annual_hol.DataSource = null;
			AnnualHoliday.Clear();
		}
		
		void Btn_remove_annualClick(object sender, EventArgs e)
		{
			AnnualHolidaySource.Remove(lstbx_annual_hol.SelectedItem);			
		}
		
		void Txtbx_project_days_percentageTextChanged(object sender, EventArgs e)
		{			
			int percentage = 0;
			
			txtbx_project_days_percentage.BackColor = Color.White;
			
			if (int.TryParse(txtbx_project_days_percentage.Text, out percentage))
			{
				if (percentage > 0 && percentage <= 100)
				{
					flag = true;
				}
				else
				{
					txtbx_project_days_percentage.BackColor = Color.Red;
					flag = false;
					lbl_days_between.Text = lbl_project_days.Text = ""; //Clear the screen
					MessageBox.Show("Number must be > 0 and <= 100");
				}
			}
			else
			{
				txtbx_project_days_percentage.BackColor = Color.Red;
				flag = false;
				lbl_days_between.Text = lbl_project_days.Text = ""; //Clear the screen
				MessageBox.Show("Only numbers allowed in the textbox");
			}
		}
		
		void Txtbx_days_reqTextChanged(object sender, EventArgs e)
		{
			int DaysReq = 0;
			
			txtbx_days_req.BackColor = Color.White;
			
			if (int.TryParse(txtbx_days_req.Text, out DaysReq))
			{
				
			}
			else
			{
				txtbx_days_req.BackColor = Color.Red;
				lbl_days_between.Text = lbl_project_days.Text = ""; //Clear the screen
				MessageBox.Show("Only numbers allowed in the textbox");
			}
			
		}
		
		void Rdobtn_days_reqCheckedChanged(object sender, EventArgs e)
		{
			if (rdobtn_days_req.Checked)
			{
				lbl_days_req.Visible = true;
				txtbx_days_req.Visible = true;
				
				lbl_date_to.Visible = false;
				DatePick_EndDate.Visible = false;
			}
			else
			{
				lbl_days_req.Visible = false;
				txtbx_days_req.Visible = false;
				
				lbl_date_to.Visible = true;
				DatePick_EndDate.Visible = true;
			}
		}
		
		
	}
}