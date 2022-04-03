# ShapeCalculator
 Sample shape area calculator with tests

# Task 2
Item can have many categories.

Category can have many items in it.

Query to get All pairs Item-Category(even if Item has no categories).
```sql
SELECT Items.name, itemCatwithCatNamed.name
FROM Items
LEFT JOIN (SELECT * FROM Categories JOIN ItemCategoriesLinks ON idCategory = catId) itemCatWithCatNamed
ON itemId = idItem
```
