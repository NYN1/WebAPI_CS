using System.Drawing;

namespace Test_integrate_task1_2
{
    public class frameDetails
	{
		public string uniqueName { get; set; }
		public string? brandName { get; set; }
		public string? frameModel { get; set; }
		public string? frameColor { get; set; }
		public string? varientGroup { get; set; }
		public string? materialType { get; set; }
		public string? RRP { get; set; }
		public string? RRPCurrency { get; set; }
		public string? frameColourDescription { get; set; }
		public string? frameSize { get; set; }
		public string? base64emb { get; set; }

		public frameDetails()
		{

		}

		public static string ImagePathToBase64(string path)
		{
			using System.Drawing.Image image = System.Drawing.Image.FromFile(path);
			using MemoryStream m = new MemoryStream();
			image.Save(m, image.RawFormat);
			byte[] imageBytes = m.ToArray();
			string base64String = Convert.ToBase64String(imageBytes);
			return base64String;
		}

		public override bool Equals(object? obj)
        {
            var other = obj as frameDetails;
			return true;
        }

        public frameDetails(string unique, Dictionary<string, string> myDict)
		{
			uniqueName = unique;
			try
			{
				brandName = myDict["Brand Name"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				frameModel = myDict["Frame Model Name"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				frameColor = myDict["Frame Colour"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				varientGroup = myDict["Variant Group"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				materialType = myDict["Material Type"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				RRP = myDict["RRP"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				RRPCurrency = myDict["RRP Currency"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				frameColourDescription = myDict["Frame Colour Description"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}

			try
			{
				frameSize = myDict["Frame size"];
			}
			catch (Exception ex)
			{
				//Console.WriteLine(ex.Message);
			}
            try
            {
				string test_path = "C:\\Users\\X6NALLUR\\Downloads\\Frames\\" + uniqueName + "\\Thumbnail.png";
				base64emb = ImagePathToBase64(test_path);
			}
            catch(Exception ex)
            {
				Console.WriteLine(ex.Message);
            }
		}
	}
}
