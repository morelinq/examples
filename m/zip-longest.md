# ZipLongest

Returns a projection of tuples, where each tuple contains the N-th
element from each of the argument sequences. The resulting sequence
will always be as long as the longest of input sequences where the
default value of each of the shorter sequence element types is used
for padding.

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
// TODO add example
```

See also [Exploring MoreLINQ Part 1 - Zipping] by [Mark Heath] and his video
that covers `ZipLongest`:

[![Video by Mark Heath](http://img.youtube.com/vi/LmeTMUptJPo/0.jpg)](https://youtu.be/LmeTMUptJPo "MoreLINQ 1 - EquiZip, ZipLongest ZipShortest")

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/zip-longest.md
[issue]: https://github.com/morelinq/try/issues/new?title=ZipLongest
[doc]: https://morelinq.github.io/3.1/ref/api/html/Overload_MoreLinq_MoreEnumerable_ZipLongest.htm
[Exploring MoreLINQ Part 1 - Zipping]: https://markheath.net/post/exploring-morelinq-1-zipping
[Mark Heath]: https://markheath.net/
