// <copyright file="StringContainsProductSearchTest.cs">Copyright © Microsoft 2015</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.ProductSearch;

namespace PartsUnlimited.ProductSearch.Tests
{
    [TestClass]
    [PexClass(typeof(StringContainsProductSearch))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringContainsProductSearchTest
    {

        [PexMethod]
        public string Depluralize([PexAssumeUnderTest]StringContainsProductSearch target, string query)
        {
            string result = target.Depluralize(query);
            return result;
            // TODO: add assertions to method StringContainsProductSearchTest.Depluralize(StringContainsProductSearch, String)
        }
    }
}
