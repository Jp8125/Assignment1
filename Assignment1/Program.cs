using Nancy.Json;
using System;
using System.IO;

class Test
{
public static void Main()
    {
         string path1= @"D:\.net core\mod9\Assignment1\movie.json";
        FileStream fs = new FileStream(path1,FileMode.Open,FileAccess.Read);
        StreamReader sr=new StreamReader(fs);
        var demo = sr.ReadToEnd();
        //Console.WriteLine(demo);
        var resultObject = new JavaScriptSerializer().Deserialize<mv[]>(demo);
        foreach (var item in resultObject)
        {
            Console.WriteLine(item.MovieName);
        }
       
        
    }
}
 public class mv
    {

        public int MovieID;

        public string MovieName;

        public Details Details;

    }
    public class Details
        {
            public string DirectorName;

            public string[] ActorsNames;

            public string VideoLink;
}