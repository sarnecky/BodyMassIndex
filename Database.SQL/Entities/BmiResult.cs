namespace Database.SQL.Entities
{
    public class BmiResult
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public float Bmi { get; set; }
    }
}