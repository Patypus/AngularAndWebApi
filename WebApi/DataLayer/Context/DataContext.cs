using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {
        }

        public DbSet<ChampionshipYear> ChampionshipYears { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<DriverChampionshipEntry> DriverChampionshipEntrys { get; set; }
        public DbSet<PositionDetails> PossitionDetails { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceResultPosition> RaceResultPosition { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamChampionshipEntry> TeamChampionshipEntrys { get; set; }
        public DbSet<Track> Tracks { get; set; }
}
}
