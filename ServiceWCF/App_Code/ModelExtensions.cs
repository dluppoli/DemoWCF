using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


[MetadataType(typeof(AthletesMetadata))]
public partial class Athlete
{

}

[DataContract]
public class AthletesMetadata
{
    [DataMember]
    public int IdAthlete { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public string Sex { get; set; }
    [DataMember]
    public Nullable<short> Height { get; set; }
    [DataMember]
    public Nullable<short> Weight { get; set; }
}
