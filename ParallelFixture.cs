using System;
using System.Threading;
using NUnit.Framework;

namespace Tests
{
    [Parallelizable(ParallelScope.All)]
    class ParallelFixture
    {
        [Test]
        [Repeat(100)]
        public void ImATest()
        {
            Console.WriteLine(".");
            Thread.Sleep(50);
        }

        [Test]
        public void SoAmI()
        {
            Thread.Sleep(5000);
        }

        [Test]
        public void MeToo()
        {
            Thread.Sleep(5000);
        }

        [TestCase(1)]
        [TestCase(2)]
        public void WhatAboutTestCases(int x)
        {
            Thread.Sleep(5000);
        }
    }
}