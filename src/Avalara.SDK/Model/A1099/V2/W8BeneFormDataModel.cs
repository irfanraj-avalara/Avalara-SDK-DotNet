/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara 1099 & W-9 API Definition
 *
 * ## 🔐 Authentication  Use **username/password** or generate a **license key** from: *Avalara Portal → Settings → License and API Keys*.  [More on authentication methods](https://developer.avalara.com/avatax-dm-combined-erp/common-setup/authentication/authentication-methods/)  [Test your credentials](https://developer.avalara.com/avatax/test-credentials/)  ## 📘 API & SDK Documentation  [Avalara SDK (.NET) on GitHub](https://github.com/avadev/Avalara-SDK-DotNet#avalarasdk- -the-unified-c-library-for-next-gen-avalara-services)  [Code Examples – 1099 API](https://github.com/avadev/Avalara-SDK-DotNet/blob/main/docs/A1099/V2/Class1099IssuersApi.md#call1099issuersget)
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Avalara.SDK.Client.FileParameter;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.A1099.V2
{
/// <summary>
    /// W-8 BEN-E form
    /// </summary>
    [DataContract(Name = "W8BeneFormDataModel")]
    public partial class W8BeneFormDataModel : IValidatableObject
    {
        /// <summary>
        /// Type of the form, always W8BENE for this model.
        /// </summary>
        /// <value>Type of the form, always W8BENE for this model.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum W9 for value: w9
            /// </summary>
            [EnumMember(Value = "w9")]
            W9 = 1,

            /// <summary>
            /// Enum W4 for value: w4
            /// </summary>
            [EnumMember(Value = "w4")]
            W4 = 2,

            /// <summary>
            /// Enum W8imy for value: w8imy
            /// </summary>
            [EnumMember(Value = "w8imy")]
            W8imy = 3,

            /// <summary>
            /// Enum W8ben for value: w8ben
            /// </summary>
            [EnumMember(Value = "w8ben")]
            W8ben = 4,

            /// <summary>
            /// Enum W8bene for value: w8bene
            /// </summary>
            [EnumMember(Value = "w8bene")]
            W8bene = 5
        }


        /// <summary>
        /// Type of the form, always W8BENE for this model.
        /// </summary>
        /// <value>Type of the form, always W8BENE for this model.</value>
        /// <example>w8bene</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="W8BeneFormDataModel" /> class.
        /// </summary>
        /// <param name="signedDate">The date the form was signed..</param>
        /// <param name="disregardedEntityChapter4FatcaStatus">The FATCA status for disregarded entities under Chapter 4..</param>
        /// <param name="createdAt">The creation date of the form..</param>
        /// <param name="name">The name of the individual or entity associated with the form..</param>
        /// <param name="residenceAddress">The residential address of the individual or entity..</param>
        /// <param name="residenceCity">The city of residence..</param>
        /// <param name="residenceState">The state of residence..</param>
        /// <param name="residencePostalCode">The postal code of the residence..</param>
        /// <param name="residenceCountry">The country of residence..</param>
        /// <param name="mailingAddress">The mailing address..</param>
        /// <param name="mailingCity">The city of the mailing address..</param>
        /// <param name="mailingState">The state of the mailing address..</param>
        /// <param name="mailingPostalCode">The postal code of the mailing address..</param>
        /// <param name="mailingCountry">The country of the mailing address..</param>
        /// <param name="disregardedAddress">The address for disregarded entities..</param>
        /// <param name="disregardedCity">The city for disregarded entities..</param>
        /// <param name="disregardedState">The state for disregarded entities..</param>
        /// <param name="disregardedPostalCode">The postal code for disregarded entities..</param>
        /// <param name="disregardedCountry">The country for disregarded entities..</param>
        /// <param name="tin">The taxpayer identification number (TIN)..</param>
        /// <param name="typeOfTin">The type of TIN provided..</param>
        /// <param name="foreignTin">The foreign taxpayer identification number (TIN)..</param>
        /// <param name="ftinNotRequired">Indicates whether a foreign TIN is not required..</param>
        /// <param name="referenceNumber">A reference number for the form..</param>
        /// <param name="giin">The global intermediary identification number (GIIN)..</param>
        /// <param name="chapter3EntityType">The Chapter 3 entity type..</param>
        /// <param name="chapter4FatcaStatus">The Chapter 4 FATCA status..</param>
        /// <param name="disregardedEntity">The disregarded entity information..</param>
        /// <param name="disregardedEntityGiin">The GIIN for disregarded entities..</param>
        /// <param name="benefitLimitation">The benefit limitation for tax treaty claims..</param>
        /// <param name="part4SponsoringEntity">The sponsoring entity information for Part 4..</param>
        /// <param name="part4SponsoringEntityGiin">The GIIN for the sponsoring entity in Part 4..</param>
        /// <param name="part7SponsoringEntity">The sponsoring entity information for Part 7..</param>
        /// <param name="part12IgaCountry">The IGA country information for Part 12..</param>
        /// <param name="part12IgaType">The IGA type information for Part 12..</param>
        /// <param name="part12FatcaStatusUnderIgaAnnexIi">The FATCA status under IGA Annex II for Part 12..</param>
        /// <param name="part12TrusteeName">The trustee name for Part 12..</param>
        /// <param name="part12TrusteeIsForeign">Indicates whether the trustee is foreign for Part 12..</param>
        /// <param name="part12Model2IgaGiin">The GIIN for Model 2 IGA in Part 12..</param>
        /// <param name="box37AExchange">The exchange information for Box 37A..</param>
        /// <param name="box37BExchange">The exchange information for Box 37B..</param>
        /// <param name="box37BEntity">The entity information for Box 37B..</param>
        /// <param name="part28SponsoringEntity">The sponsoring entity information for Part 28..</param>
        /// <param name="part28SponsoringEntityGiin">The GIIN for the sponsoring entity in Part 28..</param>
        /// <param name="signerName">The name of the signer..</param>
        /// <param name="eDeliveryConsentedAt">The date when e-delivery was consented..</param>
        /// <param name="residenceIsMailing">residenceIsMailing.</param>
        /// <param name="citizenshipCountry">citizenshipCountry.</param>
        /// <param name="makingTreatyClaim">makingTreatyClaim.</param>
        /// <param name="treatyCountry">treatyCountry.</param>
        /// <param name="treatyArticle">treatyArticle.</param>
        /// <param name="withholdingRate">withholdingRate.</param>
        /// <param name="incomeType">incomeType.</param>
        /// <param name="treatyReasons">treatyReasons.</param>
        /// <param name="certifyBox14A">certifyBox14A.</param>
        /// <param name="certifyBox14B">certifyBox14B.</param>
        /// <param name="certifyBox14C">certifyBox14C.</param>
        /// <param name="certifyBox171">certifyBox171.</param>
        /// <param name="certifyBox172">certifyBox172.</param>
        /// <param name="certifyBox18">certifyBox18.</param>
        /// <param name="certifyBox19">certifyBox19.</param>
        /// <param name="certifyBox21">certifyBox21.</param>
        /// <param name="certifyBox22">certifyBox22.</param>
        /// <param name="certifyBox23">certifyBox23.</param>
        /// <param name="certifyBox24A">certifyBox24A.</param>
        /// <param name="certifyBox24B">certifyBox24B.</param>
        /// <param name="certifyBox24C">certifyBox24C.</param>
        /// <param name="certifyBox24D">certifyBox24D.</param>
        /// <param name="certifyBox25A">certifyBox25A.</param>
        /// <param name="certifyBox25B">certifyBox25B.</param>
        /// <param name="certifyBox25C">certifyBox25C.</param>
        /// <param name="certifyBox26">certifyBox26.</param>
        /// <param name="certifyBox27">certifyBox27.</param>
        /// <param name="certifyBox28A">certifyBox28A.</param>
        /// <param name="certifyBox28B">certifyBox28B.</param>
        /// <param name="certifyBox29A">certifyBox29A.</param>
        /// <param name="certifyBox29B">certifyBox29B.</param>
        /// <param name="certifyBox29C">certifyBox29C.</param>
        /// <param name="certifyBox29D">certifyBox29D.</param>
        /// <param name="certifyBox29E">certifyBox29E.</param>
        /// <param name="certifyBox29F">certifyBox29F.</param>
        /// <param name="certifyBox30">certifyBox30.</param>
        /// <param name="certifyBox31">certifyBox31.</param>
        /// <param name="certifyBox32">certifyBox32.</param>
        /// <param name="certifyBox33">certifyBox33.</param>
        /// <param name="certifyBox34">certifyBox34.</param>
        /// <param name="certifyBox35">certifyBox35.</param>
        /// <param name="certifyBox36">certifyBox36.</param>
        /// <param name="certifyBox37A">certifyBox37A.</param>
        /// <param name="certifyBox37B">certifyBox37B.</param>
        /// <param name="certifyBox38">certifyBox38.</param>
        /// <param name="certifyBox39">certifyBox39.</param>
        /// <param name="certifyBox40A">certifyBox40A.</param>
        /// <param name="certifyBox40B">certifyBox40B.</param>
        /// <param name="certifyBox40C">certifyBox40C.</param>
        /// <param name="certifyBox41">certifyBox41.</param>
        /// <param name="certifyBox43">certifyBox43.</param>
        /// <param name="certifyPart29Signature">certifyPart29Signature.</param>
        /// <param name="part19FormationOrResolutionDate">part19FormationOrResolutionDate.</param>
        /// <param name="part20FilingDate">part20FilingDate.</param>
        /// <param name="part21DeterminationDate">part21DeterminationDate.</param>
        /// <param name="substantialUsOwners">substantialUsOwners.</param>
        /// <param name="employeeFirstName">The first name of the employee..</param>
        /// <param name="employeeMiddleName">The middle name of the employee..</param>
        /// <param name="employeeLastName">The last name of the employee..</param>
        /// <param name="employeeNameSuffix">The name suffix of the employee..</param>
        /// <param name="address">The address of the individual or entity..</param>
        /// <param name="city">The city of the address..</param>
        /// <param name="state">The state of the address..</param>
        /// <param name="zip">The ZIP code of the address..</param>
        /// <param name="box3MaritalStatus">The marital status of the employee..</param>
        /// <param name="box4LastNameDiffers">Indicates whether the last name differs from prior records..</param>
        /// <param name="box5NumAllowances">The number of allowances claimed by the employee..</param>
        /// <param name="otherDependents">The number of dependents other than allowances..</param>
        /// <param name="nonJobIncome">The amount of non-job income..</param>
        /// <param name="deductions">The amount of deductions claimed..</param>
        /// <param name="box6AdditionalWithheld">The additional amount withheld..</param>
        /// <param name="box7ExemptFromWithholding">Indicates whether the employee is exempt from withholding..</param>
        /// <param name="officeCode">The office code associated with the form..</param>
        /// <param name="birthday">The birthday of the individual associated with the form..</param>
        /// <param name="foreignTinNotRequired">Indicates whether a foreign TIN is not required..</param>
        /// <param name="archived">Indicates whether the form is archived..</param>
        /// <param name="referenceId">A reference identifier for the form..</param>
        /// <param name="companyId">The ID of the associated company..</param>
        /// <param name="displayName">The display name associated with the form..</param>
        /// <param name="email">The email address of the individual associated with the form..</param>
        /// <param name="signerCapacity">The capacity in which the signer is signing the form..</param>
        /// <param name="updatedAt">The last updated date of the form..</param>
        /// <param name="ein">The employer identification number (EIN)..</param>
        /// <param name="einType">The type of employer identification number (EIN)..</param>
        /// <param name="certifyBox14">Indicates certification for box 14..</param>
        /// <param name="certifyBox15A">Indicates certification for box 15A..</param>
        /// <param name="certifyBox15B">Indicates certification for box 15B..</param>
        /// <param name="certifyBox15C">Indicates certification for box 15C..</param>
        /// <param name="certifyBox15D">Indicates certification for box 15D..</param>
        /// <param name="certifyBox15E">Indicates certification for box 15E..</param>
        /// <param name="certifyBox15F">Indicates certification for box 15F..</param>
        /// <param name="certifyBox15G">Indicates certification for box 15G..</param>
        /// <param name="certifyBox15H">Indicates certification for box 15H..</param>
        /// <param name="certifyBox15I">Indicates certification for box 15I..</param>
        /// <param name="certifyBox16A">Indicates certification for box 16A..</param>
        /// <param name="box16BQddCorporate">Indicates certification for box 16B as a QDD corporate entity..</param>
        /// <param name="box16BQddPartnership">Indicates certification for box 16B as a QDD partnership..</param>
        /// <param name="box16BQddDisregardedEntity">Indicates certification for box 16B as a QDD disregarded entity..</param>
        /// <param name="certifyBox17A">Indicates certification for box 17A..</param>
        /// <param name="certifyBox17B">Indicates certification for box 17B..</param>
        /// <param name="certifyBox17C">Indicates certification for box 17C..</param>
        /// <param name="certifyBox17D">Indicates certification for box 17D..</param>
        /// <param name="certifyBox17E">Indicates certification for box 17E..</param>
        /// <param name="certifyBox18A">Indicates certification for box 18A..</param>
        /// <param name="certifyBox18B">Indicates certification for box 18B..</param>
        /// <param name="certifyBox18C">Indicates certification for box 18C..</param>
        /// <param name="certifyBox18D">Indicates certification for box 18D..</param>
        /// <param name="certifyBox18E">Indicates certification for box 18E..</param>
        /// <param name="certifyBox18F">Indicates certification for box 18F..</param>
        /// <param name="certifyBox19A">Indicates certification for box 19A..</param>
        /// <param name="certifyBox19B">Indicates certification for box 19B..</param>
        /// <param name="certifyBox19C">Indicates certification for box 19C..</param>
        /// <param name="certifyBox19D">Indicates certification for box 19D..</param>
        /// <param name="certifyBox19E">Indicates certification for box 19E..</param>
        /// <param name="certifyBox19F">Indicates certification for box 19F..</param>
        /// <param name="certifyBox20">Indicates certification for box 20..</param>
        /// <param name="certifyBox21A">Indicates certification for box 21A..</param>
        /// <param name="certifyBox21B">Indicates certification for box 21B..</param>
        /// <param name="certifyBox21C">Indicates certification for box 21C..</param>
        /// <param name="certifyBox21D">Indicates certification for box 21D..</param>
        /// <param name="certifyBox21E">Indicates certification for box 21E..</param>
        /// <param name="certifyBox21F">Indicates certification for box 21F..</param>
        /// <param name="box23ANameSponsoringEntity">The name of the sponsoring entity for box 23A..</param>
        /// <param name="certifyBox23B">Indicates certification for box 23B..</param>
        /// <param name="certifyBox23C">Indicates certification for box 23C..</param>
        /// <param name="certifyBox25">Indicates certification for box 25..</param>
        /// <param name="box27ANameSponsoringEntity">The name of the sponsoring entity for box 27A..</param>
        /// <param name="certifyBox27B">Indicates certification for box 27B..</param>
        /// <param name="certifyBox28">Indicates certification for box 28..</param>
        /// <param name="certifyBox29">Indicates certification for box 29..</param>
        /// <param name="certifyBox30A">Indicates certification for box 30A..</param>
        /// <param name="certifyBox30B">Indicates certification for box 30B..</param>
        /// <param name="certifyBox30C">Indicates certification for box 30C..</param>
        /// <param name="box32IgaCountry">The IGA country information for box 32..</param>
        /// <param name="box32IgaType">The IGA type information for box 32..</param>
        /// <param name="box32IgaTreatedAs">The IGA treatment information for box 32..</param>
        /// <param name="box32TrusteeOrSponsor">The trustee or sponsor information for box 32..</param>
        /// <param name="box32TrusteeIsForeign">Indicates whether the trustee is foreign for box 32..</param>
        /// <param name="certifyBox33A">Indicates certification for box 33A..</param>
        /// <param name="certifyBox33B">Indicates certification for box 33B..</param>
        /// <param name="certifyBox33C">Indicates certification for box 33C..</param>
        /// <param name="certifyBox33D">Indicates certification for box 33D..</param>
        /// <param name="certifyBox33E">Indicates certification for box 33E..</param>
        /// <param name="certifyBox33F">Indicates certification for box 33F..</param>
        /// <param name="box37ASecuritiesMarket">The securities market information for box 37A..</param>
        /// <param name="box37BNameOfEntity">The name of the entity for box 37B..</param>
        /// <param name="box37BSecuritiesMarket">The securities market information for box 37B..</param>
        /// <param name="certifyBox40">Indicates certification for box 40..</param>
        /// <param name="box41SponsoringEntity">The sponsoring entity information for box 41..</param>
        /// <param name="certifyBox42">Indicates certification for box 42..</param>
        /// <param name="box35FormedOnDate">box35FormedOnDate.</param>
        /// <param name="box36FiledOnDate">box36FiledOnDate.</param>
        /// <param name="tinMatchStatus">The status of the TIN match..</param>
        /// <param name="signature">The signature itself.</param>
        /// <param name="businessClassification">The classification of the business..</param>
        /// <param name="businessName">The name of the business associated with the form..</param>
        /// <param name="businessOther">businessOther.</param>
        /// <param name="exemptPayeeCode">exemptPayeeCode.</param>
        /// <param name="exemptFatcaCode">exemptFatcaCode.</param>
        /// <param name="accountNumber">The account number associated with the form..</param>
        /// <param name="foreignCountryIndicator">Indicates whether the individual or entity is in a foreign country..</param>
        /// <param name="foreignAddress">The foreign address of the individual or entity..</param>
        /// <param name="backupWithholding">Indicates whether backup withholding applies..</param>
        /// <param name="is1099able">is1099able.</param>
        /// <param name="foreignPartnerOwnerOrBeneficiary">Indicates whether the individual is a foreign partner, owner, or beneficiary..</param>
        public W8BeneFormDataModel(DateTime? signedDate = default(DateTime?), string disregardedEntityChapter4FatcaStatus = default(string), DateTime? createdAt = default(DateTime?), string name = default(string), string residenceAddress = default(string), string residenceCity = default(string), string residenceState = default(string), string residencePostalCode = default(string), string residenceCountry = default(string), string mailingAddress = default(string), string mailingCity = default(string), string mailingState = default(string), string mailingPostalCode = default(string), string mailingCountry = default(string), string disregardedAddress = default(string), string disregardedCity = default(string), string disregardedState = default(string), string disregardedPostalCode = default(string), string disregardedCountry = default(string), string tin = default(string), string typeOfTin = default(string), string foreignTin = default(string), bool? ftinNotRequired = default(bool?), string referenceNumber = default(string), string giin = default(string), string chapter3EntityType = default(string), string chapter4FatcaStatus = default(string), string disregardedEntity = default(string), string disregardedEntityGiin = default(string), string benefitLimitation = default(string), string part4SponsoringEntity = default(string), string part4SponsoringEntityGiin = default(string), string part7SponsoringEntity = default(string), string part12IgaCountry = default(string), string part12IgaType = default(string), string part12FatcaStatusUnderIgaAnnexIi = default(string), string part12TrusteeName = default(string), bool? part12TrusteeIsForeign = default(bool?), string part12Model2IgaGiin = default(string), string box37AExchange = default(string), string box37BExchange = default(string), string box37BEntity = default(string), string part28SponsoringEntity = default(string), string part28SponsoringEntityGiin = default(string), string signerName = default(string), DateTime? eDeliveryConsentedAt = default(DateTime?), bool? residenceIsMailing = default(bool?), string citizenshipCountry = default(string), bool? makingTreatyClaim = default(bool?), string treatyCountry = default(string), string treatyArticle = default(string), string withholdingRate = default(string), string incomeType = default(string), string treatyReasons = default(string), bool certifyBox14A = default(bool), bool certifyBox14B = default(bool), bool certifyBox14C = default(bool), bool certifyBox171 = default(bool), bool certifyBox172 = default(bool), bool certifyBox18 = default(bool), bool certifyBox19 = default(bool), bool certifyBox21 = default(bool), bool certifyBox22 = default(bool), bool certifyBox23 = default(bool), bool certifyBox24A = default(bool), bool certifyBox24B = default(bool), bool certifyBox24C = default(bool), bool certifyBox24D = default(bool), bool certifyBox25A = default(bool), bool certifyBox25B = default(bool), bool certifyBox25C = default(bool), bool certifyBox26 = default(bool), bool certifyBox27 = default(bool), bool certifyBox28A = default(bool), bool certifyBox28B = default(bool), bool certifyBox29A = default(bool), bool certifyBox29B = default(bool), bool certifyBox29C = default(bool), bool certifyBox29D = default(bool), bool certifyBox29E = default(bool), bool certifyBox29F = default(bool), bool certifyBox30 = default(bool), bool certifyBox31 = default(bool), bool certifyBox32 = default(bool), bool certifyBox33 = default(bool), bool certifyBox34 = default(bool), bool certifyBox35 = default(bool), bool certifyBox36 = default(bool), bool certifyBox37A = default(bool), bool certifyBox37B = default(bool), bool certifyBox38 = default(bool), bool certifyBox39 = default(bool), bool certifyBox40A = default(bool), bool certifyBox40B = default(bool), bool certifyBox40C = default(bool), bool certifyBox41 = default(bool), bool certifyBox43 = default(bool), bool certifyPart29Signature = default(bool), DateTime? part19FormationOrResolutionDate = default(DateTime?), DateTime? part20FilingDate = default(DateTime?), DateTime? part21DeterminationDate = default(DateTime?), List<W8BenESubstantialUsOwnerDataModel> substantialUsOwners = default(List<W8BenESubstantialUsOwnerDataModel>), string employeeFirstName = default(string), string employeeMiddleName = default(string), string employeeLastName = default(string), string employeeNameSuffix = default(string), string address = default(string), string city = default(string), string state = default(string), string zip = default(string), string box3MaritalStatus = default(string), bool? box4LastNameDiffers = default(bool?), int? box5NumAllowances = default(int?), int? otherDependents = default(int?), double? nonJobIncome = default(double?), double? deductions = default(double?), double? box6AdditionalWithheld = default(double?), bool? box7ExemptFromWithholding = default(bool?), string officeCode = default(string), string birthday = default(string), bool? foreignTinNotRequired = default(bool?), bool? archived = default(bool?), string referenceId = default(string), int? companyId = default(int?), string displayName = default(string), string email = default(string), string signerCapacity = default(string), DateTime? updatedAt = default(DateTime?), string ein = default(string), string einType = default(string), bool certifyBox14 = default(bool), bool certifyBox15A = default(bool), bool certifyBox15B = default(bool), bool certifyBox15C = default(bool), bool certifyBox15D = default(bool), bool certifyBox15E = default(bool), bool certifyBox15F = default(bool), bool certifyBox15G = default(bool), bool certifyBox15H = default(bool), bool certifyBox15I = default(bool), bool certifyBox16A = default(bool), bool box16BQddCorporate = default(bool), bool box16BQddPartnership = default(bool), bool box16BQddDisregardedEntity = default(bool), bool certifyBox17A = default(bool), bool certifyBox17B = default(bool), bool certifyBox17C = default(bool), bool certifyBox17D = default(bool), bool certifyBox17E = default(bool), bool certifyBox18A = default(bool), bool certifyBox18B = default(bool), bool certifyBox18C = default(bool), bool certifyBox18D = default(bool), bool certifyBox18E = default(bool), bool certifyBox18F = default(bool), bool certifyBox19A = default(bool), bool certifyBox19B = default(bool), bool certifyBox19C = default(bool), bool certifyBox19D = default(bool), bool certifyBox19E = default(bool), bool certifyBox19F = default(bool), bool certifyBox20 = default(bool), bool certifyBox21A = default(bool), bool certifyBox21B = default(bool), bool certifyBox21C = default(bool), bool certifyBox21D = default(bool), bool certifyBox21E = default(bool), bool certifyBox21F = default(bool), string box23ANameSponsoringEntity = default(string), bool certifyBox23B = default(bool), bool certifyBox23C = default(bool), bool certifyBox25 = default(bool), string box27ANameSponsoringEntity = default(string), bool certifyBox27B = default(bool), bool certifyBox28 = default(bool), bool certifyBox29 = default(bool), bool certifyBox30A = default(bool), bool certifyBox30B = default(bool), bool certifyBox30C = default(bool), string box32IgaCountry = default(string), string box32IgaType = default(string), string box32IgaTreatedAs = default(string), string box32TrusteeOrSponsor = default(string), bool box32TrusteeIsForeign = default(bool), bool certifyBox33A = default(bool), bool certifyBox33B = default(bool), bool certifyBox33C = default(bool), bool certifyBox33D = default(bool), bool certifyBox33E = default(bool), bool certifyBox33F = default(bool), string box37ASecuritiesMarket = default(string), string box37BNameOfEntity = default(string), string box37BSecuritiesMarket = default(string), bool certifyBox40 = default(bool), string box41SponsoringEntity = default(string), bool certifyBox42 = default(bool), DateTime? box35FormedOnDate = default(DateTime?), DateTime? box36FiledOnDate = default(DateTime?), string tinMatchStatus = default(string), string signature = default(string), string businessClassification = default(string), string businessName = default(string), string businessOther = default(string), string exemptPayeeCode = default(string), string exemptFatcaCode = default(string), string accountNumber = default(string), bool? foreignCountryIndicator = default(bool?), string foreignAddress = default(string), bool? backupWithholding = default(bool?), bool? is1099able = default(bool?), bool? foreignPartnerOwnerOrBeneficiary = default(bool?))
        {
            this.SignedDate = signedDate;
            this.DisregardedEntityChapter4FatcaStatus = disregardedEntityChapter4FatcaStatus;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.ResidenceAddress = residenceAddress;
            this.ResidenceCity = residenceCity;
            this.ResidenceState = residenceState;
            this.ResidencePostalCode = residencePostalCode;
            this.ResidenceCountry = residenceCountry;
            this.MailingAddress = mailingAddress;
            this.MailingCity = mailingCity;
            this.MailingState = mailingState;
            this.MailingPostalCode = mailingPostalCode;
            this.MailingCountry = mailingCountry;
            this.DisregardedAddress = disregardedAddress;
            this.DisregardedCity = disregardedCity;
            this.DisregardedState = disregardedState;
            this.DisregardedPostalCode = disregardedPostalCode;
            this.DisregardedCountry = disregardedCountry;
            this.Tin = tin;
            this.TypeOfTin = typeOfTin;
            this.ForeignTin = foreignTin;
            this.FtinNotRequired = ftinNotRequired;
            this.ReferenceNumber = referenceNumber;
            this.Giin = giin;
            this.Chapter3EntityType = chapter3EntityType;
            this.Chapter4FatcaStatus = chapter4FatcaStatus;
            this.DisregardedEntity = disregardedEntity;
            this.DisregardedEntityGiin = disregardedEntityGiin;
            this.BenefitLimitation = benefitLimitation;
            this.Part4SponsoringEntity = part4SponsoringEntity;
            this.Part4SponsoringEntityGiin = part4SponsoringEntityGiin;
            this.Part7SponsoringEntity = part7SponsoringEntity;
            this.Part12IgaCountry = part12IgaCountry;
            this.Part12IgaType = part12IgaType;
            this.Part12FatcaStatusUnderIgaAnnexIi = part12FatcaStatusUnderIgaAnnexIi;
            this.Part12TrusteeName = part12TrusteeName;
            this.Part12TrusteeIsForeign = part12TrusteeIsForeign;
            this.Part12Model2IgaGiin = part12Model2IgaGiin;
            this.Box37AExchange = box37AExchange;
            this.Box37BExchange = box37BExchange;
            this.Box37BEntity = box37BEntity;
            this.Part28SponsoringEntity = part28SponsoringEntity;
            this.Part28SponsoringEntityGiin = part28SponsoringEntityGiin;
            this.SignerName = signerName;
            this.EDeliveryConsentedAt = eDeliveryConsentedAt;
            this.ResidenceIsMailing = residenceIsMailing;
            this.CitizenshipCountry = citizenshipCountry;
            this.MakingTreatyClaim = makingTreatyClaim;
            this.TreatyCountry = treatyCountry;
            this.TreatyArticle = treatyArticle;
            this.WithholdingRate = withholdingRate;
            this.IncomeType = incomeType;
            this.TreatyReasons = treatyReasons;
            this.CertifyBox14A = certifyBox14A;
            this.CertifyBox14B = certifyBox14B;
            this.CertifyBox14C = certifyBox14C;
            this.CertifyBox171 = certifyBox171;
            this.CertifyBox172 = certifyBox172;
            this.CertifyBox18 = certifyBox18;
            this.CertifyBox19 = certifyBox19;
            this.CertifyBox21 = certifyBox21;
            this.CertifyBox22 = certifyBox22;
            this.CertifyBox23 = certifyBox23;
            this.CertifyBox24A = certifyBox24A;
            this.CertifyBox24B = certifyBox24B;
            this.CertifyBox24C = certifyBox24C;
            this.CertifyBox24D = certifyBox24D;
            this.CertifyBox25A = certifyBox25A;
            this.CertifyBox25B = certifyBox25B;
            this.CertifyBox25C = certifyBox25C;
            this.CertifyBox26 = certifyBox26;
            this.CertifyBox27 = certifyBox27;
            this.CertifyBox28A = certifyBox28A;
            this.CertifyBox28B = certifyBox28B;
            this.CertifyBox29A = certifyBox29A;
            this.CertifyBox29B = certifyBox29B;
            this.CertifyBox29C = certifyBox29C;
            this.CertifyBox29D = certifyBox29D;
            this.CertifyBox29E = certifyBox29E;
            this.CertifyBox29F = certifyBox29F;
            this.CertifyBox30 = certifyBox30;
            this.CertifyBox31 = certifyBox31;
            this.CertifyBox32 = certifyBox32;
            this.CertifyBox33 = certifyBox33;
            this.CertifyBox34 = certifyBox34;
            this.CertifyBox35 = certifyBox35;
            this.CertifyBox36 = certifyBox36;
            this.CertifyBox37A = certifyBox37A;
            this.CertifyBox37B = certifyBox37B;
            this.CertifyBox38 = certifyBox38;
            this.CertifyBox39 = certifyBox39;
            this.CertifyBox40A = certifyBox40A;
            this.CertifyBox40B = certifyBox40B;
            this.CertifyBox40C = certifyBox40C;
            this.CertifyBox41 = certifyBox41;
            this.CertifyBox43 = certifyBox43;
            this.CertifyPart29Signature = certifyPart29Signature;
            this.Part19FormationOrResolutionDate = part19FormationOrResolutionDate;
            this.Part20FilingDate = part20FilingDate;
            this.Part21DeterminationDate = part21DeterminationDate;
            this.SubstantialUsOwners = substantialUsOwners;
            this.EmployeeFirstName = employeeFirstName;
            this.EmployeeMiddleName = employeeMiddleName;
            this.EmployeeLastName = employeeLastName;
            this.EmployeeNameSuffix = employeeNameSuffix;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Box3MaritalStatus = box3MaritalStatus;
            this.Box4LastNameDiffers = box4LastNameDiffers;
            this.Box5NumAllowances = box5NumAllowances;
            this.OtherDependents = otherDependents;
            this.NonJobIncome = nonJobIncome;
            this.Deductions = deductions;
            this.Box6AdditionalWithheld = box6AdditionalWithheld;
            this.Box7ExemptFromWithholding = box7ExemptFromWithholding;
            this.OfficeCode = officeCode;
            this.Birthday = birthday;
            this.ForeignTinNotRequired = foreignTinNotRequired;
            this.Archived = archived;
            this.ReferenceId = referenceId;
            this.CompanyId = companyId;
            this.DisplayName = displayName;
            this.Email = email;
            this.SignerCapacity = signerCapacity;
            this.UpdatedAt = updatedAt;
            this.Ein = ein;
            this.EinType = einType;
            this.CertifyBox14 = certifyBox14;
            this.CertifyBox15A = certifyBox15A;
            this.CertifyBox15B = certifyBox15B;
            this.CertifyBox15C = certifyBox15C;
            this.CertifyBox15D = certifyBox15D;
            this.CertifyBox15E = certifyBox15E;
            this.CertifyBox15F = certifyBox15F;
            this.CertifyBox15G = certifyBox15G;
            this.CertifyBox15H = certifyBox15H;
            this.CertifyBox15I = certifyBox15I;
            this.CertifyBox16A = certifyBox16A;
            this.Box16BQddCorporate = box16BQddCorporate;
            this.Box16BQddPartnership = box16BQddPartnership;
            this.Box16BQddDisregardedEntity = box16BQddDisregardedEntity;
            this.CertifyBox17A = certifyBox17A;
            this.CertifyBox17B = certifyBox17B;
            this.CertifyBox17C = certifyBox17C;
            this.CertifyBox17D = certifyBox17D;
            this.CertifyBox17E = certifyBox17E;
            this.CertifyBox18A = certifyBox18A;
            this.CertifyBox18B = certifyBox18B;
            this.CertifyBox18C = certifyBox18C;
            this.CertifyBox18D = certifyBox18D;
            this.CertifyBox18E = certifyBox18E;
            this.CertifyBox18F = certifyBox18F;
            this.CertifyBox19A = certifyBox19A;
            this.CertifyBox19B = certifyBox19B;
            this.CertifyBox19C = certifyBox19C;
            this.CertifyBox19D = certifyBox19D;
            this.CertifyBox19E = certifyBox19E;
            this.CertifyBox19F = certifyBox19F;
            this.CertifyBox20 = certifyBox20;
            this.CertifyBox21A = certifyBox21A;
            this.CertifyBox21B = certifyBox21B;
            this.CertifyBox21C = certifyBox21C;
            this.CertifyBox21D = certifyBox21D;
            this.CertifyBox21E = certifyBox21E;
            this.CertifyBox21F = certifyBox21F;
            this.Box23ANameSponsoringEntity = box23ANameSponsoringEntity;
            this.CertifyBox23B = certifyBox23B;
            this.CertifyBox23C = certifyBox23C;
            this.CertifyBox25 = certifyBox25;
            this.Box27ANameSponsoringEntity = box27ANameSponsoringEntity;
            this.CertifyBox27B = certifyBox27B;
            this.CertifyBox28 = certifyBox28;
            this.CertifyBox29 = certifyBox29;
            this.CertifyBox30A = certifyBox30A;
            this.CertifyBox30B = certifyBox30B;
            this.CertifyBox30C = certifyBox30C;
            this.Box32IgaCountry = box32IgaCountry;
            this.Box32IgaType = box32IgaType;
            this.Box32IgaTreatedAs = box32IgaTreatedAs;
            this.Box32TrusteeOrSponsor = box32TrusteeOrSponsor;
            this.Box32TrusteeIsForeign = box32TrusteeIsForeign;
            this.CertifyBox33A = certifyBox33A;
            this.CertifyBox33B = certifyBox33B;
            this.CertifyBox33C = certifyBox33C;
            this.CertifyBox33D = certifyBox33D;
            this.CertifyBox33E = certifyBox33E;
            this.CertifyBox33F = certifyBox33F;
            this.Box37ASecuritiesMarket = box37ASecuritiesMarket;
            this.Box37BNameOfEntity = box37BNameOfEntity;
            this.Box37BSecuritiesMarket = box37BSecuritiesMarket;
            this.CertifyBox40 = certifyBox40;
            this.Box41SponsoringEntity = box41SponsoringEntity;
            this.CertifyBox42 = certifyBox42;
            this.Box35FormedOnDate = box35FormedOnDate;
            this.Box36FiledOnDate = box36FiledOnDate;
            this.TinMatchStatus = tinMatchStatus;
            this.Signature = signature;
            this.BusinessClassification = businessClassification;
            this.BusinessName = businessName;
            this.BusinessOther = businessOther;
            this.ExemptPayeeCode = exemptPayeeCode;
            this.ExemptFatcaCode = exemptFatcaCode;
            this.AccountNumber = accountNumber;
            this.ForeignCountryIndicator = foreignCountryIndicator;
            this.ForeignAddress = foreignAddress;
            this.BackupWithholding = backupWithholding;
            this.Is1099able = is1099able;
            this.ForeignPartnerOwnerOrBeneficiary = foreignPartnerOwnerOrBeneficiary;
        }

        /// <summary>
        /// The date the form was signed.
        /// </summary>
        /// <value>The date the form was signed.</value>
        /// <example>2022-04-29T00:00Z</example>
        [DataMember(Name = "signedDate", EmitDefaultValue = true)]
        public DateTime? SignedDate { get; set; }

        /// <summary>
        /// The FATCA status for disregarded entities under Chapter 4.
        /// </summary>
        /// <value>The FATCA status for disregarded entities under Chapter 4.</value>
        [DataMember(Name = "disregardedEntityChapter4FatcaStatus", EmitDefaultValue = true)]
        public string DisregardedEntityChapter4FatcaStatus { get; set; }

        /// <summary>
        /// The creation date of the form.
        /// </summary>
        /// <value>The creation date of the form.</value>
        /// <example>2022-04-29T10:00Z</example>
        [DataMember(Name = "createdAt", EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The name of the individual or entity associated with the form.
        /// </summary>
        /// <value>The name of the individual or entity associated with the form.</value>
        /// <example>Global Enterprises LLC</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The residential address of the individual or entity.
        /// </summary>
        /// <value>The residential address of the individual or entity.</value>
        /// <example>123 International Blvd</example>
        [DataMember(Name = "residenceAddress", EmitDefaultValue = true)]
        public string ResidenceAddress { get; set; }

        /// <summary>
        /// The city of residence.
        /// </summary>
        /// <value>The city of residence.</value>
        /// <example>Metropolis</example>
        [DataMember(Name = "residenceCity", EmitDefaultValue = true)]
        public string ResidenceCity { get; set; }

        /// <summary>
        /// The state of residence.
        /// </summary>
        /// <value>The state of residence.</value>
        /// <example>NY</example>
        [DataMember(Name = "residenceState", EmitDefaultValue = true)]
        public string ResidenceState { get; set; }

        /// <summary>
        /// The postal code of the residence.
        /// </summary>
        /// <value>The postal code of the residence.</value>
        /// <example>10118</example>
        [DataMember(Name = "residencePostalCode", EmitDefaultValue = true)]
        public string ResidencePostalCode { get; set; }

        /// <summary>
        /// The country of residence.
        /// </summary>
        /// <value>The country of residence.</value>
        /// <example>USA</example>
        [DataMember(Name = "residenceCountry", EmitDefaultValue = true)]
        public string ResidenceCountry { get; set; }

        /// <summary>
        /// The mailing address.
        /// </summary>
        /// <value>The mailing address.</value>
        /// <example>P.O. Box 123</example>
        [DataMember(Name = "mailingAddress", EmitDefaultValue = true)]
        public string MailingAddress { get; set; }

        /// <summary>
        /// The city of the mailing address.
        /// </summary>
        /// <value>The city of the mailing address.</value>
        /// <example>Metropolis</example>
        [DataMember(Name = "mailingCity", EmitDefaultValue = true)]
        public string MailingCity { get; set; }

        /// <summary>
        /// The state of the mailing address.
        /// </summary>
        /// <value>The state of the mailing address.</value>
        /// <example>NY</example>
        [DataMember(Name = "mailingState", EmitDefaultValue = true)]
        public string MailingState { get; set; }

        /// <summary>
        /// The postal code of the mailing address.
        /// </summary>
        /// <value>The postal code of the mailing address.</value>
        /// <example>10119</example>
        [DataMember(Name = "mailingPostalCode", EmitDefaultValue = true)]
        public string MailingPostalCode { get; set; }

        /// <summary>
        /// The country of the mailing address.
        /// </summary>
        /// <value>The country of the mailing address.</value>
        /// <example>USA</example>
        [DataMember(Name = "mailingCountry", EmitDefaultValue = true)]
        public string MailingCountry { get; set; }

        /// <summary>
        /// The address for disregarded entities.
        /// </summary>
        /// <value>The address for disregarded entities.</value>
        [DataMember(Name = "disregardedAddress", EmitDefaultValue = true)]
        public string DisregardedAddress { get; set; }

        /// <summary>
        /// The city for disregarded entities.
        /// </summary>
        /// <value>The city for disregarded entities.</value>
        [DataMember(Name = "disregardedCity", EmitDefaultValue = true)]
        public string DisregardedCity { get; set; }

        /// <summary>
        /// The state for disregarded entities.
        /// </summary>
        /// <value>The state for disregarded entities.</value>
        [DataMember(Name = "disregardedState", EmitDefaultValue = true)]
        public string DisregardedState { get; set; }

        /// <summary>
        /// The postal code for disregarded entities.
        /// </summary>
        /// <value>The postal code for disregarded entities.</value>
        [DataMember(Name = "disregardedPostalCode", EmitDefaultValue = true)]
        public string DisregardedPostalCode { get; set; }

        /// <summary>
        /// The country for disregarded entities.
        /// </summary>
        /// <value>The country for disregarded entities.</value>
        [DataMember(Name = "disregardedCountry", EmitDefaultValue = true)]
        public string DisregardedCountry { get; set; }

        /// <summary>
        /// The taxpayer identification number (TIN).
        /// </summary>
        /// <value>The taxpayer identification number (TIN).</value>
        /// <example>12-3456789</example>
        [DataMember(Name = "tin", EmitDefaultValue = true)]
        public string Tin { get; set; }

        /// <summary>
        /// The type of TIN provided.
        /// </summary>
        /// <value>The type of TIN provided.</value>
        [DataMember(Name = "typeOfTin", EmitDefaultValue = true)]
        public string TypeOfTin { get; set; }

        /// <summary>
        /// The foreign taxpayer identification number (TIN).
        /// </summary>
        /// <value>The foreign taxpayer identification number (TIN).</value>
        [DataMember(Name = "foreignTin", EmitDefaultValue = true)]
        public string ForeignTin { get; set; }

        /// <summary>
        /// Indicates whether a foreign TIN is not required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not required.</value>
        [DataMember(Name = "ftinNotRequired", EmitDefaultValue = true)]
        public bool? FtinNotRequired { get; set; }

        /// <summary>
        /// A reference number for the form.
        /// </summary>
        /// <value>A reference number for the form.</value>
        /// <example>W8BENE12345</example>
        [DataMember(Name = "referenceNumber", EmitDefaultValue = true)]
        public string ReferenceNumber { get; set; }

        /// <summary>
        /// The global intermediary identification number (GIIN).
        /// </summary>
        /// <value>The global intermediary identification number (GIIN).</value>
        /// <example>GIIN12345678</example>
        [DataMember(Name = "giin", EmitDefaultValue = true)]
        public string Giin { get; set; }

        /// <summary>
        /// The Chapter 3 entity type.
        /// </summary>
        /// <value>The Chapter 3 entity type.</value>
        /// <example>Corporation</example>
        [DataMember(Name = "chapter3EntityType", EmitDefaultValue = true)]
        public string Chapter3EntityType { get; set; }

        /// <summary>
        /// The Chapter 4 FATCA status.
        /// </summary>
        /// <value>The Chapter 4 FATCA status.</value>
        /// <example>Active</example>
        [DataMember(Name = "chapter4FatcaStatus", EmitDefaultValue = true)]
        public string Chapter4FatcaStatus { get; set; }

        /// <summary>
        /// The disregarded entity information.
        /// </summary>
        /// <value>The disregarded entity information.</value>
        /// <example>Subsidiary LLC</example>
        [DataMember(Name = "disregardedEntity", EmitDefaultValue = true)]
        public string DisregardedEntity { get; set; }

        /// <summary>
        /// The GIIN for disregarded entities.
        /// </summary>
        /// <value>The GIIN for disregarded entities.</value>
        /// <example>GIIN87654321</example>
        [DataMember(Name = "disregardedEntityGiin", EmitDefaultValue = true)]
        public string DisregardedEntityGiin { get; set; }

        /// <summary>
        /// The benefit limitation for tax treaty claims.
        /// </summary>
        /// <value>The benefit limitation for tax treaty claims.</value>
        /// <example>Treaty Benefit</example>
        [DataMember(Name = "benefitLimitation", EmitDefaultValue = true)]
        public string BenefitLimitation { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 4.
        /// </summary>
        /// <value>The sponsoring entity information for Part 4.</value>
        /// <example>Parent Company</example>
        [DataMember(Name = "part4SponsoringEntity", EmitDefaultValue = true)]
        public string Part4SponsoringEntity { get; set; }

        /// <summary>
        /// The GIIN for the sponsoring entity in Part 4.
        /// </summary>
        /// <value>The GIIN for the sponsoring entity in Part 4.</value>
        /// <example>GIIN11223344</example>
        [DataMember(Name = "part4SponsoringEntityGiin", EmitDefaultValue = true)]
        public string Part4SponsoringEntityGiin { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 7.
        /// </summary>
        /// <value>The sponsoring entity information for Part 7.</value>
        /// <example>Affiliated Organization</example>
        [DataMember(Name = "part7SponsoringEntity", EmitDefaultValue = true)]
        public string Part7SponsoringEntity { get; set; }

        /// <summary>
        /// The IGA country information for Part 12.
        /// </summary>
        /// <value>The IGA country information for Part 12.</value>
        /// <example>USA</example>
        [DataMember(Name = "part12IgaCountry", EmitDefaultValue = true)]
        public string Part12IgaCountry { get; set; }

        /// <summary>
        /// The IGA type information for Part 12.
        /// </summary>
        /// <value>The IGA type information for Part 12.</value>
        /// <example>Model 1</example>
        [DataMember(Name = "part12IgaType", EmitDefaultValue = true)]
        public string Part12IgaType { get; set; }

        /// <summary>
        /// The FATCA status under IGA Annex II for Part 12.
        /// </summary>
        /// <value>The FATCA status under IGA Annex II for Part 12.</value>
        /// <example>Registered Deemed Compliant</example>
        [DataMember(Name = "part12FatcaStatusUnderIgaAnnexIi", EmitDefaultValue = true)]
        public string Part12FatcaStatusUnderIgaAnnexIi { get; set; }

        /// <summary>
        /// The trustee name for Part 12.
        /// </summary>
        /// <value>The trustee name for Part 12.</value>
        /// <example>Trustee Inc.</example>
        [DataMember(Name = "part12TrusteeName", EmitDefaultValue = true)]
        public string Part12TrusteeName { get; set; }

        /// <summary>
        /// Indicates whether the trustee is foreign for Part 12.
        /// </summary>
        /// <value>Indicates whether the trustee is foreign for Part 12.</value>
        /// <example>false</example>
        [DataMember(Name = "part12TrusteeIsForeign", EmitDefaultValue = true)]
        public bool? Part12TrusteeIsForeign { get; set; }

        /// <summary>
        /// The GIIN for Model 2 IGA in Part 12.
        /// </summary>
        /// <value>The GIIN for Model 2 IGA in Part 12.</value>
        /// <example>GIIN33445566</example>
        [DataMember(Name = "part12Model2IgaGiin", EmitDefaultValue = true)]
        public string Part12Model2IgaGiin { get; set; }

        /// <summary>
        /// The exchange information for Box 37A.
        /// </summary>
        /// <value>The exchange information for Box 37A.</value>
        /// <example>NYSE</example>
        [DataMember(Name = "box37AExchange", EmitDefaultValue = true)]
        public string Box37AExchange { get; set; }

        /// <summary>
        /// The exchange information for Box 37B.
        /// </summary>
        /// <value>The exchange information for Box 37B.</value>
        /// <example>NASDAQ</example>
        [DataMember(Name = "box37BExchange", EmitDefaultValue = true)]
        public string Box37BExchange { get; set; }

        /// <summary>
        /// The entity information for Box 37B.
        /// </summary>
        /// <value>The entity information for Box 37B.</value>
        /// <example>Trading Partner</example>
        [DataMember(Name = "box37BEntity", EmitDefaultValue = true)]
        public string Box37BEntity { get; set; }

        /// <summary>
        /// The sponsoring entity information for Part 28.
        /// </summary>
        /// <value>The sponsoring entity information for Part 28.</value>
        /// <example>Global Trust</example>
        [DataMember(Name = "part28SponsoringEntity", EmitDefaultValue = true)]
        public string Part28SponsoringEntity { get; set; }

        /// <summary>
        /// The GIIN for the sponsoring entity in Part 28.
        /// </summary>
        /// <value>The GIIN for the sponsoring entity in Part 28.</value>
        /// <example>GIIN99887766</example>
        [DataMember(Name = "part28SponsoringEntityGiin", EmitDefaultValue = true)]
        public string Part28SponsoringEntityGiin { get; set; }

        /// <summary>
        /// The name of the signer.
        /// </summary>
        /// <value>The name of the signer.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "signerName", EmitDefaultValue = true)]
        public string SignerName { get; set; }

        /// <summary>
        /// The date when e-delivery was consented.
        /// </summary>
        /// <value>The date when e-delivery was consented.</value>
        /// <example>2022-04-29T15:30Z</example>
        [DataMember(Name = "eDeliveryConsentedAt", EmitDefaultValue = true)]
        public DateTime? EDeliveryConsentedAt { get; set; }

        /// <summary>
        /// Gets or Sets ResidenceIsMailing
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "residenceIsMailing", EmitDefaultValue = true)]
        public bool? ResidenceIsMailing { get; set; }

        /// <summary>
        /// Gets or Sets CitizenshipCountry
        /// </summary>
        [DataMember(Name = "citizenshipCountry", EmitDefaultValue = true)]
        public string CitizenshipCountry { get; set; }

        /// <summary>
        /// Gets or Sets MakingTreatyClaim
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "makingTreatyClaim", EmitDefaultValue = true)]
        public bool? MakingTreatyClaim { get; set; }

        /// <summary>
        /// Gets or Sets TreatyCountry
        /// </summary>
        [DataMember(Name = "treatyCountry", EmitDefaultValue = true)]
        public string TreatyCountry { get; set; }

        /// <summary>
        /// Gets or Sets TreatyArticle
        /// </summary>
        [DataMember(Name = "treatyArticle", EmitDefaultValue = true)]
        public string TreatyArticle { get; set; }

        /// <summary>
        /// Gets or Sets WithholdingRate
        /// </summary>
        [DataMember(Name = "withholdingRate", EmitDefaultValue = true)]
        public string WithholdingRate { get; set; }

        /// <summary>
        /// Gets or Sets IncomeType
        /// </summary>
        [DataMember(Name = "incomeType", EmitDefaultValue = true)]
        public string IncomeType { get; set; }

        /// <summary>
        /// Gets or Sets TreatyReasons
        /// </summary>
        [DataMember(Name = "treatyReasons", EmitDefaultValue = true)]
        public string TreatyReasons { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14A", EmitDefaultValue = true)]
        public bool CertifyBox14A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14B", EmitDefaultValue = true)]
        public bool CertifyBox14B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox14C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14C", EmitDefaultValue = true)]
        public bool CertifyBox14C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox171
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17_1", EmitDefaultValue = true)]
        public bool CertifyBox171 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox172
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17_2", EmitDefaultValue = true)]
        public bool CertifyBox172 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox18
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18", EmitDefaultValue = true)]
        public bool CertifyBox18 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox19
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19", EmitDefaultValue = true)]
        public bool CertifyBox19 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox21
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21", EmitDefaultValue = true)]
        public bool CertifyBox21 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox22
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox22", EmitDefaultValue = true)]
        public bool CertifyBox22 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox23
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox23", EmitDefaultValue = true)]
        public bool CertifyBox23 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24A", EmitDefaultValue = true)]
        public bool CertifyBox24A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24B", EmitDefaultValue = true)]
        public bool CertifyBox24B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24C", EmitDefaultValue = true)]
        public bool CertifyBox24C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox24D
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox24D", EmitDefaultValue = true)]
        public bool CertifyBox24D { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25A", EmitDefaultValue = true)]
        public bool CertifyBox25A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25B", EmitDefaultValue = true)]
        public bool CertifyBox25B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox25C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25C", EmitDefaultValue = true)]
        public bool CertifyBox25C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox26
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox26", EmitDefaultValue = true)]
        public bool CertifyBox26 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox27
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox27", EmitDefaultValue = true)]
        public bool CertifyBox27 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox28A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox28A", EmitDefaultValue = true)]
        public bool CertifyBox28A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox28B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox28B", EmitDefaultValue = true)]
        public bool CertifyBox28B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29A", EmitDefaultValue = true)]
        public bool CertifyBox29A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29B", EmitDefaultValue = true)]
        public bool CertifyBox29B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29C", EmitDefaultValue = true)]
        public bool CertifyBox29C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29D
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29D", EmitDefaultValue = true)]
        public bool CertifyBox29D { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29E
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29E", EmitDefaultValue = true)]
        public bool CertifyBox29E { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox29F
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29F", EmitDefaultValue = true)]
        public bool CertifyBox29F { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox30
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox30", EmitDefaultValue = true)]
        public bool CertifyBox30 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox31
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox31", EmitDefaultValue = true)]
        public bool CertifyBox31 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox32
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox32", EmitDefaultValue = true)]
        public bool CertifyBox32 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox33
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33", EmitDefaultValue = true)]
        public bool CertifyBox33 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox34
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox34", EmitDefaultValue = true)]
        public bool CertifyBox34 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox35
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox35", EmitDefaultValue = true)]
        public bool CertifyBox35 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox36
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox36", EmitDefaultValue = true)]
        public bool CertifyBox36 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox37A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox37A", EmitDefaultValue = true)]
        public bool CertifyBox37A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox37B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox37B", EmitDefaultValue = true)]
        public bool CertifyBox37B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox38
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox38", EmitDefaultValue = true)]
        public bool CertifyBox38 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox39
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox39", EmitDefaultValue = true)]
        public bool CertifyBox39 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40A
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40A", EmitDefaultValue = true)]
        public bool CertifyBox40A { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40B
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40B", EmitDefaultValue = true)]
        public bool CertifyBox40B { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox40C
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40C", EmitDefaultValue = true)]
        public bool CertifyBox40C { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox41
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox41", EmitDefaultValue = true)]
        public bool CertifyBox41 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyBox43
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyBox43", EmitDefaultValue = true)]
        public bool CertifyBox43 { get; set; }

        /// <summary>
        /// Gets or Sets CertifyPart29Signature
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "certifyPart29Signature", EmitDefaultValue = true)]
        public bool CertifyPart29Signature { get; set; }

        /// <summary>
        /// Gets or Sets Part19FormationOrResolutionDate
        /// </summary>
        [DataMember(Name = "part19FormationOrResolutionDate", EmitDefaultValue = true)]
        public DateTime? Part19FormationOrResolutionDate { get; set; }

        /// <summary>
        /// Gets or Sets Part20FilingDate
        /// </summary>
        [DataMember(Name = "part20FilingDate", EmitDefaultValue = true)]
        public DateTime? Part20FilingDate { get; set; }

        /// <summary>
        /// Gets or Sets Part21DeterminationDate
        /// </summary>
        [DataMember(Name = "part21DeterminationDate", EmitDefaultValue = true)]
        public DateTime? Part21DeterminationDate { get; set; }

        /// <summary>
        /// Gets or Sets SubstantialUsOwners
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "substantialUsOwners", EmitDefaultValue = true)]
        public List<W8BenESubstantialUsOwnerDataModel> SubstantialUsOwners { get; set; }

        /// <summary>
        /// The first name of the employee.
        /// </summary>
        /// <value>The first name of the employee.</value>
        /// <example>Jane</example>
        [DataMember(Name = "employeeFirstName", EmitDefaultValue = true)]
        public string EmployeeFirstName { get; set; }

        /// <summary>
        /// The middle name of the employee.
        /// </summary>
        /// <value>The middle name of the employee.</value>
        /// <example>A.</example>
        [DataMember(Name = "employeeMiddleName", EmitDefaultValue = true)]
        public string EmployeeMiddleName { get; set; }

        /// <summary>
        /// The last name of the employee.
        /// </summary>
        /// <value>The last name of the employee.</value>
        /// <example>Smith</example>
        [DataMember(Name = "employeeLastName", EmitDefaultValue = true)]
        public string EmployeeLastName { get; set; }

        /// <summary>
        /// The name suffix of the employee.
        /// </summary>
        /// <value>The name suffix of the employee.</value>
        /// <example>Jr.</example>
        [DataMember(Name = "employeeNameSuffix", EmitDefaultValue = true)]
        public string EmployeeNameSuffix { get; set; }

        /// <summary>
        /// The address of the individual or entity.
        /// </summary>
        /// <value>The address of the individual or entity.</value>
        /// <example>123 Main St</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>The city of the address.</value>
        /// <example>Anytown</example>
        [DataMember(Name = "city", EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>The state of the address.</value>
        /// <example>CA</example>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// The ZIP code of the address.
        /// </summary>
        /// <value>The ZIP code of the address.</value>
        /// <example>90210</example>
        [DataMember(Name = "zip", EmitDefaultValue = true)]
        public string Zip { get; set; }

        /// <summary>
        /// The marital status of the employee.
        /// </summary>
        /// <value>The marital status of the employee.</value>
        /// <example>Married</example>
        [DataMember(Name = "box3MaritalStatus", EmitDefaultValue = true)]
        public string Box3MaritalStatus { get; set; }

        /// <summary>
        /// Indicates whether the last name differs from prior records.
        /// </summary>
        /// <value>Indicates whether the last name differs from prior records.</value>
        /// <example>false</example>
        [DataMember(Name = "box4LastNameDiffers", EmitDefaultValue = true)]
        public bool? Box4LastNameDiffers { get; set; }

        /// <summary>
        /// The number of allowances claimed by the employee.
        /// </summary>
        /// <value>The number of allowances claimed by the employee.</value>
        /// <example>3</example>
        [DataMember(Name = "box5NumAllowances", EmitDefaultValue = true)]
        public int? Box5NumAllowances { get; set; }

        /// <summary>
        /// The number of dependents other than allowances.
        /// </summary>
        /// <value>The number of dependents other than allowances.</value>
        /// <example>1</example>
        [DataMember(Name = "otherDependents", EmitDefaultValue = true)]
        public int? OtherDependents { get; set; }

        /// <summary>
        /// The amount of non-job income.
        /// </summary>
        /// <value>The amount of non-job income.</value>
        /// <example>5000.0</example>
        [DataMember(Name = "nonJobIncome", EmitDefaultValue = true)]
        public double? NonJobIncome { get; set; }

        /// <summary>
        /// The amount of deductions claimed.
        /// </summary>
        /// <value>The amount of deductions claimed.</value>
        /// <example>2000.0</example>
        [DataMember(Name = "deductions", EmitDefaultValue = true)]
        public double? Deductions { get; set; }

        /// <summary>
        /// The additional amount withheld.
        /// </summary>
        /// <value>The additional amount withheld.</value>
        /// <example>150.0</example>
        [DataMember(Name = "box6AdditionalWithheld", EmitDefaultValue = true)]
        public double? Box6AdditionalWithheld { get; set; }

        /// <summary>
        /// Indicates whether the employee is exempt from withholding.
        /// </summary>
        /// <value>Indicates whether the employee is exempt from withholding.</value>
        /// <example>false</example>
        [DataMember(Name = "box7ExemptFromWithholding", EmitDefaultValue = true)]
        public bool? Box7ExemptFromWithholding { get; set; }

        /// <summary>
        /// The office code associated with the form.
        /// </summary>
        /// <value>The office code associated with the form.</value>
        /// <example>OC12345</example>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// The birthday of the individual associated with the form.
        /// </summary>
        /// <value>The birthday of the individual associated with the form.</value>
        [DataMember(Name = "birthday", EmitDefaultValue = true)]
        public string Birthday { get; set; }

        /// <summary>
        /// Indicates whether a foreign TIN is not required.
        /// </summary>
        /// <value>Indicates whether a foreign TIN is not required.</value>
        [DataMember(Name = "foreignTinNotRequired", EmitDefaultValue = true)]
        public bool? ForeignTinNotRequired { get; set; }

        /// <summary>
        /// Indicates whether the form is archived.
        /// </summary>
        /// <value>Indicates whether the form is archived.</value>
        /// <example>false</example>
        [DataMember(Name = "archived", EmitDefaultValue = true)]
        public bool? Archived { get; set; }

        /// <summary>
        /// A reference identifier for the form.
        /// </summary>
        /// <value>A reference identifier for the form.</value>
        /// <example>REF67890</example>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// The ID of the associated company.
        /// </summary>
        /// <value>The ID of the associated company.</value>
        /// <example>4004</example>
        [DataMember(Name = "companyId", EmitDefaultValue = true)]
        public int? CompanyId { get; set; }

        /// <summary>
        /// The display name associated with the form.
        /// </summary>
        /// <value>The display name associated with the form.</value>
        /// <example>Global Financials</example>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The email address of the individual associated with the form.
        /// </summary>
        /// <value>The email address of the individual associated with the form.</value>
        /// <example>contact@globalfinancials.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The capacity in which the signer is signing the form.
        /// </summary>
        /// <value>The capacity in which the signer is signing the form.</value>
        /// <example>Authorized Representative</example>
        [DataMember(Name = "signerCapacity", EmitDefaultValue = true)]
        public string SignerCapacity { get; set; }

        /// <summary>
        /// The last updated date of the form.
        /// </summary>
        /// <value>The last updated date of the form.</value>
        /// <example>2023-06-20T14:30Z</example>
        [DataMember(Name = "updatedAt", EmitDefaultValue = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The employer identification number (EIN).
        /// </summary>
        /// <value>The employer identification number (EIN).</value>
        [DataMember(Name = "ein", EmitDefaultValue = true)]
        public string Ein { get; set; }

        /// <summary>
        /// The type of employer identification number (EIN).
        /// </summary>
        /// <value>The type of employer identification number (EIN).</value>
        [DataMember(Name = "einType", EmitDefaultValue = true)]
        public string EinType { get; set; }

        /// <summary>
        /// Indicates certification for box 14.
        /// </summary>
        /// <value>Indicates certification for box 14.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox14", EmitDefaultValue = true)]
        public bool CertifyBox14 { get; set; }

        /// <summary>
        /// Indicates certification for box 15A.
        /// </summary>
        /// <value>Indicates certification for box 15A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15A", EmitDefaultValue = true)]
        public bool CertifyBox15A { get; set; }

        /// <summary>
        /// Indicates certification for box 15B.
        /// </summary>
        /// <value>Indicates certification for box 15B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15B", EmitDefaultValue = true)]
        public bool CertifyBox15B { get; set; }

        /// <summary>
        /// Indicates certification for box 15C.
        /// </summary>
        /// <value>Indicates certification for box 15C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15C", EmitDefaultValue = true)]
        public bool CertifyBox15C { get; set; }

        /// <summary>
        /// Indicates certification for box 15D.
        /// </summary>
        /// <value>Indicates certification for box 15D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15D", EmitDefaultValue = true)]
        public bool CertifyBox15D { get; set; }

        /// <summary>
        /// Indicates certification for box 15E.
        /// </summary>
        /// <value>Indicates certification for box 15E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15E", EmitDefaultValue = true)]
        public bool CertifyBox15E { get; set; }

        /// <summary>
        /// Indicates certification for box 15F.
        /// </summary>
        /// <value>Indicates certification for box 15F.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15F", EmitDefaultValue = true)]
        public bool CertifyBox15F { get; set; }

        /// <summary>
        /// Indicates certification for box 15G.
        /// </summary>
        /// <value>Indicates certification for box 15G.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15G", EmitDefaultValue = true)]
        public bool CertifyBox15G { get; set; }

        /// <summary>
        /// Indicates certification for box 15H.
        /// </summary>
        /// <value>Indicates certification for box 15H.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15H", EmitDefaultValue = true)]
        public bool CertifyBox15H { get; set; }

        /// <summary>
        /// Indicates certification for box 15I.
        /// </summary>
        /// <value>Indicates certification for box 15I.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox15I", EmitDefaultValue = true)]
        public bool CertifyBox15I { get; set; }

        /// <summary>
        /// Indicates certification for box 16A.
        /// </summary>
        /// <value>Indicates certification for box 16A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox16A", EmitDefaultValue = true)]
        public bool CertifyBox16A { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD corporate entity.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD corporate entity.</value>
        /// <example>false</example>
        [DataMember(Name = "box16BQddCorporate", EmitDefaultValue = true)]
        public bool Box16BQddCorporate { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD partnership.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD partnership.</value>
        /// <example>false</example>
        [DataMember(Name = "box16BQddPartnership", EmitDefaultValue = true)]
        public bool Box16BQddPartnership { get; set; }

        /// <summary>
        /// Indicates certification for box 16B as a QDD disregarded entity.
        /// </summary>
        /// <value>Indicates certification for box 16B as a QDD disregarded entity.</value>
        /// <example>false</example>
        [DataMember(Name = "box16BQddDisregardedEntity", EmitDefaultValue = true)]
        public bool Box16BQddDisregardedEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 17A.
        /// </summary>
        /// <value>Indicates certification for box 17A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17A", EmitDefaultValue = true)]
        public bool CertifyBox17A { get; set; }

        /// <summary>
        /// Indicates certification for box 17B.
        /// </summary>
        /// <value>Indicates certification for box 17B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17B", EmitDefaultValue = true)]
        public bool CertifyBox17B { get; set; }

        /// <summary>
        /// Indicates certification for box 17C.
        /// </summary>
        /// <value>Indicates certification for box 17C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17C", EmitDefaultValue = true)]
        public bool CertifyBox17C { get; set; }

        /// <summary>
        /// Indicates certification for box 17D.
        /// </summary>
        /// <value>Indicates certification for box 17D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17D", EmitDefaultValue = true)]
        public bool CertifyBox17D { get; set; }

        /// <summary>
        /// Indicates certification for box 17E.
        /// </summary>
        /// <value>Indicates certification for box 17E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox17E", EmitDefaultValue = true)]
        public bool CertifyBox17E { get; set; }

        /// <summary>
        /// Indicates certification for box 18A.
        /// </summary>
        /// <value>Indicates certification for box 18A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18A", EmitDefaultValue = true)]
        public bool CertifyBox18A { get; set; }

        /// <summary>
        /// Indicates certification for box 18B.
        /// </summary>
        /// <value>Indicates certification for box 18B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18B", EmitDefaultValue = true)]
        public bool CertifyBox18B { get; set; }

        /// <summary>
        /// Indicates certification for box 18C.
        /// </summary>
        /// <value>Indicates certification for box 18C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18C", EmitDefaultValue = true)]
        public bool CertifyBox18C { get; set; }

        /// <summary>
        /// Indicates certification for box 18D.
        /// </summary>
        /// <value>Indicates certification for box 18D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18D", EmitDefaultValue = true)]
        public bool CertifyBox18D { get; set; }

        /// <summary>
        /// Indicates certification for box 18E.
        /// </summary>
        /// <value>Indicates certification for box 18E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18E", EmitDefaultValue = true)]
        public bool CertifyBox18E { get; set; }

        /// <summary>
        /// Indicates certification for box 18F.
        /// </summary>
        /// <value>Indicates certification for box 18F.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox18F", EmitDefaultValue = true)]
        public bool CertifyBox18F { get; set; }

        /// <summary>
        /// Indicates certification for box 19A.
        /// </summary>
        /// <value>Indicates certification for box 19A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19A", EmitDefaultValue = true)]
        public bool CertifyBox19A { get; set; }

        /// <summary>
        /// Indicates certification for box 19B.
        /// </summary>
        /// <value>Indicates certification for box 19B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19B", EmitDefaultValue = true)]
        public bool CertifyBox19B { get; set; }

        /// <summary>
        /// Indicates certification for box 19C.
        /// </summary>
        /// <value>Indicates certification for box 19C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19C", EmitDefaultValue = true)]
        public bool CertifyBox19C { get; set; }

        /// <summary>
        /// Indicates certification for box 19D.
        /// </summary>
        /// <value>Indicates certification for box 19D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19D", EmitDefaultValue = true)]
        public bool CertifyBox19D { get; set; }

        /// <summary>
        /// Indicates certification for box 19E.
        /// </summary>
        /// <value>Indicates certification for box 19E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19E", EmitDefaultValue = true)]
        public bool CertifyBox19E { get; set; }

        /// <summary>
        /// Indicates certification for box 19F.
        /// </summary>
        /// <value>Indicates certification for box 19F.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox19F", EmitDefaultValue = true)]
        public bool CertifyBox19F { get; set; }

        /// <summary>
        /// Indicates certification for box 20.
        /// </summary>
        /// <value>Indicates certification for box 20.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox20", EmitDefaultValue = true)]
        public bool CertifyBox20 { get; set; }

        /// <summary>
        /// Indicates certification for box 21A.
        /// </summary>
        /// <value>Indicates certification for box 21A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21A", EmitDefaultValue = true)]
        public bool CertifyBox21A { get; set; }

        /// <summary>
        /// Indicates certification for box 21B.
        /// </summary>
        /// <value>Indicates certification for box 21B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21B", EmitDefaultValue = true)]
        public bool CertifyBox21B { get; set; }

        /// <summary>
        /// Indicates certification for box 21C.
        /// </summary>
        /// <value>Indicates certification for box 21C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21C", EmitDefaultValue = true)]
        public bool CertifyBox21C { get; set; }

        /// <summary>
        /// Indicates certification for box 21D.
        /// </summary>
        /// <value>Indicates certification for box 21D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21D", EmitDefaultValue = true)]
        public bool CertifyBox21D { get; set; }

        /// <summary>
        /// Indicates certification for box 21E.
        /// </summary>
        /// <value>Indicates certification for box 21E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21E", EmitDefaultValue = true)]
        public bool CertifyBox21E { get; set; }

        /// <summary>
        /// Indicates certification for box 21F.
        /// </summary>
        /// <value>Indicates certification for box 21F.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox21F", EmitDefaultValue = true)]
        public bool CertifyBox21F { get; set; }

        /// <summary>
        /// The name of the sponsoring entity for box 23A.
        /// </summary>
        /// <value>The name of the sponsoring entity for box 23A.</value>
        [DataMember(Name = "box23ANameSponsoringEntity", EmitDefaultValue = true)]
        public string Box23ANameSponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 23B.
        /// </summary>
        /// <value>Indicates certification for box 23B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox23B", EmitDefaultValue = true)]
        public bool CertifyBox23B { get; set; }

        /// <summary>
        /// Indicates certification for box 23C.
        /// </summary>
        /// <value>Indicates certification for box 23C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox23C", EmitDefaultValue = true)]
        public bool CertifyBox23C { get; set; }

        /// <summary>
        /// Indicates certification for box 25.
        /// </summary>
        /// <value>Indicates certification for box 25.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox25", EmitDefaultValue = true)]
        public bool CertifyBox25 { get; set; }

        /// <summary>
        /// The name of the sponsoring entity for box 27A.
        /// </summary>
        /// <value>The name of the sponsoring entity for box 27A.</value>
        [DataMember(Name = "box27ANameSponsoringEntity", EmitDefaultValue = true)]
        public string Box27ANameSponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 27B.
        /// </summary>
        /// <value>Indicates certification for box 27B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox27B", EmitDefaultValue = true)]
        public bool CertifyBox27B { get; set; }

        /// <summary>
        /// Indicates certification for box 28.
        /// </summary>
        /// <value>Indicates certification for box 28.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox28", EmitDefaultValue = true)]
        public bool CertifyBox28 { get; set; }

        /// <summary>
        /// Indicates certification for box 29.
        /// </summary>
        /// <value>Indicates certification for box 29.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox29", EmitDefaultValue = true)]
        public bool CertifyBox29 { get; set; }

        /// <summary>
        /// Indicates certification for box 30A.
        /// </summary>
        /// <value>Indicates certification for box 30A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox30A", EmitDefaultValue = true)]
        public bool CertifyBox30A { get; set; }

        /// <summary>
        /// Indicates certification for box 30B.
        /// </summary>
        /// <value>Indicates certification for box 30B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox30B", EmitDefaultValue = true)]
        public bool CertifyBox30B { get; set; }

        /// <summary>
        /// Indicates certification for box 30C.
        /// </summary>
        /// <value>Indicates certification for box 30C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox30C", EmitDefaultValue = true)]
        public bool CertifyBox30C { get; set; }

        /// <summary>
        /// The IGA country information for box 32.
        /// </summary>
        /// <value>The IGA country information for box 32.</value>
        [DataMember(Name = "box32IgaCountry", EmitDefaultValue = true)]
        public string Box32IgaCountry { get; set; }

        /// <summary>
        /// The IGA type information for box 32.
        /// </summary>
        /// <value>The IGA type information for box 32.</value>
        [DataMember(Name = "box32IgaType", EmitDefaultValue = true)]
        public string Box32IgaType { get; set; }

        /// <summary>
        /// The IGA treatment information for box 32.
        /// </summary>
        /// <value>The IGA treatment information for box 32.</value>
        [DataMember(Name = "box32IgaTreatedAs", EmitDefaultValue = true)]
        public string Box32IgaTreatedAs { get; set; }

        /// <summary>
        /// The trustee or sponsor information for box 32.
        /// </summary>
        /// <value>The trustee or sponsor information for box 32.</value>
        [DataMember(Name = "box32TrusteeOrSponsor", EmitDefaultValue = true)]
        public string Box32TrusteeOrSponsor { get; set; }

        /// <summary>
        /// Indicates whether the trustee is foreign for box 32.
        /// </summary>
        /// <value>Indicates whether the trustee is foreign for box 32.</value>
        /// <example>false</example>
        [DataMember(Name = "box32TrusteeIsForeign", EmitDefaultValue = true)]
        public bool Box32TrusteeIsForeign { get; set; }

        /// <summary>
        /// Indicates certification for box 33A.
        /// </summary>
        /// <value>Indicates certification for box 33A.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33A", EmitDefaultValue = true)]
        public bool CertifyBox33A { get; set; }

        /// <summary>
        /// Indicates certification for box 33B.
        /// </summary>
        /// <value>Indicates certification for box 33B.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33B", EmitDefaultValue = true)]
        public bool CertifyBox33B { get; set; }

        /// <summary>
        /// Indicates certification for box 33C.
        /// </summary>
        /// <value>Indicates certification for box 33C.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33C", EmitDefaultValue = true)]
        public bool CertifyBox33C { get; set; }

        /// <summary>
        /// Indicates certification for box 33D.
        /// </summary>
        /// <value>Indicates certification for box 33D.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33D", EmitDefaultValue = true)]
        public bool CertifyBox33D { get; set; }

        /// <summary>
        /// Indicates certification for box 33E.
        /// </summary>
        /// <value>Indicates certification for box 33E.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33E", EmitDefaultValue = true)]
        public bool CertifyBox33E { get; set; }

        /// <summary>
        /// Indicates certification for box 33F.
        /// </summary>
        /// <value>Indicates certification for box 33F.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox33F", EmitDefaultValue = true)]
        public bool CertifyBox33F { get; set; }

        /// <summary>
        /// The securities market information for box 37A.
        /// </summary>
        /// <value>The securities market information for box 37A.</value>
        [DataMember(Name = "box37ASecuritiesMarket", EmitDefaultValue = true)]
        public string Box37ASecuritiesMarket { get; set; }

        /// <summary>
        /// The name of the entity for box 37B.
        /// </summary>
        /// <value>The name of the entity for box 37B.</value>
        [DataMember(Name = "box37BNameOfEntity", EmitDefaultValue = true)]
        public string Box37BNameOfEntity { get; set; }

        /// <summary>
        /// The securities market information for box 37B.
        /// </summary>
        /// <value>The securities market information for box 37B.</value>
        [DataMember(Name = "box37BSecuritiesMarket", EmitDefaultValue = true)]
        public string Box37BSecuritiesMarket { get; set; }

        /// <summary>
        /// Indicates certification for box 40.
        /// </summary>
        /// <value>Indicates certification for box 40.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox40", EmitDefaultValue = true)]
        public bool CertifyBox40 { get; set; }

        /// <summary>
        /// The sponsoring entity information for box 41.
        /// </summary>
        /// <value>The sponsoring entity information for box 41.</value>
        [DataMember(Name = "box41SponsoringEntity", EmitDefaultValue = true)]
        public string Box41SponsoringEntity { get; set; }

        /// <summary>
        /// Indicates certification for box 42.
        /// </summary>
        /// <value>Indicates certification for box 42.</value>
        /// <example>false</example>
        [DataMember(Name = "certifyBox42", EmitDefaultValue = true)]
        public bool CertifyBox42 { get; set; }

        /// <summary>
        /// Gets or Sets Box35FormedOnDate
        /// </summary>
        [DataMember(Name = "box35FormedOnDate", EmitDefaultValue = true)]
        public DateTime? Box35FormedOnDate { get; set; }

        /// <summary>
        /// Gets or Sets Box36FiledOnDate
        /// </summary>
        [DataMember(Name = "box36FiledOnDate", EmitDefaultValue = true)]
        public DateTime? Box36FiledOnDate { get; set; }

        /// <summary>
        /// The status of the TIN match.
        /// </summary>
        /// <value>The status of the TIN match.</value>
        /// <example>Match</example>
        [DataMember(Name = "tinMatchStatus", EmitDefaultValue = true)]
        public string TinMatchStatus { get; set; }

        /// <summary>
        /// The signature itself
        /// </summary>
        /// <value>The signature itself</value>
        [DataMember(Name = "signature", EmitDefaultValue = true)]
        public string Signature { get; set; }

        /// <summary>
        /// The classification of the business.
        /// </summary>
        /// <value>The classification of the business.</value>
        /// <example>LLC</example>
        [DataMember(Name = "businessClassification", EmitDefaultValue = true)]
        public string BusinessClassification { get; set; }

        /// <summary>
        /// The name of the business associated with the form.
        /// </summary>
        /// <value>The name of the business associated with the form.</value>
        /// <example>Doe Enterprises</example>
        [DataMember(Name = "businessName", EmitDefaultValue = true)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets BusinessOther
        /// </summary>
        [DataMember(Name = "businessOther", EmitDefaultValue = true)]
        public string BusinessOther { get; set; }

        /// <summary>
        /// Gets or Sets ExemptPayeeCode
        /// </summary>
        [DataMember(Name = "exemptPayeeCode", EmitDefaultValue = true)]
        public string ExemptPayeeCode { get; set; }

        /// <summary>
        /// Gets or Sets ExemptFatcaCode
        /// </summary>
        [DataMember(Name = "exemptFatcaCode", EmitDefaultValue = true)]
        public string ExemptFatcaCode { get; set; }

        /// <summary>
        /// The account number associated with the form.
        /// </summary>
        /// <value>The account number associated with the form.</value>
        /// <example>ACC123456</example>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Indicates whether the individual or entity is in a foreign country.
        /// </summary>
        /// <value>Indicates whether the individual or entity is in a foreign country.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignCountryIndicator", EmitDefaultValue = true)]
        public bool? ForeignCountryIndicator { get; set; }

        /// <summary>
        /// The foreign address of the individual or entity.
        /// </summary>
        /// <value>The foreign address of the individual or entity.</value>
        [DataMember(Name = "foreignAddress", EmitDefaultValue = true)]
        public string ForeignAddress { get; set; }

        /// <summary>
        /// Indicates whether backup withholding applies.
        /// </summary>
        /// <value>Indicates whether backup withholding applies.</value>
        /// <example>false</example>
        [DataMember(Name = "backupWithholding", EmitDefaultValue = true)]
        public bool? BackupWithholding { get; set; }

        /// <summary>
        /// Gets or Sets Is1099able
        /// </summary>
        [DataMember(Name = "is1099able", EmitDefaultValue = true)]
        public bool? Is1099able { get; set; }

        /// <summary>
        /// Indicates whether the individual is a foreign partner, owner, or beneficiary.
        /// </summary>
        /// <value>Indicates whether the individual is a foreign partner, owner, or beneficiary.</value>
        /// <example>false</example>
        [DataMember(Name = "foreignPartnerOwnerOrBeneficiary", EmitDefaultValue = true)]
        public bool? ForeignPartnerOwnerOrBeneficiary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class W8BeneFormDataModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SignedDate: ").Append(SignedDate).Append("\n");
            sb.Append("  DisregardedEntityChapter4FatcaStatus: ").Append(DisregardedEntityChapter4FatcaStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ResidenceAddress: ").Append(ResidenceAddress).Append("\n");
            sb.Append("  ResidenceCity: ").Append(ResidenceCity).Append("\n");
            sb.Append("  ResidenceState: ").Append(ResidenceState).Append("\n");
            sb.Append("  ResidencePostalCode: ").Append(ResidencePostalCode).Append("\n");
            sb.Append("  ResidenceCountry: ").Append(ResidenceCountry).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
            sb.Append("  MailingCity: ").Append(MailingCity).Append("\n");
            sb.Append("  MailingState: ").Append(MailingState).Append("\n");
            sb.Append("  MailingPostalCode: ").Append(MailingPostalCode).Append("\n");
            sb.Append("  MailingCountry: ").Append(MailingCountry).Append("\n");
            sb.Append("  DisregardedAddress: ").Append(DisregardedAddress).Append("\n");
            sb.Append("  DisregardedCity: ").Append(DisregardedCity).Append("\n");
            sb.Append("  DisregardedState: ").Append(DisregardedState).Append("\n");
            sb.Append("  DisregardedPostalCode: ").Append(DisregardedPostalCode).Append("\n");
            sb.Append("  DisregardedCountry: ").Append(DisregardedCountry).Append("\n");
            sb.Append("  Tin: ").Append(Tin).Append("\n");
            sb.Append("  TypeOfTin: ").Append(TypeOfTin).Append("\n");
            sb.Append("  ForeignTin: ").Append(ForeignTin).Append("\n");
            sb.Append("  FtinNotRequired: ").Append(FtinNotRequired).Append("\n");
            sb.Append("  ReferenceNumber: ").Append(ReferenceNumber).Append("\n");
            sb.Append("  Giin: ").Append(Giin).Append("\n");
            sb.Append("  Chapter3EntityType: ").Append(Chapter3EntityType).Append("\n");
            sb.Append("  Chapter4FatcaStatus: ").Append(Chapter4FatcaStatus).Append("\n");
            sb.Append("  DisregardedEntity: ").Append(DisregardedEntity).Append("\n");
            sb.Append("  DisregardedEntityGiin: ").Append(DisregardedEntityGiin).Append("\n");
            sb.Append("  BenefitLimitation: ").Append(BenefitLimitation).Append("\n");
            sb.Append("  Part4SponsoringEntity: ").Append(Part4SponsoringEntity).Append("\n");
            sb.Append("  Part4SponsoringEntityGiin: ").Append(Part4SponsoringEntityGiin).Append("\n");
            sb.Append("  Part7SponsoringEntity: ").Append(Part7SponsoringEntity).Append("\n");
            sb.Append("  Part12IgaCountry: ").Append(Part12IgaCountry).Append("\n");
            sb.Append("  Part12IgaType: ").Append(Part12IgaType).Append("\n");
            sb.Append("  Part12FatcaStatusUnderIgaAnnexIi: ").Append(Part12FatcaStatusUnderIgaAnnexIi).Append("\n");
            sb.Append("  Part12TrusteeName: ").Append(Part12TrusteeName).Append("\n");
            sb.Append("  Part12TrusteeIsForeign: ").Append(Part12TrusteeIsForeign).Append("\n");
            sb.Append("  Part12Model2IgaGiin: ").Append(Part12Model2IgaGiin).Append("\n");
            sb.Append("  Box37AExchange: ").Append(Box37AExchange).Append("\n");
            sb.Append("  Box37BExchange: ").Append(Box37BExchange).Append("\n");
            sb.Append("  Box37BEntity: ").Append(Box37BEntity).Append("\n");
            sb.Append("  Part28SponsoringEntity: ").Append(Part28SponsoringEntity).Append("\n");
            sb.Append("  Part28SponsoringEntityGiin: ").Append(Part28SponsoringEntityGiin).Append("\n");
            sb.Append("  SignerName: ").Append(SignerName).Append("\n");
            sb.Append("  EDeliveryConsentedAt: ").Append(EDeliveryConsentedAt).Append("\n");
            sb.Append("  ResidenceIsMailing: ").Append(ResidenceIsMailing).Append("\n");
            sb.Append("  CitizenshipCountry: ").Append(CitizenshipCountry).Append("\n");
            sb.Append("  MakingTreatyClaim: ").Append(MakingTreatyClaim).Append("\n");
            sb.Append("  TreatyCountry: ").Append(TreatyCountry).Append("\n");
            sb.Append("  TreatyArticle: ").Append(TreatyArticle).Append("\n");
            sb.Append("  WithholdingRate: ").Append(WithholdingRate).Append("\n");
            sb.Append("  IncomeType: ").Append(IncomeType).Append("\n");
            sb.Append("  TreatyReasons: ").Append(TreatyReasons).Append("\n");
            sb.Append("  CertifyBox14A: ").Append(CertifyBox14A).Append("\n");
            sb.Append("  CertifyBox14B: ").Append(CertifyBox14B).Append("\n");
            sb.Append("  CertifyBox14C: ").Append(CertifyBox14C).Append("\n");
            sb.Append("  CertifyBox171: ").Append(CertifyBox171).Append("\n");
            sb.Append("  CertifyBox172: ").Append(CertifyBox172).Append("\n");
            sb.Append("  CertifyBox18: ").Append(CertifyBox18).Append("\n");
            sb.Append("  CertifyBox19: ").Append(CertifyBox19).Append("\n");
            sb.Append("  CertifyBox21: ").Append(CertifyBox21).Append("\n");
            sb.Append("  CertifyBox22: ").Append(CertifyBox22).Append("\n");
            sb.Append("  CertifyBox23: ").Append(CertifyBox23).Append("\n");
            sb.Append("  CertifyBox24A: ").Append(CertifyBox24A).Append("\n");
            sb.Append("  CertifyBox24B: ").Append(CertifyBox24B).Append("\n");
            sb.Append("  CertifyBox24C: ").Append(CertifyBox24C).Append("\n");
            sb.Append("  CertifyBox24D: ").Append(CertifyBox24D).Append("\n");
            sb.Append("  CertifyBox25A: ").Append(CertifyBox25A).Append("\n");
            sb.Append("  CertifyBox25B: ").Append(CertifyBox25B).Append("\n");
            sb.Append("  CertifyBox25C: ").Append(CertifyBox25C).Append("\n");
            sb.Append("  CertifyBox26: ").Append(CertifyBox26).Append("\n");
            sb.Append("  CertifyBox27: ").Append(CertifyBox27).Append("\n");
            sb.Append("  CertifyBox28A: ").Append(CertifyBox28A).Append("\n");
            sb.Append("  CertifyBox28B: ").Append(CertifyBox28B).Append("\n");
            sb.Append("  CertifyBox29A: ").Append(CertifyBox29A).Append("\n");
            sb.Append("  CertifyBox29B: ").Append(CertifyBox29B).Append("\n");
            sb.Append("  CertifyBox29C: ").Append(CertifyBox29C).Append("\n");
            sb.Append("  CertifyBox29D: ").Append(CertifyBox29D).Append("\n");
            sb.Append("  CertifyBox29E: ").Append(CertifyBox29E).Append("\n");
            sb.Append("  CertifyBox29F: ").Append(CertifyBox29F).Append("\n");
            sb.Append("  CertifyBox30: ").Append(CertifyBox30).Append("\n");
            sb.Append("  CertifyBox31: ").Append(CertifyBox31).Append("\n");
            sb.Append("  CertifyBox32: ").Append(CertifyBox32).Append("\n");
            sb.Append("  CertifyBox33: ").Append(CertifyBox33).Append("\n");
            sb.Append("  CertifyBox34: ").Append(CertifyBox34).Append("\n");
            sb.Append("  CertifyBox35: ").Append(CertifyBox35).Append("\n");
            sb.Append("  CertifyBox36: ").Append(CertifyBox36).Append("\n");
            sb.Append("  CertifyBox37A: ").Append(CertifyBox37A).Append("\n");
            sb.Append("  CertifyBox37B: ").Append(CertifyBox37B).Append("\n");
            sb.Append("  CertifyBox38: ").Append(CertifyBox38).Append("\n");
            sb.Append("  CertifyBox39: ").Append(CertifyBox39).Append("\n");
            sb.Append("  CertifyBox40A: ").Append(CertifyBox40A).Append("\n");
            sb.Append("  CertifyBox40B: ").Append(CertifyBox40B).Append("\n");
            sb.Append("  CertifyBox40C: ").Append(CertifyBox40C).Append("\n");
            sb.Append("  CertifyBox41: ").Append(CertifyBox41).Append("\n");
            sb.Append("  CertifyBox43: ").Append(CertifyBox43).Append("\n");
            sb.Append("  CertifyPart29Signature: ").Append(CertifyPart29Signature).Append("\n");
            sb.Append("  Part19FormationOrResolutionDate: ").Append(Part19FormationOrResolutionDate).Append("\n");
            sb.Append("  Part20FilingDate: ").Append(Part20FilingDate).Append("\n");
            sb.Append("  Part21DeterminationDate: ").Append(Part21DeterminationDate).Append("\n");
            sb.Append("  SubstantialUsOwners: ").Append(SubstantialUsOwners).Append("\n");
            sb.Append("  EmployeeFirstName: ").Append(EmployeeFirstName).Append("\n");
            sb.Append("  EmployeeMiddleName: ").Append(EmployeeMiddleName).Append("\n");
            sb.Append("  EmployeeLastName: ").Append(EmployeeLastName).Append("\n");
            sb.Append("  EmployeeNameSuffix: ").Append(EmployeeNameSuffix).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  Box3MaritalStatus: ").Append(Box3MaritalStatus).Append("\n");
            sb.Append("  Box4LastNameDiffers: ").Append(Box4LastNameDiffers).Append("\n");
            sb.Append("  Box5NumAllowances: ").Append(Box5NumAllowances).Append("\n");
            sb.Append("  OtherDependents: ").Append(OtherDependents).Append("\n");
            sb.Append("  NonJobIncome: ").Append(NonJobIncome).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Box6AdditionalWithheld: ").Append(Box6AdditionalWithheld).Append("\n");
            sb.Append("  Box7ExemptFromWithholding: ").Append(Box7ExemptFromWithholding).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  ForeignTinNotRequired: ").Append(ForeignTinNotRequired).Append("\n");
            sb.Append("  Archived: ").Append(Archived).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  SignerCapacity: ").Append(SignerCapacity).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
            sb.Append("  EinType: ").Append(EinType).Append("\n");
            sb.Append("  CertifyBox14: ").Append(CertifyBox14).Append("\n");
            sb.Append("  CertifyBox15A: ").Append(CertifyBox15A).Append("\n");
            sb.Append("  CertifyBox15B: ").Append(CertifyBox15B).Append("\n");
            sb.Append("  CertifyBox15C: ").Append(CertifyBox15C).Append("\n");
            sb.Append("  CertifyBox15D: ").Append(CertifyBox15D).Append("\n");
            sb.Append("  CertifyBox15E: ").Append(CertifyBox15E).Append("\n");
            sb.Append("  CertifyBox15F: ").Append(CertifyBox15F).Append("\n");
            sb.Append("  CertifyBox15G: ").Append(CertifyBox15G).Append("\n");
            sb.Append("  CertifyBox15H: ").Append(CertifyBox15H).Append("\n");
            sb.Append("  CertifyBox15I: ").Append(CertifyBox15I).Append("\n");
            sb.Append("  CertifyBox16A: ").Append(CertifyBox16A).Append("\n");
            sb.Append("  Box16BQddCorporate: ").Append(Box16BQddCorporate).Append("\n");
            sb.Append("  Box16BQddPartnership: ").Append(Box16BQddPartnership).Append("\n");
            sb.Append("  Box16BQddDisregardedEntity: ").Append(Box16BQddDisregardedEntity).Append("\n");
            sb.Append("  CertifyBox17A: ").Append(CertifyBox17A).Append("\n");
            sb.Append("  CertifyBox17B: ").Append(CertifyBox17B).Append("\n");
            sb.Append("  CertifyBox17C: ").Append(CertifyBox17C).Append("\n");
            sb.Append("  CertifyBox17D: ").Append(CertifyBox17D).Append("\n");
            sb.Append("  CertifyBox17E: ").Append(CertifyBox17E).Append("\n");
            sb.Append("  CertifyBox18A: ").Append(CertifyBox18A).Append("\n");
            sb.Append("  CertifyBox18B: ").Append(CertifyBox18B).Append("\n");
            sb.Append("  CertifyBox18C: ").Append(CertifyBox18C).Append("\n");
            sb.Append("  CertifyBox18D: ").Append(CertifyBox18D).Append("\n");
            sb.Append("  CertifyBox18E: ").Append(CertifyBox18E).Append("\n");
            sb.Append("  CertifyBox18F: ").Append(CertifyBox18F).Append("\n");
            sb.Append("  CertifyBox19A: ").Append(CertifyBox19A).Append("\n");
            sb.Append("  CertifyBox19B: ").Append(CertifyBox19B).Append("\n");
            sb.Append("  CertifyBox19C: ").Append(CertifyBox19C).Append("\n");
            sb.Append("  CertifyBox19D: ").Append(CertifyBox19D).Append("\n");
            sb.Append("  CertifyBox19E: ").Append(CertifyBox19E).Append("\n");
            sb.Append("  CertifyBox19F: ").Append(CertifyBox19F).Append("\n");
            sb.Append("  CertifyBox20: ").Append(CertifyBox20).Append("\n");
            sb.Append("  CertifyBox21A: ").Append(CertifyBox21A).Append("\n");
            sb.Append("  CertifyBox21B: ").Append(CertifyBox21B).Append("\n");
            sb.Append("  CertifyBox21C: ").Append(CertifyBox21C).Append("\n");
            sb.Append("  CertifyBox21D: ").Append(CertifyBox21D).Append("\n");
            sb.Append("  CertifyBox21E: ").Append(CertifyBox21E).Append("\n");
            sb.Append("  CertifyBox21F: ").Append(CertifyBox21F).Append("\n");
            sb.Append("  Box23ANameSponsoringEntity: ").Append(Box23ANameSponsoringEntity).Append("\n");
            sb.Append("  CertifyBox23B: ").Append(CertifyBox23B).Append("\n");
            sb.Append("  CertifyBox23C: ").Append(CertifyBox23C).Append("\n");
            sb.Append("  CertifyBox25: ").Append(CertifyBox25).Append("\n");
            sb.Append("  Box27ANameSponsoringEntity: ").Append(Box27ANameSponsoringEntity).Append("\n");
            sb.Append("  CertifyBox27B: ").Append(CertifyBox27B).Append("\n");
            sb.Append("  CertifyBox28: ").Append(CertifyBox28).Append("\n");
            sb.Append("  CertifyBox29: ").Append(CertifyBox29).Append("\n");
            sb.Append("  CertifyBox30A: ").Append(CertifyBox30A).Append("\n");
            sb.Append("  CertifyBox30B: ").Append(CertifyBox30B).Append("\n");
            sb.Append("  CertifyBox30C: ").Append(CertifyBox30C).Append("\n");
            sb.Append("  Box32IgaCountry: ").Append(Box32IgaCountry).Append("\n");
            sb.Append("  Box32IgaType: ").Append(Box32IgaType).Append("\n");
            sb.Append("  Box32IgaTreatedAs: ").Append(Box32IgaTreatedAs).Append("\n");
            sb.Append("  Box32TrusteeOrSponsor: ").Append(Box32TrusteeOrSponsor).Append("\n");
            sb.Append("  Box32TrusteeIsForeign: ").Append(Box32TrusteeIsForeign).Append("\n");
            sb.Append("  CertifyBox33A: ").Append(CertifyBox33A).Append("\n");
            sb.Append("  CertifyBox33B: ").Append(CertifyBox33B).Append("\n");
            sb.Append("  CertifyBox33C: ").Append(CertifyBox33C).Append("\n");
            sb.Append("  CertifyBox33D: ").Append(CertifyBox33D).Append("\n");
            sb.Append("  CertifyBox33E: ").Append(CertifyBox33E).Append("\n");
            sb.Append("  CertifyBox33F: ").Append(CertifyBox33F).Append("\n");
            sb.Append("  Box37ASecuritiesMarket: ").Append(Box37ASecuritiesMarket).Append("\n");
            sb.Append("  Box37BNameOfEntity: ").Append(Box37BNameOfEntity).Append("\n");
            sb.Append("  Box37BSecuritiesMarket: ").Append(Box37BSecuritiesMarket).Append("\n");
            sb.Append("  CertifyBox40: ").Append(CertifyBox40).Append("\n");
            sb.Append("  Box41SponsoringEntity: ").Append(Box41SponsoringEntity).Append("\n");
            sb.Append("  CertifyBox42: ").Append(CertifyBox42).Append("\n");
            sb.Append("  Box35FormedOnDate: ").Append(Box35FormedOnDate).Append("\n");
            sb.Append("  Box36FiledOnDate: ").Append(Box36FiledOnDate).Append("\n");
            sb.Append("  TinMatchStatus: ").Append(TinMatchStatus).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  BusinessClassification: ").Append(BusinessClassification).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  BusinessOther: ").Append(BusinessOther).Append("\n");
            sb.Append("  ExemptPayeeCode: ").Append(ExemptPayeeCode).Append("\n");
            sb.Append("  ExemptFatcaCode: ").Append(ExemptFatcaCode).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ForeignCountryIndicator: ").Append(ForeignCountryIndicator).Append("\n");
            sb.Append("  ForeignAddress: ").Append(ForeignAddress).Append("\n");
            sb.Append("  BackupWithholding: ").Append(BackupWithholding).Append("\n");
            sb.Append("  Is1099able: ").Append(Is1099able).Append("\n");
            sb.Append("  ForeignPartnerOwnerOrBeneficiary: ").Append(ForeignPartnerOwnerOrBeneficiary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
