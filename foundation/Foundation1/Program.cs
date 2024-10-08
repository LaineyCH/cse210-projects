using System;
using Foundation1;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video howToDigitise = new Video("Using an iPad and Apple Pencil to Digitise Machine Embroidery Designs", "Elaine Henson", 3737);
        Video zipperJig = new Video("Zipper Jig - How to use ESL's Zipper Jig", "Elaine's Sweet Life", 260);
        Video diagPouch = new Video("Diagonal Pouch Workshop", "Elaine Henson", 3624);
        
        howToDigitise.AddComment("@suescholz5993", "Fantastic idea.  Could you use this method with Brother P E Design and an IPad and Apple Pencil?  I am fascinated by Edge to Edge Quilting but find the mouse a little hard to digitise my drawings.");
        howToDigitise.AddComment("@GracefulEmbroidery", "Fascinating to watch. I must try this. How does this work for fill patterns?");
        howToDigitise.AddComment("@jacobbenavente1011", "So technically, we cannot use our iPads to digitize / be able to put our designs to our embroidery machines ?");
        howToDigitise.AddComment("@JBDacasinJr", "that was amazing to watch from start to finish.  Thank you for sharing.");
        howToDigitise.AddComment("@CapricornDayz", "Do you have to stay close to the PC when drawing on the ipad or can you go into another room?");
        
        zipperJig.AddComment("@dianeperkins9294", "Brilliant little tool. Love it \u2764");
        zipperJig.AddComment("@ritamills434", "Where can I buy one  of these please");
        zipperJig.AddComment("@mousegirl42", "I bought one of these for all my sewing friends, such a useful tool!");
        
        diagPouch.AddComment("@kathleenchamp3764", "\ud83d\ude0aHelllo Elaine.. WHAT A FUN BAG TO MAKE AND SHARE!!\n I just wanted to pop in and say Thank you ever so much !! This is a fabulous pattern. It was ever so kind of you to share. \nSo very thoughtful! I did try to send you a message in the download but it wasn't allowing me to. Thusly, I jumped right over to make sure you would get the note. \nThese days , especially, I think it is critical to let those who've taken the time in sharing of their time.. creativity. Doing a  tutorial let alone sharing the pattern, to know  that your thoughtfulness and kindness are not taken lightly.  It's greatly appreciated. And in fact it's blessed me and I have no doubts it will be a blessing to so many..  Thank You Again\ud83d\ude0a\nHave a delightful fall.. keep stitching \u263a");
        diagPouch.AddComment("@joycemonaco-olivas1483", "Could you speak up please");
        diagPouch.AddComment("@sewmama28", "Can I make this pouch bigger? I need one big enough to carry a rice pot.");
        diagPouch.AddComment("@nocomment321", "I can't download the pattern, please send it to me.");
        
        videos.Add(howToDigitise);
        videos.Add(zipperJig);
        videos.Add(diagPouch);

        Console.Clear();
        foreach (Video video in videos)
        {
            Console.WriteLine(" ");
            video.Display();
            Console.WriteLine(" ");
            Console.WriteLine("          ----------------");
        }
    }
}