-- ═══════════════════════════════════════════════════
-- Problem   : #1141 User Activity for Past 30 Days
-- Difficulty: Easy
-- Concept   : GROUP BY with COUNT DISTINCT + BETWEEN
-- Date      : Day 4
-- ───────────────────────────────────────────────────
-- Key Insight: GROUP BY only the column that defines groups
--              "one row per day" → GROUP BY activity_date only
--              COUNT(DISTINCT user_id) handles multiple users
--              Do NOT add session_id to GROUP BY — too granular
-- Mistake made: added session_id to GROUP BY initially
--               creates one group per session instead of per day
-- ═══════════════════════════════════════════════════


SELECT ACTIVITY_DATE AS DAY,COUNT(DISTINCT USER_ID) AS ACTIVE_USERS FROM ACTIVITY
WHERE ACTIVITY_DATE BETWEEN '2019-06-28' AND '2019-07-27'
GROUP BY ACTIVITY_DATE