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
    ///  Class for testing TradingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TradingApiTests
    {
        private TradingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TradingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TradingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TradingApi
            //Assert.IsInstanceOfType(typeof(TradingApi), instance, "instance is a TradingApi");
        }

        
        /// <summary>
        /// Test OrderClientOrderIdDelete
        /// </summary>
        [Test]
        public void OrderClientOrderIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientOrderId = null;
            //var response = instance.OrderClientOrderIdDelete(clientOrderId);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test OrderClientOrderIdGet
        /// </summary>
        [Test]
        public void OrderClientOrderIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientOrderId = null;
            //int? wait = null;
            //var response = instance.OrderClientOrderIdGet(clientOrderId, wait);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test OrderClientOrderIdPatch
        /// </summary>
        [Test]
        public void OrderClientOrderIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientOrderId = null;
            //string quantity = null;
            //string requestClientId = null;
            //string price = null;
            //var response = instance.OrderClientOrderIdPatch(clientOrderId, quantity, requestClientId, price);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test OrderClientOrderIdPut
        /// </summary>
        [Test]
        public void OrderClientOrderIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientOrderId = null;
            //string symbol = null;
            //string side = null;
            //string timeInForce = null;
            //string quantity = null;
            //string type = null;
            //string price = null;
            //string stopPrice = null;
            //DateTime? expireTime = null;
            //bool? strictValidate = null;
            //var response = instance.OrderClientOrderIdPut(clientOrderId, symbol, side, timeInForce, quantity, type, price, stopPrice, expireTime, strictValidate);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test OrderDelete
        /// </summary>
        [Test]
        public void OrderDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.OrderDelete(symbol);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test OrderGet
        /// </summary>
        [Test]
        public void OrderGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.OrderGet(symbol);
            //Assert.IsInstanceOf<List<Order>> (response, "response is List<Order>");
        }
        
        /// <summary>
        /// Test OrderPost
        /// </summary>
        [Test]
        public void OrderPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OrderCommand _event = null;
            //var response = instance.OrderPost(_event);
            //Assert.IsInstanceOf<Order> (response, "response is Order");
        }
        
        /// <summary>
        /// Test TradingBalanceGet
        /// </summary>
        [Test]
        public void TradingBalanceGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TradingBalanceGet();
            //Assert.IsInstanceOf<List<Balance>> (response, "response is List<Balance>");
        }
        
        /// <summary>
        /// Test TradingFeeSymbolGet
        /// </summary>
        [Test]
        public void TradingFeeSymbolGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string symbol = null;
            //var response = instance.TradingFeeSymbolGet(symbol);
            //Assert.IsInstanceOf<TradingFee> (response, "response is TradingFee");
        }
        
    }

}