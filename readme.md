# Console Dump of an object
[LINQPad](https://www.linqpad.net/) has a handy extension method on `object` called `Dump()` which formats and displays the object in a display pane. It functions as a souped-up version of `Console.WriteLine()` since it handles `null`, formats collections and so on.

I thought it would be fun little project to see how well I could mimic that functionality using just a basic console. There will be some limitations, since LP outputs to a rich text pane, so it can "prettify" tables and complex objects, but let's see how far I can get.