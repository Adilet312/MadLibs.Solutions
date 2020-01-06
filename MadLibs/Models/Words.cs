namespace MadLibs.Models
{
    public class Words
    {
        private string namePerson;

        private string reciverName;
        private string adjective;
        private string noun;
        private string verb;
        public Words(string name, string noun, string verb)
        {
            this.namePerson = name;
            this.noun = noun;
            this.verb = verb;
        }
        public Words(string name,string reciver, string adj, string noun, string verb)
        {
            this.namePerson = name;
            this.reciverName = reciver;
            this.adjective = adj;
            this.noun = noun;
            this.verb = verb;
        }
        public string getName()
        {
            return this.namePerson;
        }

        public string getAdjective()
        {
            return this.adjective;
        }

        public string getNoun()
        {
            return this.noun;
        }

        public string getVerb()
        {
            return this.verb;
        }

        public string getReciver()
        {
            return this.reciverName;
        }

        public void setNamePrson(string new_name)
        {
            this.namePerson = new_name;
        }

        public void setAdjective(string new_adjective)
        {
            this.adjective = new_adjective;
        }

        public void setNoun(string new_noun)
        {
            this.noun = new_noun;
        }

        public void setVerb(string new_verb)
        {
            this.verb = new_verb;
        }
    }
}