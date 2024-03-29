﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingExample.Models
{
    
    public static class Stringhelper
    {
        /// <summary>
        /// Ensures <paramref name="fileName"/> filename ends with .txt (not case sensitive)
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsTextFile(string fileName)
        {
            if(string.IsNullOrWhiteSpace(fileName))
            {
                return false;
            }

            
          DoesContainSpecialCharacters(fileName);
            fileName = fileName.Trim().ToLower();

            if(fileName.Length <= 4)
            {
                return false;
            }
            if (DoesContainSpecialCharacters(fileName))
            {
                return false;
            }

            if (!fileName.EndsWith(".txt"))
            {
                return false;
            }

            return true;
        }

        private static bool DoesContainSpecialCharacters(string name)
        {
            if(name.Contains("<") || name.Contains(">") 
                || name.Contains("$") || name.Contains("^") || name.Contains("&"))
            {
                return true;
            }
            return false;
        }

    }

    
}
