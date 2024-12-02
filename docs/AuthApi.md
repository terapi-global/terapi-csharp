# IO.Swagger.Api.AuthApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthAuthenticatePost**](AuthApi.md#authauthenticatepost) | **POST** /auth/authenticate | 23_999
[**AuthRefreshPost**](AuthApi.md#authrefreshpost) | **POST** /auth/refresh | 23_998

<a name="authauthenticatepost"></a>
# **AuthAuthenticatePost**
> GetAuthenticationTokenResponse AuthAuthenticatePost (string secretKey = null)

23_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 23_999_101 | UnknownExceptionWhenTryingFetchApplicationApiKey |  |  | 23_999_102 | FailedToFindApplicationApiKey |  |  | 23_999_103 | UnknownExceptionWhenTryingToGetUserAuthenticationToken |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthAuthenticatePostExample
    {
        public void main()
        {

            var apiInstance = new AuthApi();
            var secretKey = secretKey_example;  // string |  (optional) 

            try
            {
                // 23_999
                GetAuthenticationTokenResponse result = apiInstance.AuthAuthenticatePost(secretKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthAuthenticatePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **secretKey** | **string**|  | [optional] 

### Return type

[**GetAuthenticationTokenResponse**](GetAuthenticationTokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="authrefreshpost"></a>
# **AuthRefreshPost**
> RefreshAuthenticationTokenResponse AuthRefreshPost (string refreshToken = null)

23_998

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 23_998_101 | UnknownExceptionWhenTryingToRefreshUserAuthenticationToken |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthRefreshPostExample
    {
        public void main()
        {

            var apiInstance = new AuthApi();
            var refreshToken = refreshToken_example;  // string |  (optional) 

            try
            {
                // 23_998
                RefreshAuthenticationTokenResponse result = apiInstance.AuthRefreshPost(refreshToken);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthApi.AuthRefreshPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **refreshToken** | **string**|  | [optional] 

### Return type

[**RefreshAuthenticationTokenResponse**](RefreshAuthenticationTokenResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
