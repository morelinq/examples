# DistinctBy

Returns all distinct elements of the given source, where "distinctness" is
determined via a projection and the default equality comparer for the
projected type.

```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
List<Person> people = new List<Person>() {
	new Person() { name = "Jhon", email = "jhon@github.com" },
	new Person() { name = "Annie", email = "annie@github.com" },
	new Person() { name = "Jhon", email = "jhonny@github.com" }
};

List<Person> uniquePeople = people.DistinctBy((person) => person.name).ToList();

// At this point uniquePeople contains:
//   new Person() { name = "Jhon", email = "jhon@github.com" },
//   new Person() { name = "Annie", email = "anni@github.com" }
```

For more details, [see the documentation][doc].

---

[&#x270F; Edit this page][edit] if you see a typo or wish to contribute an
improvement. Alternatively, you can also [report an issue you see][issue].


[edit]: https://github.com/morelinq/try/edit/master/m/distinct-by.md
[issue]: https://github.com/morelinq/try/issues/new?title=DistinctBy
[doc]: https://morelinq.github.io/3.1/ref/api/html/Overload_MoreLinq_MoreEnumerable_DistinctBy.htm
