﻿//---------------------------------------------------------------------
// <copyright file="PluggableFormatResolver.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.Test.OData.Services.PluggableFormat
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.OData.Core;
    using Microsoft.Test.OData.PluggableFormat.VCard;
#if ENABLE_AVRO
    using Microsoft.Test.OData.PluggableFormat.Avro;
#endif

    public class PluggableFormatResolver : ODataMediaTypeResolver
    {
        private static readonly PluggableFormatResolver instance = new PluggableFormatResolver();
        private readonly ODataMediaTypeFormat[] vcardFormats = { new ODataMediaTypeFormat(new ODataMediaType("text", "x-vCard"), new VCardFormat()) };
#if ENABLE_AVRO
        private readonly ODataMediaTypeFormat[] avroFormats = { new ODataMediaTypeFormat(new ODataMediaType("avro", "binary"), AvroFormat.Avro) };
#endif

        private PluggableFormatResolver() { }

        public static PluggableFormatResolver Instance { get { return instance; } }

        public override IEnumerable<ODataMediaTypeFormat> GetMediaTypeFormats(ODataPayloadKind payloadKind)
        {
            var payloadFormats = base.GetMediaTypeFormats(payloadKind);

            if (payloadKind == ODataPayloadKind.Property)
            {
                payloadFormats = payloadFormats.Concat(vcardFormats);
            }

#if ENABLE_AVRO
            if (payloadKind == ODataPayloadKind.Feed
                || payloadKind == ODataPayloadKind.Entry
                || payloadKind == ODataPayloadKind.Property
                || payloadKind == ODataPayloadKind.Collection
                || payloadKind == ODataPayloadKind.Parameter
                || payloadKind == ODataPayloadKind.Error)
            {
                payloadFormats = payloadFormats.Concat(avroFormats);
            }
#endif

            return payloadFormats;
        }
    }
}
