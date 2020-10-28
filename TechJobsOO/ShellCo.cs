using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class ShellCo
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public JobField EmployerName { get; set; }
        public JobField EmployerLocation { get; set; }
        public JobField JobType { get; set; }
        public JobField JobCoreCompetency { get; set; }

        public ShellCo()
        {
            Id = nextId;
            nextId++;
        }

        public ShellCo(string name, Employer employer, Location location, PositionType jobType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = jobType;
            JobCoreCompetency = coreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is ShellCo co &&
                   Id == co.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {

            string emptyJob = Environment.NewLine + "OOPS! This job does not seem to exist." + Environment.NewLine;
            int emptyStrs = 1;
            StringBuilder str = new StringBuilder(Environment.NewLine);
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

            foreach (string key in keys)
            {
                if (jobStrings[key] == "")
                {
                    jobStrings[key] = "Data not available";
                    emptyStrs++;
                }
            }

            if (emptyStrs == jobStrings.Count)
            {
                return emptyJob;
            }

            foreach (KeyValuePair<string, string> field in jobStrings)
            {
                str.AppendLine(field.Key + field.Value);
            }

            return str.ToString();
        }
    }
}
