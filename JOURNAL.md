## Day 1 — Arrays + Big O Notation
**Date:** [add your date]

---

### What I Learned

**Big O Notation**
Time complexity measures how many operations a program
performs as input size grows. Big O always measures worst case.

| Notation | Name | When |
|---|---|---|
| O(1) | Constant | Direct access, no loop |
| O(n) | Linear | Single loop through input |
| O(n²) | Quadratic | Loop inside a loop |
| O(log n) | Logarithmic | Halves problem each step |
| O(d) | Digits | Loop runs once per digit |

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
- O(log n) — concept understood, will feel it when Binary Search arrives Week 3

### Freeze Moments
None today.