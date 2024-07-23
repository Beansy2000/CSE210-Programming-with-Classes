namespace YoutubeComments{
    public class Comment{
        public string user;
        public string commentText;
        private List<string> users = new List<string>{"BananaMan123","Apple-456","789Orange","0Watermelon0"};
        private List<string> commentTexts = new List<string>{"Great Video!","Subscribed!","I can't believe it!","I've rewatched 5 times."};

        public Comment(){
            Random rand = new();
            this.user = users[rand.Next(0,3)];
            this.commentText = commentTexts[rand.Next(0,3)];
        }
    }
}