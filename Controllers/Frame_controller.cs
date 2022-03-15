using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Test_integrate_task1_2.Models;

namespace Test_integrate_task1_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    
    [EnableCors()]
    public class Frame_conroller : ControllerBase
    {
        public Dictionary<string, frameDetails> My_Dictionary = new Dictionary<string, frameDetails>();
        //string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + "customer" + ".json";


        [HttpGet()]
        public frameDetails[] CompleteFrameDetails()
        {
            My_Dictionary = starter.Path2Dictionary();
            var a = My_Dictionary.Keys;
            List<int> lst = new List<int> { 10, 20, 10, 34, 113 };
            List<frameDetails> test_ans = new List<frameDetails>();
            //frameDetails[] test_ans = Array.Empty<frameDetails>();

            foreach (string s in a)
            {
                test_ans.Add(My_Dictionary[s]);
            }
            frameDetails[] a11 = test_ans.ToArray();

            return a11;
        }

        [HttpGet("{id}")]
        public frameDetails[] GetMetaData(string id)
        {
            My_Dictionary = starter.Path2Dictionary();
            var a = My_Dictionary[id];
            frameDetails[] test_ans = { a };
            return test_ans;
        }

        [HttpPost("{acc_det}")]
        public Account SetNewAccount(Account acc_det)
        {
            My_Dictionary = starter.Path2Dictionary();
            string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + "customer" + ".json";
            Dictionary<string,Account> a = new Dictionary<string, Account>();

            Reader_and_Writer reader_And_Writer = new Reader_and_Writer();

            try
            {
                a = reader_And_Writer.dataReader(path_i);
                a.Add(acc_det.name, acc_det);
                reader_And_Writer.dataWriter(path_i, a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return acc_det;
        }

        //[Route("Order")]
        [Route("AddOrder/{name}/{order}")]
        [HttpPut]
        public void addOrder(string name, string order)
        {
            string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + "customer" + ".json";
            Dictionary<string,Account> final_dict = new Dictionary<string,Account>();

            Dictionary<string, Account> a = new Dictionary<string, Account>();

            Reader_and_Writer reader_And_Writer = new Reader_and_Writer();
            try
            {
                a = reader_And_Writer.dataReader(path_i);
                Stack<string> details = a[name].orderHistory;
                details.Push(order);
                a[name].orderHistory = details;
                reader_And_Writer.dataWriter(path_i, a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        [Route("faverate_add/{name}/{faverateframe_}")]
        [HttpPut]
        public void addfaverateFrame(string name, string faverateframe_)
        {
            string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + "customer" + ".json";
            Dictionary<string, Account> final_dict = new Dictionary<string, Account>();

            //JsonObjectAttribute fileContents = "";
            Dictionary<string, Account> a = new Dictionary<string, Account>();
            Reader_and_Writer reader_And_Writer = new Reader_and_Writer();

            try
            {
                TextReader reader = null;
                a = reader_And_Writer.dataReader(path_i);
                List<string> details = a[name].faverateFrames;
                details.Add(faverateframe_);
                a[name].faverateFrames = details;
                reader_And_Writer.dataWriter(path_i, a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpDelete("name")]
        public void DeleteFile(string name)
        {
            string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + "customer" + ".json";
            Dictionary<string, Account> final_dict = new Dictionary<string, Account>();

            //JsonObjectAttribute fileContents = "";
            Dictionary<string, Account> a = new Dictionary<string, Account>();
            Reader_and_Writer reader_And_Writer = new Reader_and_Writer();

            try
            {
                a = reader_And_Writer.dataReader(path_i);
                a.Remove(name);
                reader_And_Writer.dataWriter(path_i, a);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}