# IO.Swagger.Api.ApplicationApiKeyApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationApikeyGeneratePost**](ApplicationApiKeyApi.md#applicationapikeygeneratepost) | **POST** /application-apikey/generate | 16_999
[**ApplicationApikeyGetByApplicationIdGet**](ApplicationApiKeyApi.md#applicationapikeygetbyapplicationidget) | **GET** /application-apikey/get-by-application-id | 16_995
[**ApplicationApikeyRevokeDelete**](ApplicationApiKeyApi.md#applicationapikeyrevokedelete) | **DELETE** /application-apikey/revoke | 16_998

<a name="applicationapikeygeneratepost"></a>
# **ApplicationApikeyGeneratePost**
> CreateApplicationApiKeyResponse ApplicationApikeyGeneratePost (ApplicationapikeyGenerateBody body = null)

16_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 16_999_101 | ApplicationNotFound | Application not found. |  | 16_999_102 | UnknownExceptionWhenCheckApplicationExistence | Unknown exception when checking if application exists. |  | 16_999_103 | UnknownExceptionWhenGenerateApplicationApiKey | Unknown exception when generating application API key. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApikeyGeneratePostExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApiKeyApi();
            var body = new ApplicationapikeyGenerateBody(); // ApplicationapikeyGenerateBody |  (optional) 

            try
            {
                // 16_999
                CreateApplicationApiKeyResponse result = apiInstance.ApplicationApikeyGeneratePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApiKeyApi.ApplicationApikeyGeneratePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationapikeyGenerateBody**](ApplicationapikeyGenerateBody.md)|  | [optional] 

### Return type

[**CreateApplicationApiKeyResponse**](CreateApplicationApiKeyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationapikeygetbyapplicationidget"></a>
# **ApplicationApikeyGetByApplicationIdGet**
> ApplicationApiKeyByApplicationIdResponse ApplicationApikeyGetByApplicationIdGet (Guid? applicationId = null)

16_995

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 16_995_101 | ApplicationApiKeyNotFound | Application API key not found. |  | 16_995_102 | UnknownExceptionWhenTryingFetchApplications | Unknown exception when trying to fetch applications. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApikeyGetByApplicationIdGetExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApiKeyApi();
            var applicationId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // 16_995
                ApplicationApiKeyByApplicationIdResponse result = apiInstance.ApplicationApikeyGetByApplicationIdGet(applicationId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApiKeyApi.ApplicationApikeyGetByApplicationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**ApplicationApiKeyByApplicationIdResponse**](ApplicationApiKeyByApplicationIdResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationapikeyrevokedelete"></a>
# **ApplicationApikeyRevokeDelete**
> RevokeApplicationApiKeyResponse ApplicationApikeyRevokeDelete (Guid? id = null)

16_998

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 16_998_101 | ApplicationApiKeyNotFound | Application API key not found. |  | 16_998_102 | UnknownExceptionWhenCheckApplicationExistence | Unknown exception when checking if application exists. |  | 16_998_103 | UnknownExceptionWhenGenerateApplicationApiKey | Unknown exception when generating application API key. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationApikeyRevokeDeleteExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApiKeyApi();
            var id = new Guid?(); // Guid? |  (optional) 

            try
            {
                // 16_998
                RevokeApplicationApiKeyResponse result = apiInstance.ApplicationApikeyRevokeDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApiKeyApi.ApplicationApikeyRevokeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**RevokeApplicationApiKeyResponse**](RevokeApplicationApiKeyResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
