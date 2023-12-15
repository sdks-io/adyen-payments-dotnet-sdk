
# Device Render Options

## Structure

`DeviceRenderOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SdkInterface` | [`SdkInterfaceEnum?`](../../doc/models/sdk-interface-enum.md) | Optional | Supported SDK interface types.<br>Allowed values:<br><br>* native<br>* html<br>* both<br>**Default**: `SdkInterfaceEnum.both` |
| `SdkUiType` | [`List<SdkUiTypeEnum>`](../../doc/models/sdk-ui-type-enum.md) | Optional | UI types supported for displaying specific challenges.<br>Allowed values:<br><br>* text<br>* singleSelect<br>* outOfBand<br>* otherHtml<br>* multiSelect |

## Example (as JSON)

```json
{
  "sdkInterface": "both",
  "sdkUiType": [
    "singleSelect"
  ]
}
```

