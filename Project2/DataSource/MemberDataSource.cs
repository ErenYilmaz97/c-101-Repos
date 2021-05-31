using System.Collections.Generic;

namespace Project2.DataSource
{
    public static class MemberDataSource
    {
        public static List<Member> Members;


        static MemberDataSource()
        {
            Members = InitializeMembers();
        }



        static List<Member> InitializeMembers()
        {
            return new List<Member>()
            {
                new Member(1,"Eren Yılmaz"),
                new Member(2,"Hakan Tanrıverdi"),
                new Member(3,"Elif Kandemir"),
                new Member(4,"Selin Murat"),
                new Member(5,"Ahmet Koyuncu")
            };
        }
    }
}