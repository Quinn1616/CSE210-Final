class Video{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length) 
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string username, string text)
    {
        Comments.Add(new Comment(username, text));
    }

    public int GetNumComments() 
    {
        int counter = 0;
        foreach (var comment in Comments)
        {
            counter++;
        }
        return counter;        
    }
}