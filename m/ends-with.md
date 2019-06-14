# EndsWith

Determines whether the end of the first sequence is equivalent to the second
sequence.

The following example checks whether the [segments] of a URL's path component
end with a particular sequence or not:

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
var tail = new[] { "foo/", "bar/" };

var url1 = new Uri("http://example.com/foo/bar/");
WriteLine(url1.Segments.EndsWith(tail)); // True

var url2 = new Uri("http://example.com/foo/bar/baz/");
WriteLine(url2.Segments.EndsWith(tail)); // False
```

The same example as above is expressed as a single query expression below:

```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
from url in new[]
{
    "http://example.com/foo/bar/",
    "http://example.com/foo/bar/baz/",
}
select new Uri(url) into url
select new
{
    Url = url,
    EndsWithFooBar = url.Segments.EndsWith(new[] { "foo/", "bar/" }),
}
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/ends-with.md
[issue]: https://github.com/morelinq/try/issues/new?title=EndsWith
[doc]: https://morelinq.github.io/3.1/ref/api/html/Overload_MoreLinq_MoreEnumerable_EndsWith.htm
[segments]: https://docs.microsoft.com/en-us/dotnet/api/system.uri.segments
