using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestingExample.Models.Tests
{
    [TestClass()]
    
    public class StringHelperTests
    {
        [TestMethod()]
        [DataRow("joe.txt")]
        [DataRow("test.TXT")]
        [DataRow("   test.txt")]
        [DataRow("test.txt   ")]
        [DataRow("   test.txt   ")]
        [DataRow("October2019.TXT")]
       
        
        public void IstTextFile_ValidFileName_ReturnsTrue(string fileName)
        {
            
            
            //Act
           bool result = Stringhelper.IsTextFile(fileName);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow(".text")]
        [DataRow("hello world")]
        [DataRow(" .txt")]
        [DataRow("<>.txt")]
        public void IsTextFile_InvalidFileName_ReturnsFalse(string fileName)
        {
   
            bool result = Stringhelper.IsTextFile(fileName);

            Assert.IsFalse(result);
        }
    }
}