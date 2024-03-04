using System;

namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var post1 = new Post("My First Vote", "Insert Boring Description");
                Console.WriteLine(post1._title);
                Console.WriteLine(post1._description);
                Console.WriteLine(post1._postDateTime);

                post1.UpVote();
                post1.UpVote();
                post1.UpVote();
                post1.DownVote();

                Console.WriteLine("Current Vote Value of "+post1._title);
                Console.WriteLine("Up Vote: "+post1._upVoteCount+", Down Vote: "+post1._downVoteCount);
            }
            catch (Exception)
            {
                Console.WriteLine("ガッ");
            }
        }
    }
}
