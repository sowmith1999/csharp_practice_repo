using System;
using System.Xml.Schema;

namespace StackOverflowPost
{
    class StackPost
    {
        private string _Title;
        private string _Description;
        private DateTime _PostCreationTime;
        private int _Vote;

        public int Vote { get => _Vote; set => _Vote = value; }
        public string Description { get => _Description; set => _Description = value; }
        public DateTime PostCreationTime { get => _PostCreationTime; set => _PostCreationTime = value; }
        public string Title { get => _Title; set => _Title = value; }

        public StackPost(string Title, String Description, DateTime PostDateTime)
        {
            this._Title = Title;
            this._Description = Description;
            this._PostCreationTime = PostDateTime;
        }

        public void UpVote()
        {
            this._Vote += 1;
        }
        public void DownVote()
        {
            this._Vote -=1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var lol = new StackPost("lol","I don't Care",DateTime.Now);
            Console.WriteLine(lol.Vote);
            lol.UpVote();
            lol.UpVote();
            Console.WriteLine(lol.Vote);
            lol.DownVote();
            Console.WriteLine(lol.Vote); ;

        }
    }
}
