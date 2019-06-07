# WindowRight

Creates a right-aligned sliding window over the source sequence of a given size.

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
from w in Enumerable.Range(1, 5)
                    .WindowRight(3)
select $"AVG({string.Join(",", w)}) = {w.Average()}"
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/window-right.md
[issue]: https://github.com/morelinq/try/issues/new?title=WindowRight
[doc]: https://morelinq.github.io/3.1/ref/api/html/M_MoreLinq_MoreEnumerable_WindowRight__1.htm
