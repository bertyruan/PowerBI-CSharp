// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class SSRSTile
    {
        /// <summary>
        /// Initializes a new instance of the SSRSTile class.
        /// </summary>
        public SSRSTile() { }

        /// <summary>
        /// Initializes a new instance of the SSRSTile class.
        /// </summary>
        public SSRSTile(string imageUrl)
        {
            ImageUrl = imageUrl;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageUrl")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ImageUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ImageUrl");
            }
        }
    }
}
