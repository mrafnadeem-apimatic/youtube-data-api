
# Field Violation

## Structure

`FieldViolation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Field` | `string` | Required | - |
| `Description` | `string` | Required | - |

## Example (as JSON)

```json
{
  "field": "published_before",
  "description": "Invalid value at 'published_before' (type.googleapis.com/google.protobuf.Timestamp), Field 'published_before', Illegal timestamp format; timestamps must end with 'Z' or have a valid timezone offset."
}
```

