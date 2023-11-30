class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Test");
        Video video1 = new Video("Title1", "Author1", 30);
        Video video2 = new Video("Title2", "Author2", 15);
        Video video3 = new Video("Title3", "Author3", 45);

        video1.AddComment("Username1", "Comment 1");
        video1.AddComment("Username2", "Comment 2");
        video1.AddComment("Username3", "Comment 3");

        video2.AddComment("Username1", "Comment 1");
        video2.AddComment("Username2", "Comment 2");
        video2.AddComment("Username3", "Comment 3");

        video3.AddComment("Username1", "Comment 1");
        video3.AddComment("Username2", "Comment 2");
        video3.AddComment("Username3", "Comment 3");

        List<Video> videos = new List<Video> 
        { 
            video1, video2, video3 
        };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetNumComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommentUsername} - {comment.CommentText}");
            }
            Console.WriteLine();
            
        }
    }
}