using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [DataRow("hhhhheeeelllooou", "hello", true)]
        [DataRow("h__e_l_l_o___", "hello", true)]
        [DataRow("world", "hello", false)]
        [DataRow("", "hello", false)]
        [DataRow("Hello", "hello", false)]
        [TestMethod()]
        public void IsWord_ValidParametrs_Bool(string input, string target, bool expected)
        {
            bool result = Program.IsWord(input, target);
            Assert.AreEqual(expected, result);
        }
    }
}