<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Broadcasters

## Contents

- [BroadcastMessage\`1](#T-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-#ctor 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1.#ctor')
  - [Having](#P-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-Having 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1.Having')
  - [MessageQueue](#P-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-MessageQueue 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1.MessageQueue')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-#cctor 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-Args-System-Object[]- 'xyLOGIX.Queues.Messages.Broadcasters.BroadcastMessage`1.Args(System.Object[])')
- [Resources](#T-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources 'xyLOGIX.Queues.Messages.Broadcasters.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Broadcasters.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Broadcasters.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1'></a>
## BroadcastMessage\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages.Broadcasters

##### Summary

Broadcasts messages, with event data of type
`T`, to all interested parties throughout the
application.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type of the `class` or `struct`
that carries the event data. |

##### Remarks

This class is implemented as a singleton.



This class was designed to be very fluent, in that clients of this class use
the dot operator to string together its methods and properties to form complete
sentences.



Use this class when you want to invoke all message handlers that say they work
with message data having type `T`, and that do not
respond to messages tagged with a unique identifier.

<a name='M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[BroadcastMessage](#T-SampleMVP-BroadcastMessage 'SampleMVP.BroadcastMessage').

<a name='P-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-MessageQueue'></a>
### MessageQueue `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Broadcasters-BroadcastMessage`1-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Passes a message to the message queue to be sent to all subscribed
parties throughout the application, with the `args` provided.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters
to the message.



The data types, order, and number of parameters, if supplied, must
match the signature of the message's delegate. |

<a name='T-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Broadcasters.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Broadcasters-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
