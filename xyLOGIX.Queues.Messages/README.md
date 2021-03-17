<a name='assembly'></a>
# xyLOGIX.Queues.Messages

## Contents

- [BroadcastMessage\`1](#T-xyLOGIX-Queues-Messages-BroadcastMessage`1 'xyLOGIX.Queues.Messages.BroadcastMessage`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#ctor 'xyLOGIX.Queues.Messages.BroadcastMessage`1.#ctor')
  - [Having](#P-xyLOGIX-Queues-Messages-BroadcastMessage`1-Having 'xyLOGIX.Queues.Messages.BroadcastMessage`1.Having')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-#cctor 'xyLOGIX.Queues.Messages.BroadcastMessage`1.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-BroadcastMessage`1-Args-System-Object[]- 'xyLOGIX.Queues.Messages.BroadcastMessage`1.Args(System.Object[])')
- [DelegateExtensions](#T-xyLOGIX-Queues-Messages-DelegateExtensions 'xyLOGIX.Queues.Messages.DelegateExtensions')
  - [MapToMessage\`\`1(d)](#M-xyLOGIX-Queues-Messages-DelegateExtensions-MapToMessage``1-System-Delegate- 'xyLOGIX.Queues.Messages.DelegateExtensions.MapToMessage``1(System.Delegate)')
  - [MapToMessage\`\`1(d,messageId)](#M-xyLOGIX-Queues-Messages-DelegateExtensions-MapToMessage``1-System-Delegate,System-Guid- 'xyLOGIX.Queues.Messages.DelegateExtensions.MapToMessage``1(System.Delegate,System.Guid)')
- [MakeNewMessageQueueItem](#T-xyLOGIX-Queues-Messages-MakeNewMessageQueueItem 'xyLOGIX.Queues.Messages.MakeNewMessageQueueItem')
  - [ForEventDataType(eventDataType)](#M-xyLOGIX-Queues-Messages-MakeNewMessageQueueItem-ForEventDataType-System-Type- 'xyLOGIX.Queues.Messages.MakeNewMessageQueueItem.ForEventDataType(System.Type)')
- [MessageQueue](#T-xyLOGIX-Queues-Messages-MessageQueue 'xyLOGIX.Queues.Messages.MessageQueue')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-MessageQueue-#ctor 'xyLOGIX.Queues.Messages.MessageQueue.#ctor')
  - [SyncRoot](#F-xyLOGIX-Queues-Messages-MessageQueue-SyncRoot 'xyLOGIX.Queues.Messages.MessageQueue.SyncRoot')
  - [_internalMessageQueue](#F-xyLOGIX-Queues-Messages-MessageQueue-_internalMessageQueue 'xyLOGIX.Queues.Messages.MessageQueue._internalMessageQueue')
  - [Instance](#P-xyLOGIX-Queues-Messages-MessageQueue-Instance 'xyLOGIX.Queues.Messages.MessageQueue.Instance')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-MessageQueue-#cctor 'xyLOGIX.Queues.Messages.MessageQueue.#cctor')
  - [BroadcastMessage\`\`1(args)](#M-xyLOGIX-Queues-Messages-MessageQueue-BroadcastMessage``1-System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.BroadcastMessage``1(System.Object[])')
  - [MapMessage\`\`1(messageHandler)](#M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Delegate- 'xyLOGIX.Queues.Messages.MessageQueue.MapMessage``1(System.Delegate)')
  - [MapMessage\`\`1(messageId,messageHandler)](#M-xyLOGIX-Queues-Messages-MessageQueue-MapMessage``1-System-Guid,System-Delegate- 'xyLOGIX.Queues.Messages.MessageQueue.MapMessage``1(System.Guid,System.Delegate)')
  - [PostMessage\`\`1(messageId,args)](#M-xyLOGIX-Queues-Messages-MessageQueue-PostMessage``1-System-Guid,System-Object[]- 'xyLOGIX.Queues.Messages.MessageQueue.PostMessage``1(System.Guid,System.Object[])')
  - [Remove(item)](#M-xyLOGIX-Queues-Messages-MessageQueue-Remove-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.MessageQueue.Remove(xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem)')
- [MessageQueueItemExtensions](#T-xyLOGIX-Queues-Messages-MessageQueueItemExtensions 'xyLOGIX.Queues.Messages.MessageQueueItemExtensions')
  - [DoesEventDataTypeMatch\`\`1(item)](#M-xyLOGIX-Queues-Messages-MessageQueueItemExtensions-DoesEventDataTypeMatch``1-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.MessageQueueItemExtensions.DoesEventDataTypeMatch``1(xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem)')
  - [IsBoundToMessageId\`\`1(item,messageId)](#M-xyLOGIX-Queues-Messages-MessageQueueItemExtensions-IsBoundToMessageId``1-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem,System-Guid- 'xyLOGIX.Queues.Messages.MessageQueueItemExtensions.IsBoundToMessageId``1(xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem,System.Guid)')
- [NewMessageMapping\`1](#T-xyLOGIX-Queues-Messages-NewMessageMapping`1 'xyLOGIX.Queues.Messages.NewMessageMapping`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-NewMessageMapping`1-#ctor 'xyLOGIX.Queues.Messages.NewMessageMapping`1.#ctor')
  - [_messageId](#F-xyLOGIX-Queues-Messages-NewMessageMapping`1-_messageId 'xyLOGIX.Queues.Messages.NewMessageMapping`1._messageId')
  - [Associate](#P-xyLOGIX-Queues-Messages-NewMessageMapping`1-Associate 'xyLOGIX.Queues.Messages.NewMessageMapping`1.Associate')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-NewMessageMapping`1-#cctor 'xyLOGIX.Queues.Messages.NewMessageMapping`1.#cctor')
  - [AndHandler(d)](#M-xyLOGIX-Queues-Messages-NewMessageMapping`1-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.NewMessageMapping`1.AndHandler(System.Delegate)')
  - [WithHandler(d)](#M-xyLOGIX-Queues-Messages-NewMessageMapping`1-WithHandler-System-Delegate- 'xyLOGIX.Queues.Messages.NewMessageMapping`1.WithHandler(System.Delegate)')
  - [WithMessageId(messageId)](#M-xyLOGIX-Queues-Messages-NewMessageMapping`1-WithMessageId-System-Guid- 'xyLOGIX.Queues.Messages.NewMessageMapping`1.WithMessageId(System.Guid)')
- [Resources](#T-xyLOGIX-Queues-Messages-Properties-Resources 'xyLOGIX.Queues.Messages.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Properties.Resources.ResourceManager')
- [SendMessage\`1](#T-xyLOGIX-Queues-Messages-SendMessage`1 'xyLOGIX.Queues.Messages.SendMessage`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-SendMessage`1-#ctor 'xyLOGIX.Queues.Messages.SendMessage`1.#ctor')
  - [_args](#F-xyLOGIX-Queues-Messages-SendMessage`1-_args 'xyLOGIX.Queues.Messages.SendMessage`1._args')
  - [Having](#P-xyLOGIX-Queues-Messages-SendMessage`1-Having 'xyLOGIX.Queues.Messages.SendMessage`1.Having')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-SendMessage`1-#cctor 'xyLOGIX.Queues.Messages.SendMessage`1.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-SendMessage`1-Args-System-Object[]- 'xyLOGIX.Queues.Messages.SendMessage`1.Args(System.Object[])')
  - [ForMessageId(messageId)](#M-xyLOGIX-Queues-Messages-SendMessage`1-ForMessageId-System-Guid- 'xyLOGIX.Queues.Messages.SendMessage`1.ForMessageId(System.Guid)')
  - [NoArgs()](#M-xyLOGIX-Queues-Messages-SendMessage`1-NoArgs 'xyLOGIX.Queues.Messages.SendMessage`1.NoArgs')

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

<a name='T-xyLOGIX-Queues-Messages-DelegateExtensions'></a>
## DelegateExtensions `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Provides extension methods that are designed to make assigning messages
to handlers more fluent.

<a name='M-xyLOGIX-Queues-Messages-DelegateExtensions-MapToMessage``1-System-Delegate-'></a>
### MapToMessage\`\`1(d) `method`

##### Summary

Called to map a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate'), that specifies the
code to execute in order to handle a message, with a data parameter
type, `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) Reference to the [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that is
to be matched with messages that carry objects of the
`T`
. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the object that carries the message's data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `d`, is passed a
`null` value. |

<a name='M-xyLOGIX-Queues-Messages-DelegateExtensions-MapToMessage``1-System-Delegate,System-Guid-'></a>
### MapToMessage\`\`1(d,messageId) `method`

##### Summary

Called to map a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate'), that specifies the
code to execute in order to handle a message, with a data parameter
type, `T`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | (Required.) Reference to the [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that is
to be matched with messages that carry objects of the
`T`
. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) Unique identifier (GUID) to be associated with the
message to allow subscribers to filter.



The Zero GUID may not be passed for this parameter. If it is, then
this method throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the object that carries the message's data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `messageId`, is
passed a `null` value. |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the Zero GUID is supplied for the
`messageId`
parameter.



The Zero GUID is defined as a GUID that has all its values set to zero. |

<a name='T-xyLOGIX-Queues-Messages-MakeNewMessageQueueItem'></a>
## MakeNewMessageQueueItem `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Creates new message queue item objects.

<a name='M-xyLOGIX-Queues-Messages-MakeNewMessageQueueItem-ForEventDataType-System-Type-'></a>
### ForEventDataType(eventDataType) `method`

##### Summary

Creates a new instance of a message queue item object that
implements the [IMessageQueueItem](#T-SampleMVP-IMessageQueueItem 'SampleMVP.IMessageQueueItem') interface
and associates it with the specified event data [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type').

##### Returns

Reference to an instance of an object that implements the
[IMessageQueueItem](#T-SampleMVP-IMessageQueueItem 'SampleMVP.IMessageQueueItem')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventDataType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | (Required.) Reference to an instance of [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type')
that specifies the data type of the event data object that is
associated with this event. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `eventDataType`,
is passed a `null` value. |

##### Remarks

After calling this method, callers must then invoke the
[AndHandler](#M-SampleMVP-MessageQueueItem-AndHandler 'SampleMVP.MessageQueueItem.AndHandler')
method to
associate the event data type specified with the code that is to be
executed when the message is posted to the queue.

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

Gets a reference to the one and only instance of
[MessageQueue](#T-xyLOGIX-Queues-Messages-MessageQueue 'xyLOGIX.Queues.Messages.MessageQueue').

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

<a name='M-xyLOGIX-Queues-Messages-MessageQueue-Remove-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem-'></a>
### Remove(item) `method`

##### Summary

Removes the first occurrence of the specified
`item`
from the message queue.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem') | (Required.) Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface and which represents the item to be removed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `item`, is passed
a `null` value. |

<a name='T-xyLOGIX-Queues-Messages-MessageQueueItemExtensions'></a>
## MessageQueueItemExtensions `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Provides extension methods that are designed to make working with
instances of objects implementing the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface more fluent.

<a name='M-xyLOGIX-Queues-Messages-MessageQueueItemExtensions-DoesEventDataTypeMatch``1-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem-'></a>
### DoesEventDataTypeMatch\`\`1(item) `method`

##### Summary

Determines whether the specified message queue
`item`
has a data object whose type matches that of
`T`.

##### Returns

`true` if the event data type of the provided
`item`
matches; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-SampleMVP-IMessageQueueItem 'SampleMVP.IMessageQueueItem')
interface that represents the
message queue item to be checked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that carries the message data. |

<a name='M-xyLOGIX-Queues-Messages-MessageQueueItemExtensions-IsBoundToMessageId``1-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem,System-Guid-'></a>
### IsBoundToMessageId\`\`1(item,messageId) `method`

##### Summary

Determines whether a message queue `item` has data
of type `T` and corresponds to the message ID
specified by the `messageId` parameter.

##### Returns

`true` if the message queue `item` is bound
for the message ID with the specified `messageId`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-SampleMVP-IMessageQueueItem 'SampleMVP.IMessageQueueItem')
interface that represents the
message queue item to be checked. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should receive the message. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that contains the message queue item's data. |

<a name='T-xyLOGIX-Queues-Messages-NewMessageMapping`1'></a>
## NewMessageMapping\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Fluent-builder object to build message-map entries.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type that carries the event data. |

##### Remarks

Message-map entries are what bind together a message's identifier and/or
data object type with a method that handles it; i.e, its message handler.



Message handlers are invoked automatically in response to messages being
sent or broadcast with the corresponding identifier or data type specified.

<a name='M-xyLOGIX-Queues-Messages-NewMessageMapping`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [NewMessageMapping{T}](#T-xyLOGIX-Queues-Messages-NewMessageMapping{T} 'xyLOGIX.Queues.Messages.NewMessageMapping{T}') and returns
a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-NewMessageMapping`1-_messageId'></a>
### _messageId `constants`

##### Summary

Unique identifier that identifies the specific message that gets
matched with a method that will be invoked when the message is sent.

<a name='P-xyLOGIX-Queues-Messages-NewMessageMapping`1-Associate'></a>
### Associate `property`

##### Summary

Associates a message and its handler together.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type to be composed with this object. |

<a name='M-xyLOGIX-Queues-Messages-NewMessageMapping`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-NewMessageMapping`1-AndHandler-System-Delegate-'></a>
### AndHandler(d) `method`

##### Summary

Associates a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') with the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') specifying the code to be invoked
when the message is sent. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `d`, is passed a
`null` value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a fluent-builder
style after calling the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId') method.



If the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called before this one, this method will throw
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-NewMessageMapping`1-WithHandler-System-Delegate-'></a>
### WithHandler(d) `method`

##### Summary

Associates a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') with the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') specifying the code to be invoked
when the message is sent. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `d`, is passed a
`null` value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has been called prior to calling this method. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a standalone fashion.



It is not required, nor is it even advisable, to call the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method before calling this one. If this has been done anyway, then
this method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-NewMessageMapping`1-WithMessageId-System-Guid-'></a>
### WithMessageId(messageId) `method`

##### Summary

Associates a unique identifier, `messageId`, with a
message handler.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') that contains the unique
identifier to assign to the message.



The Empty GUID is not allowed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `messageId` parameter is passed [Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty') for its value. |

##### Remarks

You must call the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method after calling this method. This method has to be called prior
to calling the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method. If this is not done, then the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method will throw a [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') exception.

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

<a name='T-xyLOGIX-Queues-Messages-SendMessage`1'></a>
## SendMessage\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages

##### Summary

Sends messages to other application components, whose event data is of
type specified.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that the message notification will carry. |

<a name='M-xyLOGIX-Queues-Messages-SendMessage`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-SendMessage`1-_args'></a>
### _args `constants`

##### Summary

Array of instances of objects that provide input to the notification.

<a name='P-xyLOGIX-Queues-Messages-SendMessage`1-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[SendMessage](#T-SampleMVP-SendMessage 'SampleMVP.SendMessage').

##### Remarks

This property is meant to be used in a fluent manner.



When using this property, first invoke the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args')
method and then
the [ForMessageId](#M-xyLOGIX-Queues-Messages-SendMessage-ForMessageId 'xyLOGIX.Queues.Messages.SendMessage.ForMessageId')
method to send your message.

<a name='M-xyLOGIX-Queues-Messages-SendMessage`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-SendMessage`1-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Supplies arguments for the message to be sent.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters to the message.



The data types, order, and number of parameters, if
supplied, must match the signature of the message's delegate. |

<a name='M-xyLOGIX-Queues-Messages-SendMessage`1-ForMessageId-System-Guid-'></a>
### ForMessageId(messageId) `method`

##### Summary

Filters the message queue by the unique identifier that the
message's handler was initially mapped under.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required). Unique identifier (GUID) that the message handler was
originally tagged with.



The Zero GUID must not be passed for this parameter.



If the Zero GUID is passed for this parameter, then this method
throws [ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

<a name='M-xyLOGIX-Queues-Messages-SendMessage`1-NoArgs'></a>
### NoArgs() `method`

##### Summary

Specifies that the message is to be sent without any input data.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method initializes the internal storage of this class that is
devoted to storing the argument list for the new message to contain
zero elements.



Calling this method is the same as calling the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args')
method without
passing any parameters. Having this method available can make client
code more fluent.
