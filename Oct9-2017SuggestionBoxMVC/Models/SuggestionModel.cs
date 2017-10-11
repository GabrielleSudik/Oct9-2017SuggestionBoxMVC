using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//here's a whole part we're creating ourselfs.
//started with Models--New--Class
//the following should look (mostly) familiar

namespace Oct9_2017SuggestionBoxMVC.Models
{
    public class SuggestionModel
    {
        private string topic;
        private string suggestion;

        [Key] //this is a new thing. you had to add the library for it to work (with lightbulb)

        public int RecordNum { get; set; }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }

        public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }
        }

        //starting here, you are practicing migration

        public string Name { get; set; }

    }
}