
# Item

## Structure

`Item`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | - |
| `Etag` | `string` | Required | - |
| `Id` | [`Models.Id`](../../doc/models/id.md) | Required | - |
| `Snippet` | [`Models.Snippet`](../../doc/models/snippet.md) | Required | - |

## Example (as JSON)

```json
{
  "kind": "youtube#searchResult",
  "etag": "tdCd6nOzse4ntq5cwSPQvm_6B98",
  "id": {
    "kind": "youtube#video",
    "videoId": "fukKNYqfJW4"
  },
  "snippet": {
    "publishedAt": "2022-09-08T21:24:11Z",
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
    "publishTime": "2022-09-08T21:24:11Z"
  }
}
```

