using FlappyBirds.Class;
using System.Collections.Generic;
using System.IO;

namespace FlappyBirds.Utils
{
    internal static class ScoreUtils
    {
        private static string ScorePath = "./scores.txt";

        public static void WriteScore(PlayerScore score)
        {
            if (File.Exists(ScorePath))
            {
                using (var stream = File.AppendText(ScorePath))
                {
                    stream.WriteLine(score);

                    stream.Flush();
                }
            }
            else
            {
                using (var stream = File.CreateText(ScorePath))
                {
                    stream.WriteLine(score);

                    stream.Flush();
                }
            }
        }

        public static List<PlayerScore> ReadTopScores()
        {
            List<PlayerScore> scores = new List<PlayerScore>();
            using (var file = File.Open(ScorePath, FileMode.OpenOrCreate))
            using (var stream = new StreamReader(file))
            {
                while (!stream.EndOfStream)
                {
                    scores.Add(PlayerScore.Parse(stream.ReadLine()));
                }
            }

            return scores;
        }
    }
}