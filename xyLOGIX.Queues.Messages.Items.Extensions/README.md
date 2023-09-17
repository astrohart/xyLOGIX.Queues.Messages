<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Items.Extensions

## Contents

- [MessageQueueItemExtensions](#T-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions 'xyLOGIX.Queues.Messages.Items.Extensions.MessageQueueItemExtensions')
  - [DoesEventDataTypeMatch\`\`1(item)](#M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-DoesEventDataTypeMatch``1-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.Items.Extensions.MessageQueueItemExtensions.DoesEventDataTypeMatch``1(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
  - [IsBoundToMessageId(item,messageId)](#M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid- 'xyLOGIX.Queues.Messages.Items.Extensions.MessageQueueItemExtensions.IsBoundToMessageId(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem,System.Guid)')
  - [IsBoundToMessageId\`\`1(item,messageId)](#M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId``1-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid- 'xyLOGIX.Queues.Messages.Items.Extensions.MessageQueueItemExtensions.IsBoundToMessageId``1(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem,System.Guid)')
  - [IsBoundToMessageId\`\`2(item,messageId)](#M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId``2-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid- 'xyLOGIX.Queues.Messages.Items.Extensions.MessageQueueItemExtensions.IsBoundToMessageId``2(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem,System.Guid)')
- [Resources](#T-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources 'xyLOGIX.Queues.Messages.Items.Extensions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Items.Extensions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Items.Extensions.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions'></a>
## MessageQueueItemExtensions `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Extensions

##### Summary

Provides extension methods that are designed to make working with
instances of objects implementing the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem') interface
more fluent.

<a name='M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-DoesEventDataTypeMatch``1-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### DoesEventDataTypeMatch\`\`1(item) `method`

##### Summary

Determines whether the specified message queue
`item`has a data object whose type matches that of
`T`.

##### Returns

`true` if the event data type of the provided
`item` matches; `false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface that represents the message queue item to be checked. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that carries the message data. |

<a name='M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid-'></a>
### IsBoundToMessageId(item,messageId) `method`

##### Summary

Determines whether a message queue `item`
corresponds to the message ID specified by the `messageId`
parameter.

##### Returns

`true` if the message queue `item`
is bound for the message ID with the specified `messageId`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface that represents the message queue item to be checked. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should
receive the message. |

<a name='M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId``1-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid-'></a>
### IsBoundToMessageId\`\`1(item,messageId) `method`

##### Summary

Determines whether a message queue `item` has data
of type `T` and corresponds to the message ID specified
by the `messageId` parameter.

##### Returns

`true` if the message queue `item`
is bound for the message ID with the specified `messageId`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface that represents the message queue item to be checked. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should
receive the message. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that contains the message queue item's
data. |

<a name='M-xyLOGIX-Queues-Messages-Items-Extensions-MessageQueueItemExtensions-IsBoundToMessageId``2-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,System-Guid-'></a>
### IsBoundToMessageId\`\`2(item,messageId) `method`

##### Summary

Determines whether a message queue `item` has data
of type `T` and corresponds to the message ID specified
by the `messageId` parameter.

##### Returns

`true` if the message queue `item`
is bound for the message ID with the specified `messageId`;
`false` otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| item | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface that represents the message queue item to be checked. |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating who should
receive the message. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the class that contains the message queue item's
data. |
| R | Name of the class that contains the message queue item's
result. |

<a name='T-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Extensions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Items-Extensions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
