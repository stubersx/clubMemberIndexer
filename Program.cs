namespace clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for(int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            //indexer get and set methods
            public string this[int i]
            {
                get
                {
                    if(i >= 0 && i < Size)
                        return Members[i];
                    else
                        return string.Empty;
                }
                set
                {
                    if(i >= 0 && i < Size)
                        Members[i] = value;
                }
            }
        }

        static void Main(string[] args)
        {
            ClubMembers member = new ClubMembers();
            member[0] = "James Johnson";
            member[1] = "Olivia Williams";
            member[2] = "Henry Jones";
            member[3] = "Evelyn Garcia";
            member[4] = "Jack Miller";
            member[5] = "Isabella Davis";
            member.ClubType = "Hiking Club";
            member.ClubLocation = "Central Hall 2F Room202";
            member.MeetingDate = "Monday April 1, 2024";
            Console.WriteLine($"{member.ClubType} Information\n\nMembers:");
            for(int i = 0; i < Size; i++)
            {
                if (member[i] != string.Empty)
                    Console.WriteLine($"{member[i]}");
            }
            Console.WriteLine($"\nNext Meeting: {member.MeetingDate}\nLocation: {member.ClubLocation}");
        }
    }
}
