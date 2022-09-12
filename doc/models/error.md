
# Error

## Structure

`Error`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Code` | `int` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | [`List<Models.ErrorDetail>`](../../doc/models/error-detail.md) | Optional | - |
| `Status` | `string` | Required | - |
| `Details` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "code": 400,
  "message": "Request contains an invalid argument.",
  "status": "INVALID_ARGUMENT"
}
```

