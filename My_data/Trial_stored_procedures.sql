-- use Database:
use trial;

-- create a store procedure to (insert values and update) orderdetails:
/*CREATE DEFINER=`root`@`localhost` PROCEDURE `stockavailableupdateinventory`(
	IN orderid INT,
    IN productid INT,
    IN quantity INT
    )
BEGIN
START TRANSACTION;
	INSERT INTO orderdetails(orderid, productid, quantity)
    VALUES( orderid, productid, quantity);
    UPDATE products
    SET stockavailable = stockavailable-quantity
    WHERE products.id = productid;
    COMMIT;
END */

-- to invoke store procedure
call stockavailableupdateinventory(2,9,25);



-- create a store procedure to find area and circumference of circle:
/* CREATE DEFINER=`root`@`localhost` PROCEDURE `calculate_circle_properties`(
	IN radius DECIMAL(10,2),
    OUT area DECIMAL(10,2),
    OUT circumference DECIMAL(10,2)
    )
BEGIN
	SET area = pi() * power(radius , 2);
    SET circumference = 2 * pi() * radius;
END */

-- to invoke stored procedures:
	SET @area = 0;
    SET @circumference = 0;
CALL calculate_circle_properties(6, @area, @circumference);
SELECT @area AS Area, @circumference AS Circumference;




