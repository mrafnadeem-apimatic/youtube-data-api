
# Error Further Detail

## Structure

`ErrorFurtherDetail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required | - |
| `FieldViolations` | [`List<Models.FieldViolation>`](../../doc/models/field-violation.md) | Required | - |

## Example (as JSON)

```json
{
  "@type": "type.googleapis.com/google.rpc.BadRequest",
  "fieldViolations": [
    {
      "field": "published_before",
      "description": "Invalid value at 'published_before' (type.googleapis.com/google.protobuf.Timestamp), Field 'published_before', Illegal timestamp format; timestamps must end with 'Z' or have a valid timezone offset."
    }
  ]
}
```

