<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Comparers

## Contents

- [MessageQueueItemWithDataTypeComparer](#T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-#ctor 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer.#ctor')
  - [Instance](#P-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-Instance 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer.Instance')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-#cctor 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer.#cctor')
  - [Equals(x,y)](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-Equals-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer.Equals(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem,xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
  - [GetHashCode(obj)](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-GetHashCode-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithDataTypeComparer.GetHashCode(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
- [MessageQueueItemWithNoDataTypeComparer](#T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-#ctor 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer.#ctor')
  - [Instance](#P-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-Instance 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer.Instance')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-#cctor 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer.#cctor')
  - [Equals(x,y)](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-Equals-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer.Equals(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem,xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
  - [GetHashCode(obj)](#M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-GetHashCode-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem- 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer.GetHashCode(xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem)')
- [Resources](#T-xyLOGIX-Queues-Messages-Comparers-Properties-Resources 'xyLOGIX.Queues.Messages.Comparers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Comparers-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Comparers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Comparers-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Comparers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer'></a>
## MessageQueueItemWithDataTypeComparer `type`

##### Namespace

xyLOGIX.Queues.Messages.Comparers

##### Summary

Compares two instances of objects that implement the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface to see if they are equal.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MessageQueueItemWithNoDataTypeComparer](#T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer')
.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-Equals-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### Equals(x,y) `method`

##### Summary

Determines whether the specified objects are equal.

##### Returns

`true` if the specified objects are equal;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The first object that implements the [typeparamref](#T-typeparamref 'typeparamref')
interface to compare. |
| y | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The second object that implements the [typeparamref](#T-typeparamref 'typeparamref')
interface to compare. |

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithDataTypeComparer-GetHashCode-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### GetHashCode(obj) `method`

##### Summary

Returns a hash code for the specified object.

##### Returns

A hash code for the specified object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') for which a hash code is to be returned. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | The type of `obj` is a reference type and
`obj`
is `null`. |

<a name='T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer'></a>
## MessageQueueItemWithNoDataTypeComparer `type`

##### Namespace

xyLOGIX.Queues.Messages.Comparers

##### Summary

Compares two instances of objects that implement the
[IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueueItem')
interface to see if they are equal. Ignores the event data type
associated with the item.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[MessageQueueItemWithNoDataTypeComparer](#T-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer 'xyLOGIX.Queues.Messages.Comparers.MessageQueueItemWithNoDataTypeComparer')
.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-Equals-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem,xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### Equals(x,y) `method`

##### Summary

Determines whether the specified objects are equal.

##### Returns

`true` if the specified objects are equal;
otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The first object that implements the [typeparamref](#T-typeparamref 'typeparamref')
interface to compare. |
| y | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The second object that implements the [typeparamref](#T-typeparamref 'typeparamref')
interface to compare. |

<a name='M-xyLOGIX-Queues-Messages-Comparers-MessageQueueItemWithNoDataTypeComparer-GetHashCode-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem-'></a>
### GetHashCode(obj) `method`

##### Summary

Returns a hash code for the specified object.

##### Returns

A hash code for the specified object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem](#T-xyLOGIX-Queues-Messages-Items-Interfaces-IMessageQueueItem 'xyLOGIX.Queues.Messages.Items.Interfaces.IMessageQueueItem') | The [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') for which a hash code is to be returned. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | The type of `obj` is a reference type and
`obj`
is `null`. |

<a name='T-xyLOGIX-Queues-Messages-Comparers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Comparers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Comparers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Comparers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
