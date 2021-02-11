using System.Data;
using SQLite;
using Xamarin.Forms.Maps;

namespace LocalDatabaseTutorial
{
    public class Person
    {
       

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double enlem { get; set; }
        public double boylam { get; set; }
       

        


    }
}