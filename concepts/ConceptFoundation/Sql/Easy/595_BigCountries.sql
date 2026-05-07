-- ═══════════════════════════════════════════════════
-- Problem   : #595 Big Countries
-- Difficulty: Easy
-- Concept   : WHERE with OR condition
-- Date      : Day 4
-- ───────────────────────────────────────────────────
-- Key Insight: either condition true — use OR
--              area >= 3000000 OR population >= 25000000
-- ═══════════════════════════════════════════════════




SELECT NAME, POPULATION, AREA FROM WORLD
WHERE POPULATION>=25000000 or AREA>=3000000