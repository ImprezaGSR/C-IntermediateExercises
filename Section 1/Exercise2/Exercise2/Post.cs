namespace Exercise2
{
    public class Post
    {
        public string? _title { get; private set; }
        public string? _description { get; private set; }
        public DateTime _postDateTime { get; private set; }
        public int _upVoteCount { get; private set; }
        public int _downVoteCount { get; private set; }
        public Post(string title, string description)
        {
            _title = title;
            _description = description;
            _postDateTime = DateTime.Now;
        }
        public void UpVote()
        {
            _upVoteCount++;
        }
        public void DownVote()
        {
            _downVoteCount++;
        }

    }
}
