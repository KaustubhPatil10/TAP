USE tflecommerce;

Create event:
-- Create the Stored Procedure
DELIMITER //
CREATE PROCEDURE my_procedure()
BEGIN
	-- SQL commands here
	INSERT INTO products (name, description, price, stock, category_id) VALUES
	('XBOX', 'Latest model with high-resolution', 899, 10, 1);
END //
DELIMITER ;

-- Enable the Event Scheduler
SHOW VARIABLES LIKE 'event_scheduler';
SET GLOBAL event_scheduler = ON;

-- Create an Event to Schedule the stored procedure .
CREATE EVENT my_event
ON SCHEDULE EVERY 1 DAY
STARTS  '2024-10-18 12:52:00'
DO
CALL my_procedure();

SHOW EVENTS;

-- Remove the event from event scheduler
DROP EVENT IF EXISTS my_event;
