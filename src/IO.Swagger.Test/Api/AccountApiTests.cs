/* 
 * HitBTC API
 *
 * Create API keys in your profile https://hitbtc.com/settings/api-keys and use public API key as username and secret as password to authorize. 
 *
 * OpenAPI spec version: 2.1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing AccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountApiTests
    {
        private AccountApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountApi
            //Assert.IsInstanceOfType(typeof(AccountApi), instance, "instance is a AccountApi");
        }

        
        /// <summary>
        /// Test AccountBalanceGet
        /// </summary>
        [Test]
        public void AccountBalanceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.AccountBalanceGet();
            //Assert.IsInstanceOf<List<Balance>> (response, "response is List<Balance>");
        }
        
        /// <summary>
        /// Test AccountCryptoAddressCurrencyGet
        /// </summary>
        [Test]
        public void AccountCryptoAddressCurrencyGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.AccountCryptoAddressCurrencyGet(currency);
            //Assert.IsInstanceOf<Address> (response, "response is Address");
        }
        
        /// <summary>
        /// Test AccountCryptoAddressCurrencyPost
        /// </summary>
        [Test]
        public void AccountCryptoAddressCurrencyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.AccountCryptoAddressCurrencyPost(currency);
            //Assert.IsInstanceOf<Address> (response, "response is Address");
        }
        
        /// <summary>
        /// Test AccountCryptoWithdrawIdDelete
        /// </summary>
        [Test]
        public void AccountCryptoWithdrawIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AccountCryptoWithdrawIdDelete(id);
            //Assert.IsInstanceOf<WithdrawConfirm> (response, "response is WithdrawConfirm");
        }
        
        /// <summary>
        /// Test AccountCryptoWithdrawIdPut
        /// </summary>
        [Test]
        public void AccountCryptoWithdrawIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AccountCryptoWithdrawIdPut(id);
            //Assert.IsInstanceOf<WithdrawConfirm> (response, "response is WithdrawConfirm");
        }
        
        /// <summary>
        /// Test AccountCryptoWithdrawPost
        /// </summary>
        [Test]
        public void AccountCryptoWithdrawPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //string amount = null;
            //string address = null;
            //string paymentId = null;
            //string networkFee = null;
            //bool? includeFee = null;
            //bool? autoCommit = null;
            //instance.AccountCryptoWithdrawPost(currency, amount, address, paymentId, networkFee, includeFee, autoCommit);
            
        }
        
        /// <summary>
        /// Test AccountTransactionsGet
        /// </summary>
        [Test]
        public void AccountTransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //string sort = null;
            //string by = null;
            //string from = null;
            //string till = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.AccountTransactionsGet(currency, sort, by, from, till, limit, offset);
            //Assert.IsInstanceOf<List<Transaction>> (response, "response is List<Transaction>");
        }
        
        /// <summary>
        /// Test AccountTransactionsIdGet
        /// </summary>
        [Test]
        public void AccountTransactionsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.AccountTransactionsIdGet(id);
            //Assert.IsInstanceOf<Transaction> (response, "response is Transaction");
        }
        
        /// <summary>
        /// Test AccountTransferPost
        /// </summary>
        [Test]
        public void AccountTransferPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //string amount = null;
            //string type = null;
            //var response = instance.AccountTransferPost(currency, amount, type);
            //Assert.IsInstanceOf<InlineResponse400> (response, "response is InlineResponse400");
        }
        
    }

}