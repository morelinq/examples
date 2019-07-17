# Try MoreLINQ

This documentation contains examples for using [MoreLINQ]. The examples can be
run and tested interactively in a browser using [`dotnet try`
(Try .NET)][dotnet-try].

See [Setup](setup.md) for requirements and installation instructions.

See the [Contribution Guidelines](CONTRIBUTING.md) if you would like to help
contribute new examples or improve existing ones.


## Examples

### [`Acquire`][Acquire]

Ensures that a source sequence of disposable objects are all acquired
successfully. If the acquisition of any one fails then those successfully
acquired till that point are disposed.

### [`Aggregate`][Aggregate]

Applies multiple accumulators sequentially in a single pass over a sequence.

### [`AggregateRight`][AggregateRight]

Applies a right-associative accumulator function over a sequence.
This operator is the right-associative version of the Aggregate LINQ operator.

### [`Append`][Append]

Returns a sequence consisting of the head element and the given tail elements.

### [`Assert`][Assert]

Asserts that all elements of a sequence meet a given condition otherwise
throws an exception.

### [`AssertCount`][AssertCount]

Asserts that a source sequence contains a given count of elements.

### [`AtLeast`][AtLeast]

Determines whether or not the number of elements in the sequence is greater
than or equal to the given integer.

### [`AtMost`][AtMost]

Determines whether or not the number of elements in the sequence is lesser
than or equal to the given integer.

### [`Backsert`][Backsert]

Inserts the elements of a sequence into another sequence at a
specified index from the tail of the sequence, where zero always represents
the last position, one represents the second-last element, two represents
the third-last element and so on.

### [`Batch`][Batch]

Batches the source sequence into sized buckets.

### [`Cartesian`][Cartesian]

Returns the Cartesian product of two or more sequences by combining each
element from the sequences and applying a user-defined projection to the
set.

### [`Choose`][Choose]

Applies a function to each element of the source sequence and returns a new
sequence of result elements for source elements where the function returns a
couple (2-tuple) having a `true` as its first element and result as the
second.

### [`CompareCount`][CompareCount]

Compares two sequences and returns an integer that indicates whether the
first sequence has fewer, the same or more elements than the second sequence.

### [`Consume`][Consume]

Completely consumes the given sequence. This method uses immediate execution,
and doesn't store any data during execution

### [`CountBetween`][CountBetween]

Determines whether or not the number of elements in the sequence is between an
inclusive range of minimum and maximum integers.

### [`CountBy`][CountBy]

Applies a key-generating function to each element of a sequence and returns a
sequence of unique keys and their number of occurrences in the original
sequence.

### [`CountDown`][CountDown]

Provides a countdown counter for a given count of elements at the tail of the
sequence where zero always represents the last element, one represents the
second-last element, two represents the third-last element and so on.

### [`DistinctBy`][DistinctBy]

Returns all distinct elements of the given source, where "distinctness" is
determined via a projection and the default equality comparer for the
projected type.

### [`EndsWith`][EndsWith]

Determines whether the end of the first sequence is equivalent to the second
sequence.

### [`EquiZip`][EquiZip]

Returns a projection of tuples, where each tuple contains the N-th
element from each of the argument sequences. An exception is thrown
if the input sequences are of different lengths.

### [`Exactly`][Exactly]

Determines whether or not the number of elements in the sequence is equals
to the given integer.

### [`ExceptBy`][ExceptBy]

Returns the set of elements in the first sequence which aren't in the second
sequence, according to a given key selector.

### [`Exclude`][Exclude]

Excludes elements from a sequence starting at a given index

### [`FallbackIfEmpty`][FallbackIfEmpty]

Returns the elements of a sequence and falls back to another if the original
sequence is empty.

### [`FillBackward`][FillBackward]

Returns a sequence with each null reference or value in the source replaced
with the following non-null reference or value in that sequence.

### [`FillForward`][FillForward]

Returns a sequence with each null reference or value in the source replaced
with the previous non-null reference or value seen in that sequence.

### [`Flatten`][Flatten]

Flattens a sequence containing arbitrarily-nested sequences.

### [`Fold`][Fold]

Returns the result of applying a function to a sequence with 1 to 16 elements.

### [`ForEach`][ForEach]

Immediately executes the given action on each element in the source sequence.

### [`From`][From]

Returns a sequence containing the values resulting from invoking (in order)
each function in the source sequence of functions.

### [`FullGroupJoin`][FullGroupJoin]

Performs a Full Group Join between the and sequences.

### [`FullJoin`][FullJoin]

Performs a full outer join between two sequences.

### [`Generate`][Generate]

Returns a sequence of values consecutively generated by a generator function

### [`GenerateByIndex`][GenerateByIndex]

Returns a sequence of values based on indexes

### [`GroupAdjacent`][GroupAdjacent]

Groups the adjacent elements of a sequence according to a specified key
selector function.

### [`Index`][Index]

Returns a sequence of where the key is the zero-based index of the value in
the source sequence.

### [`Insert`][Insert]

Inserts the elements of a sequence into another sequence at a specified index.

### [`Interleave`][Interleave]

Interleaves the elements of two or more sequences into a single sequence,
skipping sequences as they are consumed.

### [`Lag`][Lag]

Produces a projection of a sequence by evaluating pairs of elements separated
by a negative offset.

### [`Lead`][Lead]

Produces a projection of a sequence by evaluating pairs of elements separated
by a positive offset.

### [`LeftJoin`][LeftJoin]

Performs a left outer join between two sequences.

### [`MaxBy`][MaxBy]

Returns the maxima (maximal elements) of the given sequence, based on the
given projection.

### [`MinBy`][MinBy]

Returns the minima (minimal elements) of the given sequence, based on the
given projection.

### [`Move`][Move]

Returns a sequence with a range of elements in the source sequence
moved to a new offset.

### [`OrderBy`][OrderBy]

Sorts the elements of a sequence in a particular direction (ascending,
descending) according to a key.

### [`OrderedMerge`][OrderedMerge]

Merges two ordered sequences into one. Where the elements equal in both
sequences, the element from the first sequence is returned in the resulting
sequence.

### [`Pad`][Pad]

Pads a sequence with default values if it is narrower (shorter in length) than
a given width.

### [`PadStart`][PadStart]

Pads a sequence with default values in the beginning if it is narrower
(shorter in length) than a given width.

### [`Pairwise`][Pairwise]

Returns a sequence resulting from applying a function to each element in the
source sequence and its predecessor, with the exception of the first element
which is only returned as the predecessor of the second element

### [`PartialSort`][PartialSort]

Combines `OrderBy` (where element is key) and `Take` in a single operation.

### [`PartialSortBy`][PartialSortBy]

Combines `OrderBy` and `Take` in a single operation.

### [`Partition`][Partition]

Partitions a sequence by a predicate, or a grouping by Boolean keys or up to 3
sets of keys.

### [`Permutations`][Permutations]

Generates a sequence of lists that represent the permutations of the original
sequence

### [`Pipe`][Pipe]

Executes the given action on each element in the source sequence and yields it

### [`Prepend`][Prepend]

Prepends a single value to a sequence

### [`PreScan`][PreScan]

Performs a pre-scan (exclusive prefix sum) on a sequence of elements

### [`Random`][Random]

Returns an infinite sequence of random integers using the standard .NET random
number generator.

### [`RandomDouble`][RandomDouble]

Returns an infinite sequence of random double values between 0.0 and 1.0.

### [`RandomSubset`][RandomSubset]

Returns a sequence of a specified size of random elements from the original
sequence.

### [`Rank`][Rank]

Ranks each item in the sequence in descending ordering using a default
comparer.

### [`RankBy`][RankBy]

Ranks each item in the sequence in descending ordering by a specified key
using a default comparer.

### [`Repeat`][Repeat]

Repeats the sequence indefinitely or a specific number of times.

### [`RightJoin`][RightJoin]

Performs a right outer join between two sequences.

### [`RunLengthEncode`][RunLengthEncode]

Run-length encodes a sequence by converting consecutive instances of the same
element into a `KeyValuePair<T, int>` representing the item and its occurrence
count.

### [`Scan`][Scan]

Peforms a scan (inclusive prefix sum) on a sequence of elements.

### [`ScanBy`][ScanBy]

Applies an accumulator function over sequence element keys, returning the keys
along with intermediate accumulator states.

### [`ScanRight`][ScanRight]

Peforms a right-associative scan (inclusive prefix) on a sequence of elements.
This operator is the right-associative version of the Scan operator.

### [`Segment`][Segment]

Divides a sequence into multiple sequences by using a segment detector based
on the original sequence.

### [`Sequence`][Sequence]

Generates a sequence of integral numbers within the (inclusive) specified range.

### [`Shuffle`][Shuffle]

Returns a sequence of elements in random order from the original sequence.

### [`SkipLast`][SkipLast]

Bypasses a specified number of elements at the end of the sequence.

### [`SkipUntil`][SkipUntil]

Skips items from the input sequence until the given predicate returns true
when applied to the current source item; that item will be the last skipped

### [`Slice`][Slice]

Extracts elements from a sequence at a particular zero-based starting index

### [`SortedMerge`][SortedMerge]

Merges two or more sequences that are in a common order (either ascending or
descending) into a single sequence that preserves that order.

### [`Split`][Split]

Splits the source sequence by a separator.

### [`StartsWith`][StartsWith]

Determines whether the beginning of the first sequence is equivalent to the
second sequence.

### [`Subsets`][Subsets]

Returns a sequence of representing all of the subsets of any size that are
part of the original sequence.

### [`TagFirstLast`][TagFirstLast]

Returns a sequence resulting from applying a function to each element in the
source sequence with additional parameters indicating whether the element is
the first and/or last of the sequence

### [`TakeEvery`][TakeEvery]

Returns every N-th element of a source sequence

### [`TakeLast`][TakeLast]

Returns a specified number of contiguous elements from the end of a sequence

### [`TakeUntil`][TakeUntil]

Returns items from the input sequence until the given predicate returns true
when applied to the current source item; that item will be the last returned

### [`ThenBy`][ThenBy]

Performs a subsequent ordering of elements in a sequence in a particular
direction (ascending, descending) according to a key.

### [`ToArrayByIndex`][ToArrayByIndex]

Creates an array from an IEnumerable<T> where a function is used to determine
the index at which an element will be placed in the array.

### [`ToDataTable`][ToDataTable]

Appends elements in the sequence as rows of a given object with a set of
lambda expressions specifying which members (property or field) of each
element in the sequence will supply the column values.

### [`ToDelimitedString`][ToDelimitedString]

Creates a delimited string from a sequence of values. The delimiter used
depends on the current culture of the executing thread.

### [`ToDictionary`][ToDictionary]

Creates a [dictionary] from a sequence of [key-value pair][kvp] elements
or tuples of 2.

### [`ToHashSet`][ToHashSet]

Returns a [hash-set] of the source items using the default equality
comparer for the type.

### [`ToLookup`][ToLookup]

Creates a [lookup] from a sequence of [key-value pair][kvp] elements
or tuples of 2.

### [`Transpose`][Transpose]

Transposes the rows of a sequence into columns.

### [`TraverseBreadthFirst`][TraverseBreadthFirst]

Traverses a tree in a breadth-first fashion, starting at a root node and using
a user-defined function to get the children at each node of the tree.

### [`TraverseDepthFirst`][TraverseDepthFirst]

Traverses a tree in a depth-first fashion, starting at a root node and using a
user-defined function to get the children at each node of the tree.

### [`Trace`][Trace]

Traces the elements of a source sequence for diagnostics.

### [`Unfold`][Unfold]

Returns a sequence generated by applying a state to the generator function,
and from its result, determines if the sequence should have a next element and
its value, and the next state in the recursive call.

### [`Window`][Window]

Processes a sequence into a series of subsequences representing a windowed
subset of the original

### [`WindowLeft`][WindowLeft]

Creates a left-aligned sliding window over the source sequence of a given size.

### [`WindowRight`][WindowRight]

Creates a right-aligned sliding window over the source sequence of a given size.

### [`ZipLongest`][ZipLongest]

Returns a projection of tuples, where each tuple contains the N-th
element from each of the argument sequences. The resulting sequence
will always be as long as the longest of input sequences where the
default value of each of the shorter sequence element types is used
for padding.

### [`ZipShortest`][ZipShortest]

Returns a projection of tuples, where each tuple contains the N-th
element from each of the argument sequences. The resulting sequence
is as short as the shortest input sequence.


## Experimental Operators

THESE METHODS ARE EXPERIMENTAL. THEY MAY BE UNSTABLE AND UNTESTED. THEY MAY BE
REMOVED FROM A FUTURE MAJOR OR MINOR RELEASE AND POSSIBLY WITHOUT NOTICE. USE
THEM AT YOUR OWN RISK. THE METHODS ARE PUBLISHED FOR FIELD EXPERIMENTATION TO
SOLICIT FEEDBACK ON THEIR UTILITY AND DESIGN/IMPLEMENTATION DEFECTS.

Use of experimental methods requires importing the `MoreLinq.Experimental`
namespace.

### [`Await`][Await]

Creates a sequence query that streams the result of each task in the source
sequence as it completes asynchronously.

### [`AwaitCompletion`][AwaitCompletion]

Awaits completion of all asynchronous evaluations irrespective of whether they
succeed or fail. An additional argument specifies a function that projects the
final result given the source item and completed task.

### [`Memoize`][Memoize]

Creates a sequence that lazily caches the source as it is iterated for the
first time, reusing the cache thereafter for future re-iterations. If the
source is already cached or buffered then it is returned verbatim.


[MoreLINQ]: https://morelinq.github.io/
[dotnet-try]: https://github.com/dotnet/try
[dictionary]: https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2
[hash-set]: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1
[kvp]: https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2
[lookup]: https://docs.microsoft.com/en-us/dotnet/api/system.linq.lookup-2

[Acquire]: ./m/acquire.md
[Aggregate]: ./m/aggregate.md
[AggregateRight]: ./m/aggregate-right.md
[Append]: ./m/append.md
[Assert]: ./m/assert.md
[AssertCount]: ./m/assert-count.md
[AtLeast]: ./m/at-least.md
[AtMost]: ./m/at-most.md
[Await]: ./m/await.md
[AwaitCompletion]: ./m/await-completion.md
[Backsert]: ./m/backsert.md
[Batch]: ./m/batch.md
[Cartesian]: ./m/cartesian.md
[Choose]: ./m/choose.md
[CompareCount]: ./m/compare-count.md
[Consume]: ./m/consume.md
[CountBetween]: ./m/count-between.md
[CountBy]: ./m/count-by.md
[CountDown]: ./m/count-down.md
[DistinctBy]: ./m/distinct-by.md
[EndsWith]: ./m/ends-with.md
[EquiZip]: ./m/equi-zip.md
[Exactly]: ./m/exactly.md
[ExceptBy]: ./m/except-by.md
[Exclude]: ./m/exclude.md
[FallbackIfEmpty]: ./m/fallback-if-empty.md
[FillBackward]: ./m/fill-backward.md
[FillForward]: ./m/fill-forward.md
[Flatten]: ./m/flatten.md
[Fold]: ./m/fold.md
[ForEach]: ./m/for-each.md
[From]: ./m/from.md
[FullGroupJoin]: ./m/full-group-join.md
[FullJoin]: ./m/full-join.md
[Generate]: ./m/generate.md
[GenerateByIndex]: ./m/generate-by-index.md
[GroupAdjacent]: ./m/group-adjacent.md
[Index]: ./m/index.md
[Insert]: ./m/insert.md
[Interleave]: ./m/interleave.md
[Lag]: ./m/lag.md
[Lead]: ./m/lead.md
[LeftJoin]: ./m/left-join.md
[MaxBy]: ./m/max-by.md
[Memoize]: ./m/memoize.md
[MinBy]: ./m/min-by.md
[Move]: ./m/move.md
[OrderBy]: ./m/order-by.md
[OrderedMerge]: ./m/ordered-merge.md
[Pad]: ./m/pad.md
[PadStart]: ./m/pad-start.md
[Pairwise]: ./m/pairwise.md
[PartialSort]: ./m/partial-sort.md
[PartialSortBy]: ./m/partial-sort-by.md
[Partition]: ./m/partition.md
[Permutations]: ./m/permutations.md
[Pipe]: ./m/pipe.md
[Prepend]: ./m/prepend.md
[PreScan]: ./m/pre-scan.md
[Random]: ./m/random.md
[RandomDouble]: ./m/random-double.md
[RandomSubset]: ./m/random-subset.md
[Rank]: ./m/rank.md
[RankBy]: ./m/rank-by.md
[Repeat]: ./m/repeat.md
[RightJoin]: ./m/right-join.md
[RunLengthEncode]: ./m/run-length-encode.md
[Scan]: ./m/scan.md
[ScanBy]: ./m/scan-by.md
[ScanRight]: ./m/scan-right.md
[Segment]: ./m/segment.md
[Sequence]: ./m/sequence.md
[Shuffle]: ./m/shuffle.md
[SkipLast]: ./m/skip-last.md
[SkipUntil]: ./m/skip-until.md
[Slice]: ./m/slice.md
[SortedMerge]: ./m/sorted-merge.md
[Split]: ./m/split.md
[StartsWith]: ./m/starts-with.md
[Subsets]: ./m/subsets.md
[TagFirstLast]: ./m/tag-first-last.md
[TakeEvery]: ./m/take-every.md
[TakeLast]: ./m/take-last.md
[TakeUntil]: ./m/take-until.md
[ThenBy]: ./m/then-by.md
[ToArrayByIndex]: ./m/to-array-by-index.md
[ToDataTable]: ./m/to-data-table.md
[ToDelimitedString]: ./m/to-delimited-string.md
[ToDictionary]: ./m/to-dictionary.md
[ToHashSet]: ./m/to-hash-set.md
[ToLookup]: ./m/to-lookup.md
[Trace]: ./m/trace.md
[Transpose]: ./m/transpose.md
[TraverseBreadthFirst]: ./m/traverse-breadth-first.md
[TraverseDepthFirst]: ./m/traverse-depth-first.md
[Unfold]: ./m/unfold.md
[Window]: ./m/window.md
[WindowLeft]: ./m/window-left.md
[WindowRight]: ./m/window-right.md
[ZipLongest]: ./m/zip-longest.md
[ZipShortest]: ./m/zip-shortest.md
