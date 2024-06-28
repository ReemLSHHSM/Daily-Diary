using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryManager
{
    internal class Entry
    {

        private string date;
        private string content;

        //get and set date
        public string Date
        {

            get
            {
             return date;

            }
            set
            {
                date = value;
            }
        }

        //get and set content

        public string Content
        {
            get
            {

                return content;
            }
            set
            {
                content = value;
            }
        }


        //constructor
        public Entry(string date, string content)
        {
            this.date = date;
            this.content = content;
        }




    }
}