using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    class User
    {
        private string _userName;
        public string UserName 
        {
            get => _userName;
            set
            {
                while (value.Length < 8)
                {
                    Console.WriteLine("Duzgun UserName Deyeri Daxil. Minimum 8 Simvol Olmalidir");
                    value = Console.ReadLine();
                }

                _userName = value;
            }
        }

        private string _password;
        public string Password 
        {
            get => _password;
            set
            {
                //bool check = true;
                while (/*check*/true)
                {
                    if (value.Length >= 8)
                    {
                        bool checkLower = false;
                        bool checkUpper = false;
                        bool checkDigit = false;

                        foreach (char item in value)
                        {
                            if (char.IsUpper(item))
                            {
                                checkUpper = true;
                            }
                            else if (char.IsLower(item))
                            {
                                checkLower = true;
                            }
                            else if (char.IsDigit(item))
                            {
                                checkDigit = true;
                            }

                            if (checkDigit == true && checkLower == true && checkUpper == true)
                            {
                                _password = value;
                                //check = false;
                                //break;
                                return;
                            }
                        }

                        Console.WriteLine("Duzgun Password Daxil Et. Minimum 1 Boyuk Herf 1 Kicik Herf 1 Reqem Olmalidir");
                        value = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Duzgun Password Daxil Et. Minimum 8 Simvol Olmalidir");
                    value = Console.ReadLine();
                }
            }
        }

        public User(string userName)
        {
            UserName = userName;
        }

    }
}
