-- ═══════════════════════════════════════════════════
-- Problem   : #584 Find Customer Referee
-- Difficulty: Easy
-- Concept   : NULL handling — IS NULL
-- Date      : Day 4
-- ───────────────────────────────────────────────────
-- Key Insight: referee_id != 2 misses NULL rows
--              NULL compared with = returns UNKNOWN
--              UNKNOWN treated as FALSE in WHERE
--              Must explicitly add OR referee_id IS NULL
-- ═══════════════════════════════════════════════════

SELECT  NAME FROM CUSTOMER
WHERE  REFEREE_ID<>2 OR REFEREE_ID IS NULL