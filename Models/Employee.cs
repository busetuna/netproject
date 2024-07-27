namespace Basics.ModelExpressionProvider
{
    public class Employee
    {
        public int Id { get; set;}

        public String FirstName { get; set;} = String.Empty;
        
        public String LastName { get; set;} = String.Empty;

        public String Fullname => $@"{FirstName} {LastName.ToUpper()}";

        public int Age { get; set; } 
            }
}