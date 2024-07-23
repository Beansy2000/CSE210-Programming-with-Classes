namespace YoutubeComments{
    public class Video{
        public string title;
        public string author;
        private int length;
        public List<Comment> comments = new List<Comment>();
        private List<string> titles = new List<string>{"Carrot Review","Pumpkin Smashing","Zucchini Bread Recipe","Corn Husk Projects"};
        private List<string> authors = new List<string>{"Cowman17","Chicken32","Piggy010","Lamb521"};
        private List<int> lengths = new List<int>{310, 654, 372, 621};

        public Video(){
            Random rand = new Random();
            this.title = titles[rand.Next(0,3)];
            this.author = authors[rand.Next(0,3)];
            this.length = lengths[rand.Next(0,3)];
            AddComments(rand.Next(3,5));
        }
        private void AddComments(int loops){
            for(int i = 0; i < loops; i++){
                Comment comment = new();
                this.comments.Add(comment);
            }
        }
        public (int, int) CalculateVideoTime(){
            int seconds = this.length;
            int minutes = 0;
            while(seconds >= 60){
                minutes += 1;
                seconds -= 60;
            }
            return (minutes, seconds);
        }
    }
}