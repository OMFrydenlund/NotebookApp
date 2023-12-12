using System;
using System.Collections.Generic;

namespace PersonalNotebook
{
    public class Notebook 
    {
                      //Dictionary class is built in, provides key/value pairs (each key must be unique)
                      //Used to associate values with keys, look up values based on corresponding keys
   

        private Dictionary<string, Dictionary<int, string>> Year2024;
            
        public Notebook()
        {
            NotebookInstance();
        }

        private void NotebookInstance()
        //define the notebook instance
        {
            //apply layout then compose array of months to refer to (a set of keys, which will also have their own sets of keys(days))
            Year2024 = new Dictionary<string, Dictionary<int, string>>;

            string[] months =
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
                "November", "December"
            };
            //for every month in the month array, create a new Dictionary 
            //loop through months. gpt help?
            foreach (var month in months)
            {
                //what in the f is this
                Year2024[month] = new Dictionary<int, string>();

                for (int day = 1; day <= 7; day++)
                {
                    Year2024[month][day] = "";
                }
            }
        }
    }
}
