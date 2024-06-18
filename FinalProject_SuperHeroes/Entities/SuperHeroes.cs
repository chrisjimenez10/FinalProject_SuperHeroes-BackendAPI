namespace FinalProject_SuperHeroes.Entities
{
    public class SuperHeroes
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string SuperName { get; set; } = string.Empty;
        public string SuperPower { get; set; } = string.Empty;
        public int Strength { get; set; } = 50;
        public bool IsTeam { get; set; } = false;
        public string VillainName { get; set; } = string.Empty;

    }
}
