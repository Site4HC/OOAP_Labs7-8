namespace DateInterpreterSimulation.Context
{
    public class DateContext
    {
        public string Input { get; set; }
        public int Position { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public bool IsValid { get; set; } = true;
        public string ErrorMessage { get; set; }

        public DateContext(string input)
        {
            Input = input;
        }
    }
}