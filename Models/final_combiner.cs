namespace Test_integrate_task1_2.Models
{
    public class final_combiner
    {
        //public Dictionary<string, Values_dict> My_Dictionary = new Dictionary<string, Values_dict>();

        public Dictionary<string, frameDetails> GetDictionary()
        {
            return starter.Path2Dictionary();
        }

        public frameDetails accountDetails(string name)
        {
            var dict = GetDictionary();
            return dict[name];
        }
    }
}