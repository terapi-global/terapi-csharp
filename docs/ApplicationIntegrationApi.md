# IO.Swagger.Api.ApplicationIntegrationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationIntegrationAddIntegrationToApplicationPost**](ApplicationIntegrationApi.md#applicationintegrationaddintegrationtoapplicationpost) | **POST** /application-integration/add-integration-to-application | 18_999
[**ApplicationIntegrationApplicationIntegrationListByApplicationIdGet**](ApplicationIntegrationApi.md#applicationintegrationapplicationintegrationlistbyapplicationidget) | **GET** /application-integration/application-integration-list-by-application-id | 18_997

<a name="applicationintegrationaddintegrationtoapplicationpost"></a>
# **ApplicationIntegrationAddIntegrationToApplicationPost**
> AddIntegrationToApplicationResponse ApplicationIntegrationAddIntegrationToApplicationPost (ApplicationintegrationAddintegrationtoapplicationBody body = null)

18_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 18_999_101 | ApplicationNotFound | Application not found. |  | 18_999_102 | UnknownExceptionWhenCheckApplicationExistence | Unknown exception when checking if application exists. |  | 18_999_103 | IntegrationNotFound | Integration not found. |  | 18_999_104 | UnknownExceptionWhenCheckIntegrationExistence | Unknown exception when checking if integration exists. |  | 18_999_105 | UnknownExceptionWhenAddIntegrationToApplication | Unknown exception when adding integration to application. |  | 18_999_106 | IntegrationAlreadyAddedToTheApplication | You already map this integration to your application. |  | 18_999_107 | UnknownExceptionWhenCheckApplicationIntegrationUniqueness |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationIntegrationAddIntegrationToApplicationPostExample
    {
        public void main()
        {

            var apiInstance = new ApplicationIntegrationApi();
            var body = new ApplicationintegrationAddintegrationtoapplicationBody(); // ApplicationintegrationAddintegrationtoapplicationBody |  (optional) 

            try
            {
                // 18_999
                AddIntegrationToApplicationResponse result = apiInstance.ApplicationIntegrationAddIntegrationToApplicationPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationIntegrationApi.ApplicationIntegrationAddIntegrationToApplicationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationintegrationAddintegrationtoapplicationBody**](ApplicationintegrationAddintegrationtoapplicationBody.md)|  | [optional] 

### Return type

[**AddIntegrationToApplicationResponse**](AddIntegrationToApplicationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationintegrationapplicationintegrationlistbyapplicationidget"></a>
# **ApplicationIntegrationApplicationIntegrationListByApplicationIdGet**
> ApplicationIntegrationListByApplicationIdResponse ApplicationIntegrationApplicationIntegrationListByApplicationIdGet (Guid? applicationId = null, int? page = null, int? perPage = null)

18_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 18_998 | UnknownExceptionWhenTryingFetchApplicationIntegrations |  |  | 18_999 | ApplicationNotFound |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationIntegrationApplicationIntegrationListByApplicationIdGetExample
    {
        public void main()
        {

            var apiInstance = new ApplicationIntegrationApi();
            var applicationId = new Guid?(); // Guid? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 

            try
            {
                // 18_997
                ApplicationIntegrationListByApplicationIdResponse result = apiInstance.ApplicationIntegrationApplicationIntegrationListByApplicationIdGet(applicationId, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationIntegrationApi.ApplicationIntegrationApplicationIntegrationListByApplicationIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationId** | [**Guid?**](Guid?.md)|  | [optional] 
 **page** | **int?**|  | [optional] 
 **perPage** | **int?**|  | [optional] 

### Return type

[**ApplicationIntegrationListByApplicationIdResponse**](ApplicationIntegrationListByApplicationIdResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
