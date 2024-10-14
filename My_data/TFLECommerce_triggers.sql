-- created database tflecommerce.
use tflecommerce;

-- triggers
-- 1. Trigger to Update Stock After an Order is Placed
-- 2. Trigger to Prevent Deletion of a Product with Existing Orders
-- 3. Trigger to Automatically Set Order Status to 'Shipped' After Shipping Date is Updated
-- 4. Trigger to Log Changes to Product Prices
-- 5. Trigger to Automatically Apply Discount to Orders Over a Certain Amount
-- 6. Trigger to Update the Last Modified Date on Product Changes
-- 7. Trigger to Archive Orders Before Deletion
-- 8. Trigger to Validate User Email Format
-- 9. Trigger to Prevent Orders from Being Placed on Closed Dates
-- 10. Trigger to Automatically Update User Points Based on Order Total

-- 1. Trigger to Update Stock After an Order is Placed
DELIMITER //

CREATE TRIGGER after_order_insert
AFTER INSERT ON orders
FOR EACH ROW
BEGIN
    -- Update stock for each item in the order
    UPDATE products p
    JOIN order_items oi ON p.id = oi.item_id
    SET p.stock = p.stock - oi.quantity
    WHERE oi.order_id = NEW.id;
END//

DELIMITER ;

