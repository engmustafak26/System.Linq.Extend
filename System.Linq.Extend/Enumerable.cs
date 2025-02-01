using System;
using System.Collections;
using System.Collections.Generic;

namespace System.Linq.Extend
{
    public static partial class Enumerable
    {
        const string ExceptionMessage = "Aborted by user code";

        //
        // Summary:
        //     Creates an array from a System.Collections.Generic.IEnumerable`1.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create an array from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     An array that contains the elements from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource[] ToArray<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToArray, () => Linq.Enumerable.ToArray(source), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains keys and values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null. -or- keySelector produces a key that is null.
        //
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToDictionary, () => Linq.Enumerable.ToDictionary(source, keySelector), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function and key comparer.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the keys returned by keySelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains keys and values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null. -or- keySelector produces a key that is null.
        //
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TSource> ToDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToDictionary, () => Linq.Enumerable.ToDictionary(source, keySelector, comparer), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to specified key selector and element selector functions.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        //     selected from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null. -or- keySelector produces a
        //     key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToDictionary, () => Linq.Enumerable.ToDictionary(source, keySelector, elementSelector), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.Dictionary`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function, a comparer, and an element selector
        //     function.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.Dictionary`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Collections.Generic.Dictionary`2 that contains values of type TElement
        //     selected from the input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null. -or- keySelector produces a
        //     key that is null.
        //
        //   T:System.ArgumentException:
        //     keySelector produces duplicate keys for two elements.
        public static Dictionary<TKey, TElement> ToDictionary<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToDictionary, () => Linq.Enumerable.ToDictionary(source, keySelector, elementSelector, comparer), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.HashSet`1 from an System.Collections.Generic.IEnumerable`1.
        //
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.HashSet`1
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.HashSet`1 that contains values of type TSource selected
        //     from the input sequence.
        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options = null)
             => CodeWrapperUtility.WrapLinq(Event.ToHashSet, () => Linq.Enumerable.ToHashSet(source), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.HashSet`1 from an System.Collections.Generic.IEnumerable`1
        //     using the comparer to compare keys
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.HashSet`1
        //     from.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.HashSet`1 that contains values of type TSource selected
        //     from the input sequence.
        public static HashSet<TSource> ToHashSet<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToHashSet, () => Linq.Enumerable.ToHashSet(source, comparer), source, options);
        //
        // Summary:
        //     Creates a System.Collections.Generic.List`1 from an System.Collections.Generic.IEnumerable`1.
        //
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Collections.Generic.List`1
        //     from.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     A System.Collections.Generic.List`1 that contains elements from the input sequence.
        //
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static List<TSource> ToList<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options = null)
           => CodeWrapperUtility.WrapLinq(Event.ToList, () => Linq.Enumerable.ToList(source), source, options);
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains keys and values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, ExtendLinqOptions options = null)
             => CodeWrapperUtility.WrapLinq(Event.ToLookup, () => Linq.Enumerable.ToLookup(source, keySelector), source, options);
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function and key comparer.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains keys and values.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector is null.
        public static ILookup<TKey, TSource> ToLookup<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, ExtendLinqOptions options = null)
             => CodeWrapperUtility.WrapLinq(Event.ToLookup, () => Linq.Enumerable.ToLookup(source, keySelector, comparer), source, options);
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to specified key selector and element selector functions.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains values of type TElement selected from the
        //     input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, ExtendLinqOptions options = null)
          => CodeWrapperUtility.WrapLinq(Event.ToLookup, () => Linq.Enumerable.ToLookup(source, keySelector, elementSelector), source, options);
        //
        // Summary:
        //     Creates a System.Linq.Lookup`2 from an System.Collections.Generic.IEnumerable`1
        //     according to a specified key selector function, a comparer and an element selector
        //     function.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to create a System.Linq.Lookup`2
        //     from.
        //
        //   keySelector:
        //     A function to extract a key from each element.
        //
        //   elementSelector:
        //     A transform function to produce a result element value from each element.
        //
        //   comparer:
        //     An System.Collections.Generic.IEqualityComparer`1 to compare keys.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        //   TKey:
        //     The type of the key returned by keySelector.
        //
        //   TElement:
        //     The type of the value returned by elementSelector.
        //
        // Returns:
        //     A System.Linq.Lookup`2 that contains values of type TElement selected from the
        //     input sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or keySelector or elementSelector is null.
        public static ILookup<TKey, TElement> ToLookup<TSource, TKey, TElement>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, ExtendLinqOptions options = null)
            => CodeWrapperUtility.WrapLinq(Event.ToLookup, () => Linq.Enumerable.ToLookup(source, keySelector, elementSelector, comparer), source, options);


        //
        // Summary:
        //     Returns the first element of a sequence.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the specified sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource First<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options = null)
                    => CodeWrapperUtility.WrapLinq(Event.First, () => Linq.Enumerable.First(source), source, options);

        //
        // Summary:
        //     Returns the first element in a sequence that satisfies a specified condition.
        //
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The first element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source sequence is
        //     empty.
        public static TSource First<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, ExtendLinqOptions options = null)
                 => CodeWrapperUtility.WrapLinq(Event.First, () => Linq.Enumerable.First(source, predicate), source, options);

        //
        // Summary:
        //     Returns the first element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     The System.Collections.Generic.IEnumerable`1 to return the first element of.
        //
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty; otherwise, the first element in source.
        //
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options = null)
                 => CodeWrapperUtility.WrapLinq(Event.FirstOrDefault, () => Linq.Enumerable.FirstOrDefault(source), source, options);
        //
        // Summary:
        //     Returns the first element of the sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if source is empty or if no element passes the test specified
        //     by predicate; otherwise, the first element in source that passes the test specified
        //     by predicate.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, ExtendLinqOptions options = null)
                 => CodeWrapperUtility.WrapLinq(Event.FirstOrDefault, () => Linq.Enumerable.FirstOrDefault(source, predicate), source, options);

        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a specified condition.
        //
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The last element in the sequence that passes the test in the specified predicate
        //     function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        //
        //   T:System.InvalidOperationException:
        //     No element satisfies the condition in predicate. -or- The source sequence is
        //     empty.
        public static TSource Last<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, ExtendLinqOptions options)
               => CodeWrapperUtility.WrapLinq(Event.Last, () => Linq.Enumerable.Last(source, predicate), source, options);
        //
        // Summary:
        //     Returns the last element of a sequence.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     The value at the last position in the source sequence.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        //
        //   T:System.InvalidOperationException:
        //     The source sequence is empty.
        public static TSource Last<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options)
               => CodeWrapperUtility.WrapLinq(Event.Last, () => Linq.Enumerable.Last(source), source, options);
        //
        // Summary:
        //     Returns the last element of a sequence, or a default value if the sequence contains
        //     no elements.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return the last element of.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the source sequence is empty; otherwise, the last element
        //     in the System.Collections.Generic.IEnumerable`1.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source is null.
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, ExtendLinqOptions options)
               => CodeWrapperUtility.WrapLinq(Event.LastOrDefault, () => Linq.Enumerable.LastOrDefault(source), source, options);
        //
        // Summary:
        //     Returns the last element of a sequence that satisfies a condition or a default
        //     value if no such element is found.
        //
        // Parameters:
        //   source:
        //     An System.Collections.Generic.IEnumerable`1 to return an element from.
        //
        //   predicate:
        //     A function to test each element for a condition.
        //
        // Type parameters:
        //   TSource:
        //     The type of the elements of source.
        //
        // Returns:
        //     default(TSource) if the sequence is empty or if no elements pass the test in
        //     the predicate function; otherwise, the last element that passes the test in the
        //     predicate function.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     source or predicate is null.
        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, ExtendLinqOptions options)
               => CodeWrapperUtility.WrapLinq(Event.LastOrDefault, () => Linq.Enumerable.LastOrDefault(source, predicate), source, options);
    }
}
