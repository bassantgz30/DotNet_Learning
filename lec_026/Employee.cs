namespace ProjectClasses
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal salary { get; set; }
        public string department { get; set; }

        public override bool Equals(object obj)
        { 
            if ((obj == null) || (!(obj is Employee))) return false;
            var emp = obj as Employee;
            return this.id == emp.id 
                    && this.name == emp.name 
                    && this.salary == emp.salary 
                    && this.department == emp.department;
        }
    }
}
