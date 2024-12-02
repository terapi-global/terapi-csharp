# IO.Swagger.Api.ApiProxyApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiProxyEndpointDelete**](ApiProxyApi.md#apiproxyendpointdelete) | **DELETE** /api-proxy/{endpoint} | 21_997
[**ApiProxyEndpointGet**](ApiProxyApi.md#apiproxyendpointget) | **GET** /api-proxy/{endpoint} | 21_997
[**ApiProxyEndpointPatch**](ApiProxyApi.md#apiproxyendpointpatch) | **PATCH** /api-proxy/{endpoint} | 21_997
[**ApiProxyEndpointPost**](ApiProxyApi.md#apiproxyendpointpost) | **POST** /api-proxy/{endpoint} | 21_997
[**ApiProxyEndpointPut**](ApiProxyApi.md#apiproxyendpointput) | **PUT** /api-proxy/{endpoint} | 21_997
[**ApiProxyOauth2ChallengeGet**](ApiProxyApi.md#apiproxyoauth2challengeget) | **GET** /api-proxy/oauth2/challenge | 
[**ApiProxyUnifiedContactsExternalIdGet**](ApiProxyApi.md#apiproxyunifiedcontactsexternalidget) | **GET** /api-proxy/unified/contacts/{externalId} | 
[**ApiProxyUnifiedContactsGet**](ApiProxyApi.md#apiproxyunifiedcontactsget) | **GET** /api-proxy/unified/contacts | 

<a name="apiproxyendpointdelete"></a>
# **ApiProxyEndpointDelete**
> CallActionResponse ApiProxyEndpointDelete (Guid? xTenantId, string integrationName, string endpoint, ApiproxyEndpointBody6 body = null)

21_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 21_997_101 | TenantNotFound |  |  | 21_997_102 | IntegrationNotFound |  |  | 21_997_103 | UnknownExceptionWhenCallingThirdPartyApi |  |  | 21_997_104 | UnknownExceptionWhenCallAction |  |  | 21_997_105 | IntegrationIsNotEnabled |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyEndpointDeleteExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var xTenantId = new Guid?(); // Guid? | 
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var body = new ApiproxyEndpointBody6(); // ApiproxyEndpointBody6 |  (optional) 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointDelete(xTenantId, integrationName, endpoint, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyEndpointDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xTenantId** | [**Guid?**](Guid?.md)|  | 
 **integrationName** | **string**|  | 
 **endpoint** | **string**|  | 
 **body** | [**ApiproxyEndpointBody6**](ApiproxyEndpointBody6.md)|  | [optional] 

### Return type

[**CallActionResponse**](CallActionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyendpointget"></a>
# **ApiProxyEndpointGet**
> CallActionResponse ApiProxyEndpointGet (string integrationName, string endpoint, Guid? xTenantId)

21_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 21_997_101 | TenantNotFound |  |  | 21_997_102 | IntegrationNotFound |  |  | 21_997_103 | UnknownExceptionWhenCallingThirdPartyApi |  |  | 21_997_104 | UnknownExceptionWhenCallAction |  |  | 21_997_105 | IntegrationIsNotEnabled |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyEndpointGetExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var xTenantId = new Guid?(); // Guid? | 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointGet(integrationName, endpoint, xTenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyEndpointGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integrationName** | **string**|  | 
 **endpoint** | **string**|  | 
 **xTenantId** | [**Guid?**](Guid?.md)|  | 

### Return type

[**CallActionResponse**](CallActionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyendpointpatch"></a>
# **ApiProxyEndpointPatch**
> CallActionResponse ApiProxyEndpointPatch (Guid? xTenantId, string integrationName, string endpoint, ApiproxyEndpointBody9 body = null)

21_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 21_997_101 | TenantNotFound |  |  | 21_997_102 | IntegrationNotFound |  |  | 21_997_103 | UnknownExceptionWhenCallingThirdPartyApi |  |  | 21_997_104 | UnknownExceptionWhenCallAction |  |  | 21_997_105 | IntegrationIsNotEnabled |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyEndpointPatchExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var xTenantId = new Guid?(); // Guid? | 
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var body = new ApiproxyEndpointBody9(); // ApiproxyEndpointBody9 |  (optional) 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointPatch(xTenantId, integrationName, endpoint, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyEndpointPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xTenantId** | [**Guid?**](Guid?.md)|  | 
 **integrationName** | **string**|  | 
 **endpoint** | **string**|  | 
 **body** | [**ApiproxyEndpointBody9**](ApiproxyEndpointBody9.md)|  | [optional] 

### Return type

[**CallActionResponse**](CallActionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyendpointpost"></a>
# **ApiProxyEndpointPost**
> CallActionResponse ApiProxyEndpointPost (Guid? xTenantId, string integrationName, string endpoint, ApiproxyEndpointBody3 body = null)

21_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 21_997_101 | TenantNotFound |  |  | 21_997_102 | IntegrationNotFound |  |  | 21_997_103 | UnknownExceptionWhenCallingThirdPartyApi |  |  | 21_997_104 | UnknownExceptionWhenCallAction |  |  | 21_997_105 | IntegrationIsNotEnabled |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyEndpointPostExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var xTenantId = new Guid?(); // Guid? | 
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var body = new ApiproxyEndpointBody3(); // ApiproxyEndpointBody3 |  (optional) 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointPost(xTenantId, integrationName, endpoint, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyEndpointPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xTenantId** | [**Guid?**](Guid?.md)|  | 
 **integrationName** | **string**|  | 
 **endpoint** | **string**|  | 
 **body** | [**ApiproxyEndpointBody3**](ApiproxyEndpointBody3.md)|  | [optional] 

### Return type

[**CallActionResponse**](CallActionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyendpointput"></a>
# **ApiProxyEndpointPut**
> CallActionResponse ApiProxyEndpointPut (Guid? xTenantId, string integrationName, string endpoint, ApiproxyEndpointBody body = null)

21_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 21_997_101 | TenantNotFound |  |  | 21_997_102 | IntegrationNotFound |  |  | 21_997_103 | UnknownExceptionWhenCallingThirdPartyApi |  |  | 21_997_104 | UnknownExceptionWhenCallAction |  |  | 21_997_105 | IntegrationIsNotEnabled |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyEndpointPutExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var xTenantId = new Guid?(); // Guid? | 
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var body = new ApiproxyEndpointBody(); // ApiproxyEndpointBody |  (optional) 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointPut(xTenantId, integrationName, endpoint, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyEndpointPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xTenantId** | [**Guid?**](Guid?.md)|  | 
 **integrationName** | **string**|  | 
 **endpoint** | **string**|  | 
 **body** | [**ApiproxyEndpointBody**](ApiproxyEndpointBody.md)|  | [optional] 

### Return type

[**CallActionResponse**](CallActionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyoauth2challengeget"></a>
# **ApiProxyOauth2ChallengeGet**
> OAuth2ChallengeDtoResponse ApiProxyOauth2ChallengeGet (Guid? tenantId = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyOauth2ChallengeGetExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var tenantId = new Guid?(); // Guid? |  (optional) 

            try
            {
                OAuth2ChallengeDtoResponse result = apiInstance.ApiProxyOauth2ChallengeGet(tenantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyOauth2ChallengeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenantId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**OAuth2ChallengeDtoResponse**](OAuth2ChallengeDtoResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyunifiedcontactsexternalidget"></a>
# **ApiProxyUnifiedContactsExternalIdGet**
> UnifiedContactResponse ApiProxyUnifiedContactsExternalIdGet (string externalId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyUnifiedContactsExternalIdGetExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var externalId = externalId_example;  // string | 

            try
            {
                UnifiedContactResponse result = apiInstance.ApiProxyUnifiedContactsExternalIdGet(externalId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyUnifiedContactsExternalIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalId** | **string**|  | 

### Return type

[**UnifiedContactResponse**](UnifiedContactResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="apiproxyunifiedcontactsget"></a>
# **ApiProxyUnifiedContactsGet**
> UnifiedContactsListResponse ApiProxyUnifiedContactsGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApiProxyUnifiedContactsGetExample
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();

            try
            {
                UnifiedContactsListResponse result = apiInstance.ApiProxyUnifiedContactsGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiProxyApi.ApiProxyUnifiedContactsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**UnifiedContactsListResponse**](UnifiedContactsListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
