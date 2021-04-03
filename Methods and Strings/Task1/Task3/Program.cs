using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new method that will remove extra space characters
            //Call the method with the following text:
            //The best  Lorem Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar
            //next adventure  and cajol yar clients   into walking the plank with ev'ry layout!
            //Configure      above, then get yer pirate ipsum...own the high seas,    argh!
            string message = "The    best  Lorem  Ipsum        Generator in all the  sea!" +
                "   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!" +
                "    Configure       above, then get yer pirate ipsum...own the high seas,    argh!";
            static void MessagePurifier(string givenMessage)
            {
                char[] newArray = new char[0];

                bool checker = false;

                givenMessage.ToCharArray();
                foreach(char item in givenMessage)
                {
                    if (item !=' ') 
                    {
                        checker = false;
                    }
                   if(!checker)
                    {
                        
                        Array.Resize(ref newArray, newArray.Length + 1);
                        newArray[newArray.Length - 1] = item;
                        if(item==' ')
                        {
                            checker = true;
                        }

                    }
                 
                }

                foreach(char item in newArray)
                {
                    Console.Write(item);
                }
            }
            MessagePurifier(message);
        }
    }
}
