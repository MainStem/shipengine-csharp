# ShipEngine.ApiClient.Api.NLPApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NLPRecognizeAddress**](NLPApi.md#nlprecognizeaddress) | **PUT** /v1/addresses/recognize | Identifies address-related entities (name, line1, line2, city, postal code, etc.) in unstructured text 
[**NLPRecognizeShipment**](NLPApi.md#nlprecognizeshipment) | **PUT** /v1/shipments/recognize | Identifies shipment-related entities (names, address parts, package dimensions, weight, insurance options, etc.) in unstructured text 


<a name="nlprecognizeaddress"></a>
# **NLPRecognizeAddress**
> RecognizeAddressResponseDTO NLPRecognizeAddress (RecognizeAddressRequestDTO body)

Identifies address-related entities (name, line1, line2, city, postal code, etc.) in unstructured text 

### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class NLPRecognizeAddressExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new NLPApi();
            var body = new RecognizeAddressRequestDTO(); // RecognizeAddressRequestDTO | 

            try
            {
                // Identifies address-related entities (name, line1, line2, city, postal code, etc.) in unstructured text 
                RecognizeAddressResponseDTO result = apiInstance.NLPRecognizeAddress(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NLPApi.NLPRecognizeAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecognizeAddressRequestDTO**](RecognizeAddressRequestDTO.md)|  | 

### Return type

[**RecognizeAddressResponseDTO**](RecognizeAddressResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="nlprecognizeshipment"></a>
# **NLPRecognizeShipment**
> RecognizeShipmentResponseDTO NLPRecognizeShipment (RecognizeShipmentRequestDTO body)

Identifies shipment-related entities (names, address parts, package dimensions, weight, insurance options, etc.) in unstructured text 

### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class NLPRecognizeShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new NLPApi();
            var body = new RecognizeShipmentRequestDTO(); // RecognizeShipmentRequestDTO | 

            try
            {
                // Identifies shipment-related entities (names, address parts, package dimensions, weight, insurance options, etc.) in unstructured text 
                RecognizeShipmentResponseDTO result = apiInstance.NLPRecognizeShipment(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NLPApi.NLPRecognizeShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecognizeShipmentRequestDTO**](RecognizeShipmentRequestDTO.md)|  | 

### Return type

[**RecognizeShipmentResponseDTO**](RecognizeShipmentResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

