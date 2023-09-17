<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Extensions

## Contents

- [DelegateExtensions](#T-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions 'xyLOGIX.Queues.Messages.Extensions.DelegateExtensions')
  - [MessageQueue](#P-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MessageQueue 'xyLOGIX.Queues.Messages.Extensions.DelegateExtensions.MessageQueue')
  - [MapToMessage(d,messageId)](#M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage-System-Delegate,System-Guid- 'xyLOGIX.Queues.Messages.Extensions.DelegateExtensions.MapToMessage(System.Delegate,System.Guid)')
  - [MapToMessage\`\`1(d)](#M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage``1-System-Delegate- 'xyLOGIX.Queues.Messages.Extensions.DelegateExtensions.MapToMessage``1(System.Delegate)')
  - [MapToMessage\`\`1(d,messageId)](#M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage``1-System-Delegate,System-Guid- 'xyLOGIX.Queues.Messages.Extensions.DelegateExtensions.MapToMessage``1(System.Delegate,System.Guid)')
- [Resources](#T-xyLOGIX-Queues-Messages-Extensions-Properties-Resources 'xyLOGIX.Queues.Messages.Extensions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Extensions-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Extensions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Extensions-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Extensions.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions'></a>
## DelegateExtensions `type`

##### Namespace

xyLOGIX.Queues.Messages.Extensions

##### Summary

Provides extension methods that are designed to make assigning
messages to handlers more fluent.

<a name='P-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MessageQueue'></a>
### MessageQueue `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage-System-Delegate,System-Guid-'></a>
### MapToMessage(d,messageId) `method`

##### Summary

Called to map a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate'), that specifies the
code to execute in order to handle a message, with a unique identifier,
`messageId`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) Reference to the [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate')
that is to be matched with messages that have ID of
`messageId`. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Unique identifier (GUID) to be associated
with the message to allow subscribers to filter.



The Zero GUID may not be passed for this parameter. If it is, then this method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `messageId`, is passed a `null`
value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the Zero GUID is
supplied for the `messageId` parameter.



The Zero GUID is defined as a GUID that has all its values set to zero. |

<a name='M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage``1-System-Delegate-'></a>
### MapToMessage\`\`1(d) `method`

##### Summary

Called to map a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate'), that specifies the
code to execute in order to handle a message, with a data parameter type,
`T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) Reference to the [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate')
that is to be matched with messages that carry objects of the
`T` . |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the object that carries the
message's data. |

<a name='M-xyLOGIX-Queues-Messages-Extensions-DelegateExtensions-MapToMessage``1-System-Delegate,System-Guid-'></a>
### MapToMessage\`\`1(d,messageId) `method`

##### Summary

Called to map a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate'), that specifies the
code to execute in order to handle a message, with a data parameter type,
`T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) Reference to the [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate')
that is to be matched with messages that carry objects of the
`T` . |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Unique identifier (GUID) to be associated
with the message to allow subscribers to filter.



The Zero GUID may not be passed for this parameter. If it is, then this method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the object that carries the
message's data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `messageId`, is passed a `null`
value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the Zero GUID is
supplied for the `messageId` parameter.



The Zero GUID is defined as a GUID that has all its values set to zero. |

<a name='T-xyLOGIX-Queues-Messages-Extensions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Extensions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Extensions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Extensions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
