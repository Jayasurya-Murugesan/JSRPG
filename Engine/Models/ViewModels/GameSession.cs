
namespace Engine.Models.ViewModels
{
    internal class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer=new Player();
            CurrentPlayer.Name = "Jayasurya";
            CurrentPlayer.CharacterClass = "Warrior";
            CurrentPlayer.ExperiencePoints = 9999;
            CurrentPlayer.HitPoins = 9999;
            CurrentPlayer.Level = 9999;
            CurrentPlayer.Gold = 1;
        }
    }
}
