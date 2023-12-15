
# Additional Data Level 23

## Structure

`AdditionalDataLevel23`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnhancedSchemeDataCustomerReference` | `string` | Optional | The customer code.<br><br>* Encoding: ASCII<br>* Max length: 25 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataDestinationCountryCode` | `string` | Optional | The three-letter [ISO 3166-1 alpha-3 country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) for the destination address.<br><br>* Encoding: ASCII<br>* Fixed length: 3 characters |
| `EnhancedSchemeDataDestinationPostalCode` | `string` | Optional | The postal code of the destination address.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* Must not start with a space |
| `EnhancedSchemeDataDestinationStateProvinceCode` | `string` | Optional | Destination state or province code.<br><br>* Encoding: ASCII<br>* Max length: 3 characters<br>* Must not start with a space |
| `EnhancedSchemeDataDutyAmount` | `string` | Optional | The duty amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters |
| `EnhancedSchemeDataFreightAmount` | `string` | Optional | The shipping amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>  *Max length: 12 characters |
| `EnhancedSchemeDataItemDetailLineItemNrCommodityCode` | `string` | Optional | The [UNSPC commodity code](https://www.unspsc.org/) of the item.<br><br>* Encoding: ASCII<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrDescription` | `string` | Optional | A description of the item.<br><br>* Encoding: ASCII<br>* Max length: 26 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrDiscountAmount` | `string` | Optional | The discount amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters |
| `EnhancedSchemeDataItemDetailLineItemNrProductCode` | `string` | Optional | The product code.<br><br>* Encoding: ASCII.<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrQuantity` | `string` | Optional | The number of items. Must be an integer greater than zero.<br><br>* Encoding: Numeric<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces |
| `EnhancedSchemeDataItemDetailLineItemNrTotalAmount` | `string` | Optional | The total amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Max length: 12 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrUnitOfMeasure` | `string` | Optional | The unit of measurement for an item.<br><br>* Encoding: ASCII<br><br>Max length: 3 characters<br><br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataItemDetailLineItemNrUnitPrice` | `string` | Optional | The unit price in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>* Encoding: Numeric<br>* Max length: 12 characters<br>* Must not be all zeros. |
| `EnhancedSchemeDataOrderDate` | `string` | Optional | The order date.<br><br>* Format: `ddMMyy`<br>* Encoding: ASCII<br>* Max length: 6 characters |
| `EnhancedSchemeDataShipFromPostalCode` | `string` | Optional | The postal code of the address the item is shipped from.<br><br>* Encoding: ASCII<br>* Max length: 10 characters<br>* Must not start with a space or be all spaces<br>* Must not be all zeros. |
| `EnhancedSchemeDataTotalTaxAmount` | `string` | Optional | The total tax amount, in [minor units](https://docs.adyen.com/development-resources/currency-codes).<br><br>* For example, 2000 means USD 20.00.<br>  *Encoding: Numeric<br>  *Max length: 12 characters<br>* Must not be all zeros. |

## Example (as JSON)

```json
{
  "enhancedSchemeData.customerReference": "enhancedSchemeData.customerReference4",
  "enhancedSchemeData.destinationCountryCode": "enhancedSchemeData.destinationCountryCode4",
  "enhancedSchemeData.destinationPostalCode": "enhancedSchemeData.destinationPostalCode6",
  "enhancedSchemeData.destinationStateProvinceCode": "enhancedSchemeData.destinationStateProvinceCode4",
  "enhancedSchemeData.dutyAmount": "enhancedSchemeData.dutyAmount4"
}
```

