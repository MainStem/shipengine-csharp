# ShipEngine.ApiClient.Api.MarketplaceAccountsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AmazonAccountConnect**](MarketplaceAccountsApi.md#amazonaccountconnect) | **POST** /v-beta/connections/marketplaces/amazon | 
[**AmazonAccountDeactivate**](MarketplaceAccountsApi.md#amazonaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/amazon/{store_id}/deactivate | 
[**AmazonAccountReactivate**](MarketplaceAccountsApi.md#amazonaccountreactivate) | **PUT** /v-beta/connections/marketplaces/amazon/{store_id}/reactivate | 
[**AmazonAccountTest**](MarketplaceAccountsApi.md#amazonaccounttest) | **GET** /v-beta/connections/marketplaces/amazon/{store_id}/test | 
[**ChannelAdvisorAccountConnect**](MarketplaceAccountsApi.md#channeladvisoraccountconnect) | **POST** /v-beta/connections/marketplaces/channeladvisor | 
[**ChannelAdvisorAccountDeactivate**](MarketplaceAccountsApi.md#channeladvisoraccountdeactivate) | **PUT** /v-beta/connections/marketplaces/channeladvisor/{store_id}/deactivate | 
[**ChannelAdvisorAccountReactivate**](MarketplaceAccountsApi.md#channeladvisoraccountreactivate) | **PUT** /v-beta/connections/marketplaces/channeladvisor/{store_id}/reactivate | 
[**ChannelAdvisorAccountTest**](MarketplaceAccountsApi.md#channeladvisoraccounttest) | **GET** /v-beta/connections/marketplaces/channeladvisor/{store_id}/test | 
[**EbayAccountConnectAccessToken**](MarketplaceAccountsApi.md#ebayaccountconnectaccesstoken) | **POST** /v-beta/connections/marketplaces/ebay/access_token | 
[**EbayAccountDeactivate**](MarketplaceAccountsApi.md#ebayaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/ebay/{store_id}/deactivate | 
[**EbayAccountReactivate**](MarketplaceAccountsApi.md#ebayaccountreactivate) | **PUT** /v-beta/connections/marketplaces/ebay/{store_id}/reactivate | 
[**EbayAccountTest**](MarketplaceAccountsApi.md#ebayaccounttest) | **GET** /v-beta/connections/marketplaces/ebay/{store_id}/test | 
[**EtsyAccountConnect**](MarketplaceAccountsApi.md#etsyaccountconnect) | **POST** /v-beta/connections/marketplaces/etsy/access_token | 
[**EtsyAccountDeactivate**](MarketplaceAccountsApi.md#etsyaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/etsy/{store_id}/deactivate | 
[**EtsyAccountReactivate**](MarketplaceAccountsApi.md#etsyaccountreactivate) | **PUT** /v-beta/connections/marketplaces/etsy/{store_id}/reactivate | 
[**EtsyAccountTest**](MarketplaceAccountsApi.md#etsyaccounttest) | **GET** /v-beta/connections/marketplaces/etsy/{store_id}/test | 
[**MagentoAccountConnect**](MarketplaceAccountsApi.md#magentoaccountconnect) | **POST** /v-beta/connections/marketplaces/magento | 
[**MagentoAccountDeactivate**](MarketplaceAccountsApi.md#magentoaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/magento/{store_id}/deactivate | 
[**MagentoAccountReactivate**](MarketplaceAccountsApi.md#magentoaccountreactivate) | **PUT** /v-beta/connections/marketplaces/magento/{store_id}/reactivate | 
[**MagentoAccountTest**](MarketplaceAccountsApi.md#magentoaccounttest) | **GET** /v-beta/connections/marketplaces/magento/{store_id}/test | 
[**ShopifyAccountConnectAccessToken**](MarketplaceAccountsApi.md#shopifyaccountconnectaccesstoken) | **POST** /v-beta/connections/marketplaces/shopify/access_token | 
[**ShopifyAccountDeactivate**](MarketplaceAccountsApi.md#shopifyaccountdeactivate) | **PUT** /v-beta/connections/marketplaces/shopify/{store_id}/deactivate | 
[**ShopifyAccountReactivate**](MarketplaceAccountsApi.md#shopifyaccountreactivate) | **PUT** /v-beta/connections/marketplaces/shopify/{store_id}/reactivate | 
[**ShopifyAccountTest**](MarketplaceAccountsApi.md#shopifyaccounttest) | **GET** /v-beta/connections/marketplaces/shopify/{store_id}/test | 


<a name="amazonaccountconnect"></a>
# **AmazonAccountConnect**
> ConnectMarketplaceResponseDTO AmazonAccountConnect (AmazonAccountInformationRequest accountInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AmazonAccountConnectExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accountInfo = new AmazonAccountInformationRequest(); // AmazonAccountInformationRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.AmazonAccountConnect(accountInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.AmazonAccountConnect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountInfo** | [**AmazonAccountInformationRequest**](AmazonAccountInformationRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amazonaccountdeactivate"></a>
# **AmazonAccountDeactivate**
> void AmazonAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AmazonAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.AmazonAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.AmazonAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amazonaccountreactivate"></a>
# **AmazonAccountReactivate**
> void AmazonAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AmazonAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.AmazonAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.AmazonAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="amazonaccounttest"></a>
# **AmazonAccountTest**
> void AmazonAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AmazonAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.AmazonAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.AmazonAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channeladvisoraccountconnect"></a>
# **ChannelAdvisorAccountConnect**
> ConnectMarketplaceResponseDTO ChannelAdvisorAccountConnect (ChannelAdvisorAccountInformationRequest accountInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ChannelAdvisorAccountConnectExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accountInfo = new ChannelAdvisorAccountInformationRequest(); // ChannelAdvisorAccountInformationRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.ChannelAdvisorAccountConnect(accountInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ChannelAdvisorAccountConnect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountInfo** | [**ChannelAdvisorAccountInformationRequest**](ChannelAdvisorAccountInformationRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channeladvisoraccountdeactivate"></a>
# **ChannelAdvisorAccountDeactivate**
> void ChannelAdvisorAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ChannelAdvisorAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ChannelAdvisorAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ChannelAdvisorAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channeladvisoraccountreactivate"></a>
# **ChannelAdvisorAccountReactivate**
> void ChannelAdvisorAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ChannelAdvisorAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ChannelAdvisorAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ChannelAdvisorAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="channeladvisoraccounttest"></a>
# **ChannelAdvisorAccountTest**
> void ChannelAdvisorAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ChannelAdvisorAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ChannelAdvisorAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ChannelAdvisorAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ebayaccountconnectaccesstoken"></a>
# **EbayAccountConnectAccessToken**
> ConnectMarketplaceResponseDTO EbayAccountConnectAccessToken (EbayAccessTokenRequest accessTokenInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EbayAccountConnectAccessTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accessTokenInfo = new EbayAccessTokenRequest(); // EbayAccessTokenRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.EbayAccountConnectAccessToken(accessTokenInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EbayAccountConnectAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessTokenInfo** | [**EbayAccessTokenRequest**](EbayAccessTokenRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ebayaccountdeactivate"></a>
# **EbayAccountDeactivate**
> void EbayAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EbayAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EbayAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EbayAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ebayaccountreactivate"></a>
# **EbayAccountReactivate**
> void EbayAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EbayAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EbayAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EbayAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ebayaccounttest"></a>
# **EbayAccountTest**
> void EbayAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EbayAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EbayAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EbayAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="etsyaccountconnect"></a>
# **EtsyAccountConnect**
> ConnectMarketplaceResponseDTO EtsyAccountConnect (EtsyAccessTokenRequest accessTokenInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EtsyAccountConnectExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accessTokenInfo = new EtsyAccessTokenRequest(); // EtsyAccessTokenRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.EtsyAccountConnect(accessTokenInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EtsyAccountConnect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessTokenInfo** | [**EtsyAccessTokenRequest**](EtsyAccessTokenRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="etsyaccountdeactivate"></a>
# **EtsyAccountDeactivate**
> void EtsyAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EtsyAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EtsyAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EtsyAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="etsyaccountreactivate"></a>
# **EtsyAccountReactivate**
> void EtsyAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EtsyAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EtsyAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EtsyAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="etsyaccounttest"></a>
# **EtsyAccountTest**
> void EtsyAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EtsyAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EtsyAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.EtsyAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="magentoaccountconnect"></a>
# **MagentoAccountConnect**
> ConnectMarketplaceResponseDTO MagentoAccountConnect (MagentoAccountInformationRequest accountInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class MagentoAccountConnectExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accountInfo = new MagentoAccountInformationRequest(); // MagentoAccountInformationRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.MagentoAccountConnect(accountInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.MagentoAccountConnect: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountInfo** | [**MagentoAccountInformationRequest**](MagentoAccountInformationRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="magentoaccountdeactivate"></a>
# **MagentoAccountDeactivate**
> void MagentoAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class MagentoAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.MagentoAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.MagentoAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="magentoaccountreactivate"></a>
# **MagentoAccountReactivate**
> void MagentoAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class MagentoAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.MagentoAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.MagentoAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="magentoaccounttest"></a>
# **MagentoAccountTest**
> void MagentoAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class MagentoAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.MagentoAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.MagentoAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shopifyaccountconnectaccesstoken"></a>
# **ShopifyAccountConnectAccessToken**
> ConnectMarketplaceResponseDTO ShopifyAccountConnectAccessToken (ShopifyAccessTokenRequest accessTokenInfo, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShopifyAccountConnectAccessTokenExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var accessTokenInfo = new ShopifyAccessTokenRequest(); // ShopifyAccessTokenRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectMarketplaceResponseDTO result = apiInstance.ShopifyAccountConnectAccessToken(accessTokenInfo, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ShopifyAccountConnectAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessTokenInfo** | [**ShopifyAccessTokenRequest**](ShopifyAccessTokenRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectMarketplaceResponseDTO**](ConnectMarketplaceResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shopifyaccountdeactivate"></a>
# **ShopifyAccountDeactivate**
> void ShopifyAccountDeactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShopifyAccountDeactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShopifyAccountDeactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ShopifyAccountDeactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shopifyaccountreactivate"></a>
# **ShopifyAccountReactivate**
> void ShopifyAccountReactivate (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShopifyAccountReactivateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShopifyAccountReactivate(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ShopifyAccountReactivate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shopifyaccounttest"></a>
# **ShopifyAccountTest**
> void ShopifyAccountTest (Guid? storeId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShopifyAccountTestExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new MarketplaceAccountsApi();
            var storeId = new Guid?(); // Guid? | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShopifyAccountTest(storeId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MarketplaceAccountsApi.ShopifyAccountTest: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storeId** | [**Guid?**](Guid?.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

