﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using net.openstack.Core.Domain;

namespace net.openstack.Providers.Rackspace.Objects.Request
{
    [DataContract]
    internal class UpdateMetadataRequest
    {
        [DataMember(Name = "metadata")]
        public Metadata Metadata { get; set; }
    }
}
