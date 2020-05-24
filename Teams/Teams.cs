
using System.Collections.Generic;


    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        private string teamName;

        public Team(string teamName)
        {
            this.teamName = teamName;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam; }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam; }
        }

        public string TeamName
        {
        get
            {
                return teamName;
            }
        }
        
        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }

        }
        

    }