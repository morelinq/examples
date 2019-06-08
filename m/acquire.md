# Acquire

Ensures that a sequence of _disposable_ objects, those implementing
[`IDisposable`][disposable]), are all acquired successfully. If the
acquisition of any one fails then those successfully acquired till that
point are disposed.

Following [answer][a] by [Sergey Berezovskiy][sb] to the [StackOverflow]
question, "[MoreLinq Acquire. What does it do?][q]", offers a
great explanation:

> Assume you have code which creates and returns disposable objects one by one:
>
> ```c#
> public IEnumerable<FileStream> GetFiles()
> {
>     yield return File.OpenRead("file1");
>     yield return File.OpenRead("file2"); // does not exist
>     yield return File.OpenRead("file3");
> }
> ```
>
> You need to get all of the disposable objects, but if in the middle of
> acquisition there is an exception, then the objects which were already yielded
> will stay in memory and not disposed. So, `Acquire` either acquires all
> streams and returns them, or, upon failing, it disposes all already acquired
> streams and rethrows the exception.
>
> ```c#
> var streams = GetFiles().Acquire();
> ```

The following example shows a function lazily yielding resources (objects
implementing `IDisposable`) that are later acquired and disposed in a loop.

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
IEnumerable<IDisposable> GetResources()
{
    WriteLine("Yielding resource #1");
    yield return Disposable(() => WriteLine("Resource #1 disposed"));
    WriteLine("Yielding resource #2");
    yield return Disposable(() => WriteLine("Resource #2 disposed"));
    WriteLine("Yielding resource #3");
    yield return Disposable(() => WriteLine("Resource #3 disposed"));
}

var i = 0;
foreach (var r in GetResources().Acquire())
{
    i++;
    using (r)
        WriteLine($"Disposing resource #{i}");
}
```

The `GetResources` function uses `Disposable` from the [Delegating] library to
create ad-hoc implementations. Running the example will produce the output:

```
Yielding resource #1
Yielding resource #2
Yielding resource #3
Disposing resource #1
Resource #1 disposed
Disposing resource #2
Resource #2 disposed
Disposing resource #3
Resource #3 disposed
```

Note how all the resources were acquired _eagerly_ at the start of the loop.

Suppose now `GetResources` is modified to simulate an error in the generation
of the third resource:

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
IEnumerable<IDisposable> GetResources()
{
    WriteLine("Yielding resource #1");
    yield return Disposable(() => WriteLine("Resource #1 disposed"));
    WriteLine("Yielding resource #2");
    yield return Disposable(() => WriteLine("Resource #2 disposed"));
    WriteLine("Yielding resource #3");
    throw new ApplicationException(); // Oops!
    // CS0162: Unreachable code detected
    yield return Disposable(() => WriteLine("Resource #3 disposed"));
}

try
{
    var i = 0;
    foreach (var r in GetResources().Acquire())
    {
        i++;
        using (r)
            WriteLine($"Disposing resource #{i}");
    }
}
catch (Exception e)
{
    WriteLine("ERROR! " + e.Message);
}
```

The ouput this time will read:

```
Yielding resource #1
Yielding resource #2
Yielding resource #3
Resource #1 disposed
Resource #2 disposed
ERROR! Error in the application.
```

Since not all resouces could be acquired successfully, because an error occurs
when the third resource is about to be yielded, `Acquire` disposes the first
two resources that were acquired successfully up to when the error occurs and
propagates up the stack. Since the loop is never entered, it would not have
had a chance to dispose the resources. Without `Acquire`, the resources would
have leaked.

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/acquire.md
[issue]: https://github.com/morelinq/try/issues/new?title=Acquire
[doc]: https://morelinq.github.io/3.1/ref/api/html/M_MoreLinq_MoreEnumerable_Acquire__1.htm
[sb]: https://stackoverflow.com/users/470005/sergey-berezovskiy
[StackOverflow]: https://stackoverflow.com/
[q]: https://stackoverflow.com/questions/21483023/morelinq-acquire-what-does-it-do
[a]: https://stackoverflow.com/a/21483151/6682
[disposable]: https://docs.microsoft.com/en-us/dotnet/api/system.idisposable
