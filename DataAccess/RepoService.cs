using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using GameStatisticsApp.Models;

namespace GameStatisticsApp.DataAccess
{
    public class RepoService
    {
        private static RepoService _instance;
        private RepoService()
        {
            
        }
        
        public static RepoService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RepoService();
            }

            return _instance;
        }
        
        
        
        public List<Game> ReadDataFromFile()
        {
            var allLines = File.ReadAllLines("data.txt");
            var result = new List<Game>();

            foreach (var line in allLines)
            {
                var row = line.Split('\t');
                var game = new Game()
                {
                    Name = row[0],
                    SoldCopies = double.Parse(row[1], CultureInfo.InvariantCulture),
                    ReleaseYear = new DateTime(int.Parse(row[2]),1,1),
                    Genre = row[3],
                    Company = row[4]
                };
                result.Add(game);
            }
            
            return result;
        }
        
    }
}