<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Items.Factories

## Contents

- [MakeNewMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Factories.MakeNewMessageQueueItem')
  - [ForEventDataType(eventDataType)](#M-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem-ForEventDataType-System-Type- 'xyLOGIX.Queues.Messages.Items.Factories.MakeNewMessageQueueItem.ForEventDataType(System.Type)')
  - [FromScratch()](#M-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem-FromScratch 'xyLOGIX.Queues.Messages.Items.Factories.MakeNewMessageQueueItem.FromScratch')
- [Resources](#T-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources 'xyLOGIX.Queues.Messages.Items.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Items.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Items.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem'></a>
## MakeNewMessageQueueItem `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Factories

##### Summary

Creates new message queue item objects.

<a name='M-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem-ForEventDataType-System-Type-'></a>
### ForEventDataType(eventDataType) `method`

##### Summary

Creates a new instance of a message queue item object that implements
the [IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface and associates it with the specified event data
[Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type').

##### Returns

Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem')
interface.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| eventDataType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | (Required.) Reference to an instance of
[Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') that specifies the data type of the event data
object that is associated with this event. |

##### Remarks

After calling this method, callers must then invoke the
[AndHandler](#M-SampleMVP-MessageQueueItem-AndHandler 'SampleMVP.MessageQueueItem.AndHandler') method to associate the
event data type specified with the code that is to be executed when the message
is posted to the queue.

<a name='M-xyLOGIX-Queues-Messages-Items-Factories-MakeNewMessageQueueItem-FromScratch'></a>
### FromScratch() `method`

##### Summary

Creates a new instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem') interface
and which is totally uninitialized.

##### Returns

Reference to an instance of an object that implements the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Items.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Items-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
