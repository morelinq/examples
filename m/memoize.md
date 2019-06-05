# Memoize

Creates a sequence that lazily caches the source as it is iterated for the
first time, reusing the cache thereafter for future re-iterations. If the
source is already cached or buffered then it is returned verbatim.

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
// TODO add example
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/memoize.md
[issue]: https://github.com/morelinq/try/issues/new?title=Memoize
[doc]: https://morelinq.github.io/3.1/ref/api/html/M_MoreLinq_Experimental_ExperimentalEnumerable_Memoize__1.htm
