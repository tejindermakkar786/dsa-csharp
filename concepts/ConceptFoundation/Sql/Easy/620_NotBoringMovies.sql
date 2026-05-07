-- ═══════════════════════════════════════════════════
-- Problem   : #620 Not Boring Movies
-- Difficulty: Easy
-- Concept   : WHERE with modulo for odd check
-- Date      : Day 4
-- ───────────────────────────────────────────────────
-- Key Insight: odd id means id % 2 = 1
--              combine with description != 'boring'
--              ORDER BY rating DESC for highest first
-- ═══════════════════════════════════════════════════


SELECT * FROM CINEMA
WHERE ID%2<>0 AND DESCRIPTION!='boring'
ORDER BY RATING DESC