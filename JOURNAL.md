# 180 Day MAANG Preparation Journal

---

## Day 1 — Arrays + Big O Notation
**Date:** 01-05-2026

---

### What I Learned

**Big O Notation**
Time complexity measures how many operations a program
performs as input size grows. Big O always measures worst case.

| Notation | Name | When |
|---|---|---|
| O(1) | Constant | Direct access, no loop |
| O(n) | Linear | Single loop through input |
| O(n²) | Quadratic | Loop inside a loop on same input |
| O(log n) | Logarithmic | Halves problem each step |
| O(d) | Digits | Loop runs once per digit |
| O(n*m) | Two different inputs | Two loops on different sized inputs |

**Why index access is O(1) but search is O(n):**
Index access uses formula: `base_address + (index * bytes)`
Jumps directly to memory address. One operation always.
Search has no address to jump to. Must check every element.

**Space Complexity:**
Measures extra memory created that grows with input.
Single variables = O(1). New array same size as input = O(n).
Ask: did I create anything that grows with input size?

**Arrays:**
Contiguous block of memory. Each element at a fixed address.
That is why index access is O(1).

**Edge Cases:**
Always check empty input before accessing index 0.
Empty array does not remove complexity — loop just runs 0 times.

**For Loop Update Timing:**
Update runs AFTER the loop body.
If body modifies variables that update uses — update sees new values.
Rule: use for loop for fixed count. Use while loop for value condition.

---

### What I Built — Block 2
`concepts/ConceptFoundation/BigO/BigONotation.cs`
`concepts/ConceptFoundation/Arrays/ArrayBasics.cs`

- O(1), O(n), O(n²) examples in code
- Find largest number — O(n) time O(1) space
- Empty array edge case handled

---

### What I Practiced — Block 3
Find the largest number in an array.
Time: O(n) — one pass. Space: O(1) — one tracker variable.

---

### Pre-Plan Exercises — Completed Before Day 1

| # | Exercise | Pattern | Time | Space |
|---|---|---|---|---|
| 1 | Fibonacci | Variable rotation | O(n) | O(1) |
| 2 | Factorial | Accumulator | O(n) | O(1) |
| 3 | Reverse Number | Mod + divide + build | O(d) | O(1) |
| 4 | Prime Check | Boolean flag + break | O(n) | O(1) |
| 5 | FizzBuzz | Specific condition first | O(n) | O(1) |
| 6 | Sum of Digits | Mod + divide + add | O(d) | O(1) |
| 7 | Palindrome | Reverse + compare | O(d) | O(1) |

---

### What Clicked
- Memory address formula explains why O(1) access works
- Big O measures worst case not best case
- O(d) is same idea as O(n) — different letter for clarity
- For loop update runs after body — can cause timing bugs

### What Is Still Unclear
- O(log n) — concept understood, will feel it properly
  when Binary Search arrives Week 3

### Freeze Moments
None today.

---

## Day 2 — Strings in C#
**Date:** 02-05-2026

---

### What I Learned

**String basics:**
A string is an array of characters underneath.
`"hello"[0]` is `'h'` — same as array index access.
That is why all array thinking applies to strings.

**How to access the 3rd character of a string:**
Two ways:

```csharp
// Way 1 — direct index access (immutable)
char c = str[2];

// Way 2 — convert to char array first (mutable)
char[] chars = str.ToCharArray();
char c = chars[2];
chars[2] = 'X'; // now you can modify it
```

Key difference: direct index access keeps the string immutable.
ToCharArray creates a new mutable char array you can modify.

**What does ToCharArray() return?**
Returns a new `char[]` containing every character of the string.
The array is independent — modifying it does not change the original string.

**What does ToLower() do and why is it used in problems?**
Converts all characters to lowercase.
Used in problems when comparing characters regardless of case.
Instead of checking both `'A'` and `'a'` — convert first, check once.

```csharp
char lower = char.ToLower(c);
// now only need to check lowercase version
```

**String immutability — why can you not do word[0] = 'H'?**
When a string is assigned — it gets a fixed memory address.
Any modification does not change the original string.
C# creates a new string object in memory instead.
This is why `word[0] = 'H'` does not compile — strings are read-only.

To modify characters: convert to `char[]` with `ToCharArray()`,
modify the array, then convert back with `new string(chars)`.

```csharp
string word = "hello";
char[] chars = word.ToCharArray();
chars[0] = 'H';
string modified = new string(chars); // "Hello"
// word is still "hello" — unchanged
```

---

### What I Built — Block 2
`concepts/ConceptFoundation/Strings/StringBasics.cs`

- Accessed characters using direct index and ToCharArray
- Demonstrated immutability — original string unchanged after modification
- Used ToLower, ToUpper, Contains, Length
- Converted char array back to string using new string(chars)

---

### What I Practiced — Block 3
**Count vowels in a string — written 3 versions**

**Version 1 — Contains (original)**
```csharp
string vowels = "aeiouAEIOU";
if (vowels.Contains(userInput[i])) count++;
```
Time: O(n * m) — n = sentence length, m = vowels string length (10)
Contains hides an internal loop searching through vowels string.

**Version 2 — if/else with ToLower**
```csharp
char lower = char.ToLower(userInput[i]);
if (lower == 'a' || lower == 'e' || lower == 'i' ||
    lower == 'o' || lower == 'u') count++;
```
Time: O(n * 5) → constant ignored → O(n)
No hidden loop. Direct comparisons only. ToLower reduces 10 conditions to 5.

**Version 3 — Manual nested loop**
```csharp
for (int j = 0; j < 10; j++) {
    if (vowels[j] == userInput[i]) {
        count++;
        break; // stop after first match
    }
}
```
Time: O(n * 10) → constant ignored → O(n)
Makes the hidden Contains loop explicit and visible.
break added — stops checking once a match is found.

**Complexity comparison:**

| Version | Raw complexity | Simplified |
|---|---|---|
| Contains | O(n * m) | O(n * 10) = O(n) here because m=10 is fixed |
| if/else | O(n * 5) | O(n) |
| Nested loop | O(n * 10) | O(n) |

**Key insight discovered:**
If BOTH loops run on the same input size → O(n²)
If loops run on DIFFERENT input sizes → O(n * m)
In all 3 versions the inner part runs on a fixed size (10 or 5)
so constants are ignored and all three are effectively O(n).

---

### What Clicked
- String is just a char array — same mental model as arrays
- Immutability means modification creates new object in memory
- ToCharArray pattern: convert → modify → convert back
- Contains hides a loop — O(n*m) not O(n)
- When inner loop is fixed size — constant is ignored → O(n)
- O(n²) only when BOTH loops grow with the same input size

### What Is Still Unclear
- Nothing unclear today — all concepts clicked

### Freeze Moments
None today.

### Tomorrow — Day 3
Dictionary in C#.
Going in knowing: Dictionary gives O(1) lookup by key.
This is the data structure that makes Two Sum O(n) instead of O(n²).