using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    internal class DailyDiary
    {

       // public string path = Path.Combine(Environment.CurrentDirectory, "diary.txt");

           

        //ReadContent
    public string Readcontent(string date,string content,string path)
        {
            int len = 0;
            //if (File.Exists(path))
            //{
               // Console.WriteLine(File.ReadAllText(path));
                var arr=File.ReadAllLines(path);
                for(int i = 0; i < arr.Length; i++)
                {
                    if (!string.IsNullOrEmpty(arr[i]))
                    {
                        len++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if(len == 0)
                {
                    Console.WriteLine("Your diary is empty :(");
                }
                else
                {

                    for(int i = 0; i < arr.Length; i+=2)
                    {
                        if (arr[i] == date)
                        {
                            Console.WriteLine($"{arr[i]} \n {arr[i+1]}\n");
                            return $"{arr[i]} \n {arr[i + 1]}\n";
                        }
                        else
                        {
                            Console.WriteLine("Sorry this entery does'nt exist :( \n");
                            return "Sorry this entery does'nt exist :( \n";
                        }
                    }
                }
           // }
            //else
            //{
            //    Console.WriteLine("path doesnt exitst \n");
            //    return "";
            //}


            return "";
            
        }

        //Write in diary
        public string Addcontent(string date, string content, string path) {

            string content_toadd;
            if (File.Exists(path)) {

                content_toadd = $"{date} \n {content}";

                File.AppendAllText(path,content_toadd);
                Console.WriteLine("Content added successfully :)");
                return "Content added successfully :)";

            }

            return "";
        }

        //Delete Content
        public string Deletecontent(string date,string content, string path)
        {
          
           var arr = File.ReadAllLines(path);//store all lines
            //var new_arr=new string[arr.Length-2];
            // List<string> files = new List<string>();
            List<string> files = arr.ToList();

            if (files.Contains(date) == true)
            {
                int index=files.IndexOf(date);//find index of the date of the entry

                files.RemoveAt(index);//remove the date
                files.RemoveAt(index+1);//remove the entry

                arr=files.ToArray();//converted to an array to use it with File
                File.WriteAllLines(path,arr);
                Console.WriteLine("Entry deleted successfully :)");
                return "Entry deleted successfully :)";
            }
            else
            {
                Console.WriteLine("Entry does'nt exist :|");
                return "Entry does'nt exist :|";
            }

       
        }

        //Count lines
        public int count_lines(string path)
        {
            int len = 0;
            var arr = File.ReadAllLines(path);
            for (int i = 0; i < arr.Length; i++)
            {
                if (!string.IsNullOrEmpty(arr[i]))
                {
                    len++;
                }
                else
                {
                    continue;
                }
            }
            return len;
        }
    }
}
