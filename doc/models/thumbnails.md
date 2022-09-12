
# Thumbnails

## Structure

`Thumbnails`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Default` | [`Models.Default`](../../doc/models/default.md) | Required | - |
| `Medium` | [`Models.Medium`](../../doc/models/medium.md) | Required | - |
| `High` | [`Models.High`](../../doc/models/high.md) | Required | - |

## Example (as JSON)

```json
{
  "default": {
    "url": "https://i.ytimg.com/vi/fukKNYqfJW4/default.jpg",
    "width": 120,
    "height": 90
  },
  "medium": {
    "url": "https://i.ytimg.com/vi/fukKNYqfJW4/mqdefault.jpg",
    "width": 320,
    "height": 180
  },
  "high": {
    "url": "https://i.ytimg.com/vi/fukKNYqfJW4/hqdefault.jpg",
    "width": 480,
    "height": 360
  }
}
```

