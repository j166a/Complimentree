namespace Complimentree.DataModels
{
    public class Compliment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Compliment(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public static string GetCompliment()
        {
            Random rand = new Random();
            string[] compliments = {"You may not be evergreen, but you are to me.",
                "I bet squirrels consider you prime real estate.",
                "You're so down to earth.",
                "You're very grounded.",
                "Your leaves are soothing.",
                "You sway nicely in the wind.",
                "You're blooming brilliant.",
                "You're really good at standing still and doing nothing.",
                "Let's get to the root of your beauty.",
                "I will never leaf you.",
                "You've really branched out lately.",
                "You provide the perfect amount of shade on a hot day.",
                "I'm really pine-ing for you." };


            return compliments[rand.Next(compliments.Length)];
        }
    }
}
