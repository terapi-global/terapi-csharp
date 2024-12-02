# IO.Swagger.Api.CategoryApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CategoryListGet**](CategoryApi.md#categorylistget) | **GET** /category/list | 19_999

<a name="categorylistget"></a>
# **CategoryListGet**
> CategoryListResponse CategoryListGet (int? page = null, int? perPage = null)

19_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 19_999_101 | UnknownExceptionWhenTryingFetchCategories | Unknown exception when fetching category. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoryListGetExample
    {
        public void main()
        {

            var apiInstance = new CategoryApi();
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 

            try
            {
                // 19_999
                CategoryListResponse result = apiInstance.CategoryListGet(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CategoryListGet: " + e.Message );
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

### Return type

[**CategoryListResponse**](CategoryListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
