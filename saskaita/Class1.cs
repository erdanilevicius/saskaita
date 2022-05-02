﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace saskaita
{


    internal class Class1
    {

    }
    class RPG
    {

        static string alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string alphaLow = "abcdefghijklmnopqrstuvwxyz";
        static string numerics = "1234567890";
        static string special = "@#$-=/";
        string allChars = alphaCaps + alphaLow + numerics + special;
        Random r = new Random();

        public string GenerateRandomStrongPassword(int length)
        {
            String generatedPassword = "";
            if (length < 4)
                throw new Exception("Number of characters should be greater than 4.");
            int lowerpass, upperpass, numpass, specialchar;
            string posarray = "0123456789";
            if (length < posarray.Length)
                posarray = posarray.Substring(0, length);
            lowerpass = getRandomPosition(ref posarray);
            upperpass = getRandomPosition(ref posarray);
            numpass = getRandomPosition(ref posarray);
            specialchar = getRandomPosition(ref posarray);


            for (int i = 0; i < length; i++)
            {
                if (i == lowerpass)
                    generatedPassword += getRandomChar(alphaCaps);
                else if (i == upperpass)
                    generatedPassword += getRandomChar(alphaLow);
                else if (i == numpass)
                    generatedPassword += getRandomChar(numerics);
                else if (i == specialchar)
                    generatedPassword += getRandomChar(special);
                else
                    generatedPassword += getRandomChar(allChars);
            }
            return generatedPassword;
        }

        private string getRandomChar(string fullString)
        {
            return fullString.ToCharArray()[(int)Math.Floor(r.NextDouble() * fullString.Length)].ToString();
        }

        private int getRandomPosition(ref string posArray)
        {
            int pos;
            string randomChar = posArray.ToCharArray()[(int)Math.Floor(r.NextDouble() * posArray.Length)].ToString();
            pos = int.Parse(randomChar);
            posArray = posArray.Replace(randomChar, "");
            return pos;
        }

      
    }





}
