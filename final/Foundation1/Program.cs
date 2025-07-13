using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation Project 1");
        List<Video> videos = CreateVideos();
        foreach(Video video in videos) {
            Video.DisplayVideos(video);
        }

    }

    static List<Video> CreateVideos()
    {
        List<Video> videos = [];

        // video 1
        List<Comment> comments = [];
        Comment comment1 = new Comment("Dave", "This video is cool!");
        comments.Add(comment1);
        Comment comment2 = new Comment("Steve", "This video is lame!");
        comments.Add(comment2);
        Comment comment3 = new Comment("Max", "What is this video about?");
        comments.Add(comment3);
        Video video1 = new Video("video1", "Brother Barzee", 238, comments);
        videos.Add(video1);

        // video 2
        comments = [];
        Comment comment4 = new Comment("Averly", "Cool video!");
        comments.Add(comment4);
        Comment comment5 = new Comment("Bro Barzee", "You got an A on this assignment!");
        comments.Add(comment5);
        Comment comment6 = new Comment("Jeff", "Boring");
        comments.Add(comment6);
        Video video2 = new Video("video2", "Ke Nunn", 402, comments);
        videos.Add(video2);

        // video 3
        comments = [];
        Comment comment7 = new Comment("Megan", "Worth a watch!");
        comments.Add(comment7);
        Comment comment8 = new Comment("President Merideth", "Great work!");
        comments.Add(comment8);
        Comment comment9 = new Comment("Gary", "*insert comment here*");
        comments.Add(comment9);
        Video video3 = new Video("video3", "Elon Musk", 120, comments);
        videos.Add(video3);

        // video 4
        comments = [];
        Comment comment10 = new Comment("Lola", "Informative video!");
        comments.Add(comment10);
        Comment comment11 = new Comment("Greg", "What trig function is blind? ..... sec");
        comments.Add(comment11);
        Comment comment12 = new Comment("Scott", "I ran out of ideas... But there would be a comment here");
        comments.Add(comment12);
        Video video4 = new Video("video4", "Jeff Bezos", 167, comments);
        videos.Add(video4);

        return videos;
    }
}