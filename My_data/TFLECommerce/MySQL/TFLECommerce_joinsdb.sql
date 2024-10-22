---- JOIN Queries ----

-- 1. Inner Join: Retrieve Orders with Their Items and Product Details
-- 2. Left Join: Retrieve All Products and Their Categories
-- 3.Right Join: Retrieve All Categories and Products in Each Category
-- 4. Full Outer Join: Retrieve All Products and Reviews, Even If Some Products Have No Reviews
-- 5. Self Join: Retrieve Products and Their Similar Products Based on Category
-- 6. Join with Aggregation: Retrieve Total Sales Per Product
-- 7. Join with Filtering: Retrieve Orders for a Specific User with Item Details
-- 8. Join with Subquery: Retrieve Users Who Have Purchased Products in a Specific Category
-- 9. Complex Join: Retrieve Orders with Product Details and Discount Information
-- 10. Join for Data Consistency: Retrieve Orders and Verify Product Availability
-- 11. Join to Retrieve High-Rated Products with Their Categories
-- 12. Join to Get Users and Their Recent Orders





-- 1. Retrieve Orders with Shipping Address and User Information
-- 2. List Products with Their Latest Review
-- 3. Retrieve Orders with Items and Calculate Total Price for Each Order
-- 4. Find Products That Are Out of Stock and Their Categories
-- 5. Retrieve Users Who Have Left Reviews for Products
-- 6. List Categories and the Number of Products in Each
-- 7. Retrieve Orders with Products and Check for Discounts Applied
-- 8. Get Users and Their Total Spending
-- 9. Retrieve Products with Reviews and Average Rating
-- 10. Find Orders Placed by Users with a Specific Email Domain
-- 11. List Products and the Number of Times They Have Been Ordered
-- 12. Get Orders and Their Shipping Status Based on Product Availability
-- 13. Find Users Who Have Not Purchased Any Products
-- 14. Retrieve All Orders and Check If Any Discount Code Was Used
-- 15. List Products with Their Average Review Rating and Number of Review
-- 16. Retrieve Orders and Their Shipping Address for Users in a Specific City
-- 17. Get Total Revenue from Each Category
-- 18. List Orders and Their Associated Review Ratings
-- 19. Find Most Frequently Purchased Products


------ JOIN QUERIES -------

-- 1. Inner Join: Retrieve Orders with Their Items and Product Details
SELECT o.id AS order_id, o.order_date, p.name AS product_name, oi.quantity, p.price, (oi.quantity * p.price) AS total_price
FROM orders o
JOIN order_items oi ON o.id = oi.order_id
JOIN products p ON oi.item_id = p.id;

-- 2. Left Join: Retrieve All Products and Their Categories
SELECT p.id AS product_id, p.name AS product_name, c.name AS category_name
FROM products p
LEFT JOIN categories c ON p.category_id = c.id;

 -- 3.Right Join: Retrieve All Categories and Products in Each Category
SELECT c.id AS category_id, c.name AS category_name, p.name AS product_name
FROM categories c
RIGHT JOIN products p ON c.id = p.category_id;

-- 5. Self Join: Retrieve Products and Their Similar Products Based on Category
SELECT p1.id AS product_id, p1.name AS product_name, p2.name AS similar_product_name
FROM products p1
JOIN products p2 ON p1.category_id = p2.category_id AND p1.id <> p2.id;

