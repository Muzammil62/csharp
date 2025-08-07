namespace new_project
{
    public class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Age must be between 1 and 100.");
                }
            }
        }
    }
}
