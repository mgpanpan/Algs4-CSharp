﻿//-----------------------------------------------------------------------
// <copyright file="QuickUnitTests.cs" company="Eusebio Rufian-Zilbermann">
//   Copyright (c) Eusebio Rufian-Zilbermann for the C# implementation
//   based on materials published by Robert Sedgewick and Kevin Wayne
// </copyright>
//-----------------------------------------------------------------------
namespace Algs4UnitTests
{
   using System;
   using Algs4;
   using Microsoft.VisualStudio.TestTools.UnitTesting;

   /// <summary>
   /// Unit Tests for the Quick sort class.
   /// </summary>
   [TestClass]
   public class QuickUnitTests
   {
      /// <summary>
      /// Sort a small text file.
      /// </summary>
      [TestMethod]
      public void QuickTiny()
      {
         string[] expectedResult = { "A", "E", "E", "L", "M", "O", "P", "R", "S", "T", "X" };
         string[] actualResult = CommonSortUnitTests.SortCommon("Algs4-Data\\tiny.txt", Quick.Instance);
         for (int i = 0; actualResult.Length > i && expectedResult.Length > i; i++)
         {
            Assert.AreEqual(expectedResult[i], actualResult[i]);
         }
      }

      /// <summary>
      /// Sort a slightly larger text file.
      /// </summary>
      [TestMethod]
      public void QuickWords3()
      {
         string[] expectedResult = 
         { 
            "all", "bad", "bed", "bug", "dad", "dim", "dug", "egg", "fee", "few", "for", "gig", 
            "hut", "ilk", "jam", "jay", "jot", "joy", "men", "nob", "now", "owl", "rap", "sky", 
            "sob", "tag", "tap", "tar", "tip", "wad", "was", "wee", "yes", "yet", "zoo" 
         };

         string[] actualResult = CommonSortUnitTests.SortCommon("Algs4-Data\\words3.txt", Quick.Instance);
         for (int i = 0; actualResult.Length > i && expectedResult.Length > i; i++)
         {
            Assert.AreEqual(expectedResult[i], actualResult[i]);
         }
      }
   }
}