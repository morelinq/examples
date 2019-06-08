# Contribution Guidelines

You can help by contributing new examples or improve on existing ones that
demonstrate how to use the various MoreLINQ methods and extensions.

All it takes to add an example is the following fenced-block in a Markdown
document:

    ```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
    // replace this comment with your example code
    ```

**You can develop an example as a single C# expression or as C# statements.**
In the above example, `--region statements` assumes the example code is
expressed as one or more C# statements:

    ```c# --destination-file ../code/Program.cs --region statements --project ../code/TryMoreLinq.csproj
    var xs = Enumerable.Range(1, 5);
    foreach (var x in xs)
        Console.WriteLine(x);
    ```

To show an example as a single C# expression, instead, change
`--region statements` to `--region expression`. The benefit is that you do not
need to worry about looping and displaying the result of the expression via
`Console.WriteLine`. This will be done automatically when the example is run
interactively through Try .NET. Following is an example using an expression:

    ```c# --destination-file ../code/Program.cs --region expression --project ../code/TryMoreLinq.csproj
    Enumerable.Range(1, 5)
    ```

Note that expressions _must not_ be terminated by a semi-colon (`;`), which is
the standard syntax rule in C#.

Keep examples:

- simple
- clear
- short
- meaningful
- self-contained

You may use C# 8 in example code.

**Wrap paragraphs in Markdown documents such that no line exceeds 78
characters in length.** See the "Wrap Your Text" section of [Markdown Style
Guide] on [Miguel de Icaza's Blog][tirania] for the background behind this
choice.

That's it! Fork away and submit your pull request!


[Markdown Style Guide]: https://tirania.org/blog/archive/2014/Sep-30.html
[tirania]: https://tirania.org/blog/
