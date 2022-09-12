
# Snippet

## Structure

`Snippet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PublishedAt` | `string` | Required | - |
| `ChannelId` | `string` | Required | - |
| `Title` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Thumbnails` | [`Models.Thumbnails`](../../doc/models/thumbnails.md) | Required | - |
| `ChannelTitle` | `string` | Required | - |
| `LiveBroadcastContent` | `string` | Required | - |
| `PublishTime` | `string` | Required | - |

## Example (as JSON)

```json
{
  "publishedAt": "09/08/2022 21:24:11",
  "channelId": "UChuLeaTGRcfzo0UjL-2qSbQ",
  "title": "Carissa Moore vs Stephanie Gilmore | Rip Curl WSL Finals 2022 - Championship Heat",
  "description": "Championship Heat Replay of Carissa Moore vs Stephanie Gilmore at the Rip Curl WSL Finals Shop the limited edition Rip Curl ...",
  "thumbnails": {
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
  },
  "channelTitle": "World Surf League",
  "liveBroadcastContent": "none",
  "publishTime": "09/08/2022 21:24:11"
}
```

