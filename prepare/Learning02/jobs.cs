
    // create two classes Job and Resume  
    // class Job Responsability Keep track of the company, job title, start year and end year.  
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startDate;
        public int _endDate;

// Behavior display job information
        public void DisplayJobDetails()
        {
            Console.WriteLine($"{_jobTitle} {_startDate}-{_endDate}");
        }
    }
