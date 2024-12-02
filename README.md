#  Terapi.Client .NET

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 111.4.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation

Run the following commands to generate the DLL
```
cd src/IO.Swagger
dotnet restore
dotnet build
```

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            var apiInstance = new ApiProxyApi();
            var integrationName = integrationName_example;  // string | 
            var endpoint = endpoint_example;  // string | 
            var xTenantId = new Guid?(); // Guid? | 
            var body = new ApiproxyEndpointBody6(); // ApiproxyEndpointBody6 |  (optional) 

            try
            {
                // 21_997
                CallActionResponse result = apiInstance.ApiProxyEndpointDelete(integrationName, endpoint, xTenantId, body);
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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to */*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApiProxyApi* | [**ApiProxyEndpointDelete**](docs/ApiProxyApi.md#apiproxyendpointdelete) | **DELETE** /api-proxy/{endpoint} | 21_997
*ApiProxyApi* | [**ApiProxyEndpointGet**](docs/ApiProxyApi.md#apiproxyendpointget) | **GET** /api-proxy/{endpoint} | 21_997
*ApiProxyApi* | [**ApiProxyEndpointPatch**](docs/ApiProxyApi.md#apiproxyendpointpatch) | **PATCH** /api-proxy/{endpoint} | 21_997
*ApiProxyApi* | [**ApiProxyEndpointPost**](docs/ApiProxyApi.md#apiproxyendpointpost) | **POST** /api-proxy/{endpoint} | 21_997
*ApiProxyApi* | [**ApiProxyEndpointPut**](docs/ApiProxyApi.md#apiproxyendpointput) | **PUT** /api-proxy/{endpoint} | 21_997
*ApiProxyApi* | [**ApiProxyOauth2ChallengeGet**](docs/ApiProxyApi.md#apiproxyoauth2challengeget) | **GET** /api-proxy/oauth2/challenge | 
*ApiProxyApi* | [**ApiProxyUnifiedContactsExternalIdGet**](docs/ApiProxyApi.md#apiproxyunifiedcontactsexternalidget) | **GET** /api-proxy/unified/contacts/{externalId} | 
*ApiProxyApi* | [**ApiProxyUnifiedContactsGet**](docs/ApiProxyApi.md#apiproxyunifiedcontactsget) | **GET** /api-proxy/unified/contacts | 
*ApplicationApi* | [**ApplicationCreatePost**](docs/ApplicationApi.md#applicationcreatepost) | **POST** /application/create | 15_999
*ApplicationApi* | [**ApplicationDeleteDelete**](docs/ApplicationApi.md#applicationdeletedelete) | **DELETE** /application/delete | 15_997
*ApplicationApi* | [**ApplicationListGet**](docs/ApplicationApi.md#applicationlistget) | **GET** /application/list | 15_996
*ApplicationApi* | [**ApplicationUpdatePut**](docs/ApplicationApi.md#applicationupdateput) | **PUT** /application/update | 15_998
*ApplicationApiKeyApi* | [**ApplicationApikeyGeneratePost**](docs/ApplicationApiKeyApi.md#applicationapikeygeneratepost) | **POST** /application-apikey/generate | 16_999
*ApplicationApiKeyApi* | [**ApplicationApikeyGetByApplicationIdGet**](docs/ApplicationApiKeyApi.md#applicationapikeygetbyapplicationidget) | **GET** /application-apikey/get-by-application-id | 16_995
*ApplicationApiKeyApi* | [**ApplicationApikeyRevokeDelete**](docs/ApplicationApiKeyApi.md#applicationapikeyrevokedelete) | **DELETE** /application-apikey/revoke | 16_998
*ApplicationIntegrationApi* | [**ApplicationIntegrationAddIntegrationToApplicationPost**](docs/ApplicationIntegrationApi.md#applicationintegrationaddintegrationtoapplicationpost) | **POST** /application-integration/add-integration-to-application | 18_999
*ApplicationIntegrationApi* | [**ApplicationIntegrationApplicationIntegrationListByApplicationIdGet**](docs/ApplicationIntegrationApi.md#applicationintegrationapplicationintegrationlistbyapplicationidget) | **GET** /application-integration/application-integration-list-by-application-id | 18_997
*AuthApi* | [**AuthAuthenticatePost**](docs/AuthApi.md#authauthenticatepost) | **POST** /auth/authenticate | 23_999
*AuthApi* | [**AuthRefreshPost**](docs/AuthApi.md#authrefreshpost) | **POST** /auth/refresh | 23_998
*CategoryApi* | [**CategoryListGet**](docs/CategoryApi.md#categorylistget) | **GET** /category/list | 19_999
*IntegrationApi* | [**IntegrationGetGet**](docs/IntegrationApi.md#integrationgetget) | **GET** /integration/get | 17_997
*IntegrationApi* | [**IntegrationListGet**](docs/IntegrationApi.md#integrationlistget) | **GET** /integration/list | 17_999
*StatisticsApi* | [**StatisticsUserProfileGet**](docs/StatisticsApi.md#statisticsuserprofileget) | **GET** /statistics/user-profile | 14_997
*TenantApi* | [**TenantDeclineTenantIdGet**](docs/TenantApi.md#tenantdeclinetenantidget) | **GET** /tenant/decline-tenant/{id} | 20_996
*TenantApi* | [**TenantInviteTenantByApplicationIntegrationIdPost**](docs/TenantApi.md#tenantinvitetenantbyapplicationintegrationidpost) | **POST** /tenant/invite-tenant-by-application-integration-id | 20_998
*TenantApi* | [**TenantInviteTenantPost**](docs/TenantApi.md#tenantinvitetenantpost) | **POST** /tenant/invite-tenant | 20_998
*TenantApi* | [**TenantUpdateTenantConnectionPost**](docs/TenantApi.md#tenantupdatetenantconnectionpost) | **POST** /tenant/update-tenant-connection | 20_997
*TenantApi* | [**TenantUserTenantListGet**](docs/TenantApi.md#tenantusertenantlistget) | **GET** /tenant/user-tenant-list | 20_999
*UserApi* | [**UserCreateOrGetUserProfilePost**](docs/UserApi.md#usercreateorgetuserprofilepost) | **POST** /user/create-or-get-user-profile | 14_998

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddIntegrationToApplicationError](docs/AddIntegrationToApplicationError.md)
 - [Model.AddIntegrationToApplicationRequest](docs/AddIntegrationToApplicationRequest.md)
 - [Model.AddIntegrationToApplicationRequestDto](docs/AddIntegrationToApplicationRequestDto.md)
 - [Model.AddIntegrationToApplicationRequestErrorCodes](docs/AddIntegrationToApplicationRequestErrorCodes.md)
 - [Model.AddIntegrationToApplicationResponse](docs/AddIntegrationToApplicationResponse.md)
 - [Model.AllOfAddIntegrationToApplicationErrorCode](docs/AllOfAddIntegrationToApplicationErrorCode.md)
 - [Model.AllOfAddIntegrationToApplicationErrorType](docs/AllOfAddIntegrationToApplicationErrorType.md)
 - [Model.AllOfAddIntegrationToApplicationRequestDto](docs/AllOfAddIntegrationToApplicationRequestDto.md)
 - [Model.AllOfAddIntegrationToApplicationResponseError](docs/AllOfAddIntegrationToApplicationResponseError.md)
 - [Model.AllOfApplicationApiKeyByApplicationIdErrorCode](docs/AllOfApplicationApiKeyByApplicationIdErrorCode.md)
 - [Model.AllOfApplicationApiKeyByApplicationIdErrorType](docs/AllOfApplicationApiKeyByApplicationIdErrorType.md)
 - [Model.AllOfApplicationApiKeyByApplicationIdResponseData](docs/AllOfApplicationApiKeyByApplicationIdResponseData.md)
 - [Model.AllOfApplicationApiKeyByApplicationIdResponseError](docs/AllOfApplicationApiKeyByApplicationIdResponseError.md)
 - [Model.AllOfApplicationIntegrationDtoApplication](docs/AllOfApplicationIntegrationDtoApplication.md)
 - [Model.AllOfApplicationIntegrationDtoIntegration](docs/AllOfApplicationIntegrationDtoIntegration.md)
 - [Model.AllOfApplicationIntegrationListByApplicationIdErrorCode](docs/AllOfApplicationIntegrationListByApplicationIdErrorCode.md)
 - [Model.AllOfApplicationIntegrationListByApplicationIdErrorType](docs/AllOfApplicationIntegrationListByApplicationIdErrorType.md)
 - [Model.AllOfApplicationIntegrationListByApplicationIdResponseData](docs/AllOfApplicationIntegrationListByApplicationIdResponseData.md)
 - [Model.AllOfApplicationIntegrationListByApplicationIdResponseError](docs/AllOfApplicationIntegrationListByApplicationIdResponseError.md)
 - [Model.AllOfCallActionErrorCode](docs/AllOfCallActionErrorCode.md)
 - [Model.AllOfCallActionErrorType](docs/AllOfCallActionErrorType.md)
 - [Model.AllOfCallActionResponseData](docs/AllOfCallActionResponseData.md)
 - [Model.AllOfCallActionResponseError](docs/AllOfCallActionResponseError.md)
 - [Model.AllOfCategoryListErrorCode](docs/AllOfCategoryListErrorCode.md)
 - [Model.AllOfCategoryListErrorType](docs/AllOfCategoryListErrorType.md)
 - [Model.AllOfCategoryListResponseData](docs/AllOfCategoryListResponseData.md)
 - [Model.AllOfCategoryListResponseError](docs/AllOfCategoryListResponseError.md)
 - [Model.AllOfCreateApplicationApiKeyErrorCode](docs/AllOfCreateApplicationApiKeyErrorCode.md)
 - [Model.AllOfCreateApplicationApiKeyErrorType](docs/AllOfCreateApplicationApiKeyErrorType.md)
 - [Model.AllOfCreateApplicationApiKeyRequestDto](docs/AllOfCreateApplicationApiKeyRequestDto.md)
 - [Model.AllOfCreateApplicationApiKeyResponseData](docs/AllOfCreateApplicationApiKeyResponseData.md)
 - [Model.AllOfCreateApplicationApiKeyResponseError](docs/AllOfCreateApplicationApiKeyResponseError.md)
 - [Model.AllOfCreateApplicationErrorCode](docs/AllOfCreateApplicationErrorCode.md)
 - [Model.AllOfCreateApplicationErrorType](docs/AllOfCreateApplicationErrorType.md)
 - [Model.AllOfCreateApplicationRequestDto](docs/AllOfCreateApplicationRequestDto.md)
 - [Model.AllOfCreateApplicationResponseData](docs/AllOfCreateApplicationResponseData.md)
 - [Model.AllOfCreateApplicationResponseError](docs/AllOfCreateApplicationResponseError.md)
 - [Model.AllOfCreateUserProfileErrorCode](docs/AllOfCreateUserProfileErrorCode.md)
 - [Model.AllOfCreateUserProfileErrorType](docs/AllOfCreateUserProfileErrorType.md)
 - [Model.AllOfCreateUserProfileResponseData](docs/AllOfCreateUserProfileResponseData.md)
 - [Model.AllOfCreateUserProfileResponseError](docs/AllOfCreateUserProfileResponseError.md)
 - [Model.AllOfDeclineTenantInvitationErrorCode](docs/AllOfDeclineTenantInvitationErrorCode.md)
 - [Model.AllOfDeclineTenantInvitationErrorType](docs/AllOfDeclineTenantInvitationErrorType.md)
 - [Model.AllOfDeclineTenantInvitationResponseError](docs/AllOfDeclineTenantInvitationResponseError.md)
 - [Model.AllOfDeleteApplicationErrorCode](docs/AllOfDeleteApplicationErrorCode.md)
 - [Model.AllOfDeleteApplicationErrorType](docs/AllOfDeleteApplicationErrorType.md)
 - [Model.AllOfDeleteApplicationResponseError](docs/AllOfDeleteApplicationResponseError.md)
 - [Model.AllOfErrorType](docs/AllOfErrorType.md)
 - [Model.AllOfGetAuthenticationTokenErrorCode](docs/AllOfGetAuthenticationTokenErrorCode.md)
 - [Model.AllOfGetAuthenticationTokenErrorType](docs/AllOfGetAuthenticationTokenErrorType.md)
 - [Model.AllOfGetAuthenticationTokenResponseData](docs/AllOfGetAuthenticationTokenResponseData.md)
 - [Model.AllOfGetAuthenticationTokenResponseError](docs/AllOfGetAuthenticationTokenResponseError.md)
 - [Model.AllOfGetOneIntegrationErrorCode](docs/AllOfGetOneIntegrationErrorCode.md)
 - [Model.AllOfGetOneIntegrationErrorType](docs/AllOfGetOneIntegrationErrorType.md)
 - [Model.AllOfGetOneIntegrationResponseData](docs/AllOfGetOneIntegrationResponseData.md)
 - [Model.AllOfGetOneIntegrationResponseError](docs/AllOfGetOneIntegrationResponseError.md)
 - [Model.AllOfIntegrationDtoReleaseStatus](docs/AllOfIntegrationDtoReleaseStatus.md)
 - [Model.AllOfIntegrationListErrorCode](docs/AllOfIntegrationListErrorCode.md)
 - [Model.AllOfIntegrationListErrorType](docs/AllOfIntegrationListErrorType.md)
 - [Model.AllOfIntegrationListResponseData](docs/AllOfIntegrationListResponseData.md)
 - [Model.AllOfIntegrationListResponseError](docs/AllOfIntegrationListResponseError.md)
 - [Model.AllOfInviteTenantByApplicationIntegrationIdErrorCode](docs/AllOfInviteTenantByApplicationIntegrationIdErrorCode.md)
 - [Model.AllOfInviteTenantByApplicationIntegrationIdErrorType](docs/AllOfInviteTenantByApplicationIntegrationIdErrorType.md)
 - [Model.AllOfInviteTenantByApplicationIntegrationIdRequestDto](docs/AllOfInviteTenantByApplicationIntegrationIdRequestDto.md)
 - [Model.AllOfInviteTenantByApplicationIntegrationIdResponseData](docs/AllOfInviteTenantByApplicationIntegrationIdResponseData.md)
 - [Model.AllOfInviteTenantByApplicationIntegrationIdResponseError](docs/AllOfInviteTenantByApplicationIntegrationIdResponseError.md)
 - [Model.AllOfInviteTenantErrorCode](docs/AllOfInviteTenantErrorCode.md)
 - [Model.AllOfInviteTenantErrorType](docs/AllOfInviteTenantErrorType.md)
 - [Model.AllOfInviteTenantRequestDto](docs/AllOfInviteTenantRequestDto.md)
 - [Model.AllOfInviteTenantResponseData](docs/AllOfInviteTenantResponseData.md)
 - [Model.AllOfInviteTenantResponseError](docs/AllOfInviteTenantResponseError.md)
 - [Model.AllOfOAuth2ChallengeDtoResponseData](docs/AllOfOAuth2ChallengeDtoResponseData.md)
 - [Model.AllOfOAuth2ChallengeDtoResponseError](docs/AllOfOAuth2ChallengeDtoResponseError.md)
 - [Model.AllOfOAuth2ChallengeDtoTokens](docs/AllOfOAuth2ChallengeDtoTokens.md)
 - [Model.AllOfRefreshAuthenticationTokenErrorCode](docs/AllOfRefreshAuthenticationTokenErrorCode.md)
 - [Model.AllOfRefreshAuthenticationTokenErrorType](docs/AllOfRefreshAuthenticationTokenErrorType.md)
 - [Model.AllOfRefreshAuthenticationTokenResponseData](docs/AllOfRefreshAuthenticationTokenResponseData.md)
 - [Model.AllOfRefreshAuthenticationTokenResponseError](docs/AllOfRefreshAuthenticationTokenResponseError.md)
 - [Model.AllOfResponseError](docs/AllOfResponseError.md)
 - [Model.AllOfRevokeApplicationApiKeyErrorCode](docs/AllOfRevokeApplicationApiKeyErrorCode.md)
 - [Model.AllOfRevokeApplicationApiKeyErrorType](docs/AllOfRevokeApplicationApiKeyErrorType.md)
 - [Model.AllOfRevokeApplicationApiKeyResponseError](docs/AllOfRevokeApplicationApiKeyResponseError.md)
 - [Model.AllOfTenantDtoApplicationIntegration](docs/AllOfTenantDtoApplicationIntegration.md)
 - [Model.AllOfTenantDtoInvitationStatus](docs/AllOfTenantDtoInvitationStatus.md)
 - [Model.AllOfUnifiedContactResponseData](docs/AllOfUnifiedContactResponseData.md)
 - [Model.AllOfUnifiedContactResponseError](docs/AllOfUnifiedContactResponseError.md)
 - [Model.AllOfUnifiedContactsListResponseData](docs/AllOfUnifiedContactsListResponseData.md)
 - [Model.AllOfUnifiedContactsListResponseError](docs/AllOfUnifiedContactsListResponseError.md)
 - [Model.AllOfUpdateApplicationErrorCode](docs/AllOfUpdateApplicationErrorCode.md)
 - [Model.AllOfUpdateApplicationErrorType](docs/AllOfUpdateApplicationErrorType.md)
 - [Model.AllOfUpdateApplicationRequestDto](docs/AllOfUpdateApplicationRequestDto.md)
 - [Model.AllOfUpdateApplicationResponseData](docs/AllOfUpdateApplicationResponseData.md)
 - [Model.AllOfUpdateApplicationResponseError](docs/AllOfUpdateApplicationResponseError.md)
 - [Model.AllOfUpdateTenantConnectionErrorCode](docs/AllOfUpdateTenantConnectionErrorCode.md)
 - [Model.AllOfUpdateTenantConnectionErrorType](docs/AllOfUpdateTenantConnectionErrorType.md)
 - [Model.AllOfUpdateTenantConnectionRequestDto](docs/AllOfUpdateTenantConnectionRequestDto.md)
 - [Model.AllOfUpdateTenantConnectionResponseError](docs/AllOfUpdateTenantConnectionResponseError.md)
 - [Model.AllOfUserApplicationListErrorCode](docs/AllOfUserApplicationListErrorCode.md)
 - [Model.AllOfUserApplicationListErrorType](docs/AllOfUserApplicationListErrorType.md)
 - [Model.AllOfUserApplicationListResponseData](docs/AllOfUserApplicationListResponseData.md)
 - [Model.AllOfUserApplicationListResponseError](docs/AllOfUserApplicationListResponseError.md)
 - [Model.AllOfUserProfileStatisticsErrorCode](docs/AllOfUserProfileStatisticsErrorCode.md)
 - [Model.AllOfUserProfileStatisticsErrorType](docs/AllOfUserProfileStatisticsErrorType.md)
 - [Model.AllOfUserProfileStatisticsResponseData](docs/AllOfUserProfileStatisticsResponseData.md)
 - [Model.AllOfUserProfileStatisticsResponseError](docs/AllOfUserProfileStatisticsResponseError.md)
 - [Model.AllOfUserTenantListErrorCode](docs/AllOfUserTenantListErrorCode.md)
 - [Model.AllOfUserTenantListErrorType](docs/AllOfUserTenantListErrorType.md)
 - [Model.AllOfUserTenantListResponseData](docs/AllOfUserTenantListResponseData.md)
 - [Model.AllOfUserTenantListResponseError](docs/AllOfUserTenantListResponseError.md)
 - [Model.ApiproxyEndpointBody](docs/ApiproxyEndpointBody.md)
 - [Model.ApiproxyEndpointBody1](docs/ApiproxyEndpointBody1.md)
 - [Model.ApiproxyEndpointBody10](docs/ApiproxyEndpointBody10.md)
 - [Model.ApiproxyEndpointBody11](docs/ApiproxyEndpointBody11.md)
 - [Model.ApiproxyEndpointBody2](docs/ApiproxyEndpointBody2.md)
 - [Model.ApiproxyEndpointBody3](docs/ApiproxyEndpointBody3.md)
 - [Model.ApiproxyEndpointBody4](docs/ApiproxyEndpointBody4.md)
 - [Model.ApiproxyEndpointBody5](docs/ApiproxyEndpointBody5.md)
 - [Model.ApiproxyEndpointBody6](docs/ApiproxyEndpointBody6.md)
 - [Model.ApiproxyEndpointBody7](docs/ApiproxyEndpointBody7.md)
 - [Model.ApiproxyEndpointBody8](docs/ApiproxyEndpointBody8.md)
 - [Model.ApiproxyEndpointBody9](docs/ApiproxyEndpointBody9.md)
 - [Model.ApplicationApiKeyByApplicationIdError](docs/ApplicationApiKeyByApplicationIdError.md)
 - [Model.ApplicationApiKeyByApplicationIdErrorCodes](docs/ApplicationApiKeyByApplicationIdErrorCodes.md)
 - [Model.ApplicationApiKeyByApplicationIdResponse](docs/ApplicationApiKeyByApplicationIdResponse.md)
 - [Model.ApplicationApiKeyDto](docs/ApplicationApiKeyDto.md)
 - [Model.ApplicationCreateBody](docs/ApplicationCreateBody.md)
 - [Model.ApplicationCreateBody1](docs/ApplicationCreateBody1.md)
 - [Model.ApplicationCreateBody2](docs/ApplicationCreateBody2.md)
 - [Model.ApplicationDto](docs/ApplicationDto.md)
 - [Model.ApplicationIntegrationDto](docs/ApplicationIntegrationDto.md)
 - [Model.ApplicationIntegrationListByApplicationIdError](docs/ApplicationIntegrationListByApplicationIdError.md)
 - [Model.ApplicationIntegrationListByApplicationIdRequestErrorCodes](docs/ApplicationIntegrationListByApplicationIdRequestErrorCodes.md)
 - [Model.ApplicationIntegrationListByApplicationIdResponse](docs/ApplicationIntegrationListByApplicationIdResponse.md)
 - [Model.ApplicationIntegrationListDto](docs/ApplicationIntegrationListDto.md)
 - [Model.ApplicationListDto](docs/ApplicationListDto.md)
 - [Model.ApplicationUpdateBody](docs/ApplicationUpdateBody.md)
 - [Model.ApplicationUpdateBody1](docs/ApplicationUpdateBody1.md)
 - [Model.ApplicationUpdateBody2](docs/ApplicationUpdateBody2.md)
 - [Model.ApplicationapikeyGenerateBody](docs/ApplicationapikeyGenerateBody.md)
 - [Model.ApplicationapikeyGenerateBody1](docs/ApplicationapikeyGenerateBody1.md)
 - [Model.ApplicationapikeyGenerateBody2](docs/ApplicationapikeyGenerateBody2.md)
 - [Model.ApplicationintegrationAddintegrationtoapplicationBody](docs/ApplicationintegrationAddintegrationtoapplicationBody.md)
 - [Model.ApplicationintegrationAddintegrationtoapplicationBody1](docs/ApplicationintegrationAddintegrationtoapplicationBody1.md)
 - [Model.ApplicationintegrationAddintegrationtoapplicationBody2](docs/ApplicationintegrationAddintegrationtoapplicationBody2.md)
 - [Model.CallActionBodyDto](docs/CallActionBodyDto.md)
 - [Model.CallActionDto](docs/CallActionDto.md)
 - [Model.CallActionError](docs/CallActionError.md)
 - [Model.CallActionErrorCodes](docs/CallActionErrorCodes.md)
 - [Model.CallActionResponse](docs/CallActionResponse.md)
 - [Model.CategoryDto](docs/CategoryDto.md)
 - [Model.CategoryListDto](docs/CategoryListDto.md)
 - [Model.CategoryListError](docs/CategoryListError.md)
 - [Model.CategoryListRequestErrorCodes](docs/CategoryListRequestErrorCodes.md)
 - [Model.CategoryListResponse](docs/CategoryListResponse.md)
 - [Model.ClientErrorType](docs/ClientErrorType.md)
 - [Model.CreateApplicationApiKeyError](docs/CreateApplicationApiKeyError.md)
 - [Model.CreateApplicationApiKeyRequest](docs/CreateApplicationApiKeyRequest.md)
 - [Model.CreateApplicationApiKeyRequestDto](docs/CreateApplicationApiKeyRequestDto.md)
 - [Model.CreateApplicationApiKeyRequestErrorCodes](docs/CreateApplicationApiKeyRequestErrorCodes.md)
 - [Model.CreateApplicationApiKeyResponse](docs/CreateApplicationApiKeyResponse.md)
 - [Model.CreateApplicationError](docs/CreateApplicationError.md)
 - [Model.CreateApplicationRequest](docs/CreateApplicationRequest.md)
 - [Model.CreateApplicationRequestDto](docs/CreateApplicationRequestDto.md)
 - [Model.CreateApplicationRequestErrorCodes](docs/CreateApplicationRequestErrorCodes.md)
 - [Model.CreateApplicationResponse](docs/CreateApplicationResponse.md)
 - [Model.CreateUserProfileError](docs/CreateUserProfileError.md)
 - [Model.CreateUserProfileRequestErrorCodes](docs/CreateUserProfileRequestErrorCodes.md)
 - [Model.CreateUserProfileResponse](docs/CreateUserProfileResponse.md)
 - [Model.DeclineTenantInvitationError](docs/DeclineTenantInvitationError.md)
 - [Model.DeclineTenantInvitationRequestErrorCodes](docs/DeclineTenantInvitationRequestErrorCodes.md)
 - [Model.DeclineTenantInvitationResponse](docs/DeclineTenantInvitationResponse.md)
 - [Model.DeleteApplicationError](docs/DeleteApplicationError.md)
 - [Model.DeleteApplicationRequestErrorCodes](docs/DeleteApplicationRequestErrorCodes.md)
 - [Model.DeleteApplicationResponse](docs/DeleteApplicationResponse.md)
 - [Model.Error](docs/Error.md)
 - [Model.GetAuthenticationTokenDto](docs/GetAuthenticationTokenDto.md)
 - [Model.GetAuthenticationTokenError](docs/GetAuthenticationTokenError.md)
 - [Model.GetAuthenticationTokenRequestErrorCodes](docs/GetAuthenticationTokenRequestErrorCodes.md)
 - [Model.GetAuthenticationTokenResponse](docs/GetAuthenticationTokenResponse.md)
 - [Model.GetOneIntegrationError](docs/GetOneIntegrationError.md)
 - [Model.GetOneIntegrationRequestErrorCodes](docs/GetOneIntegrationRequestErrorCodes.md)
 - [Model.GetOneIntegrationResponse](docs/GetOneIntegrationResponse.md)
 - [Model.IntegrationDto](docs/IntegrationDto.md)
 - [Model.IntegrationEndpointDto](docs/IntegrationEndpointDto.md)
 - [Model.IntegrationEventDto](docs/IntegrationEventDto.md)
 - [Model.IntegrationFieldDto](docs/IntegrationFieldDto.md)
 - [Model.IntegrationListDto](docs/IntegrationListDto.md)
 - [Model.IntegrationListError](docs/IntegrationListError.md)
 - [Model.IntegrationListRequestErrorCodes](docs/IntegrationListRequestErrorCodes.md)
 - [Model.IntegrationListResponse](docs/IntegrationListResponse.md)
 - [Model.InvitationStatus](docs/InvitationStatus.md)
 - [Model.InvitationStatus1](docs/InvitationStatus1.md)
 - [Model.InviteTenantByApplicationIntegrationIdError](docs/InviteTenantByApplicationIntegrationIdError.md)
 - [Model.InviteTenantByApplicationIntegrationIdRequest](docs/InviteTenantByApplicationIntegrationIdRequest.md)
 - [Model.InviteTenantByApplicationIntegrationIdRequestDto](docs/InviteTenantByApplicationIntegrationIdRequestDto.md)
 - [Model.InviteTenantByApplicationIntegrationIdResponse](docs/InviteTenantByApplicationIntegrationIdResponse.md)
 - [Model.InviteTenantError](docs/InviteTenantError.md)
 - [Model.InviteTenantRequest](docs/InviteTenantRequest.md)
 - [Model.InviteTenantRequestDto](docs/InviteTenantRequestDto.md)
 - [Model.InviteTenantRequestErrorCodes](docs/InviteTenantRequestErrorCodes.md)
 - [Model.InviteTenantResponse](docs/InviteTenantResponse.md)
 - [Model.OAuth2ChallengeDto](docs/OAuth2ChallengeDto.md)
 - [Model.OAuth2ChallengeDtoResponse](docs/OAuth2ChallengeDtoResponse.md)
 - [Model.OAuth2ChallengeTokenDto](docs/OAuth2ChallengeTokenDto.md)
 - [Model.RefreshAuthenticationTokenDto](docs/RefreshAuthenticationTokenDto.md)
 - [Model.RefreshAuthenticationTokenError](docs/RefreshAuthenticationTokenError.md)
 - [Model.RefreshAuthenticationTokenRequestErrorCodes](docs/RefreshAuthenticationTokenRequestErrorCodes.md)
 - [Model.RefreshAuthenticationTokenResponse](docs/RefreshAuthenticationTokenResponse.md)
 - [Model.ReleaseStatus](docs/ReleaseStatus.md)
 - [Model.Response](docs/Response.md)
 - [Model.RevokeApplicationApiKeyError](docs/RevokeApplicationApiKeyError.md)
 - [Model.RevokeApplicationApiKeyRequestErrorCodes](docs/RevokeApplicationApiKeyRequestErrorCodes.md)
 - [Model.RevokeApplicationApiKeyResponse](docs/RevokeApplicationApiKeyResponse.md)
 - [Model.TenantDto](docs/TenantDto.md)
 - [Model.TenantInvitetenantBody](docs/TenantInvitetenantBody.md)
 - [Model.TenantInvitetenantBody1](docs/TenantInvitetenantBody1.md)
 - [Model.TenantInvitetenantBody2](docs/TenantInvitetenantBody2.md)
 - [Model.TenantInvitetenantbyapplicationintegrationidBody](docs/TenantInvitetenantbyapplicationintegrationidBody.md)
 - [Model.TenantInvitetenantbyapplicationintegrationidBody1](docs/TenantInvitetenantbyapplicationintegrationidBody1.md)
 - [Model.TenantInvitetenantbyapplicationintegrationidBody2](docs/TenantInvitetenantbyapplicationintegrationidBody2.md)
 - [Model.TenantListDto](docs/TenantListDto.md)
 - [Model.TenantUpdatetenantconnectionBody](docs/TenantUpdatetenantconnectionBody.md)
 - [Model.TenantUpdatetenantconnectionBody1](docs/TenantUpdatetenantconnectionBody1.md)
 - [Model.TenantUpdatetenantconnectionBody2](docs/TenantUpdatetenantconnectionBody2.md)
 - [Model.UnifiedContact](docs/UnifiedContact.md)
 - [Model.UnifiedContactResponse](docs/UnifiedContactResponse.md)
 - [Model.UnifiedContactsList](docs/UnifiedContactsList.md)
 - [Model.UnifiedContactsListResponse](docs/UnifiedContactsListResponse.md)
 - [Model.UpdateApplicationError](docs/UpdateApplicationError.md)
 - [Model.UpdateApplicationRequest](docs/UpdateApplicationRequest.md)
 - [Model.UpdateApplicationRequestDto](docs/UpdateApplicationRequestDto.md)
 - [Model.UpdateApplicationRequestErrorCodes](docs/UpdateApplicationRequestErrorCodes.md)
 - [Model.UpdateApplicationResponse](docs/UpdateApplicationResponse.md)
 - [Model.UpdateTenantConnectionError](docs/UpdateTenantConnectionError.md)
 - [Model.UpdateTenantConnectionRequest](docs/UpdateTenantConnectionRequest.md)
 - [Model.UpdateTenantConnectionRequestDto](docs/UpdateTenantConnectionRequestDto.md)
 - [Model.UpdateTenantConnectionRequestErrorCodes](docs/UpdateTenantConnectionRequestErrorCodes.md)
 - [Model.UpdateTenantConnectionResponse](docs/UpdateTenantConnectionResponse.md)
 - [Model.UserApplicationListError](docs/UserApplicationListError.md)
 - [Model.UserApplicationListRequestErrorCodes](docs/UserApplicationListRequestErrorCodes.md)
 - [Model.UserApplicationListResponse](docs/UserApplicationListResponse.md)
 - [Model.UserDto](docs/UserDto.md)
 - [Model.UserProfileStatisticsDto](docs/UserProfileStatisticsDto.md)
 - [Model.UserProfileStatisticsError](docs/UserProfileStatisticsError.md)
 - [Model.UserProfileStatisticsErrorCodes](docs/UserProfileStatisticsErrorCodes.md)
 - [Model.UserProfileStatisticsResponse](docs/UserProfileStatisticsResponse.md)
 - [Model.UserTenantListError](docs/UserTenantListError.md)
 - [Model.UserTenantListRequestErrorCodes](docs/UserTenantListRequestErrorCodes.md)
 - [Model.UserTenantListResponse](docs/UserTenantListResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Bearer"></a>
### Bearer


