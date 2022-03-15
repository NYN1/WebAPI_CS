namespace Test_integrate_task1_2
{
	public class Account
	{
		public string name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string frame_size { get; set; }
		public string age { get; set; }
		public List<string> faverateFrames { get; set; }
		public Stack<string> orderHistory { get; set; }
		//public string base64 { get; set; }
		//public Dictionary<string, frameDetails> name2details { get; set; }

		public Account()
		{

		}


		public Account(string Name, string Password, string Email, string Frame_size, string Age, List<string> FaverateFrame, Stack<string> OrderHistory)//, Dictionary<string, frameDetails> name2Details)
		{
			name = Name;
			password = Password;
			email = Email;
			frame_size = Frame_size;
			age = Age;
			faverateFrames = FaverateFrame;
			orderHistory = OrderHistory;
			//name2details = name2Details;
		}

		/*public void SavetoDisk()
		{
			string path_i = "C:\\Users\\X6NALLUR\\Desktop\\Customer\\" + name + ".txt";
			try
			{
				if (File.Exists(path_i))
				{
					File.Delete(path_i);
				}

				using (StreamWriter writetext = new StreamWriter(path_i))
				{
					writetext.WriteLine("Name :" + name);
					writetext.WriteLine("Password :" + password);
					writetext.WriteLine("Email :" + email);
					writetext.WriteLine("Age :" + age);

					string names_frames = "";
					foreach (Values_dict value in faverateFrames)
					{
						names_frames = names_frames + "||" + value.uniqueName.ToString();
					}
					writetext.WriteLine("Faverate Frames :" + names_frames);

					string orderhistory = "";
					foreach (Values_dict value in orderHistory)
					{
						orderhistory = value.uniqueName.ToString() + "||" + orderhistory;
					}
					writetext.WriteLine("OrderHistory: " + orderhistory);
				}
			}

			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

		}

		public void addFrameToFaverate(string FrameNameUnique)
		{
			faverateFrames.Add(name2details[FrameNameUnique]);
			Console.WriteLine($"{FrameNameUnique} has been added to Faverates");
			SavetoDisk();

		}

		public void removeFromFaverate(string FrameNameUnique)
		{
			faverateFrames.Remove(name2details[FrameNameUnique]);
			Console.WriteLine($"{FrameNameUnique} has been removed from Faverates");
			SavetoDisk();
		}

		public void MakeOrder(string FrameNameUnique)
		{
			orderHistory.Push(name2details[FrameNameUnique]);
			Console.WriteLine($"{FrameNameUnique} has been ordered");
			SavetoDisk();

		}*/
	}
}