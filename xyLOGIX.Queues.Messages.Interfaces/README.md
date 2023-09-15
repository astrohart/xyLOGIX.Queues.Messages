<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Interfaces

## Contents

- [IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue')
  - [BroadcastMessage\`\`1(args)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-BroadcastMessage``1-System-Object[]- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.BroadcastMessage``1(System.Object[])')
  - [MapMessage(messageId,messageHandler)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage-System-Guid,System-Delegate- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.MapMessage(System.Guid,System.Delegate)')
  - [MapMessage\`\`1(messageHandler)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage``1-System-Delegate- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.MapMessage``1(System.Delegate)')
  - [MapMessage\`\`1(messageId,messageHandler)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage``1-System-Guid,System-Delegate- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.MapMessage``1(System.Guid,System.Delegate)')
  - [PostMessage(messageId,args)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-PostMessage-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.PostMessage(System.Guid,System.Object[])')
  - [PostMessage\`\`1(messageId,args)](#M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-PostMessage``1-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue.PostMessage``1(System.Guid,System.Object[])')
- [Resources](#T-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources 'xyLOGIX.Queues.Messages.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue'></a>
## IMessageQueue `type`

##### Namespace

xyLOGIX.Queues.Messages.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a message queue object.

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-BroadcastMessage``1-System-Object[]-'></a>
### BroadcastMessage\`\`1(args) `method`

##### Summary

Broadcasts a message to all subscribers everywhere in the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Zero or more arguments to be provided to the message handler.



The number, order, and type of arguments provider must
match the message delegate's signature precisely. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class containing the message's data. |

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage-System-Guid,System-Delegate-'></a>
### MapMessage(messageId,messageHandler) `method`

##### Summary

Associates a unique identifier with the code to be executed when the message
is posted to the queue, with no regard for the event data type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating the specific
application object that should process the message. |
| messageHandler | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies the code to be
executed when the message is posted to the queue. |

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage``1-System-Delegate-'></a>
### MapMessage\`\`1(messageHandler) `method`

##### Summary

Associates event data with the code to be executed when the message
is posted to the queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageHandler | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies the code to be
executed when the message is posted to the queue. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of the event data. |

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-MapMessage``1-System-Guid,System-Delegate-'></a>
### MapMessage\`\`1(messageId,messageHandler) `method`

##### Summary

Associates event data with the code to be executed when the message
is posted to the queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating the specific
application object that should process the message. |
| messageHandler | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies the code to be
executed when the message is posted to the queue. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of the event data. |

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-PostMessage-System-Guid,System-Object[]-'></a>
### PostMessage(messageId,args) `method`

##### Summary

Posts a message to the message queue and aims it at the specific
message ID indicated by the `messageId`. Only the
objects who originally mapped handlers to the message with the
specified message ID will be sent the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should receive the message. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Zero or more arguments to be provided to the message handler.



The number, order, and type of arguments provided must
match the message delegate's signature precisely. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the Zero GUID is passed for the
`messageId`
parameter. |

<a name='M-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue-PostMessage``1-System-Guid,System-Object[]-'></a>
### PostMessage\`\`1(messageId,args) `method`

##### Summary

Posts a message to the message queue and aims it at the specific
message ID indicated by the `messageId`. Only the
objects who mapped handlers to the message with the specified
message ID will be sent the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should receive the message. |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Zero or more arguments to be provided to the message handler.



The number, order, and type of arguments provider must
match the message delegate's signature precisely. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that will be passed to the message handler. |

<a name='T-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
