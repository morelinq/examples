# AggregateRight

Applies multiple accumulators sequentially in a single pass over a sequence.

In the example below, `Aggregate` is used to run the following seven
accumulators:

- sum of all numbers
- sum of even numbers
- count of numbers
- smallest number
- largest number
- distinct number of digits across all numbers
- list of numbers

concurrently, and in a single pass, over a sequence of integers:

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
Enumerable
    .Range(1, 10)
    .Shuffle()
    .Select(n => new { Num = n, Str = n.ToString(CultureInfo.InvariantCulture) })
    .Aggregate(
        0, (s, e) => s + e.Num,
        0, (s, e) => e.Num % 2 == 0 ? s + e.Num : s,
        0, (s, _) => s + 1,
        (int?)null, (s, e) => s is int n ? Math.Min(n, e.Num) : e.Num,
        (int?)null, (s, e) => s is int n ? Math.Max(n, e.Num) : e.Num,
        new HashSet<int>(), (s, e) => { s.Add(e.Str.Length); return s; },
        new List<(int, string)>(), (s, e) => { s.Add((e.Num, e.Str)); return s; },
        (sum, esum, count, min, max, lengths, items) => new
        {
            Sum           = sum,
            EvenSum       = esum,
            Count         = count,
            Average       = (double)sum / count,
            Min           = min is int mn ? mn : throw new InvalidOperationException(),
            Max           = max is int mx ? mx : throw new InvalidOperationException(),
            UniqueLengths = "[" + string.Join(", ", lengths) + "]",
            Items         = "[" + string.Join(", ", items)   + "]",
        })
```

Writing each aggregator this way can be tedious, repetitive and error-prone
because you cannot, for example, reuse [`Enumerable.Sum`][sum] but there is
a set of [_experimental overloads_][exp] (that live in the
[`MoreLinq.Experimental` namespace][expns]) that allow aggregators to be written
as _reactive comprehensions_. This enables you to use aggregators from
[System.Reactive]. The next example is logically the same as the previous,
except it uses the overload where aggregators from System.Reactive are reused.

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
Enumerable
    .Range(1, 10)
    .Shuffle()
    .Select(n => new { Num = n, Str = n.ToString(CultureInfo.InvariantCulture) })
    .Aggregate(
        s => s.Sum(e => e.Num),
        s => s.Select(e => e.Num).Where(n => n % 2 == 0).Sum(),
        s => s.Count(),
        s => s.Min(e => e.Num),
        s => s.Max(e => e.Num),
        s => s.Select(e => e.Str.Length).Distinct().ToArray(),
        s => s.ToList(),
        (sum, esum, count, min, max, lengths, items) => new
        {
            Sum           = sum,
            EvenSum       = esum,
            Count         = count,
            Average       = (double)sum / count,
            Min           = min,
            Max           = max,
            UniqueLengths = "[" + string.Join(", ", lengths) + "]",
            Items         = "[" + string.Join(", ", items)   + "]",
        })
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/aggregate.md
[issue]: https://github.com/morelinq/try/issues/new?title=Aggregate
[doc]: https://morelinq.github.io/3.2/ref/api/html/Overload_MoreLinq_MoreEnumerable_Aggregate.htm

[sum]: https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum
[expns]: https://morelinq.github.io/3.2/ref/api/html/N_MoreLinq_Experimental.htm
[exp]: https://morelinq.github.io/3.2/ref/api/html/Overload_MoreLinq_Experimental_ExperimentalEnumerable_Aggregate.htm
[System.Reactive]: https://www.nuget.org/packages/System.Reactive/
