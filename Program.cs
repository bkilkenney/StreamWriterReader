using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            

namespace StreamWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {

//**************************************This reads to the end of the txt file with an absolute path**********************************

            StreamReader sw = new StreamReader(@"C:\Users\bkilkenney\Documents\Visual Studio 2015\Projects\ThisIsATextFile.TXT");

            string readerString = sw.ReadToEnd();

            Console.WriteLine(readerString);

            Console.ReadLine();


//**********************************This reads just the first line******************************************************************

            StreamReader sw2 = new StreamReader(@"C:\Users\bkilkenney\Documents\Visual Studio 2015\Projects\ThisIsATextFile.TXT");

            string readerLine = sw2.ReadLine();

            Console.WriteLine(readerLine);

            Console.ReadLine();


//*******************************************Another way to create an absolute path********************************************************


            StreamReader sw3 = new StreamReader("C:\\Users\\bkilkenney\\Documents\\Visual Studio 2015\\Projects\\ThisIsATextFile.TXT");

            string readerString2 = sw3.ReadToEnd();

            Console.WriteLine(readerString2);

            Console.ReadLine();


//*******************************************Creating a relative path***************************************************


//This example not working, need to figure out what's wrong with the relative path

            StreamReader sw4 = new StreamReader("..\\..\\ThisIsATextFile.TXT");

            string readerLine2 = sw4.ReadLine();

            Console.WriteLine(readerLine2);

            Console.ReadLine();




        }
    }
}
