<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Senders

## Contents

- [Resources](#T-xyLOGIX-Queues-Messages-Senders-Properties-Resources 'xyLOGIX.Queues.Messages.Senders.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Senders-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Senders.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Senders-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Senders.Properties.Resources.ResourceManager')
- [SendMessage](#T-xyLOGIX-Queues-Messages-Senders-SendMessage 'xyLOGIX.Queues.Messages.Senders.SendMessage')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage-#ctor 'xyLOGIX.Queues.Messages.Senders.SendMessage.#ctor')
  - [_args](#F-xyLOGIX-Queues-Messages-Senders-SendMessage-_args 'xyLOGIX.Queues.Messages.Senders.SendMessage._args')
  - [Having](#P-xyLOGIX-Queues-Messages-Senders-SendMessage-Having 'xyLOGIX.Queues.Messages.Senders.SendMessage.Having')
  - [MessageQueue](#P-xyLOGIX-Queues-Messages-Senders-SendMessage-MessageQueue 'xyLOGIX.Queues.Messages.Senders.SendMessage.MessageQueue')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage-#cctor 'xyLOGIX.Queues.Messages.Senders.SendMessage.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage-Args-System-Object[]- 'xyLOGIX.Queues.Messages.Senders.SendMessage.Args(System.Object[])')
  - [ForMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage-ForMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Senders.SendMessage.ForMessageId(System.Guid)')
  - [NoArgs()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage-NoArgs 'xyLOGIX.Queues.Messages.Senders.SendMessage.NoArgs')
- [SendMessage\`1](#T-xyLOGIX-Queues-Messages-Senders-SendMessage`1 'xyLOGIX.Queues.Messages.Senders.SendMessage`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-#ctor 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.#ctor')
  - [_args](#F-xyLOGIX-Queues-Messages-Senders-SendMessage`1-_args 'xyLOGIX.Queues.Messages.Senders.SendMessage`1._args')
  - [Having](#P-xyLOGIX-Queues-Messages-Senders-SendMessage`1-Having 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.Having')
  - [MessageQueue](#P-xyLOGIX-Queues-Messages-Senders-SendMessage`1-MessageQueue 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.MessageQueue')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-#cctor 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-Args-System-Object[]- 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.Args(System.Object[])')
  - [ForMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-ForMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.ForMessageId(System.Guid)')
  - [NoArgs()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-NoArgs 'xyLOGIX.Queues.Messages.Senders.SendMessage`1.NoArgs')
- [SendMessage\`2](#T-xyLOGIX-Queues-Messages-Senders-SendMessage`2 'xyLOGIX.Queues.Messages.Senders.SendMessage`2')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-#ctor 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.#ctor')
  - [_args](#F-xyLOGIX-Queues-Messages-Senders-SendMessage`2-_args 'xyLOGIX.Queues.Messages.Senders.SendMessage`2._args')
  - [Having](#P-xyLOGIX-Queues-Messages-Senders-SendMessage`2-Having 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.Having')
  - [MessageQueue](#P-xyLOGIX-Queues-Messages-Senders-SendMessage`2-MessageQueue 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.MessageQueue')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-#cctor 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.#cctor')
  - [Args(args)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-Args-System-Object[]- 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.Args(System.Object[])')
  - [ForMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-ForMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.ForMessageId(System.Guid)')
  - [NoArgs()](#M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-NoArgs 'xyLOGIX.Queues.Messages.Senders.SendMessage`2.NoArgs')

<a name='T-xyLOGIX-Queues-Messages-Senders-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Senders.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Senders-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Senders-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Queues-Messages-Senders-SendMessage'></a>
## SendMessage `type`

##### Namespace

xyLOGIX.Queues.Messages.Senders

##### Summary

Sends messages to other application components, whose event data is
of type specified.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Senders-SendMessage-_args'></a>
### _args `constants`

##### Summary

Array of instances of objects that provide input to the notification.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[SendMessage](#T-SampleMVP-SendMessage 'SampleMVP.SendMessage').

##### Remarks

This property is meant to be used in a fluent manner.



When using this property, first invoke the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method and then the
[ForMessageId](#M-xyLOGIX-Queues-Messages-SendMessage-ForMessageId 'xyLOGIX.Queues.Messages.SendMessage.ForMessageId') method to
send your message.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage-MessageQueue'></a>
### MessageQueue `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Supplies arguments for the message to be sent.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters
to the message.



The data types, order, and number of parameters, if supplied, must
match the signature of the message's delegate. |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage-ForMessageId-System-Guid-'></a>
### ForMessageId(messageId) `method`

##### Summary

Filters the message queue by the unique identifier that the message's
handler was initially mapped under.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required). Unique identifier (GUID) that the message
handler was originally tagged with.



The Zero GUID must not be passed for this parameter.



If the Zero GUID is passed for this parameter, then this method throws
[ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage-NoArgs'></a>
### NoArgs() `method`

##### Summary

Specifies that the message is to be sent without any input data.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method initializes the internal storage of this class that is
devoted to storing the argument list for the new message to contain zero
elements.



Calling this method is the same as calling the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method without
passing any parameters. Having this method available can make client code more
fluent.

<a name='T-xyLOGIX-Queues-Messages-Senders-SendMessage`1'></a>
## SendMessage\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages.Senders

##### Summary

Sends messages to other application components, whose event data is
of type specified.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that the message notification
will carry. |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Senders-SendMessage`1-_args'></a>
### _args `constants`

##### Summary

Array of instances of objects that provide input to the notification.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage`1-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[SendMessage](#T-SampleMVP-SendMessage 'SampleMVP.SendMessage').

##### Remarks

This property is meant to be used in a fluent manner.



When using this property, first invoke the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method and then the
[ForMessageId](#M-xyLOGIX-Queues-Messages-SendMessage-ForMessageId 'xyLOGIX.Queues.Messages.SendMessage.ForMessageId') method to
send your message.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage`1-MessageQueue'></a>
### MessageQueue `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Supplies arguments for the message to be sent.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters
to the message.



The data types, order, and number of parameters, if supplied, must
match the signature of the message's delegate. |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-ForMessageId-System-Guid-'></a>
### ForMessageId(messageId) `method`

##### Summary

Filters the message queue by the unique identifier that the message's
handler was initially mapped under.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required). Unique identifier (GUID) that the message
handler was originally tagged with.



The Zero GUID must not be passed for this parameter.



If the Zero GUID is passed for this parameter, then this method throws
[ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`1-NoArgs'></a>
### NoArgs() `method`

##### Summary

Specifies that the message is to be sent without any input data.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method initializes the internal storage of this class that is
devoted to storing the argument list for the new message to contain zero
elements.



Calling this method is the same as calling the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method without
passing any parameters. Having this method available can make client code more
fluent.

<a name='T-xyLOGIX-Queues-Messages-Senders-SendMessage`2'></a>
## SendMessage\`2 `type`

##### Namespace

xyLOGIX.Queues.Messages.Senders

##### Summary

Sends messages to other application components, whose event data is
of type specified.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the type of data that the message notification
will carry. |
| R | Name of the type of the object that the method processing
the received message will return. |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, `private` constructor to prohibit direct allocation of this
class.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Senders-SendMessage`2-_args'></a>
### _args `constants`

##### Summary

Array of instances of objects that provide input to the notification.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage`2-Having'></a>
### Having `property`

##### Summary

Gets a reference to the one and only instance of
[SendMessage](#T-SampleMVP-SendMessage 'SampleMVP.SendMessage').

##### Remarks

This property is meant to be used in a fluent manner.



When using this property, first invoke the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method and then the
[ForMessageId](#M-xyLOGIX-Queues-Messages-SendMessage-ForMessageId 'xyLOGIX.Queues.Messages.SendMessage.ForMessageId') method to
send your message.

<a name='P-xyLOGIX-Queues-Messages-Senders-SendMessage`2-MessageQueue'></a>
### MessageQueue `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IMessageQueue](#T-xyLOGIX-Queues-Messages-Interfaces-IMessageQueue 'xyLOGIX.Queues.Messages.Interfaces.IMessageQueue') interface.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this
class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-Args-System-Object[]-'></a>
### Args(args) `method`

##### Summary

Supplies arguments for the message to be sent.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.Object[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object[] 'System.Object[]') | (Optional.) One of more values to be passed as parameters
to the message.



The data types, order, and number of parameters, if supplied, must
match the signature of the message's delegate. |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-ForMessageId-System-Guid-'></a>
### ForMessageId(messageId) `method`

##### Summary

Filters the message queue by the unique identifier that the message's
handler was initially mapped under.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageId | [System.Guid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid 'System.Guid') | (Required). Unique identifier (GUID) that the message
handler was originally tagged with.



The Zero GUID must not be passed for this parameter.



If the Zero GUID is passed for this parameter, then this method throws
[ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException'). |

<a name='M-xyLOGIX-Queues-Messages-Senders-SendMessage`2-NoArgs'></a>
### NoArgs() `method`

##### Summary

Specifies that the message is to be sent without any input data.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method initializes the internal storage of this class that is
devoted to storing the argument list for the new message to contain zero
elements.



Calling this method is the same as calling the
[Args](#M-xyLOGIX-Queues-Messages-SendMessage-Args 'xyLOGIX.Queues.Messages.SendMessage.Args') method without
passing any parameters. Having this method available can make client code more
fluent.
