namespace FlappyBirds.Class
{
    public class PlayerScore
    {
        public int Score { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}:{Score}";
        }

        public static PlayerScore Parse(string str)
        {
            var parts = str.Split(':');

            return new PlayerScore
            {
                Score = int.Parse(parts[1]),
                Name = parts[0]
            };
        }
    }
}