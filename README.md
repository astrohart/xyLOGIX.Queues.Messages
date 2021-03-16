# xyLOGIX.Queues.Messages

This project is a collection of C# class libraries -- that I hope to combine into a NuGet package some day -- which implement a very simple version of the Event Aggregator pattern.

I am heavily experienced in C++/MFC/Win32 and, as such, I sought to emulate the way the Microsoft Foundation Class Library implements event aggregation (called message maps in that implementation) on a very microcosm level in C#.

The idea sprang from my working in a recent project where I had a service object being called by a WinForms Presenter (using MVP pattern). The service object exposed numerous C# `event`s that served as callbacks for various phases of the actions of the service object.

That was less than satisfactory because:

* (a) It tightly coupled the Presenter and the Service Object; and
* (b) No one else but the Presenter could receive the event notifications.
* (c) Some of the events were ones that the client(s) of the Presenter object might also be interested in.

This system of class libraries was the solution to that problem.  Using this framework is a way to allow me to decouple the sender of a C# `event` from a handler of it.

I specifically geared this library towards a way to "meld" the C#-style `event`s with the Event Aggregator pattern and make it compatible with a WinForms application (or, really, any C# application but I had to make sure it would work seamlessly with a MVP WinForms app first and foremost).

To that end, I cobbled together a stupid little calculator app using MVP -- see the [SampleMVP](https://github.com/astrohart/SampleMVP) repository for that, following the tutorial [posted here](https://grantwinney.com/its-possible-to-test-a-winforms-app-using-mvp/).  Now, I obviously know how to write MVP apps without following tutorials --- however, the thought process at the time was to standardize the client of the message queue according to something posted by somebody else online.  This gives us the opportunity to see the deltas.

Then what I did was refactor the project from the tutorial to use a generalized message-queue apparatus according to my approach.  Then I created this Visual Studio solution and I migrated the code that was not specific to [SampleMVP](https://github.com/astrohart/SampleMVP) out of that project and into this one.