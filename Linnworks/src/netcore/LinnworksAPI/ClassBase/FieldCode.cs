using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace LinnworksAPI
{ 
    [JsonConverter(typeof(StringEnumConverter))]
	public enum FieldCode
	{
		GENERAL_INFO,
		GENERAL_INFO_ORDER_ID,
		GENERAL_INFO_REFERENCE_NUMBER,
		GENERAL_INFO_CHANNEL_REFERENCE_NUMBER,
		GENERAL_INFO_EXTERNAL_REFERENCE_NUMBER,
		GENERAL_INFO_DATE,
		GENERAL_INFO_SOURCE,
		GENERAL_INFO_SUBSOURCE,
		GENERAL_INFO_LABEL_PRINTED,
		GENERAL_INFO_INVOICE_PRINTED,
		GENERAL_INFO_PICK_LIST_PRINTED,
		GENERAL_INFO_IS_RULE_RUN,
		GENERAL_INFO_NOTES,
		GENERAL_INFO_LOCKED,
		GENERAL_INFO_PARKED,
		GENERAL_INFO_PART_SHIPPED,
		GENERAL_INFO_TAG,
		GENERAL_INFO_IDENTIFIER,
		GENERAL_INFO_STATUS,
		GENERAL_INFO_DESPATCHBYDATE,
		GENERAL_INFO_ITEMS_COUNT,
		GENERAL_INFO_SHIPPING_LABEL_ERROR,
		GENERAL_INFO_HAS_SHIPPING_LABEL_ERROR,
		SHIPPING_INFORMATION,
		SHIPPING_INFORMATION_VENDOR,
		SHIPPING_INFORMATION_SERVICE,
		SHIPPING_INFORMATION_WEIGHT,
		SHIPPING_INFORMATION_PACKAGING_GROUP,
		SHIPPING_INFORMATION_PACKAGING_TYPE,
		SHIPPING_INFORMATION_COST,
		SHIPPING_INFORMATION_TRACKING_NUMBER,
		SHIPPING_INFORMATION_SERVICE_ID,
		CUSTOMER,
		CUSTOMER_ADDRESS_FULL_NAME,
		CUSTOMER_ADDRESS_COMPANY,
		CUSTOMER_ADDRESS_POSTCODE,
		CUSTOMER_ADDRESS_COUNTY,
		CUSTOMER_ADDRESS_COUNTRY,
		CUSTOMER_ADDRESS_COUNTRY_ZONE,
		CUSTOMER_ADDRESS_ADDRESS1,
		CUSTOMER_ADDRESS_ADDRESS2,
		CUSTOMER_ADDRESS_ADDRESS3,
		CUSTOMER_ADDRESS_TOWN,
		CUSTOMER_BILLING_ADDRESS,
		CUSTOMER_EMAIL,
		CUSTOMER_CHANNEL_BUYER_NAME,
		CUSTOMER_PHONE,
		TOTALS,
		TOTALS_SUBTOTAL,
		TOTALS_SHIPPING,
		TOTALS_TAX,
		TOTALS_TOTAL,
		TOTALS_CURRENCY,
		TOTALS_PAYMENT_METHOD,
		TOTALS_COUNTRY_TAX_RATE,
		ORDER_TOTAL,
		ORDER_TOTAL_TOTAL,
		ORDER_TOTAL_CURRENCY,
		ORDER_TAX,
		ORDER_TAX_TOTAL,
		ORDER_TAX_CURRENCY,
		FOLDER,
		JOB,
		ITEMS,
		ITEMS_IMAGE,
		ITEMS_SKU,
		ITEMS_ORIGINAL_SKU,
		ITEMS_TITLE,
		ITEMS_ORIGINAL_TITLE,
		ITEMS_QUANTITY,
		ITEMS_LINE,
		ITEMS_CURRENCY,
		ITEMS_CATEGORY,
		ITEMS_BINRACK,
		ITEMS_TAX_COST_INCLUSIVE,
		ITEMS_WEIGHT,
		ITEMS_UNIT_COST,
		ITEMS_PRICE_PER_UNIT,
		ITEMS_BATCHED,
		ITEMS_BARCODE_NUMBER,
		STOCK_LEVEL,
		HOT_BUTTONS,
		HOT_BUTTON,
	}
}