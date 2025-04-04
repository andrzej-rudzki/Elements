//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements.Fittings
{
    #pragma warning disable // Disable all warnings

    /// <summary>Pressure calc data</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class PressureCalculationTerminal : PressureCalculationBase
    {
        [JsonConstructor]
        public PressureCalculationTerminal(double? @fixedPressure, double @pipeLoss, double @flow, double @fluidVelocity, double @zLoss, double @z, double @diameter, double @diameterInner, double @length, double @staticGain, double @heightDelta, double @dynamicPressure, double @frictionLossCoefficient, System.Guid @elementId)
            : base(elementId)
        {
            this.FixedPressure = @fixedPressure;
            this.PipeLoss = @pipeLoss;
            this.Flow = @flow;
            this.FluidVelocity = @fluidVelocity;
            this.ZLoss = @zLoss;
            this.Z = @z;
            this.Diameter = @diameter;
            this.DiameterInner = @diameterInner;
            this.Length = @length;
            this.StaticGain = @staticGain;
            this.HeightDelta = @heightDelta;
            this.DynamicPressure = @dynamicPressure;
            this.FrictionLossCoefficient = @frictionLossCoefficient;
            }
        
        // Empty constructor
        public PressureCalculationTerminal()
            : base()
        {
        }
    
        [JsonProperty("FixedPressure", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FixedPressure { get; set; }
    
        [JsonProperty("PipeLoss", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double PipeLoss { get; set; }
    
        [JsonProperty("Flow", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Flow { get; set; }
    
        [JsonProperty("FluidVelocity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double FluidVelocity { get; set; }
    
        [JsonProperty("ZLoss", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double ZLoss { get; set; }
    
        [JsonProperty("Z", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Z { get; set; }
    
        [JsonProperty("Diameter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Diameter { get; set; }
    
        [JsonProperty("DiameterInner", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DiameterInner { get; set; }
    
        [JsonProperty("Length", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Length { get; set; }
    
        [JsonProperty("StaticGain", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double StaticGain { get; set; }
    
        [JsonProperty("HeightDelta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double HeightDelta { get; set; }
    
        [JsonProperty("DynamicPressure", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DynamicPressure { get; set; }
    
        [JsonProperty("FrictionLossCoefficient", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double FrictionLossCoefficient { get; set; }
    
    
    }
}