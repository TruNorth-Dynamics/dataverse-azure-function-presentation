#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataverseAzureFunctionsCommon.Dataverse.Model
{
	
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum RjB_TypeOfAzureFunction
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("HttpTriggered", 0)]
		Httptriggered = 911620000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("ServiceBus Queue", 1)]
		ServicebusQueue = 911620001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Service Bus Topic", 2)]
		ServiceBusTopic = 911620003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("TwoWay Http", 4)]
		TwowayHttp = 911620004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("TwoWay ServiceBus", 3)]
		TwowayServicebus = 911620002,
	}
}
#pragma warning restore CS1591
