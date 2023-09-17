<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Comparers.Factories

## Contents

- [GetMessageQueueItemEquialityComparer](#T-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-#ctor 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer.#ctor')
  - [That](#P-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-That 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer.That')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-#cctor 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer.#cctor')
  - [DoesNotTakeEventDataTypeIntoAccount()](#M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-DoesNotTakeEventDataTypeIntoAccount 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer.DoesNotTakeEventDataTypeIntoAccount')
  - [TakesEventDataTypeIntoAccount()](#M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-TakesEventDataTypeIntoAccount 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer.TakesEventDataTypeIntoAccount')
- [Resources](#T-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources 'xyLOGIX.Queues.Messages.Comparers.Factories.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Comparers.Factories.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Comparers.Factories.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer'></a>
## GetMessageQueueItemEquialityComparer `type`

##### Namespace

xyLOGIX.Queues.Messages.Comparers.Factories

##### Summary

Gets references to instances of objects that implement the
[IEqualityComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer') interface for
pairs of objects that implement the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface.

<a name='M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-That'></a>
### That `property`

##### Summary

Gets a reference to the one and only instance of
[GetMessageQueueItemEquialityComparer](#T-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer 'xyLOGIX.Queues.Messages.Comparers.Factories.GetMessageQueueItemEquialityComparer')
.

<a name='M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-DoesNotTakeEventDataTypeIntoAccount'></a>
### DoesNotTakeEventDataTypeIntoAccount() `method`

##### Summary

Gets a reference to the equality comparer that does not take the
event data type into account.

##### Returns

Reference to an instance of an object that implements the
[IEqualityComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer') interface for
objects implementing the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Comparers-Factories-GetMessageQueueItemEquialityComparer-TakesEventDataTypeIntoAccount'></a>
### TakesEventDataTypeIntoAccount() `method`

##### Summary

Gets a reference to the equality comparer that takes the event data
type into account.

##### Returns

Reference to an instance of an object that implements the
[IEqualityComparer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEqualityComparer 'System.Collections.Generic.IEqualityComparer') interface for
objects implementing the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Comparers.Factories.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Comparers-Factories-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
