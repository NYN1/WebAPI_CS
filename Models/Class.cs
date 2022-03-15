namespace Test_integrate_task1_2.Models
{
    public class Class
    {
        public Dictionary<string, frameDetails> My_Dictionary = new Dictionary<string, frameDetails>();

        List<frameDetails> faverate = new List<frameDetails>();

        public Class()
        {
            My_Dictionary = starter.Path2Dictionary();
            Console.WriteLine(My_Dictionary["ZSS-30002"]);

        }
    }
}
