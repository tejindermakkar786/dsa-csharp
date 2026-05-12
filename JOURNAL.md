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


## Day 4 — SQL Basics
**Date:** 07-05-2026

---

### What I Learned — Block 1

**SQL is declarative.**
You say WHAT you want — not HOW to get it.
The database engine figures out execution.

**Execution Order — memorise this:**
```sql
FROM → WHERE → GROUP BY → HAVING → SELECT → ORDER BY
```
This is NOT the writing order. It is the order the database runs it.
Why it matters: you cannot use a SELECT alias in WHERE
because SELECT runs after WHERE.

**Key concepts covered:**

| Concept | Purpose | Example |
|---|---|---|
| SELECT | Choose columns to return | SELECT name, salary |
| WHERE | Filter rows before grouping | WHERE salary > 50000 |
| GROUP BY | Group rows for aggregation | GROUP BY department |
| HAVING | Filter groups after grouping | HAVING COUNT(*) > 3 |
| ORDER BY | Sort the result | ORDER BY salary DESC |
| COUNT DISTINCT | Count unique values | COUNT(DISTINCT user_id) |
| BETWEEN | Range filter inclusive | BETWEEN '2019-06-28' AND '2019-07-27' |

**WHERE vs HAVING:**
WHERE:  filters individual rows BEFORE grouping
cannot use aggregate functions
HAVING: filters groups AFTER grouping
can use aggregate functions

**NULL handling — critical insight:**
```sql
NULL = 2     → returns UNKNOWN → row excluded
NULL != 2    → returns UNKNOWN → row excluded
NULL IS NULL → returns TRUE    → row included
```
Rule: always add `OR column IS NULL` when excluding a value
      otherwise NULL rows are silently dropped.

**GROUP BY rule:**
Ask before writing GROUP BY: what do I want ONE ROW per?
Only put columns in GROUP BY that define the groups you want.
Extra columns make groups too granular — wrong result.

---

### What I Built — Block 2

Wrote basic SQL queries on DB Fiddle against sample Employees data:

```sql
-- Basic SELECT
SELECT Name, Salary FROM Employees;

-- WHERE filter
SELECT Name FROM Employees WHERE Salary > 70000;

-- ORDER BY descending
SELECT Name, Salary FROM Employees ORDER BY Salary DESC;

-- GROUP BY with COUNT
SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees GROUP BY Department;

-- HAVING — filter after grouping
SELECT Department, COUNT(*) AS EmployeeCount
FROM Employees
GROUP BY Department
HAVING COUNT(*) > 2;

-- WHERE vs HAVING together
SELECT Department, AVG(Salary) AS AvgSalary
FROM Employees
WHERE HireDate > '2019-01-01'
GROUP BY Department
HAVING AVG(Salary) > 60000;
```

---

### What I Practiced — Block 3

**5 LeetCode Easy SQL problems solved:**

| # | Problem | Concept | Key Insight |
|---|---|---|---|
| #1757 | Recyclable and Low Fat Products | WHERE AND | Both conditions must be true |
| #595 | Big Countries | WHERE OR | Either condition true |
| #584 | Find Customer Referee | NULL handling | Must add IS NULL explicitly |
| #1141 | User Activity Past 30 Days | GROUP BY + COUNT DISTINCT | GROUP BY date only — not session |
| #620 | Not Boring Movies | WHERE + modulo + ORDER BY | id % 2 = 1 for odd ids |

**Solutions pushed to:** `dsa-csharp/sql/easy/`

---

### Freeze Moment — #1141 User Activity

**What froze me:**
Added `session_id` to GROUP BY alongside `activity_date`.

**Why it was wrong:**
Adding session_id created one group per session per day.
Instead of one row per day — got one row per session.
COUNT became 1 for every row instead of total users per day.

**The fix:**
```sql
-- WRONG — too granular
GROUP BY activity_date, session_id

-- CORRECT — one row per day
GROUP BY activity_date
```

**The rule I learned:**
Ask: what do I want one row per?
One row per day → GROUP BY activity_date only.
COUNT(DISTINCT user_id) handles multiple users within each day.
session_id was in the table but not needed to define the groups.

**This mistake happens because:**
Seeing a column in the table makes you think it belongs in GROUP BY.
It does not. Only columns that define your groups belong there.

---

### What Clicked
- Execution order explains why WHERE cannot use SELECT aliases
- NULL compared with = or != always returns UNKNOWN not FALSE
- GROUP BY only needs columns that define what one row represents
- COUNT(DISTINCT col) counts unique values within each group
- BETWEEN is inclusive on both ends

### What Is Still Unclear
- Nothing major — concepts clear today
- Will deepen GROUP BY understanding as problems get harder

### Freeze Moments
1 — GROUP BY on #1141 — added session_id incorrectly
    Understood why after tracing the grouping logic
    Will not make this mistake again

### Day 5 — Encapsulation in C#

---

### What I Learned — Block 1

**What is Encapsulation?**
A way of protecting a class's internal members.
Controls what external sources can access and modify.
Gives full control over input and output of a class.

**Field vs Property:**

| | Field | Property |
|---|---|---|
| What it is | Variable declared inside class | Getter and setter wrapper |
| Validation | Cannot add validation | Can validate before get/set |
| Access control | Limited | Full control |
| Usage | Used inside properties | Exposed to outside safely |

```csharp
private decimal _balance;        // field — hidden
public decimal Balance           // property — controlled access
{
    get => _balance;
    set
    {
        if (value < 0) throw new ArgumentException("Cannot be negative");
        _balance = value;
    }
}
```

**What does private mean?**
Setting access to private means only members of that same class
can access it. Nothing from outside the class can read or modify it.

**Why hide internal state?**
To protect the integrity of data and maintain full control over it.

Real example:
Without encapsulation:
Anyone can set balance = -99999 directly
No validation possible
Data integrity broken
With encapsulation:
Balance only changes through Deposit() and Withdraw()
Both methods validate before changing state
Invalid operations are rejected

---

### What I Built — Block 2
`concepts/ConceptFoundation/OOP/Encapsulation.cs`

- BankAccount class with private _balance field
- Read-only Balance property — get only, no setter
- Deposit() method — validates amount > 0 before adding
- Withdraw() method — validates amount <= balance before deducting
- Verified: setting balance directly from outside does not compile

---

### What I Practiced — Block 3

**StudentGrade class built and tested:**
- Name set only in constructor — cannot change after
- Private grades list — outside code cannot add directly
- AddGrade() validates grade is between 0 and 100
- Average property calculates from private list — read only
- Tested: tried to corrupt data from outside — every attempt failed

**Prime numbers up to N — brute force O(n²):**

Bug found during practice:
Wrong: for (int j = 2; j <= result; j++)
Right: for (int j = 2; j < i; j++)

Why j < i is correct:
A number larger than i can never divide i.
Checking beyond i is wasted work.
Asked the question: at what point does the inner loop
become pointless? Answer: when j reaches i.

There was some freezing while writing the solution.
Fix: asked "does this inner loop need to go all the way?"
That question revealed j < i without any hints.

---

### What Clicked
- Field stores data, property controls access to that data
- Private means class-only access — compiler enforces this
- Encapsulation is not just hiding data — it is protecting integrity
- Inner loop limits deserve a question: does it need to go all the way?

### What Is Still Unclear
- Nothing unclear today — all concepts clicked

### Freeze Moments
1 — Prime numbers inner loop condition
    Wrote j <= result instead of j < i
    Resolved by asking: can j ever divide i when j > i?
    Answer: no — so j < i is the correct limit

---

## Day 6 — Saturday Build Day + First Contest Problem
**Date:** 09-05-2026

---

### What I Built — StudentRecordSystem

Built a complete console application combining everything from Week 1:

**Classes built:**
- `Student` — encapsulated class controlling its own data
- `StudentRepository` — Dictionary-based storage with O(1) lookup
- `Program` — console menu with full input validation

**Console menu:**

Add Student     → asks for ID and name
Add Grade       → asks for student ID and grade (0-100)
View Student    → shows name, all grades, average
View Top 3      → shows top 3 students by average
Exit


---

### Bugs Found and Fixed

| # | Bug | Fix |
|---|---|---|
| 1 | Grades list not encapsulated — anyone could add or clear directly | Made list private and readonly, exposed as IReadOnlyList |
| 2 | Take(n) before OrderBy — picked random students not top students | Moved OrderByDescending before Take |
| 3 | Typo in Average property name — Avergae | Fixed to Average |
| 4 | Unnecessary Student class field at repository level | Removed — used local variables inside methods instead |
| 5 | Average stored as settable property — could go out of sync | Replaced with calculated property using LINQ Average() |

**Key learning from bugs:**
private set on List<int> does NOT protect the list contents.
Anyone can still call .Add() or .Clear() on it.
IReadOnlyList is the correct way to expose a list safely.
LINQ order matters:
Wrong:   Take(n) → OrderBy   — sorts only the randomly picked n
Correct: OrderBy → Take(n)   — sorts all, then picks top n

---

### What This Project Demonstrates
Encapsulation:
Name       — set in constructor only, no setter
_grades    — private, only AddGrade() can modify
Average    — calculated property, no setter, always accurate
Grades     — IReadOnlyList, readable but not modifiable externally
Dictionary O(1):
AddStudent  — validates duplicate ID before adding
AddGrade    — TryGetValue to find student in O(1)
GetStudent  — TryGetValue with not found handling
Separation of responsibility:
Student     — owns and protects its own data
Repository  — stores and finds students
Program     — handles user interaction only

---

### First LeetCode Contest Problem
**Contest:** Weekly Contest 500 (virtual)
**Problem:** Sum of Primes Between Number and Its Reverse
**Time taken:** 40 minutes
**Result:** Solved independently

**Patterns combined:**

| Pattern | Source |
|---|---|
| Reverse number | Pre-plan exercise |
| Prime check | Pre-plan exercise |
| Range sum accumulator | Pre-plan exercise |

**Key insight:**
Contest problems combine patterns you already know.
Not new concepts — new combinations of existing patterns.

**Complexity:**
Current:   O(range * maxValue)   — inner loop runs up to i
Optimised: O(range * √maxValue)  — inner loop runs up to √i

**Bugs caught during review:**
n < 2 better than n == 1 — handles 0 and 1 both
Console.WriteLine removed from helper method — not needed in contest code
Math.Sqrt optimisation identified — will apply from Week 3

---

### What Clicked
- IReadOnlyList is the correct encapsulation for exposing a list
- LINQ order is critical — OrderBy must always come before Take
- Contest problems are combinations of patterns already known
- 40 minutes on Day 7 — target is under 20 minutes by Month 3

### Freeze Moments
None today — built and debugged independently.

### Day 7 (Sunday)
Re-solve all 9 programs from memory — target under 50 minutes total.
Week 1 JOURNAL review — freeze count, what clicked, what is still unclear.
StudentRecordSystem README push.
Preview Week 2: HashSet, Two Pointers, Two Sum, SQL JOINs, Inheritance.

## Day 8 — HashSet in C#
**Date:** 11-05-2026

---

### What I Learned

**HashSet vs Dictionary:**

| | HashSet | Dictionary |
|---|---|---|
| Stores | Keys only | Key-value pairs |
| Duplicate keys | Ignored silently | Overwrites existing |
| Use when | Existence check, uniqueness | Key-based value lookup |
| Lookup | O(1) | O(1) |

Both use hash table internally. Both O(1) for add, remove, lookup.

**When to use HashSet:** checking existence, removing duplicates, tracking seen elements.
**When to use Dictionary:** storing data with meaningful key, frequency counting, key-value mapping.

---

### Practiced — LeetCode #217 Contains Duplicate

**Key insight — Add() instead of Contains():**
```csharp
// Contains() + Add() = 2 operations
// Add() alone = 1 operation — returns false if duplicate
if (!hashset.Add(num)) return true;
```
`Time: O(n) | Space: O(n)`

---

### Extra Discoveries

**Object equality — reference vs value:**
HashSet uses Equals() to compare. Default compares memory address.
Two objects with same data = different addresses = both added.
Fix: override Equals() AND GetHashCode() together.
Rule: always override both — never one without the other.

**Case sensitivity:**
"Apple" and "apple" treated as different by default.
Fix: `new HashSet<string>(StringComparer.OrdinalIgnoreCase)`

---

### What Clicked
- Add() return value tells you if duplicate was found
- Default object equality is reference-based not value-based
- Always override Equals AND GetHashCode together
- StringComparer handles case sensitivity at construction time

### Freeze Moments
None.

### Tomorrow — Day 9
Two Pointers pattern — first DSA pattern.
Two index variables replace nested loops — O(n²) → O(n).