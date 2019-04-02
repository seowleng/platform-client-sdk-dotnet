using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Browser
    /// </summary>
    [DataContract]
    public partial class Browser :  IEquatable<Browser>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Browser() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Browser" /> class.
        /// </summary>
        /// <param name="Family">Browser family (e.g. Chrome, Safari, Firefox). (required).</param>
        /// <param name="Version">Browser version (e.g. 68.0.3440.84). (required).</param>
        /// <param name="Lang">Language the browser is set to. Must conform to BCP 47..</param>
        /// <param name="Fingerprint">Fingerprint generated by looking at the individual browser features..</param>
        /// <param name="IsMobile">Flag that is true for mobile devices..</param>
        /// <param name="ViewHeight">Browser&#39;s viewport height..</param>
        /// <param name="ViewWidth">Browser&#39;s viewport width..</param>
        /// <param name="FeaturesFlash">Whether Flash is installed..</param>
        /// <param name="FeaturesJava">Whether Java is installed..</param>
        /// <param name="FeaturesPdf">Whether the browser recognizes PDFs..</param>
        /// <param name="FeaturesWebrtc">Whether WebRTC is supported..</param>
        public Browser(string Family = null, string Version = null, string Lang = null, string Fingerprint = null, bool? IsMobile = null, int? ViewHeight = null, int? ViewWidth = null, bool? FeaturesFlash = null, bool? FeaturesJava = null, bool? FeaturesPdf = null, bool? FeaturesWebrtc = null)
        {
            this.Family = Family;
            this.Version = Version;
            this.Lang = Lang;
            this.Fingerprint = Fingerprint;
            this.IsMobile = IsMobile;
            this.ViewHeight = ViewHeight;
            this.ViewWidth = ViewWidth;
            this.FeaturesFlash = FeaturesFlash;
            this.FeaturesJava = FeaturesJava;
            this.FeaturesPdf = FeaturesPdf;
            this.FeaturesWebrtc = FeaturesWebrtc;
            
        }
        
        
        
        /// <summary>
        /// Browser family (e.g. Chrome, Safari, Firefox).
        /// </summary>
        /// <value>Browser family (e.g. Chrome, Safari, Firefox).</value>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public string Family { get; set; }
        
        
        
        /// <summary>
        /// Browser version (e.g. 68.0.3440.84).
        /// </summary>
        /// <value>Browser version (e.g. 68.0.3440.84).</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }
        
        
        
        /// <summary>
        /// Language the browser is set to. Must conform to BCP 47.
        /// </summary>
        /// <value>Language the browser is set to. Must conform to BCP 47.</value>
        [DataMember(Name="lang", EmitDefaultValue=false)]
        public string Lang { get; set; }
        
        
        
        /// <summary>
        /// Fingerprint generated by looking at the individual browser features.
        /// </summary>
        /// <value>Fingerprint generated by looking at the individual browser features.</value>
        [DataMember(Name="fingerprint", EmitDefaultValue=false)]
        public string Fingerprint { get; set; }
        
        
        
        /// <summary>
        /// Flag that is true for mobile devices.
        /// </summary>
        /// <value>Flag that is true for mobile devices.</value>
        [DataMember(Name="isMobile", EmitDefaultValue=false)]
        public bool? IsMobile { get; set; }
        
        
        
        /// <summary>
        /// Browser&#39;s viewport height.
        /// </summary>
        /// <value>Browser&#39;s viewport height.</value>
        [DataMember(Name="viewHeight", EmitDefaultValue=false)]
        public int? ViewHeight { get; set; }
        
        
        
        /// <summary>
        /// Browser&#39;s viewport width.
        /// </summary>
        /// <value>Browser&#39;s viewport width.</value>
        [DataMember(Name="viewWidth", EmitDefaultValue=false)]
        public int? ViewWidth { get; set; }
        
        
        
        /// <summary>
        /// Whether Flash is installed.
        /// </summary>
        /// <value>Whether Flash is installed.</value>
        [DataMember(Name="featuresFlash", EmitDefaultValue=false)]
        public bool? FeaturesFlash { get; set; }
        
        
        
        /// <summary>
        /// Whether Java is installed.
        /// </summary>
        /// <value>Whether Java is installed.</value>
        [DataMember(Name="featuresJava", EmitDefaultValue=false)]
        public bool? FeaturesJava { get; set; }
        
        
        
        /// <summary>
        /// Whether the browser recognizes PDFs.
        /// </summary>
        /// <value>Whether the browser recognizes PDFs.</value>
        [DataMember(Name="featuresPdf", EmitDefaultValue=false)]
        public bool? FeaturesPdf { get; set; }
        
        
        
        /// <summary>
        /// Whether WebRTC is supported.
        /// </summary>
        /// <value>Whether WebRTC is supported.</value>
        [DataMember(Name="featuresWebrtc", EmitDefaultValue=false)]
        public bool? FeaturesWebrtc { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Browser {\n");
            
            sb.Append("  Family: ").Append(Family).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
            sb.Append("  IsMobile: ").Append(IsMobile).Append("\n");
            sb.Append("  ViewHeight: ").Append(ViewHeight).Append("\n");
            sb.Append("  ViewWidth: ").Append(ViewWidth).Append("\n");
            sb.Append("  FeaturesFlash: ").Append(FeaturesFlash).Append("\n");
            sb.Append("  FeaturesJava: ").Append(FeaturesJava).Append("\n");
            sb.Append("  FeaturesPdf: ").Append(FeaturesPdf).Append("\n");
            sb.Append("  FeaturesWebrtc: ").Append(FeaturesWebrtc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Browser);
        }

        /// <summary>
        /// Returns true if Browser instances are equal
        /// </summary>
        /// <param name="other">Instance of Browser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Browser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.Lang == other.Lang ||
                    this.Lang != null &&
                    this.Lang.Equals(other.Lang)
                ) &&
                (
                    this.Fingerprint == other.Fingerprint ||
                    this.Fingerprint != null &&
                    this.Fingerprint.Equals(other.Fingerprint)
                ) &&
                (
                    this.IsMobile == other.IsMobile ||
                    this.IsMobile != null &&
                    this.IsMobile.Equals(other.IsMobile)
                ) &&
                (
                    this.ViewHeight == other.ViewHeight ||
                    this.ViewHeight != null &&
                    this.ViewHeight.Equals(other.ViewHeight)
                ) &&
                (
                    this.ViewWidth == other.ViewWidth ||
                    this.ViewWidth != null &&
                    this.ViewWidth.Equals(other.ViewWidth)
                ) &&
                (
                    this.FeaturesFlash == other.FeaturesFlash ||
                    this.FeaturesFlash != null &&
                    this.FeaturesFlash.Equals(other.FeaturesFlash)
                ) &&
                (
                    this.FeaturesJava == other.FeaturesJava ||
                    this.FeaturesJava != null &&
                    this.FeaturesJava.Equals(other.FeaturesJava)
                ) &&
                (
                    this.FeaturesPdf == other.FeaturesPdf ||
                    this.FeaturesPdf != null &&
                    this.FeaturesPdf.Equals(other.FeaturesPdf)
                ) &&
                (
                    this.FeaturesWebrtc == other.FeaturesWebrtc ||
                    this.FeaturesWebrtc != null &&
                    this.FeaturesWebrtc.Equals(other.FeaturesWebrtc)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.Lang != null)
                    hash = hash * 59 + this.Lang.GetHashCode();
                
                if (this.Fingerprint != null)
                    hash = hash * 59 + this.Fingerprint.GetHashCode();
                
                if (this.IsMobile != null)
                    hash = hash * 59 + this.IsMobile.GetHashCode();
                
                if (this.ViewHeight != null)
                    hash = hash * 59 + this.ViewHeight.GetHashCode();
                
                if (this.ViewWidth != null)
                    hash = hash * 59 + this.ViewWidth.GetHashCode();
                
                if (this.FeaturesFlash != null)
                    hash = hash * 59 + this.FeaturesFlash.GetHashCode();
                
                if (this.FeaturesJava != null)
                    hash = hash * 59 + this.FeaturesJava.GetHashCode();
                
                if (this.FeaturesPdf != null)
                    hash = hash * 59 + this.FeaturesPdf.GetHashCode();
                
                if (this.FeaturesWebrtc != null)
                    hash = hash * 59 + this.FeaturesWebrtc.GetHashCode();
                
                return hash;
            }
        }
    }

}
