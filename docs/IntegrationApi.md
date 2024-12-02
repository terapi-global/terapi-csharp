# IO.Swagger.Api.IntegrationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationGetGet**](IntegrationApi.md#integrationgetget) | **GET** /integration/get | 17_997
[**IntegrationListGet**](IntegrationApi.md#integrationlistget) | **GET** /integration/list | 17_999

<a name="integrationgetget"></a>
# **IntegrationGetGet**
> GetOneIntegrationResponse IntegrationGetGet (Guid? id = null)

17_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 17_997_101 | UnknownExceptionWhenTryingFetchOneIntegration |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationGetGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationApi();
            var id = new Guid?(); // Guid? |  (optional) 

            try
            {
                // 17_997
                GetOneIntegrationResponse result = apiInstance.IntegrationGetGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.IntegrationGetGet: " + e.Message );
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

[**GetOneIntegrationResponse**](GetOneIntegrationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="integrationlistget"></a>
# **IntegrationListGet**
> IntegrationListResponse IntegrationListGet (int? page = null, int? perPage = null, string searchKeyword = null, Guid? categoryId = null)

17_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 17_999_101 | UnknownExceptionWhenTryingFetchIntegrations | Unknown exception when trying to fetch integrations. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationListGetExample
    {
        public void main()
        {

            var apiInstance = new IntegrationApi();
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 
            var searchKeyword = searchKeyword_example;  // string |  (optional) 
            var categoryId = new Guid?(); // Guid? |  (optional) 

            try
            {
                // 17_999
                IntegrationListResponse result = apiInstance.IntegrationListGet(page, perPage, searchKeyword, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationApi.IntegrationListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**|  | [optional] 
 **perPage** | **int?**|  | [optional] 
 **searchKeyword** | **string**|  | [optional] 
 **categoryId** | [**Guid?**](Guid?.md)|  | [optional] 

### Return type

[**IntegrationListResponse**](IntegrationListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
