
# Search Result

## Structure

`SearchResult`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Kind` | `string` | Required | - |
| `Etag` | `string` | Required | - |
| `NextPageToken` | `string` | Required | - |
| `RegionCode` | `string` | Required | - |
| `PageInfo` | [`Models.PageInfo`](../../doc/models/page-info.md) | Required | - |
| `Items` | [`List<Models.Item>`](../../doc/models/item.md) | Required | - |

## Example (as JSON)

```json
{
  "kind": "youtube#searchListResponse",
  "etag": "-5tNgTihVuCApRK6QZhoxaxytAY",
  "nextPageToken": "CAIQAA",
  "regionCode": "PK",
  "pageInfo": {
    "totalResults": 1000000,
    "resultsPerPage": 2
  },
  "items": [
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
    },
    {
      "kind": "youtube#searchResult",
      "etag": "yemShPZBnLVfuPO54YuQw1juu-o",
      "id": {
        "kind": "youtube#video",
        "videoId": "a-KAzMTgnHs"
      },
      "snippet": {
        "publishedAt": "2022-09-08T21:03:21Z",
        "channelId": "UChuLeaTGRcfzo0UjL-2qSbQ",
        "title": "Filipe Toledo vs Italo Ferreira | Rip Curl WSL Finals 2022 - Title Match 1",
        "description": "Title Match Replay of Filipe Toledo vs Italo Ferreira at the Rip Curl WSL Finals Shop the limited edition Rip Curl WSL Finals ...",
        "thumbnails": {
          "default": {
            "url": "https://i.ytimg.com/vi/a-KAzMTgnHs/default.jpg",
            "width": 120,
            "height": 90
          },
          "medium": {
            "url": "https://i.ytimg.com/vi/a-KAzMTgnHs/mqdefault.jpg",
            "width": 320,
            "height": 180
          },
          "high": {
            "url": "https://i.ytimg.com/vi/a-KAzMTgnHs/hqdefault.jpg",
            "width": 480,
            "height": 360
          }
        },
        "channelTitle": "World Surf League",
        "liveBroadcastContent": "none",
        "publishTime": "2022-09-08T21:03:21Z"
      }
    }
  ]
}
```

