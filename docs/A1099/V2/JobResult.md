# Avalara.SDK.Model.A1099.V2.JobResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Type** | **string** |  | [optional] 
**DryRun** | **bool** | Dry run. If &#x60;true&#x60;, this job only simulates the changes but doesn&#39;t actually persist them. | [optional] 
**Upsert** | **bool** | Upsert. If &#x60;true&#x60;, this job will first attempt to update existing records if matches can be found. Matches are done in the following order:  * Form ID  * Form Reference ID and tax year  * Form TIN and tax year | [optional] 
**Status** | **string** | Status of the job | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**TotalProcessed** | **int** | Total number of forms processed | [optional] 
**TotalRows** | **int** | Total number of forms in the request | [optional] 
**UpdatedValid** | **int** | Number of forms updated and valid for e-filing and e-delivery | [optional] 
**UpdatedNoEmail** | **int** | Number of forms updated and valid for e-filing but missing email or email is undeliverable | [optional] 
**UpdatedInvalid** | **int** | Number of forms updated but invalid for e-filing | [optional] 
**SkippedDuplicate** | **int** | Number of forms skipped because they would have updated a record already updated once in the request | [optional] 
**SkippedInvalid** | **int** | Number of forms skipped because they would have made a form invalid and the form is already e-filed or scheduled for e-filing | [optional] 
**SkippedMultipleMatches** | **int** | Number of forms skipped because they matched multiple forms | [optional] 
**NotFound** | **int** | Number of forms skipped because no matching form or issuer could be found | [optional] 
**CreatedInvalid** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - with errors | [optional] 
**CreatedNoEmail** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing but missing email or email is undeliverable | [optional] 
**CreatedValid** | **int** | Number of new forms created because no matching form could be found (and &#x60;upsert&#x60; was true) - valid for e-filing and e-delivery | [optional] 

[[Back to Model list]](../../../README.md#documentation-for-models) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to README]](../../../README.md)

