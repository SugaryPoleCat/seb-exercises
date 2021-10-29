using System;

namespace CSharp_Basics
{
    class SuperClass
    {
        private string userName;

        /// <summary>
        /// This is getter/setter.
        /// </summary>
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        /// <summary>
        /// this creates a new user.
        /// </summary>
        public void makeUser()
        {
            Console.WriteLine("user created");
        }
    }
}
