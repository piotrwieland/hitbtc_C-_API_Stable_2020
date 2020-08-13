# IO.Swagger - the C# library for the HitBTC API

Create API keys in your profile https://hitbtc.com/settings/api-keys and use public API key as username and secret as password to authorize. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 2.1.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure HTTP basic authorization: BasicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new AccountApi();

            try
            {
                // Get main acccount balance
                List<Balance> result = apiInstance.AccountBalanceGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountBalanceGet: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.hitbtc.com/api/2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountApi* | [**AccountBalanceGet**](docs/AccountApi.md#accountbalanceget) | **GET** /account/balance | Get main acccount balance
*AccountApi* | [**AccountCryptoAddressCurrencyGet**](docs/AccountApi.md#accountcryptoaddresscurrencyget) | **GET** /account/crypto/address/{currency} | Get deposit crypro address
*AccountApi* | [**AccountCryptoAddressCurrencyPost**](docs/AccountApi.md#accountcryptoaddresscurrencypost) | **POST** /account/crypto/address/{currency} | Create new deposit crypro address
*AccountApi* | [**AccountCryptoWithdrawIdDelete**](docs/AccountApi.md#accountcryptowithdrawiddelete) | **DELETE** /account/crypto/withdraw/{id} | Rollback withdraw crypro
*AccountApi* | [**AccountCryptoWithdrawIdPut**](docs/AccountApi.md#accountcryptowithdrawidput) | **PUT** /account/crypto/withdraw/{id} | Commit withdraw crypro
*AccountApi* | [**AccountCryptoWithdrawPost**](docs/AccountApi.md#accountcryptowithdrawpost) | **POST** /account/crypto/withdraw | Withdraw crypro
*AccountApi* | [**AccountTransactionsGet**](docs/AccountApi.md#accounttransactionsget) | **GET** /account/transactions | Get account transactions
*AccountApi* | [**AccountTransactionsIdGet**](docs/AccountApi.md#accounttransactionsidget) | **GET** /account/transactions/{id} | Get account transaction by id
*AccountApi* | [**AccountTransferPost**](docs/AccountApi.md#accounttransferpost) | **POST** /account/transfer | Transfer amount to trading
*PublicApi* | [**PublicCandlesSymbolGet**](docs/PublicApi.md#publiccandlessymbolget) | **GET** /public/candles/{symbol} | Candles
*PublicApi* | [**PublicCurrencyCurrencyGet**](docs/PublicApi.md#publiccurrencycurrencyget) | **GET** /public/currency/{currency} | Get currency info
*PublicApi* | [**PublicCurrencyGet**](docs/PublicApi.md#publiccurrencyget) | **GET** /public/currency | Available Currencies
*PublicApi* | [**PublicOrderbookSymbolGet**](docs/PublicApi.md#publicorderbooksymbolget) | **GET** /public/orderbook/{symbol} | Orderbook
*PublicApi* | [**PublicSymbolGet**](docs/PublicApi.md#publicsymbolget) | **GET** /public/symbol | Available Currency Symbols
*PublicApi* | [**PublicSymbolSymbolGet**](docs/PublicApi.md#publicsymbolsymbolget) | **GET** /public/symbol/{symbol} | Get symbol info
*PublicApi* | [**PublicTickerGet**](docs/PublicApi.md#publictickerget) | **GET** /public/ticker | Ticker list for all symbols
*PublicApi* | [**PublicTickerSymbolGet**](docs/PublicApi.md#publictickersymbolget) | **GET** /public/ticker/{symbol} | Ticker for symbol
*PublicApi* | [**PublicTradesSymbolGet**](docs/PublicApi.md#publictradessymbolget) | **GET** /public/trades/{symbol} | Trades
*TradingApi* | [**OrderClientOrderIdDelete**](docs/TradingApi.md#orderclientorderiddelete) | **DELETE** /order/{clientOrderId} | Cancel order
*TradingApi* | [**OrderClientOrderIdGet**](docs/TradingApi.md#orderclientorderidget) | **GET** /order/{clientOrderId} | Get a single order by clientOrderId
*TradingApi* | [**OrderClientOrderIdPatch**](docs/TradingApi.md#orderclientorderidpatch) | **PATCH** /order/{clientOrderId} | Cancel Replace order
*TradingApi* | [**OrderClientOrderIdPut**](docs/TradingApi.md#orderclientorderidput) | **PUT** /order/{clientOrderId} | Create new order
*TradingApi* | [**OrderDelete**](docs/TradingApi.md#orderdelete) | **DELETE** /order | Cancel all open orders
*TradingApi* | [**OrderGet**](docs/TradingApi.md#orderget) | **GET** /order | List your current open orders
*TradingApi* | [**OrderPost**](docs/TradingApi.md#orderpost) | **POST** /order | Create new order
*TradingApi* | [**TradingBalanceGet**](docs/TradingApi.md#tradingbalanceget) | **GET** /trading/balance | Get trading balance
*TradingApi* | [**TradingFeeSymbolGet**](docs/TradingApi.md#tradingfeesymbolget) | **GET** /trading/fee/{symbol} | Get trading fee rate
*TradingHistoryApi* | [**HistoryOrderGet**](docs/TradingHistoryApi.md#historyorderget) | **GET** /history/order | Get historical orders
*TradingHistoryApi* | [**HistoryOrderIdTradesGet**](docs/TradingHistoryApi.md#historyorderidtradesget) | **GET** /history/order/{id}/trades | Get historical trades by specified order
*TradingHistoryApi* | [**HistoryTradesGet**](docs/TradingHistoryApi.md#historytradesget) | **GET** /history/trades | Get historical trades


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Address](docs/Address.md)
 - [Model.Balance](docs/Balance.md)
 - [Model.Candle](docs/Candle.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.Error](docs/Error.md)
 - [Model.ErrorError](docs/ErrorError.md)
 - [Model.InlineResponse400](docs/InlineResponse400.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderCommand](docs/OrderCommand.md)
 - [Model.OrderTradesReport](docs/OrderTradesReport.md)
 - [Model.Orderbook](docs/Orderbook.md)
 - [Model.OrderbookAsk](docs/OrderbookAsk.md)
 - [Model.PublicTrade](docs/PublicTrade.md)
 - [Model.Symbol](docs/Symbol.md)
 - [Model.Ticker](docs/Ticker.md)
 - [Model.Trade](docs/Trade.md)
 - [Model.TradingFee](docs/TradingFee.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.WithdrawConfirm](docs/WithdrawConfirm.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="BasicAuth"></a>
### BasicAuth

- **Type**: HTTP basic authentication

