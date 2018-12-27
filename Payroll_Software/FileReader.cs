using System;
using System.Collections.Generic;
using System.IO;
namespace Payroll_Software
{
    public class FileReader
    {
        
        public FileReader()
        {
        }
        public List<Staff> ReadFile()
        {
            List<Staff> MyStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "Staff.txt";
            string[] separator = {", "};
            if (File.Exists(path)){
                using (StreamReader sr = new StreamReader(path)){
                    while(!sr.EndOfStream){
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        if(result[1] == "Manager"){
                            MyStaff.Add(new Manager(result[0]));
                        }
                        else if (result[1] == "Admin"){
                            MyStaff.Add(new Admin(result[0]));
                            sr.Close();
                        }
                        else {
                            Console.WriteLine("File does not exist");
                        }
                    }
                }
            }
            return MyStaff;
        }
    }
}
