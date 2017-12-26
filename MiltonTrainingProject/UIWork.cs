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
        public static void AddPersonToGrid(this DataGridView g, PersonModel p)
        {
           
            g.Rows[g.Rows.Add(p.LastName, 
                                p.FirstName, 
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
        public static void AddPersonToGrid(this DataGridView g, List<PersonModel> person)
        {
            foreach (PersonModel p in person)
            {
                g.AddPersonToGrid(p);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="c"></param>
        public static void AddCollegeToGrid(this DataGridView g, College c)
        {
            g.Rows[g.Rows.Add(c.Name, c.Street, c.City, Enum.GetName(typeof(State), c.State), c.Zip)].Tag = c.ID;
        }

        /// <summary>
        /// Adds a Collection of Colleges to a Grid
        /// </summary>
        public static void AddCollegeToGrid(this DataGridView g, List<College> colleges)
        {
            foreach (College c in colleges)
            {
                g.AddCollegeToGrid(c);
            }
        }
    
    public static void AddItemsToBox(this ComboBox cb, string[] names, int[] values)
        {
            
            for (int i = 0; i < names.Length; i++)
            {
                cb.Items.Add(new ComboBoxItem(names[i], values[i]));
               
            }
        }

        /// <summary>
        /// Adds list of colleges to a combobox
        /// </summary>
        public static void AddCollegesToBox(this ComboBox cb, List<College> collegeList)
        {
            foreach (College c in collegeList)
            {
                cb.Items.Add(c);
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
        public static PersonModel GetPersonFromGrid(this DataGridViewRow row)
        {
            PersonModel p = new PersonModel();
            p.ID = (int)row.Tag;
            p.LastName = row.Cells[1].Value.ToString();
            p.FirstName = row.Cells[0].Value.ToString();           
            p.SSN = (int)row.Cells[3].Value;
            p.DOB = Convert.ToDateTime(row.Cells[2].Value);
            p.Gender = row.Cells[4].Value.ToString().GetEnumFromString<Gender>();
            p.MaritalStatus = row.Cells[5].Value.ToString().GetEnumFromString<MaritalStatus>();            
            return p;
        }
    }
}
