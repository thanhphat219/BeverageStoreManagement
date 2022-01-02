﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BeverageStoreManagement.ViewModels;

namespace BeverageStoreManagement.Test
{
    [TestFixture]
    class ConvertToType
    {
        BaseViewModel baseViewModel = new BaseViewModel();
        [Test]
        public void testCase1()
        {
            Assert.AreEqual(3, baseViewModel.ConvertToType("Milk Tea"));
        }
        [Test]
        public void testCase2()
        {
            Assert.AreEqual(1, baseViewModel.ConvertToType("Coffee"));
        }
        [Test]
        public void testCase3()
        {
            Assert.AreEqual(2, baseViewModel.ConvertToType("Tea"));
        }
        [Test]
        public void testCase4()
        {
            Assert.AreEqual(4, baseViewModel.ConvertToType("Fruit Tea"));
        }
        [Test]
        public void testCase5()
        {
            Assert.AreEqual(5, baseViewModel.ConvertToType("Snacks"));
        }
        [Test]
        public void testCase6()
        {
            Assert.AreEqual(0, baseViewModel.ConvertToType(""));
        }
        [Test]
        public void testCase7()
        {
            Assert.AreEqual(0, baseViewModel.ConvertToType(null));
        }
    }
}
