namespace DnDCreator.Data
{
    public class CharCreatorData
    {
        public enum Classes
        {
            Barbarian,
            Bard,
            Cleric,
            Druid,
            Fighter,
            Monk,
            Paladin,
            Ranger,
            Rogue,
            Sorcerer,
            Warlock,
            Wizard
        };

        private int statsStr = 8;
        private int statsDex = 8;
        private int statsCha = 8;
        private int stats123 = 8;
        private int stats321 = 8;
        private int stats231 = 8;
        

        /*public int StatsStr
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        public int StatsDex
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        public int StatsCha
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        public int Stats123
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        public int Stats321
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        public int Stats231
        {
            get { return statsStr; }
            set
            {
                statsStr = calculateStats();
            }
        }
        */

        private CharCreatorData() {}
        private static CharCreatorData instance = null;

        public static CharCreatorData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CharCreatorData();
                }
                return instance; 
            }
        }
        public void calculateStats(Classes chosenClass)
        {

            switch (chosenClass)
            {
                case Classes.Barbarian:
                    {
                        Barbarian barbarian = new Barbarian();
                        break;
                    }
                case Classes.Bard:
                    {

                        break;
                    }
                case Classes.Cleric:
                    {

                        break;
                    }
                case Classes.Druid:
                    {

                        break;
                    }
                case Classes.Fighter:
                    {

                        break;
                    }
                case Classes.Monk:
                    {

                        break;
                    }
                case Classes.Paladin:
                    {

                        break;
                    }
                case Classes.Ranger:
                    {

                        break;
                    }
                case Classes.Rogue:
                    {

                        break;
                    }
                case Classes.Sorcerer:
                    {

                        break;
                    }
                case Classes.Warlock:
                    {

                        break;
                    }
                case Classes.Wizard:
                    {

                        break;
                    }

            }
        }
    }
}
