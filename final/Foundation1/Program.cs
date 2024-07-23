using System;
namespace YoutubeComments{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();
            for(int i = 0; i < 4; i++){
                videos.Add(new Video());
            }
            foreach(Video video in videos){
                Console.WriteLine($"{video.title} : {video.author} - {video.CalculateVideoTime().Item1}:{video.CalculateVideoTime().Item2} Comments:{video.comments.Count()}");
                foreach(Comment comment in video.comments){
                    Console.WriteLine($"{comment.user}: {comment.commentText}");
                }
                Console.WriteLine();
            }
        }
    }
}