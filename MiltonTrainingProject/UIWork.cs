using System;
using System.Windows.Forms;
using Models;
using PServices;
using System.Collections.Generic;

namespace MiltonTrainingProject
{
    public static class UIWork
    {
        /// <summary>
        /// Adds an Employee to a Grid
        /// </summary>
        public static void AddPersonToGrid(this DataGridView g, Person p)
        {
           
            g.Rows[g.Rows.Add(p.FirstName, 
                                p.LastName, 
                                p.DOB.ToShortDateString(), 
                                p.SSN,
                                Enum.GetName(typeof(Gender), 
                                p.Gender), 
                                Enum.GetName(typeof(MaritalStatus), 
                                p.MaritalStatus))].Tag = p.ID;
        }
        /// <summary>
        /// Adds an Employee Collection to a Grid
        /// </summary>
        public static void AddPersonToGrid(this DataGridView g, List<Person> person)
        {
            foreach (Person p in person)
            {
                g.AddPersonToGrid(p);
            }
        }
        public static void AddItemsToBox(this ComboBox cb, string[] names, int[] values)
        {
            
            for (int i = 0; i < names.Length; i++)
            {
                cb.Items.Add(new ComboBoxItem(names[i], values[i]));
               
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }

            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }
        }
    }
}
