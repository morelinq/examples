# AggregateRight

Applies a right-associative accumulator function over a sequence.
This operator is the right-associative version of the [`Aggregate`][Aggregate]
LINQ operator.

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
Enumerable
    .Range(1, 5)
    .Select(i => i.ToString())
    .AggregateRight((a, b) => string.Format("({0}/{1})", a, b))
```

Using an overload of `AggregateRight`, you can also supply a _seed_:

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
Enumerable
    .Range(1, 5)
    .AggregateRight("6", (a, b) => string.Format("({0}/{1})", a, b))
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/aggregate-right.md
[issue]: https://github.com/morelinq/try/issues/new?title=AggregateRight
[doc]: https://morelinq.github.io/3.1/ref/api/html/Overload_MoreLinq_MoreEnumerable_AggregateRight.htm

[Aggregate]: https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate
