using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TechJobsOO
{
    public class Job : ShellCo
    {

        public Job() : base()
        {
            Name = "";
            EmployerName = new Employer("");
            EmployerLocation = new Location("");
            JobType = new PositionType("");
            JobCoreCompetency = new CoreCompetency("");
        }

        public Job (string name, Employer employer, Location location, PositionType jobType, CoreCompetency coreCompetency) : 
            base(name, employer, location, jobType, coreCompetency)
        { }
    

        //public override string ToString()
        //{
        //    string str = Environment.NewLine;
        //    string empty = "Data not available";
        //    int isEmpty = 0;
        //    foreach(PropertyInfo property in this.GetType().GetProperties())
        //    {
        //        if (property.Name == "Id")
        //        {
        //            str += "ID: " + this.Id.ToString() + Environment.NewLine;
        //        }
        //        else if (property.Name == "Name")
        //        {
        //            str += "Name: ";
        //            if (this.Name == "")
        //            {
        //                str += empty;
        //                isEmpty++;
        //            }
        //            else
        //            {
        //                str += this.Name;
        //            }
        //            str += Environment.NewLine;
        //        }
        //        else if (property.Name == "EmployerName")
        //        {
        //            str += "Employer: ";
        //            if (this.EmployerName.Value == "")
        //            {
        //                str += empty;
        //                isEmpty++;
        //            }
        //            else
        //            {
        //                str += this.EmployerName.Value;
        //            }
        //            str += Environment.NewLine;
        //        }
        //        else if (property.Name == "EmployerLocation")
        //        {
        //            str += "Location: ";
        //            if (this.EmployerLocation.Value == "")
        //            {
        //                str += empty;
        //                isEmpty++;
        //            }
        //            else
        //            {
        //                str += this.EmployerLocation.Value;
        //            }
        //            str += Environment.NewLine;
        //        }
        //        else if (property.Name == "JobType")
        //        {
        //            str += "Position Type: ";
        //            if(this.JobType.Value == "")
        //            {
        //                str += empty;
        //                isEmpty++;
        //            }
        //            else
        //            {
        //                str += this.JobType.Value;
        //            }
        //            str += Environment.NewLine;
        //        }
        //        else if (property.Name == "JobCoreCompetency")
        //        {
        //            str += "Core Competency: ";
        //            if (this.JobCoreCompetency.Value == "")
        //            {
        //                str += empty;
        //                isEmpty++;
        //            }
        //            else
        //            {
        //                str += this.JobCoreCompetency.Value;
        //            }
        //            str += Environment.NewLine;
        //        }
        //    }  
        //    if(isEmpty == 5)
        //    {
        //       str = "OOPS! This job does not seem to exist";
        //    }

        //        return str;

    }
}
