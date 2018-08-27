using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Cliente
    {
        private int personalId;
        private string name;
        private string lastName;
        private string currentRole;
        private string contry;
        private string industry;
        private double numberOfRecommendations;
        private double numberOfConnections;

        public double NumberOfConnections
        {
            get { return numberOfConnections; }
            set { numberOfConnections = value; }
        }

        public double NumberOfRecommendations
        {
            get { return numberOfRecommendations; }
            set { numberOfRecommendations = value; }
        }

        public string Industry
        {
            get { return industry; }
            set { industry = value; }
        }

        public string Country
        {
            get { return contry; }
            set { contry = value; }
        }

        public string CurrentRole
        {
            get { return currentRole; }
            set { currentRole = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PersonalId
        {
            get { return personalId; }
            set { personalId = value; }
        }

    }
}
