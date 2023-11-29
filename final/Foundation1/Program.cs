using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine();
        List<Video> videosList = new List<Video>();
        
        // Creating video 1
        List<Comment> comments = new List<Comment>();
        Video video1 = new Video();
        video1._author = "CIT";
        video1._title ="C# Abstraction example Tutorial part1/3";
        video1._length = 350;
        Comment comment1 = new Comment();
        comment1._name = "George Billard";
        comment1._text = "Great tutorial. Thanks";
        comments.Add(comment1);
        Comment comment2 = new Comment();
        comment2._name = "Michael Wolf";
        comment2._text = "It helped a lot. Thanks from Canada";
        comments.Add(comment2);
        Comment comment3 = new Comment();
        comment3._name = "Roberto Miranda";
        comment3._text = "Awesome job :)";
        comments.Add(comment3);
        video1._comments = comments;
        videosList.Add(video1);
        // Creating video 2
        List<Comment> comments2 = new List<Comment>();
        Video video2 = new Video();
        video2._author = "Ambient Cinematics";
        video2._title ="Work & Study with Spider-Man";
        video2._length = 3600;
        Comment comment21 = new Comment();
        comment21._name = "@Spiderboy16";
        comment21._text = "This sounds amazing really captures the feeling of Spider-Man thinking to himself and even talking to others";
        comments2.Add(comment21);
        Comment comment22 = new Comment();
        comment22._name = "@eedvard6014";
        comment22._text = "It still amazes me how Spider-Man keeps having a effect on me, even at an adult.";
        comments2.Add(comment22);
        Comment comment23 = new Comment();
        comment23._name = "@DekeRadio";
        comment23._text = "My god, this is beautiful.   I've been reading Spider-Man comics for more than 40 years.";
        comments2.Add(comment23);
        video2._comments = comments2;
        videosList.Add(video2);
         // Creating video 3
        List<Comment> comments3 = new List<Comment>();
        Video video3 = new Video();
        video3._author = "Major League Soccer";
        video3._title ="HIGHLIGHTS: Cruz Azul vs. Inter Miami CF | July 21, 2023 (Lionel Messi's Inter Miami Debut)";
        video3._length = 4880;
        Comment comment31 = new Comment();
        comment31._name = "@luiscaetano6184";
        comment31._text = "This was his very first debut goal of his career. He is finishing up the side missions now.";
        comments3.Add(comment31);
        Comment comment32 = new Comment();
        comment32._name = "@TransHippie";
        comment32._text = "I gotta say, Messi looks happier in Miami pink than he ever did in PSG blue.Good for him.";
        comments3.Add(comment32);
        Comment comment33 = new Comment();
        comment33._name = "@purwantiallan5089";
        comment33._text = "Messi's debut with Inter Miami already being this INSANE. THE GOAT!";
        comments3.Add(comment33);
        Comment comment34 = new Comment();
        comment34._name = "@user-ll2yj7dv3h";
        comment34._text = "What a way to rejuvenate my football viewing! Thank you MLS for signing Messi.";
        comments3.Add(comment34);
        video3._comments = comments3;
        videosList.Add(video3);
           // Creating video 4
        List<Comment> comments4 = new List<Comment>();
        Video video4 = new Video();
        video4._author = "Bro Code";
        video4._title ="Python Full Course for free";
        video4._length = 7200;
        Comment comment41 = new Comment();
        comment41._name = "@Strawbed";
        comment41._text = "Look at this man :-He make an actual good tutorial - He makes a whole a*s 12 hours tutorial";
        comments4.Add(comment41);
        Comment comment42 = new Comment();
        comment42._name = "@markhackney3305";
        comment42._text = "This tutorial was not only better than my college material, but time-lined almost identically.";
        comments4.Add(comment42);
        Comment comment43 = new Comment();
        comment43._name = "@jimtanner9091";
        comment43._text = "One of the best intro reviews of Python I’ve seen for some time.";
        comments4.Add(comment43);
        Comment comment44 = new Comment();
        comment44._name = "@jaglinuxmint";
        comment44._text = "12 hours of pure gem of knowledge, explained very well. Thanks a lot bro!";
        comments4.Add(comment44);
        video4._comments = comments4;
        videosList.Add(video4);

        //Displaying videos from the List
        
        foreach(Video v in videosList)
        {
            Console.WriteLine($"Title: {v._title}\nAuthor: {v._author}\nLength: {v._length} seconds\nNumber of comments: {v.CountComment()}");
            Console.WriteLine("See the comments below:");
            foreach(Comment c in v._comments)
            {
                Console.WriteLine($"    {c._name} - {c._text}");
            }
            Console.WriteLine();
        }
    }
}