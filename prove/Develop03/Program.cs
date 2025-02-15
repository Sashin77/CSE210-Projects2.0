using System;
using System.Collections.Generic;

class Scripture
{
    public string Reference { get; set; }
    public string Text { get; set; }
    private HashSet<int> hiddenWords;

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        hiddenWords = new HashSet<int>();
    }

    public void HideWords()
    {
        var words = Text.Split(' ');
        var random = new Random();
        int numToHide = Math.Min(3, words.Length);

        hiddenWords.Clear();

        while (hiddenWords.Count < numToHide)
        {
            int wordIndex = random.Next(words.Length);
            hiddenWords.Add(wordIndex);
        }
    }

    public void Reset()
    {
        hiddenWords.Clear();
    }

    public string GetDisplayText()
    {
        var words = Text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (hiddenWords.Contains(i))
            {
                words[i] = "____";
            }
        }

        return $"{Reference}: {string.Join(" ", words)}";
    }
}

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture("Romans 8:28", "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."),
            new Scripture("Isaiah 41:10", "Fear thou not; for I am with thee: be not dismayed; for I am thy God: I will strengthen thee; yea, I will help thee; yea, I will uphold thee with the right hand of my righteousness."),
            new Scripture("Matthew 11:28-30", "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
            new Scripture("Psalm 23:1", "The Lord is my shepherd; I shall not want."),
            new Scripture("James 1:5", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."),
            new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me."),
            new Scripture("2 Timothy 1:7", "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."),
            new Scripture("Hebrews 11:1", "Now faith is the substance of things hoped for, the evidence of things not seen."),
            new Scripture("2 Nephi 2:25", "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture("Mosiah 2:17", "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture("Ether 12:27", "If men come unto me I will show unto them their weakness."),
            new Scripture("Alma 37:6", "By small and simple things are great things brought to pass."),
            new Scripture("2 Nephi 31:20", "Wherefore, ye must press forward with a steadfastness in Christ."),
            new Scripture("3 Nephi 12:48", "Therefore I would that ye should be perfect even as I, or your Father who is in heaven is perfect."),
            new Scripture("Moroni 10:4", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true."),
            new Scripture("Mosiah 18:9", "Ye are willing to mourn with those that mourn; yea, and comfort those that stand in need of comfort."),
            new Scripture("Alma 5:14", "Have ye spiritually been born of God? Have ye received his image in your countenances?"),
            new Scripture("Helaman 5:12", "Remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation.")
        };

        Scripture currentScripture = scriptures[0];

        while (true)
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("          Scripture Memorizer         ");
            Console.WriteLine("======================================");
            Console.WriteLine("\nCurrent Scripture:\n");
            Console.WriteLine(currentScripture.GetDisplayText());

            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("               MENU                  ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1 - Hide words");
            Console.WriteLine("2 - Reset scripture");
            Console.WriteLine("3 - Switch scripture");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("--------------------------------------");
            Console.Write("\nChoose an option: ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                currentScripture.HideWords();
            }
            else if (input == "2")
            {
                currentScripture.Reset();
            }
            else if (input == "3")
            {
                Console.WriteLine("\nChoose a scripture:");
                for (int i = 0; i < scriptures.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {scriptures[i].Reference}");
                }

                Console.Write("\nEnter number: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= scriptures.Count)
                {
                    currentScripture = scriptures[choice - 1];
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye! Dont forget to pray");
                break;
            }
            else
            {
                Console.WriteLine("Error with that choice. Press Enter to try again.");
                Console.ReadLine();
            }
        }
    }
}
