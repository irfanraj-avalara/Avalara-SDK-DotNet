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
    /// Form1099RRequest
    /// </summary>
    [DataContract(Name = "Form1099RRequest")]
    public partial class Form1099RRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099RRequest" /> class.
        /// </summary>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        /// <param name="grossDistribution">grossDistribution.</param>
        /// <param name="taxableAmount">taxableAmount.</param>
        /// <param name="taxableAmountNotDetermined">taxableAmountNotDetermined.</param>
        /// <param name="totalDistributionDetermined">totalDistributionDetermined.</param>
        /// <param name="capitalGain">capitalGain.</param>
        /// <param name="federalIncomeTaxWithheld">federalIncomeTaxWithheld.</param>
        /// <param name="employeeContributionsOrDesignatedRothOrInsurancePremiums">employeeContributionsOrDesignatedRothOrInsurancePremiums.</param>
        /// <param name="netUnrealizedAppreciationInEmployerSecurities">netUnrealizedAppreciationInEmployerSecurities.</param>
        /// <param name="distributionCode">distributionCode.</param>
        /// <param name="secondDistributionCode">secondDistributionCode.</param>
        /// <param name="iraSepSimple">iraSepSimple.</param>
        /// <param name="traditionalIraSepSimpleOrRothConversionAmount">traditionalIraSepSimpleOrRothConversionAmount.</param>
        /// <param name="otherAmount">otherAmount.</param>
        /// <param name="otherPercentage">otherPercentage.</param>
        /// <param name="totalDistributionPercentage">totalDistributionPercentage.</param>
        /// <param name="totalEmployeeContributions">totalEmployeeContributions.</param>
        /// <param name="amountAllocableToIrrWithin5Years">amountAllocableToIrrWithin5Years.</param>
        /// <param name="firstYearOfDesignatedRothContribution">firstYearOfDesignatedRothContribution.</param>
        /// <param name="fatcaFilingRequirement">fatcaFilingRequirement.</param>
        /// <param name="dateOfPayment">dateOfPayment.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">issuerId.</param>
        /// <param name="issuerReferenceId">issuerReferenceId.</param>
        /// <param name="issuerTin">issuerTin.</param>
        /// <param name="taxYear">taxYear.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="recipientName">recipientName.</param>
        /// <param name="recipientTin">recipientTin.</param>
        /// <param name="tinType">tinType.</param>
        /// <param name="recipientSecondName">recipientSecondName.</param>
        /// <param name="streetAddress">streetAddress.</param>
        /// <param name="streetAddressLine2">streetAddressLine2.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="recipientEmail">recipientEmail.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="officeCode">officeCode.</param>
        /// <param name="recipientNonUsProvince">recipientNonUsProvince.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="federalEFile">federalEFile.</param>
        /// <param name="postalMail">postalMail.</param>
        /// <param name="stateEFile">stateEFile.</param>
        /// <param name="tinMatch">tinMatch.</param>
        /// <param name="addressVerification">addressVerification.</param>
        public Form1099RRequest(StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest), double grossDistribution = default(double), double taxableAmount = default(double), bool taxableAmountNotDetermined = default(bool), bool totalDistributionDetermined = default(bool), double capitalGain = default(double), double federalIncomeTaxWithheld = default(double), double employeeContributionsOrDesignatedRothOrInsurancePremiums = default(double), double netUnrealizedAppreciationInEmployerSecurities = default(double), string distributionCode = default(string), string secondDistributionCode = default(string), bool iraSepSimple = default(bool), double traditionalIraSepSimpleOrRothConversionAmount = default(double), double otherAmount = default(double), string otherPercentage = default(string), string totalDistributionPercentage = default(string), double totalEmployeeContributions = default(double), double amountAllocableToIrrWithin5Years = default(double), string firstYearOfDesignatedRothContribution = default(string), bool fatcaFilingRequirement = default(bool), DateTime dateOfPayment = default(DateTime), string type = default(string), string issuerId = default(string), string issuerReferenceId = default(string), string issuerTin = default(string), int taxYear = default(int), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), int tinType = default(int), string recipientSecondName = default(string), string streetAddress = default(string), string streetAddressLine2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool))
        {
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.GrossDistribution = grossDistribution;
            this.TaxableAmount = taxableAmount;
            this.TaxableAmountNotDetermined = taxableAmountNotDetermined;
            this.TotalDistributionDetermined = totalDistributionDetermined;
            this.CapitalGain = capitalGain;
            this.FederalIncomeTaxWithheld = federalIncomeTaxWithheld;
            this.EmployeeContributionsOrDesignatedRothOrInsurancePremiums = employeeContributionsOrDesignatedRothOrInsurancePremiums;
            this.NetUnrealizedAppreciationInEmployerSecurities = netUnrealizedAppreciationInEmployerSecurities;
            this.DistributionCode = distributionCode;
            this.SecondDistributionCode = secondDistributionCode;
            this.IraSepSimple = iraSepSimple;
            this.TraditionalIraSepSimpleOrRothConversionAmount = traditionalIraSepSimpleOrRothConversionAmount;
            this.OtherAmount = otherAmount;
            this.OtherPercentage = otherPercentage;
            this.TotalDistributionPercentage = totalDistributionPercentage;
            this.TotalEmployeeContributions = totalEmployeeContributions;
            this.AmountAllocableToIrrWithin5Years = amountAllocableToIrrWithin5Years;
            this.FirstYearOfDesignatedRothContribution = firstYearOfDesignatedRothContribution;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.DateOfPayment = dateOfPayment;
            this.Type = type;
            this.IssuerId = issuerId;
            this.IssuerReferenceId = issuerReferenceId;
            this.IssuerTin = issuerTin;
            this.TaxYear = taxYear;
            this.ReferenceId = referenceId;
            this.RecipientName = recipientName;
            this.RecipientTin = recipientTin;
            this.TinType = tinType;
            this.RecipientSecondName = recipientSecondName;
            this.StreetAddress = streetAddress;
            this.StreetAddressLine2 = streetAddressLine2;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.RecipientEmail = recipientEmail;
            this.AccountNumber = accountNumber;
            this.OfficeCode = officeCode;
            this.RecipientNonUsProvince = recipientNonUsProvince;
            this.CountryCode = countryCode;
            this.FederalEFile = federalEFile;
            this.PostalMail = postalMail;
            this.StateEFile = stateEFile;
            this.TinMatch = tinMatch;
            this.AddressVerification = addressVerification;
        }

        /// <summary>
        /// Gets or Sets StateAndLocalWithholding
        /// </summary>
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = false)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Gets or Sets GrossDistribution
        /// </summary>
        [DataMember(Name = "grossDistribution", EmitDefaultValue = false)]
        public double GrossDistribution { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmount
        /// </summary>
        [DataMember(Name = "taxableAmount", EmitDefaultValue = false)]
        public double TaxableAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxableAmountNotDetermined
        /// </summary>
        [DataMember(Name = "taxableAmountNotDetermined", EmitDefaultValue = true)]
        public bool TaxableAmountNotDetermined { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistributionDetermined
        /// </summary>
        [DataMember(Name = "totalDistributionDetermined", EmitDefaultValue = true)]
        public bool TotalDistributionDetermined { get; set; }

        /// <summary>
        /// Gets or Sets CapitalGain
        /// </summary>
        [DataMember(Name = "capitalGain", EmitDefaultValue = false)]
        public double CapitalGain { get; set; }

        /// <summary>
        /// Gets or Sets FederalIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "federalIncomeTaxWithheld", EmitDefaultValue = false)]
        public double FederalIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeContributionsOrDesignatedRothOrInsurancePremiums
        /// </summary>
        [DataMember(Name = "employeeContributionsOrDesignatedRothOrInsurancePremiums", EmitDefaultValue = false)]
        public double EmployeeContributionsOrDesignatedRothOrInsurancePremiums { get; set; }

        /// <summary>
        /// Gets or Sets NetUnrealizedAppreciationInEmployerSecurities
        /// </summary>
        [DataMember(Name = "netUnrealizedAppreciationInEmployerSecurities", EmitDefaultValue = false)]
        public double NetUnrealizedAppreciationInEmployerSecurities { get; set; }

        /// <summary>
        /// Gets or Sets DistributionCode
        /// </summary>
        [DataMember(Name = "distributionCode", EmitDefaultValue = false)]
        public string DistributionCode { get; set; }

        /// <summary>
        /// Gets or Sets SecondDistributionCode
        /// </summary>
        [DataMember(Name = "secondDistributionCode", EmitDefaultValue = false)]
        public string SecondDistributionCode { get; set; }

        /// <summary>
        /// Gets or Sets IraSepSimple
        /// </summary>
        [DataMember(Name = "iraSepSimple", EmitDefaultValue = true)]
        public bool IraSepSimple { get; set; }

        /// <summary>
        /// Gets or Sets TraditionalIraSepSimpleOrRothConversionAmount
        /// </summary>
        [DataMember(Name = "traditionalIraSepSimpleOrRothConversionAmount", EmitDefaultValue = false)]
        public double TraditionalIraSepSimpleOrRothConversionAmount { get; set; }

        /// <summary>
        /// Gets or Sets OtherAmount
        /// </summary>
        [DataMember(Name = "otherAmount", EmitDefaultValue = false)]
        public double OtherAmount { get; set; }

        /// <summary>
        /// Gets or Sets OtherPercentage
        /// </summary>
        [DataMember(Name = "otherPercentage", EmitDefaultValue = false)]
        public string OtherPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalDistributionPercentage
        /// </summary>
        [DataMember(Name = "totalDistributionPercentage", EmitDefaultValue = false)]
        public string TotalDistributionPercentage { get; set; }

        /// <summary>
        /// Gets or Sets TotalEmployeeContributions
        /// </summary>
        [DataMember(Name = "totalEmployeeContributions", EmitDefaultValue = false)]
        public double TotalEmployeeContributions { get; set; }

        /// <summary>
        /// Gets or Sets AmountAllocableToIrrWithin5Years
        /// </summary>
        [DataMember(Name = "amountAllocableToIrrWithin5Years", EmitDefaultValue = false)]
        public double AmountAllocableToIrrWithin5Years { get; set; }

        /// <summary>
        /// Gets or Sets FirstYearOfDesignatedRothContribution
        /// </summary>
        [DataMember(Name = "firstYearOfDesignatedRothContribution", EmitDefaultValue = false)]
        public string FirstYearOfDesignatedRothContribution { get; set; }

        /// <summary>
        /// Gets or Sets FatcaFilingRequirement
        /// </summary>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Gets or Sets DateOfPayment
        /// </summary>
        [DataMember(Name = "dateOfPayment", EmitDefaultValue = false)]
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IssuerId
        /// </summary>
        [DataMember(Name = "issuerId", EmitDefaultValue = false)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerReferenceId
        /// </summary>
        [DataMember(Name = "issuerReferenceId", EmitDefaultValue = false)]
        public string IssuerReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets IssuerTin
        /// </summary>
        [DataMember(Name = "issuerTin", EmitDefaultValue = false)]
        public string IssuerTin { get; set; }

        /// <summary>
        /// Gets or Sets TaxYear
        /// </summary>
        [DataMember(Name = "taxYear", EmitDefaultValue = false)]
        public int TaxYear { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets RecipientName
        /// </summary>
        [DataMember(Name = "recipientName", EmitDefaultValue = false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Gets or Sets RecipientTin
        /// </summary>
        [DataMember(Name = "recipientTin", EmitDefaultValue = false)]
        public string RecipientTin { get; set; }

        /// <summary>
        /// Gets or Sets TinType
        /// </summary>
        [DataMember(Name = "tinType", EmitDefaultValue = false)]
        public int TinType { get; set; }

        /// <summary>
        /// Gets or Sets RecipientSecondName
        /// </summary>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = false)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddressLine2
        /// </summary>
        [DataMember(Name = "streetAddressLine2", EmitDefaultValue = false)]
        public string StreetAddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Zip
        /// </summary>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or Sets RecipientEmail
        /// </summary>
        [DataMember(Name = "recipientEmail", EmitDefaultValue = false)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficeCode
        /// </summary>
        [DataMember(Name = "officeCode", EmitDefaultValue = false)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Gets or Sets RecipientNonUsProvince
        /// </summary>
        [DataMember(Name = "recipientNonUsProvince", EmitDefaultValue = false)]
        public string RecipientNonUsProvince { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets FederalEFile
        /// </summary>
        [DataMember(Name = "federalEFile", EmitDefaultValue = true)]
        public bool FederalEFile { get; set; }

        /// <summary>
        /// Gets or Sets PostalMail
        /// </summary>
        [DataMember(Name = "postalMail", EmitDefaultValue = true)]
        public bool PostalMail { get; set; }

        /// <summary>
        /// Gets or Sets StateEFile
        /// </summary>
        [DataMember(Name = "stateEFile", EmitDefaultValue = true)]
        public bool StateEFile { get; set; }

        /// <summary>
        /// Gets or Sets TinMatch
        /// </summary>
        [DataMember(Name = "tinMatch", EmitDefaultValue = true)]
        public bool TinMatch { get; set; }

        /// <summary>
        /// Gets or Sets AddressVerification
        /// </summary>
        [DataMember(Name = "addressVerification", EmitDefaultValue = true)]
        public bool AddressVerification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Form1099RRequest {\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  GrossDistribution: ").Append(GrossDistribution).Append("\n");
            sb.Append("  TaxableAmount: ").Append(TaxableAmount).Append("\n");
            sb.Append("  TaxableAmountNotDetermined: ").Append(TaxableAmountNotDetermined).Append("\n");
            sb.Append("  TotalDistributionDetermined: ").Append(TotalDistributionDetermined).Append("\n");
            sb.Append("  CapitalGain: ").Append(CapitalGain).Append("\n");
            sb.Append("  FederalIncomeTaxWithheld: ").Append(FederalIncomeTaxWithheld).Append("\n");
            sb.Append("  EmployeeContributionsOrDesignatedRothOrInsurancePremiums: ").Append(EmployeeContributionsOrDesignatedRothOrInsurancePremiums).Append("\n");
            sb.Append("  NetUnrealizedAppreciationInEmployerSecurities: ").Append(NetUnrealizedAppreciationInEmployerSecurities).Append("\n");
            sb.Append("  DistributionCode: ").Append(DistributionCode).Append("\n");
            sb.Append("  SecondDistributionCode: ").Append(SecondDistributionCode).Append("\n");
            sb.Append("  IraSepSimple: ").Append(IraSepSimple).Append("\n");
            sb.Append("  TraditionalIraSepSimpleOrRothConversionAmount: ").Append(TraditionalIraSepSimpleOrRothConversionAmount).Append("\n");
            sb.Append("  OtherAmount: ").Append(OtherAmount).Append("\n");
            sb.Append("  OtherPercentage: ").Append(OtherPercentage).Append("\n");
            sb.Append("  TotalDistributionPercentage: ").Append(TotalDistributionPercentage).Append("\n");
            sb.Append("  TotalEmployeeContributions: ").Append(TotalEmployeeContributions).Append("\n");
            sb.Append("  AmountAllocableToIrrWithin5Years: ").Append(AmountAllocableToIrrWithin5Years).Append("\n");
            sb.Append("  FirstYearOfDesignatedRothContribution: ").Append(FirstYearOfDesignatedRothContribution).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  DateOfPayment: ").Append(DateOfPayment).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
            sb.Append("  IssuerReferenceId: ").Append(IssuerReferenceId).Append("\n");
            sb.Append("  IssuerTin: ").Append(IssuerTin).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientTin: ").Append(RecipientTin).Append("\n");
            sb.Append("  TinType: ").Append(TinType).Append("\n");
            sb.Append("  RecipientSecondName: ").Append(RecipientSecondName).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  StreetAddressLine2: ").Append(StreetAddressLine2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  OfficeCode: ").Append(OfficeCode).Append("\n");
            sb.Append("  RecipientNonUsProvince: ").Append(RecipientNonUsProvince).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  FederalEFile: ").Append(FederalEFile).Append("\n");
            sb.Append("  PostalMail: ").Append(PostalMail).Append("\n");
            sb.Append("  StateEFile: ").Append(StateEFile).Append("\n");
            sb.Append("  TinMatch: ").Append(TinMatch).Append("\n");
            sb.Append("  AddressVerification: ").Append(AddressVerification).Append("\n");
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
