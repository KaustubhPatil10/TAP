-- use database
use tflecommerce;

-- creating a Function (calculate_tax) for TFLECommerce. 
/*CREATE DEFINER=`root`@`localhost` FUNCTION `calculate_tax`(amount DECIMAL(10,2)) RETURNS decimal(10,2)
    DETERMINISTIC
BEGIN
	RETURN amount * 0.2;
END */

-- to invoke function:-
SELECT calculate_tax(100) AS tax_amount;

-- creating a Function (days_between) for TFLECommerce. 
/* CREATE DEFINER=`root`@`localhost` FUNCTION `days_between`(start_date DATE, end_date DATE) RETURNS int
    DETERMINISTIC
BEGIN
	RETURN datediff(start_date, end_date);
END */


-- to invoke function:-
SELECT days_between('2024-01-12', '2024-01-01') AS days_diff;
