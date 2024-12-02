# IO.Swagger.Api.ApplicationApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApplicationCreatePost**](ApplicationApi.md#applicationcreatepost) | **POST** /application/create | 15_999
[**ApplicationDeleteDelete**](ApplicationApi.md#applicationdeletedelete) | **DELETE** /application/delete | 15_997
[**ApplicationListGet**](ApplicationApi.md#applicationlistget) | **GET** /application/list | 15_996
[**ApplicationUpdatePut**](ApplicationApi.md#applicationupdateput) | **PUT** /application/update | 15_998

<a name="applicationcreatepost"></a>
# **ApplicationCreatePost**
> CreateApplicationResponse ApplicationCreatePost (ApplicationCreateBody body = null)

15_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 15_999_101 | ApplicationNameAlreadyExist | Application name already exists. |  | 15_999_102 | UnknownExceptionWhenValidateApplicationNameUniqueness | Unknown exception when validating application name uniqueness. |  | 15_999_103 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |  | 15_999_104 | UserNotFound | User not found. |  | 15_999_105 | UnknownExceptionWhenCreateOrganization |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationCreatePostExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApi();
            var body = new ApplicationCreateBody(); // ApplicationCreateBody |  (optional) 

            try
            {
                // 15_999
                CreateApplicationResponse result = apiInstance.ApplicationCreatePost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApplicationCreatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationCreateBody**](ApplicationCreateBody.md)|  | [optional] 

### Return type

[**CreateApplicationResponse**](CreateApplicationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationdeletedelete"></a>
# **ApplicationDeleteDelete**
> DeleteApplicationResponse ApplicationDeleteDelete (Guid? id = null)

15_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 15_997_101 | ApplicationNotFound | Application not found. |  | 15_997_102 | UnknownExceptionWhenFetchApplicationExistence | Unknown exception when fetching application existence. |  | 15_997_103 | UnknownExceptionWhenDeleteApplication | Unknown exception when deleting application. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationDeleteDeleteExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApi();
            var id = new Guid?(); // Guid? |  (optional) 

            try
            {
                // 15_997
                DeleteApplicationResponse result = apiInstance.ApplicationDeleteDelete(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApplicationDeleteDelete: " + e.Message );
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

[**DeleteApplicationResponse**](DeleteApplicationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationlistget"></a>
# **ApplicationListGet**
> UserApplicationListResponse ApplicationListGet (int? page = null, int? perPage = null)

15_996

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 15_996_101 | UnknownExceptionWhenTryingFetchApplications | Unknown exception when trying to fetch applications. |  | 15_996_102 | UserNotFound | User not found. |  | 15_996_103 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationListGetExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApi();
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 

            try
            {
                // 15_996
                UserApplicationListResponse result = apiInstance.ApplicationListGet(page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApplicationListGet: " + e.Message );
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

[**UserApplicationListResponse**](UserApplicationListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="applicationupdateput"></a>
# **ApplicationUpdatePut**
> UpdateApplicationResponse ApplicationUpdatePut (ApplicationUpdateBody body = null)

15_998

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 15_998_101 | ApplicationNotFound | Application not found. |  | 15_998_102 | UnknownExceptionWhenFetchApplication | Unknown exception when fetching application. |  | 15_998_103 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApplicationUpdatePutExample
    {
        public void main()
        {

            var apiInstance = new ApplicationApi();
            var body = new ApplicationUpdateBody(); // ApplicationUpdateBody |  (optional) 

            try
            {
                // 15_998
                UpdateApplicationResponse result = apiInstance.ApplicationUpdatePut(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationApi.ApplicationUpdatePut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationUpdateBody**](ApplicationUpdateBody.md)|  | [optional] 

### Return type

[**UpdateApplicationResponse**](UpdateApplicationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
