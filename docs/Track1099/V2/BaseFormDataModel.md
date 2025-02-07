# Avalara.SDK.Model.Track1099.V2.BaseFormDataModel
Resource data model for /w9/forms API    Note that the same model is used for proxy and API because this is a form model with standardized form field names    Currently, the in-built polymorphic json (de)serializer in System.Text does not work if the type discriminator is not the first property  See issue: https://github.com/dotnet/runtime/issues/72604  Whenever it starts working in the future, we will be able to replace the JsonConverter below to using -      [JsonPolymorphic(TypeDiscriminatorPropertyName = \"type\")]      [JsonDerivedType(typeof(W9FormDataModel), typeDiscriminator: \"w9\")]      [JsonDerivedType(typeof(W4FormDataModel), typeDiscriminator: \"w4\")]      [JsonDerivedType(typeof(W8ImyFormDataModel), typeDiscriminator: \"w8imy\")]      [JsonDerivedType(typeof(W8BenFormDataModel), typeDiscriminator: \"w8ben\")]      [JsonDerivedType(typeof(W8BeneFormDataModel), typeDiscriminator: \"w8bene\")]        Until then, W9FormsJsonConverter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**Type** | **string** |  | [optional] [readonly] 
**EntryStatus** | **string** |  | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

