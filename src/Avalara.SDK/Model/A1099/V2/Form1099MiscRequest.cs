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
    /// Form1099MiscRequest
    /// </summary>
    [DataContract(Name = "Form1099MiscRequest")]
    public partial class Form1099MiscRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1099MiscRequest" /> class.
        /// </summary>
        /// <param name="stateAndLocalWithholding">stateAndLocalWithholding.</param>
        /// <param name="secondTinNotice">secondTinNotice.</param>
        /// <param name="rents">rents.</param>
        /// <param name="royalties">royalties.</param>
        /// <param name="otherIncome">otherIncome.</param>
        /// <param name="fedIncomeTaxWithheld">fedIncomeTaxWithheld.</param>
        /// <param name="fishingBoatProceeds">fishingBoatProceeds.</param>
        /// <param name="medicalHealthCarePayments">medicalHealthCarePayments.</param>
        /// <param name="payerMadeDirectSales">payerMadeDirectSales.</param>
        /// <param name="substitutePayments">substitutePayments.</param>
        /// <param name="cropInsuranceProceeds">cropInsuranceProceeds.</param>
        /// <param name="grossProceedsPaidToAttorney">grossProceedsPaidToAttorney.</param>
        /// <param name="fishPurchasedForResale">fishPurchasedForResale.</param>
        /// <param name="section409ADeferrals">section409ADeferrals.</param>
        /// <param name="fatcaFilingRequirement">fatcaFilingRequirement.</param>
        /// <param name="excessGoldenParachutePayments">excessGoldenParachutePayments.</param>
        /// <param name="nonqualifiedDeferredCompensation">nonqualifiedDeferredCompensation.</param>
        /// <param name="type">type.</param>
        /// <param name="issuerId">issuerId.</param>
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
        public Form1099MiscRequest(StateAndLocalWithholdingRequest stateAndLocalWithholding = default(StateAndLocalWithholdingRequest), bool secondTinNotice = default(bool), double rents = default(double), double royalties = default(double), double otherIncome = default(double), double fedIncomeTaxWithheld = default(double), double fishingBoatProceeds = default(double), double medicalHealthCarePayments = default(double), bool payerMadeDirectSales = default(bool), double substitutePayments = default(double), double cropInsuranceProceeds = default(double), double grossProceedsPaidToAttorney = default(double), double fishPurchasedForResale = default(double), double section409ADeferrals = default(double), bool fatcaFilingRequirement = default(bool), double excessGoldenParachutePayments = default(double), double nonqualifiedDeferredCompensation = default(double), string type = default(string), string issuerId = default(string), string referenceId = default(string), string recipientName = default(string), string recipientTin = default(string), string tinType = default(string), string recipientSecondName = default(string), string streetAddress = default(string), string streetAddressLine2 = default(string), string city = default(string), string state = default(string), string zip = default(string), string recipientEmail = default(string), string accountNumber = default(string), string officeCode = default(string), string recipientNonUsProvince = default(string), string countryCode = default(string), bool federalEFile = default(bool), bool postalMail = default(bool), bool stateEFile = default(bool), bool tinMatch = default(bool), bool addressVerification = default(bool))
        {
            this.StateAndLocalWithholding = stateAndLocalWithholding;
            this.SecondTinNotice = secondTinNotice;
            this.Rents = rents;
            this.Royalties = royalties;
            this.OtherIncome = otherIncome;
            this.FedIncomeTaxWithheld = fedIncomeTaxWithheld;
            this.FishingBoatProceeds = fishingBoatProceeds;
            this.MedicalHealthCarePayments = medicalHealthCarePayments;
            this.PayerMadeDirectSales = payerMadeDirectSales;
            this.SubstitutePayments = substitutePayments;
            this.CropInsuranceProceeds = cropInsuranceProceeds;
            this.GrossProceedsPaidToAttorney = grossProceedsPaidToAttorney;
            this.FishPurchasedForResale = fishPurchasedForResale;
            this.Section409ADeferrals = section409ADeferrals;
            this.FatcaFilingRequirement = fatcaFilingRequirement;
            this.ExcessGoldenParachutePayments = excessGoldenParachutePayments;
            this.NonqualifiedDeferredCompensation = nonqualifiedDeferredCompensation;
            this.Type = type;
            this.IssuerId = issuerId;
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
        [DataMember(Name = "stateAndLocalWithholding", EmitDefaultValue = true)]
        public StateAndLocalWithholdingRequest StateAndLocalWithholding { get; set; }

        /// <summary>
        /// Gets or Sets SecondTinNotice
        /// </summary>
        [DataMember(Name = "secondTinNotice", EmitDefaultValue = true)]
        public bool SecondTinNotice { get; set; }

        /// <summary>
        /// Gets or Sets Rents
        /// </summary>
        [DataMember(Name = "rents", EmitDefaultValue = false)]
        public double Rents { get; set; }

        /// <summary>
        /// Gets or Sets Royalties
        /// </summary>
        [DataMember(Name = "royalties", EmitDefaultValue = false)]
        public double Royalties { get; set; }

        /// <summary>
        /// Gets or Sets OtherIncome
        /// </summary>
        [DataMember(Name = "otherIncome", EmitDefaultValue = false)]
        public double OtherIncome { get; set; }

        /// <summary>
        /// Gets or Sets FedIncomeTaxWithheld
        /// </summary>
        [DataMember(Name = "fedIncomeTaxWithheld", EmitDefaultValue = false)]
        public double FedIncomeTaxWithheld { get; set; }

        /// <summary>
        /// Gets or Sets FishingBoatProceeds
        /// </summary>
        [DataMember(Name = "fishingBoatProceeds", EmitDefaultValue = false)]
        public double FishingBoatProceeds { get; set; }

        /// <summary>
        /// Gets or Sets MedicalHealthCarePayments
        /// </summary>
        [DataMember(Name = "medicalHealthCarePayments", EmitDefaultValue = false)]
        public double MedicalHealthCarePayments { get; set; }

        /// <summary>
        /// Gets or Sets PayerMadeDirectSales
        /// </summary>
        [DataMember(Name = "payerMadeDirectSales", EmitDefaultValue = true)]
        public bool PayerMadeDirectSales { get; set; }

        /// <summary>
        /// Gets or Sets SubstitutePayments
        /// </summary>
        [DataMember(Name = "substitutePayments", EmitDefaultValue = false)]
        public double SubstitutePayments { get; set; }

        /// <summary>
        /// Gets or Sets CropInsuranceProceeds
        /// </summary>
        [DataMember(Name = "cropInsuranceProceeds", EmitDefaultValue = false)]
        public double CropInsuranceProceeds { get; set; }

        /// <summary>
        /// Gets or Sets GrossProceedsPaidToAttorney
        /// </summary>
        [DataMember(Name = "grossProceedsPaidToAttorney", EmitDefaultValue = false)]
        public double GrossProceedsPaidToAttorney { get; set; }

        /// <summary>
        /// Gets or Sets FishPurchasedForResale
        /// </summary>
        [DataMember(Name = "fishPurchasedForResale", EmitDefaultValue = false)]
        public double FishPurchasedForResale { get; set; }

        /// <summary>
        /// Gets or Sets Section409ADeferrals
        /// </summary>
        [DataMember(Name = "section409ADeferrals", EmitDefaultValue = false)]
        public double Section409ADeferrals { get; set; }

        /// <summary>
        /// Gets or Sets FatcaFilingRequirement
        /// </summary>
        [DataMember(Name = "fatcaFilingRequirement", EmitDefaultValue = true)]
        public bool FatcaFilingRequirement { get; set; }

        /// <summary>
        /// Gets or Sets ExcessGoldenParachutePayments
        /// </summary>
        [DataMember(Name = "excessGoldenParachutePayments", EmitDefaultValue = false)]
        public double ExcessGoldenParachutePayments { get; set; }

        /// <summary>
        /// Gets or Sets NonqualifiedDeferredCompensation
        /// </summary>
        [DataMember(Name = "nonqualifiedDeferredCompensation", EmitDefaultValue = false)]
        public double NonqualifiedDeferredCompensation { get; set; }

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
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = true)]
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
        public string TinType { get; set; }

        /// <summary>
        /// Gets or Sets RecipientSecondName
        /// </summary>
        [DataMember(Name = "recipientSecondName", EmitDefaultValue = true)]
        public string RecipientSecondName { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name = "streetAddress", EmitDefaultValue = false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or Sets StreetAddressLine2
        /// </summary>
        [DataMember(Name = "streetAddressLine2", EmitDefaultValue = true)]
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
        [DataMember(Name = "recipientEmail", EmitDefaultValue = true)]
        public string RecipientEmail { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name = "accountNumber", EmitDefaultValue = true)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets OfficeCode
        /// </summary>
        [DataMember(Name = "officeCode", EmitDefaultValue = true)]
        public string OfficeCode { get; set; }

        /// <summary>
        /// Gets or Sets RecipientNonUsProvince
        /// </summary>
        [DataMember(Name = "recipientNonUsProvince", EmitDefaultValue = true)]
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
            sb.Append("class Form1099MiscRequest {\n");
            sb.Append("  StateAndLocalWithholding: ").Append(StateAndLocalWithholding).Append("\n");
            sb.Append("  SecondTinNotice: ").Append(SecondTinNotice).Append("\n");
            sb.Append("  Rents: ").Append(Rents).Append("\n");
            sb.Append("  Royalties: ").Append(Royalties).Append("\n");
            sb.Append("  OtherIncome: ").Append(OtherIncome).Append("\n");
            sb.Append("  FedIncomeTaxWithheld: ").Append(FedIncomeTaxWithheld).Append("\n");
            sb.Append("  FishingBoatProceeds: ").Append(FishingBoatProceeds).Append("\n");
            sb.Append("  MedicalHealthCarePayments: ").Append(MedicalHealthCarePayments).Append("\n");
            sb.Append("  PayerMadeDirectSales: ").Append(PayerMadeDirectSales).Append("\n");
            sb.Append("  SubstitutePayments: ").Append(SubstitutePayments).Append("\n");
            sb.Append("  CropInsuranceProceeds: ").Append(CropInsuranceProceeds).Append("\n");
            sb.Append("  GrossProceedsPaidToAttorney: ").Append(GrossProceedsPaidToAttorney).Append("\n");
            sb.Append("  FishPurchasedForResale: ").Append(FishPurchasedForResale).Append("\n");
            sb.Append("  Section409ADeferrals: ").Append(Section409ADeferrals).Append("\n");
            sb.Append("  FatcaFilingRequirement: ").Append(FatcaFilingRequirement).Append("\n");
            sb.Append("  ExcessGoldenParachutePayments: ").Append(ExcessGoldenParachutePayments).Append("\n");
            sb.Append("  NonqualifiedDeferredCompensation: ").Append(NonqualifiedDeferredCompensation).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssuerId: ").Append(IssuerId).Append("\n");
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
