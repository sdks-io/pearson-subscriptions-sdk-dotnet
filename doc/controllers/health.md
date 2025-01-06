# Health

```csharp
HealthController healthController = client.HealthController;
```

## Class Name

`HealthController`


# Health Check

```csharp
HealthCheckAsync()
```

## Response Type

`Task<dynamic>`

## Example Usage

```csharp
try
{
    dynamic result = await healthController.HealthCheckAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

