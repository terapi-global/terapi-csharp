# IO.Swagger.Api.TenantApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TenantDeclineTenantIdGet**](TenantApi.md#tenantdeclinetenantidget) | **GET** /tenant/decline-tenant/{id} | 20_996
[**TenantInviteTenantByApplicationIntegrationIdPost**](TenantApi.md#tenantinvitetenantbyapplicationintegrationidpost) | **POST** /tenant/invite-tenant-by-application-integration-id | 20_998
[**TenantInviteTenantPost**](TenantApi.md#tenantinvitetenantpost) | **POST** /tenant/invite-tenant | 20_998
[**TenantUpdateTenantConnectionPost**](TenantApi.md#tenantupdatetenantconnectionpost) | **POST** /tenant/update-tenant-connection | 20_997
[**TenantUserTenantListGet**](TenantApi.md#tenantusertenantlistget) | **GET** /tenant/user-tenant-list | 20_999

<a name="tenantdeclinetenantidget"></a>
# **TenantDeclineTenantIdGet**
> DeclineTenantInvitationResponse TenantDeclineTenantIdGet (Guid? id)

20_996

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 20_996_101 | TenantNotFound | Tenant Not Found |  | 20_996_102 | UnknownExceptionWhileFetchingTenant | Unknown exception when checking tenant existence. |  | 20_996_103 | UnknownExceptionWhileDecliningTenant | Unknown exception when declining tenant. |  | 20_996_104 | TenantIsNotInInvitedStatus |  |  | 20_996_105 | UnknownExceptionWhileCheckingIfTenantIsInCorrectStatus |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantDeclineTenantIdGetExample
    {
        public void main()
        {

            var apiInstance = new TenantApi();
            var id = new Guid?(); // Guid? | 

            try
            {
                // 20_996
                DeclineTenantInvitationResponse result = apiInstance.TenantDeclineTenantIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.TenantDeclineTenantIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)|  | 

### Return type

[**DeclineTenantInvitationResponse**](DeclineTenantInvitationResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tenantinvitetenantbyapplicationintegrationidpost"></a>
# **TenantInviteTenantByApplicationIntegrationIdPost**
> InviteTenantByApplicationIntegrationIdResponse TenantInviteTenantByApplicationIntegrationIdPost (TenantInvitetenantbyapplicationintegrationidBody body = null)

20_998

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 20_998_101 | ApplicationIntegrationNotFound | Application integration not found. |  | 20_998_102 | UnknownExceptionWhenCheckApplicationExistence | Unknown exception when checking application existence. |  | 20_998_103 | UnknownExceptionWhenCreateTenant | Unknown exception when createing tenant. |  | 20_998_104 | UnknownExceptionWhenSendingEmailToInvitedEmailAddress | Unknown exception when sending email to invited email address. |  | 20_998_105 | UserNotFound | User not found. |  | 20_998_106 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |  | 20_998_107 | UnknownExceptionWhenCreateUserTenant | Unknown exception when creating user tenant. |  | 20_998_108 | UnknownExceptionWhenCreatingEmailContent | Unknown exception when creating email content. |  | 20_998_109 | UnknownExceptionWhenCreatingEmailAcceptInvitationUrl |  |  | 20_998_110 | UnknownExceptionWhenAddingTenantInKeycloak |  |  | 20_998_111 | UnknownExceptionWhenAddingTenantInOrganization |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantInviteTenantByApplicationIntegrationIdPostExample
    {
        public void main()
        {

            var apiInstance = new TenantApi();
            var body = new TenantInvitetenantbyapplicationintegrationidBody(); // TenantInvitetenantbyapplicationintegrationidBody |  (optional) 

            try
            {
                // 20_998
                InviteTenantByApplicationIntegrationIdResponse result = apiInstance.TenantInviteTenantByApplicationIntegrationIdPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.TenantInviteTenantByApplicationIntegrationIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantInvitetenantbyapplicationintegrationidBody**](TenantInvitetenantbyapplicationintegrationidBody.md)|  | [optional] 

### Return type

[**InviteTenantByApplicationIntegrationIdResponse**](InviteTenantByApplicationIntegrationIdResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tenantinvitetenantpost"></a>
# **TenantInviteTenantPost**
> InviteTenantResponse TenantInviteTenantPost (TenantInvitetenantBody body = null)

20_998

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 20_998_101 | ApplicationIntegrationNotFound | Application integration not found. |  | 20_998_102 | UnknownExceptionWhenCheckApplicationExistence | Unknown exception when checking application existence. |  | 20_998_103 | UnknownExceptionWhenCreateTenant | Unknown exception when createing tenant. |  | 20_998_104 | UnknownExceptionWhenSendingEmailToInvitedEmailAddress | Unknown exception when sending email to invited email address. |  | 20_998_105 | UserNotFound | User not found. |  | 20_998_106 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |  | 20_998_107 | UnknownExceptionWhenCreateUserTenant | Unknown exception when creating user tenant. |  | 20_998_108 | UnknownExceptionWhenCreatingEmailContent | Unknown exception when creating email content. |  | 20_998_109 | UnknownExceptionWhenCreatingEmailAcceptInvitationUrl |  |  | 20_998_110 | UnknownExceptionWhenAddingTenantInKeycloak |  |  | 20_998_111 | UnknownExceptionWhenAddingTenantInOrganization |  |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantInviteTenantPostExample
    {
        public void main()
        {

            var apiInstance = new TenantApi();
            var body = new TenantInvitetenantBody(); // TenantInvitetenantBody |  (optional) 

            try
            {
                // 20_998
                InviteTenantResponse result = apiInstance.TenantInviteTenantPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.TenantInviteTenantPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantInvitetenantBody**](TenantInvitetenantBody.md)|  | [optional] 

### Return type

[**InviteTenantResponse**](InviteTenantResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tenantupdatetenantconnectionpost"></a>
# **TenantUpdateTenantConnectionPost**
> UpdateTenantConnectionResponse TenantUpdateTenantConnectionPost (TenantUpdatetenantconnectionBody body = null)

20_997

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 20_997_101 | TenantNotFound | Tenant not found. |  | 20_997_102 | UnknownExceptionWhenCheckTenantExistence | Unknown exception when checking tenant existence. |  | 20_997_103 | UnknownExceptionWhenUpdateTenantConnection | Unknown exception when updating tenant connection. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantUpdateTenantConnectionPostExample
    {
        public void main()
        {

            var apiInstance = new TenantApi();
            var body = new TenantUpdatetenantconnectionBody(); // TenantUpdatetenantconnectionBody |  (optional) 

            try
            {
                // 20_997
                UpdateTenantConnectionResponse result = apiInstance.TenantUpdateTenantConnectionPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.TenantUpdateTenantConnectionPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantUpdatetenantconnectionBody**](TenantUpdatetenantconnectionBody.md)|  | [optional] 

### Return type

[**UpdateTenantConnectionResponse**](UpdateTenantConnectionResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="tenantusertenantlistget"></a>
# **TenantUserTenantListGet**
> UserTenantListResponse TenantUserTenantListGet (InvitationStatus1 invitationStatus = null, int? page = null, int? perPage = null)

20_999

### Error Codes  | Code | Name | Message |  | :- -- | :- -- | :- -- |  | 20_999_101 | UnknownExceptionWhenTryingFetchTenants | Unknown exception when trying to fetch tenants. |  | 20_999_102 | UserNotFound | User not found. |  | 20_999_103 | UnknownExceptionWhenInsertApplication | Unknown exception when inserting application. |

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantUserTenantListGetExample
    {
        public void main()
        {

            var apiInstance = new TenantApi();
            var invitationStatus = new InvitationStatus1(); // InvitationStatus1 |   0 = Invited  1 = Accepted  2 = Declined (optional) 
            var page = 56;  // int? |  (optional) 
            var perPage = 56;  // int? |  (optional) 

            try
            {
                // 20_999
                UserTenantListResponse result = apiInstance.TenantUserTenantListGet(invitationStatus, page, perPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantApi.TenantUserTenantListGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invitationStatus** | [**InvitationStatus1**](InvitationStatus1.md)|   0 &#x3D; Invited  1 &#x3D; Accepted  2 &#x3D; Declined | [optional] 
 **page** | **int?**|  | [optional] 
 **perPage** | **int?**|  | [optional] 

### Return type

[**UserTenantListResponse**](UserTenantListResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
