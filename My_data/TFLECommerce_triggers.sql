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

CREATE TRIGGER after_order_items_insert
AFTER INSERT ON order_items
FOR EACH ROW
BEGIN
    -- Update stock for each item in the order
    UPDATE products p
    JOIN order_items oi ON p.id = oi.item_id
    SET p.stock = p.stock - NEW.quantity
    WHERE p.id= NEW.item_id;
END//

DELIMITER ;

-- 2. Trigger to Prevent Deletion of a Product with Existing Orders

DELIMITER //

CREATE TRIGGER before_product_delete
BEFORE DELETE ON products
FOR EACH ROW
BEGIN
    -- Check if the product is present in any order
    IF EXISTS (
        SELECT 1
        FROM order_items oi
        WHERE oi.item_id = OLD.id
    ) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Cannot delete product with existing orders.';
    END IF;
END//

DELIMITER ;

-- 3. Trigger to Automatically Set Order Status to 'Shipped' After Shipping Date is Updated

DELIMITER //

CREATE TRIGGER after_shipping_date_update
AFTER UPDATE ON orders
FOR EACH ROW
BEGIN
    -- Update order status if the shipping date is set
    IF NEW.shipping_date IS NOT NULL AND OLD.shipping_date IS NULL THEN
        UPDATE orders
        SET status = 'Shipped'
        WHERE id = NEW.id;
    END IF;
END//

DELIMITER ;


-- 4. Trigger to Log Changes to Product Prices

DELIMITER //

CREATE TRIGGER after_product_price_update
AFTER UPDATE ON products
FOR EACH ROW
BEGIN
    -- Insert a record into the price_changes table
    INSERT INTO price_changes (product_id, old_price, new_price, change_date)
    VALUES (OLD.id, OLD.price, NEW.price, NOW());
END//

DELIMITER ;


UPDATE products
SET price = 733.99
WHERE id = 1;

SELECT * FROM price_changes
WHERE product_id = 1
ORDER BY change_date DESC;


-- 5. Trigger to Automatically Apply Discount to Orders Over a Certain Amount

DELIMITER //

CREATE TRIGGER before_order_insert
BEFORE INSERT ON orders
FOR EACH ROW
BEGIN
    -- Apply discount if order total exceeds 1000
    IF NEW.total_amount > 1000 THEN
        SET NEW.total_amount = NEW.total_amount * 0.9; -- Apply 10% discount
    END IF;
END//

DELIMITER ;


-- 6. Trigger to Update the Last Modified Date on Product Changes

DELIMITER //

CREATE TRIGGER before_product_update
BEFORE UPDATE ON products
FOR EACH ROW
BEGIN
    -- Set the last_modified field to the current timestamp
		SET NEW.last_modified = NOW();
END//

DELIMITER ;

-- 7. Trigger to Archive Orders Before Deletion

DELIMITER //

CREATE TRIGGER before_order_delete
BEFORE DELETE ON orders
FOR EACH ROW
BEGIN
    -- Insert the order into the archieved_orders table
    INSERT INTO archieved_orders (order_date, customer_id, total_amount, status)
    VALUES (OLD.order_date, OLD.customer_id, OLD.total_amount, OLD.status);
END//

DELIMITER ;

-- -----------------------------------need to discuss with sir on this archieved_orders table. --
-- drop trigger before_order_delete;

-- 8. Trigger to Validate User Email Format

DELIMITER //

CREATE TRIGGER before_user_insert
BEFORE INSERT ON users
FOR EACH ROW
BEGIN
    -- Check if email contains '@' and '.'
    IF NEW.email NOT REGEXP '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Invalid email format.';
    END IF;
END//

DELIMITER ;


DELIMITER //

CREATE TRIGGER before_user_update
BEFORE UPDATE ON users
FOR EACH ROW
BEGIN
    -- Check if email contains '@' and '.'
    IF NEW.email NOT REGEXP '^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Invalid email format.';
    END IF;
END//

DELIMITER ;

-- 9. Trigger to Prevent Orders from Being Placed on Closed Dates

DELIMITER //

CREATE TRIGGER prevent_order_insert
BEFORE INSERT ON orders
FOR EACH ROW
BEGIN
    -- Assuming store closed dates are stored in a `closed_dates` table
    IF EXISTS (
        SELECT 1
        FROM closed_dates
        WHERE date = NEW.order_date
    ) THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Cannot place orders on closed dates.';
    END IF;
END//

DELIMITER ;

-- ----------------------------------- need to change the name of the trigger  variable as it already exists on trigger 5.


-- 10. Trigger to Automatically Update User Points Based on Order Total

DELIMITER //

CREATE TRIGGER after_order_insert_update_points
AFTER INSERT ON orders
FOR EACH ROW
BEGIN
    -- Assuming 1 point per 10 units of order total
    UPDATE users
    SET points = points + FLOOR(NEW.total_amount / 10)
    WHERE id = NEW.customer_id;
END//

DELIMITER ;

-- ----------------------------------- need to change the name of the trigger  variable as it already exists on trigger 1.

