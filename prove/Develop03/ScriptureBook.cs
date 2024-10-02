namespace Develop03;

public class ScriptureBook
{
    private List<Scripture> _scriptures;

    // CONSTRUCTOR
    public ScriptureBook()
    {
        _scriptures = new List<Scripture>();
        
        // add scriptures to the book
        
        Reference reference1 = new Reference("2 Nephi", 2, 25);
        Verse verse1 = new Verse("Adam fell that men might be; and men are, that they might have joy.");
        List<Verse> verses1 = new List<Verse>();
        verses1.Add(verse1);
        Scripture scripture1 = new Scripture(reference1, verses1);
        _scriptures.Add(scripture1);
        
        Reference reference2 = new Reference("2 Nephi", 9, 28, 29);
        List<Verse> verses2 = new List<Verse>();
        Verse verse2A = new Verse("O that cunning plan of the evil one! O the vainness, and the frailties, and the foolishness of men! When they are learned they think they are wise, and they hearken not unto the counsel of God, for they set it aside, supposing they know of themselves, wherefore, their wisdom is foolishness and it profiteth them not. And they shall perish.");
        verses2.Add(verse2A);
        Verse verse2B = new Verse("But to be learned is good if they hearken unto the counsels of God.");
        verses2.Add(verse2B);
        Scripture scripture2 = new Scripture(reference2, verses2);
        _scriptures.Add(scripture2);
        
        Reference reference3 = new Reference("2 Nephi", 31, 19, 20);
        List<Verse> verses3 = new List<Verse>();
        Verse verse3A = new Verse("And now, my beloved brethren, after ye have gotten into this strait and narrow path, I would ask if all is done? Behold, I say unto you, Nay; for ye have not come thus far save it were by the word of Christ with unshaken faith in him, relying wholly upon the merits of him who is mighty to save.");
        verses3.Add(verse3A);
        Verse verse3B = new Verse("Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
        verses3.Add(verse3B);
        Scripture scripture3 = new Scripture(reference3, verses3);
        _scriptures.Add(scripture3);
        
        Reference reference4 = new Reference("Alma", 7, 11, 13);
        List<Verse> verses4 = new List<Verse>();
        Verse verse4A = new Verse("And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.");
        verses4.Add(verse4A);
        Verse verse4B = new Verse("And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.");
        verses4.Add(verse4B);
        Verse verse4C = new Verse("Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.");
        verses4.Add(verse4C);
        Scripture scripture4 = new Scripture(reference4, verses4);
        _scriptures.Add(scripture4);
        
        Reference reference5 = new Reference("Helaman", 5, 2);
        Verse verse5 = new Verse("And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.");
        List<Verse> verses5 = new List<Verse>();
        verses5.Add(verse5);
        Scripture scripture5 = new Scripture(reference5, verses5);
        _scriptures.Add(scripture5);
    }
    
    // METHODS
    public Scripture GetSelectedScripture(int index) => _scriptures[index];

    public void DisplayReferenceList()
    {
        int number = 1;
        foreach (Scripture s in _scriptures)
        {
            Console.Write($"{number}. ");
            s.GetReference.Display();
            Console.WriteLine("");
            number++;
        }
    }
}