
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `DefaultHost` | `string` | *Default*: `"www.example.com"` |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |

The API client can be initialized as follows:

```csharp
PearsonSubscriptionsAPIClient client = new PearsonSubscriptionsAPIClient.Builder()
    .Environment(PearsonSubscriptionsAPI.Standard.Environment.Production)
    .DefaultHost("www.example.com")
    .Build();
```

## Pearson Subscriptions APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| HealthController | Gets HealthController controller. |
| SubscriptionsController | Gets SubscriptionsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| DefaultHost | DefaultHost value. | `string` |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Pearson Subscriptions APIClient using the values provided for the builder. | `Builder` |

## Pearson Subscriptions APIClient Builder Class

Class to build instances of Pearson Subscriptions APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `DefaultHost(string defaultHost)` | DefaultHost value. | `Builder` |

