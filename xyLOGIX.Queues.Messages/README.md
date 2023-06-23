<a name='assembly'></a>
# xyLOGIX.Queues.Messages

## Contents

- [BroadcastMessage\`1](#T-xyLOGIX-Queues-Messages-BroadcastMessage`1 'xyLOGIX.Queues.Messages.BroadcastMessage`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#ctor 'xyLOGIX.Queues.Messages.BroadcastMessage`1.#ctor')
  - [Having](#P-xyLOGIX-Queues-Messages-BroadcastMessage`1-Having 'xyLOGIX.Queues.Messages.BroadcastMessage`1.Having')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#cctor 'xyLOGIX.Queues.Messages.BroadcastMessage`1.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-Args-System-Object[]- 'xyLOGIX.Queues.Messages.BroadcastMessage`1.Args(System.Object[])')
- [MessageQueue](#T-xyLOGIX-Queues-Messages-MessageQueue 'xyLOGIX.Queues.Messages.MessageQueue')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-MessageQueue-#ctor 'xyLOGIX.Queues.Messages.MessageQueue.#ctor')
  - [SyncRoot](#F-xyLOGIX-Queues-Messages-MessageQueue-SyncRoot 'xyLOGIX.Queues.Messages.MessageQueue.SyncRoot')
  - [_internalMessageQueue](#F-xyLOGIX-Queues-Messages-MessageQueue-_internalMessageQueue 'xyLOGIX.Queues.Messages.MessageQueue._internalMessageQueue')
  - [Instance](#P-xyLOGIX-Queues-Messages-MessageQueue-Instance 'xyLOGIX.Queues.Messages.MessageQueue.Instance')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-MessageQueue-#cctor 'xyLOGIX.Queues.Messages.MessageQueue.#cctor')
  - [BroadcastMessage\`\`1(args)](#M-xyLOGIX-Queues-Messages-MessageQueue-BroadcastMessage``1-System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.BroadcastMessage``1(System.Object[])')
  - [MapMessage(messageId,messageHandler)](#M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage-System-Guid,System-Delegate- 'xyLOGIX.Queues.Messages.MessageQueue.MapMessage(System.Guid,System.Delegate)')
  - [MapMessage\`\`1(messageHandler)](#M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Delegate- 'xyLOGIX.Queues.Messages.MessageQueue.MapMessage``1(System.Delegate)')
  - [MapMessage\`\`1(messageId,messageHandler)](#M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Guid,System-Delegate- 'xyLOGIX.Queues.Messages.MessageQueue.MapMessage``1(System.Guid,System.Delegate)')
  - [PostMessage(messageId,args)](#M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.PostMessage(System.Guid,System.Object[])')
  - [PostMessage\`\`1(messageId,args)](#M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage``1-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.PostMessage``1(System.Guid,System.Object[])')
  - [PostMessage\`\`2(messageId,args)](#M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage``2-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.PostMessage``2(System.Guid,System.Object[])')
  - [Remove(item)](#M-xyLOGIX-Queues-Messages-MessageQueue-Remove-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.MessageQueue.Remove(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
- [Resources](#T-xyLOGIX-Queues-Messages-Properties-Resources 'xyLOGIX.Queues.Messages.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-BroadcastMessage`1'></a>
## BroadcastMessage\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Broadcasts messages, with event data of type `T`,
to all interested parties throughout the application.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the `class` or `struct` that carries
the event data. |

##### Remarks

This class is implemented as a singleton.



This class was designed to be very fluent, in that clients of this class
use the dot operator to string together its methods and properties to
form complete sentences.



Use this class when you want to invoke all message handlers that say
they work with message data having type `T`, and
that do not respond to messages tagged with a unique identifier.

<a name='M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Queues-Messages-BroadcastMessage`1-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[BroadcastMessage](#T-SampleMVP-BroadcastMessage 'SampleMVP.BroadcastMessage').

<a name='M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-BroadcastMessage`1-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Passes a message to the message queue to be sent to all subscribed
parties throughout the application, with the `args` provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters to the message.



The data types, order, and number of parameters, if
supplied, must match the signature of the message's delegate. |

<a name='T-xyLOGIX-Queues-Messages-MessageQueue'></a>
## MessageQueue `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Centralized storehouse for application messages.

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-MessageQueue-SyncRoot'></a>
### SyncRoot `constants`

##### Summary

Synchronization context object.

<a name='F-xyLOGIX-Queues-Messages-MessageQueue-_internalMessageQueue'></a>
### _internalMessageQueue `constants`

##### Summary

Internal message queue.

<a name='P-xyLOGIX-Queues-Messages-MessageQueue-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of the object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-BroadcastMessage``1-System-Object[]-'></a>
### BroadcastMessage\`\`1(args) `method`

##### Summary

Broadcasts a message to all subscribers everywhere in the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | Zero or more arguments to be provided to the message handler.



The number, order, and type of arguments provided must
match the message delegate's signature precisely. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class containing the message's data. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage-System-Guid,System-Delegate-'></a>
### MapMessage(messageId,messageHandler) `method`

##### Summary

Associates a unique identifier with the code to be executed when the
message is posted to the queue, with no regard for the event data type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating the specific
application object that should process the message. |
| messageHandler | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies the code to be
executed when the message is posted to the queue. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Delegate-'></a>
### MapMessage\`\`1(messageHandler) `method`

##### Summary

Associates event data with the message handler, i.e., the method
that contains the code to be executed when the message is posted to
the queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageHandler | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies the code to be
executed when the message is posted to the queue. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of the event data. |

##### Remarks

A message that is mapped to a handler using this method will be
broadcast, i.e., any component of the application that registers a
handler will automatically have its handler invoked.

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Guid,System-Delegate-'></a>
### MapMessage\`\`1(messageId,messageHandler) `method`

##### Summary

Associates event data with the message handler, i.e., the method
that contains the code to be executed when the message is posted to
the queue.

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

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the Zero GUID is passed for the
`messageId`
parameter. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `messageHandler`,
is passed a `null` value. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage-System-Guid,System-Object[]-'></a>
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

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage``1-System-Guid,System-Object[]-'></a>
### PostMessage\`\`1(messageId,args) `method`

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

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that will be passed to the message handler. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage``2-System-Guid,System-Object[]-'></a>
### PostMessage\`\`2(messageId,args) `method`

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

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that will be passed to the message handler. |
| R | Name of the type of data that will be returned from the message handler as its
result. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-Remove-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### Remove(item) `method`

##### Summary

Removes the first occurrence of the specified
`item`
from the message queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | (Required.) Reference to an instance of an object that implements
the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface and which represents the item to be removed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `item`, is passed
a `null` value. |

<a name='T-xyLOGIX-Queues-Messages-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
