-- ═══════════════════════════════════════════════════
-- Problem   : #1757 Recyclable and Low Fat Products
-- Difficulty: Easy
-- Concept   : WHERE with AND condition
-- Date      : Day 4
-- ───────────────────────────────────────────────────
-- Time      : O(n) — scans all rows once
-- ───────────────────────────────────────────────────
-- Key Insight: both conditions must be true — use AND
-- ═══════════════════════════════════════════════════


SELECT PRODUCT_ID FROM PRODUCTS
WHERE LOW_FATS='Y' AND RECYCLABLE='Y'