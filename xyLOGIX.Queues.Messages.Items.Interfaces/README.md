<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Items.Interfaces

## Contents

- [IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
  - [EventDataType](#P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-EventDataType 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.EventDataType')
  - [MessageHandler](#P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-MessageHandler 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.MessageHandler')
  - [MessageId](#P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-MessageId 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.MessageId')
  - [ResultDataType](#P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-ResultDataType 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.ResultDataType')
  - [AndHandler()](#M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.AndHandler(System.Delegate)')
  - [HavingMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-HavingMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.HavingMessageId(System.Guid)')
  - [WithDisposalAction()](#M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-WithDisposalAction-System-Action{xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem}- 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem.WithDisposalAction(System.Action{xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem})')
- [Resources](#T-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources 'xyLOGIX.Queues.Messages.Items.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Items.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Items.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem'></a>
## IMessageQueueItem `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Interfaces

##### Summary

Defines the publicly-exposed methods and properties of a message
queue item object.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-EventDataType'></a>
### EventDataType `property`

##### Summary

Gets or sets the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the event data.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-MessageHandler'></a>
### MessageHandler `property`

##### Summary

Gets or sets a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies what
code is to be run when a message is sent.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets the unique identifier of the message ID of this specific
message queue item.

##### Remarks

If this property is set to the zero GUID, then the message is
broadcast.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-ResultDataType'></a>
### ResultDataType `property`

##### Summary

Gets or sets the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the result.

<a name='M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-AndHandler-System-Delegate-'></a>
### AndHandler() `method`

##### Summary

Fluent-builder method to associate this message queue item with code
to be executed when the message is published.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
parameter, `messageHandler`, is passed a
`null` value. |

<a name='M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-HavingMessageId-System-Guid-'></a>
### HavingMessageId(messageId) `method`

##### Summary

Fluent-builder method to associate mark this message queue item for
processing only by a specific message ID.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') indicating
who should process this message. |

##### Remarks

Calling this method is optional. The Zero GUID will be associated
with this message queue item if this method is not called.



Associating a message with the Zero GUID means that the message in question
should be dispatched to all interested parties.

<a name='M-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-WithDisposalAction-System-Action{xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem}-'></a>
### WithDisposalAction() `method`

##### Summary

Fluent-builder method that enables us to attach an
[IMessageQueueItem}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem}')
to this object that is called when this object's resources are freed from
memory by the garbage collector.



The most common implementation is to remove the newly-built
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
-implementing object from the internal list maintained by the message queue
object.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Items-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
