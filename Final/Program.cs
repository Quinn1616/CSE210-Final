class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Test");
        Video video1 = new Video("Video Title 1", "Author 1", 30);
        Video video2 = new Video("Video Title 2", "Author 2", 15);
        Video video3 = new Video("Video Title 3", "Author 3", 45);

        video1.AddComment("Username 1", "Comment 1");
        video1.AddComment("Username 2", "Comment 2");
        video1.AddComment("Username 3", "Comment 3");

        video2.AddComment("Username 1", "Comment 1");
        video2.AddComment("Username 2", "Comment 2");
        video2.AddComment("Username 3", "Comment 3");

        video3.AddComment("Username 1", "Comment 1");
        video3.AddComment("Username 2", "Comment 2");
        video3.AddComment("Username 3", "Comment 3");

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