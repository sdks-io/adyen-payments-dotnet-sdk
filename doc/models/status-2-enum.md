
# Status 2 Enum

The status of the session. The status included in the response doesn't get updated. Don't make the request again to check for payment status updates.

Possible values:

         * **completed** – The shopper completed the payment. This means that the payment was authorized.
         * **paymentPending** – The shopper is in the process of making the payment. This applies to payment methods with an asynchronous flow.
         * **refused** – The session has been refused, due to too many refused payment attempts. Shoppers can no longer complete the payment with this session.
         * **canceled** – The shopper canceled the payment.
         * **active** – The session is still active and can be paid.
         * **expired** – The session expired (default: 1 hour after session creation). Shoppers can no longer complete the payment with this session.

## Enumeration

`Status2Enum`

## Fields

| Name |
|  --- |
| `Active` |
| `Canceled` |
| `Completed` |
| `Expired` |
| `PaymentPending` |
| `Refused` |

