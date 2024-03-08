namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> soccerTeams = new List<string>()
            {
                "Real Madrid", "Manchester United", "AC Millan", "Barcelona", "Liverpool", "Ajax", 
                "Benfica", "Chelsea"
            };

            var orderedTeams = soccerTeams.OrderBy(name => name.Length);
            Console.WriteLine("These are the Champions League teams and the names goes by length order");

            foreach (var team in orderedTeams) 
            {               
                Console.WriteLine(team);
            }

        }
    }
}
