<a name='assembly'></a>
# xyLOGIX.Queues.Messages.Mappings

## Contents

- [NewMessageMapping](#T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-#ctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.#ctor')
  - [_messageId](#F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-_messageId 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping._messageId')
  - [Associate](#P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-Associate 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.Associate')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-#cctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.#cctor')
  - [AndEventHandler(handler)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-AndEventHandler-System-EventHandler- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.AndEventHandler(System.EventHandler)')
  - [AndHandler(d)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.AndHandler(System.Delegate)')
  - [WithMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-WithMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping.WithMessageId(System.Guid)')
- [NewMessageMapping\`1](#T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-#ctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.#ctor')
  - [_messageId](#F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-_messageId 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1._messageId')
  - [Associate](#P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-Associate 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.Associate')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-#cctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.#cctor')
  - [AndEventHandler(handler)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-AndEventHandler-System-EventHandler{`0}- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.AndEventHandler(System.EventHandler{`0})')
  - [AndHandler(d)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.AndHandler(System.Delegate)')
  - [WithHandler(d)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-WithHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.WithHandler(System.Delegate)')
  - [WithMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-WithMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`1.WithMessageId(System.Guid)')
- [NewMessageMapping\`2](#T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2')
  - [#ctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-#ctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.#ctor')
  - [_messageId](#F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-_messageId 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2._messageId')
  - [Associate](#P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-Associate 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.Associate')
  - [#cctor()](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-#cctor 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.#cctor')
  - [AndEventHandler(handler)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-AndEventHandler-System-Func{System-Object,`0,`1}- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.AndEventHandler(System.Func{System.Object,`0,`1})')
  - [AndHandler(d)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-AndHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.AndHandler(System.Delegate)')
  - [WithHandler(d)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-WithHandler-System-Delegate- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.WithHandler(System.Delegate)')
  - [WithMessageId(messageId)](#M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-WithMessageId-System-Guid- 'xyLOGIX.Queues.Messages.Mappings.NewMessageMapping`2.WithMessageId(System.Guid)')
- [Resources](#T-xyLOGIX-Queues-Messages-Mappings-Properties-Resources 'xyLOGIX.Queues.Messages.Mappings.Properties.Resources')
  - [Culture](#P-xyLOGIX-Queues-Messages-Mappings-Properties-Resources-Culture 'xyLOGIX.Queues.Messages.Mappings.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Queues-Messages-Mappings-Properties-Resources-ResourceManager 'xyLOGIX.Queues.Messages.Mappings.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping'></a>
## NewMessageMapping `type`

##### Namespace

xyLOGIX.Queues.Messages.Mappings

##### Summary

Fluent-builder object to build message-map entries.

##### Remarks

Message-map entries are what bind together a message's identifier and/or
data object type with a method that handles it; i.e, its message handler.



Message handlers are invoked automatically in response to messages being
sent or broadcast with the corresponding identifier or data type specified.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[NewMessageMapping{T}](#T-xyLOGIX-Queues-Messages-NewMessageMapping{T} 'xyLOGIX.Queues.Messages.NewMessageMapping{T}')
and returns
a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-_messageId'></a>
### _messageId `constants`

##### Summary

Unique identifier that identifies the specific message that gets
matched with a method that will be invoked when the message is sent.

<a name='P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-Associate'></a>
### Associate `property`

##### Summary

Associates a message and its handler together.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-AndEventHandler-System-EventHandler-'></a>
### AndEventHandler(handler) `method`

##### Summary

Associates a [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') with the message
having unique identifier specified by the earlier call to the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') | A [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') specifying the code to be
invoked when the message is sent. |

##### Remarks

The delegate, `handler`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is not meant to be called in a standalone fashion;
rather, it should be called in a fluent chain after calling the
WithMessageId method.



It is not required, nor is it even advisable, to call the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method before calling this one. If this has been done anyway, then
this method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-AndHandler-System-Delegate-'></a>
### AndHandler(d) `method`

##### Summary

Associates a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') with the message having
unique identifier specified by the earlier call to the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method.

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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has been called prior to calling this method. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is not meant to be called in a standalone fashion;
rather, it should be called in a fluent chain after calling the
WithMessageId method.



It is not required, nor is it even advisable, to call the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method before calling this one. If this has been done anyway, then
this method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping-WithMessageId-System-Guid-'></a>
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `messageId` parameter is passed
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty')
for its value. |

##### Remarks

You must call the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method after calling this method. This method has to be called prior
to calling the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method. If this is not done, then the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method will throw a [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException')
exception.

<a name='T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1'></a>
## NewMessageMapping\`1 `type`

##### Namespace

xyLOGIX.Queues.Messages.Mappings

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

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[NewMessageMapping{T}](#T-xyLOGIX-Queues-Messages-NewMessageMapping{T} 'xyLOGIX.Queues.Messages.NewMessageMapping{T}')
and returns
a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-_messageId'></a>
### _messageId `constants`

##### Summary

Unique identifier that identifies the specific message that gets
matched with a method that will be invoked when the message is sent.

<a name='P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-Associate'></a>
### Associate `property`

##### Summary

Associates a message and its handler together.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-AndEventHandler-System-EventHandler{`0}-'></a>
### AndEventHandler(handler) `method`

##### Summary

Associates a [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') with the message
having unique identifier specified by the earlier call to the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.EventHandler{\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler{`0}') | A [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') specifying the code to be
invoked when the message is sent. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `handler`, is
passed a `null` value. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has been called prior to calling this method. |

##### Remarks

The delegate, `handler`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a fluent-builder
style after calling the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method.



If the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called before this one, this method will throw
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-AndHandler-System-Delegate-'></a>
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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown in the event that the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a fluent-builder
style after calling the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method.



If the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called before this one, this method will throw
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-WithHandler-System-Delegate-'></a>
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
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has been called prior to calling this method. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a standalone fashion.



It is not required, nor is it even advisable, to call the
[WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method before calling this one. If this has been done anyway, then
this method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`1-WithMessageId-System-Guid-'></a>
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
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if the `messageId` parameter is passed
[Empty](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Guid.Empty 'System.Guid.Empty')
for its value. |

##### Remarks

You must call the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method after calling this method. This method has to be called prior
to calling the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method. If this is not done, then the
[AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method will throw a [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException')
exception.

<a name='T-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2'></a>
## NewMessageMapping\`2 `type`

##### Namespace

xyLOGIX.Queues.Messages.Mappings

##### Summary

Fluent-builder object to build message-map entries.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Name of the data type that carries the event data. |
| R | Name of the data type that carries the result of processing the message. |

##### Remarks

Message-map entries are what bind together a message's identifier and/or
data object type with a method that handles it; i.e, its message handler.



Message handlers are invoked automatically in response to messages being
sent or broadcast with the corresponding identifier or data type specified.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [NewMessageMapping{T}](#T-xyLOGIX-Queues-Messages-NewMessageMapping{T} 'xyLOGIX.Queues.Messages.NewMessageMapping{T}') and returns
a reference to it.

##### Parameters

This constructor has no parameters.

<a name='F-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-_messageId'></a>
### _messageId `constants`

##### Summary

Unique identifier that identifies the specific message that gets
matched with a method that will be invoked when the message is sent.

<a name='P-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-Associate'></a>
### Associate `property`

##### Summary

Associates a message and its handler together.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-AndEventHandler-System-Func{System-Object,`0,`1}-'></a>
### AndEventHandler(handler) `method`

##### Summary

Associates a [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') with the message
having unique identifier specified by the earlier call to the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId') method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| handler | [System.Func{System.Object,\`0,\`1}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Object,`0,`1}') | A [EventHandler](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventHandler 'System.EventHandler') specifying the code to be
invoked when the message is sent. |

##### Remarks

The delegate, `handler`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a fluent-builder
style after calling the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId') method.



If the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method has not been called before this one, this method will throw
[InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-AndHandler-System-Delegate-'></a>
### AndHandler(d) `method`

##### Summary

Associates a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') with the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') specifying the code to be invoked
when the message is sent. |

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

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-WithHandler-System-Delegate-'></a>
### WithHandler(d) `method`

##### Summary

Associates a [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') with the message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') | A [Delegate](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Delegate 'System.Delegate') specifying the code to be invoked
when the message is sent. |

##### Remarks

The delegate, `d`, can be thought of as being
analogous to a C-style function pointer, in that it refers to code
that will be invoked when a message matching the creation criteria
is sent.



This method is meant to be called in a standalone fashion.



It is not required, nor is it even advisable, to call the [WithMessageId](#M-xyLOGIX-Queues-Messages-NewMessageMapping-WithMessageId 'xyLOGIX.Queues.Messages.NewMessageMapping.WithMessageId')
method before calling this one. If this has been done anyway, then
this method throws [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException').

<a name='M-xyLOGIX-Queues-Messages-Mappings-NewMessageMapping`2-WithMessageId-System-Guid-'></a>
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

##### Remarks

You must call the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method after calling this method. This method has to be called prior
to calling the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method. If this is not done, then the [AndHandler](#M-xyLOGIX-Queues-Messages-NewMessageMapping-AndHandler 'xyLOGIX.Queues.Messages.NewMessageMapping.AndHandler')
method will throw a [InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') exception.

<a name='T-xyLOGIX-Queues-Messages-Mappings-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Queues.Messages.Mappings.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Queues-Messages-Mappings-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Queues-Messages-Mappings-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
