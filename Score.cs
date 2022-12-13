namespace BAP.Types
{
    /// <summary>
    /// This is the basic score component that is stored in the database and returned if using the basic score system. 
    /// Dificulty levels can be defined, howerver you want but it is there because you might have different settings that make comparing scores difficult
    /// Also, a game might be much more difficult with more buttons or much easier. So this basically creates multiple score boards for the same game. 
    /// </summary>
    public class Score
    {
        public int ScoreId { get; set; }
        public string GameId { get; set; } = "";
        public string DifficultyId { get; set; } = "";
        public string DifficultyDescription { get; set; } = "";
        public string UserName { get; set; } = "";
        public string ScoreDescription { get; set; } = "";
        public string ScoreData { get; set; } = "";
        public decimal NormalizedScore { get; set; }
    }
}