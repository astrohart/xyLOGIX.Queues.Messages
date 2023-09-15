<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Items

## Contents

- [MessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-MessageQueueItem 'xyLOGIX.Queues.Messages.Items.MessageQueueItem')
  - [_removalAction](#F-xyLOGIX-Queues-Messages-Items-MessageQueueItem-_removalAction 'xyLOGIX.Queues.Messages.Items.MessageQueueItem._removalAction')
  - [EventDataType](#P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-EventDataType 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.EventDataType')
  - [MessageHandler](#P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-MessageHandler 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.MessageHandler')
  - [MessageId](#P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-MessageId 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.MessageId')
  - [ResultDataType](#P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-ResultDataType 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.ResultDataType')
  - [AndHandler()](#M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.AndHandler(System.Delegate)')
  - [Dispose()](#M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-Dispose 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.Dispose')
  - [HavingMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-HavingMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.HavingMessageId(System.Guid)')
  - [ToString()](#M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-ToString 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.ToString')
  - [WithDisposalAction()](#M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-WithDisposalAction-System-Action{xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem}- 'xyLOGIX.Queues.Messages.Items.MessageQueueItem.WithDisposalAction(System.Action{xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem})')
- [Resources](#T-xyLOGIX-Queues-Messages-Items-Properties-Resources 'xyLOGIX.Queues.Messages.Items.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Items-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Items.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Items-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Items.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Items-MessageQueueItem'></a>
## MessageQueueItem `type`

##### Namespace

xyLOGIX.Queues.Messages.Items

##### Summary

Represents a single item in a
[MessageQueue](#T-xyLOGIX-Queues-Messages-MessageQueue 'xyLOGIX.Queues.Messages.MessageQueue').

<a name='F-xyLOGIX-Queues-Messages-Items-MessageQueueItem-_removalAction'></a>
### _removalAction `constants`

##### Summary

An [Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') that specifies how to remove this
`MessageQueueItem` from the `MessageQueue`.

<a name='P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-EventDataType'></a>
### EventDataType `property`

##### Summary

Gets or sets the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the event data.

<a name='P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-MessageHandler'></a>
### MessageHandler `property`

##### Summary

Gets or sets a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') that specifies what
code is to be run when a message is sent.

<a name='P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-MessageId'></a>
### MessageId `property`

##### Summary

Gets or sets the unique identifier of the message ID of this
specific `MessageQueueItem`.

##### Remarks

If this property is set to the zero GUID, then the message is broadcast.

<a name='P-xyLOGIX-Queues-Messages-Items-MessageQueueItem-ResultDataType'></a>
### ResultDataType `property`

##### Summary

Gets or sets the [Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') of the result.

<a name='M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-AndHandler-System-Delegate-'></a>
### AndHandler() `method`

##### Summary

Fluent-builder method to associate this `MessageQueueItem` with
code to be executed when the message is published.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `messageHandler`,
is passed a `null` value. |

<a name='M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing,
releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-HavingMessageId-System-Guid-'></a>
### HavingMessageId(messageId) `method`

##### Summary

Fluent-builder method to mark this `MessageQueueItem` for
processing only by those objects who map handlers to a specific
message ID.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required.) A [Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') tagging this message with
a unique identifier. |

##### Remarks

Calling this method is optional. The Zero GUID will be associated
with this `MessageQueueItem` if this method is not called.



Associating a message with the Zero GUID means that the message in
question should be dispatched to all interested parties.

<a name='M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-ToString'></a>
### ToString() `method`

##### Summary

Returns a string that represents the current object.

##### Returns

A string that represents the current object.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Items-MessageQueueItem-WithDisposalAction-System-Action{xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem}-'></a>
### WithDisposalAction() `method`

##### Summary

Fluent-builder method that enables us to attach a
[IMessageQueueItem}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem}')
to this object that is called when this object's resources are freed
from memory by the garbage collector.



The most common implementation is to remove the newly-built
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
-implementing object from the internal list maintained by the
`MessageQueue` object.

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Queues-Messages-Items-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Items-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Items-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
