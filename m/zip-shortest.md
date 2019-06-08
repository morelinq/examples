# ZipShortest

Returns a projection of tuples, where each tuple contains the N-th
element from each of the argument sequences. The resulting sequence
is as short as the shortest input sequence.

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
var numbers = new[] { 1, 2, 3 };
var letters = new[] { "A", "B", "C", "D" };
var chars   = new[] { 'a', 'b', 'c', 'd', 'e' };
var flags   = new[] { true, false };
var zipped  = numbers.ZipShortest(letters, chars, flags, (n, l, c, f) => n + l + c + f);
WriteLine(zipped);
```

See also [Exploring MoreLINQ Part 1 - Zipping] by [Mark Heath] and his video
that covers `ZipShortest`:

[![Video by Mark Heath](http://img.youtube.com/vi/LmeTMUptJPo/0.jpg)](https://youtu.be/LmeTMUptJPo "MoreLINQ 1 - EquiZip, ZipLongest ZipShortest")

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/zip-shortest.md
[issue]: https://github.com/morelinq/try/issues/new?title=ZipShortest
[doc]: https://morelinq.github.io/3.1/ref/api/html/Overload_MoreLinq_MoreEnumerable_ZipShortest.htm
[Exploring MoreLINQ Part 1 - Zipping]: https://markheath.net/post/exploring-morelinq-1-zipping
[Mark Heath]: https://markheath.net/
