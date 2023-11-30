class Comment{
    public string CommentUsername { get; set; }
    public string CommentText { get; set; }

    public Comment(string user, string text) {
        CommentUsername = user;
        CommentText = text;
    }
}