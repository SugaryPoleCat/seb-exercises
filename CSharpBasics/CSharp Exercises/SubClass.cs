using System;

namespace CSharp_Basics
{
    /// <summary>
    /// Sub class of the superclass
    /// </summary>
    class SubClass : SuperClass
    {
        // this will add new functionality to the supr class.
        private int userAge;

        /// <summary>
        /// St and get the user age.
        /// </summary>
        public int UserAge
        {
            get
            {
                return this.userAge;
            }
            set
            {
                this.userAge = value;
            }
        }

        /// <summary>
        /// Displays the user.
        /// </summary>
        public void displayUser()
        {
            Console.WriteLine("user: " + UserName + " and age: " + userAge);
        }
    }
}
