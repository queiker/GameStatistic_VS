using System;
using GameStatisticsApp.DataAccess;

namespace GameStatisticsApp.Services
{
    public class GameService
    {
        private static GameService _instance;

        private GameService()
        {
            
        }
        
        public static GameService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameService();
            }

            return _instance;
        }
        
        public int GetNumberOfGames()
        {
            var dataAccess = RepoService.GetInstance();
            var games = dataAccess.ReadDataFromFile();
            var result = games.Count;

            return result;
        }

        public bool IsThereGameFromYear(int year)
        {
            var dataAccess = RepoService.GetInstance();
            var games = dataAccess.ReadDataFromFile();
            foreach (var game in games)
            {
                if (game.ReleaseYear.Year == year)
                    return true;
            }

            return false;
        }
        
    }
}