# Subscriptions

```csharp
SubscriptionsController subscriptionsController = client.SubscriptionsController;
```

## Class Name

`SubscriptionsController`

## Methods

* [Update Subscription](../../doc/controllers/subscriptions.md#update-subscription)
* [Cancel Subscription](../../doc/controllers/subscriptions.md#cancel-subscription)
* [Aggregate Subscription](../../doc/controllers/subscriptions.md#aggregate-subscription)
* [Expire Subscriptions](../../doc/controllers/subscriptions.md#expire-subscriptions)


# Update Subscription

```csharp
UpdateSubscriptionAsync(
    string xUserId,
    string xAuthorization,
    Models.UpdateSubscription body,
    string xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xUserId` | `string` | Header, Required | UserId of an user who bought a subscription. This will be an IES userId |
| `xAuthorization` | `string` | Header, Required | This will be an IES system token |
| `body` | [`UpdateSubscription`](../../doc/models/update-subscription.md) | Body, Required | Data |
| `xTransactionId` | `string` | Header, Optional | Unique ID for a transaction |

## Response Type

[`Task<Models.OrderRespType>`](../../doc/models/order-resp-type.md)

## Example Usage

```csharp
string xUserId = "X-UserId4";
string xAuthorization = "X-Authorization6";
UpdateSubscription body = new UpdateSubscription
{
    OrderType = OrderTypeEnum.UPGRADE,
    OrderNumber = "10034567",
    Description = "Sample description of the API",
    ExistingAccountNumber = "A000000001",
    UpdateSubscriptionProducts = new List<Product>
    {
        new Product
        {
            Isbn = "20045634128",
            Ppid = "A101702992101",
            EndDate = "2021-05-14T07:12:27.152-0500",
        },
        new Product
        {
            Isbn = "10045634128",
            Ppid = "A101702992102",
            EndDate = "2021-05-14T07:12:27.152-0500",
        },
    },
    CustomFields = new List<CustomField>
    {
        new CustomField
        {
            Name = "paymentMethod__c",
            MValue = "CREDIT CARD",
        },
        new CustomField
        {
            Name = "paymentInfo__c",
            MValue = "CREDIT CARD",
        },
        new CustomField
        {
            Name = "paymentToken__c",
            MValue = "4111111111111111",
        },
        new CustomField
        {
            Name = "iesId__c",
            MValue = "ea9mmnj1qe2tghnb3",
        },
        new CustomField
        {
            Name = "hybrisAccountNumber__c",
            MValue = "456",
        },
        new CustomField
        {
            Name = "tepAccountNumber__c",
            MValue = "c123",
        },
        new CustomField
        {
            Name = "institutionId__c",
            MValue = "5678",
        },
        new CustomField
        {
            Name = "tepPartyId__c",
            MValue = "GH6789",
        },
        new CustomField
        {
            Name = "campaignName__c",
            MValue = "test val",
        },
        new CustomField
        {
            Name = "promoCode__c",
            MValue = "PM10",
        },
        new CustomField
        {
            Name = "couponCode__c",
            MValue = "BA10",
        },
        new CustomField
        {
            Name = "discountCodeStartDate__c",
            MValue = "2021-09-21",
        },
        new CustomField
        {
            Name = "discountCodeEndDate__c",
            MValue = "2021-11-21",
        },
        new CustomField
        {
            Name = "amountBeforeTax__c",
            MValue = "9.99",
        },
        new CustomField
        {
            Name = "discountedAmountBeforeTax__c",
            MValue = "9.99",
        },
        new CustomField
        {
            Name = "subscriptionSource__c",
            MValue = "channel_partner",
        },
        new CustomField
        {
            Name = "upFrontPayment__c",
            MValue = "true",
        },
        new CustomField
        {
            Name = "embeddedPromoCode__c",
            MValue = "string",
        },
        new CustomField
        {
            Name = "discountCodeDescription__c",
            MValue = "string",
        },
    },
};

try
{
    OrderRespType result = await subscriptionsController.UpdateSubscriptionAsync(
        xUserId,
        xAuthorization,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`InvalidReqTypeException`](../../doc/models/invalid-req-type-exception.md) |
| 401 | Unauthorized | [`AuthErrorTypeException`](../../doc/models/auth-error-type-exception.md) |
| 500 | Error | [`OrderErrorTypeException`](../../doc/models/order-error-type-exception.md) |


# Cancel Subscription

Cancel subscription for a given subscription ID

```csharp
CancelSubscriptionAsync(
    string userId,
    string xAuthorization,
    Models.CancelReqType body,
    string xTransactionId = null,
    string origin = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Header, Required | UserId of an user who bought a subscription. This will be an IES userId |
| `xAuthorization` | `string` | Header, Required | This will be an IES system token |
| `body` | [`CancelReqType`](../../doc/models/cancel-req-type.md) | Body, Required | Data |
| `xTransactionId` | `string` | Header, Optional | Unique ID for a transaction |
| `origin` | `string` | Header, Optional | Originating System |

## Response Type

[`Task<Models.CancelResType>`](../../doc/models/cancel-res-type.md)

## Example Usage

```csharp
string userId = "userId0";
string xAuthorization = "X-Authorization6";
CancelReqType body = new CancelReqType
{
    SubscriptionId = "urn:pearson:gps:subs:649e7109fc57341ba129e23",
    SubscriptionSource = SubscriptionSourceEnum.Internal,
    CancelReason = "No longer need service",
    CancelDate = "2023-06-30",
};

try
{
    CancelResType result = await subscriptionsController.CancelSubscriptionAsync(
        userId,
        xAuthorization,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`InvalidReqTypeException`](../../doc/models/invalid-req-type-exception.md) |
| 401 | Unauthorized | [`AuthErrorTypeException`](../../doc/models/auth-error-type-exception.md) |
| 500 | Error | [`OrderErrorTypeException`](../../doc/models/order-error-type-exception.md) |


# Aggregate Subscription

```csharp
AggregateSubscriptionAsync(
    string xUserId,
    string xAuthorization,
    Models.OrderRequestType body,
    string xTransactionId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `xUserId` | `string` | Header, Required | UserId of an user who bought a subscription. This will be an IES userId |
| `xAuthorization` | `string` | Header, Required | This will be an IES system token |
| `body` | [`OrderRequestType`](../../doc/models/order-request-type.md) | Body, Required | Data |
| `xTransactionId` | `string` | Header, Optional | Unique ID for a transaction |

## Response Type

[`Task<Models.OrderRespType>`](../../doc/models/order-resp-type.md)

## Example Usage

```csharp
string xUserId = "X-UserId4";
string xAuthorization = "X-Authorization6";
OrderRequestType body = new OrderRequestType
{
    OrderNumber = "10034567",
    Description = "Sample description of the API",
    SubscriptionModelName = "Mojo",
    StoreCode = "US",
    SwapTitle = false,
    SendEmail = true,
    OrderRequestTypeProducts = new List<OrderRequestTypeProduct>
    {
        new OrderRequestTypeProduct
        {
            Isbn = "4280134085545",
            Ppid = "A101702992101",
        },
        new OrderRequestTypeProduct
        {
            Isbn = "4280134085546",
            Ppid = "A101702992102",
        },
    },
    CustomFields = new List<CustomField>
    {
        new CustomField
        {
            Name = "paymentMethod__c",
            MValue = "CREDIT CARD",
        },
        new CustomField
        {
            Name = "paymentInfo__c",
            MValue = "CREDIT CARD",
        },
        new CustomField
        {
            Name = "paymentToken__c",
            MValue = "4111111111111111",
        },
        new CustomField
        {
            Name = "iesId__c",
            MValue = "ea9mmnj1qe2tghnb3",
        },
        new CustomField
        {
            Name = "hybrisAccountNumber__c",
            MValue = "456",
        },
        new CustomField
        {
            Name = "tepAccountNumber__c",
            MValue = "c123",
        },
        new CustomField
        {
            Name = "institutionId__c",
            MValue = "5678",
        },
        new CustomField
        {
            Name = "tepPartyId__c",
            MValue = "GH6789",
        },
        new CustomField
        {
            Name = "campaignName__c",
            MValue = "test val",
        },
        new CustomField
        {
            Name = "promoCode__c",
            MValue = "PM10",
        },
        new CustomField
        {
            Name = "couponCode__c",
            MValue = "BA10",
        },
        new CustomField
        {
            Name = "discountCodeStartDate__c",
            MValue = "2021-09-21",
        },
        new CustomField
        {
            Name = "discountCodeEndDate__c",
            MValue = "2021-11-21",
        },
        new CustomField
        {
            Name = "amountBeforeTax__c",
            MValue = "9.99",
        },
        new CustomField
        {
            Name = "discountedAmountBeforeTax__c",
            MValue = "9.99",
        },
        new CustomField
        {
            Name = "subscriptionSource__c",
            MValue = "channel_partner",
        },
        new CustomField
        {
            Name = "upFrontPayment__c",
            MValue = "true",
        },
        new CustomField
        {
            Name = "embeddedPromoCode__c",
            MValue = "string",
        },
        new CustomField
        {
            Name = "discountCodeDescription__c",
            MValue = "string",
        },
    },
};

try
{
    OrderRespType result = await subscriptionsController.AggregateSubscriptionAsync(
        xUserId,
        xAuthorization,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`InvalidReqTypeException`](../../doc/models/invalid-req-type-exception.md) |
| 401 | Unauthorized | [`AuthErrorTypeException`](../../doc/models/auth-error-type-exception.md) |
| 500 | Error | [`OrderRespTypeErrorException`](../../doc/models/order-resp-type-error-exception.md) |


# Expire Subscriptions

Expire subscription for all past enddate internal and IA subscriptions

```csharp
ExpireSubscriptionsAsync()
```

## Response Type

[`Task<Models.CancelResType>`](../../doc/models/cancel-res-type.md)

## Example Usage

```csharp
try
{
    CancelResType result = await subscriptionsController.ExpireSubscriptionsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`InvalidReqTypeException`](../../doc/models/invalid-req-type-exception.md) |
| 401 | Unauthorized | [`AuthErrorTypeException`](../../doc/models/auth-error-type-exception.md) |
| 500 | Error | [`OrderErrorTypeException`](../../doc/models/order-error-type-exception.md) |

