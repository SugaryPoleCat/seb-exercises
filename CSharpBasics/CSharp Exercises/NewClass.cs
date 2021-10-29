namespace CSharp_Basics
{
    class NewClass
    {
        // Class method
        private string username;
        public static int userCount;

        /// <summary>
        /// THis is constructor. It creates a new object from this class.
        /// </summary>
        /// <param name="aUsername">The name.</param>
        public NewClass(string aUsername)
        {
            this.username = aUsername;
            // add to the user count, upon new user creation
            userCount++;
        }

        /// <summary>
        /// This gets the username.
        /// </summary>
        /// <returns>The username as string.</returns>
        public string getUsername()
        {
            return username;
        }

        /// <summary>
        /// Exactly the same as getUsername, when GETTING the username, but different, because it also lets you set a NEW username for hte user.
        /// </summary>
        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                // Value is used, when you do this:
                // SuperClass sc = new SuperClass();
                // sc.Username = "mark";
                // value is "mark" in this case.
                this.username = value;
            }
        }
    }
}
