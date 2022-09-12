# Search

```csharp
SearchController searchController = client.SearchController;
```

## Class Name

`SearchController`


# Search List

Returns a collection of search results that match the query parameters specified in the API request.

```csharp
SearchListAsync(
    string part,
    string q = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `part` | `string` | Query, Required | The part parameter specifies a comma-separated list of one or more search resource properties that the API response will include. Set the parameter value to snippet. |
| `q` | `string` | Query, Optional | The q parameter specifies the query term to search for. |

## Response Type

[`Task<Models.SearchResult>`](../../doc/models/search-result.md)

## Example Usage

```csharp
string part = "snippet";

try
{
    SearchResult result = await searchController.SearchListAsync(part, null);
}
catch (ApiException e){};
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | Search Result Error! | [`SearchErrorException`](../../doc/models/search-error-exception.md) |

