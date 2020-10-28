using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job (string name, Employer employer, Location location, PositionType jobType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = jobType;
            JobCoreCompetency = coreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
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

        //}
        {
            
            StringBuilder str = new StringBuilder(Environment.NewLine);
            int emptyFields = 1;
            Dictionary<string, string> jobStrings = new Dictionary<string, string>()
            {
                {"ID: ", Id.ToString() },
                {"Name: ", Name },
                {"Employer: ", EmployerName.Value },
                {"Location: ", EmployerLocation.Value },
                {"Position Type: ", JobType.Value },
                {"Core Competency: ", JobCoreCompetency.Value }
            };

            List<string> keys = new List<string>(jobStrings.Keys);

            foreach ( string key in keys)
            {
                if(jobStrings[key] == "")
                {
                    jobStrings[key] = "Data not available";
                    emptyFields++;
                }
            }

            if(emptyFields == jobStrings.Count)
            {
                return Environment.NewLine + "OOPS! This job does not seem to exist." + Environment.NewLine;
            }

            foreach(KeyValuePair<string, string> field in jobStrings)
            {
                str.AppendLine(field.Key + field.Value);
            }




            return str.ToString();
        }

    }
}
