namespace Test_integrate_task1_2
{
    public class starter
    {
        public static string DataReader(string path)
        {
            string str1 = null;
            if (File.Exists(path))
            {
                str1 = File.ReadAllText(path);
            }
            return str1;
        }


        public static void printer()
        {
            Console.WriteLine("Hello Mate");
        }

        public static Dictionary<string, frameDetails> Path2Dictionary(string path = "C:\\Users\\X6NALLUR\\Downloads\\Frames")
        {
            var directories = Directory.GetDirectories("C:\\Users\\X6NALLUR\\Downloads\\Frames");
            var files_path = TXTfilePath("C:\\Users\\X6NALLUR\\Downloads\\Frames");
            var file = files_path[0];
            Dictionary<string, frameDetails> My_Dictionary = new Dictionary<string, frameDetails>();

            foreach (var fileName in files_path)
            {
                var a = DataReader(fileName);
                var res = a.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var unique_name_list = fileName.Split(new[] { '\\' });
                var l = unique_name_list.Length;
                var unique_name = unique_name_list[l - 2];
                //Console.WriteLine(unique_name);
                //Console.WriteLine('\n');

                List<string> individual_words = new List<string>();
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                foreach (var d in res)
                {
                    var combined = d.Split(new[] { '=' });
                    keyValuePairs.Add(combined[0], combined[1].Replace("\r", ""));
                }
                frameDetails index_test = new frameDetails(unique_name, keyValuePairs);
                My_Dictionary.Add(unique_name, index_test);
            }

            return My_Dictionary;
        }

        public static List<string> TXTfilePath(string path)
        {
            var directories = Directory.GetDirectories("C:\\Users\\X6NALLUR\\Downloads\\Frames");
            List<string> allPaths = new List<string>();
            foreach (string dir1 in directories)
            {
                var dir = Path.Combine(dir1, "metadata.txt");
                allPaths.Add(dir);
            }
            return allPaths;
        }
    }
}
