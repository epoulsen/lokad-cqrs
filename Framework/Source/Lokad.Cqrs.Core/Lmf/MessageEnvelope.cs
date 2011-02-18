#region (c) 2010 Lokad Open Source - New BSD License 

// Copyright (c) Lokad 2010, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

using System;

namespace Lokad.Cqrs
{
	/// <summary>
	/// Deserialized message representation
	/// </summary>
	public class MessageEnvelope
	{
		/// <summary>
		/// Type of the contract behind the message
		/// </summary>
		public readonly Type ContractType;
		
		/// <summary>
		/// Available message attributes
		/// </summary>
		public readonly MessageAttributesContract Attributes;
		/// <summary>
		/// Message content
		/// </summary>
		public readonly object Content;

		public MessageEnvelope(MessageAttributesContract attributes, object content, Type contractType)
		{
		
			ContractType = contractType;
			Attributes = attributes;
			Content = content;
		}
	}

	

	//public sealed class MessageEnvelope
	//{
	//    public readonly string EnvelopeId;
	//    public readonly MessageItem[] Messages;
	//    public readonly IDictionary<string, object> Attributes = new Dictionary<string, object>();

	
	//}

	//public sealed class MessageItem
	//{
	//    public readonly string MessageId;
	//    public readonly string Contract;
	//    public readonly Type MappedType;
	//    public readonly object Content;
	//    public readonly IDictionary<string, object> Attributes = new Dictionary<string, object>();
	//}
}