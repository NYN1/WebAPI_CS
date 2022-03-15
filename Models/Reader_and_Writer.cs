using Newtonsoft.Json;


namespace Test_integrate_task1_2.Models
{
    public class Reader_and_Writer
    {
        public Dictionary<string, Account> dataReader(string path_i)
        {
            Dictionary<string, Account> a = new Dictionary<string, Account>();
            TextReader reader = null;
            try
            {
                reader = new StringReader(path_i);
                string fileContents = reader.ReadToEnd();
                a = JsonConvert.DeserializeObject<Dictionary<string, Account>>(System.IO.File.ReadAllText(path_i));
                //Account details = a[name];
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }

            return a;
        }

        public void dataWriter(string path_i, Dictionary<string, Account> a)
        {
            StreamWriter writer = null;

            try
            {
                string json = JsonConvert.SerializeObject(a);
                writer = new StreamWriter(path_i);
                writer.Write(json);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
