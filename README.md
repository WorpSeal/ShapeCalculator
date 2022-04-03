# ShapeCalculator
 Sample shape area calculator with tests

# Task 2
Item can have many categories
Category can have many items in it
Query to get All pairs Item-Category(even if Item has no categories)
select Items.name, itemCatwithCatNamed.name
from Items
left join (select * from Categories join ItemCategoriesLinks on idCategory = catId) itemCatwithCatNamed
on itemId = idItem
