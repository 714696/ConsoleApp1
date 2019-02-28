using System;

class CountrySide

{
    static void Main()

    {

    }

    public void Run()
    {
        berrie = new Village("berrie", false);
        windsor = new Village("windsor", false);
        kitchner = new Village("kitchner", true);

        berrie.distanceToEastVillage = 14;
        berrie.distanceToEastVillage = 19;
        berrie.west = windsor;
        berrie.east = kitchner;

        windsor.west = null;
        windsor.west = null;

    }


    // Create the LinkedList to reflect the Map in the PowerPoint Instructions

    Village toronto;

    Village sudbury;

    Village berrie;

    Village kitchner;

    Village winnipeg;

    Village london;

    Village windsor;

    private void TorontoVillage(Village CurrentVillage)

    {
       
        {
            if (CurrentVillage.isAstrildgeHere)
            {
                Console.WriteLine("I saw a Lion in {0}", CurrentVillage.VillageName);
                Console.WriteLine("*******eaten by Lion!******");
                return;
            }

        }
    }





    class Village

    {

        public Village(string _villageName, bool _isAHere)
        {

            isAstrildgeHere = _isAHere;

            VillageName = _villageName;

        }



        public Village west;

        public Village east;

        public string VillageName;

        public int distanceToNextVillage;

        public int distanceToPreviousVillage;

        public bool isAstrildgeHere;

        public int distanceToEastVillage { get; internal set; }

       
    }
}
