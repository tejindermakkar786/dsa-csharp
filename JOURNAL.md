## Day 1 — Big O Notation + Arrays
**Date:** 01-05-2026

### Concepts Covered
| Concept | Understanding |
|---|---|
| O(1) | Direct memory jump using `base_address + (index * bytes)` |
| O(n) | Single loop — operations grow with input |
| O(n²) | Nested loops on same input |
| O(log n) | Halves problem each step — Binary Search (Week 3) |
| O(d) | Loop runs once per digit — Reverse, Sum of Digits |
| O(n*m) | Two loops on different sized inputs |

**Key Insight:** Big O always measures worst case.
Index access is O(1) because the address is mathematically calculable.
Search is O(n) because there is no address to jump to.

**Space Complexity Rule:**
Single variables = O(1). New array = O(n). Ask: does it grow with input?

**Edge Case Rule:**
Always check empty input before accessing index 0.

**Bug Found:** For loop update runs AFTER body.
Variables modified in body are seen by update expression.
Fix: use while loop for value-based stopping conditions.

### Built
- `BigONotation.cs` — O(1) O(n) O(n²) examples with complexity labels
- `ArrayBasics.cs` — find largest, empty array edge case

### Practiced
Find largest number in array.
`Time: O(n) | Space: O(1)`

### Pre-Plan Exercises Completed (7 programs, all under 5 mins from memory)

| # | Program | Pattern | Time | Space |
|---|---|---|---|---|
| 1 | Fibonacci | Variable rotation | O(n) | O(1) |
| 2 | Factorial | Accumulator | O(n) | O(1) |
| 3 | Reverse Number | Mod + divide + build | O(d) | O(1) |
| 4 | Prime Check | Boolean flag + break | O(n) | O(1) |
| 5 | FizzBuzz | Specific condition first | O(n) | O(1) |
| 6 | Sum of Digits | Mod + divide + add | O(d) | O(1) |
| 7 | Palindrome | Reverse + compare | O(d) | O(1) |

**Freeze Moments:** 0

---

## Day 2 — Strings in C#
**Date:** 02-05-2026

### Concepts Covered

**String = char array underneath.**
`"hello"[0]` is `'h'` — all array thinking applies.

| Operation | Method | Complexity |
|---|---|---|
| Access character | `str[i]` | O(1) |
| Convert to mutable | `ToCharArray()` | O(n) time + O(n) space |
| Convert back | `new string(chars)` | O(n) |
| Case conversion | `char.ToLower(c)` | O(1) per char |
| Iterate without array | `foreach (char c in str)` | O(n) time, O(1) space |

**Immutability:**
Strings cannot be modified in place. `word[0] = 'H'` does not compile.
Modification creates a new string object in memory.
Pattern: `ToCharArray()` → modify → `new string(chars)`.

**Hidden Space Cost:**
`ToCharArray()` creates new array same size as string → O(n) space.
Iterating directly on string → O(1) space.
Rule: only use `ToCharArray()` when modification is needed.

### Built
- `StringBasics.cs` — immutability demo, ToLower, ToUpper, ToCharArray

### Practiced — Vowel Count (3 versions)

| Version | Approach | Time | Space |
|---|---|---|---|
| Contains | `vowels.Contains(c)` | O(n*m) | O(1) |
| if/else + ToLower | Direct comparisons | O(n) | O(1) |
| Nested loop + break | Manual Contains | O(n*10)=O(n) | O(1) |
| Best version | foreach on string directly | O(n) | O(1) |

**Key Insight:** `Contains()` hides a loop inside it.
`O(n*m)` when m is variable. `O(n)` when m is fixed constant.

**Freeze Moments:** 0

---

## Day 3 — Dictionary (HashMap) in C#
**Date:** [add date]

### Concepts Covered

**What is a Dictionary?**
Stores key-value pairs. Key chosen by developer — always known at lookup time.
That is why Dictionary is practically O(1) in real problems.

| Operation | Method | Complexity |
|---|---|---|
| Add or update | `dict[key] = value` | O(1) |
| Check existence | `ContainsKey(key)` | O(1) |
| Check + get value | `TryGetValue(key, out val)` | O(1) — one operation |
| Get or default | `GetValueOrDefault(key)` | O(1) — returns 0/null if missing |
| Remove | `dict.Remove(key)` | O(1) |
| Iterate | `foreach (var kv in dict)` | O(n) |

**Why O(1)?**
Hashing converts key to a number → maps to memory address → direct jump.
Same concept as array: `base_address + (index * bytes)`.

**O(1) only when key is known:**
Array:      O(1) access if you know the index
Dictionary: O(1) access if you know the key
Both:       O(n) search if you do not know where to look

**TryGetValue vs ContainsKey:**
ContainsKey + access = 2 lookups
TryGetValue          = 1 lookup (check + retrieve in one step)
Always prefer TryGetValue when you need the value too.

**GetValueOrDefault:**
Returns default value of type if key missing.
`int` → returns 0. `string` → returns null.

### Built
- `DictionaryBasics.cs` — all operations with complexity labels

### Practiced — Word Frequency Counter (2 versions)

**Version 1 — Dictionary (optimal)**
```csharp
if (fc.TryGetValue(word, out int count))
    fc[word] = count + 1;
else
    fc[word] = 1;
```
`Time: O(n) | Space: O(n)`

**Version 2 — List (brute force)**
```csharp
int idx = list.FindIndex(a => a.Fruit == word);
if (idx != -1) list[idx].Count++;
else list.Add(new FruitsCounter { Fruit = word, Count = 1 });
```
`Time: O(n²) worst case | Space: O(n)`

**FindIndex is O(m) because:**
It hides a loop that scans the list from start to end.
As unique words grow toward n — O(n * m) → O(n²) worst case.

| | Dictionary | List |
|---|---|---|
| Time | O(n) | O(n²) worst case |
| Space | O(n) | O(n) |
| Interview choice | Optimal | Brute force |

**Trade-off discovered:**
Using extra memory (Dictionary) → faster time (O(n) not O(n²)).
This space-for-time trade is the most common pattern in DSA.

**Case Analysis — Bug Found and Fixed:**
Prime check bug: `if (number % i != 0) break` — wrong.
One non-divisor does not prove prime. ALL must fail.
Fix: break only when `% i == 0` (divisor found).

**3 questions to catch bugs before testing:**
1. What case clearly works?
2. What case might break?
3. What is the opposite of my assumption?

**Complexity Calculation — 4 steps:**
1. Find every loop — count iterations
2. Find every method — check for hidden loops
3. Multiply nested, add separate
4. Keep dominant term, drop constants

### Sorting Covered
**Bubble Sort** — written and understood.
`Time: O(n²) | Space: O(1)`
Applied to string character sorting.
`i` = pass number. `j` stops at `n-1-pass` — sorted zone grows right to left.
Early exit optimisation: break if no swaps in a pass.

**Why not use Bubble Sort in production:**
For 1M elements — Bubble Sort needs ~500B operations.
Merge Sort needs ~20M. No comparison.

**Freeze Moments:** 0

---

## Revision Session — Between Day 3 and Day 4
All 8 programs written from memory in under 5 minutes each.

| Program | Time | Notes |
|---|---|---|
| Fibonacci | < 5 mins | Variable rotation locked in |
| Factorial | < 5 mins | Accumulator pattern solid |
| Reverse Number | < 5 mins | mod + divide + build instinctive |
| Prime Check | < 5 mins | Boolean flag + break correct |
| FizzBuzz | < 5 mins | Specific before general — automatic |
| Sum of Digits | < 5 mins | Same tools as reverse, different operation |
| Palindrome | < 5 mins | Combines reverse + comparison |
| Vowel Count | < 5 mins | ToLower + foreach on string directly |

**Observation:** One week ago Fibonacci took 2 hours.
Today all 8 done in under 40 minutes total from memory.
This is not memorisation — verified by adapting each program
to a variation never seen before (consonants, even digits only, all primes to N).
The patterns are owned, not remembered.

---

## Commitments
- Minimum viable day: 45 minutes — never zero
- Re-solve yesterday's program every morning before new content
- Push to GitHub every single day — no exceptions
- 5 inputs tested before every push
- Complexity written in every comment block