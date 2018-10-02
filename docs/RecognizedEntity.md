# ShipEngine.ApiClient.Model.RecognizedEntity
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The Entity type (e.g. \&quot;weight\&quot;, \&quot;person\&quot;, \&quot;address_line1\&quot;, etc.) | [optional] 
**Score** | **double?** | A confidence score between zero and one that indicates how certain the API is that this entity is correct | [optional] 
**Text** | **string** | The substring from the original text that was recognized as this entity | [optional] 
**StartIndex** | **decimal?** | The index of the first character of this entity withing the original text | [optional] 
**EndIndex** | **decimal?** | The index of the last character of this entity withing the original text | [optional] 
**Result** | **Object** | The result object will be different for each entity type.  Most entity results will have a \&quot;value\&quot; property, which is the normalized value of the entity.  For example, if the substring \&quot;john doe\&quot; was recognized as a \&quot;person\&quot; entity, then the value might be normalized to have proper capitalization (e.g. \&quot;John Doe\&quot;).  Or if the substring \&quot;dalas\&quot; was recognized as a \&quot;city\&quot; entity, then the value might be normalized to have proper capitalization and correct the misspelling of \&quot;Dallas\&quot;.  Some entities will have other information in addition to, or instead of a \&quot;value\&quot; property.  For example, a \&quot;dimensions\&quot; entity will have separate properties for \&quot;length\&quot;, \&quot;width\&quot;, \&quot;height\&quot;, and \&quot;unit\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

