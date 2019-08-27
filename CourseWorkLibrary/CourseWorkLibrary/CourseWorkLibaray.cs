using System;

//**********************************************************//
// File: CourseWorkLibaray.cs                               //
//                                                          //
// Purpose: Contains the class definitions for CourseWork.  //
//          These Class will be used as test classes.       //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//**********************************************************//

namespace CourseWorkLibrary
{
    //First Class Category takes name and percent variables
    public class Category{

        //Member Variables
        private string name;
        private double percentage;

        //Constructor
        public Category()
        {

        }

        //Using C# Properties with string
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //Using C# Properties with double 
        public double Percentage
        {
            get
            {
                return percentage;
            }

            set
            {
                percentage = value;
            }
        }

       //To DO: ToString method
    }

    //Second Class takes name, description & categoryName variables
    public class Assignment
    {
        //Memeber Variables 
        private string name;
        private string description;
        private string categoryName;

        //Constructor
        public Assignment()
        {

        }

        //Get & Set using C# properties 
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;

            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }

        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }

        //TO DO: ToString Method 

    }

    //Class Created for testing 
    public class CourseWorkUnitTesting
    {
        public void UnitTestCategory()
        {
            //TO DO: declare instance of category
            //       perform testing on the properties
            //       print pass/fail message
        }

        public void UnitTestAssignment()
        {
            //TO DO: declare instance of assigment
            //       perform testing on the properties
            //       print pass/fail message
        }
    }
}
