using System;

namespace WorkingWithStringsPart1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            //string myString = "Go to your c:\\ drive";

            //string myString = "My \" so called\" life";
            //string myString = "What if I \n need a new line";

            //string myString = string.Format("{0}!", "Bonzai");

            //string myString = string.Format("make: {0} (Model: {1}", "BMW", "7601I");
            //string myString = string.Format("{0:C}", 123.45);

            //string myString = string.Format("{0:N}", 123456789);
            //string myString = string.Format("{0:P}" , .123);
            //	string myString = string.Format("Phone Nimber: {0:(###) ### ####}", 1234567890);

           string myString = "That summer we took threes across the board";
            // myString = myString.Substring(1, 6);
            //myString = myString.ToUpper();
            //  myString = myString.Replace(" ","--"); 


            myString = String.Format("lengtht before: {0} -- After:D {1} ",
                                     myString.Length, myString.Trim().Length);                                    
			Console.WriteLine(myString);
			Console.ReadLine();

		}
	}
}
